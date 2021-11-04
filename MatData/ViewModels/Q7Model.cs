namespace MatData.ViewModels
{
    public class Q7Model
    {
        public int TotalWomanCMAC { get; set; }
        public int TotalManCMAC { get; set; }
        public int TotalMemberCMAC 
        {
            get { return TotalWomanCMAC + TotalWomanCMAC; } 
        }
        public int TotalOrgCMAC { get; set; }
        public string OrgCMACLists { get; set; }
        public string IdDispatchCMAC { get; set; }
        public string StartDateCMAC { get; set; }
        public int TotalMeetingCMAC { get; set; }
        public string ExistsReguInternal { get; set; }
        public int TotalMeetingByYear { get; set; }
        public string ExistsAgendaByMeeting { get; set; }
        public string ExistsActaByMeeting { get; set; }
        public string Comments { get; set; }
    }
}
