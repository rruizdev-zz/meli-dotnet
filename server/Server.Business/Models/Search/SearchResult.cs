using System.Collections.Generic;

namespace Server.Domain.Models.Search
{
    public class SearchResult
    {
        public Author author { get; set; }

        public IList<string> categories { get; set; }

        public IList<SingleItem> items { get; set; }
    }
}