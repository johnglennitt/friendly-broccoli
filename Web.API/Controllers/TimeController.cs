using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Web.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TimeController : ControllerBase
    {
        /// <summary>
        /// returns the authoritative time at the moment the request was processed
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public async Task<IActionResult> GetAuthoritativeTimeUtc()
        {
            return Ok(new { time = DateTime.UtcNow });
        }
    }
}
