using System.Net;
using MediatR;
using Meli.Backend.Application.Query.Items.GetByCode;
using Meli.Backend.Application.Query.Items.GetByQuery;
using Meli.Backend.Domain.Responses.Items;
using Microsoft.AspNetCore.Mvc;

namespace Meli.Backend.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ItemsController : ControllerBase
    {
        private readonly IMediator _mediator;

        public ItemsController(IMediator mediator)
        {
            _mediator = mediator;
        }

        /// <summary>
        /// Get items by search
        /// </summary>
        /// <param name="query">Search query parameter</param>
        /// <returns>A lot of items</returns>
        [HttpGet]
        [ProducesResponseType(typeof(SearchResponse), (int) HttpStatusCode.OK)]
        public async Task<IActionResult> GetByQuery(string query) =>
            Ok(await _mediator.Send(new GetByQueryRequest(query)));

        /// <summary>
        /// Get a specific item detail
        /// </summary>
        /// <param name="code">Id of item</param>
        /// <returns>A item detail</returns>
        [HttpGet("{code}")]
        [ProducesResponseType(typeof(DetailResponse), (int) HttpStatusCode.OK)]
        public async Task<IActionResult> GetByCode(string code) =>
            Ok(await _mediator.Send(new GetByCodeRequest(code)));
    }
}
