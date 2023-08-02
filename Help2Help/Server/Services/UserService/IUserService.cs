namespace Help2Help.Server.Services.UserService
{
    public interface IUserService
    {
        Task<bool> UserExists(string email);
        Task<ServiceResponse<UserResponseDTO>> GetCurrentUserInfo(string email);
        Task<ServiceResponse<UserResponseDTO>> GetUserInfo(int userId);
        Task<ServiceResponse<string>> EditUserInfo(UserResponseDTO user);
        Task<ServiceResponse<string>> EditProfilePhoto(Shared.Image request, User user);
        Task<ServiceResponse<bool>> GetDonarUsers(string userEmail);
        Task<ServiceResponse<List<UserSearchResultDTO>>> SearchUsersSuggestions(string searchText);
        Task<ServiceResponse<string>> ApproveUserVerification(int userId, string transactionID);
        Task<ServiceResponse<string>> DisapproveUserVerification(int userId, string transactionID);
        Task<ServiceResponse<string>> NotShowGuide(string email);
    }
}
