using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;

namespace MercadoLibre.WebApi.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class ItemsController : ControllerBase
	{
		[HttpGet]
		public ActionResult<IEnumerable<string>> Get(string q)
		{
			return new string[] { "value1", "value2" };
		}

		[HttpGet("{id}")]
		public ActionResult<string> Get(int id)
		{
			return "value";
		}
	}
}
