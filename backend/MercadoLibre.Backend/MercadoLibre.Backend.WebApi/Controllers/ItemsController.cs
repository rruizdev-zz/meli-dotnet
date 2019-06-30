using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;

namespace MercadoLibre.Backend.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ItemsController : ControllerBase
    {
        [HttpGet]
        public ActionResult<IEnumerable<string>> GetItemsLike(string q)
        {
            return new string[] { q };
        }

        [HttpGet("{id}")]
        public ActionResult<string> GetItemDetail(int id)
        {
            return $"{id}: value";
        }
    }
}
