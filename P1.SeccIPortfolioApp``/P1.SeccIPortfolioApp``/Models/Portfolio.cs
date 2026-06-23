
namespace P1.SeccIPortfolioApp__.Models
{
    public class Portfolio
    {
        public string Id { get; set; } = "";
        public string FirmId { get; set; } = "";
        public string Name { get; set; } = "";
        public string Status { get; set; } = "";
        public string Currency { get; set; } = "";
        public decimal CurrentValue { get; set; }
        public int Accounts { get; set; }
        public decimal UninvestedCash { get; set; }
    }
}
