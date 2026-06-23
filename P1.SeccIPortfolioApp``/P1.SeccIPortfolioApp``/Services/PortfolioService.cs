using Microsoft.Extensions.Options;
using P1.SeccIPortfolioApp__.Models;
using System.Net.Http.Headers;
using System.Net.Http.Json;

namespace P1.SeccIPortfolioApp__.Services
{
    public class PortfolioService : IPortfolioService
    {
        private readonly HttpClient _httpClient;
        private readonly SecclSettings _settings;

        public PortfolioService(
            HttpClient httpClient,
            IOptions<SecclSettings> settings)
        {
            _httpClient = httpClient;
            _settings = settings.Value;
        }

        private async Task<string> GetAccessTokenAsync()
        {
            var request = new
            {
                firmId = _settings.FirmId,
                id = _settings.Id,
                password = _settings.Password
            };

            var response = await _httpClient.PostAsJsonAsync(
                $"{_settings.BaseUrl}/authenticate",
                request);

            response.EnsureSuccessStatusCode();

            var result =
                await response.Content.ReadFromJsonAsync<TokenResponse>();

            return result?.Data?.Token ?? string.Empty;
        }

        public async Task<List<Portfolio>> GetPortfoliosAsync()
        {
            var token = await GetAccessTokenAsync();

            _httpClient.DefaultRequestHeaders.Authorization =
                new System.Net.Http.Headers.AuthenticationHeaderValue(
                    "Bearer",
                    token);

            var response =
                await _httpClient.GetAsync(
                    $"{_settings.BaseUrl}/portfolio/{_settings.FirmId}?pageSize=100&page=1");

            response.EnsureSuccessStatusCode();

            var result =
                await response.Content.ReadFromJsonAsync<PortfolioApiResponse>();

            return result?.Data ?? new List<Portfolio>();
        }

        public async Task<Portfolio?> GetPortfolioByIdAsync(string id)
        {
            var portfolios = await GetPortfoliosAsync();

            return portfolios.FirstOrDefault(x => x.Id == id);
        }
    }
}