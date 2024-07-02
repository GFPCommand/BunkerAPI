using Bunker_API.Models;
using Microsoft.AspNetCore.Mvc;

namespace Bunker_API.Controllers
{
	[ApiController]
	[Route("[controller]")]
	public class PersonController : ControllerBase
	{
		private readonly ILogger<UserController> _logger;

		public PersonController(ILogger<UserController> logger)
		{
			_logger = logger;
		}

		[HttpGet(Name = "GetPerson")]
		public Person Get(int id)
		{
			// get this from DB
			Person room = new()
			{
				ID = 5,
				Name = "",
				Description = "smth"
			};

			if (room.ID == id && room.Name.Equals(""))
				return room;
			else return new Person() { ID = -1 };
		}
	}
}
