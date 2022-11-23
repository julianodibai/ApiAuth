using ApiAuth.Models;
using ApiAuth.Repositories;
using ApiAuth.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Security.Claims;

namespace ApiAuth.Controllers
{
    [ApiController]
    [Route("v1/account")]
    public class UserController : ControllerBase
    {
        [HttpPost]
        [Route("login")]
        [AllowAnonymous]
        public ActionResult<dynamic> Login([FromBody] User model)
        {
            var user = UserRepository.Get(model.UserName, model.Password);

            if (user == null)
                return NotFound("Invalid username or password");

            var token = TokenService.GenerateToken(user);
            user.Password = ""; //esconder a senha

            return Ok(new
            {
                user = user,
                token = token
            });
        }

        [HttpGet]
        [Route("authenticated")]
        [Authorize]
        public string Authenticated() => string.Format($"Authenticated as {User.Identity.Name}");

        [HttpGet]
        [Route("anonymous")]
        [AllowAnonymous]
        public string Anonymous() => "Anônimo";

        [HttpGet]
        [Route("employee")]
        [Authorize(Roles = "employee, manager")]
        public string Employee() => "Funcionário";

        [HttpGet]
        [Route("manager")]
        [Authorize(Roles = "manager")]
        public string Manager() => "Gerente";



    }
}
