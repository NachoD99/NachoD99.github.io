using Microsoft.AspNetCore.Components.Forms;

namespace Help2Help.Client.Services.AuthService
{
    public interface IAuthService
    {
        Task<ServiceResponse<string>> Register(UserRegister request);
        Task DeleteCookie();
        Task<ServiceResponse<string>> Login(UserLogin request);
        Task<ServiceResponse<bool>> ChangePassword(UserChangePassword request);
        Task<bool> ValidateCode(string request);
        Task<bool> IsUserAuthenticated();

        event Action OnChange;
    }
}
