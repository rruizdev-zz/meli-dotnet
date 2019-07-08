﻿using AutoMapper;
using MercadoLibre.Backend.Domain.Responses.Items;
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
        /// <param name="q">Search query parameter</param>
        /// <returns>A lot of items</returns>
        [HttpGet]
        [SwaggerResponse(HttpStatusCode.OK, typeof(SearchResponse))]
        public async Task<IActionResult> Search(string q)
        {
            var response = await _service.Search(q);

            return Ok(_mapper.Map<SearchResponse>(response));
        }

        /// <summary>
        /// Get a specific item detail
        /// </summary>
        /// <param name="id">Id of item</param>
        /// <returns>A item detail</returns>
        [HttpGet("{id}")]
        [SwaggerResponse(HttpStatusCode.OK, typeof(DetailResponse))]
        public async Task<IActionResult> Detail(string id)
        {
            var response = await _service.DetailWithDescription(id);

            return Ok(_mapper.Map<DetailResponse>(response));
        }


    }
}
