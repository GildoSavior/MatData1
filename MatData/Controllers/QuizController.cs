using MatData.Services.Category;
using MatData.Services.Indicator;
using MatData.Services.Municipe;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace MatData.Controllers
{
    [Route("api/v1/[controller]")]
    [ApiController]
    public class QuizController : ControllerBase
    {
        private readonly ILogger<CategoryController> _logger;
        private readonly IIndicatorService _indicatorService;

        public QuizController(ILogger<CategoryController> logger, IIndicatorService indicatorService)
        {
            _logger = logger;
            _indicatorService = indicatorService;
        }

        [HttpGet("{themeId}")]
        public IActionResult GetQuizByThemeId(int themeId)
        {
            _logger.LogInformation("Getting quiz by theme id");

            return Ok(_indicatorService.GetIndicatorsByTheme(themeId));
        }

        
    }
}
