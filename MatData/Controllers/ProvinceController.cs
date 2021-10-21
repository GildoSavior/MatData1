using MatData.Models;
using MatData.Serialization;
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
    public class ProvinceController : ControllerBase
    {
        private readonly ILogger<ProvinceController> _logger;
        private readonly IProvinceService _provinceService;

        public ProvinceController(ILogger<ProvinceController> logger, IProvinceService provinceService)
        {
            _logger = logger;
            _provinceService = provinceService;
        }


        [HttpGet]
        public IActionResult GetAll()
        {
            _logger.LogInformation("Getting provinces");
            var provinces = _provinceService.GetAllProvinces();

            var provinceModels = provinces.Select(province => ProvinceMapper.Serialize(province))
                .OrderBy(province => province.Name)
                .ToList();

            return Ok(provinceModels);
        }

        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {
            _logger.LogInformation("Get a province");
            var province = _provinceService.GetById(id);
            return Ok(province);
        }

        [HttpPost]
        public IActionResult Create([FromBody] ProvinceModel provinceModel)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            _logger.LogInformation("Creating a new province");
            provinceModel.CreatedOn = DateTime.Now;
            provinceModel.UpdatedOn = DateTime.UtcNow;
            var province = ProvinceMapper.Serialize(provinceModel);
            var newProvince = _provinceService.CreateProvince(province);
            return Ok(newProvince);
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            _logger.LogInformation("Deleting a province");
            var response = _provinceService.DeleteProvince(id);
            return Ok(response);
        }
    }
}
