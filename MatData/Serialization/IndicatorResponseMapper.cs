using MatData.Models;
using MatData.ViewModels;
using System;

namespace MatData.Serialization
{
    public static class IndicatorResponseMapper
    {
        public static IndicatorResponse Serialize(dynamic record)
        {
            var now = DateTime.Now;

            return new IndicatorResponse
            {
                CreatedOn = now,
                UpdatedOn= now,
                Indicator = record.Indicator,
                Data = record.Data,
                Province = record.Province,
                Municipe = record.Municipe,
                UrbanDistrictCommune = record.UrbanDistrictCommune,
                NeighborhoodVillage = record.NeighborhoodVillage,
            };
        }
    };
}
