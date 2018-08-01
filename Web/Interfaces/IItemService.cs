using System.Threading.Tasks;
using Web.Models.Item;
using Web.Models.Search;

namespace Web.Interfaces
{
    public interface IItemService
    {
        Task<SearchResult> GetSearchResult(string query);

        Task<DetailResult> GetItemResult(string id);
    }
}