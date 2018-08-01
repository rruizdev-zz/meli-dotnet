using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using Web.Interfaces;
using Web.Models;
using Web.Models.Item;
using Web.Models.Search;

namespace Web.Business
{
    public class ItemLogic : IItemLogic
    {
        public DetailResult ParseItemResult(string itemResult, string descriptionResult)
        {
            var itemObject = JObject.Parse(itemResult);
            var descriptionObject = JObject.Parse(itemResult);

            var itemDetail = new DetailResult 
            {
                author = new Author 
                {
                    name = "Roberto",
                    lastname = "Ruiz"
                }
            };

            return itemDetail;
        }

        public SearchResult ParseSearchResults(string searchResults)
        {
            var searchObject = JObject.Parse(searchResults);

            var newSearchResult = new SearchResult 
            {
                author = new Author
                {
                    name = "Roberto",
                    lastname = "Ruiz"
                }
            };

            return newSearchResult;
        }
    }
}