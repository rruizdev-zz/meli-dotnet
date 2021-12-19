using System.Net.Http;
using System.Threading.Tasks;
using Meli.Backend.Application.Services.Interfaces;
using Meli.Backend.Domain.Models.Items;
using Newtonsoft.Json;

namespace Meli.Backend.Application.Services
{
    public class ItemsService : IItemsService
    {
        private readonly HttpClient _httpClient;

        public ItemsService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<Search> Search(string query, string url)
        {
            var response = await _httpClient.GetStringAsync(string.Format(url, query));

            return JsonConvert.DeserializeObject<Search>(response);
        }

        public async Task<Detail> DetailWithDescription(string id, string urlDetail, string urlDescription)
        {
            var response = await GetDetail(id, urlDetail);

            response.Description = await GetDescription(id, urlDescription);

            return response;
        }

        private async Task<Detail> GetDetail(string id, string url)
        {
            var response = await _httpClient.GetStringAsync(string.Format(url, id));

            return JsonConvert.DeserializeObject<Detail>(response);
        }

        private async Task<Description> GetDescription(string id, string url)
        {
            var response = await _httpClient.GetStringAsync(string.Format(url, id));

            return JsonConvert.DeserializeObject<Description>(response);
        }
    }
}
