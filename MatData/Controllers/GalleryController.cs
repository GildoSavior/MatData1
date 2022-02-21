using System;
using Matdata.API.Serialization;
using Matdata.API.Services.Agenda;
using Matdata.API.Services.Comment;
using Matdata.API.Services.Gallery;
using Matdata.API.Services.Message;
using Matdata.API.ViewModels;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace Matdata.API.Controllers
{
	[Route("api/v1/[controller]")]
	[ApiController]
	public class GalleryController : ControllerBase
	{
		private readonly ILogger<GalleryController> _logger;
		private readonly IGalleryService _galleryService;

		public GalleryController(ILogger<GalleryController> logger, IGalleryService galleryService)
		{
			_logger = logger;
			_galleryService = galleryService;
		}

		[HttpGet]
		public IActionResult GetAll()
		{
			return Ok(_galleryService.GetGallery());
		}

		[HttpGet("{id}")]
		public IActionResult GetById(int id)
		{
			return Ok(_galleryService.GetGalleryById(id));
		}


		[HttpPost]
		public IActionResult Create(IFormFile file, [FromQuery] GalleryVM gallery)
		{
			return Ok(_galleryService.CreateGallery(GalleryMapper.Serialize(gallery, file.FileName), file));
		}

		[HttpDelete]
		public IActionResult Delete(int id)
		{
			return Ok(_galleryService.DeleteGallery(id));
		}
	}
}

