using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;
using Server.Application.Tasks;
using Server.Application.Tasks.Interfaces;
using Server.Domain.Models.Config;
using Server.Infrastructure.Services;
using Server.Infrastructure.Services.Interfaces;

namespace Server.WebApi.Controllers
{
    [Route("api/[controller]")]
    public class ItemsController : ControllerBase
    {
        private readonly IItemService _itemService;
        private readonly IItemLogic _itemLogic;
        private readonly IOptions<MeliConfig> _config;

        public ItemsController(IOptions<MeliConfig> config)
        {
            _itemService = new ItemService(config);
            _itemLogic = new ItemLogic(config);
            _config = config;
        }

        // GET /api/items?q=:query
        [HttpGet(Name = nameof(GetItemsByQuery))]
        public async Task<IActionResult> GetItemsByQuery([FromQuery]string q)
        {
            var searchResult = await _itemService.GetSearchResult(q);

            var processedResult = _itemLogic.ParseSearchResults(searchResult);

            return base.Ok(processedResult);
        }

        // GET /api/items/:id
        [HttpGet]
        [Route("{id}", Name = nameof(GetItemById))]
        public async Task<IActionResult> GetItemById(string id)
        {
            var detailResult = await _itemService.GetDetailResult(id);

            var descriptionResult = await _itemService.GetDescriptionResult(id);

            var processedResult = _itemLogic.ParseItemResult(detailResult, descriptionResult);

            return base.Ok(processedResult);
        }            
    }
}
