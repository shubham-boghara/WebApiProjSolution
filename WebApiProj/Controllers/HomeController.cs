using Microsoft.AspNetCore.Mvc;

namespace WebApiProj.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class HomeController : ControllerBase
    {
        [HttpGet]
        public IActionResult Index()
        {
            return Ok("Ok Works Fine :)");
        }


        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {
            return Ok("Ticket Result has Id " + id);
        }

        [HttpPut("{id}")]
        public IActionResult Update(int id)
        {
            return Ok("Update on Id" + id);
        }

        [HttpDelete("{id}")]
        public IActionResult DeleteById(int id)
        {
            return Ok("Delete Id is" + id);
        }
        
    }
}
