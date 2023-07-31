using Microsoft.AspNetCore.Components.Forms;

namespace Help2Help.Client.Services.UserService
{
    public interface IUserService
    {
        User UserProfile { get; set; }
        UserResponseDTO UserDTO { get; set; }
        
        Task GetCurrentUserInfo();
        Task<ServiceResponse<UserResponseDTO>> GetUserInfo(int userId);
        Task<List<UserSearchResultDTO>> GetUsersSearchSuggestions(string searchText);
        Task<ServiceResponse<User>> SetUserInformationWhenExternalLogin();
        Task SetTermsAndConditionsValue();
        Task<ServiceResponse<string>> EditUserInfo(UserResponseDTO request);
        Task<ServiceResponse<string>> EditProfilePhoto(Help2Help.Shared.Image request);
        Task<bool> CheckDonarUser();
        Task<string> ApproveUserVerification(int userId, string transactionID);
        Task<string> DisapproveUserVerification(int userId, string transactionID);
        Task NotShowGuide();

        event Action OnChange;
    }
}
