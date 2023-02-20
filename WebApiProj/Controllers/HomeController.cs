using Microsoft.AspNetCore.Mvc;

namespace WebApiProj.Controllers
{
    [ApiController]
    [Route("/")]
    public class HomeController : ControllerBase
    {
        [HttpGet]
        public IActionResult Index()
        {
            return Ok("Ok Works Fine :)");
        }
    }
}
