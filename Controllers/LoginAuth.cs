using Microsoft.AspNetCore.Mvc;

namespace ApiAuth.Controllers
{
    [ApiController]
    [Route("/api/v1")]
    public class LoginAuth : ControllerBase
    {
        [HttpGet]
        //[Authorize]
        [Route("login/{id}")]
        public async Task<IActionResult> GetByIdAsync(long id)
        {
            return Ok();
        }
    }
}
