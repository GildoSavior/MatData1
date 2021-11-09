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
                TotalWomenCMCS = Int32.Parse(record.q904),
                TotalMenCMCS = Int32.Parse(record.q905),
                TotalOrgCMCS = Int32.Parse(record.q907),
                orgCMCSLists = record.q908,
                ExistsInRegCMCS = record.q909,
                TotalMeetingCMCSByYear = record.q910,
                ExistsAgendaByMeeting = record.q911,
                ExistsActaByMeeting = record.q912,
                Comments = record.q913,
            };
        }
    }
}
