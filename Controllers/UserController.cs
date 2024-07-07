using Bunker_API.Models;
using Microsoft.AspNetCore.Mvc;

namespace Bunker_API.Controllers
{
    [ApiController]
	[Route("[controller]")]
	public class UserController : ControllerBase
	{
		private readonly ILogger<UserController> _logger;

		BunkerContext _context = new();

		public UserController(ILogger<UserController> logger)
		{
			_logger = logger;
		}

		[HttpGet(Name = "GetUser")]
		public User Get()
		{
			User user = _context.Users.ToList().FirstOrDefault();

			return user;
		}
	}
}
