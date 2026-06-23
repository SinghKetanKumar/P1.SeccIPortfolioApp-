using P1.SeccIPortfolioApp__.Models;
namespace P1.SeccIPortfolioApp__.Services
{
    public class PortfolioService : IPortfolioService
    {
        private readonly List<Portfolio> _portfolios = [
            new Portfolio {
              PortfolioId = 1001,
              Name = "Demo Portfolio"
            },
            new Portfolio {
              PortfolioId = 1002,
              Name = "Growth Portfolio"
            },
             new Portfolio {
              PortfolioId = 1003,
              Name = "Equity Portfolio"
            }
          ];
        public Task<List<Portfolio>> GetPortfoliosAsync()
        {
            return Task.FromResult(_portfolios);
        }
        public Task<Portfolio?> GetPortfolioByIdAsync(int id)
        {
            return Task.FromResult(_portfolios.FirstOrDefault(x => x.PortfolioId == id));
        }
        
       
    }
}
