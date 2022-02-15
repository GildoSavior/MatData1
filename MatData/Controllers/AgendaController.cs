using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using CsvHelper;
using Matdata.API.Serialization;
using Matdata.API.Services.Agenda;
using Matdata.API.ViewModels;
using MatData.Data;
using MatData.Models;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.FileProviders;
using Microsoft.Extensions.Logging;

namespace Matdata.API.Controllers
{
	[Route("api/v1/[controller]")]
	[ApiController]
	public class AgendaController : ControllerBase
	{
		private readonly ILogger<AgendaController> _logger;
		private readonly IAgendaService _agendaService;
		private readonly AppDbContext _db;
		private readonly IWebHostEnvironment _environment;

		public AgendaController(ILogger<AgendaController> logger, IAgendaService agendaService, AppDbContext db, IWebHostEnvironment environment)
		{
			_logger = logger;
			_agendaService = agendaService;
			_db = db;
			_environment = environment;
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
		public IActionResult Create(IFormFile file, [FromQuery] AgendaVM agenda)
		{
			return Ok(_agendaService.CreateAgenda(AgendaMapper.Serialize(agenda, file.FileName), file));
		}

		[HttpGet("csv")]
		public IActionResult CreateCSV()
		{

			var provinces = _db.Provinces.ToList();
			var data = new List<DataSet>();

            foreach (var province in provinces)
            {

				var municipes = _db.Municipes.Where(m => m.Province.Id == province.Id).ToList();
				
				var listMunicipes = new List<DataSet2>();

				foreach (var municipe in municipes)
                {
					var communes = _db.UrbanDistrictCommunes.Where(m => m.Municipe.Id == municipe.Id).ToList();
					var listCommunes = new List<string>();

                    foreach (var commune in communes)
                    {
						listCommunes.Add(commune.Name);
                    }

					listMunicipes.Add(new DataSet2
					{
						MunicipeName = municipe.Name,
						Communes = listCommunes
					});
				}

				data.Add(new DataSet
				{
					ProvinceName = province.Name,
					Municipes = listMunicipes
				});
            }

			using (var writer = new StreamWriter(Path.Combine(_environment.WebRootPath, "Repository", "Data.csv")))
			using (var csv = new CsvWriter(writer, CultureInfo.InvariantCulture))
			{
				var listToSave = new List<ToSave>();
                foreach (var province in data)
                {
					foreach (var municipe in province.Municipes)
                    {

						foreach (var comune in municipe.Communes)
						{
							var toSave = new ToSave();
							toSave.ProvinceName = province.ProvinceName;
							toSave.MunicipeName = municipe.MunicipeName;
							toSave.ComuneName = comune;
							toSave.LabelName = comune;
						    listToSave.Add(toSave);
						}

					}
				}

				csv.WriteRecords(listToSave);
			}




			return Ok();
		}

		[HttpDelete]
		public IActionResult Delete(int id)
		{
			return Ok(_agendaService.DeleteAgenda(id));
		}
	}

    public class DataSet
    {
        public string ProvinceName { get; set; }
        public List<DataSet2> Municipes { get; set; }
    }

	public class ToSave
	{
		public string Name { get; set; } = "comunas";
        public string ComuneName { get; set; }
        public string LabelName { get; set; }
		public string ProvinceName { get; set; }
		public string MunicipeName { get; set; }
	}

	public class DataSet2
	{
		public string MunicipeName { get; set; }
		public List<string> Communes { get; set; }
	}
}

