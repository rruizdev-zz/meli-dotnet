using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Web.Interfaces;
using Web.Services;

namespace Web.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ItemsController : ControllerBase
    {
        IItemService _itemService;

        public ItemsController() => _itemService = new ItemService();

        // GET /api/items?q=:query
        [HttpGet(Name = nameof(GetItemsByQuery))]
        public async Task<IActionResult> GetItemsByQuery([FromQuery]string q) => base.Ok(await _itemService.GetSearchResult(q));

        // GET /api/items/:id
        [HttpGet]
        [Route("{id}", Name = nameof(GetItemById))]
        public async Task<IActionResult> GetItemById(string id) => base.Ok(await _itemService.GetItemResult(id));
    }
}
