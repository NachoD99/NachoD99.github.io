using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authentication.Facebook;
using Microsoft.AspNetCore.Authentication.Google;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Net.Http.Headers;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;

namespace Help2Help.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MailingController : ControllerBase
    {
        private readonly IMailingService mailingService;
        private readonly DataContext context;

        public MailingController(IMailingService mailingService, DataContext context)
        {
            this.mailingService = mailingService;
            this.context = context;
        }

        [HttpGet("send-mail/{email}")]
        public async Task<ActionResult<ServiceResponse<string>>> SendMail(string email)
        {
            var response = await mailingService.SendMail(email);
            if (!response.Success)
            {
                return BadRequest(response);
            }
            return Ok(response);
        }

        [HttpPost("send-question")]
        public async Task<ActionResult<ServiceResponse<string>>> SendSupportQuestion(MailRequestDTO request)
        {
            var result = new ServiceResponse<string>();
            if (User.FindFirstValue(ClaimTypes.Email) == null)
            {
                try
                {
                    var handler = new JwtSecurityTokenHandler();

                    var jsonToken = handler.ReadJwtToken(request.Jwt);
                    string jwtEmail = jsonToken.Claims.FirstOrDefault(c => c.Type == "http://schemas.xmlsoap.org/ws/2005/05/identity/claims/name")?.Value;
                    request.Jwt = jwtEmail;
                    result = await this.mailingService.SendSupportQuestion(request);
                }
                catch (Exception ex)
                {
                    var e = ex.Message;
                }
            }
            else
            {
                request.Jwt = User.FindFirstValue(ClaimTypes.Email);
                result = await this.mailingService.SendSupportQuestion(request);
            }

            if (!result.Success)
            {
                return BadRequest(result);
            }
            return Ok(result);
        }
    }
}
