using MercadoLibre.Backend.Domain.Models;
using MercadoLibre.Backend.Domain.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;
using NSwag.Annotations;
using System.Net;
using System.Threading.Tasks;

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

        /// <summary>
        /// Get items by search
        /// </summary>
        /// <param name="q">Search parameter</param>
        /// <returns>A lot of items</returns>
        [HttpGet]
        [SwaggerResponse(HttpStatusCode.OK, typeof(ItemByQuery))]
        public async Task<IActionResult> GetByQuery(string q)
        {
            var response = await _itemsService.GetBy(q);

            return Ok(response);
        }

        //[HttpGet("{id}")]
        //public async Task<IActionResult> GetById(int id)
        //{
        //    var itemResponse = await _itemsService.GetBy(id);

        //    var descriptionResponse = await _itemsService.GetDescriptionBy(id);

        //    return Ok(itemResponse);
        //}
    }
}
