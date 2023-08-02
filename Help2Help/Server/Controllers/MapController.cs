using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Help2Help.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MapController : ControllerBase
    {
        private readonly IMapService mapService;
        public MapController(IMapService mapService)
        {
            this.mapService = mapService;
        }

        [HttpPost("markers")]
        public async Task<ActionResult<ServiceResponse<List<MapResponseDTO>>>> GetMapMarkers()
        {
            var result = await this.mapService.GetMapMarkers();

            return Ok(result);
        }

        [HttpGet("get-provinces")]
        public async Task<ActionResult<bool>> SaveProvinces()
        {
            try
            {
                await this.mapService.SaveProvincesInDb();

                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest();
            }
            
        }

        [HttpGet("save-cities")]
        public async Task<ActionResult<bool>> SaveCities()
        {
            try
            {
                await this.mapService.SaveCitiesInDb();

                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest();
            }
            
        }

        [HttpGet("provinces")]
        public async Task<ActionResult<ServiceResponse<List<ProvinceResponseDTO>>>> GetProvinces()
        {
            try
            {
                var response = await this.mapService.GetProvinces();

                return Ok(response);
            }
            catch (Exception ex)
            {
                return BadRequest();
            }
        }

        [HttpGet("cities/{provinceId}")]
        public async Task<ActionResult<ServiceResponse<List<CityResponseDTO>>>> GetCities(string provinceId)
        {
            try
            {
                var response = await this.mapService.GetCities(provinceId);

                return Ok(response);
            }
            catch (Exception ex)
            {
                return BadRequest();
            }
        }
    }
}
