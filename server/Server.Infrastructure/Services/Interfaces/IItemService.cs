using System.Threading.Tasks;

namespace Server.Infrastructure.Services.Interfaces
{
    public interface IItemService
    {
        Task<string> GetSearchResult(string query);

        Task<string> GetDetailResult(string id);

        Task<string> GetDescriptionResult(string id);
    }
}