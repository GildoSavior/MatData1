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
        private readonly IMunicipeService _municipeService;

        public IndicatorController(ILogger<IndicatorController> logger, IMunicipeService municipeService)
        {
            _logger = logger;
            _municipeService = municipeService;
        }
    }
}
