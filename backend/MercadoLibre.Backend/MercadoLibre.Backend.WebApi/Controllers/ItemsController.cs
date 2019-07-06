using AutoMapper;
using MercadoLibre.Backend.Domain.Responses;
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
        private readonly IItemsService _service;

        private readonly IMapper _mapper;

        public ItemsController(IItemsService service, IMapper mapper)
        {
            _service = service;

            _mapper = mapper;
        }

        /// <summary>
        /// Get items by search
        /// </summary>
        /// <param name="q">Search parameter</param>
        /// <returns>A lot of items</returns>
        [HttpGet]
        [SwaggerResponse(HttpStatusCode.OK, typeof(ItemByQueryResponse))]
        public async Task<IActionResult> GetByQuery(string q)
        {
            var response = await _service.GetBy(q);

            return Ok(_mapper.Map<ItemByQueryResponse>(response));
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(int id)
        {
            var itemResponse = await _service.GetBy(id);

            var descriptionResponse = await _service.GetDescriptionBy(id);

            return Ok(itemResponse);
        }
    }
}
