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
    }
}
