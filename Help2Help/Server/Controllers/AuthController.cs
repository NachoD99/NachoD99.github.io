using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authentication.Facebook;
using Microsoft.AspNetCore.Authentication.Google;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Net.Http.Headers;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;

namespace Help2Help.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthController : ControllerBase
    {
        private readonly IAuthService authService;
        private readonly DataContext context;
        private static User LoggedOutUser = new User { IsAuthenticated = false };

        public AuthController(IAuthService authService, DataContext context)
        {
            this.authService = authService;
            this.context = context;
        }

        [HttpPost("register")]
        public async Task<ActionResult<ServiceResponse<string>>> Register(UserRegister request)
        {
            var response = await this.authService.Register(
                new User
                {
                    FirstName = request.FirstName,
                    LastName = request.LastName,
                    Email = request.Email
                },
                request.Password);

            if (!response.Success)
            {
                return BadRequest(response);
            }

            return Ok(response);
        }

        [HttpPost("login")]
        public async Task<ActionResult<ServiceResponse<string>>> Login(UserLogin request)
        {
            var response = await this.authService.Login(request.Email, request.Password);
            if (!response.Success)
            {
                return BadRequest(response);
            }

            return Ok(response);
        }

        #region EXTERNAL HANDLE LOGIN
        [HttpGet("google-login")]
        public async Task GoogleLogin()
        {
            var auth = new AuthenticationProperties
            {
                RedirectUri = "/home"
            };
            await HttpContext.ChallengeAsync(GoogleDefaults.AuthenticationScheme, auth);
        }

        [HttpGet("facebook-login")]
        public async Task<ActionResult> FacebookLogin()
        {
            var auth = new AuthenticationProperties
            {
                RedirectUri = "/home"
            };
            return Challenge(auth, FacebookDefaults.AuthenticationScheme);

        }

        /*Esta API GetUser es utilizada solamente por el CustomAuthStateProvider,
         *toma los datos del usuario del contexto para validar su autenticación y pasa como
         *parámetro el tipo de autenticación para que el CustomAuthStateProvider identifique 
         *el método utilizado
         */
        [HttpGet("user")]
        public User GetUser()
        {
            return User.Identity.IsAuthenticated
            ? new User
            {
                FirstName = User.Identity.Name,
                IsAuthenticated = true,
                AuthenticationType = User.Identity.AuthenticationType
            }
            : LoggedOutUser;
        }
        /*
         * Esta API hace cierre de sesión para logeo externo, elimina la cookie de autenticación
         * Para logueo interno simplemente se elimina el JWT del LocalStorage
         */
        [HttpGet("signout")]
        public async Task<IActionResult> LogOut()
        {
            await HttpContext.SignOutAsync(
            CookieAuthenticationDefaults.AuthenticationScheme);
            return Redirect("~/");
        }
        #endregion

        [HttpPost("change-password")]
        public async Task<ActionResult<ServiceResponse<bool>>> ChangePassword([FromBody] UserChangePassword request)
        {
            //var userId = this.context.Users.FindAsync(request.Email);
            //var userId = User.FindFirstValue(request.Email);
            var response = await this.authService.ChangePassword(request.Email, request.Password);

            if (!response.Success)
            {
                return BadRequest(response);
            }

            return Ok(response);
        }
       
    }
}
