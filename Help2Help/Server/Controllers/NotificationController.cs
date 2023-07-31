using Help2Help.Server.Services.NotificationService;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;

namespace Help2Help.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class NotificationController : ControllerBase
    {
        private readonly INotificationService notificationService;
        public NotificationController(INotificationService notificationService)
        {
            this.notificationService = notificationService;
        }

        [HttpPost()]
        public async Task<ActionResult<ServiceResponse<NotificationResponseDto>>> AddNotification(NotificationResponseDto dto)
        {
            var result = new ServiceResponse<List<NotificationResponseDto>>();
            //si no es null, esta autenticado de manera externa
            if (User.FindFirstValue(ClaimTypes.Email) == null)
            {
                try
                {
                    var handler = new JwtSecurityTokenHandler();
                   
                    var jsonToken = handler.ReadJwtToken(dto.Jwt);
                    string jwtEmail = jsonToken.Claims.FirstOrDefault(c => c.Type == "http://schemas.xmlsoap.org/ws/2005/05/identity/claims/name")?.Value;

                    result = await this.notificationService.GetNotifications(jwtEmail);
                }
                catch (Exception ex)
                {
                    var e = ex.Message;
                }
                
            }
            else
            {
                result = await this.notificationService.GetNotifications(User.FindFirstValue(ClaimTypes.Email));
            }
            
            return Ok(result);
        }

        [HttpPost("add-event-notification")]
        public async Task<ActionResult<ServiceResponse<NotificationResponseDto>>> AddDeadlineEventNotification(NotificationResponseDto dto)
        {
            var result = new ServiceResponse<NotificationResponseDto>();
            //si no es null, esta autenticado de manera externa
            if (User.FindFirstValue(ClaimTypes.Email) == null)
            {
                try
                {
                    var handler = new JwtSecurityTokenHandler();

                    var jsonToken = handler.ReadJwtToken(dto.Jwt);
                    string jwtEmail = jsonToken.Claims.FirstOrDefault(c => c.Type == "http://schemas.xmlsoap.org/ws/2005/05/identity/claims/name")?.Value;

                    result = await this.notificationService.AddDeadlineEventNotification(jwtEmail);
                }
                catch (Exception ex)
                {
                    var e = ex.Message;
                }
            }
            else
            {
                result = await this.notificationService.AddDeadlineEventNotification(User.FindFirstValue(ClaimTypes.Email));
            }

            return Ok(result);
        }
    }
}
