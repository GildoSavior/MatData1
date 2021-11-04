using MatData.Data;
using MatData.Models;
using MatData.Models.Records;
using MatData.Serialization;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using CsvHelper.Configuration;
using System.Globalization;
using CsvHelper;
using Newtonsoft.Json;

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
                    var fileName = Path.Combine(destinationPath, file.FileName);
                    using (var filestream = File.Create(fileName))
                    {
                        await file.CopyToAsync(filestream);
                        filestream.Flush();
                    }

                    var list = new List<Quiz>();
                    var config = new CsvConfiguration(CultureInfo.InvariantCulture)
                    {
                        HasHeaderRecord = false,
                    };

                    using (var reader = new StreamReader(fileName))
                    using (var csv = new CsvReader(reader, config))
                    {
                        var records = csv.GetRecords<Quiz>()
                            .ToList();

                        for (var i = 0; i < records.Count; i++)
                        {
                            if (i == 0)
                                continue;

                            var record = records[i];

                            if (record.FormId == "Q01")
                            {
                                var quiz = QuizMapper.Serialize<Q1Record>(record);

                                var props = new Dictionary<string, string>();

                                foreach (var prop in quiz.Data.GetType().GetProperties())
                                {
                                    props.Add(prop.Name, prop.GetValue(quiz.Data, null)?.ToString());
                                }

                                var now = DateTime.Now;

                                _db.IndicatorResponses.Add(new IndicatorResponse
                                {
                                    CreatedOn = now,
                                    UpdatedOn = now,
                                    Data = JsonConvert.SerializeObject(Q1Mapper.Serialize(quiz.Data)),
                                    Indicator = _db.Indicators.Find(1),
                                    Province = _db.Provinces.FirstOrDefault(p => p.Name == props["q101"]),
                                    Municipe = _db.Municipes.FirstOrDefault(p => p.Name == props["q102"])
                                });

                                _db.SaveChanges();
                            }

                            if (record.FormId == "Q02")
                            {
                                var quiz = QuizMapper.Serialize<Q2Record>(record);

                                var props = new Dictionary<string, string>();

                                foreach (var prop in quiz.Data.GetType().GetProperties())
                                {
                                    props.Add(prop.Name, prop.GetValue(quiz.Data, null)?.ToString());
                                }

                                var now = DateTime.Now;

                                _db.IndicatorResponses.Add(new IndicatorResponse
                                {
                                    CreatedOn = now,
                                    UpdatedOn = now,
                                    Data = JsonConvert.SerializeObject(Q2Mapper.Serialize(quiz.Data)),
                                    Indicator = _db.Indicators.Find(2),
                                    Province = _db.Provinces.FirstOrDefault(p => p.Name == props["q201"]),
                                    Municipe = _db.Municipes.FirstOrDefault(p => p.Name == props["q202"]),
                                    UrbanDistrictCommune = _db.UrbanDistrictCommunes.FirstOrDefault(p => p.Name == props["q203"])
                                });

                                _db.SaveChanges();
                            }

                            if (record.FormId == "Q03")
                            {
                                var quiz = QuizMapper.Serialize<Q3Record>(record);

                                var props = new Dictionary<string, string>();

                                foreach (var prop in quiz.Data.GetType().GetProperties())
                                {
                                    props.Add(prop.Name, prop.GetValue(quiz.Data, null)?.ToString());
                                }

                                var now = DateTime.Now;

                                _db.IndicatorResponses.Add(new IndicatorResponse
                                {
                                    CreatedOn = now,
                                    UpdatedOn = now,
                                    Data = JsonConvert.SerializeObject(Q3Mapper.Serialize(quiz.Data)),
                                    Indicator = _db.Indicators.Find(3),
                                    Province = _db.Provinces.FirstOrDefault(p => p.Name == props["q301"]),
                                    Municipe = _db.Municipes.FirstOrDefault(p => p.Name == props["q302"]),
                                    UrbanDistrictCommune = _db.UrbanDistrictCommunes.FirstOrDefault(p => p.Name == props["q303"]),
                                    NeighborhoodVillage = _db.NeighborhoodVillages.FirstOrDefault(p => p.Name == props["q304"])
                                });

                                _db.SaveChanges();
                            }

                            if (record.FormId == "Q04")
                            {
                                var quiz = QuizMapper.Serialize<Q4Record>(record);

                                var props = new Dictionary<string, string>();

                                foreach (var prop in quiz.Data.GetType().GetProperties())
                                {
                                    props.Add(prop.Name, prop.GetValue(quiz.Data, null)?.ToString());
                                }

                                var now = DateTime.Now;

                                _db.IndicatorResponses.Add(new IndicatorResponse
                                {
                                    CreatedOn = now,
                                    UpdatedOn = now,
                                    Data = JsonConvert.SerializeObject(Q4Mapper.Serialize(quiz.Data)),
                                    Indicator = _db.Indicators.Find(4),
                                    Province = _db.Provinces.FirstOrDefault(p => p.Name == props["q401"]),
                                    Municipe = _db.Municipes.FirstOrDefault(p => p.Name == props["q402"]),
                                    UrbanDistrictCommune = _db.UrbanDistrictCommunes.FirstOrDefault(p => p.Name == props["q403"]),
                                    NeighborhoodVillage = _db.NeighborhoodVillages.FirstOrDefault(p => p.Name == props["q404"])
                                });

                                _db.SaveChanges();
                            }

                            if (record.FormId == "Q05")
                            {
                                var quiz = QuizMapper.Serialize<Q5Record>(record);

                                var props = new Dictionary<string, string>();

                                foreach (var prop in quiz.Data.GetType().GetProperties())
                                {
                                    props.Add(prop.Name, prop.GetValue(quiz.Data, null)?.ToString());
                                }

                                var now = DateTime.Now;

                                _db.IndicatorResponses.Add(new IndicatorResponse
                                {
                                    CreatedOn = now,
                                    UpdatedOn = now,
                                    Data = JsonConvert.SerializeObject(Q5Mapper.Serialize(quiz.Data)),
                                    Indicator = _db.Indicators.Find(5),
                                    Province = _db.Provinces.FirstOrDefault(p => p.Name == props["q501"]),
                                    Municipe = _db.Municipes.FirstOrDefault(p => p.Name == props["q502"]),
                                });

                                _db.SaveChanges();
                            }

                            if (record.FormId == "Q06")
                            {
                                var quiz = QuizMapper.Serialize<Q6Record>(record);

                                var props = new Dictionary<string, string>();

                                foreach (var prop in quiz.Data.GetType().GetProperties())
                                {
                                    props.Add(prop.Name, prop.GetValue(quiz.Data, null)?.ToString());
                                }

                                var now = DateTime.Now;

                                _db.IndicatorResponses.Add(new IndicatorResponse
                                {
                                    CreatedOn = now,
                                    UpdatedOn = now,
                                    Data = JsonConvert.SerializeObject(Q6Mapper.Serialize(quiz.Data)),
                                    Indicator = _db.Indicators.Find(6),
                                    Province = _db.Provinces.FirstOrDefault(p => p.Name == props["q601"]),
                                    Municipe = _db.Municipes.FirstOrDefault(p => p.Name == props["q602"]),
                                });

                                _db.SaveChanges();
                            }

                            if (record.FormId == "Q07")
                            {
                                var quiz = QuizMapper.Serialize<Q7Record>(record);

                                var props = new Dictionary<string, string>();

                                foreach (var prop in quiz.Data.GetType().GetProperties())
                                {
                                    props.Add(prop.Name, prop.GetValue(quiz.Data, null)?.ToString());
                                }

                                var now = DateTime.Now;

                                _db.IndicatorResponses.Add(new IndicatorResponse
                                {
                                    CreatedOn = now,
                                    UpdatedOn = now,
                                    Data = JsonConvert.SerializeObject(Q7Mapper.Serialize(quiz.Data)),
                                    Indicator = _db.Indicators.Find(7),
                                    Province = _db.Provinces.FirstOrDefault(p => p.Name == props["q701"]),
                                    Municipe = _db.Municipes.FirstOrDefault(p => p.Name == props["q702"]),
                                });

                                _db.SaveChanges();
                            }

                            if (record.FormId == "Q10")
                            {
                                var quiz = QuizMapper.Serialize<Q10Record>(record);

                                var props = new Dictionary<string, string>();

                                foreach (var prop in quiz.Data.GetType().GetProperties())
                                {
                                    props.Add(prop.Name, prop.GetValue(quiz.Data, null)?.ToString());
                                }

                                var now = DateTime.Now;

                                _db.IndicatorResponses.Add(new IndicatorResponse
                                {
                                    CreatedOn = now,
                                    UpdatedOn = now,
                                    Data = JsonConvert.SerializeObject(Q10Mapper.Serialize(quiz.Data)),
                                    Indicator = _db.Indicators.Find(10),
                                    Province = _db.Provinces.FirstOrDefault(p => p.Name == props["q1001"]),
                                    Municipe = _db.Municipes.FirstOrDefault(p => p.Name == props["q1002"]),
                                    UrbanDistrictCommune = _db.UrbanDistrictCommunes.FirstOrDefault(p => p.Name == props["q1003"]),
                                    NeighborhoodVillage = _db.NeighborhoodVillages.FirstOrDefault(p => p.Name == props["q1004"]),
                                });

                                _db.SaveChanges();
                            }                  
                        }
                    }

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

    }
}
