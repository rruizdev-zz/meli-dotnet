using Microsoft.Extensions.Options;
using Newtonsoft.Json.Linq;
using Server.Application.Tasks.Interfaces;
using Server.Domain.Models;
using Server.Domain.Models.Config;
using Server.Domain.Models.Detail;
using Server.Domain.Models.Search;
using System;
using System.Linq;

namespace Server.Application.Tasks
{
    public class ItemLogic : IItemLogic
    {
        private readonly IOptions<MeliConfig> _config;

        public ItemLogic(IOptions<MeliConfig> config)
        {
            _config = config;
        }

        public DetailResult ParseItemResult(string detailResult, string descriptionResult)
        {
            var itemObject = JObject.Parse(detailResult);
            var descriptionObject = JObject.Parse(detailResult);

            var item = itemObject.SelectToken("");

            var itemDetail = new DetailResult 
            {
                author = new Author 
                {
                    name = _config.Value.AuthorName,
                    lastname = _config.Value.AuthorSurname
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
                    name = _config.Value.AuthorName,
                    lastname = _config.Value.AuthorSurname
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