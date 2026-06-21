using Microsoft.AspNetCore.Mvc;

namespace P1.SeccIPortfolioApp__.Controller
{
    [ApiController]
    [Route("api/[controller]")]
    public class PortfolioController : ControllerBase
    {
        [HttpGet]
        public IActionResult Get()
        {
            return Ok(new List<object>
            {
                new
                {
                    PortfolioId = 1001,
                    Name = "Demo Portfolio"
                }
            });
        }

        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {
            return Ok(new
            {
                PortfolioId = id,
                Name = "Demo Portfolio"
            });
        }
    }
}