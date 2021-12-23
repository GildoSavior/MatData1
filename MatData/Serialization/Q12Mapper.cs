using System;
using MatData.Models.Records;
using MatData.ViewModels;

namespace MatData.Serialization
{
    public static class Q12Mapper
    {
        public static Q12Model Serialize(Q12Record model)
        {
            return new Q12Model
            {
                DataAttrEstadoMunicipioAposIndependencia = model.q1204,
                DataAttrEstadoMunicipioAposConselho = model.q1205,
                DiaMunicipio = model.q1206,
                EventoQueDeuOrigemATribuicaoEstadoMunicipio = model.q1207,
                PersonalidadesNacionaisAssociadasAFundacao = model.q1208.Contains(",") ?
                    model.q1208.Split(",") :
                    model.q1208.Contains(", ") ? model.q1208.Split(",") :
                    string.IsNullOrEmpty(model.q1208) ? Array.Empty<string>() : new string[] {model.q1208},
                PersonalidadesExtrangeirasAssociadasAFundacao = model.q1209.Contains(",") ?
                    model.q1209.Split(",") :
                    model.q1209.Contains(", ") ? model.q1209.Split(",") :
                    string.IsNullOrEmpty(model.q1209) ? Array.Empty<string>() : new string[] { model.q1209 },
                Observacoes = model.q1210
            };
        }
    }
}
