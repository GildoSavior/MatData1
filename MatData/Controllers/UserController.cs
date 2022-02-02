using System;
using Matdata.API.Serialization;
using Matdata.API.ViewModels;
using MatData.Services.User;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace Matdata.API.Controllers
{
	[Route("api/v1/[controller]")]
	[ApiController]
	public class UserController : ControllerBase
	{
		private readonly ILogger<UserController> _logger;
		private readonly IUserService _userService;

		public UserController(ILogger<UserController> logger, IUserService userService)
		{
			_logger = logger;
			_userService = userService;
		}

		[HttpGet]
		public IActionResult GetAll()
		{
			_logger.LogInformation("Getting users");
			var users = _userService.GetUsers();
			return Ok(users);
		}

		[HttpPost]
		public IActionResult Create(UserModel userModel)
		{
			_logger.LogInformation("Create user");
			var user = UserMapper.Serialize(userModel);
			var result = _userService.Create(user);
			return Ok(result);
		}

		[HttpGet("{id}")]
		public IActionResult GetById(int id)
		{
			_logger.LogInformation("Getting user");
			return Ok();
		}

		[HttpPut("{id}")]
		public IActionResult Update([FromBody] UserModel userModel, int id)
		{
			_logger.LogInformation("Updating user");
			return Ok();
		}

		[HttpDelete("{id}")]
		public IActionResult Delete(int id)
		{
			_logger.LogInformation("Delete user");
			return Ok();
		}


	}
}

