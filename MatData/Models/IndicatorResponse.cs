using System;

namespace MatData.Models
{
    public class IndicatorResponse
    {
        public int Id { get; set; }
        public DateTime CreatedOn { get; set; }
        public DateTime UpdatedOn { get; set; }

        public Indicator Indicator { get; set; }
        public int? IndicatorId { get; set; }

        public string Year { get; set; }

        public Province? Province { get; set; }
        public int? ProvinceId { get; set; }

        public Municipe? Municipe { get; set; }
        public int? MunicipeId { get; set; }

        public UrbanDistrictCommune? UrbanDistrictCommune { get; set; }
        public int? UrbanDistrictCommuneId { get; set; }

        public NeighborhoodVillage? NeighborhoodVillage { get; set; }
        public int? NeighborhoodVillageId { get; set; }

        public string? Data { get; set; }
        public string InstanceId { get; set; }
    }
}
