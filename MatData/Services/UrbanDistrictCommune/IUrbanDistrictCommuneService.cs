using System.Collections.Generic;

namespace MatData.Services.UrbanDistrictCommune
{
    public interface IUrbanDistrictCommuneService
    {
        List<Models.UrbanDistrictCommune> GetAllUrbanDistrictCommunes();
        ServiceResponse<Models.UrbanDistrictCommune> CreateUrbanDistrictCommune(Models.UrbanDistrictCommune urbanDistrictCommune);
        ServiceResponse<bool> DeleteUrbanDistrictCommune(int id);
        Models.UrbanDistrictCommune GetById(int id);
    }
}
