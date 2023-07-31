using Microsoft.AspNetCore.Mvc;

namespace Help2Help.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AnalyticController : ControllerBase
    {
        private readonly IAnalyticService analyticService;
        private readonly DataContext context;

        public AnalyticController(IAnalyticService analyticService, DataContext context)
        {
            this.analyticService = analyticService;
            this.context = context;
        }

        [HttpGet("get-analytics")]
        public async Task<ActionResult<ServiceResponse<Dictionary<string, double>>>> GetAnalyticCategoriesData()
        {
            var response = await analyticService.GetAnalyticCategoriesData();
            if (!response.Success)
            {
                return BadRequest(response);
            }

            return Ok(response);
        }
    }
}
