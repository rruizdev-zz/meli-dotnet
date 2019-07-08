using MercadoLibre.Backend.Domain.Models;
using System.Threading.Tasks;
using MercadoLibre.Backend.Domain.Models.Items;

namespace MercadoLibre.Backend.Domain.Services.Interfaces
{
    public interface IItemsService
    {
        Task<ItemByQuery> Search(string query);

        Task<ItemById> DetailWithDescription(string id);
    }
}
