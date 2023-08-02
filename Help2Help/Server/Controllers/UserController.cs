using Help2Help.Shared.DTO.Token;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Net.Http.Headers;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;

namespace Help2Help.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly IUserService userService;
        private readonly DataContext context;

        public UserController(IUserService userService, DataContext context)
        {
            this.userService = userService;
            this.context = context;
        }

        /*
         * Esta API consulta por la información del usuario logueado en base de datos, se utiliza para
         * mapear información en vistas
         */
        [HttpPost("current-user-info")]
        public async Task<ActionResult<ServiceResponse<UserResponseDTO>>> GetCurrentUserInfo(JwtDTO dto)
        {
            var response = new ServiceResponse<UserResponseDTO>();

            if (User.FindFirstValue(ClaimTypes.Email) == null)
            {
                try
                {
                    var handler = new JwtSecurityTokenHandler();

                    var jsonToken = handler.ReadJwtToken(dto.Jwt);
                    string jwtEmail = jsonToken.Claims.FirstOrDefault(c => c.Type == "http://schemas.xmlsoap.org/ws/2005/05/identity/claims/name")?.Value;

                    response = await userService.GetCurrentUserInfo(jwtEmail);
                }
                catch (Exception ex)
                {
                    var e = ex.Message;
                }
            }
            else
            {
                response = await userService.GetCurrentUserInfo(User.FindFirstValue(ClaimTypes.Email));
            }

            if (!response.Success)
            {
                return BadRequest(response);
            }

            return Ok(response);
        }
        /*
         * Esta API es utilizada principalmente para cuando un usuario se loguea mediante autenticación externa,
         * valido que exista el usuario en bd y en caso contrario lo doy de alta mapeando informacion de los Claims
         * Es llamado cada vez que se pasa del login al Home
         */
        [HttpPost("validate-user-when-external-login")]
        public async Task<ActionResult> SetUserInformation(JwtDTO dto)
        {
            var response = new ServiceResponse<User>();
            if (User.Identity.IsAuthenticated)
            {
                User currentUser = new User();
                currentUser.Email = User.FindFirstValue(ClaimTypes.Email);


                currentUser = await this.context.Users.Where(u => u.Email == currentUser.Email).FirstOrDefaultAsync();
                if (currentUser == null)
                {
                    currentUser = new User();
                    currentUser.Email = User.FindFirstValue(ClaimTypes.Email);
                    currentUser.FirstName = User.FindFirstValue(ClaimTypes.Name).Split(" ").First();
                    currentUser.LastName = User.FindFirstValue(ClaimTypes.Surname);
                    currentUser.AuthenticationType = User.Identity.AuthenticationType == null ? string.Empty : User.Identity.AuthenticationType;
                    currentUser.IsAuthenticated = true;
                    if (User.Identity.AuthenticationType == "Google")
                    {
                        currentUser.ProfilePicture = this.HttpContext.User.Identities.FirstOrDefault().Claims.LastOrDefault().Value;
                    }

                    /*
                    Estos Claims vienen nulos - Ver la forma de recibir esta info junto con la foto de perfil
                    var phone = User.FindFirstValue(ClaimTypes.MobilePhone);
                    var street = User.FindFirstValue(ClaimTypes.StreetAddress);
                    var city = User.FindFirstValue(ClaimTypes.StateOrProvince);
                    var country = User.FindFirstValue(ClaimTypes.Country);
                    var dateOfBirth = User.FindFirstValue(ClaimTypes.DateOfBirth);
                    var zipCode = User.FindFirstValue(ClaimTypes.PostalCode);
                    */

                    try
                    {
                        this.context.Users.Add(currentUser);
                        await this.context.SaveChangesAsync();
                    }
                    catch (Exception ex)
                    {
                        var message = ex.Message;
                        response.Data = currentUser;
                        return BadRequest(response);
                    }
                }
                response.Data = currentUser;
                return Ok(response);
            }
            else
            {
                //Cuando un user se loguea de forma manual no figurará en el User.Identity, llamo al servicio de obtención de datos para usuarios manuales
                response.Data = new User();

                var handler = new JwtSecurityTokenHandler();

                var jsonToken = handler.ReadJwtToken(dto.Jwt);
                string jwtEmail = jsonToken.Claims.FirstOrDefault(c => c.Type == "http://schemas.xmlsoap.org/ws/2005/05/identity/claims/name")?.Value;

                var response1 = await userService.GetCurrentUserInfo(jwtEmail);

                response.Data.NotShowGuide = response1.Data.NotShowGuide;
                response.Data.AuthenticationType = "Manual";
                response.Data.TermsAndConditionsAccepted = true;
                return Ok(response);
            }
        }

        [HttpGet("set-terms-and-conditions-value")]
        public async Task<ActionResult> SetTermsAndConditionsValue()
        {
            if (User.Identity.IsAuthenticated)
            {
                User currentUser = new User();
                currentUser.Email = User.FindFirstValue(ClaimTypes.Email);

                currentUser = await this.context.Users.Where(u => u.Email == currentUser.Email).FirstOrDefaultAsync();
                if (currentUser != null)
                {
                    if (User.Identity.AuthenticationType == "Google" || User.Identity.AuthenticationType == "Facebook")
                    {
                        currentUser.TermsAndConditionsAccepted = true;
                    }

                    try
                    {
                        await this.context.SaveChangesAsync();
                    }
                    catch (Exception ex)
                    {
                        var message = ex.Message;
                        return BadRequest();
                    }
                }
                return Ok();
            }
            else return BadRequest();
        }

        /*
         * Esta API consulta por un usuario distino al logueado en base de datos
         */
        [HttpGet("user-info/{userId}")]
        public async Task<ActionResult<ServiceResponse<UserResponseDTO>>> GetUserInfo(int userId)
        {
            var response = await userService.GetUserInfo(userId);
            if (!response.Success)
            {
                return BadRequest(response);
            }

            return Ok(response);
        }

        [HttpPost("edit-info")]
        public async Task<ActionResult<ServiceResponse<string>>> EditUserInfo(UserResponseDTO request)
        {
            var response = await this.userService.EditUserInfo(request);
            return Ok(response);
        }

        [HttpPost("edit-photo")]
        public async Task<ActionResult<ServiceResponse<string>>> EditProfilePhoto(Shared.Image request)
        {

            var user = await this.context.Users.Where(u => u.Email == User.FindFirstValue(ClaimTypes.Email)).FirstOrDefaultAsync();
            var response = await this.userService.EditProfilePhoto(request, user);
            return Ok(response.Message);
        }

        [HttpPost("check-donar-user")]
        public async Task<ActionResult<ServiceResponse<bool>>> CheckDonarUser(CommentResponseDto dto)
        {
            var result = new ServiceResponse<bool>();
            //si no es null, esta autenticado de manera externa
            if (User.FindFirstValue(ClaimTypes.Email) == null)
            {
                try
                {
                    var handler = new JwtSecurityTokenHandler();

                    var jsonToken = handler.ReadJwtToken(dto.Jwt);
                    string jwtEmail = jsonToken.Claims.FirstOrDefault(c => c.Type == "http://schemas.xmlsoap.org/ws/2005/05/identity/claims/name")?.Value;

                    result = await this.userService.GetDonarUsers(jwtEmail);
                }
                catch (Exception ex)
                {
                    var e = ex.Message;
                }
            }
            else
            {
                result = await this.userService.GetDonarUsers(User.FindFirstValue(ClaimTypes.Email));
            }

            return result;
        }

        [HttpGet("searchsuggestions/{searchText}")]
        public async Task<ActionResult<ServiceResponse<List<UserSearchResultDTO>>>> GetUsersSearchSuggestions(string searchText)
        {
            var result = await this.userService.SearchUsersSuggestions(searchText);
            return Ok(result);
        }

        [HttpGet("approve/{userId}/{transactionID}")]
        public async Task<ActionResult<ServiceResponse<string>>> ApproveUserVerification(int userId, string transactionID)
        {
            var result = await this.userService.ApproveUserVerification(userId, transactionID);
            return Ok(result);
        }

        [HttpGet("disapprove/{userId}/{transactionID}")]
        public async Task<ActionResult<ServiceResponse<string>>> DisapproveUserVerification(int userId, string transactionID)
        {
            var result = await this.userService.DisapproveUserVerification(userId, transactionID);
            return Ok(result);
        }

        [HttpPost("not-show-guide")]
        public async Task<ActionResult<ServiceResponse<string>>> NotShowGuide(LikeResponseDto dto)
        {
            var result = new ServiceResponse<string>();
            if (User.FindFirstValue(ClaimTypes.Email) == null)
            {
                try
                {
                    var handler = new JwtSecurityTokenHandler();

                    var jsonToken = handler.ReadJwtToken(dto.Jwt);
                    string jwtEmail = jsonToken.Claims.FirstOrDefault(c => c.Type == "http://schemas.xmlsoap.org/ws/2005/05/identity/claims/name")?.Value;

                    result = await this.userService.NotShowGuide(jwtEmail);
                }
                catch (Exception ex)
                {
                    var e = ex.Message;
                }
            }
            else
            {
                result = await this.userService.NotShowGuide(User.FindFirstValue(ClaimTypes.Email));
            }

            return result;
        }
    }
}
