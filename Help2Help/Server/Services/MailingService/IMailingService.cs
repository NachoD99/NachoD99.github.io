namespace Help2Help.Server.Services.MailingService
{
    public interface IMailingService
    {
        Task<ServiceResponse<string>> SendMail(string email);
        Task<ServiceResponse<string>> SendSupportQuestion(MailRequestDTO request);
    }
}
