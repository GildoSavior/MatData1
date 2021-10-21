using MatData.Models;
using MatData.ViewModels;

namespace MatData.Serialization
{
    public class NeighborhoodVillageMapper
    {
        public static NeighborhoodVillageModel Serialize(NeighborhoodVillage neighborhoodVillage)
        {
            return new NeighborhoodVillageModel
            {
                Id = neighborhoodVillage.Id,
                CreatedOn = neighborhoodVillage.CreatedOn,
                UpdatedOn = neighborhoodVillage.UpdatedOn,
                Name = neighborhoodVillage.Name,
                UrbanDistrictCommune = UrbanDistrictCommuneMapper.Serialize(neighborhoodVillage.UrbanDistrictCommune)
            };
        }

        public static NeighborhoodVillage Serialize(NeighborhoodVillageModel neighborhoodVillageModel)
        {
            return new NeighborhoodVillage
            {
                Id = neighborhoodVillageModel.Id,
                CreatedOn = neighborhoodVillageModel.CreatedOn,
                UpdatedOn = neighborhoodVillageModel.UpdatedOn,
                Name = neighborhoodVillageModel.Name,
                UrbanDistrictCommune = UrbanDistrictCommuneMapper.Serialize(neighborhoodVillageModel.UrbanDistrictCommune)
            };
        }
    }
}
