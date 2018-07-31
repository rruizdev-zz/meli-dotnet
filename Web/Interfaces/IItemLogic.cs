using Web.Models;

namespace Web.Interfaces
{
    public interface IItemLogic 
    {
        SearchResult ParseSearchResults(string searchResults);

        ItemResult ParseItemResult(string itemResult, string descriptionResult);
    }
}