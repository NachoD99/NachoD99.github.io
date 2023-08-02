using Blazored.LocalStorage;
using Help2Help.Shared;
using Microsoft.AspNetCore.Components.Authorization;
using Microsoft.AspNetCore.Components.Forms;
using System.Net.Http.Json;

namespace Help2Help.Client.Services.AuthService
{
    public class AuthService : IAuthService
    {
        private readonly HttpClient http;
        private readonly AuthenticationStateProvider authStateProvider;
        private readonly ILocalStorageService localStorage;

        public AuthService(HttpClient http, AuthenticationStateProvider authStateProvider, ILocalStorageService localStorage)
        {
            this.http = http;
            this.authStateProvider = authStateProvider;
            this.localStorage = localStorage;
        }

        public event Action OnChange;

        public async Task<ServiceResponse<bool>> ChangePassword(UserChangePassword request)
        {
            var result = await this.http.PostAsJsonAsync("api/auth/change-password", request);
            return await result.Content.ReadFromJsonAsync<ServiceResponse<bool>>();
        }

        public async Task<bool> IsUserAuthenticated()
        {
            return (await this.authStateProvider.GetAuthenticationStateAsync()).User.Identity.IsAuthenticated;
        }

        public async Task<ServiceResponse<string>> Login(UserLogin request)
        {
            var result = await this.http.PostAsJsonAsync("api/auth/login", request);
            return await result.Content.ReadFromJsonAsync<ServiceResponse<string>>();
        }

        public async Task<ServiceResponse<string>> Register(UserRegister request)
        {
            var result = await this.http.PostAsJsonAsync("api/auth/register", request);
            return await result.Content.ReadFromJsonAsync<ServiceResponse<string>>();
        }
        public async Task DeleteCookie()
        {
            var code = await this.localStorage.GetItemAsync<string>("code");

            if (code != null) await this.localStorage.RemoveItemAsync("code", null);
        }
        public async Task<bool> ValidateCode(string request)
        {
            var code = await this.localStorage.GetItemAsync<string>("code");

            if (code == request)
            {
                await this.localStorage.RemoveItemAsync("code", null);
                return true;
            }
            else return false;
        }
    }
}
