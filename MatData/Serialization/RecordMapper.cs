using MatData.Models;
using MatData.Models.Records;
using MatData.ViewModels;
using System.Collections.Generic;
using System.Linq;

namespace MatData.Serialization
{
    public static class RecordMapper
    {
        public static List<QuizModel> Serialize(List<Quiz> list)
        {
            return list.Select(x =>
            {
                if (x.FormId == "Q1")
                    return QuizMapper.Serialize<Q1Record>(x);
                if (x.FormId == "Q10")
                    return QuizMapper.Serialize<Q10Record>(x);

                return null;
            }).ToList();
        }
    }
}
