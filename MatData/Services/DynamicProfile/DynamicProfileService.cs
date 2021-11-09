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

                            if (record.FormId == "Q08")
                            {
                                var quiz = QuizMapper.Serialize<Q8Record>(record);

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
                                    Data = JsonConvert.SerializeObject(Q8Mapper.Serialize(quiz.Data)),
                                    Indicator = _db.Indicators.Find(8),
                                    Province = _db.Provinces.FirstOrDefault(p => p.Name == props["q801"]),
                                    Municipe = _db.Municipes.FirstOrDefault(p => p.Name == props["q802"]),
                                });

                                _db.SaveChanges();
                            }

                            if (record.FormId == "Q09")
                            {
                                var quiz = QuizMapper.Serialize<Q9Record>(record);

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
                                    Data = JsonConvert.SerializeObject(Q9Mapper.Serialize(quiz.Data)),
                                    Indicator = _db.Indicators.Find(9),
                                    Province = _db.Provinces.FirstOrDefault(p => p.Name == props["q901"]),
                                    Municipe = _db.Municipes.FirstOrDefault(p => p.Name == props["q902"]),
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

                            if (record.FormId == "Q11")
                            {
                                var quiz = QuizMapper.Serialize<Q11Record>(record);

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
                                    Data = JsonConvert.SerializeObject(Q11Mapper.Serialize(quiz.Data)),
                                    Indicator = _db.Indicators.Find(11),
                                    Province = _db.Provinces.FirstOrDefault(p => p.Name == props["q1101"]),
                                    Municipe = _db.Municipes.FirstOrDefault(p => p.Name == props["q1102"]),
                                    UrbanDistrictCommune = _db.UrbanDistrictCommunes.FirstOrDefault(p => p.Name == props["q1103"]),
                                    NeighborhoodVillage = _db.NeighborhoodVillages.FirstOrDefault(p => p.Name == props["q1104"])
                                });

                                _db.SaveChanges();
                            }

                            if (record.FormId == "Q12")
                            {
                                var quiz = QuizMapper.Serialize<Q12Record>(record);

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
                                    Data = JsonConvert.SerializeObject(Q12Mapper.Serialize(quiz.Data)),
                                    Indicator = _db.Indicators.Find(12),
                                    Province = _db.Provinces.FirstOrDefault(p => p.Name == props["q1201"]),
                                    Municipe = _db.Municipes.FirstOrDefault(p => p.Name == props["q1202"])
                                });

                                _db.SaveChanges();
                            }

                            if (record.FormId == "Q13")
                            {
                                var quiz = QuizMapper.Serialize<Q13Record>(record);

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
                                    Data = JsonConvert.SerializeObject(Q13Mapper.Serialize(quiz.Data)),
                                    Indicator = _db.Indicators.Find(13),
                                    Province = _db.Provinces.FirstOrDefault(p => p.Name == props["q1301"]),
                                    Municipe = _db.Municipes.FirstOrDefault(p => p.Name == props["q1302"]),
                                    UrbanDistrictCommune = _db.UrbanDistrictCommunes.FirstOrDefault(p => p.Name == props["q1303"]),
                                    NeighborhoodVillage = _db.NeighborhoodVillages.FirstOrDefault(p => p.Name == props["q1304"]),
                                });

                                _db.SaveChanges();
                            }

                            if (record.FormId == "Q14")
                            {
                                var quiz = QuizMapper.Serialize<Q14Record>(record);

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
                                    Data = JsonConvert.SerializeObject(Q14Mapper.Serialize(quiz.Data)),
                                    Indicator = _db.Indicators.Find(14),
                                    Province = _db.Provinces.FirstOrDefault(p => p.Name == props["q1401"]),
                                    Municipe = _db.Municipes.FirstOrDefault(p => p.Name == props["q1402"]),
                                    UrbanDistrictCommune = _db.UrbanDistrictCommunes.FirstOrDefault(p => p.Name == props["q1403"]),
                                    NeighborhoodVillage = _db.NeighborhoodVillages.FirstOrDefault(p => p.Name == props["q1404"]),
                                });

                                _db.SaveChanges();
                            }

                            if (record.FormId == "Q15")
                            {
                                var quiz = QuizMapper.Serialize<Q15Record>(record);

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
                                    Data = JsonConvert.SerializeObject(Q15Mapper.Serialize(quiz.Data)),
                                    Indicator = _db.Indicators.Find(15),
                                    Province = _db.Provinces.FirstOrDefault(p => p.Name == props["q1501"]),
                                    Municipe = _db.Municipes.FirstOrDefault(p => p.Name == props["q1502"]),
                                    UrbanDistrictCommune = _db.UrbanDistrictCommunes.FirstOrDefault(p => p.Name == props["q1503"]),
                                    NeighborhoodVillage = _db.NeighborhoodVillages.FirstOrDefault(p => p.Name == props["q1504"]),
                                });

                                _db.SaveChanges();
                            }

                            if (record.FormId == "Q16")
                            {
                                var quiz = QuizMapper.Serialize<Q16Record>(record);

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
                                    Data = JsonConvert.SerializeObject(Q16Mapper.Serialize(quiz.Data)),
                                    Indicator = _db.Indicators.Find(16),
                                    Province = _db.Provinces.FirstOrDefault(p => p.Name == props["q1601"]),
                                    Municipe = _db.Municipes.FirstOrDefault(p => p.Name == props["q1602"]),

                                });

                                _db.SaveChanges();
                            }

                            if (record.FormId == "Q17")
                            {
                                var quiz = QuizMapper.Serialize<Q17Record>(record);

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
                                    Data = JsonConvert.SerializeObject(Q17Mapper.Serialize(quiz.Data)),
                                    Indicator = _db.Indicators.Find(17),
                                    Province = _db.Provinces.FirstOrDefault(p => p.Name == props["q1701"]),
                                    Municipe = _db.Municipes.FirstOrDefault(p => p.Name == props["q1702"]),
                                    UrbanDistrictCommune = _db.UrbanDistrictCommunes.FirstOrDefault(p => p.Name == props["q1703"]),
                                    NeighborhoodVillage = _db.NeighborhoodVillages.FirstOrDefault(p => p.Name == props["q1704"]),

                                });

                                _db.SaveChanges();
                            }

                            if (record.FormId == "Q18")
                            {
                                var quiz = QuizMapper.Serialize<Q18Record>(record);

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
                                    Data = JsonConvert.SerializeObject(Q17Mapper.Serialize(quiz.Data)),
                                    Indicator = _db.Indicators.Find(18),
                                    Province = _db.Provinces.FirstOrDefault(p => p.Name == props["q1801"]),
                                    Municipe = _db.Municipes.FirstOrDefault(p => p.Name == props["q1802"]),
                                    UrbanDistrictCommune = _db.UrbanDistrictCommunes.FirstOrDefault(p => p.Name == props["q1803"]),
                                    NeighborhoodVillage = _db.NeighborhoodVillages.FirstOrDefault(p => p.Name == props["q1804"]),

                                });

                                _db.SaveChanges();
                            }

                            if (record.FormId == "Q19")
                            {
                                var quiz = QuizMapper.Serialize<Q19Record>(record);

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
                                    Data = JsonConvert.SerializeObject(Q19Mapper.Serialize(quiz.Data)),
                                    Indicator = _db.Indicators.Find(19),
                                    Province = _db.Provinces.FirstOrDefault(p => p.Name == props["q1901"]),
                                    Municipe = _db.Municipes.FirstOrDefault(p => p.Name == props["q1902"]),
                                    UrbanDistrictCommune = _db.UrbanDistrictCommunes.FirstOrDefault(p => p.Name == props["q1903"]),
                                    NeighborhoodVillage = _db.NeighborhoodVillages.FirstOrDefault(p => p.Name == props["q1904"]),

                                });

                                _db.SaveChanges();
                            }

                            if (record.FormId == "Q20")
                            {
                                var quiz = QuizMapper.Serialize<Q20Record>(record);

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
                                    Data = JsonConvert.SerializeObject(Q20Mapper.Serialize(quiz.Data)),
                                    Indicator = _db.Indicators.Find(20),
                                    Province = _db.Provinces.FirstOrDefault(p => p.Name == props["q2001"]),
                                    Municipe = _db.Municipes.FirstOrDefault(p => p.Name == props["q2002"]),
                                    UrbanDistrictCommune = _db.UrbanDistrictCommunes.FirstOrDefault(p => p.Name == props["q2003"]),
                                    NeighborhoodVillage = _db.NeighborhoodVillages.FirstOrDefault(p => p.Name == props["q2004"]),

                                });

                                _db.SaveChanges();
                            }

                            if (record.FormId == "Q21")
                            {
                                var quiz = QuizMapper.Serialize<Q21Record>(record);

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
                                    Data = JsonConvert.SerializeObject(Q21Mapper.Serialize(quiz.Data)),
                                    Indicator = _db.Indicators.Find(21),
                                    Province = _db.Provinces.FirstOrDefault(p => p.Name == props["q2101"]),
                                    Municipe = _db.Municipes.FirstOrDefault(p => p.Name == props["q2102"]),
                                    UrbanDistrictCommune = _db.UrbanDistrictCommunes.FirstOrDefault(p => p.Name == props["q2103"]),
                                    NeighborhoodVillage = _db.NeighborhoodVillages.FirstOrDefault(p => p.Name == props["q2104"]),

                                });

                                _db.SaveChanges();
                            }

                            if (record.FormId == "Q22")
                            {
                                var quiz = QuizMapper.Serialize<Q22Record>(record);

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
                                    Data = JsonConvert.SerializeObject(Q22Mapper.Serialize(quiz.Data)),
                                    Indicator = _db.Indicators.Find(22),
                                    Province = _db.Provinces.FirstOrDefault(p => p.Name == props["q2201"]),
                                    Municipe = _db.Municipes.FirstOrDefault(p => p.Name == props["q2202"]),
                                    UrbanDistrictCommune = _db.UrbanDistrictCommunes.FirstOrDefault(p => p.Name == props["q2203"]),
                                    NeighborhoodVillage = _db.NeighborhoodVillages.FirstOrDefault(p => p.Name == props["q2204"]),

                                });

                                _db.SaveChanges();
                            }

                            if (record.FormId == "Q23")
                            {
                                var quiz = QuizMapper.Serialize<Q23Record>(record);

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
                                    Data = JsonConvert.SerializeObject(Q23Mapper.Serialize(quiz.Data)),
                                    Indicator = _db.Indicators.Find(19),
                                    Province = _db.Provinces.FirstOrDefault(p => p.Name == props["q2301"]),
                                    Municipe = _db.Municipes.FirstOrDefault(p => p.Name == props["q2302"]),
                                    UrbanDistrictCommune = _db.UrbanDistrictCommunes.FirstOrDefault(p => p.Name == props["q2303"]),
                                    NeighborhoodVillage = _db.NeighborhoodVillages.FirstOrDefault(p => p.Name == props["q2304"]),

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
