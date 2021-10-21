using MatData.Models;
using MatData.ViewModels;

namespace MatData.Serialization
{
    public static class UrbanDistrictCommuneMapper
    {
        public static UrbanDistrictCommuneModel Serialize(UrbanDistrictCommune urbanDistrictCommune)
        {
            return new UrbanDistrictCommuneModel
            {
                Id = urbanDistrictCommune.Id,
                CreatedOn = urbanDistrictCommune.CreatedOn,
                UpdatedOn = urbanDistrictCommune.UpdatedOn,
                Name = urbanDistrictCommune.Name,
                Municipe = MunicipeMapper.Serialize(urbanDistrictCommune.Municipe)
            };
        }

        public static UrbanDistrictCommune Serialize(UrbanDistrictCommuneModel urbanDistrictCommune)
        {
            return new UrbanDistrictCommune
            {
                Id = urbanDistrictCommune.Id,
                CreatedOn = urbanDistrictCommune.CreatedOn,
                UpdatedOn = urbanDistrictCommune.UpdatedOn,
                Name = urbanDistrictCommune.Name,
                Municipe = MunicipeMapper.Serialize(urbanDistrictCommune.Municipe)
            };
        }
    }
}
