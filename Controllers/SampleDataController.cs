using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace AureliaDotnetTemplate.Controllers {
	[Route("api/[controller]")]
	[ApiController]
	public class SampleDataController : Controller {

		public static IEnumerable<string> GetData() {
			yield return "Hello Betcom";
		}
		[HttpGet("HelloBetcom")]
		public IEnumerable<string> HelloBetcom() {



			IEnumerable<string> messageHello = GetData();
			return messageHello;
		}
		
	}
}
