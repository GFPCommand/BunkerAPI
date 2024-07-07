using Microsoft.AspNetCore.Mvc;

namespace Bunker_API.Controllers
{
	[ApiController]
	[Route("[controller]")]
	public class ProfessionController : ControllerBase
	{
		private readonly ILogger<UserController> _logger;

		BunkerContext _context = new();

		public ProfessionController(ILogger<UserController> logger)
		{
			_logger = logger;
		}

		[HttpGet(Name = "GetProfession")]
		public Profession Get(int id)
		{
			Profession profession = _context.Professions.ToList().FirstOrDefault();

			return profession;
		}
	}
}
