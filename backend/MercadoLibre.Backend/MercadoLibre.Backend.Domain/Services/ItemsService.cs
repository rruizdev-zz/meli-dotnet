using MercadoLibre.Backend.Domain.Models;
using MercadoLibre.Backend.Domain.Services.Interfaces;
using Newtonsoft.Json;
using System.Net.Http;
using System.Threading.Tasks;

namespace MercadoLibre.Backend.Domain.Services
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

        public async Task<ItemByQuery> Search(string query)
        {
            var response = await _httpClient.GetStringAsync(string.Format(API_GET_ITEMSQUERY, query));

            return JsonConvert.DeserializeObject<ItemByQuery>(response);
        }

        public async Task<ItemById> DetailWithDescription(string id)
        {
            var response = await GetDetail(id);

            response.Description = await GetDescription(id);

            return response;
        }

        private async Task<ItemById> GetDetail(string id)
        {
            var response = await _httpClient.GetStringAsync(string.Format(API_GET_ITEMDETAIL, id));

            return JsonConvert.DeserializeObject<ItemById>(response);
        }

        private async Task<ItemDescriptionById> GetDescription(string id)
        {
            var response = await _httpClient.GetStringAsync(string.Format(API_GET_ITEMDESCRIPTION, id));

            return JsonConvert.DeserializeObject<ItemDescriptionById>(response);
        }
    }
}
