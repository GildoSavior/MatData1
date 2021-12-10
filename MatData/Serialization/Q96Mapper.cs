using MatData.Models.Records;
using MatData.ViewModels;

namespace MatData.Serialization
{
    public static class Q96Mapper
    {
        public static Q96Model Serialize(Q96Record model)
        {
            return new Q96Model
            {
                //Dados gerais do PIDLCP = model.q960,
                PeriodExecucaoOrcamental = model.q9604,
                ValorOrcamentado = double.Parse(model.q9605),
                ValorTotalExecucaoTri = double.Parse(model.q9606),
                PercentExecucaoFinanceiraTri = double.Parse(model.q9607),
                //Alimentação e Saúde: Principais Acções Desenvolvidas = model.q960,
                NumMerendasEscolaresAtri = double.Parse(model.q9608),
                DespesaMerenda = double.Parse(model.q9609),
                DespesaCuidadosPriSaude = double.Parse(model.q9610),
                DespesaAguaPTodos = double.Parse(model.q9611),
                OutrosProjectosAS = model.q9612,
                DespesaOutrosProjectos = double.Parse(model.q9613),
                //Agricultura Familiar e Empreendedorismo; Principais Acções Desenvolvidas = model.q960,
                DespesaOrgProdutivaComuni = double.Parse(model.q9614),
                DespesaInfraestruturasMicrofomento = double.Parse(model.q9615),
                DespesaOperacionalizacaoMicrofomento = double.Parse(model.q9616),
                OutrosProjectosAF = model.q9617,
                DespesaOutrosProject = double.Parse(model.q9618),
                //Ampliação e Promoção de Serviços Públicos Básicos e Acesso ao Ensino: Principais Acções Desenvolvidas = model.q960,
                DespesaInfraestrutSociais = double.Parse(model.q9619),
                DespesaGestaoManuInfraestrut = double.Parse(model.q9620),
                DespesaOperInfraestrutInsti = double.Parse(model.q9621),
                DespesaProjectoIntegrado = double.Parse(model.q9622),
                OutrosProjectosAP = model.q9623,
                DespesaOutrosProjectosAP = double.Parse(model.q9624),
                //Mobilização e Concertação Social: Principais Acções Desenvolvidas = model.q960,
                DespesaMobilizacaoSocial = double.Parse(model.q9625),
                DespesaReforçoInstituicional = double.Parse(model.q9626),
                OutrosProjectosMob = model.q9627,
                DespesaOutrosProjectosMob = double.Parse(model.q9628),
                //Transferências Social Produtiva: Principais Acções Desenvolvidas = model.q960,
                DespesaProgramaCartaoKikuia = double.Parse(model.q9629),
                OutrosProjectosTS = model.q9630,
                DespesaOutrosProjectosTS = double.Parse(model.q9631),
                //Outros Projectos = model.q960,
                OutrosProjectosOP = model.q9632,
                DespesaOutrosProjectosOP = double.Parse(model.q9633),
                //Ponto de situação do Programa = model.q960,
                PontoSituacaoPrincip = model.q9634,
                OutrasInfoRelev = model.q9635,
                Conclusoes = model.q9636,
                Recomendacoes = model.q9637,
                RelatorioProvinAnual = model.q9638,
                Observacoes = model.q9639,
            };
        }
    }
}
