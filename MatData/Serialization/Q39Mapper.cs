using MatData.Models.Records;
using MatData.ViewModels;

namespace MatData.Serialization
{
    public static class Q39Mapper
    {
        public static Q39Model Serialize(Q39Record model)
        {
            return new Q39Model
            {
                DesignacaodaUnidadedeSaude = model.q3906,
                TipologiadeUnidadedeSaude = model.q3907,
                Medicos = int.Parse(model.q3908),
                EnfermeirosTecnicosSuperiores = int.Parse(model.q3909),
                EnfermeirosTecnicosMedios = int.Parse(model.q3910),
                Parteiras = int.Parse(model.q3911),
                TecnicosdeDiagnostico = int.Parse(model.q3912),
                OutrosProfissionaisdeSaude = int.Parse(model.q3913),
                Observacoes = model.q3918
            };
        }
    }
}
