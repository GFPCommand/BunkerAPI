using Bunker_API.Models;
using Microsoft.AspNetCore.Mvc;

namespace Bunker_API.Controllers
{

	[ApiController]
	[Route("[controller]")]
	public class RoleController : ControllerBase
	{
		private readonly ILogger<UserController> _logger;

		public RoleController(ILogger<UserController> logger)
		{
			_logger = logger;
		}

		[HttpGet(Name = "GetRole")]
		public Role Get(int id)
		{
			// get this from DB
			Role room = new()
			{
				ID = 5,
				RoleName = ""
			};

			if (room.ID == id && room.RoleName.Equals(""))
				return room;
			else return new Role() { ID = -1 };
		}
	}
}
