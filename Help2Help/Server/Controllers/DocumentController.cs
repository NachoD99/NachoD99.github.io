using Help2Help.Server.Services.DocumentService;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;

namespace Help2Help.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DocumentController : ControllerBase
    {
        private readonly IDocumentService documentService;
        public DocumentController(IDocumentService documentService)
        {
            this.documentService = documentService;
        }

        [HttpPost("upload")]
        public async Task<ActionResult<ServiceResponse<DocumentResponseDTO>>> UploadDocument(DocumentRequestDTO dto)
        {
            var result = new ServiceResponse<DocumentResponseDTO>();
            //si no es null, esta autenticado de manera externa
            if (User.FindFirstValue(ClaimTypes.Email) == null)
            {
                try
                {
                    var handler = new JwtSecurityTokenHandler();
                   
                    var jsonToken = handler.ReadJwtToken(dto.Jwt);
                    string jwtEmail = jsonToken.Claims.FirstOrDefault(c => c.Type == "http://schemas.xmlsoap.org/ws/2005/05/identity/claims/name")?.Value;

                    result = await this.documentService.UploadDocument(dto, jwtEmail);
                }
                catch (Exception ex)
                {
                    var e = ex.Message;
                }
            }
            else
            {
                result = await this.documentService.UploadDocument(dto, User.FindFirstValue(ClaimTypes.Email));
            }
            
            return Ok(result);
        }

        [HttpGet("get-certificates")]
        public async Task<ActionResult<ServiceResponse<List<GetCertificatesResponseDTO>>>> GetCertificates()
        {
            var result = await this.documentService.GetCertificates();
                
            return Ok(result);
        }

        [HttpGet("get-tutorial-guide")]
        public async Task<ActionResult<ServiceResponse<GetCertificatesResponseDTO>>> DownloadTutorialGuide()
        {
            var result = await this.documentService.DownloadTutorialGuide();

            return Ok(result);
        }

        [HttpGet("get-sworn-declaration")]
        public async Task<ActionResult<ServiceResponse<GetCertificatesResponseDTO>>> DownloadSwornDeclaration()
        {
            var result = await this.documentService.DownloadSwornDeclaration();

            return Ok(result);
        }
    }
}
