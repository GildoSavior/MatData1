using MatData.Models.Records;
using MatData.ViewModels;

namespace MatData.Serialization
{
    public static class Q17Mapper
    {
        public static Q17Model Serialize(Q17Record model)
        {
            return new Q17Model
            {
                TipoCimaNoLocal = model.q1706,
                CaracteristicasClimáticas = model.q1707,
                DuracaoTipicaEpocaChuvas = model.q1708,
                DuracaoTipicaEpocaSeca = model.q1709,
                MesesEpocaChuvas = model.q1710,
                MesesEpocaSeca = model.q1711,
                ExistênciaCiclosEstiagem = model.q1712,
                DuracaoMediaPeriodosEstiagem = model.q1713,
                SituacaoActualEstiagem = model.q1714,
                InicioUltimoCicloEstiagemAnterior = model.q1715,
                FinalUltimoCicloEstiagemAnterior = model.q1716,
                Observacoes = model.q1717,
            };
        }
    }
}
