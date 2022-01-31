using System;
using Matdata.API.ViewModels;
using MatData.Models;

namespace Matdata.API.Serialization
{
	public class HistoryDataMapper
	{
		public static HistoryDataModel Serialize(HistoryData historyData)
		{
			return new HistoryDataModel
			{
				Id = historyData.Id,
				UserId = historyData.UserId,
				ProvinceId = historyData.ProvinceId,
				MunicipeId = historyData.MunicipeId,
				FileName = historyData.FileName,
				Year = historyData.Year,
				CreatedOn = historyData.CreatedOn
			};
		}

		public static HistoryData Serialize(HistoryDataModel historyData)
		{
			return new HistoryData
			{
				Id = historyData.Id,
				UserId = historyData.UserId,
				ProvinceId = historyData.ProvinceId,
				MunicipeId = historyData.MunicipeId,
				FileName = historyData.FileName,
				Year = historyData.Year,
				CreatedOn = historyData.CreatedOn
			};
		}
	}
}

