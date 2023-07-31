using Microsoft.AspNetCore.Components.Forms;

namespace Help2Help.Client.Services.MailingService
{
    public interface IMailingService
    {
        Task<ServiceResponse<string>> SendMail(string email);
        Task<ServiceResponse<string>> SendSupportQuestion(string message);
    }
}
