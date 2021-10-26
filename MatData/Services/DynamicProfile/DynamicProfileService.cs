using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using System;
using System.IO;
using System.Threading.Tasks;

namespace MatData.Services.DynamicProfile
{
    public class DynamicProfileService : IDynamicProfileService
    {
        public static IWebHostEnvironment _environment;

        public DynamicProfileService(IWebHostEnvironment environment)
        {
            _environment = environment;
        } 

        public async Task<ServiceResponse<bool>> importData(IFormFile file)
        {
            if (file.Length > 0)
            {
                try
                {
                    var repositoryPath = Path.Combine(_environment.WebRootPath, "Repository");
                    if (!Directory.Exists(repositoryPath))
                    {
                        Directory.CreateDirectory(repositoryPath);
                    }

                    var destinationPath = Path.Combine(repositoryPath, "ProvinceName");

                    if (!Directory.Exists(destinationPath))
                    {
                        Directory.CreateDirectory(destinationPath);
                    }

                    using FileStream filestream = File.Create(Path.Combine(destinationPath, file.FileName));
                    await file.CopyToAsync(filestream);
                    filestream.Flush();
                    return new ServiceResponse<bool>
                    {
                        Data = true,
                        IsSuccess = true,
                        Message = "Dynamic profile imported with success",
                        Time = DateTime.Now
                    };
                }
                catch (Exception e)
                {
                    return new ServiceResponse<bool>
                    {
                        Data = false,
                        IsSuccess = false,
                        Message = e.StackTrace,
                        Time = DateTime.Now
                    };
                }
            }
            else
            {
                return new ServiceResponse<bool>
                {
                    Data = false,
                    IsSuccess = false,
                    Message = "An error occurred in sending",
                    Time = DateTime.Now
                };
            }
        }
    }
}
