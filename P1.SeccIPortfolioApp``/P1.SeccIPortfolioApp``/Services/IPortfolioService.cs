using P1.SeccIPortfolioApp__.Models;
namespace P1.SeccIPortfolioApp__.Services
{
    public interface IPortfolioService
    {
        Task<List<Portfolio>> GetPortfoliosAsync();
        Task<Portfolio?> GetPortfolioByIdAsync(string id);
    }
}
