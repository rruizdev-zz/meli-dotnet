using Web.Models.Item;
using Web.Models.Search;

namespace Web.Interfaces
{
    public interface IItemLogic 
    {
        SearchResult ParseSearchResults(string searchResults);

        DetailResult ParseItemResult(string itemResult, string descriptionResult);
    }
}