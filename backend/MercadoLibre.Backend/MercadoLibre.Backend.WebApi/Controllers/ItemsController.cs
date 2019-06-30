using System.Collections.Generic;
using System.Threading.Tasks;
using MercadoLibre.Backend.Domain.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace MercadoLibre.Backend.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ItemsController : ControllerBase
    {
        private readonly IItemsService _itemsService;

        public ItemsController(IItemsService itemsService)
        {
            _itemsService = itemsService;
        }

        [HttpGet]
        public Task<IList<string>> GetItemsLike(string q) => _itemsService.GetItemsLike(q);

        [HttpGet("{id}")]
        public ActionResult<string> GetItemDetail(int id) => $"{id}: value";
    }
}
