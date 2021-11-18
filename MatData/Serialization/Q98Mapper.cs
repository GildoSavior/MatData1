using MatData.Models.Records;
using MatData.ViewModels;

namespace MatData.Serialization
{
    public class Q98Mapper
    {
        public static Q98Model Serialize(Q98Record model)
        {
            return new Q98Model
            {
              //Dados gerais sobre o PIIM 
              PeriodoReferencia = model.q9806,
              NomeProjecto = model.q9807,
              NumProjecto = model.q9808,
              FotoFrontal = model.q9809,
              FotoGeral = model.q9810,
              Localizacao = model.q9811,
              ValorAprovado = double.Parse(model.q9812),
              ValorExecutadoProjecto = double.Parse(model.q9813),
              DesvioFinanceiro = double.Parse(model.q9814),
              PercentagemExecucaoOrçamental = double.Parse(model.q9815),
              TotalValorAprovado = double.Parse(model.q9816),
              TotalValorExecutado = double.Parse(model.q9817),
              //Ponto de situação do Programa
              PercentExecucaoFisica = double.Parse(model.q9818),
              PercentExecucaoFinanceira = double.Parse(model.q9819),
              PontoSituacao = model.q9820,
              OutrasInformacaesRel = model.q9821,
              Conclusoes = model.q9822,
              Recomendacoes = model.q9823,
              Observacoes = model.q9824,
            };
        }
    }
}
