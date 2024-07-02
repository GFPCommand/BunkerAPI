using Bunker_API.Models;
using Microsoft.AspNetCore.Mvc;

namespace Bunker_API.Controllers
{
    [ApiController]
	[Route("[controller]")]
	public class UserController : ControllerBase
	{
		private readonly ILogger<UserController> _logger;

		public UserController(ILogger<UserController> logger)
		{
			_logger = logger;
		}

		[HttpGet(Name = "GetUser")]
		public IEnumerable<User> Get()
		{
			return Enumerable.Range(1, 5).Select(index => new User
			{
				ID = index,
				UserName = $"User{index}"
			})
			.ToArray();
		}
	}
}
