using MatData.Models.Records;
using MatData.ViewModels;
using System;

namespace MatData.Serialization
{
    public static class Q8Mapper
    {
        public static Q8Model Serialize(Q8Record record)
        {
            return new Q8Model
            {
                TotalWomenCMCS =    Int32.Parse(record.q804),
                TotalMenCMCS = Int32.Parse(record.q805),
                TotalOrgCMCS = Int32.Parse(record.q807),
                orgCMCSLists = record.q808,
                ExistsInRegCMCS = record.q809,
                TotalMeetingCMCSByYear = record.q810,
                ExistsAgendaByMeeting = record.q811,
                ExistsActaByMeeting = record.q812,
                Comments = record.q813,
            };
        }
    }
}
