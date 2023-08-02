using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Security.Claims;

namespace Help2Help.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PublicationController : ControllerBase
    {
        private readonly IPublicationService publicationService;

        public PublicationController(IPublicationService publicationService)
        {
            this.publicationService = publicationService;
        }

        [HttpPost("create")]
        public async Task<ActionResult<ServiceResponse<Publication>>> CreatePublication(PublicationResponseDTO request)
        {
            request.Email = User.FindFirstValue(ClaimTypes.Email);
            var response = await this.publicationService.CreatePublication(request);
            if (!response.Success)
            {
                return BadRequest(response);
            }

            return Ok(response);
        }

        [HttpGet("publications-by-user/{usrId}")]
        public async Task<ActionResult<ServiceResponse<List<PublicationResponseDTO>>>> GetPublicationsByUser(int usrId)
        {
            var result = await publicationService.GetPublicationsByUser(usrId, User.FindFirstValue(ClaimTypes.Email));
            return Ok(result);
        }

        [HttpPost("edit-info")]
        public async Task<ActionResult<ServiceResponse<string>>> EditPublicationInfo(PublicationResponseDTO request)
        {
            var response = await this.publicationService.EditPublicationInfo(request);
            return Ok(response);
        }

        [HttpPost("delete")]
        public async Task<ActionResult<ServiceResponse<string>>> DeletePublication(PublicationResponseDTO request)
        {
            var response = await this.publicationService.DeletePublication(request);
            return Ok(response);
        }
        /*
        /
        //[HttpGet]
        //public async Task<ActionResult<ServiceResponse<List<Publication>>>> GetPublications()
        //{
        //    var result = await publicationService.GetPublicationsAsync();
        //    return Ok(result);
        //}
        ///*
        // También válido
        // [HttpGet]
        // [Route("{productId}")]
        // */
        //[HttpGet("{publicationId}")]//Para recibir un parámetro se debe agregar una ruta
        //public async Task<ActionResult<ServiceResponse<Publication>>> GetPublication(int publicationId)
        //{
        //    var result = await publicationService.GetPublicationAsync(publicationId);
        //    return Ok(result);
        //}

        //[HttpGet("category/{categoryUrl}")]
        //public async Task<ActionResult<ServiceResponse<List<Publication>>>> GetPublicationByCategory(string categoryUrl)
        //{
        //    var result = await publicationService.GetPublicationsByCategory(categoryUrl);
        //    return Ok(result);
        //}

        //[HttpGet("search/{searchText}/{page}")]
        //public async Task<ActionResult<ServiceResponse<PublicationSearchResultDTO>>> SearchPublications(string searchText, int page = 1)
        //{
        //    var result = await publicationService.SearchPublications(searchText, page);
        //    return Ok(result);
        //}

        //[HttpGet("searchsuggestions/{searchText}")]
        //public async Task<ActionResult<ServiceResponse<List<Publication>>>> GetPublicationsSearchSuggestions(string searchText)
        //{
        //    var result = await publicationService.SearchPublicationsSuggestions(searchText);
        //    return Ok(result);
        //}

        //[HttpGet("featured")]
        //public async Task<ActionResult<ServiceResponse<List<Publication>>>> GetFeaturedPublications()
        //{
        //    var result = await publicationService.GetFeaturedPublications();
        //    return Ok(result);
        //}
    }
}
