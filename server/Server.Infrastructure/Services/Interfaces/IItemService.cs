using Server.Business.Models.Detail;
using Server.Business.Models.Search;
using System.Threading.Tasks;

namespace Server.Infrastructure.Services.Interfaces
{
    public interface IItemService
    {
        Task<SearchResult> GetSearchResult(string query);

        Task<DetailResult> GetItemResult(string id);
    }
}