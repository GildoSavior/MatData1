using MatData.Models;
using MatData.Serialization;
using MatData.Services.Municipe;
using MatData.Services.Province;
using MatData.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Linq;

namespace MatData.Controllers
{
    [Route("api/v1/[controller]")]
    [ApiController]
    public class MunicipeController : ControllerBase
    {
        private readonly ILogger<MunicipeController> _logger;
        private readonly IMunicipeService _municipeService;

        public MunicipeController(ILogger<MunicipeController> logger, IMunicipeService municipeService)
        {
            _logger = logger;
            _municipeService = municipeService;
        }


        [HttpGet]
        public IActionResult GetAll()
        {
            _logger.LogInformation("Getting municipes");
            var municipes = _municipeService.GetAllMunicipes();

            var provinceModels = municipes.Select(municipe => MunicipeMapper.Serialize(municipe))
                .OrderBy(municipe => municipe.Id)
                .ToList();

            return Ok(provinceModels);
        }

        [HttpGet("province/{id}")]
        public IActionResult GetAllByProvinceId(int id)
        {
            _logger.LogInformation("Get a municipe");
            var province = _municipeService.GetAllByProvinceId(id);

            return Ok(province);
        }

        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {
            _logger.LogInformation("Get a municipe");
            var province = _municipeService.GetById(id);

            return Ok(province);
        }

        [HttpPost]
        public IActionResult Create([FromBody] MunicipeModel municipeModel)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            _logger.LogInformation("Creating a new municipe");
            municipeModel.CreatedOn = DateTime.Now;
            municipeModel.UpdatedOn = DateTime.UtcNow;
            var municipe = MunicipeMapper.Serialize(municipeModel);
            var newMunicipe = _municipeService.CreateMunicipe(municipe);
            return Ok(newMunicipe);
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            _logger.LogInformation("Deleting a province");
            var response = _municipeService.DeleteMunicipe(id);
            return Ok(response);
        }
    }
}
