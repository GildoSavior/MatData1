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
                DesignacaodaUnidadedeSaude = model.q3905,
                TipologiadeUnidadedeSaude = model.q3906,
                Medicos = int.Parse(model.q3907),
                EnfermeirosTecnicosSuperiores = int.Parse(model.q3908),
                EnfermeirosTecnicosMedios = int.Parse(model.q3909),
                Parteiras = int.Parse(model.q3910),
                TecnicosdeDiagnostico = int.Parse(model.q3911),
                OutrosProfissionaisdeSaude = int.Parse(model.q3912),
                NumerototaldeProfissionaisdeSaudedestaUS = int.Parse(model.q3913),
                RacioUtenteMedico = int.Parse(model.q3914),
                RacioUtenteEnfermeiro = int.Parse(model.q3915),
                RacioUtenteTecnicodeDiagnostico = int.Parse(model.q3916),
                Observacoes = model.q3917
            };
        }
    }
}
