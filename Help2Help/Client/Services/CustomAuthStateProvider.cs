using Blazored.LocalStorage;
using Microsoft.AspNetCore.Components.Authorization;
using System.Net.Http.Headers;
using System.Security.Claims;
using System.Text.Json;
using System.Net.Http;
using Microsoft.AspNetCore.Components;

namespace Help2Help.Client
{
    public class CustomAuthStateProvider : AuthenticationStateProvider
    {
        private readonly ILocalStorageService localStorage;
        private readonly HttpClient http;
        public CustomAuthStateProvider(ILocalStorageService localStorage, HttpClient http)
        {
            this.localStorage = localStorage;
            this.http = http;
        }
        public override async Task<AuthenticationState> GetAuthenticationStateAsync()
        {
            var UserInfo = await http.GetFromJsonAsync<User>("api/auth/user");
            if (UserInfo.AuthenticationType == "Google" || UserInfo.AuthenticationType == "Facebook")
            {
                var Identity = UserInfo.IsAuthenticated
                                    ? new ClaimsIdentity(
                                        new[]
                                                {
                                                new Claim(ClaimTypes.Name, UserInfo.FirstName)
                                            }, UserInfo.AuthenticationType)
                : new ClaimsIdentity();
                return new AuthenticationState(new ClaimsPrincipal(Identity));
            }
            else
            {
                string authToken = await this.localStorage.GetItemAsStringAsync("authToken");

                var identity = new ClaimsIdentity();

                this.http.DefaultRequestHeaders.Authorization = null;

                if (!string.IsNullOrEmpty(authToken))
                {
                    try
                    {
                        identity = new ClaimsIdentity(ParseClaimsFromJwt(authToken), "jwt");
                        this.http.DefaultRequestHeaders.Authorization =
                            new AuthenticationHeaderValue("Bearer", authToken.Replace("\"", ""));
                    }
                    catch
                    {
                        await this.localStorage.RemoveItemAsync("AuthToken");
                        identity = new ClaimsIdentity();
                    }
                }

                var user = new ClaimsPrincipal(identity);
                var state = new AuthenticationState(user);

                NotifyAuthenticationStateChanged(Task.FromResult(state));

                return state;
            }
        }

        private byte[] ParseBase64WithoutPadding(string base64)
        {
            switch (base64.Length % 4)
            {
                case 2: base64 += "=="; break;
                case 3: base64 += "="; break;
            }

            return Convert.FromBase64String(base64);
        }

        private IEnumerable<Claim> ParseClaimsFromJwt(string jwt)
        {
            var payload = jwt.Split('.')[1];
            var jsonBytes = ParseBase64WithoutPadding(payload);
            var keyValuePairs = JsonSerializer
                .Deserialize<Dictionary<string, object>>(jsonBytes);

            var claims = keyValuePairs.Select(kvp => new Claim(kvp.Key, kvp.Value.ToString()));

            return claims;
        }
    }
}
