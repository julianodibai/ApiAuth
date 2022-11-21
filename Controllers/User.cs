using Microsoft.AspNetCore.Mvc;

namespace ApiAuth.Controllers
{
    [ApiController]
    [Route("/api/v1")]
    public class User : ControllerBase
    {
        [HttpGet]
        //[Authorize]
        [Route("user/{id}")]
        public async Task<IActionResult> GetByIdAsync(long id)
        {
            return Ok();
        }
    }
}
