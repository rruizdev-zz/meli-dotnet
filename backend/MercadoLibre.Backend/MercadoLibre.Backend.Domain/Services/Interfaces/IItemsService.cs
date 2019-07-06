using MercadoLibre.Backend.Domain.Models;
using System.Threading.Tasks;

namespace MercadoLibre.Backend.Domain.Services.Interfaces
{
    public interface IItemsService
    {
        Task<ItemByQuery> GetBy(string query);

        Task<ItemById> GetBy(int id);

        Task<ItemDescriptionById> GetDescriptionBy(int id);
    }
}
