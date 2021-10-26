using MatData.Models;
using MatData.Services.Token;
using MatData.Services.User;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace MatData.Controllers
{
    [Route("api/v1/[controller]")]
    [ApiController]
    public class LoginController : ControllerBase
    {
        private readonly IUserService _userService;
        private readonly ITokenService _tokenService;
        public LoginController(IUserService userService, ITokenService tokenService)
        {
            _userService = userService;
            _tokenService = tokenService;
        }

        [HttpPost]
        [Route("login")]
        public ActionResult<dynamic> Authenticate([FromBody] User model)
        {
            var user =  _userService.Get(model.Username, model.Password);

            if (user == null)
                return NotFound(new { message = "Usuário ou senhas inválidos" });


            var token = _tokenService.GenerateToken(user);

            user.Password = "";

            return new
            {
                user = user,
                token = token
            };
        }
    }
}
