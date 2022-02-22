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
using static MatData.Serialization.Q35Mapper;
using Matdata.API.ViewModels;
using System.IO.Compression;
using Matdata.API.Serialization;
using Microsoft.Extensions.Logging;
using MatData.Services.Municipe;

namespace MatData.Services.DynamicProfile
{
    public class DynamicProfileService : IDynamicProfileService
    {
        public static IWebHostEnvironment _environment;
        public readonly AppDbContext _db;
        private readonly ILogger<DynamicProfileService> _logger;
        private readonly IHistoryDataService _historyDataService;

        public DynamicProfileService(ILogger<DynamicProfileService> logger, IWebHostEnvironment environment, AppDbContext db, IHistoryDataService historyDataService)
        {
            _db = db;
            _environment = environment;
            _logger = logger;
            _historyDataService = historyDataService;
        }

        public async Task<ServiceResponse<bool>> importData(ProfileVM model, IFormFile file)
        {
            if (file.Length > 0)
            {
                if (!file.FileName.EndsWith(".zip"))
                {
                    return new ServiceResponse<bool>
                    {
                        Data = false,
                        IsSuccess = false,
                        Message = "Ficheiro invalido",
                        Time = DateTime.Now
                    };
                }

                try
                {
                    var repositoryPath = Path.Combine(_environment.WebRootPath, "Repository");
                    if (!Directory.Exists(repositoryPath))
                    {
                        Directory.CreateDirectory(repositoryPath);
                    }

                    var destinationPath = Path.Combine(repositoryPath, "Images");

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

                    // Ler o Zip
                    var zipPath = Path.Combine(destinationPath, file.FileName);

                    // Extrar as Images
                    // Extrair o CSV
                    try
                    {
                        using(ZipArchive archive = ZipFile.OpenRead(zipPath))
                        {
                            foreach (ZipArchiveEntry entry in archive.Entries)
                            {
                                if (entry.FullName.EndsWith(".csv", StringComparison.OrdinalIgnoreCase))
                                {
                                    string csvDestinationPath = Path.GetFullPath(Path.Combine(destinationPath, entry.FullName));

                                    if (csvDestinationPath.StartsWith(destinationPath, StringComparison.Ordinal))
                                        if (!File.Exists(csvDestinationPath))
                                            entry.ExtractToFile(csvDestinationPath);
                                }

                                if (entry.FullName.StartsWith("Images", StringComparison.OrdinalIgnoreCase))
                                {
                                    string imageDestinationPath =
                                        Path.GetFullPath(Path.Combine(destinationPath, entry.FullName));

                                    if (imageDestinationPath.StartsWith(destinationPath, StringComparison.Ordinal))
                                        if (entry.FullName != "Images/")
                                            if (!File.Exists(imageDestinationPath))
                                                entry.ExtractToFile(imageDestinationPath);
                                }
                            }
                        }
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine(e.Message);
                        // Apagar o zip

                        return new ServiceResponse<bool>
                        {
                            Data = false,
                            IsSuccess = false,
                            Message = "Erro ao descompactar o zip",
                            Time = DateTime.Now
                        };
                    }

                    var csvPath = Path.Combine(destinationPath,
                        $"Report-{file.FileName.Split("SIBM-DATA-")[1].Replace(".zip", ".csv")}");
                    using (var reader = new StreamReader(csvPath))
                    using (var csv = new CsvReader(reader, config))
                    {
                        var records = csv.GetRecords<Quiz>()
                            .ToList();

                        for (var i = 0; i < records.Count; i++)
                        {
                            if (i == 0)
                                continue;

                            var record = records[i];

                            var instanceExist = _db.IndicatorResponses.FirstOrDefault(x => x.InstanceId == record.InstanceId);

                            if (instanceExist != null) continue;

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
                                    Year = model.Year,
                                    InstanceId = record.InstanceId,
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
                                    Year = model.Year,
                                    InstanceId = record.InstanceId,
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
                                    Year = model.Year,
                                    InstanceId = record.InstanceId,
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
                                    Year = model.Year,
                                    InstanceId = record.InstanceId,
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
                                    Year = model.Year,
                                    InstanceId = record.InstanceId,
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
                                    Year = model.Year,
                                    InstanceId = record.InstanceId,
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
                                    Year = model.Year,
                                    InstanceId = record.InstanceId,
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
                                    Year = model.Year,
                                    InstanceId = record.InstanceId,
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
                                    Year = model.Year,
                                    InstanceId = record.InstanceId,
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
                                    Year = model.Year,
                                    InstanceId = record.InstanceId,
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
                                    Year = model.Year,
                                    InstanceId = record.InstanceId,
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
                                    Year = model.Year,
                                    InstanceId = record.InstanceId,
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
                                    Year = model.Year,
                                    InstanceId = record.InstanceId,
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
                                    Year = model.Year,
                                    InstanceId = record.InstanceId,
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
                                    Year = model.Year,
                                    InstanceId = record.InstanceId,
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
                                    Year = model.Year,
                                    InstanceId = record.InstanceId,
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
                                    Year = model.Year,
                                    InstanceId = record.InstanceId,
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
                                    Year = props["q1806"],
                                    InstanceId = record.InstanceId,
                                    Data = JsonConvert.SerializeObject(Q18Mapper.Serialize(quiz.Data)),
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
                                    Year = model.Year,
                                    InstanceId = record.InstanceId,
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
                                    Year = model.Year,
                                    InstanceId = record.InstanceId,
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
                                    Year = model.Year,
                                    InstanceId = record.InstanceId,
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
                                    Year = model.Year,
                                    InstanceId = record.InstanceId,
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
                                    Year = model.Year,
                                    InstanceId = record.InstanceId,
                                    Data = JsonConvert.SerializeObject(Q23Mapper.Serialize(quiz.Data)),
                                    Indicator = _db.Indicators.Find(23),
                                    Province = _db.Provinces.FirstOrDefault(p => p.Name == props["q2301"]),
                                    Municipe = _db.Municipes.FirstOrDefault(p => p.Name == props["q2302"]),
                                    UrbanDistrictCommune = _db.UrbanDistrictCommunes.FirstOrDefault(p => p.Name == props["q2303"]),
                                    NeighborhoodVillage = _db.NeighborhoodVillages.FirstOrDefault(p => p.Name == props["q2304"]),

                                });

                                _db.SaveChanges();
                            }

                            if (record.FormId == "Q24")
                            {
                                var quiz = QuizMapper.Serialize<Q24Record>(record);

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
                                    Year = model.Year,
                                    InstanceId = record.InstanceId,
                                    Data = JsonConvert.SerializeObject(Q24Mapper.Serialize(quiz.Data)),
                                    Indicator = _db.Indicators.Find(24),
                                    Province = _db.Provinces.FirstOrDefault(p => p.Name == props["q2401"]),
                                    Municipe = _db.Municipes.FirstOrDefault(p => p.Name == props["q2402"]),
                                    UrbanDistrictCommune = _db.UrbanDistrictCommunes.FirstOrDefault(p => p.Name == props["q2403"]),
                                    NeighborhoodVillage = _db.NeighborhoodVillages.FirstOrDefault(p => p.Name == props["q2404"]),

                                });

                                _db.SaveChanges();
                            }

                            if (record.FormId == "Q25")
                            {
                                var quiz = QuizMapper.Serialize<Q25Record>(record);

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
                                    Year = model.Year,
                                    InstanceId = record.InstanceId,
                                    Data = JsonConvert.SerializeObject(Q25Mapper.Serialize(quiz.Data)),
                                    Indicator = _db.Indicators.Find(25),
                                    Province = _db.Provinces.FirstOrDefault(p => p.Name == props["q2501"]),
                                    Municipe = _db.Municipes.FirstOrDefault(p => p.Name == props["q2502"]),
                                    UrbanDistrictCommune = _db.UrbanDistrictCommunes.FirstOrDefault(p => p.Name == props["q2503"]),
                                    NeighborhoodVillage = _db.NeighborhoodVillages.FirstOrDefault(p => p.Name == props["q2504"]),

                                });

                                _db.SaveChanges();
                            }

                            if (record.FormId == "Q26")
                            {
                                var quiz = QuizMapper.Serialize<Q26Record>(record);

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
                                    Year = model.Year,
                                    InstanceId = record.InstanceId,
                                    Data = JsonConvert.SerializeObject(Q26Mapper.Serialize(quiz.Data)),
                                    Indicator = _db.Indicators.Find(26),
                                    Province = _db.Provinces.FirstOrDefault(p => p.Name == props["q2601"]),
                                    Municipe = _db.Municipes.FirstOrDefault(p => p.Name == props["q2602"]),
                                    UrbanDistrictCommune = _db.UrbanDistrictCommunes.FirstOrDefault(p => p.Name == props["q2603"]),
                                    NeighborhoodVillage = _db.NeighborhoodVillages.FirstOrDefault(p => p.Name == props["q2604"]),

                                });

                                _db.SaveChanges();
                            }

                            if (record.FormId == "Q27")
                            {
                                var quiz = QuizMapper.Serialize<Q27Record>(record);

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
                                    Year = model.Year,
                                    InstanceId = record.InstanceId,
                                    Data = JsonConvert.SerializeObject(Q27Mapper.Serialize(quiz.Data)),
                                    Indicator = _db.Indicators.Find(27),
                                    Province = _db.Provinces.FirstOrDefault(p => p.Name == props["q2701"]),
                                    Municipe = _db.Municipes.FirstOrDefault(p => p.Name == props["q2702"]),
                                    UrbanDistrictCommune = _db.UrbanDistrictCommunes.FirstOrDefault(p => p.Name == props["q2703"]),
                                    NeighborhoodVillage = _db.NeighborhoodVillages.FirstOrDefault(p => p.Name == props["q2704"]),

                                });

                                _db.SaveChanges();
                            }


                            if (record.FormId == "Q28")
                            {
                                var quiz = QuizMapper.Serialize<Q28Record>(record);

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
                                    Year = model.Year,
                                    InstanceId = record.InstanceId,
                                    Data = JsonConvert.SerializeObject(Q28Mapper.Serialize(quiz.Data)),
                                    Indicator = _db.Indicators.Find(28),
                                    Province = _db.Provinces.FirstOrDefault(p => p.Name == props["q2801"]),
                                    Municipe = _db.Municipes.FirstOrDefault(p => p.Name == props["q2802"]),
                                    UrbanDistrictCommune = _db.UrbanDistrictCommunes.FirstOrDefault(p => p.Name == props["q2803"]),
                                    NeighborhoodVillage = _db.NeighborhoodVillages.FirstOrDefault(p => p.Name == props["q2804"]),

                                });

                                _db.SaveChanges();
                            }

                            if (record.FormId == "Q29")
                            {
                                var quiz = QuizMapper.Serialize<Q29Record>(record);

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
                                    Year = model.Year,
                                    InstanceId = record.InstanceId,
                                    Data = JsonConvert.SerializeObject(Q29Mapper.Serialize(quiz.Data)),
                                    Indicator = _db.Indicators.Find(29),
                                    Province = _db.Provinces.FirstOrDefault(p => p.Name == props["q2901"]),
                                    Municipe = _db.Municipes.FirstOrDefault(p => p.Name == props["q2902"]),
                                    UrbanDistrictCommune = _db.UrbanDistrictCommunes.FirstOrDefault(p => p.Name == props["q2903"]),
                                    NeighborhoodVillage = _db.NeighborhoodVillages.FirstOrDefault(p => p.Name == props["q2904"])
                                });

                                _db.SaveChanges();
                            }

                            if (record.FormId == "Q30")
                            {
                                var quiz = QuizMapper.Serialize<Q30Record>(record);

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
                                    Year = model.Year,
                                    InstanceId = record.InstanceId,
                                    Data = JsonConvert.SerializeObject(Q30Mapper.Serialize(quiz.Data)),
                                    Indicator = _db.Indicators.Find(30),
                                    Province = _db.Provinces.FirstOrDefault(p => p.Name == props["q3001"]),
                                    Municipe = _db.Municipes.FirstOrDefault(p => p.Name == props["q3002"]),
                                    UrbanDistrictCommune = _db.UrbanDistrictCommunes.FirstOrDefault(p => p.Name == props["q3003"]),
                                    NeighborhoodVillage = _db.NeighborhoodVillages.FirstOrDefault(p => p.Name == props["q3004"]),

                                });

                                _db.SaveChanges();
                            }

                            if (record.FormId == "Q31")
                            {
                                var quiz = QuizMapper.Serialize<Q31Record>(record);

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
                                    Year = model.Year,
                                    InstanceId = record.InstanceId,
                                    Data = JsonConvert.SerializeObject(Q31Mapper.Serialize(quiz.Data)),
                                    Indicator = _db.Indicators.Find(31),
                                    Province = _db.Provinces.FirstOrDefault(p => p.Name == props["q3101"]),
                                    Municipe = _db.Municipes.FirstOrDefault(p => p.Name == props["q3102"]),
                                    UrbanDistrictCommune = _db.UrbanDistrictCommunes.FirstOrDefault(p => p.Name == props["q3103"]),
                                    NeighborhoodVillage = _db.NeighborhoodVillages.FirstOrDefault(p => p.Name == props["q3104"]),

                                });

                                _db.SaveChanges();
                            }

                            if (record.FormId == "Q32")
                            {
                                var quiz = QuizMapper.Serialize<Q32Record>(record);

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
                                    Year = model.Year,
                                    InstanceId = record.InstanceId,
                                    Data = JsonConvert.SerializeObject(Q32Mapper.Serialize(quiz.Data)),
                                    Indicator = _db.Indicators.Find(32),
                                    Province = _db.Provinces.FirstOrDefault(p => p.Name == props["q3201"]),
                                    Municipe = _db.Municipes.FirstOrDefault(p => p.Name == props["q3202"]),
                                    UrbanDistrictCommune = _db.UrbanDistrictCommunes.FirstOrDefault(p => p.Name == props["q3203"]),
                                    NeighborhoodVillage = _db.NeighborhoodVillages.FirstOrDefault(p => p.Name == props["q3204"]),

                                });

                                _db.SaveChanges();
                            }

                            if (record.FormId == "Q33")
                            {
                                var quiz = QuizMapper.Serialize<Q33Record>(record);

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
                                    Year = model.Year,
                                    InstanceId = record.InstanceId,
                                    Data = JsonConvert.SerializeObject(Q33Mapper.Serialize(quiz.Data)),
                                    Indicator = _db.Indicators.Find(33),
                                    Province = _db.Provinces.FirstOrDefault(p => p.Name == props["q3301"]),
                                    Municipe = _db.Municipes.FirstOrDefault(p => p.Name == props["q3302"]),
                                    UrbanDistrictCommune = _db.UrbanDistrictCommunes.FirstOrDefault(p => p.Name == props["q3303"]),
                                    NeighborhoodVillage = _db.NeighborhoodVillages.FirstOrDefault(p => p.Name == props["q3304"]),

                                });

                                _db.SaveChanges();
                            }

                            if (record.FormId == "Q34")
                            {
                                var quiz = QuizMapper.Serialize<Q34Record>(record);

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
                                    Year = model.Year,
                                    InstanceId = record.InstanceId,
                                    Data = JsonConvert.SerializeObject(Q34Mapper.Serialize(quiz.Data)),
                                    Indicator = _db.Indicators.Find(34),
                                    Province = _db.Provinces.FirstOrDefault(p => p.Name == props["q3401"]),
                                    Municipe = _db.Municipes.FirstOrDefault(p => p.Name == props["q3402"]),
                                    UrbanDistrictCommune = _db.UrbanDistrictCommunes.FirstOrDefault(p => p.Name == props["q3403"]),
                                    NeighborhoodVillage = _db.NeighborhoodVillages.FirstOrDefault(p => p.Name == props["q3404"]),

                                });

                                _db.SaveChanges();
                            }

                            if (record.FormId == "Q35")
                            {
                                var quiz = QuizMapper.Serialize<Q35Record>(record);

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
                                    Year = model.Year,
                                    InstanceId = record.InstanceId,
                                    Data = JsonConvert.SerializeObject(Q35Mapper.Serialize(quiz.Data)),
                                    Indicator = _db.Indicators.Find(35),
                                    Province = _db.Provinces.FirstOrDefault(p => p.Name == props["q3501"]),
                                    Municipe = _db.Municipes.FirstOrDefault(p => p.Name == props["q3502"])
                                });

                                _db.SaveChanges();
                            }

                            if (record.FormId == "Q36")
                            {
                                var quiz = QuizMapper.Serialize<Q36Record>(record);

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
                                    Year = model.Year,
                                    InstanceId = record.InstanceId,
                                    Data = JsonConvert.SerializeObject(Q36Mapper.Serialize(quiz.Data)),
                                    Indicator = _db.Indicators.Find(36),
                                    Province = _db.Provinces.FirstOrDefault(p => p.Name == props["q3601"]),
                                    Municipe = _db.Municipes.FirstOrDefault(p => p.Name == props["q3602"])
                                });

                                _db.SaveChanges();
                            }

                            if (record.FormId == "Q37")
                            {
                                var quiz = QuizMapper.Serialize<Q37Record>(record);

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
                                    Year = model.Year,
                                    InstanceId = record.InstanceId,
                                    Data = JsonConvert.SerializeObject(Q37Mapper.Serialize(quiz.Data)),
                                    Indicator = _db.Indicators.Find(37),
                                    Province = _db.Provinces.FirstOrDefault(p => p.Name == props["q3701"]),
                                    Municipe = _db.Municipes.FirstOrDefault(p => p.Name == props["q3702"]),
                                    UrbanDistrictCommune = _db.UrbanDistrictCommunes.FirstOrDefault(p => p.Name == props["q3703"]),
                                    NeighborhoodVillage = _db.NeighborhoodVillages.FirstOrDefault(p => p.Name == props["q3704"])
                                });

                                _db.SaveChanges();
                            }

                            if (record.FormId == "Q38")
                            {
                                var quiz = QuizMapper.Serialize<Q38Record>(record);

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
                                    Year = model.Year,
                                    InstanceId = record.InstanceId,
                                    Data = JsonConvert.SerializeObject(Q38Mapper.Serialize(quiz.Data)),
                                    Indicator = _db.Indicators.Find(38),
                                    Province = _db.Provinces.FirstOrDefault(p => p.Name == props["q3801"]),
                                    Municipe = _db.Municipes.FirstOrDefault(p => p.Name == props["q3802"]),
                                    UrbanDistrictCommune = _db.UrbanDistrictCommunes.FirstOrDefault(p => p.Name == props["q3803"]),
                                    NeighborhoodVillage = _db.NeighborhoodVillages.FirstOrDefault(p => p.Name == props["q3804"])
                                });

                                _db.SaveChanges();
                            }

                            if (record.FormId == "Q39")
                            {
                                var quiz = QuizMapper.Serialize<Q39Record>(record);

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
                                    Year = model.Year,
                                    InstanceId = record.InstanceId,
                                    Data = JsonConvert.SerializeObject(Q39Mapper.Serialize(quiz.Data)),
                                    Indicator = _db.Indicators.Find(39),
                                    Province = _db.Provinces.FirstOrDefault(p => p.Name == props["q3901"]),
                                    Municipe = _db.Municipes.FirstOrDefault(p => p.Name == props["q3902"]),
                                    UrbanDistrictCommune = _db.UrbanDistrictCommunes.FirstOrDefault(p => p.Name == props["q3903"]),
                                    NeighborhoodVillage = _db.NeighborhoodVillages.FirstOrDefault(p => p.Name == props["q3904"])
                                });

                                _db.SaveChanges();
                            }

                            if (record.FormId == "Q40")
                            {
                                var quiz = QuizMapper.Serialize<Q40Record>(record);

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
                                    Year = model.Year,
                                    InstanceId = record.InstanceId,
                                    Data = JsonConvert.SerializeObject(Q40Mapper.Serialize(quiz.Data)),
                                    Indicator = _db.Indicators.Find(40),
                                    Province = _db.Provinces.FirstOrDefault(p => p.Name == props["q4001"]),
                                    Municipe = _db.Municipes.FirstOrDefault(p => p.Name == props["q4002"]),
                                    UrbanDistrictCommune = _db.UrbanDistrictCommunes.FirstOrDefault(p => p.Name == props["q4003"]),
                                    NeighborhoodVillage = _db.NeighborhoodVillages.FirstOrDefault(p => p.Name == props["q4004"])
                                });

                                _db.SaveChanges();
                            }

                            if (record.FormId == "Q41")
                            {
                                var quiz = QuizMapper.Serialize<Q41Record>(record);

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
                                    Year = model.Year,
                                    InstanceId = record.InstanceId,
                                    Data = JsonConvert.SerializeObject(Q41Mapper.Serialize(quiz.Data)),
                                    Indicator = _db.Indicators.Find(41),
                                    Province = _db.Provinces.FirstOrDefault(p => p.Name == props["q4101"]),
                                    Municipe = _db.Municipes.FirstOrDefault(p => p.Name == props["q4102"])
                                });

                                _db.SaveChanges();
                            }

                            if (record.FormId == "Q42")
                            {
                                var quiz = QuizMapper.Serialize<Q42Record>(record);

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
                                    Year = model.Year,
                                    InstanceId = record.InstanceId,
                                    Data = JsonConvert.SerializeObject(Q42Mapper.Serialize(quiz.Data)),
                                    Indicator = _db.Indicators.Find(42),
                                    Province = _db.Provinces.FirstOrDefault(p => p.Name == props["q4201"]),
                                    Municipe = _db.Municipes.FirstOrDefault(p => p.Name == props["q4202"])
                                });

                                _db.SaveChanges();
                            }

                            if (record.FormId == "Q43")
                            {
                                var quiz = QuizMapper.Serialize<Q43Record>(record);

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
                                    Year = model.Year,
                                    InstanceId = record.InstanceId,
                                    Data = JsonConvert.SerializeObject(Q43Mapper.Serialize(quiz.Data)),
                                    Indicator = _db.Indicators.Find(43),
                                    Province = _db.Provinces.FirstOrDefault(p => p.Name == props["q4301"]),
                                    Municipe = _db.Municipes.FirstOrDefault(p => p.Name == props["q4302"]),
                                    UrbanDistrictCommune = _db.UrbanDistrictCommunes.FirstOrDefault(p => p.Name == props["q4303"]),
                                    NeighborhoodVillage = _db.NeighborhoodVillages.FirstOrDefault(p => p.Name == props["q4304"])
                                });

                                _db.SaveChanges();
                            }

                            if (record.FormId == "Q44")
                            {
                                var quiz = QuizMapper.Serialize<Q44Record>(record);

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
                                    Year = model.Year,
                                    InstanceId = record.InstanceId,
                                    Data = JsonConvert.SerializeObject(Q44Mapper.Serialize(quiz.Data)),
                                    Indicator = _db.Indicators.Find(44),
                                    Province = _db.Provinces.FirstOrDefault(p => p.Name == props["q4401"]),
                                    Municipe = _db.Municipes.FirstOrDefault(p => p.Name == props["q4402"])
                                });

                                _db.SaveChanges();
                            }

                            if (record.FormId == "Q45")
                            {
                                var quiz = QuizMapper.Serialize<Q45Record>(record);

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
                                    Year = model.Year,
                                    InstanceId = record.InstanceId,
                                    Data = JsonConvert.SerializeObject(Q45Mapper.Serialize(quiz.Data)),
                                    Indicator = _db.Indicators.Find(45),
                                    Province = _db.Provinces.FirstOrDefault(p => p.Name == props["q4501"]),
                                    Municipe = _db.Municipes.FirstOrDefault(p => p.Name == props["q4502"]),
                                    UrbanDistrictCommune = _db.UrbanDistrictCommunes.FirstOrDefault(p => p.Name == props["q4503"]),
                                    NeighborhoodVillage = _db.NeighborhoodVillages.FirstOrDefault(p => p.Name == props["q4504"])
                                });

                                _db.SaveChanges();
                            }

                            if (record.FormId == "Q46")
                            {
                                var quiz = QuizMapper.Serialize<Q46Record>(record);

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
                                    Year = model.Year,
                                    InstanceId = record.InstanceId,
                                    Data = JsonConvert.SerializeObject(Q46Mapper.Serialize(quiz.Data)),
                                    Indicator = _db.Indicators.Find(46),
                                    Province = _db.Provinces.FirstOrDefault(p => p.Name == props["q4601"]),
                                    Municipe = _db.Municipes.FirstOrDefault(p => p.Name == props["q4602"])
                                });

                                _db.SaveChanges();
                            }

                            if (record.FormId == "Q47")
                            {
                                var quiz = QuizMapper.Serialize<Q47Record>(record);

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
                                    Year = model.Year,
                                    InstanceId = record.InstanceId,
                                    Data = JsonConvert.SerializeObject(Q47Mapper.Serialize(quiz.Data)),
                                    Indicator = _db.Indicators.Find(47),
                                    Province = _db.Provinces.FirstOrDefault(p => p.Name == props["q4701"]),
                                    Municipe = _db.Municipes.FirstOrDefault(p => p.Name == props["q4702"]),
                                    UrbanDistrictCommune = _db.UrbanDistrictCommunes.FirstOrDefault(p => p.Name == props["q4703"]),
                                    NeighborhoodVillage = _db.NeighborhoodVillages.FirstOrDefault(p => p.Name == props["q4704"])
                                });

                                _db.SaveChanges();
                            }

                            if (record.FormId == "Q48")
                            {
                                var quiz = QuizMapper.Serialize<Q48Record>(record);

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
                                    Year = model.Year,
                                    InstanceId = record.InstanceId,
                                    Data = JsonConvert.SerializeObject(Q48Mapper.Serialize(quiz.Data)),
                                    Indicator = _db.Indicators.Find(48),
                                    Province = _db.Provinces.FirstOrDefault(p => p.Name == props["q4801"]),
                                    Municipe = _db.Municipes.FirstOrDefault(p => p.Name == props["q4802"])
                                });

                                _db.SaveChanges();
                            }

                            if (record.FormId == "Q49")
                            {
                                var quiz = QuizMapper.Serialize<Q49Record>(record);

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
                                    Year = model.Year,
                                    InstanceId = record.InstanceId,
                                    Data = JsonConvert.SerializeObject(Q49Mapper.Serialize(quiz.Data)),
                                    Indicator = _db.Indicators.Find(49),
                                    Province = _db.Provinces.FirstOrDefault(p => p.Name == props["q4901"]),
                                    Municipe = _db.Municipes.FirstOrDefault(p => p.Name == props["q4902"]),
                                    UrbanDistrictCommune = _db.UrbanDistrictCommunes.FirstOrDefault(p => p.Name == props["q4903"]),
                                    NeighborhoodVillage = _db.NeighborhoodVillages.FirstOrDefault(p => p.Name == props["q4904"])
                                });

                                _db.SaveChanges();
                            }

                            if (record.FormId == "Q50")
                            {
                                var quiz = QuizMapper.Serialize<Q50Record>(record);

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
                                    Year = model.Year,
                                    InstanceId = record.InstanceId,
                                    Data = JsonConvert.SerializeObject(Q50Mapper.Serialize(quiz.Data)),
                                    Indicator = _db.Indicators.Find(50),
                                    Province = _db.Provinces.FirstOrDefault(p => p.Name == props["q5001"]),
                                    Municipe = _db.Municipes.FirstOrDefault(p => p.Name == props["q5002"]),
                                    UrbanDistrictCommune = _db.UrbanDistrictCommunes.FirstOrDefault(p => p.Name == props["q5003"]),
                                    NeighborhoodVillage = _db.NeighborhoodVillages.FirstOrDefault(p => p.Name == props["q5004"])
                                });

                                _db.SaveChanges();
                            }

                            if (record.FormId == "Q51")
                            {
                                var quiz = QuizMapper.Serialize<Q51Record>(record);

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
                                    Year = model.Year,
                                    InstanceId = record.InstanceId,
                                    Data = JsonConvert.SerializeObject(Q51Mapper.Serialize(quiz.Data)),
                                    Indicator = _db.Indicators.Find(51),
                                    Province = _db.Provinces.FirstOrDefault(p => p.Name == props["q5101"]),
                                    Municipe = _db.Municipes.FirstOrDefault(p => p.Name == props["q5102"]),
                                });
                                _db.SaveChanges();
                            }
                            if (record.FormId == "Q52")
                            {
                                var quiz = QuizMapper.Serialize<Q52Record>(record);

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
                                    Year = model.Year,


                                    InstanceId = record.InstanceId,
                                    Data = JsonConvert.SerializeObject(Q52Mapper.Serialize(quiz.Data)),
                                    Indicator = _db.Indicators.Find(52),
                                    Province = _db.Provinces.FirstOrDefault(p => p.Name == props["q5201"]),
                                    Municipe = _db.Municipes.FirstOrDefault(p => p.Name == props["q5202"]),
                                    UrbanDistrictCommune = _db.UrbanDistrictCommunes.FirstOrDefault(p => p.Name == props["q5203"]),
                                    NeighborhoodVillage = _db.NeighborhoodVillages.FirstOrDefault(p => p.Name == props["q5204"]),
                                });

                                _db.SaveChanges();
                            }
                            if (record.FormId == "Q53")
                            {
                                var quiz = QuizMapper.Serialize<Q53Record>(record);

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
                                    Year = model.Year,
                                    InstanceId = record.InstanceId,
                                    Data = JsonConvert.SerializeObject(Q53Mapper.Serialize(quiz.Data)),
                                    Indicator = _db.Indicators.Find(53),
                                    Province = _db.Provinces.FirstOrDefault(p => p.Name == props["q5301"]),
                                    Municipe = _db.Municipes.FirstOrDefault(p => p.Name == props["q5302"]),
                                });
                                _db.SaveChanges();
                            }



                            if (record.FormId == "Q54")
                            {
                                var quiz = QuizMapper.Serialize<Q54Record>(record);

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
                                    Year = model.Year,
                                    InstanceId = record.InstanceId,
                                    Data = JsonConvert.SerializeObject(Q54Mapper.Serialize(quiz.Data)),
                                    Indicator = _db.Indicators.Find(54),
                                    Province = _db.Provinces.FirstOrDefault(p => p.Name == props["q5401"]),
                                    Municipe = _db.Municipes.FirstOrDefault(p => p.Name == props["q5402"]),
                                    UrbanDistrictCommune = _db.UrbanDistrictCommunes.FirstOrDefault(p => p.Name == props["q5403"]),
                                    NeighborhoodVillage = _db.NeighborhoodVillages.FirstOrDefault(p => p.Name == props["q5404"]),
                                });

                                _db.SaveChanges();
                            }

                            if (record.FormId == "Q55")
                            {
                                var quiz = QuizMapper.Serialize<Q55Record>(record);

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
                                    Year = model.Year,
                                    InstanceId = record.InstanceId,
                                    Data = JsonConvert.SerializeObject(Q55Mapper.Serialize(quiz.Data)),
                                    Indicator = _db.Indicators.Find(55),
                                    Province = _db.Provinces.FirstOrDefault(p => p.Name == props["q5501"]),
                                    Municipe = _db.Municipes.FirstOrDefault(p => p.Name == props["q5502"]),
                                    UrbanDistrictCommune = _db.UrbanDistrictCommunes.FirstOrDefault(p => p.Name == props["q5503"]),
                                    NeighborhoodVillage = _db.NeighborhoodVillages.FirstOrDefault(p => p.Name == props["q5504"]),
                                });

                                _db.SaveChanges();
                            }

                            if (record.FormId == "Q56")
                            {
                                var quiz = QuizMapper.Serialize<Q56Record>(record);

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
                                    Year = model.Year,
                                    InstanceId = record.InstanceId,
                                    Data = JsonConvert.SerializeObject(Q56Mapper.Serialize(quiz.Data)),
                                    Indicator = _db.Indicators.Find(56),
                                    Province = _db.Provinces.FirstOrDefault(p => p.Name == props["q5601"]),
                                    Municipe = _db.Municipes.FirstOrDefault(p => p.Name == props["q5602"]),
                                    UrbanDistrictCommune = _db.UrbanDistrictCommunes.FirstOrDefault(p => p.Name == props["q5603"]),
                                    NeighborhoodVillage = _db.NeighborhoodVillages.FirstOrDefault(p => p.Name == props["q5604"]),
                                });

                                _db.SaveChanges();
                            }

                            if (record.FormId == "Q57")
                            {
                                var quiz = QuizMapper.Serialize<Q57Record>(record);

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
                                    Year = model.Year,
                                    InstanceId = record.InstanceId,
                                    Data = JsonConvert.SerializeObject(Q57Mapper.Serialize(quiz.Data)),
                                    Indicator = _db.Indicators.Find(57),
                                    Province = _db.Provinces.FirstOrDefault(p => p.Name == props["q5701"]),
                                    Municipe = _db.Municipes.FirstOrDefault(p => p.Name == props["q5702"]),
                                });

                                _db.SaveChanges();
                            }

                            if (record.FormId == "Q58")
                            {
                                var quiz = QuizMapper.Serialize<Q58Record>(record);

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
                                    Year = model.Year,
                                    InstanceId = record.InstanceId,
                                    Data = JsonConvert.SerializeObject(Q58Mapper.Serialize(quiz.Data)),
                                    Indicator = _db.Indicators.Find(58),
                                    Province = _db.Provinces.FirstOrDefault(p => p.Name == props["q5801"]),
                                    Municipe = _db.Municipes.FirstOrDefault(p => p.Name == props["q5802"]),
                                });

                                _db.SaveChanges();
                            }

                            if (record.FormId == "Q59")
                            {
                                var quiz = QuizMapper.Serialize<Q59Record>(record);

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
                                    Year = model.Year,
                                    InstanceId = record.InstanceId,
                                    Data = JsonConvert.SerializeObject(Q59Mapper.Serialize(quiz.Data)),
                                    Indicator = _db.Indicators.Find(59),
                                    Province = _db.Provinces.FirstOrDefault(p => p.Name == props["q5901"]),
                                    Municipe = _db.Municipes.FirstOrDefault(p => p.Name == props["q5902"]),
                                    UrbanDistrictCommune = _db.UrbanDistrictCommunes.FirstOrDefault(p => p.Name == props["q5903"]),
                                    NeighborhoodVillage = _db.NeighborhoodVillages.FirstOrDefault(p => p.Name == props["q5904"]),
                                });

                                _db.SaveChanges();
                            }

                            if (record.FormId == "Q60")
                            {
                                var quiz = QuizMapper.Serialize<Q60Record>(record);

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
                                    Year = model.Year,
                                    InstanceId = record.InstanceId,
                                    Data = JsonConvert.SerializeObject(Q60Mapper.Serialize(quiz.Data)),
                                    Indicator = _db.Indicators.Find(60),
                                    Province = _db.Provinces.FirstOrDefault(p => p.Name == props["q6001"]),
                                    Municipe = _db.Municipes.FirstOrDefault(p => p.Name == props["q6002"]),
                                    UrbanDistrictCommune = _db.UrbanDistrictCommunes.FirstOrDefault(p => p.Name == props["q6003"]),
                                    NeighborhoodVillage = _db.NeighborhoodVillages.FirstOrDefault(p => p.Name == props["q6004"]),
                                });

                                _db.SaveChanges();
                            }

                            if (record.FormId == "Q61")
                            {
                                var quiz = QuizMapper.Serialize<Q61Record>(record);

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
                                    Year = model.Year,
                                    InstanceId = record.InstanceId,
                                    Data = JsonConvert.SerializeObject(Q61Mapper.Serialize(quiz.Data)),
                                    Indicator = _db.Indicators.Find(61),
                                    Province = _db.Provinces.FirstOrDefault(p => p.Name == props["q6101"]),
                                    Municipe = _db.Municipes.FirstOrDefault(p => p.Name == props["q6102"]),
                                });

                                _db.SaveChanges();
                            }

                            if (record.FormId == "Q62")
                            {
                                var quiz = QuizMapper.Serialize<Q62Record>(record);

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
                                    Year = model.Year,
                                    InstanceId = record.InstanceId,
                                    Data = JsonConvert.SerializeObject(Q62Mapper.Serialize(quiz.Data)),
                                    Indicator = _db.Indicators.Find(62),
                                    Province = _db.Provinces.FirstOrDefault(p => p.Name == props["q6201"]),
                                    Municipe = _db.Municipes.FirstOrDefault(p => p.Name == props["q6202"]),
                                    UrbanDistrictCommune = _db.UrbanDistrictCommunes.FirstOrDefault(p => p.Name == props["q6203"]),
                                    NeighborhoodVillage = _db.NeighborhoodVillages.FirstOrDefault(p => p.Name == props["q6204"]),
                                });

                                _db.SaveChanges();
                            }
                            if (record.FormId == "Q63")
                            {
                                var quiz = QuizMapper.Serialize<Q63Record>(record);

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
                                    Year = model.Year,
                                    InstanceId = record.InstanceId,
                                    Data = JsonConvert.SerializeObject(Q63Mapper.Serialize(quiz.Data)),
                                    Indicator = _db.Indicators.Find(63),
                                    Province = _db.Provinces.FirstOrDefault(p => p.Name == props["q6301"]),
                                    Municipe = _db.Municipes.FirstOrDefault(p => p.Name == props["q6302"]),
                                    UrbanDistrictCommune = _db.UrbanDistrictCommunes.FirstOrDefault(p => p.Name == props["q6303"]),
                                    NeighborhoodVillage = _db.NeighborhoodVillages.FirstOrDefault(p => p.Name == props["q6304"]),
                                });

                                _db.SaveChanges();
                            }
                            if (record.FormId == "Q64")
                            {
                                var quiz = QuizMapper.Serialize<Q64Record>(record);

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
                                    Year = model.Year,
                                    InstanceId = record.InstanceId,
                                    Data = JsonConvert.SerializeObject(Q64Mapper.Serialize(quiz.Data)),
                                    Indicator = _db.Indicators.Find(64),
                                    Province = _db.Provinces.FirstOrDefault(p => p.Name == props["q6401"]),
                                    Municipe = _db.Municipes.FirstOrDefault(p => p.Name == props["q6402"])
                                });

                                _db.SaveChanges();
                            }
                            if (record.FormId == "Q65")
                            {
                                var quiz = QuizMapper.Serialize<Q65Record>(record);

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
                                    Year = model.Year,
                                    InstanceId = record.InstanceId,
                                    Data = JsonConvert.SerializeObject(Q65Mapper.Serialize(quiz.Data)),
                                    Indicator = _db.Indicators.Find(65),
                                    Province = _db.Provinces.FirstOrDefault(p => p.Name == props["q6501"]),
                                    Municipe = _db.Municipes.FirstOrDefault(p => p.Name == props["q6502"]),
                                    UrbanDistrictCommune = _db.UrbanDistrictCommunes.FirstOrDefault(p => p.Name == props["q6503"]),
                                    NeighborhoodVillage = _db.NeighborhoodVillages.FirstOrDefault(p => p.Name == props["q6504"]),
                                });

                                _db.SaveChanges();
                            }
                            if (record.FormId == "Q66")
                            {
                                var quiz = QuizMapper.Serialize<Q66Record>(record);

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
                                    Year = model.Year,
                                    InstanceId = record.InstanceId,
                                    Data = JsonConvert.SerializeObject(Q66Mapper.Serialize(quiz.Data)),
                                    Indicator = _db.Indicators.Find(66),
                                    Province = _db.Provinces.FirstOrDefault(p => p.Name == props["q6601"]),
                                    Municipe = _db.Municipes.FirstOrDefault(p => p.Name == props["q6602"]),
                                    UrbanDistrictCommune = _db.UrbanDistrictCommunes.FirstOrDefault(p => p.Name == props["q6603"]),
                                    NeighborhoodVillage = _db.NeighborhoodVillages.FirstOrDefault(p => p.Name == props["q6604"]),
                                });

                                _db.SaveChanges();
                            }
                            if (record.FormId == "Q67")
                            {
                                var quiz = QuizMapper.Serialize<Q67Record>(record);

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
                                    Year = model.Year,
                                    InstanceId = record.InstanceId,
                                    Data = JsonConvert.SerializeObject(Q67Mapper.Serialize(quiz.Data)),
                                    Indicator = _db.Indicators.Find(67),
                                    Province = _db.Provinces.FirstOrDefault(p => p.Name == props["q6701"]),
                                    Municipe = _db.Municipes.FirstOrDefault(p => p.Name == props["q6702"]),
                                    UrbanDistrictCommune = _db.UrbanDistrictCommunes.FirstOrDefault(p => p.Name == props["q6703"]),
                                    NeighborhoodVillage = _db.NeighborhoodVillages.FirstOrDefault(p => p.Name == props["q6704"]),
                                });
                                _db.SaveChanges();
                            }
                            if (record.FormId == "Q68")
                            {
                                var quiz = QuizMapper.Serialize<Q68Record>(record);

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
                                    Year = model.Year,
                                    InstanceId = record.InstanceId,
                                    Data = JsonConvert.SerializeObject(Q68Mapper.Serialize(quiz.Data)),
                                    Indicator = _db.Indicators.Find(68),
                                    Province = _db.Provinces.FirstOrDefault(p => p.Name == props["q6801"]),
                                    Municipe = _db.Municipes.FirstOrDefault(p => p.Name == props["q6802"]),
                                    UrbanDistrictCommune = _db.UrbanDistrictCommunes.FirstOrDefault(p => p.Name == props["q6803"]),
                                    NeighborhoodVillage = _db.NeighborhoodVillages.FirstOrDefault(p => p.Name == props["q6804"]),
                                });
                                _db.SaveChanges();
                            }
                            if (record.FormId == "Q69")
                            {
                                var quiz = QuizMapper.Serialize<Q69Record>(record);

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
                                    Year = model.Year,
                                    InstanceId = record.InstanceId,
                                    Data = JsonConvert.SerializeObject(Q69Mapper.Serialize(quiz.Data)),
                                    Indicator = _db.Indicators.Find(69),
                                    Province = _db.Provinces.FirstOrDefault(p => p.Name == props["q6901"]),
                                    Municipe = _db.Municipes.FirstOrDefault(p => p.Name == props["q6902"]),
                                });
                                _db.SaveChanges();
                            }
                            if (record.FormId == "Q70")
                            {
                                var quiz = QuizMapper.Serialize<Q70Record>(record);

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
                                    Year = model.Year,
                                    InstanceId = record.InstanceId,
                                    Data = JsonConvert.SerializeObject(Q70Mapper.Serialize(quiz.Data)),
                                    Indicator = _db.Indicators.Find(70),
                                    Province = _db.Provinces.FirstOrDefault(p => p.Name == props["q7001"]),
                                    Municipe = _db.Municipes.FirstOrDefault(p => p.Name == props["q7002"]),
                                    UrbanDistrictCommune = _db.UrbanDistrictCommunes.FirstOrDefault(p => p.Name == props["q7003"]),
                                    NeighborhoodVillage = _db.NeighborhoodVillages.FirstOrDefault(p => p.Name == props["q7004"]),
                                });
                                _db.SaveChanges();
                            }
                            if (record.FormId == "Q71")
                            {
                                var quiz = QuizMapper.Serialize<Q71Record>(record);

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
                                    Year = model.Year,
                                    InstanceId = record.InstanceId,
                                    Data = JsonConvert.SerializeObject(Q71Mapper.Serialize(quiz.Data)),
                                    Indicator = _db.Indicators.Find(71),
                                    Province = _db.Provinces.FirstOrDefault(p => p.Name == props["q7101"]),
                                    Municipe = _db.Municipes.FirstOrDefault(p => p.Name == props["q7102"]),
                                    UrbanDistrictCommune = _db.UrbanDistrictCommunes.FirstOrDefault(p => p.Name == props["q7103"]),
                                    NeighborhoodVillage = _db.NeighborhoodVillages.FirstOrDefault(p => p.Name == props["q7104"]),
                                });
                                _db.SaveChanges();
                            }
                            if (record.FormId == "Q72")
                            {
                                var quiz = QuizMapper.Serialize<Q72Record>(record);

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
                                    Year = model.Year,
                                    InstanceId = record.InstanceId,
                                    Data = JsonConvert.SerializeObject(Q72Mapper.Serialize(quiz.Data)),
                                    Indicator = _db.Indicators.Find(72),
                                    Province = _db.Provinces.FirstOrDefault(p => p.Name == props["q7201"]),
                                    Municipe = _db.Municipes.FirstOrDefault(p => p.Name == props["q7202"]),
                                    UrbanDistrictCommune = _db.UrbanDistrictCommunes.FirstOrDefault(p => p.Name == props["q7203"]),
                                    NeighborhoodVillage = _db.NeighborhoodVillages.FirstOrDefault(p => p.Name == props["q7204"]),
                                });
                                _db.SaveChanges();
                            }
                            if (record.FormId == "Q73")
                            {
                                var quiz = QuizMapper.Serialize<Q73Record>(record);

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
                                    Year = model.Year,
                                    InstanceId = record.InstanceId,
                                    Data = JsonConvert.SerializeObject(Q73Mapper.Serialize(quiz.Data)),
                                    Indicator = _db.Indicators.Find(73),
                                    Province = _db.Provinces.FirstOrDefault(p => p.Name == props["q7301"]),
                                    Municipe = _db.Municipes.FirstOrDefault(p => p.Name == props["q7302"]),
                                });
                                _db.SaveChanges();
                            }
                            if (record.FormId == "Q74")
                            {
                                var quiz = QuizMapper.Serialize<Q74Record>(record);

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
                                    Year = model.Year,
                                    InstanceId = record.InstanceId,
                                    Data = JsonConvert.SerializeObject(Q74Mapper.Serialize(quiz.Data)),
                                    Indicator = _db.Indicators.Find(74),
                                    Province = _db.Provinces.FirstOrDefault(p => p.Name == props["q7401"]),
                                    Municipe = _db.Municipes.FirstOrDefault(p => p.Name == props["q7402"]),
                                });
                                _db.SaveChanges();
                            }
                            if (record.FormId == "Q75")
                            {
                                var quiz = QuizMapper.Serialize<Q75Record>(record);

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
                                    Year = model.Year,
                                    InstanceId = record.InstanceId,
                                    Data = JsonConvert.SerializeObject(Q75Mapper.Serialize(quiz.Data)),
                                    Indicator = _db.Indicators.Find(75),
                                    Province = _db.Provinces.FirstOrDefault(p => p.Name == props["q7501"]),
                                    Municipe = _db.Municipes.FirstOrDefault(p => p.Name == props["q7502"]),
                                });
                                _db.SaveChanges();
                            }
                            if (record.FormId == "Q76")
                            {
                                var quiz = QuizMapper.Serialize<Q76Record>(record);

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
                                    Year = model.Year,
                                    InstanceId = record.InstanceId,
                                    Data = JsonConvert.SerializeObject(Q76Mapper.Serialize(quiz.Data)),
                                    Indicator = _db.Indicators.Find(76),
                                    Province = _db.Provinces.FirstOrDefault(p => p.Name == props["q7601"]),
                                    Municipe = _db.Municipes.FirstOrDefault(p => p.Name == props["q7602"]),
                                });
                                _db.SaveChanges();
                            }
                            if (record.FormId == "Q77")
                            {
                                var quiz = QuizMapper.Serialize<Q77Record>(record);

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
                                    Year = model.Year,
                                    InstanceId = record.InstanceId,
                                    Data = JsonConvert.SerializeObject(Q77Mapper.Serialize(quiz.Data)),
                                    Indicator = _db.Indicators.Find(77),
                                    Province = _db.Provinces.FirstOrDefault(p => p.Name == props["q7701"]),
                                    Municipe = _db.Municipes.FirstOrDefault(p => p.Name == props["q7702"]),
                                    UrbanDistrictCommune = _db.UrbanDistrictCommunes.FirstOrDefault(p => p.Name == props["q7703"]),
                                    NeighborhoodVillage = _db.NeighborhoodVillages.FirstOrDefault(p => p.Name == props["q7704"]),
                                });
                                _db.SaveChanges();
                            }
                            if (record.FormId == "Q78")
                            {
                                var quiz = QuizMapper.Serialize<Q78Record>(record);

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
                                    Year = model.Year,
                                    InstanceId = record.InstanceId,
                                    Data = JsonConvert.SerializeObject(Q78Mapper.Serialize(quiz.Data)),
                                    Indicator = _db.Indicators.Find(78),
                                    Province = _db.Provinces.FirstOrDefault(p => p.Name == props["q7801"]),
                                    Municipe = _db.Municipes.FirstOrDefault(p => p.Name == props["q7802"]),
                                    UrbanDistrictCommune = _db.UrbanDistrictCommunes.FirstOrDefault(p => p.Name == props["q7803"]),
                                    NeighborhoodVillage = _db.NeighborhoodVillages.FirstOrDefault(p => p.Name == props["q7804"]),
                                });
                                _db.SaveChanges();
                            }
                            if (record.FormId == "Q79")
                            {
                                var quiz = QuizMapper.Serialize<Q79Record>(record);

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
                                    Year = model.Year,
                                    InstanceId = record.InstanceId,
                                    Data = JsonConvert.SerializeObject(Q79Mapper.Serialize(quiz.Data)),
                                    Indicator = _db.Indicators.Find(79),
                                    Province = _db.Provinces.FirstOrDefault(p => p.Name == props["q7901"]),
                                    Municipe = _db.Municipes.FirstOrDefault(p => p.Name == props["q7902"]),
                                    UrbanDistrictCommune = _db.UrbanDistrictCommunes.FirstOrDefault(p => p.Name == props["q7903"]),
                                    NeighborhoodVillage = _db.NeighborhoodVillages.FirstOrDefault(p => p.Name == props["q7904"]),
                                });
                                _db.SaveChanges();
                            }
                            if (record.FormId == "Q80")
                            {
                                var quiz = QuizMapper.Serialize<Q80Record>(record);

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
                                    Year = model.Year,
                                    InstanceId = record.InstanceId,
                                    Data = JsonConvert.SerializeObject(Q80Mapper.Serialize(quiz.Data)),
                                    Indicator = _db.Indicators.Find(80),
                                    Province = _db.Provinces.FirstOrDefault(p => p.Name == props["q8001"]),
                                    Municipe = _db.Municipes.FirstOrDefault(p => p.Name == props["q8002"]),
                                    UrbanDistrictCommune = _db.UrbanDistrictCommunes.FirstOrDefault(p => p.Name == props["q8003"]),
                                    NeighborhoodVillage = _db.NeighborhoodVillages.FirstOrDefault(p => p.Name == props["q8004"]),
                                });
                                _db.SaveChanges();
                            }
                            if (record.FormId == "Q81")
                            {
                                var quiz = QuizMapper.Serialize<Q81Record>(record);

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
                                    Year = model.Year,
                                    InstanceId = record.InstanceId,
                                    Data = JsonConvert.SerializeObject(Q81Mapper.Serialize(quiz.Data)),
                                    Indicator = _db.Indicators.Find(81),
                                    Province = _db.Provinces.FirstOrDefault(p => p.Name == props["q8101"]),
                                    Municipe = _db.Municipes.FirstOrDefault(p => p.Name == props["q8102"]),
                                    UrbanDistrictCommune = _db.UrbanDistrictCommunes.FirstOrDefault(p => p.Name == props["q8103"]),
                                    NeighborhoodVillage = _db.NeighborhoodVillages.FirstOrDefault(p => p.Name == props["q8104"]),
                                });
                                _db.SaveChanges();
                            }
                            if (record.FormId == "Q82")
                            {
                                var quiz = QuizMapper.Serialize<Q82Record>(record);

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
                                    Year = model.Year,
                                    InstanceId = record.InstanceId,
                                    Data = JsonConvert.SerializeObject(Q82Mapper.Serialize(quiz.Data)),
                                    Indicator = _db.Indicators.Find(82),
                                    Province = _db.Provinces.FirstOrDefault(p => p.Name == props["q8201"]),
                                    Municipe = _db.Municipes.FirstOrDefault(p => p.Name == props["q8202"]),
                                    UrbanDistrictCommune = _db.UrbanDistrictCommunes.FirstOrDefault(p => p.Name == props["q8203"]),
                                    NeighborhoodVillage = _db.NeighborhoodVillages.FirstOrDefault(p => p.Name == props["q8204"]),
                                });
                                _db.SaveChanges();
                            }
                            if (record.FormId == "Q83")
                            {
                                var quiz = QuizMapper.Serialize<Q83Record>(record);

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
                                    Year = model.Year,
                                    InstanceId = record.InstanceId,
                                    Data = JsonConvert.SerializeObject(Q83Mapper.Serialize(quiz.Data)),
                                    Indicator = _db.Indicators.Find(83),
                                    Province = _db.Provinces.FirstOrDefault(p => p.Name == props["q8301"]),
                                    Municipe = _db.Municipes.FirstOrDefault(p => p.Name == props["q8302"]),
                                    UrbanDistrictCommune = _db.UrbanDistrictCommunes.FirstOrDefault(p => p.Name == props["q8303"]),
                                    NeighborhoodVillage = _db.NeighborhoodVillages.FirstOrDefault(p => p.Name == props["q8304"]),
                                });
                                _db.SaveChanges();
                            }
                            if (record.FormId == "Q84")
                            {
                                var quiz = QuizMapper.Serialize<Q84Record>(record);

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
                                    Year = model.Year,
                                    InstanceId = record.InstanceId,
                                    Data = JsonConvert.SerializeObject(Q84Mapper.Serialize(quiz.Data)),
                                    Indicator = _db.Indicators.Find(84),
                                    Province = _db.Provinces.FirstOrDefault(p => p.Name == props["q8401"]),
                                    Municipe = _db.Municipes.FirstOrDefault(p => p.Name == props["q8402"]),
                                    UrbanDistrictCommune = _db.UrbanDistrictCommunes.FirstOrDefault(p => p.Name == props["q8403"]),
                                    NeighborhoodVillage = _db.NeighborhoodVillages.FirstOrDefault(p => p.Name == props["q8404"]),
                                });
                                _db.SaveChanges();
                            }
                            if (record.FormId == "Q85")
                            {
                                var quiz = QuizMapper.Serialize<Q85Record>(record);

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
                                    Year = model.Year,
                                    InstanceId = record.InstanceId,
                                    Data = JsonConvert.SerializeObject(Q85Mapper.Serialize(quiz.Data)),
                                    Indicator = _db.Indicators.Find(85),
                                    Province = _db.Provinces.FirstOrDefault(p => p.Name == props["q8501"]),
                                    Municipe = _db.Municipes.FirstOrDefault(p => p.Name == props["q8502"]),
                                    UrbanDistrictCommune = _db.UrbanDistrictCommunes.FirstOrDefault(p => p.Name == props["q8503"]),
                                    NeighborhoodVillage = _db.NeighborhoodVillages.FirstOrDefault(p => p.Name == props["q8504"]),
                                });
                                _db.SaveChanges();
                            }
                            if (record.FormId == "Q86")
                            {
                                var quiz = QuizMapper.Serialize<Q86Record>(record);

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
                                    Year = model.Year,
                                    InstanceId = record.InstanceId,
                                    Data = JsonConvert.SerializeObject(Q86Mapper.Serialize(quiz.Data)),
                                    Indicator = _db.Indicators.Find(86),
                                    Province = _db.Provinces.FirstOrDefault(p => p.Name == props["q8601"]),
                                    Municipe = _db.Municipes.FirstOrDefault(p => p.Name == props["q8602"]),
                                    UrbanDistrictCommune = _db.UrbanDistrictCommunes.FirstOrDefault(p => p.Name == props["q8603"]),
                                    NeighborhoodVillage = _db.NeighborhoodVillages.FirstOrDefault(p => p.Name == props["q8604"]),
                                });
                                _db.SaveChanges();
                            }
                            if (record.FormId == "Q87")
                            {
                                var quiz = QuizMapper.Serialize<Q87Record>(record);

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
                                    Year = model.Year,
                                    InstanceId = record.InstanceId,
                                    Data = JsonConvert.SerializeObject(Q87Mapper.Serialize(quiz.Data)),
                                    Indicator = _db.Indicators.Find(87),
                                    Province = _db.Provinces.FirstOrDefault(p => p.Name == props["q8701"]),
                                    Municipe = _db.Municipes.FirstOrDefault(p => p.Name == props["q8702"]),
                                    UrbanDistrictCommune = _db.UrbanDistrictCommunes.FirstOrDefault(p => p.Name == props["q8703"]),
                                    NeighborhoodVillage = _db.NeighborhoodVillages.FirstOrDefault(p => p.Name == props["q8704"]),
                                });
                                _db.SaveChanges();
                            }
                            if (record.FormId == "Q88")
                            {
                                var quiz = QuizMapper.Serialize<Q88Record>(record);

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
                                    Year = model.Year,
                                    InstanceId = record.InstanceId,
                                    Data = JsonConvert.SerializeObject(Q88Mapper.Serialize(quiz.Data)),
                                    Indicator = _db.Indicators.Find(88),
                                    Province = _db.Provinces.FirstOrDefault(p => p.Name == props["q8801"]),
                                    Municipe = _db.Municipes.FirstOrDefault(p => p.Name == props["q8802"]),
                                    UrbanDistrictCommune = _db.UrbanDistrictCommunes.FirstOrDefault(p => p.Name == props["q8803"]),
                                    NeighborhoodVillage = _db.NeighborhoodVillages.FirstOrDefault(p => p.Name == props["q8804"]),
                                });
                                _db.SaveChanges();
                            }
                            if (record.FormId == "Q89")
                            {
                                var quiz = QuizMapper.Serialize<Q89Record>(record);

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
                                    Year = model.Year,
                                    InstanceId = record.InstanceId,
                                    Data = JsonConvert.SerializeObject(Q89Mapper.Serialize(quiz.Data)),
                                    Indicator = _db.Indicators.Find(89),
                                    Province = _db.Provinces.FirstOrDefault(p => p.Name == props["q8901"]),
                                    Municipe = _db.Municipes.FirstOrDefault(p => p.Name == props["q8902"]),
                                    UrbanDistrictCommune = _db.UrbanDistrictCommunes.FirstOrDefault(p => p.Name == props["q8903"]),
                                    NeighborhoodVillage = _db.NeighborhoodVillages.FirstOrDefault(p => p.Name == props["q8904"]),
                                });
                                _db.SaveChanges();
                            }
                            if (record.FormId == "Q90")
                            {
                                var quiz = QuizMapper.Serialize<Q90Record>(record);

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
                                    Year = model.Year,
                                    InstanceId = record.InstanceId,
                                    Data = JsonConvert.SerializeObject(Q90Mapper.Serialize(quiz.Data)),
                                    Indicator = _db.Indicators.Find(90),
                                    Province = _db.Provinces.FirstOrDefault(p => p.Name == props["q9001"]),
                                    Municipe = _db.Municipes.FirstOrDefault(p => p.Name == props["q9002"]),
                                    UrbanDistrictCommune = _db.UrbanDistrictCommunes.FirstOrDefault(p => p.Name == props["q9003"]),
                                    NeighborhoodVillage = _db.NeighborhoodVillages.FirstOrDefault(p => p.Name == props["q9004"]),
                                });
                                _db.SaveChanges();
                            }
                            if (record.FormId == "Q91")
                            {
                                var quiz = QuizMapper.Serialize<Q91Record>(record);

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
                                    Year = model.Year,
                                    InstanceId = record.InstanceId,
                                    Data = JsonConvert.SerializeObject(Q91Mapper.Serialize(quiz.Data)),
                                    Indicator = _db.Indicators.Find(91),
                                    Province = _db.Provinces.FirstOrDefault(p => p.Name == props["q9101"]),
                                    Municipe = _db.Municipes.FirstOrDefault(p => p.Name == props["q9102"]),
                                    UrbanDistrictCommune = _db.UrbanDistrictCommunes.FirstOrDefault(p => p.Name == props["q9103"]),
                                    NeighborhoodVillage = _db.NeighborhoodVillages.FirstOrDefault(p => p.Name == props["q9104"]),
                                });
                                _db.SaveChanges();
                            }
                            if (record.FormId == "Q92")
                            {
                                var quiz = QuizMapper.Serialize<Q92Record>(record);

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
                                    Year = model.Year,
                                    InstanceId = record.InstanceId,
                                    Data = JsonConvert.SerializeObject(Q92Mapper.Serialize(quiz.Data)),
                                    Indicator = _db.Indicators.Find(92),
                                    Province = _db.Provinces.FirstOrDefault(p => p.Name == props["q9201"]),
                                    Municipe = _db.Municipes.FirstOrDefault(p => p.Name == props["q9202"]),
                                    UrbanDistrictCommune = _db.UrbanDistrictCommunes.FirstOrDefault(p => p.Name == props["q9203"]),
                                    NeighborhoodVillage = _db.NeighborhoodVillages.FirstOrDefault(p => p.Name == props["q9204"]),
                                });
                                _db.SaveChanges();
                            }
                            if (record.FormId == "Q93")
                            {
                                var quiz = QuizMapper.Serialize<Q93Record>(record);

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
                                    Year = model.Year,
                                    InstanceId = record.InstanceId,
                                    Data = JsonConvert.SerializeObject(Q93Mapper.Serialize(quiz.Data)),
                                    Indicator = _db.Indicators.Find(93),
                                    Province = _db.Provinces.FirstOrDefault(p => p.Name == props["q9301"]),
                                    Municipe = _db.Municipes.FirstOrDefault(p => p.Name == props["q9302"]),
                                    UrbanDistrictCommune = _db.UrbanDistrictCommunes.FirstOrDefault(p => p.Name == props["q9303"]),
                                    NeighborhoodVillage = _db.NeighborhoodVillages.FirstOrDefault(p => p.Name == props["q9304"]),
                                });
                                _db.SaveChanges();
                            }
                            if (record.FormId == "Q94")
                            {
                                var quiz = QuizMapper.Serialize<Q94Record>(record);

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
                                    Year = model.Year,
                                    InstanceId = record.InstanceId,
                                    Data = JsonConvert.SerializeObject(Q94Mapper.Serialize(quiz.Data)),
                                    Indicator = _db.Indicators.Find(94),
                                    Province = _db.Provinces.FirstOrDefault(p => p.Name == props["q9401"]),
                                    Municipe = _db.Municipes.FirstOrDefault(p => p.Name == props["q9402"]),
                                });
                                _db.SaveChanges();
                            }
                            if (record.FormId == "Q95")
                            {
                                var quiz = QuizMapper.Serialize<Q95Record>(record);

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
                                    Year = model.Year,
                                    InstanceId = record.InstanceId,
                                    Data = JsonConvert.SerializeObject(Q95Mapper.Serialize(quiz.Data)),
                                    Indicator = _db.Indicators.Find(95),
                                    Province = _db.Provinces.FirstOrDefault(p => p.Name == props["q9501"]),
                                    Municipe = _db.Municipes.FirstOrDefault(p => p.Name == props["q9502"]),
                                });
                                _db.SaveChanges();
                            }
                            if (record.FormId == "Q96")
                            {
                                var quiz = QuizMapper.Serialize<Q96Record>(record);

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
                                    Year = model.Year,
                                    InstanceId = record.InstanceId,
                                    Data = JsonConvert.SerializeObject(Q96Mapper.Serialize(quiz.Data)),
                                    Indicator = _db.Indicators.Find(96),
                                    Province = _db.Provinces.FirstOrDefault(p => p.Name == props["q9601"]),
                                    Municipe = _db.Municipes.FirstOrDefault(p => p.Name == props["q9602"]),
                                });
                                _db.SaveChanges();
                            }
                            if (record.FormId == "Q97")
                            {
                                var quiz = QuizMapper.Serialize<Q97Record>(record);

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
                                    Year = model.Year,
                                    InstanceId = record.InstanceId,
                                    Data = JsonConvert.SerializeObject(Q97Mapper.Serialize(quiz.Data)),
                                    Indicator = _db.Indicators.Find(97),
                                    Province = _db.Provinces.FirstOrDefault(p => p.Name == props["q9701"]),
                                    Municipe = _db.Municipes.FirstOrDefault(p => p.Name == props["q9702"]),
                                    UrbanDistrictCommune = _db.UrbanDistrictCommunes.FirstOrDefault(p => p.Name == props["q9703"]),
                                    NeighborhoodVillage = _db.NeighborhoodVillages.FirstOrDefault(p => p.Name == props["q9704"]),
                                });
                                _db.SaveChanges();
                            }
                            if (record.FormId == "Q98")
                            {
                                var quiz = QuizMapper.Serialize<Q98Record>(record);

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
                                    Year = model.Year,
                                    InstanceId = record.InstanceId,
                                    Data = JsonConvert.SerializeObject(Q98Mapper.Serialize(quiz.Data)),
                                    Indicator = _db.Indicators.Find(98),
                                    Province = _db.Provinces.FirstOrDefault(p => p.Name == props["q9801"]),
                                    Municipe = _db.Municipes.FirstOrDefault(p => p.Name == props["q9802"]),
                                    UrbanDistrictCommune = _db.UrbanDistrictCommunes.FirstOrDefault(p => p.Name == props["q9803"]),
                                    NeighborhoodVillage = _db.NeighborhoodVillages.FirstOrDefault(p => p.Name == props["q9804"]),
                                });
                                _db.SaveChanges();
                            }
                            if (record.FormId == "Q99")
                            {
                                var quiz = QuizMapper.Serialize<Q99Record>(record);

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
                                    Year = model.Year,
                                    InstanceId = record.InstanceId,
                                    Data = JsonConvert.SerializeObject(Q99Mapper.Serialize(quiz.Data)),
                                    Indicator = _db.Indicators.Find(99),
                                    Province = _db.Provinces.FirstOrDefault(p => p.Name == props["q9901"]),
                                    Municipe = _db.Municipes.FirstOrDefault(p => p.Name == props["q9902"]),
                                    UrbanDistrictCommune = _db.UrbanDistrictCommunes.FirstOrDefault(p => p.Name == props["q9903"]),
                                    NeighborhoodVillage = _db.NeighborhoodVillages.FirstOrDefault(p => p.Name == props["q9904"]),
                                });
                                _db.SaveChanges();
                            }
                            if (record.FormId == "Q100")
                            {
                                var quiz = QuizMapper.Serialize<Q100Record>(record);

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
                                    Year = model.Year,
                                    InstanceId = record.InstanceId,
                                    Data = JsonConvert.SerializeObject(Q100Mapper.Serialize(quiz.Data)),
                                    Indicator = _db.Indicators.Find(100),
                                    Province = _db.Provinces.FirstOrDefault(p => p.Name == props["q10001"]),
                                    Municipe = _db.Municipes.FirstOrDefault(p => p.Name == props["q10002"]),
                                });
                                _db.SaveChanges();
                            }
                        }
                    }

                    try
                    {
                        if (File.Exists(csvPath))
                            File.Delete(csvPath);
                    }
                    catch (Exception e)
                    {
                        return new ServiceResponse<bool>
                        {
                            Data = false,
                            IsSuccess = false,
                            Message = "Erro ao deletar o arquivo csv",
                            Time = DateTime.Now
                        };
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
                    Console.WriteLine(e.Message);
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
