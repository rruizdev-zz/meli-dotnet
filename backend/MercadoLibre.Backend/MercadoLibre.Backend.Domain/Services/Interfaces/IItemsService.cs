using MercadoLibre.Backend.Domain.Models;
using System.Threading.Tasks;

namespace MercadoLibre.Backend.Domain.Services.Interfaces
{
    public interface IItemsService
    {
        Task<ItemByQuery> Search(string query);

        Task<ItemById> Detail(string id);
    }
}
