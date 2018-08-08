using System;
using System.Collections.Generic;
using System.Linq;
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

            var categoryValues = searchObject.SelectTokens("filters")
                .FirstOrDefault(filter => filter.SelectToken("id").Value<string>() == "category")?.SelectTokens("values")
                .FirstOrDefault()?.SelectTokens("path_from_root")
                .Select(category => category.SelectToken("name").Value<string>());

            var itemValues = searchObject.SelectTokens("results").Select(ConvertirEnItem<SingleItem>);

            return new SearchResult
            {
                author = new Author
                {
                    name = "Roberto",
                    lastname = "Ruiz"
                },
                categories = categoryValues.ToList(),
                items = itemValues.ToList()
            };
        }

        private T ConvertirEnItem<T>(JToken itemObject)
        {
            throw new NotImplementedException();
        }
    }
}