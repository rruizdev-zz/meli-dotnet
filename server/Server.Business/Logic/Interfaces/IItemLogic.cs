using Server.Business.Models.Detail;
using Server.Business.Models.Search;

namespace Server.Business.Logic.Interfaces
{
    public interface IItemLogic 
    {
        SearchResult ParseSearchResults(string searchResults);

        DetailResult ParseItemResult(string itemResult, string descriptionResult);
    }
}