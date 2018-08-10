using Newtonsoft.Json.Linq;
using Server.Business.Logic.Interfaces;
using Server.Business.Models;
using Server.Business.Models.Detail;
using Server.Business.Models.Search;
using System;
using System.Linq;

namespace Server.Business.Logic
{
    public class ItemLogic : IItemLogic
    {
        public DetailResult ParseItemResult(string itemResult, string descriptionResult)
        {
            var itemObject = JObject.Parse(itemResult);
            var descriptionObject = JObject.Parse(itemResult);

            var item = itemObject.SelectToken("");

            var itemDetail = new DetailResult 
            {
                author = new Author 
                {
                    name = "Roberto",
                    lastname = "Ruiz"
                },
                item = null
            };

            return itemDetail;
        }

        public SearchResult ParseSearchResults(string searchResults)
        {
            var searchObject = JObject.Parse(searchResults);

            var items = searchObject.SelectTokens("results").Children().Select(ConvertirItem);

            var categories = searchObject.SelectTokens("filters").Children()
                .FirstOrDefault(filter => filter.SelectToken("id").Value<string>() == "category")?
                .SelectTokens("values").FirstOrDefault()?.SelectTokens("path_from_root")
                .Select(path => path.SelectToken("name").Value<string>());

            return new SearchResult
            {
                author = new Author
                {
                    name = "",
                    lastname = ""
                },
                categories = categories.ToList(),
                items = items.ToList()
            };
        }

        private SingleItem ConvertirItem(JToken item)
        {
            var price = item.SelectToken("price").Value<string>().Split(".");

            return new SingleItem
            {
                title = item.SelectToken("title").Value<string>(),
                condition = item.SelectToken("condition").Value<string>(),
                free_shipping = item.SelectToken("shipping.free_shipping").Value<bool>(),
                id = item.SelectToken("id").Value<string>(),
                picture = item.SelectToken("thumbnail").Value<string>(),
                price = new Price
                {
                    amount = Convert.ToInt32(price.GetValue(0)),
                    currency = item.SelectToken("currency_id").Value<string>(),
                    decimals = price.Length > 1 ? Convert.ToInt32(price.GetValue(1)) : 0
                }
            };
        }
    }
}