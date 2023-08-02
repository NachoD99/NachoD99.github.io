using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;

namespace Help2Help.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EventController : ControllerBase
    {
        private readonly IEventService eventService;
        public EventController(IEventService eventService)
        {
            this.eventService = eventService;
        }

        [HttpPost("categories")]
        public async Task<ActionResult<ServiceResponse<List<EventCategory>>>> GetEventCategories()
        {
            var result = await this.eventService.GetEventCategories();

            return Ok(result);
        }

        [HttpGet("get-event-by-user-id/{userId}")]
        public async Task<ActionResult<ServiceResponse<List<EventResponseDTO>>>> GetEventByUserId(int userId)
        {
            var response = await this.eventService.GetEventByUserId(userId);
            if (!response.Success)
            {
                return BadRequest(response);
            }

            return Ok(response);
        }

        [HttpPost("new")]
        public async Task<ActionResult<ServiceResponse<bool>>> CreateEvent(EventResponseDTO request)
        {
            request.Email = User.FindFirstValue(ClaimTypes.Email);
            var response = await this.eventService.CreateEvent(request);
            if (!response.Success)
            {
                return BadRequest(response);
            }

            return Ok(response);
        }

        [HttpPost("edit-info")]
        public async Task<ActionResult<ServiceResponse<string>>> EditEventInfo(EventResponseDTO request)
        {
            var response = await this.eventService.EditEventInfo(request);
            return Ok(response);
        }

        [HttpPost("delete")]
        public async Task<ActionResult<ServiceResponse<string>>> DeleteEvent(EventResponseDTO request)
        {
            var response = await this.eventService.DeleteEvent(request);
            return Ok(response);
        }

        [HttpPost("report")]
        public async Task<ActionResult<ServiceResponse<string>>> ReportEvent(ReportEventResponseDto dto)
        {
            var result = new ServiceResponse<string>();
            if (User.FindFirstValue(ClaimTypes.Email) == null)
            {
                try
                {
                    var handler = new JwtSecurityTokenHandler();

                    var jsonToken = handler.ReadJwtToken(dto.Jwt);
                    string jwtEmail = jsonToken.Claims.FirstOrDefault(c => c.Type == "http://schemas.xmlsoap.org/ws/2005/05/identity/claims/name")?.Value;

                    result = await this.eventService.ReportEvent(dto.EventId, jwtEmail);
                }
                catch (Exception ex)
                {
                    var e = ex.Message;
                }

            }
            else
            {
                result = await this.eventService.ReportEvent(dto.EventId, User.FindFirstValue(ClaimTypes.Email));
            }

           if (!result.Success)
            {
                return BadRequest(result);
            }

            return Ok(result);
        }

        [HttpPost("synchronize")]
        public async Task<ActionResult<ServiceResponse<string>>> SynchronizeDonarEvents(ReportEventResponseDto dto)
        {
            var result = new ServiceResponse<string>();
            if (User.FindFirstValue(ClaimTypes.Email) == null)
            {
                try
                {
                    var handler = new JwtSecurityTokenHandler();

                    var jsonToken = handler.ReadJwtToken(dto.Jwt);
                    string jwtEmail = jsonToken.Claims.FirstOrDefault(c => c.Type == "http://schemas.xmlsoap.org/ws/2005/05/identity/claims/name")?.Value;

                    result = await this.eventService.SynchronizeDonarEvents(jwtEmail);
                }
                catch (Exception ex)
                {
                    var e = ex.Message;
                }

            }
            else
            {
                result = await this.eventService.SynchronizeDonarEvents(User.FindFirstValue(ClaimTypes.Email));
            }

            if (!result.Success)
            {
                return BadRequest(result);
            }

            return Ok(result);
        }
    }
}
