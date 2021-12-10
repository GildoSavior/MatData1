using MatData.Models.Records;
using MatData.ViewModels;
using System;

namespace MatData.Serialization
{
    public static class Q7Mapper
    {
        public static Q7Model Serialize(Q7Record record)
        {
            return new Q7Model
            {
                TotalWomanCMAC = Int32.Parse(record.q704),
                TotalManCMAC = Int32.Parse(record.q705),
                TotalOrgCMAC = Int32.Parse(record.q707),
                OrgCMACLists = record.q708,
                IdDispatchCMAC = record.q709,
                StartDateCMAC = record.q710,
                ExistsReguInternal = record.q711,
                TotalMeetingByYear = Int32.Parse(record.q712),
                ExistsAgendaByMeeting = record.q713,
                ExistsActaByMeeting = record.q714,
                Comments = record.q715
            };
        }
    }
}
