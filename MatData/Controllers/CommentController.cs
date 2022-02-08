using System;
using Matdata.API.Services.Agenda;
using Matdata.API.Services.Comment;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace Matdata.API.Controllers
{
	[Route("api/v1/[controller]")]
	[ApiController]
	public class CommentController : ControllerBase
	{
		private readonly ILogger<CommentController> _logger;
		private readonly ICommentService _commentService;

		public CommentController(ILogger<CommentController> logger, ICommentService commentService)
		{
			_logger = logger;
			_commentService = commentService;
		}

		[HttpGet]
		public IActionResult GetAll()
        {
			return Ok(_commentService.GetComments());
        }

		[HttpGet("{id}")]
		public IActionResult GetById(int id)
		{
			return Ok(_commentService.GetCommentById(id));
		}

		[HttpPost]
		public IActionResult Create(Models.Comment model)
		{
			return Ok(_commentService.CreateComment(model));
		}

		[HttpDelete]
		public IActionResult Delete(int id)
		{
			return Ok(_commentService.DeleteComment(id));
		}
	}
}

