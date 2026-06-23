namespace P1.SeccIPortfolioApp__.Client.Models
{
    public class Portfolio
    {
        public string Id { get; set; } = string.Empty;
        public string FirmId { get; set; } = string.Empty;
        public string Name { get; set; } = string.Empty;
        public string Status { get; set; } = string.Empty;
        public string Currency { get; set; } = string.Empty;

        public int Accounts { get; set; }

        public decimal CurrentValue { get; set; }

        public decimal UninvestedCash { get; set; }

        public decimal Growth { get; set; }

        public decimal GrowthPercent { get; set; }

        public decimal AdjustedGrowth { get; set; }

        public decimal AdjustedGrowthPercent { get; set; }
    }
}