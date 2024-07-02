using Bunker_API.Models;
using Microsoft.AspNetCore.Mvc;

namespace Bunker_API.Controllers
{
	[ApiController]
	[Route("[controller]")]
	public class RoomController : ControllerBase
	{
		private readonly ILogger<UserController> _logger;

		public RoomController(ILogger<UserController> logger)
		{
			_logger = logger;
		}

		[HttpGet(Name = "GetRoom")]
		public Room Get(int id)
		{
			// get this from DB
			Room room = new()
			{
				ID = 5,
				IsActive = true
			};

			if (room.ID == id && room.IsActive)
				return room;
			else return new Room() { ID = -1 };
		}
	}
}
