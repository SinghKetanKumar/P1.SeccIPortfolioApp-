using System.Text.Json.Serialization;

namespace P1.SeccIPortfolioApp__.Models
{
    public class TokenResponse
    {
        public TokenData Data { get; set; } = new();
    }

    public class TokenData
    {
        public string Token { get; set; } = string.Empty;
    }
}
