using MatData.Models;
using MatData.Serialization;
using MatData.Services.Municipe;
using MatData.Services.NeighborhoodVillage;
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
    public class NeighborhoodVillageController : ControllerBase
    {
        private readonly ILogger<UrbanDistrictCommuneController> _logger;
        private readonly INeighborhoodVillageService _neighborhoodVillageService;

        public NeighborhoodVillageController(ILogger<UrbanDistrictCommuneController> logger,
            INeighborhoodVillageService neighborhoodVillageService)
        {
            _logger = logger;
            _neighborhoodVillageService = neighborhoodVillageService;
        }


        [HttpGet]
        public IActionResult GetAll(int pageIndex, int pageSize)
        {
            _logger.LogInformation("Getting NeighborhoodVillages");
            var neighborhoodVillages = _neighborhoodVillageService.GetNeighborhoodVillagePerPage(pageIndex, pageSize);

            return Ok(neighborhoodVillages);
        }

        [HttpGet("urbanDistrictCommune/{id}")]
        public IActionResult GetAllByMunicipeId(int id)
        {
            _logger.LogInformation("Get a NeighborhoodVillages");
            var result = _neighborhoodVillageService.GetAllByUrbanDistrictCommuneId(id);

            return Ok(result);
        }


        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {
            _logger.LogInformation("Get a NeighborhoodVillage");
            var province = _neighborhoodVillageService.GetById(id);

            return Ok(province);
        }

        [HttpPost]
        public IActionResult Create([FromBody] NeighborhoodVillageModel neighborhoodVillageModel)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            _logger.LogInformation("Creating a new NeighborhoodVillage");
            neighborhoodVillageModel.CreatedOn = DateTime.Now;
            neighborhoodVillageModel.UpdatedOn = DateTime.UtcNow;
            var neighborhoodVillage = NeighborhoodVillageMapper.Serialize(neighborhoodVillageModel);
            var newNeighborhoodVillage = _neighborhoodVillageService.CreateNeighborhoodVillage(neighborhoodVillage);
            return Ok(newNeighborhoodVillage);
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            _logger.LogInformation("Deleting a NeighborhoodVillage");
            var response = _neighborhoodVillageService.DeleteNeighborhoodVillage(id);
            return Ok(response);
        }
    }
}
