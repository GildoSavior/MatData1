using MatData.Data;
using MatData.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;

namespace MatData.Services.Indicator
{
    public class IndicatorService : IIndicatorService
    {
        private readonly AppDbContext _db;

        public IndicatorService(AppDbContext db)
        {
            _db = db;
        }
        public IndicatorResponse GetIndicatorResponseById(int indicatorId)
        {
            return _db.IndicatorResponses
                .Where(i => i.Indicator.Id == indicatorId)
                .FirstOrDefault();
        }

        public List<Models.Indicator> GetIndicatorsByTheme(int themeId)
        {
            return _db.Indicators
                .Where(i => i.Theme.Id == themeId)
                .Include(i => i.Theme)
                .ToList();
        }
    }
}
