using MatData.Models;
using MatData.Serialization;
using MatData.Services.Municipe;
using MatData.Services.Province;
using MatData.Services.UrbanDistrictCommune;
using MatData.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Linq;

namespace MatData.Controllers
{
    [Route("api/v1/[controller]")]
    [ApiController]
    public class UrbanDistrictCommuneController : ControllerBase
    {
        private readonly ILogger<UrbanDistrictCommuneController> _logger;
        private readonly IUrbanDistrictCommuneService _urbanDistrictCommuneService;

        public UrbanDistrictCommuneController(ILogger<UrbanDistrictCommuneController> logger, 
            IUrbanDistrictCommuneService urbanDistrictCommuneService)
        {
            _logger = logger;
            _urbanDistrictCommuneService = urbanDistrictCommuneService;
        }


        [HttpGet]
        public IActionResult GetAll()
        {
            _logger.LogInformation("Getting UrbanDistrictCommunes");
            var urbanDistrictCommunes = _urbanDistrictCommuneService.GetAllUrbanDistrictCommunes();

            var urbanDistrictCommuneModels = urbanDistrictCommunes.Select(urban => UrbanDistrictCommuneMapper.Serialize(urban))
                .OrderBy(urban => urban.Id)
                .ToList();

            return Ok(urbanDistrictCommuneModels);
        }

        [HttpGet("municipality/{id}")]
        public IActionResult GetAllByMunicipeId(int id)
        {
            _logger.LogInformation("Get a UrbanDistrictCommunes");
            var comunas = _urbanDistrictCommuneService.GetAllByMunicipeId(id);

            return Ok(comunas);
        }

        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {
            _logger.LogInformation("Get a UrbanDistrictCommune");
            var province = _urbanDistrictCommuneService.GetById(id);

            return Ok(province);
        }

        [HttpPost]
        public IActionResult Create([FromBody] UrbanDistrictCommuneModel urbanDistrictCommune)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            _logger.LogInformation("Creating a new UrbanDistrictCommune");
            urbanDistrictCommune.CreatedOn = DateTime.Now;
            urbanDistrictCommune.UpdatedOn = DateTime.UtcNow;
            var urban = UrbanDistrictCommuneMapper.Serialize(urbanDistrictCommune);
            var newUrbanDistrictCommune = _urbanDistrictCommuneService.CreateUrbanDistrictCommune(urban);
            return Ok(newUrbanDistrictCommune);
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            _logger.LogInformation("Deleting a UrbanDistrictCommune");
            var response = _urbanDistrictCommuneService.DeleteUrbanDistrictCommune(id);
            return Ok(response);
        }
    }
}
