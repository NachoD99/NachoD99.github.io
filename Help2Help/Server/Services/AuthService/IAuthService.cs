namespace Help2Help.Server.Services.AuthService
{
    public interface IAuthService
    {
        Task<ServiceResponse<string>> Register(User user, string password);
        Task<ServiceResponse<string>> Login(string email, string password);
        Task<ServiceResponse<bool>> ChangePassword(string email, string newPassword);
        //int GetUserId();
        //string GetUserEmail();
        //Task<User> GetUserByEmail(string email);

    }
}
