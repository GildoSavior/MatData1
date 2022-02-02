using System;
using System.Linq;
using Matdata.API.Serialization;
using Matdata.API.ViewModels;
using MatData.Services.Municipe;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace MatData.Controllers
{
    [Route("api/v1/[controller]")]
    [ApiController]
    public class HistoryDataController : ControllerBase
    {
        private readonly ILogger<HistoryDataController> _logger;
        private readonly IHistoryDataService _historyDataService;

        public HistoryDataController(ILogger<HistoryDataController> logger, IHistoryDataService historyDataService)
        {
            _logger = logger;
            _historyDataService = historyDataService;
        }

        [HttpGet]
        public IActionResult GetAll()
        {
            _logger.LogInformation("Getting history data");
            var histories = _historyDataService.GetAllHistoryDatas();

            var result = histories.Select(municipe => HistoryDataMapper.Serialize(municipe))
                .OrderBy(history => -history.Id)
                .ToList();

            return Ok(result);
        }

        [HttpPost]
        public IActionResult Create([FromBody] HistoryDataModel model)
        {
            _logger.LogInformation("Create history data");
            var historyData = HistoryDataMapper.Serialize(model);
            _historyDataService.CreateHistoryData(historyData);
            return Ok();
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            _logger.LogInformation("Deleting a history data");
            var response = _historyDataService.DeleteHistoryData(id);
            return Ok(response);
        }
    }
}
