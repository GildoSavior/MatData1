using System.Collections.Generic;

namespace MatData.Services.NeighborhoodVillage
{
    public interface INeighborhoodVillageService
    {
        List<Models.NeighborhoodVillage> GetAllNeighborhoodVillages();
        ServiceResponse<Models.NeighborhoodVillage> CreateNeighborhoodVillage(Models.NeighborhoodVillage neighborhoodVillage);
        ServiceResponse<bool> DeleteNeighborhoodVillage(int id);
        Models.NeighborhoodVillage GetById(int id);

        object GetNeighborhoodVillagePerPage(int pageIndex, int pageSize);
    }
}
