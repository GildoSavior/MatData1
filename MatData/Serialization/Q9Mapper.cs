using MatData.Models.Records;
using MatData.ViewModels;
using System;

namespace MatData.Serialization
{
    public static class Q9Mapper
    {
        public static Q9Model Serialize(Q9Record record)
        {
            return new Q9Model
            {
                TotalWomenCMVC = Int32.Parse(record.q904),
                TotalMenCMVC = Int32.Parse(record.q905),
                TotalOrgCMVC = Int32.Parse(record.q907),
                orgCMVCLists = record.q908,
                ExistsInRegCMVC = record.q909,
                TotalMeetingCMVCByYear = record.q910,
                ExistsAgendaByMeeting = record.q911,
                ExistsActaByMeeting = record.q912,
                Comments = record.q913
            };
        }
    }
}
