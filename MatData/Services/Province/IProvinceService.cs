using System.Collections.Generic;

namespace MatData.Services.Province
{
    public interface IProvinceService
    {
        List<Models.Province> GetAllProvinces();
        ServiceResponse<Models.Province> CreateProvince(Models.Province province);
        ServiceResponse<bool> DeleteProvince(int id);
        Models.Province GetById(int id);
    }
}
