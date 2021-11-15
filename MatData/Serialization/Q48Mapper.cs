using MatData.Models.Records;
using MatData.ViewModels;

namespace MatData.Serialization
{
    public static class Q48Mapper
    {
        public static Q48Model Serialize(Q48Record model)
        {
            return new Q48Model
            {
                NumeroDeAgentesMasculinosQueIntegramOEfectivoDeOrdemPublica = int.Parse(model.q4804),
                NumeroDeAgentesFemininosQueIntegramOEfectivoDeOrdemPublica = int.Parse(model.q4805),
                NumeroTotalDeAgentesQueIntegramOEfectivoDeOrdemPublica = int.Parse(model.q4806),
                NumeroDeHomensVitimasDeActosDelituososNoAnoTransacto = int.Parse(model.q4807),
                NumeroDeMulheresVitimasDeActosDelituososNoAnoTransacto = int.Parse(model.q4808),
                NumeroDeVitimasDeActosDelituososNoAnoTransacto = int.Parse(model.q4809),
                NumeroDeAcidentesDeTransitoOcorridosNoAnoTransacto = int.Parse(model.q4810),
                NumeroDeEncaminhadosParaAssistenciaHospitalarPorAcidentesDeTransitoOcorridosNoAnoTransacto = int.Parse(model.q4811),
                NumeroDeObtidosPorAcidentesDeTransitoOcorridosNoAnoTransacto = int.Parse(model.q4812),
                NumeroDeHomensVitimasDeAssaltoNaviaPublicaNoAnoTransacto = int.Parse(model.q4813),
                NumeroDeMulheresVitimasDeAssaltoNaviaPublicaNoAnoTransacto = int.Parse(model.q4814),
                NumeroDeVitimasDeAssaltoNaviaPublicaNoAnoTransacto = int.Parse(model.q4815),
                NumeroDeVitimasAtendidasPorViolenciaDomesticaNoAnoTransacto = int.Parse(model.q4816),
                NumeroDeVitimasAtendidasPorViolacaoNoAnoTransacto = int.Parse(model.q4817),
                NumeroDeAssaltosaPropriedadePrivadaNoAnoTransacto = int.Parse(model.q4818),
                NumeroDeFurtosParticipadosDeGadoProducaoAgricolaNoAnoTransacto = int.Parse(model.q4819),
                NumeroDeOcorrenciasDeSuspeitaDePeculatoNoAnoTransacto = int.Parse(model.q4820),
                NumeroDeHomensVitimasDeActosDelituososNoAnoCorrente = int.Parse(model.q4821),
                NumeroDeMulheresVitimasDeActosDelituososNoAnoCorrente = int.Parse(model.q4822),
                NumeroDeVitimasDeActosDelituososNoAnoCorrente = int.Parse(model.q4823),
                NumeroDeAcidentesDeTransitoOcorridosNoAnoCorrente = int.Parse(model.q4824),
                NumeroDeEncaminhadosParaAssistenciaHospitalarPorAcidentesDeTransitoOcorridosNoAnoCorrente = int.Parse(model.q4825),
                NumeroDeObtidosPorAcidentesDeTransitoOcorridosNoAnoCorrente = int.Parse(model.q4826),
                NumeroDeHomensVitimasDeAssaltoNaviaPublicaNoAnoCorrente = int.Parse(model.q4827),
                NumeroDeMulheresVitimasDeAssaltoNaviaPublicaNoAnoCorrente = int.Parse(model.q4828),
                NumeroDeVitimasDeAssaltoNaviaPublicaNoAnoCorrente = int.Parse(model.q4829),
                NumeroDeVitimasAtendidasPorViolenciaDomesticaNoAnoCorrente = int.Parse(model.q4830),
                NumeroDeVitimasAtendidasPorViolacaoNoAnoCorrente = int.Parse(model.q4831),
                NumeroDeAssaltosaPropriedadePrivadaNoAnoCorrente = int.Parse(model.q4832),
                NumeroDeFurtosParticipadosDeGadoProducaoAgricolaNoAnoCorrente = int.Parse(model.q4833),
                NumeroDeOcorrenciasDeSuspeitaDeCrimeDePeculatoNoAnoCorrente = int.Parse(model.q4834),
                NumeroDeEstrangeirosPresentesNoMunicipioPorRazoesDeTrabalho = int.Parse(model.q4835),
                NumeroDeHomensEstrangeirosPresentesNoMunicipioPorRazoesDeTrabalho = int.Parse(model.q4836),
                NumeroDeMulheresEstrangeirasPresentesNoMunicipioPorRazoesDeTrabalho = int.Parse(model.q4837),
                NumeroDeEstrangeirosPresentesNoMunicipioPorRazoesDeFamilia = int.Parse(model.q4838),
                NumeroDeHomensEstrangeirosPresentesNoMunicipioPorRazoesDeFamilia = int.Parse(model.q4839),
                NumeroDeMulheresEstrangeirasPresentesNoMunicipioPorRazoesDeFamilia = int.Parse(model.q4840),
                DuracaoMediaDaEstadiaDosEstrangeirosNoMunicipio = int.Parse(model.q4841),
                PrincipaisPaísesDeProvenienciaDosEstrangeirosPresentesNoMunicipio = model.q4842,
                Observacoes = model.q4843
            };
        }
    }
}
