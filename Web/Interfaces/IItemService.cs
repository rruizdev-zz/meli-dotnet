using System.Threading.Tasks;
using Web.Models;

namespace Web.Interfaces
{
    public interface IItemService
    {
        Task<SearchResult> GetSearchResult(string query);

        Task<ItemResult> GetItemResult(string id);
    }
}