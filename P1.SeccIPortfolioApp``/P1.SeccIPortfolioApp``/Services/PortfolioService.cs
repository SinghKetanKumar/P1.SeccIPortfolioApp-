using P1.SeccIPortfolioApp__.Models;
namespace P1.SeccIPortfolioApp__.Services
{
    public class PortfolioService : IPortfolioService
    {
        public List<Portfolio> GetPortfolios()
        {
            return new List<Portfolio>
        {
            new Portfolio
            {
                PortfolioId = 1001,
                Name = "Demo Portfolio",
               
            }
        };
        }
    }
}
