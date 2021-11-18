namespace MatData.ViewModels
{
    public class Q53Model
    {
        public string ListClubsSports {get; set;}
        public string AnotherEntities {get; set;}
        public string EventsSport {get; set;}
        public int NumberPractitionersManNotFedModColect {get; set;}
        public int NumberPractitionersMaleNotFedModColect {get; set;}
        public int NumberPractitionersFedModColect {
            get { return NumberPractitionersManNotFedModColect + NumberPractitionersMaleNotFedModColect; }
        }
        public int NumberPractitionersMenFedModColect {get; set;}
        public int NumberPractitionersMaleFedModColect {get; set;}
        public int NumberPractitionersFedModColectivas {
            get { return NumberPractitionersMenFedModColect + NumberPractitionersMaleFedModColect; }
        }
        public int NumberPractitionersManNotFedModSingle {get; set;}
        public int NumberPractitionersMaleNotFedModSingle {get; set;}
        public int NumberpractitionersNotFedModSingle {
            get { return NumberPractitionersManNotFedModSingle + NumberPractitionersMaleNotFedModSingle; }
        }
        public int NumberPractitionersManFedModSingle {get; set;}
        public int NumberPractitionersMaleFedModSingle {get; set;}
        public int NumberPractitionersFedModSingle {get; set;}
        public string Comments { get; set; }

    }
}
