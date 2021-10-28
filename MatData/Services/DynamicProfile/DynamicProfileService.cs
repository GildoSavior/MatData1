using MatData.Data;
using MatData.Models;
using MatData.Models.Records;
using MatData.Serialization;
using MatData.ViewModels;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace MatData.Services.DynamicProfile
{
    public class DynamicProfileService : IDynamicProfileService
    {
        public static IWebHostEnvironment _environment;
        public readonly AppDbContext _db;

        public DynamicProfileService(IWebHostEnvironment environment, AppDbContext db)
        {
            _db = db;
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

                    using (var filestream = File.Create(Path.Combine(destinationPath, file.FileName)))
                    {
                        await file.CopyToAsync(filestream);
                        filestream.Flush();
                    }

                    var list = QuizMapper.Serializes(Path.Combine(destinationPath, file.FileName));

                    saveData(list);

                    return new ServiceResponse<bool>
                    {
                        Data = true,
                        IsSuccess = true,
                        Message = "Importação de dados realizado com sucesso!",
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

        public void saveData(List<Quiz> list)
        {
            List<QuizModel> models = RecordMapper.Serialize(list);

            foreach (var record in models)
            {
                _db.IndicatorResponses.Add(new IndicatorResponse
                {
                    Province = ,
                    Municipe = ,
                    Indicator = ,
                    Data = ,
                    UrbanDistrictCommune = ,
                    NeighborhoodVillage = ,
                    CreatedOn = DateTime.Now,
                    UpdatedOn = DateTime.Now,
                });
            }
        }
    }
}
