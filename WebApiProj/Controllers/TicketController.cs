using Microsoft.AspNetCore.Mvc;

namespace WebApiProj.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class TicketController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            return Ok("Get All Tickets");
        }

        [HttpGet("{id}")]
        public IActionResult Details(int id)
        {
            return Ok("Ticket detail by Id " + id);
        }

        [HttpPost("{id}")]
        public IActionResult Create(int id)
        {
            return Ok("Ticket Created");
        }

        [HttpPut("{id}")]
        public IActionResult Edit(int id)
        {
            return Ok("Ticket Edit by Id " + id);
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            return Ok("Ticket Delete by Id " + id);
        }

    }
}
