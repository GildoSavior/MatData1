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
                TotalOrgCMAC = Int32.Parse(record.q706),
                OrgCMACLists = record.q707,
                IdDispatchCMAC = record.q708,
                StartDateCMAC = record.q709,
                TotalMeetingCMAC = Int32.Parse(record.q710),
                ExistsReguInternal = record.q711,
                TotalMeetingByYear = Int32.Parse(record.q712),
                ExistsAgendaByMeeting = record.q713,
                ExistsActaByMeeting = record.q714,
                Comments = record.q715
            };
        }
    }
}
