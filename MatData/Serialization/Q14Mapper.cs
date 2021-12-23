using System;
using MatData.Models.Records;
using MatData.ViewModels;

namespace MatData.Serialization
{
    public static class Q14Mapper
    {
        public static Q14Model Serialize(Q14Record model)
        {
            return new Q14Model
            {
                NomdePersonalidadeReconhecidaComoImportanteHistoriaLocal = model.q1406,
                DataEventoPersonalidadeSeTornouImportanteLocal = model.q1407,
                PeriodoPersonalidadeEsteveAssociadaLocal = model.q1408,
                ActosRealizadosPelaPersonalidade = model.q1409.Contains(",") ?
                    model.q1409.Split(",") :
                    model.q1409.Contains(", ") ? model.q1409.Split(",") :
                    string.IsNullOrEmpty(model.q1409) ? Array.Empty<string>() : new string[] { model.q1409 },
                Observacoes = model.q1410
            };
        }
    }
}
