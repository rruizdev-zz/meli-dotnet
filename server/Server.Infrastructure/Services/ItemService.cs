using Server.Business.Logic;
using Server.Business.Logic.Interfaces;
using Server.Business.Models.Detail;
using Server.Business.Models.Search;
using Server.Infrastructure.Services.Interfaces;
using System.Net.Http;
using System.Threading.Tasks;

namespace Server.Infrastructure.Services
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
            var searchUri = string.Format("https://api.mercadolibre.com/sites/MLA/search?q={0}", query);
            var searchResults = await GetResult<string>(searchUri);
            
            return _itemLogic.ParseSearchResults(searchResults);
        }

        public async Task<DetailResult> GetItemResult(string id)
        {
            var itemUri = string.Format("https://api.mercadolibre.com/items/{0}​", id);
            var itemResult = await GetResult<string>(itemUri);

            var descriptionUri = string.Format("https://api.mercadolibre.com/items/​{0}/description", id);
            var descriptionResult = await GetResult<string>(descriptionUri);

            return _itemLogic.ParseItemResult(itemResult, descriptionResult);
        }

        private async Task<string> GetResult<T>(string uri) => 
            await _httpClient.GetAsync(uri).Result.Content.ReadAsStringAsync();
    }
}