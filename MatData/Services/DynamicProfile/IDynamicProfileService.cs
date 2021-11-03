using MatData.Models;
using Microsoft.AspNetCore.Http;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace MatData.Services.DynamicProfile
{
    public interface IDynamicProfileService
    {
        Task<ServiceResponse<bool>> importData(IFormFile file);
    }
}
