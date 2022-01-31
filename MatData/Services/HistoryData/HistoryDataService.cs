using MatData.Data;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;

namespace MatData.Services.Municipe
{
    public class HistoryDataService : IHistoryDataService
    {
        private readonly AppDbContext _db;

        public HistoryDataService(AppDbContext db)
        {
            _db = db;
        }

        public ServiceResponse<Models.HistoryData> CreateHistoryData(Models.HistoryData historyData)
        {
            try
            {
                _db.HistoryDatas.Add(historyData);
                _db.SaveChanges();
                return new ServiceResponse<Models.HistoryData>
                {
                    IsSuccess = true,
                    Message = "New history data added",
                    Time = DateTime.Now,
                    Data = historyData
                };
            }
            catch (Exception e)
            {
                return new ServiceResponse<Models.HistoryData>
                {
                    IsSuccess = false,
                    Message = e.StackTrace,
                    Time = DateTime.Now,
                    Data = historyData
                };
            }
        }

        public ServiceResponse<bool> DeleteHistoryData(int id)
        {
            var historyData = _db.HistoryDatas.Find(id);
            var now = DateTime.Now;

            if (historyData == null)
            {
                return new ServiceResponse<bool>
                {
                    Time = now,
                    IsSuccess = false,
                    Message = "History data to delete not found!",
                    Data = false
                };
            }
            try
            {
                _db.HistoryDatas.Remove(historyData);
                _db.SaveChanges();

                return new ServiceResponse<bool>
                {
                    Time = now,
                    IsSuccess = true,
                    Message = "History data created",
                    Data = true
                };
            }
            catch (Exception e)
            {
                return new ServiceResponse<bool>
                {
                    Time = now,
                    IsSuccess = false,
                    Message = e.StackTrace,
                    Data = false
                };
            }
        }

        public List<Models.HistoryData> GetAllHistoryDatas()
        {
            return _db.HistoryDatas
                .Include(historyData => historyData.Province)
                .OrderBy(historyData => historyData.Year)
                .ToList();
        }
    }
}
