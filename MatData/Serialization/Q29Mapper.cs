using MatData.Models.Records;
using MatData.ViewModels;

namespace MatData.Serialization
{
    public class Q29Mapper
    {
        public static Q29Model Serialize(Q29Record model)
        {
            return new Q29Model
            {
                DesignacaoDaEstruturaEscolar = model.q2906,
                LocalizacaoDaEstruturaEscolar = model.q2907,
                IdentificacaoDoServicoOuPessoaDeContacto = model.q2908,
                ContactoTelefonico = model.q2909,
                EnderecoDeEmail = model.q2910,
                Website = model.q2911,
                AnoDeConstrucaoDaEstruturaEscolar = model.q2912,
                RegistoLegalDaEstruturaEscolarSeNaoEEstruturaPublica = model.q2913,
                NumeroDeAlvaraDeAutorizacaoDeFuncionamentoDaEstruturaEscolarSeNaoEEstruturaPublica = model.q2914,
                NumeroDeSalasDeAulaDe63m2 = model.q2915,
                NumeroDeSalasDeAulaComOutrasDimensões = model.q2916,
                NumeroDeSalasEspecializadasLaboratoriosBibliotecasEtc = model.q2917,
                EspacoParaPraticaDesportiva = model.q2918,
                EspacoDeRecreioEConvivio = model.q2919,
                RegistoFotograficoFrontal = model.q2920,
                RegistoFotograficoLateralDireito = model.q2921,
                RegistoFotograficoLateralEsquerdo = model.q2922,
                RegistoFotograficoInterior1 = model.q2923,
                RegistoFotograficoInterior2 = model.q2924,
                TipoDeEstruturaEscolar = model.q2925,
                SituacaoDaEstruturaEscolar = model.q2926,
                EdificioConstruidoComoEstruturaEscolar = model.q2927,
                GestaoDaEstruturaEscolar = model.q2928,
                TipologiaDeConstrucaoDaEstruturaEscolar = model.q2929,
                NiveisDeEnsinoaFuncionarNaEstruturaEscolar = model.q2930,
                EstadoDeConservacaoDaEstruturaEscolar = model.q2931,
                PrincipalFonteDeAbastecimentoDeAgua = model.q2932,
                SegundaFonteDeAbastecimentoDeAgua = model.q2933,
                PrincipalFonteDeAbastecimentoDeEnergia = model.q2934,
                SegundaFonteDeAbastecimentoDeEnergia = model.q2935,
                PrincipalTipoDeSaneamentoBasico = model.q2936,
                SegundoTipoDeSaneamentoBasico = model.q2937,
                MeiosDeRecolhaDeLixo = model.q2938,
                MeiosDeTratamentoDeLixo = model.q2939,
                Observacões = model.q2940
            };
        }
    }
}
