using System;

namespace MatData.Models
{
    public class IndicatorResponse
    {
        public int Id { get; set; }
        public DateTime CreatedOn { get; set; }
        public DateTime UpdatedOn { get; set; }
        public Indicator Indicator { get; set; }
        public Province? Province { get; set; }
        public Municipe? Municipe { get; set; }
        public UrbanDistrictCommune? UrbanDistrictCommune { get; set; }
        public NeighborhoodVillage? NeighborhoodVillage { get; set; }
        public string? Data { get; set; }

    }
}
