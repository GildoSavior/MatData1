using MatData.Models.Records;
using MatData.ViewModels;

namespace MatData.Serialization
{
    public static class Q95Mapper
    {
        public static Q95Model Serialize(Q95Record model)
        {
            return new Q95Model
            {
              //Dados gerais do Orçamento = model.q950,
              PeriodExecOrcamental = model.q9504,
              OrcamentoProposto = double.Parse(model.q9505),
              ValorOrçamentado = double.Parse(model.q9506),
              ValorCabimentado = double.Parse(model.q9507),
              ValorExecutado = double.Parse(model.q9508),
              PercentExecucaoOrcamental = double.Parse(model.q9509),
              //Dívida Registada na Unidade de Gestão da Dívida Pública do MINFIN(DR) = model.q950,
              ValorDividaDR = double.Parse(model.q9510),
              DescriDespesaDR = model.q9511,
              DataRegistoDR = model.q9512,
              ObservacoesPontoSituacaoDR = model.q9513,
              ValorTotalDividaRegistadaDR = double.Parse(model.q9514),
              //Dívida não Registada na Unidade de Gestão da Dívida Pública do MINFIN(DNR) = model.q950,
              ValorDividaDNR = double.Parse(model.q9515),
              DescriDespesaDNR = model.q9516,
              DataRegistoDNR = model.q9517,
              ObservacoesPontoSituacaoDNR = model.q9518,
              ValorTotalDividaRegistadaDNR = double.Parse(model.q9519),
              //Ponto de situação da Execução Financeira = model.q950,
              PontoSituacao = model.q9520,
              OutrasInformRelevantes = model.q9521,
              Conclusoes = model.q9522,
              Recomendacoes = model.q9523,
              Observacoes = model.q9524,

            };
        }
    }
}
