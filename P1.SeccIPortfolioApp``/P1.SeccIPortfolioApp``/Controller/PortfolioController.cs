using Microsoft.AspNetCore.Mvc;
using P1.SeccIPortfolioApp__.Services;

namespace P1.SeccIPortfolioApp__.Controller
{
    [ApiController]
    [Route("api/[controller]")]
    public class PortfolioController : ControllerBase
    {
        private readonly IPortfolioService _service;
        public PortfolioController(IPortfolioService service)
        {
            _service = service;
        }
        [HttpGet]
        public async Task<IActionResult> Get()
        {
            var portfolios = await _service.GetPortfoliosAsync();
            return Ok(portfolios);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(int id)
        {
            var portfolio = await _service.GetPortfolioByIdAsync(id);
            if (portfolio == null)
                return NotFound();
            return Ok(portfolio);
        }
    }
}