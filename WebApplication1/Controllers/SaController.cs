using Microsoft.AspNetCore.Mvc;
using WebApplication1.Model;

namespace WebApplication1.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class SaController : ControllerBase
    {
        [HttpGet("get")]
        public ActionResult Get([FromQuery]Person person)
        {

            return Ok("pong");
        }
        [HttpPost("gett")]
        public ActionResult Gett([FromBody] Person person)
        {
            return BadRequest();
            return Ok(new Person
            {
                DateOfBirth = "1400/02/01",
                Family = "Davoody",
                Name = "Soheil"
            });
        }
    }
}
