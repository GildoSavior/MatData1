using MatData.Services.Category;
using MatData.Services.Municipe;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace MatData.Controllers
{
    [Route("api/v1/[controller]")]
    [ApiController]
    public class CategoryController : ControllerBase
    {
        private readonly ILogger<CategoryController> _logger;
        private readonly ICategoryService _categoryService;

        public CategoryController(ILogger<CategoryController> logger, ICategoryService categoryService)
        {
            _logger = logger;
            _categoryService = categoryService;
        }

        [HttpGet]
        public IActionResult GetAll()
        {
            _logger.LogInformation("Getting categories");

            return Ok(_categoryService.GetAllCategories());
        }

        [HttpGet("{categoryId}", Name="ThemesByCategoryId")]
        public IActionResult GetThemesByCategoryId(int categoryId)
        {
            _logger.LogInformation("Getting themes by category id");

            return Ok(_categoryService.GetThemesByCategoryId(categoryId));
        }
    }
}
