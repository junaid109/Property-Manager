using Microsoft.AspNetCore.Mvc;

namespace PropertyManager.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PropertyAPIController: ControllerBase
    {
        public PropertyAPIController()
        {
        }

        [HttpGet(Name = "GetProperties")]
        public IActionResult Get()
        {
            return Ok();
        }
    }
}
