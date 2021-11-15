using MatData.Models.Records;
using MatData.ViewModels;

namespace MatData.Serialization
{
    public static class Q47Mapper
    {
        public static Q47Model Serialize(Q47Record model)
        {
            return new Q47Model
            {
                NomeDeInfraestruturaDeManutencaoDaOrdemPublica = model.q4706,
                FotografiaDaInfraestruturaFrontal = model.q4707 ,
                FotografiaDaInfraestruturaLateralDireito = model.q4708,
                FotografiaDaInfraestruturaLateralEsquerdo = model.q4709,
                FotografiaDaInfraestruturaInterior1 = model.q4710,
                FotografiaDaInfraestruturaInterior2 = model.q4711,
                LocalizacaoDaInfraestrutura = model.q4712,
                IdentificacaoDoServicoOuPessoaDeContacto = model.q4713,
                ContactoTelefonico = model.q4714,
                EndereçoDeEmail = model.q4715,
                Website = model.q4716,
                TipologiaDeInfraestruturaDeOrdemPublica = model.q4717,
                SituacaoDaInfraestruturaDeOrdemPublica = model.q4718,
                EstadoDeConservacaoDaInfraestruturaDeOrdemPublica = model.q4719,
                PrincipalFonteDeAbastecimentoDeAgua = model.q4720,
                SegundaFonteDeAbastecimentoDeAgua = model.q4721,
                PrincipalFonteDeAbastecimentoDeEnergia = model.q4722,
                SegundaFonteDeAbastecimentoDeEnergia = model.q4723,
                PrincipalTipoDeSaneamentoBasico = model.q4724,
                SegundoTipoDeSaneamentoBasico = model.q4725,
                MeiosDeRecolhaDeLixo = model.q4726,
                MeiosDeTratamentoDeLixo = model.q4727,
                Observações = model.q4728
            };
        }
    }
}
