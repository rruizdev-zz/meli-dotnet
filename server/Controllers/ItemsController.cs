using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ItemsController : ControllerBase
    {
        // GET /api/items?q=:query
        [HttpGet(Name = nameof(GetItemsByQuery))]
        public async Task<IActionResult> GetItemsByQuery([FromQuery]string q)
        {
            return Ok(q);
        }
        
        // GET /api/items/:id
        [HttpGet]
        [Route("{id}", Name = nameof(GetItemById))]
        public async Task<IActionResult> GetItemById(string id)
        {
            return Ok(id);
        }
    }
}
