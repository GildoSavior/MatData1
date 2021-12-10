using MatData.Models.Records;
using MatData.ViewModels;

namespace MatData.Serialization
{
    public class Q97Mapper
    {
        public static Q97Model Serialize(Q97Record model)
        {
            return new Q97Model
            {
              //Dados gerais sobre o PIP = model.q970,
              PeriodoReferencia = model.q9706,
              NomeProjecto = model.q9707,
              NumProjecto = model.q9708,
              FotoFrontal = model.q9709,
              FotoGeral = model.q9710,
              Localizacao = model.q9711,
              ValorAprovado = double.Parse(model.q9712),
              ValorExecutadoProjecto = double.Parse(model.q9713),
              DesvioFinanceiro = double.Parse(model.q9714),
              PercentagemExecucaoOrçamental = double.Parse(model.q9715),
              TotalValorAprovado = double.Parse(model.q9716),
              TotalValorExecutado = double.Parse(model.q9717),
              //Ponto de situação do Programa = model.q970,
              PercentExecucaoFisica = double.Parse(model.q9718),
              PercentExecucaoFinanceira = double.Parse(model.q9719),
              PontoSituacao = model.q9720,
              OutrasInformacaesRel = model.q9721,
              Conclusoes = model.q9722,
              Recomendacoes = model.q9723,
              Observacoes = model.q9724,
            };
        }
    }
}
