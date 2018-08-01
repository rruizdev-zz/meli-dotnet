using Web.Interfaces;
using System.Net.Http;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using Web.Models;
using Web.Models.Item;
using Web.Models.Search;
using Web.Business;

namespace Web.Services
{
    public class ItemService : IItemService
    {
        private HttpClient _httpClient;
        private IItemLogic _itemLogic;

        public ItemService()
        {
            _httpClient = new HttpClient();
            _itemLogic = new ItemLogic();
        }

        public async Task<SearchResult> GetSearchResult(string query) 
        {
            var searchResults = await GetResult<string>(string.Concat("https://api.mercadolibre.com/sites/MLA/search?q=", query));
            
            return _itemLogic.ParseSearchResults(searchResults);
        }

        public async Task<DetailResult> GetItemResult(string id)
        {
            var itemResult = await GetResult<string>(string.Concat("https://api.mercadolibre.com/items/​", id));
            var descriptionResult = await GetResult<string>(string.Format("https://api.mercadolibre.com/items/​{0}/description", id));

            return _itemLogic.ParseItemResult(itemResult, descriptionResult);
        }

        private async Task<T> GetResult<T>(string uri) => await _httpClient.GetAsync(uri).Result.Content.ReadAsAsync<T>();
    }
}