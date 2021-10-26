using MatData.Services.DynamicProfile;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.IO;
using System.Threading.Tasks;

namespace MatData.Controllers
{
    [Route("api/v1/[controller]")]
    [ApiController]
    public class DynamicProfileController : ControllerBase
    {
        private readonly IDynamicProfileService _dynamicProfileService;

        public DynamicProfileController(IDynamicProfileService dynamicProfileService)
        {
            _dynamicProfileService = dynamicProfileService;
        }

        [HttpPost]
        public async Task<ActionResult<ServiceResponse<bool>>> ImportData(IFormFile file)
        {
            return await _dynamicProfileService.importData(file);
        }
    }
}
