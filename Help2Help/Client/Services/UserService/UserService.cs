using Blazored.LocalStorage;
using Help2Help.Shared;
using Help2Help.Shared.DTO.Token;
using Microsoft.AspNetCore.Components.Authorization;
using Microsoft.AspNetCore.Components.Forms;
using System.Net.Http.Json;

namespace Help2Help.Client.Services.UserService
{
    public class UserService : IUserService
    {
        private readonly HttpClient http;
        private readonly AuthenticationStateProvider authStateProvider;
        private readonly ILocalStorageService localStorage;

        public UserService(HttpClient http, AuthenticationStateProvider authStateProvider, ILocalStorageService localStorage)
        {
            this.http = http;
            this.authStateProvider = authStateProvider;
            this.localStorage = localStorage;
        }

        public User UserProfile { get; set; } = new User();
        public UserResponseDTO UserDTO { get; set; } = new UserResponseDTO();

        public event Action OnChange;

        public async Task GetCurrentUserInfo()
        {
            string token = await this.localStorage.GetItemAsync<string>("authToken");

            JwtDTO dto = new JwtDTO()
            {
                Jwt = token != null ? token : string.Empty
            };

            var response = await this.http.PostAsJsonAsync("api/user/current-user-info", dto);

            var result = await response.Content.ReadFromJsonAsync<ServiceResponse<UserResponseDTO>>();

            if (result != null && result.Data != null) UserDTO = result.Data;
        }

        public async Task<ServiceResponse<User>> SetUserInformationWhenExternalLogin()
        {
            string token = await this.localStorage.GetItemAsync<string>("authToken");
            var request = new JwtDTO() { Jwt = token != null ? token : string.Empty };
            var result = await http.PostAsJsonAsync("api/user/validate-user-when-external-login", request);
            return await result.Content.ReadFromJsonAsync<ServiceResponse<User>>();
        }
        public async Task SetTermsAndConditionsValue()
        {
            await http.GetFromJsonAsync<ServiceResponse<User>>("api/user/set-terms-and-conditions-value");
        }
        public async Task<ServiceResponse<UserResponseDTO>> GetUserInfo(int userId)
        {

            var result = await http.GetFromJsonAsync<ServiceResponse<UserResponseDTO>>($"api/user/user-info/{userId}");
            if (result != null && result.Data != null) return result;
            else return new ServiceResponse<UserResponseDTO>();
        }
        public async Task<ServiceResponse<string>> EditUserInfo(UserResponseDTO request)
        {
            var result = await this.http.PostAsJsonAsync("api/user/edit-info", request);
            return await result.Content.ReadFromJsonAsync<ServiceResponse<string>>();
        }
        public async Task<ServiceResponse<string>> EditProfilePhoto(Help2Help.Shared.Image request)
        {
            try
            {
                var result = await this.http.PostAsJsonAsync("api/user/edit-photo", request);
                return await result.Content.ReadFromJsonAsync<ServiceResponse<string>>();

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine(ex.InnerException);
                return new ServiceResponse<string>();
            }
        }

        public async Task<List<UserSearchResultDTO>> GetUsersSearchSuggestions(string searchText)
        {
            var result = await this.http
                .GetFromJsonAsync<ServiceResponse<List<UserSearchResultDTO>>>($"api/user/searchsuggestions/{searchText}");

            return result.Data;
        }

        public async Task<bool> CheckDonarUser()
        {
            string token = await this.localStorage.GetItemAsync<string>("authToken");
            var request = new CommentResponseDto()
            {
                Jwt = token != null ? token : string.Empty
            };
            var response = await this.http.PostAsJsonAsync("api/user/check-donar-user", request);

            var isFromDonar = await response.Content.ReadFromJsonAsync<ServiceResponse<bool>>();

            return isFromDonar.Data;
        }

        public async Task<string> ApproveUserVerification(int userId, string transactionID)
        {
            var result = await this.http
                .GetFromJsonAsync<ServiceResponse<string>>($"api/user/approve/{userId}/{transactionID}");

            return result.Data;
        }

        public async Task<string> DisapproveUserVerification(int userId, string transactionID)
        {
            var result = await this.http
                .GetFromJsonAsync<ServiceResponse<string>>($"api/user/disapprove/{userId}/{transactionID}");

            return result.Data;
        }

        public async Task NotShowGuide()
        {
            string token = await this.localStorage.GetItemAsync<string>("authToken");
            var request = new LikeResponseDto() { Jwt = token != null ? token : string.Empty };
            var response = await this.http.PostAsJsonAsync("api/user/not-show-guide", request);

            var publication = await response.Content.ReadFromJsonAsync<ServiceResponse<string>>();
        }
    }
}
