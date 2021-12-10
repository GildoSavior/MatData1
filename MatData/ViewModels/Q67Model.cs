namespace MatData.ViewModels
{
    public class Q67Model
    {
                public int NumHabitAdobeCenso2014 {get; set;}
                public int NumHabitPauPiqueCenso2014 {get; set;}
                public int NumHabitMadeiraCenso2014 {get; set;}
                public int NumHabitChapaCenso2014 {get; set;}
                public int NumHabitBlocoTijoloCenso2014 {get; set;}
                public int NumHabitConstruídasOutrosMatCenso2014 {get; set;}
                public int NumTotalHabAgloPopCenso { get { return NumHabitAdobeCenso2014 + NumHabitConstruídasOutrosMatCenso2014; } }
                public int NumHabitAdobeAnoTrans {get; set;}
                public int NumHabitPauPiqueAnoTrans {get; set;}
                public int NumHabitMadeiraAnoTrans {get; set;}
                public int NumHabitChapaAnoTrans {get; set;}
                public int NumHabitBlocoTijoloAnoTrans {get; set;}
                public int NumHabitConstrOutrosMaterAnoTrans {get; set;}
                public int NumTotalHabAgloPopAnoTrans { get { return NumHabitAdobeAnoTrans + NumHabitConstrOutrosMaterAnoTrans; } }
                public int NumHabAdobeAnoCorr {get; set;}
                public int NumHabPauPiqueAnoCorr {get; set;}
                public int NumHabMadAnoCorr {get; set;}
                public int NumHabChapaAnoCorr {get; set;}
                public int NumHabBlocoTijAnoCorr {get; set;}
                public int NumHabConstOutMatAnoCorr {get; set;}
                public int NumTotalHabAgloPopAnoCorr { get { return NumHabAdobeAnoCorr + NumHabConstOutMatAnoCorr; } }
                public string ComissaoMoradores {get; set;}
                public string CoordenadoresZona {get; set;}
                public string CasaJuventude {get; set;}
                public string JangoComunitário {get; set;}
                public string EstrutRepresOrgTradComunidade {get; set;}
                public string NomeEstrutRepreOrgTradComunidade {get; set;}
                public string OutrosServiços {get; set;}
                public string Observacoes { get; set; }
    }
}
