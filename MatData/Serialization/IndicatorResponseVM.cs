using System;
using MatData.Models;

namespace Matdata.API.Serialization
{
    public class IndicatorResponseVM
    {
        public int Id { get; set; }
        public string Data { get; set; }
    }

    public static class IndicatorResponseMapper
    {
        public static IndicatorResponseVM Serialize(IndicatorResponse indicatorResponse)
        {

            try
            {
                return new IndicatorResponseVM
                {
                    Id = indicatorResponse.Id,
                    Data = indicatorResponse.Data
                };
            }
            catch (Exception)
            {
                return new IndicatorResponseVM
                {
                    Id = 0,
                    Data = null
                };
            }
        }
    }
}

