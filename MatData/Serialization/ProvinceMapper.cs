using MatData.Models;
using MatData.ViewModels;

namespace MatData.Serialization
{
    public static class ProvinceMapper
    {
        public static ProvinceModel Serialize(Province province)
        {
            return new ProvinceModel
            {
                Id = province.Id,
                CreatedOn = province.CreatedOn,
                UpdatedOn = province.UpdatedOn,
                Name = province.Name
            };
        }

        public static Province Serialize(ProvinceModel provinceModel)
        {
            return new Province
            {
                Id = provinceModel.Id,
                CreatedOn = provinceModel.CreatedOn,
                UpdatedOn = provinceModel.UpdatedOn,
                Name = provinceModel.Name
            };
        }
    }
}
