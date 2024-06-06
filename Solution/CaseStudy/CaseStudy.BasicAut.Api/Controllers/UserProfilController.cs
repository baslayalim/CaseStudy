using CaseStudy.BasicAut.Api.Model;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CaseStudy.BasicAut.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserProfilController : ControllerBase
    {
        private readonly IUserService _userService;
        public UserProfilController(IUserService userService)
        {
            _userService = userService; 
        }

        [HttpPost("login")]
        public IActionResult Login(LoginModel model)
        {
            var user = _userService.Login(model.Username, model.Password);

            if (user == null)
            {
                return NotFound("Kullanıcı adı veya şifre yanlış!");
            }

            user.Password = "";

            return Ok(user);
        }

        [HttpGet("profile")]
        [Authorize]
        public IActionResult Profile()
        {
            return Ok("Profile");
        }


        [HttpGet("profile2")]
        public IActionResult Profile2()
        {
            return Ok("Profile");
        }



    }
}
