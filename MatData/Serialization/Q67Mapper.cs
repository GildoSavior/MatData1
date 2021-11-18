using MatData.Models.Records;
using MatData.ViewModels;
using System;

namespace MatData.Serialization
{
    public static class Q67Mapper
    {
        public static Q67Model Serialize(Q67Record model)
        {
            return new Q67Model
            {
                //Dados habitacionais de referência da Aldeia / Bairro (Censo 2014)
                NumHabitAdobeCenso2014 = Int32.Parse(model.q6706),
                NumHabitPauPiqueCenso2014 = Int32.Parse(model.q6707),
                NumHabitMadeiraCenso2014 = Int32.Parse(model.q6708),
                NumHabitChapaCenso2014 = Int32.Parse(model.q6709),
                NumHabitBlocoTijoloCenso2014 = Int32.Parse(model.q6710),
                NumHabitConstruídasOutrosMatCenso2014 = Int32.Parse(model.q6711),
                //Dados habitacionais de referência da Aldeia / Bairro no ano transacto
                NumHabitAdobeAnoTrans = Int32.Parse(model.q6713),
                NumHabitPauPiqueAnoTrans = Int32.Parse(model.q6714),
                NumHabitMadeiraAnoTrans = Int32.Parse(model.q6715),
                NumHabitChapaAnoTrans = Int32.Parse(model.q6716),
                NumHabitBlocoTijoloAnoTrans = Int32.Parse(model.q6717),
                NumHabitConstrOutrosMaterAnoTrans = Int32.Parse(model.q6718),
                //Dados habitacionais de referência da Aldeia / Bairro no ano corrente
                NumHabAdobeAnoCorr = Int32.Parse(model.q6720),
                NumHabPauPiqueAnoCorr = Int32.Parse(model.q6721),
                NumHabMadAnoCorr = Int32.Parse(model.q6722),
                NumHabChapaAnoCorr = Int32.Parse(model.q6723),
                NumHabBlocoTijAnoCorr = Int32.Parse(model.q6724),
                NumHabConstOutMatAnoCorr = Int32.Parse(model.q6725),
                //Serviços da Estrutura Comunitária
                ComissaoMoradores = model.q6727,
                CoordenadoresZona = model.q6728,
                CasaJuventude = model.q6729,
                JangoComunitário = model.q6730,
                EstrutRepresOrgTradComunidade = model.q6731,
                NomeEstrutRepreOrgTradComunidade = model.q6731 == "Sim" ? model.q6732 : null,
                OutrosServiços = model.q6733,
                Observacoes = model.q6734,


            };
        }
    }
}
