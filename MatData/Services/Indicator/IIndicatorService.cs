using System.Collections.Generic;

namespace MatData.Services.Indicator
{
    public interface IIndicatorService
    {
        List<Models.Indicator> GetIndicatorsByTheme(int themeId);
        Models.IndicatorResponse GetIndicatorResponseById(int indicatorId);
    }
}
