using MatData.Models.Records;
using MatData.ViewModels;

namespace MatData.Serialization
{
    public static class Q38Mapper
    {
        public static Q38Model Serialize(Q38Record model)
        {
            return new Q38Model
            {
                DesignacaoDaUnidadeDeSaude = model.q3806,
                TipologiaDeUnidadeDeSaude = model.q3807,
                NumeroMedioDeUtentesAtendidosPorMesPorDoencasDoForoCardiacoEVascular = int.Parse(model.q3808),
                NumeroMedioDeUtentesAtendidosPorMesPorDdaDoencaDiarreicaAguda = int.Parse(model.q3809),
                NumeroMedioDeUtentesAtendidosPorMesPorDraDoencaRespiratoriaAguda = int.Parse(model.q3810),
                NumeroMedioDeUtentesAtendidosPorMesPorAcompanhamentoDeGravidez = int.Parse(model.q3811),
                NumeroMedioDeUtentesAtendidosPorMesParaPlaneamentoFamiliar = int.Parse(model.q3812),
                NumeroMedioDeUtentesAtendidosPorMesEmAcompanhamentoPediatrico = int.Parse(model.q3813),
                NumeroMedioDeUtentesAtendidosPorMesParaVacinacao = int.Parse(model.q3814),
                NumeroMedioDeUtentesAtendidosPorMesPorAcidentes = int.Parse(model.q3815),
                NumeroMedioDeUtentesAtendidosPorMesPorMalaria = int.Parse(model.q3816),
                NumeroMedioDeUtentesAtendidosPorMesPorVihSida = int.Parse(model.q3817),
                NumeroMedioDeUtentesAtendidosPorMesPorTuberculose = int.Parse(model.q3818),
                NumeroMedioDeUtentesAtendidosPorMesPorColera = int.Parse(model.q3819),
                NumeroMedioDeUtentesAtendidosPorMesPorFebreAmarela = int.Parse(model.q3820),
                NumeroMedioDeUtentesAtendidosPorMesPorOutrasDoencasTransmissiveis = int.Parse(model.q3821),
                NumeroMedioDeUtentesAtendidosPorMesPorOutrasDoencasNaoTransmissiveis = int.Parse(model.q3822),
                NumeroMedioDeUtentesAtendidosPorMesParaRealizacaoDeExamesComplementaresDeDiagnostico = int.Parse(model.q3823),
                NumeroMedioDeUtentesMasculinosAdultosMaioresDe18AnosAtendidosPorMesNaUnidadeDeSaude = int.Parse(model.q3824),
                NumeroMedioDeUtentesFemininosAdultosMaioresDe18AnosAtendidosPorMesNaUnidadeDeSaude = int.Parse(model.q3825),
                NumeroMedioDeUtentesMasculinosDos14Aos18AnosAtendidosPorMesNaUnidadeDeSaude = int.Parse(model.q3826),
                NumeroMedioDeUtentesFemininosDos14Aos18AnosAtendidosPorMesNaUnidadeDeSaude = int.Parse(model.q3827),
                NumeroMedioDeUtentesMasculinosMenoresDe14AnosAtendidosPorMesNaUnidadeDeSaude = int.Parse(model.q3828),
                NumeroMedioDeUtentesFemininosMenoresDe14AnosAtendidosPorMesNaUnidadeDeSaude = int.Parse(model.q3829),
                NumeroMedioDeUtentesAtendidosPorMesNaUnidadeDeSaude = int.Parse(model.q3830),
                Observacoes = model.q3831
            };
        }
    }
}
