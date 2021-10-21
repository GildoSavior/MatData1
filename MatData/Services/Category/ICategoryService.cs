using System.Collections.Generic;

namespace MatData.Services.Category
{
    public interface ICategoryService
    {
        List<Models.Category> GetAllCategories();
        List<Models.Theme> GetThemesByCategoryId(int categoryId);
    }
}
