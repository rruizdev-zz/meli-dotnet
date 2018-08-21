using Microsoft.Extensions.Options;
using Server.Domain.Models.Config;
using Server.Infrastructure.Services.Interfaces;
using System.Net.Http;
using System.Threading.Tasks;

namespace Server.Infrastructure.Services
{
    public class ItemService : IItemService
    {
        private readonly HttpClient _httpClient;
        private readonly IOptions<MeliConfig> _config;

        public ItemService(IOptions<MeliConfig> config)
        {
            _httpClient = new HttpClient();
            _config = config;
        }

        public async Task<string> GetSearchResult(string query) 
        {
            var searchUri = string.Format(_config.Value.EndpointSearch, query);

            return await GetResult<string>(searchUri);
        }
        
        public async Task<string> GetDetailResult(string id)
        {
            var itemUri = string.Format(_config.Value.EndpointDetail, id);

            return await GetResult<string>(itemUri);
        }

        public async Task<string> GetDescriptionResult(string id)
        {
            var descriptionUri = string.Format(_config.Value.EndpointDescription, id);

            return await GetResult<string>(descriptionUri);
        }

        private async Task<string> GetResult<T>(string uri) => 
            await _httpClient.GetAsync(uri).Result.Content.ReadAsStringAsync();
    }
}