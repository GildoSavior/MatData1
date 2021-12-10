using MatData.Models.Records;
using MatData.ViewModels;

namespace MatData.Serialization
{
    public class Q99Mapper
    {
        public static Q99Model Serialize(Q99Record model)
        {
            return new Q99Model
            {              
              PeriodoReferencia = model.q9906,
              NomeProjecto = model.q9907,
              NumProjecto = model.q9908,
              FotoFrontal = model.q9909,
              FotoGeral = model.q9910,
              Localizacao = model.q9911,
              ValorAprovado = double.Parse(model.q9912),
              ValorExecutadoProjecto = double.Parse(model.q9913),
              DesvioFinanceiro = double.Parse(model.q9914),
              PercentagemExecucaoOrçamental = double.Parse(model.q9915),
              TotalValorAprovado = double.Parse(model.q9916),
              TotalValorExecutado = double.Parse(model.q9917),
              //Ponto de situação do Programa = model.q970,
              PercentExecucaoFisica = double.Parse(model.q9918),
              PercentExecucaoFinanceira = double.Parse(model.q9919),
              PontoSituacao = model.q9920,
              OutrasInformacaesRel = model.q9921,
              Conclusoes = model.q9922,
              Recomendacoes = model.q9923,
              Observacoes = model.q9924,
            };
        }
    }
}
