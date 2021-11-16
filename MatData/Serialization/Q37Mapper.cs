using MatData.Models.Records;
using MatData.ViewModels;

namespace MatData.Serialization
{
    public static class Q37Mapper
    {
        public static Q37Model Serialize(Q37Record model)
        {
            return new Q37Model
            {
                DesignacaoDaUnidadeDeSaude = model.q3706,
                TipologiaDeUnidadeDeSaude = model.q3707,
                LocalizacaoDaUnidadeDeSaude = model.q3708,
                IdentificacaoDoServicoOuPessoaDeContacto = model.q3709,
                ContactoTelefonico = model.q3710,
                EnderecoDeEmail = model.q3711,
                Website = model.q3712,
                AnoDeConstrucaoDaUnidadeDeSaude = int.Parse(model.q3713),
                RegistoFotograficoFrontal = model.q3714,
                RegistoFotograficoLateralDireito = model.q3715,
                RegistoFotograficoLateralEsquerdo = model.q3716,
                RegistoFotograficoInterior1 = model.q3717,
                RegistoFotograficoInterior2 = model.q3718,
                TipoDeEstruturaDaUnidadeDeSaude = model.q3719,
                SituacaoDaEstruturaDaUnidadeDeSaude = model.q3720,
                EstadoDeConservacaoDaUnidadeDeSaude = model.q3721,
                PrincipalFonteDeAbastecimentoDeAgua = model.q3722,
                SegundaFonteDeAbastecimentoDeAgua = model.q3723,
                PrincipalFonteDeAbastecimentoDeEnergia = model.q3724,
                SegundaFonteDeAbastecimentoDeEnergia = model.q3725,
                PrincipalTipoDeSaneamentoBasico = model.q3726,
                SegundoTipoDeSaneamentoBasico = model.q3727,
                MeiosDeRecolhaDeLixoGeral = model.q3728,
                MeiosDeTratamentoDeLixoGeral = model.q3729,
                ExistênciaDeRecolhaSelectivaDeLixoHospitalar = model.q3730,
                ProcedimentosDeTratamentoDeLixoHospitalar = model.q3731,
                GestaoDaUnidadeDeSaude = model.q3732,
                PropriedadeDaUnidadeDeSaude = model.q3733,
                LicencaDeFuncionamentoDeUsNaoPublicaParaaAreaDaSaude = model.q3733 == "Privada" ? model.q3734 : null,
                AreasaFuncionarNaUnidadeDeSaude = model.q3735,
                ServicosaFuncionarNaUnidadeDeSaude = model.q3736,
                ServicoDeMorgueaFuncionarNaUnidadeDeSaude = model.q3737,
                CapacidadeDaMorgue = model.q3738,
                ExistênciaDeEstruturaParaServicoDeAlimentacaoAoUtente = model.q3739,
                EmFuncionamento = model.q3740,
                NumeroMedioDeRefeicoesServidasDiariamente = model.q3741,
                EspecialidadesDeSaude = model.q3742,
                GabineteDoUtente = model.q3743,
                GabineteDeSaudePublica = model.q3744,
                NumeroDeCamasDaUnidadeDeSaude = int.Parse(model.q3745),
                KitDeMedicamentosCorrespondenteaTipologiaUsNoPresente = model.q3746,
                PacoteCompletoDeMedicamentosEssenciaisNoPresente = model.q3747,
                DistânciaaUsDeReferência = model.q3748,
                AcessoaUsDeReferência = model.q3749,
                NumeroDeMedicosNaUs = int.Parse(model.q3750),
                NumeroDeEnfermeirosNaUs = int.Parse(model.q3751),
                NumeroDeTecnicosDeDiagnosticoNaUs = int.Parse(model.q3752),
                NumeroDeOutrosTecnicosNaUs = int.Parse(model.q3753),
                NumeroDeEquipasAvancadasMoveisRealizadasaPopulacaoSemAcessoaUs = int.Parse(model.q3754),
                ServicosDeManutencaoDosEquipamentosDaUs = model.q3755,
                ServicosDeReparacaoDosEquipamentosDaUs = model.q3756,
                Observacoes = model.q3757
            };
        }
    }
}
