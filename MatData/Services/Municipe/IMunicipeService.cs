using System.Collections.Generic;

namespace MatData.Services.Municipe
{
    public interface IMunicipeService
    {
        List<Models.Municipe> GetAllMunicipes();
        ServiceResponse<Models.Municipe> CreateMunicipe(Models.Municipe municipe);
        ServiceResponse<bool> DeleteMunicipe(int id);
        Models.Municipe GetById(int id);
    }
}
