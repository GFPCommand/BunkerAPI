using Microsoft.AspNetCore.Mvc;

namespace Bunker_API.Controllers
{
	[ApiController]
	[Route("[controller]")]
	public class RoomController : ControllerBase
	{
		private readonly ILogger<UserController> _logger;

		BunkerContext _context = new();

		public RoomController(ILogger<UserController> logger)
		{
			_logger = logger;
		}

		[HttpGet(Name = "GetRoom")]
		public Room Get(int id)
		{
			Room room = _context.Rooms.ToList().FirstOrDefault();

			return room;
		}
	}
}
