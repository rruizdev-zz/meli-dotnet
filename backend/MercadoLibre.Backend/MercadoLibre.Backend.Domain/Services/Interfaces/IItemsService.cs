using System.Collections.Generic;
using System.Threading.Tasks;

namespace MercadoLibre.Backend.Domain.Services.Interfaces
{
    public interface IItemsService
    {
        Task<IList<string>> GetItemsLike(string query); 
    }
}
