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
            try
            {
                var portfolios =
                    await _service.GetPortfoliosAsync();

                return Ok(portfolios);
            }
            catch (Exception ex)
            {
                return StatusCode(
                    StatusCodes.Status500InternalServerError,
                    new
                    {
                        Message = "An error occurred while retrieving portfolios.",
                        Error = ex.Message
                    });
            }
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(string id)
        {
            try
            {
                var portfolio =
                    await _service.GetPortfolioByIdAsync(id);

                if (portfolio == null)
                {
                    return NotFound($"Portfolio '{id}' not found.");
                }

                return Ok(portfolio);
            }
            catch (Exception ex)
            {
                return StatusCode(
                    StatusCodes.Status500InternalServerError,
                    new
                    {
                        Message = "An error occurred while retrieving the portfolio.",
                        Error = ex.Message
                    });
            }
        }
    }
}