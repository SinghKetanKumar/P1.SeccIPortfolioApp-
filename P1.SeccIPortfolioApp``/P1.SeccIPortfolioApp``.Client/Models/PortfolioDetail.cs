namespace P1.SeccIPortfolioApp__.Client.Models
{
    public class PortfolioDetail
    {
        public string PortfolioId { get; set; } = string.Empty;

        public string ProductType { get; set; } = string.Empty;

        public decimal Valuation { get; set; }

        public decimal CashBalance { get; set; }
    }
}
