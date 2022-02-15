using System;
using Matdata.API.Services.Agenda;
using Matdata.API.Services.Comment;
using Matdata.API.Services.Message;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace Matdata.API.Controllers
{
	[Route("api/v1/[controller]")]
	[ApiController]
	public class PostController : ControllerBase
	{
		private readonly ILogger<PostController> _logger;
		private readonly IPostService _postService;

		public PostController(ILogger<PostController> logger, IPostService postService)
		{
			_logger = logger;
			_postService = postService;
		}

		[HttpGet]
		public IActionResult GetAll()
        {
			return Ok(_postService.GetPosts());
        }

		[HttpGet("{id}")]
		public IActionResult GetById(int id)
		{
			return Ok(_postService.GetPostById(id));
		}

		[HttpPost]
		public IActionResult Create(Models.Post model)
		{
			return Ok(_postService.CreatePost(model));
		}

		[HttpDelete]
		public IActionResult Delete(int id)
		{
			return Ok(_postService.DeletePost(id));
		}
	}
}

