using System.Net.Http;
using System.Threading.Tasks;
using MercadoLibre.Backend.Application.Services.Interfaces;
using MercadoLibre.Backend.Domain.Models.Items;
using Newtonsoft.Json;

namespace MercadoLibre.Backend.Application.Services
{
    public class ItemsService : IItemsService
    {
        private readonly HttpClient _httpClient;

        private const string API_GET_ITEMSQUERY = "https://api.mercadolibre.com/sites/MLA/search?q={0}";

        private const string API_GET_ITEMDETAIL = "https://api.mercadolibre.com/items/{0}";

        private const string API_GET_ITEMDESCRIPTION = "https://api.mercadolibre.com/items/{0}/description";

        public ItemsService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<Search> Search(string query)
        {
            var response = await _httpClient.GetStringAsync(string.Format(API_GET_ITEMSQUERY, query));

            return JsonConvert.DeserializeObject<Search>(response);
        }

        public async Task<Detail> DetailWithDescription(string id)
        {
            var response = await GetDetail(id);

            response.Description = await GetDescription(id);

            return response;
        }

        private async Task<Detail> GetDetail(string id)
        {
            var response = await _httpClient.GetStringAsync(string.Format(API_GET_ITEMDETAIL, id));

            return JsonConvert.DeserializeObject<Detail>(response);
        }

        private async Task<Description> GetDescription(string id)
        {
            var response = await _httpClient.GetStringAsync(string.Format(API_GET_ITEMDESCRIPTION, id));

            return JsonConvert.DeserializeObject<Description>(response);
        }
    }
}
