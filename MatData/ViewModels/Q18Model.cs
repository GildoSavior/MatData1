namespace MatData.ViewModels
{
    public class Q18Model
    {
        public string AnoReferencia { get; set; }
        public double IndicePluviometriaMensalJaneiro { get; set; }
        public double TemperaturaMediaDiurnaMensalJaneiro { get; set; }
        public double TemperaturaMediaNocturnaMensalJaneiro { get; set; }
        public double IndicePluviometriaMensalFevereiro { get; set; }
        public double TemperaturaMediaDiurnaMensalFevereiro { get; set; }
        public double TemperaturaMediaNocturnaMensalFevereiro { get; set; }
        public double IndicePluviometriaMensalMarco { get; set; }
        public double TemperaturaMediaDiurnaMensalMarco { get; set; }
        public double TemperaturaMediaNocturnaMensalMarco { get; set; }
        public double IndicePluviometriaMensalAbril { get; set; }
        public double TemperaturaMediaDiurnaMensalAbril { get; set; }
        public double TemperaturaMediaNocturnaMensalAbril { get; set; }
        public double IndicePluviometriaMensalMaio { get; set; }
        public double TemperaturaMediaDiurnaMensalMaio { get; set; }
        public double TemperaturaMediaNocturnaMensalMaio { get; set; }
        public double IndicePluviometriaMensalJunho { get; set; }
        public double TemperaturaMediaDiurnaMensalJunho { get; set; }
        public double TemperaturaMediaNocturnaMensalJunho { get; set; }
        public double IndicePluviometriaMensalJulho { get; set; }
        public double TemperaturaMediaDiurnaMensalJulho { get; set; }
        public double TemperaturaMediaNocturnaMensalJulho { get; set; }
        public double IndicePluviometriaMensalAgosto { get; set; }
        public double TemperaturaMediaDiurnaMensalAgosto { get; set; }
        public double TemperaturaMediaNocturnaMensalAgosto { get; set; }
        public double IndicePluviometriaMensalSetembro { get; set; }
        public double TemperaturaMediaDiurnaMensalSetembro { get; set; }
        public double TemperaturaMediaNocturnaMensalSetembro { get; set; }
        public double IndicePluviometriaMensalOutubro { get; set; }
        public double TemperaturaMediaDiurnaMensalOutubro { get; set; }
        public double TemperaturaMediaNocturnaMensalOutubro { get; set; }
        public double IndicePluviometriaMensalNovembro { get; set; }
        public double TemperaturaMediaDiurnaMensalNovembro { get; set; }
        public double TemperaturaMediaNocturnaMensalNovembro { get; set; }
        public double IndicePluviometriaMensalDezembro { get; set; }
        public double TemperaturaMediaDiurnaMensalDezembro { get; set; }
        public double TemperaturaMediaNocturnaMensalDezembro { get; set; }
        public double NumeroMedioAnualDeDiasSemChuva { get; set; }
        public double IndicePluviometricoAnual 
        {
            get
            {
                return
                    (IndicePluviometriaMensalJaneiro +
                    IndicePluviometriaMensalFevereiro +
                    IndicePluviometriaMensalMarco +
                    IndicePluviometriaMensalAbril +
                    IndicePluviometriaMensalMaio +
                    IndicePluviometriaMensalJunho +
                    IndicePluviometriaMensalJulho +
                    IndicePluviometriaMensalAgosto +
                    IndicePluviometriaMensalSetembro +
                    IndicePluviometriaMensalOutubro +
                    IndicePluviometriaMensalNovembro +
                    IndicePluviometriaMensalDezembro) / 12.0;


            }
        }
        public double TemperaturaMediaDiurnaAnual { 
            get
            {
                return 
                    (TemperaturaMediaDiurnaMensalJaneiro +
                    TemperaturaMediaDiurnaMensalFevereiro +
                    TemperaturaMediaDiurnaMensalMarco +
                    TemperaturaMediaDiurnaMensalAbril +
                    TemperaturaMediaDiurnaMensalMaio +
                    TemperaturaMediaDiurnaMensalJunho +
                    TemperaturaMediaDiurnaMensalJulho +
                    TemperaturaMediaDiurnaMensalAgosto +
                    TemperaturaMediaDiurnaMensalSetembro +
                    TemperaturaMediaDiurnaMensalOutubro +
                    TemperaturaMediaDiurnaMensalNovembro +
                    TemperaturaMediaDiurnaMensalDezembro) / 12.0;
            }
        }
        public double TemperaturaMediaNocturnaAnual { 
            get
            {
                return
                    (TemperaturaMediaNocturnaMensalJaneiro +
                    TemperaturaMediaNocturnaMensalFevereiro +
                    TemperaturaMediaNocturnaMensalMarco +
                    TemperaturaMediaNocturnaMensalAbril +
                    TemperaturaMediaNocturnaMensalMaio +
                    TemperaturaMediaNocturnaMensalJunho +
                    TemperaturaMediaNocturnaMensalJulho +
                    TemperaturaMediaNocturnaMensalAgosto +
                    TemperaturaMediaNocturnaMensalSetembro +
                    TemperaturaMediaNocturnaMensalOutubro +
                    TemperaturaMediaNocturnaMensalNovembro +
                    TemperaturaMediaNocturnaMensalDezembro) / 12.0;
            }
        }
        public double TemperaturaMediaAnual
        {
            get
            {
                return TemperaturaMediaDiurnaAnual + TemperaturaMediaNocturnaAnual;
            }
        }
        public string Observacoes { get; set; }
    }
}
