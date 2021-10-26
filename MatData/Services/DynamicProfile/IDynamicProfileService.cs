using Microsoft.AspNetCore.Http;
using System.Threading.Tasks;

namespace MatData.Services.DynamicProfile
{
    public interface IDynamicProfileService
    {
        Task<ServiceResponse<bool>> importData(IFormFile file);
    }
}
