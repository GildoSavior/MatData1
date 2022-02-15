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
	public class MessageController : ControllerBase
	{
		private readonly ILogger<MessageController> _logger;
		private readonly IMessageService _messageService;

		public MessageController(ILogger<MessageController> logger, IMessageService messageService)
		{
			_logger = logger;
			_messageService = messageService;
		}

		[HttpGet]
		public IActionResult GetAll()
        {
			return Ok(_messageService.GetMessages());
        }

		[HttpGet("{id}")]
		public IActionResult GetById(int id)
		{
			return Ok(_messageService.GetMessageById(id));
		}

		[HttpPost]
		public IActionResult Create(Models.Message model)
		{
			return Ok(_messageService.CreateMessage(model));
		}

		[HttpDelete]
		public IActionResult Delete(int id)
		{
			return Ok(_messageService.DeleteMessage(id));
		}
	}
}

