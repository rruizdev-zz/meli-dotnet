using Server.Domain.Models.Detail;
using Server.Domain.Models.Search;

namespace Server.Application.Tasks.Interfaces
{
    public interface IItemLogic 
    {
        SearchResult ParseSearchResults(string searchResults);

        DetailResult ParseItemResult(string detailResult, string descriptionResult);
    }
}