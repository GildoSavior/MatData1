using MatData.Models;
using System;

namespace MatData.ViewModels
{
    public class NeighborhoodVillageModel
    {
        public int Id { get; set; }
        public DateTime CreatedOn { get; set; }
        public DateTime UpdatedOn { get; set; }
        public string Name { get; set; }
        public UrbanDistrictCommuneModel UrbanDistrictCommune { get; set; }
    }
}
