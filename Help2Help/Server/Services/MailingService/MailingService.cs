using Help2Help.Shared;
using System.Net;
using System.Net.Mail;

namespace Help2Help.Server.Services.MailingService
{
    public class MailingService : IMailingService
    {
        private readonly DataContext context;
        private readonly INotificationService notificationService;

        public MailingService(DataContext context, INotificationService notificationService)
        {
            this.context = context;
            this.notificationService = notificationService;
        }
        public async Task<ServiceResponse<string>> SendMail(string email)
        {
            try
            {
                var user = await this.context.Users.FirstOrDefaultAsync(user => user.Email.ToLower().Equals(email.ToLower()));
                if (user != null)
                {
                    if (user.AuthenticationType == "Manual")
                    {
                        MailMessage mail;
                        //string recoveryCode = Guid.NewGuid().ToString();
                        string recoveryCode = string.Empty;
                        Random rnd = new Random();
                        recoveryCode = rnd.NextInt64(100000, 999999).ToString();
                        List<KeyValuePair<string, string>> valuesForView;
                        valuesForView = new List<KeyValuePair<string, string>>();
                        valuesForView.Add(new KeyValuePair<string, string>("#RecoveryCode", recoveryCode));
                        valuesForView.Add(new KeyValuePair<string, string>("#Name", user.FirstName));
                        mail = new MailMessage();
                        mail.IsBodyHtml = true;
                        mail.Priority = MailPriority.High;
                        mail.From = new MailAddress("helptohelp22@gmail.com");
                        mail.Subject = "Recupero de contraseña Help2Help";
                        using (StreamReader reader = new StreamReader("Templates\\RecoveryPasswordMail.html"))
                        {
                            string templateInfo = reader.ReadToEnd();

                            foreach (var item in valuesForView)
                            {
                                templateInfo = templateInfo.Replace(item.Key, item.Value);
                            }

                            mail.Body = templateInfo;
                        }

                        mail.To.Add(user.Email);

                        using (SmtpClient smtpClient = new SmtpClient("smtp.gmail.com", 587))
                        {
                            smtpClient.EnableSsl = true;
                            smtpClient.DeliveryMethod = SmtpDeliveryMethod.Network;
                            smtpClient.UseDefaultCredentials = false;
                            smtpClient.Credentials = new NetworkCredential("helptohelp22@gmail.com", "zyaqpeisxmibqiqs");
                            smtpClient.Send(mail);
                        }
                        return new ServiceResponse<string> { Data = recoveryCode, Success = true, Message = "Mail enviado!" };
                    }
                    else return new ServiceResponse<string> { Data = string.Empty, Success = true, Message = "El usuario está autenticado de forma externa. No requiere cambio de contraseña. Ingrese normalmente a través de su cuenta de Google o Facebook según corresponda." };
                }
                else return new ServiceResponse<string> { Data = string.Empty, Success = true, Message = "Usuario no encontrado." };
            }
            catch (Exception ex)
            {
                return new ServiceResponse<string> { Data = string.Empty, Success = false, Message = ex.Message };
            }
        }

        public async Task<ServiceResponse<string>> SendSupportQuestion(MailRequestDTO request)
        {
            try
            {
                var user = await this.context.Users.FirstOrDefaultAsync(user => user.Email.ToLower().Equals(request.Jwt.ToLower()));
                
                MailMessage mail;
                
                List<KeyValuePair<string, string>> valuesForView;
                valuesForView = new List<KeyValuePair<string, string>>();
                valuesForView.Add(new KeyValuePair<string, string>("#Message", request.Message));
                valuesForView.Add(new KeyValuePair<string, string>("#Name", user.FirstName));
                mail = new MailMessage();
                mail.IsBodyHtml = true;
                mail.Priority = MailPriority.High;
                mail.From = new MailAddress("helptohelp22@gmail.com");
                mail.Subject = "Casilla de soporte Help2Help";
                using (StreamReader reader = new StreamReader("Templates\\SendQuestion.html"))
                {
                    string templateInfo = reader.ReadToEnd();

                    foreach (var item in valuesForView)
                    {
                        templateInfo = templateInfo.Replace(item.Key, item.Value);
                    }

                    mail.Body = templateInfo;
                }

                mail.To.Add("helptohelp22@gmail.com");

                using (SmtpClient smtpClient = new SmtpClient("smtp.gmail.com", 587))
                {
                    smtpClient.EnableSsl = true;
                    smtpClient.DeliveryMethod = SmtpDeliveryMethod.Network;
                    smtpClient.UseDefaultCredentials = false;
                    smtpClient.Credentials = new NetworkCredential("helptohelp22@gmail.com", "zyaqpeisxmibqiqs");
                    smtpClient.Send(mail);
                }
                return new ServiceResponse<string> { Data = "Su consulta ha sido enviada", Success = true, Message = "true" };
                
            }
            catch (Exception ex)
            {
                return new ServiceResponse<string> { Data = "Ha ocurrido un error. Intente más tarde", Success = true, Message = "false" };
            }
        }
    }
}
