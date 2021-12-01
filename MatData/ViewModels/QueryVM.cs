using System;
using AspNetCore.IQueryable.Extensions;

namespace Matdata.API.ViewModels
{
    public class QueryVM : ICustomQueryable
    {
        public int ProvinceId { get; set; } = 0;
        public int IndicatorId { get; set; } = 0;
        public int MunicipeId { get; set; } = 0;
        public int UrbanDistrictCommuneId { get; set; } = 0;
        public int NeighborhoodVillageId { get; set; } = 0;
        public string Year { get; set; } = DateTime.Now.Year.ToString();
    }
}

