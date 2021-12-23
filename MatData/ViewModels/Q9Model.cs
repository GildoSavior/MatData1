namespace MatData.ViewModels
{
    public class Q9Model
    {
        public int TotalWomenCMVC { get; set; }
        public int TotalMenCMVC { get; set; }
        public int TotalMembersCMVC
        {
            get
            {

                return TotalWomenCMVC + TotalMenCMVC;
            }
        }
        public int TotalOrgCMVC { get; set; }
        public string orgCMVCLists { get; set; }
        public string ExistsInRegCMVC { get; set; }
        public string TotalMeetingCMVCByYear { get; set; }
        public string ExistsAgendaByMeeting { get; set; }
        public string ExistsActaByMeeting { get; set; }
        public string Comments { get; set; }
    }
}
