using MatData.Models;
using MatData.ViewModels;

namespace MatData.Serialization
{
    public static class MunicipeMapper
    {
        public static MunicipeModel Serialize(Municipe municipe)
        {
            return new MunicipeModel
            {
                Id = municipe.Id,
                CreatedOn = municipe.CreatedOn,
                UpdatedOn = municipe.UpdatedOn,
                Name = municipe.Name,
                Province = ProvinceMapper.Serialize(municipe.Province)
            };
        }

        public static Municipe Serialize(MunicipeModel municipeModel)
        {
            return new Municipe
            {
                Id = municipeModel.Id,
                CreatedOn = municipeModel.CreatedOn,
                UpdatedOn = municipeModel.UpdatedOn,
                Name = municipeModel.Name,
                Province = ProvinceMapper.Serialize(municipeModel.Province)
            };
        }
    }
}
