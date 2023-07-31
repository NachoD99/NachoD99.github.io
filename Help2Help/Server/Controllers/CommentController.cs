using Help2Help.Server.Services.CommentService;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;

namespace Help2Help.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CommentController : ControllerBase
    {
        private readonly ICommentService commentService;
        public CommentController(ICommentService commentService)
        {
            this.commentService = commentService;
        }

        [HttpPost()]
        public async Task<ActionResult<ServiceResponse<CommentResponseDto>>> AddComment(CommentResponseDto dto)
        {
            var result = new ServiceResponse<CommentResponseDto>();
            //si no es null, esta autenticado de manera externa
            if (User.FindFirstValue(ClaimTypes.Email) == null)
            {
                try
                {
                    var handler = new JwtSecurityTokenHandler();
                   
                    var jsonToken = handler.ReadJwtToken(dto.Jwt);
                    string jwtEmail = jsonToken.Claims.FirstOrDefault(c => c.Type == "http://schemas.xmlsoap.org/ws/2005/05/identity/claims/name")?.Value;

                    result = await this.commentService.AddComment(dto.PublicationId,dto.Message, jwtEmail);
                }
                catch (Exception ex)
                {
                    var e = ex.Message;
                }
                
            }
            else
            {
                result = await this.commentService.AddComment(dto.PublicationId, dto.Message, User.FindFirstValue(ClaimTypes.Email));
            }
            
            return Ok(result);
        }
    }
}
