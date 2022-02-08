using System;
using Matdata.API.Services.Agenda;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace Matdata.API.Controllers
{
	[Route("api/v1/[controller]")]
	[ApiController]
	public class AgendaController : ControllerBase
	{
		private readonly ILogger<AgendaController> _logger;
		private readonly IAgendaService _agendaService;

		public AgendaController(ILogger<AgendaController> logger, IAgendaService agendaService)
		{
			_logger = logger;
			_agendaService = agendaService;
		}

		[HttpGet]
		public IActionResult GetAll()
        {
			return Ok(_agendaService.GetAgendas());
        }

		[HttpGet("{id}")]
		public IActionResult GetById(int id)
		{
			return Ok(_agendaService.GetAgendaById(id));
		}

		[HttpPost]
		public IActionResult Create(Models.Agenda agenda)
		{
			return Ok(_agendaService.CreateAgenda(agenda));
		}

		[HttpDelete]
		public IActionResult Delete(int id)
		{
			return Ok(_agendaService.DeleteAgenda(id));
		}
	}
}

