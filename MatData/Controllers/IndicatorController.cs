using MatData.Services.Indicator;
using MatData.Services.Municipe;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace MatData.Controllers
{
    [Route("api/v1/[controller]")]
    [ApiController]
    public class IndicatorController : ControllerBase
    {
        private readonly ILogger<IndicatorController> _logger;
        private readonly IIndicatorService _indicatorService;

        public IndicatorController(ILogger<IndicatorController> logger, IIndicatorService indicatorService)
        {
            _logger = logger;
            _indicatorService = indicatorService;
        }

        [HttpGet("indicator-by/{id}")]
        public IActionResult GetIndicatorById(int id)
        {
            _logger.LogInformation("Getting quiz by id");

            return Ok(_indicatorService.GetIndicatorById(id));
        }

        [HttpGet("/indicator-response/{indicatorId}")]
        public IActionResult GetIndicatorResponseByIndicatorId(int indicatorId)
        {
            _logger.LogInformation("Getting indicator response by indicator id");

            return Ok(_indicatorService.GetIndicatorResponseById(indicatorId));
        }

        [HttpGet("/by-theme/{themeId}")]
        public IActionResult GetIndicatorsByThemeId(int themeId)
        {
            _logger.LogInformation("Getting indicators by theme id");

            return Ok(_indicatorService.GetIndicatorsByTheme(themeId));
        }
    }
}
