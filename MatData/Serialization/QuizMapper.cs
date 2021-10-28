using CsvHelper;
using CsvHelper.Configuration;
using MatData.Models;
using MatData.Models.Records;
using MatData.ViewModels;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;

namespace MatData.Serialization
{
    public static class QuizMapper
    {
        public static QuizModel Serialize<T>(Quiz record)
        {
            return new QuizModel
            {
                Id = record.Id,
                FormId = record.FormId,
                Name = record.Name,
                InstanceId = record.InstanceId,
                Data = JsonConvert.DeserializeObject<T>(record.Data)
            };
        }

        public static List<Quiz> Serializes(string fileName)
        {
            var list = new List<Quiz>();
            var config = new CsvConfiguration(CultureInfo.InvariantCulture)
            {
                HasHeaderRecord = false,
            };
            using (var reader = new StreamReader(fileName))
            using (var csv = new CsvReader(reader, config))
            {
                var records = csv.GetRecords<Quiz>().ToList();

                for (var i = 0; i < records.Count; i++)
                {
                    var record = records[i];
                    if (i == 0)
                        continue;

                    list.Add(record);
                }
            }

            return list;
        }
    }
}
