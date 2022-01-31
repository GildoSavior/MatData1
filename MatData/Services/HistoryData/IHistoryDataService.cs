using System.Collections.Generic;

namespace MatData.Services.Municipe
{
    public interface IHistoryDataService
    {
        List<Models.HistoryData> GetAllHistoryDatas();
        ServiceResponse<Models.HistoryData> CreateHistoryData(Models.HistoryData municipe);
        ServiceResponse<bool> DeleteHistoryData(int id);
    }
}
