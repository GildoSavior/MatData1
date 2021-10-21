using MatData.Data;
using MatData.Models;
using Microsoft.Extensions.Logging;
using System.Collections.Generic;
using System.Linq;

namespace MatData.Services.Category
{
    public class CategoryService : ICategoryService
    {
        private readonly AppDbContext _db;

        public CategoryService(AppDbContext db)
        {
            _db = db;
        }

        public List<Models.Category> GetAllCategories()
        {
            return _db.Categories.ToList();
        }

        public List<Theme> GetThemesByCategoryId(int categoryId)
        {
            return _db.Themes.Where(t => t.Category.Id == categoryId).ToList();
        }
    }
}
