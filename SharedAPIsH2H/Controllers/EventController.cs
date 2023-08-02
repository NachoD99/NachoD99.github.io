using Help2Help.Shared;
using Help2Help.Shared.API;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace SharedAPIsH2H.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class EventController : ControllerBase
    {
        private readonly IEventService eventService;
        public EventController(IEventService eventService)
        {
            this.eventService = eventService;
        }

        [HttpGet("get-events")]
        public async Task<ActionResult<ServiceResponse<List<EventModel>>>> Get()
        {
            var response = await this.eventService.GetEvents();
            if (!response.Success)
            {
                return BadRequest(response);
            }

            return Ok(response);
        }

        [HttpGet("get-event-by-id/{id}")]
        public async Task<ActionResult<ServiceResponse<List<EventModel>>>> GetEventById(int id)
        {
            var response = await this.eventService.GetEvent(id);
            if (!response.Success)
            {
                return BadRequest(response);
            }

            return Ok(response);
        }
    }
}
