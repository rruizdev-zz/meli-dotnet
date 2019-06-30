using MercadoLibre.Backend.Domain.Services.Interfaces;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;

namespace MercadoLibre.Backend.Domain.Services
{
    public class ItemsService : IItemsService
    {
        private readonly HttpClient _httpClient;

        private const string API_GET_ITEMSQUERY = "https://api.mercadolibre.com/sites/MLA/search?q={0}";

        public ItemsService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<IList<string>> GetItemsLike(string query)
        {
            var itemsResponse = await _httpClient.GetStringAsync(string.Format(API_GET_ITEMSQUERY, query));

            return new List<string> { itemsResponse };
        }
    }
}
