namespace P1.SeccIPortfolioApp__.Models
{
    public class PortfolioApiResponse
    {
        public List<Portfolio> Data { get; set; } = new();
        public PortfolioMeta Meta { get; set; } = new();
    }

    public class PortfolioMeta
    {
        public int Count { get; set; }
        public int Page { get; set; }
        public int PageSize { get; set; }
    }
}
