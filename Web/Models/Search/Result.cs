using System.Collections.Generic;
using Web.Models;

namespace Web.Models.Search
{
    public class Result
    {
        public Author author { get; set; }

        public IList<string> categories { get; set; }

        public IList<Item> items { get; set; }
    }
}