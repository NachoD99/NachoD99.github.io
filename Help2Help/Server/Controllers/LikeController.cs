using Help2Help.Server.Services.LikeService;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;

namespace Help2Help.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LikeController : ControllerBase
    {
        private readonly ILikeService likeService;
        public LikeController(ILikeService likeService)
        {
            this.likeService = likeService;
        }

        //[HttpGet("{resourceId}")]
        //public async Task<ActionResult<int>> GetLikes(int resourceId)
        //{
        //    var likes = await _likeRepository.GetLikesForResource(resourceId);
        //    return Ok(likes.Count);
        //}

        [HttpPost()]
        public async Task<ActionResult<ServiceResponse<LikeResponseDto>>> CheckLike(LikeResponseDto dto)
        {
            var result = new ServiceResponse<LikeResponseDto>();
            //si no es null, esta autenticado de manera externa
            if (User.FindFirstValue(ClaimTypes.Email) == null)
            {
                try
                {
                    var handler = new JwtSecurityTokenHandler();
                   
                    var jsonToken = handler.ReadJwtToken(dto.Jwt);
                    string jwtEmail = jsonToken.Claims.FirstOrDefault(c => c.Type == "http://schemas.xmlsoap.org/ws/2005/05/identity/claims/name")?.Value;

                    result = await this.likeService.CheckLike(dto.PublicationId, jwtEmail);
                }
                catch (Exception ex)
                {
                    var e = ex.Message;
                }
                
            }
            else
            {
                result = await this.likeService.CheckLike(dto.PublicationId, User.FindFirstValue(ClaimTypes.Email));
            }
            
            return Ok(result);
        }

        //[HttpDelete("{resourceId}")]
        //public async Task<IActionResult> RemoveLike(int resourceId)
        //{
        //    var userId = User.FindFirstValue(ClaimTypes.NameIdentifier);
        //    await _likeRepository.RemoveLike(resourceId, userId);

        //    return NoContent();
        //}
    }
}
