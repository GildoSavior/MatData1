namespace MatData.ViewModels
{
    public class Q8Model
    {
        public int TotalWomenCMCS { get; set; }
        public int TotalMenCMCS { get; set; }
        public int TotalMembersCMCS { 
            get 
            {

                return TotalWomenCMCS + TotalMenCMCS;
            } 
        }
        public int TotalOrgCMCS { get; set; }
        public string orgCMCSLists { get; set; }
        public string ExistsInRegCMCS { get; set; }
        public string TotalMeetingCMCSByYear { get; set; }
        public string ExistsAgendaByMeeting { get; set; }
        public string ExistsActaByMeeting { get; set; }
        public string Comments { get; set; }
    }
}