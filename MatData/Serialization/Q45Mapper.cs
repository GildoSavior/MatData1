using MatData.Models.Records;
using MatData.ViewModels;

namespace MatData.Serialization
{
    public class Q45Mapper
    {
        public static Q45Model Serialize(Q45Record model)
        {
            return new Q45Model
            {
                NomeDeInfraestruturaDeManutencaoDaJusticaEDireitosHumanos = model.q4506,
                FotografiaDaInfraestruturaFrontal = model.q4507,
                FotografiaDaInfraestruturaLateralDireito = model.q4508,
                FotografiaDaInfraestruturaLateralEsquerdo = model.q4509,
                FotografiaDaInfraestruturaInterior1 = model.q4510,
                FotografiaDaInfraestruturaInterior2 = model.q4511,
                LocalizacaoDaInfraestrutura = model.q4512,
                IdentificacaoDoServicoOuPessoaDeContacto = model.q4513,
                ContactoTelefonico = model.q4514,
                EnderecoDeEmail = model.q4515,
                Website = model.q4516,
                LotacaoPrevistaDaInfraestruturaDeManutencaoDaJustica = model.q4517,
                NumeroDeUtentesDeSexoMasculinoDaInfraestruturaDeManutencaoDaJustica = int.Parse(model.q4518),
                NumeroDeUtentesDeSexoFemininoDaInfraestruturaDeManutencaoDaJustica = int.Parse(model.q4519),
                SituacaoDaInfraestruturaDeManutencaoDaJustica = model.q4521,
                GestaoDaInfraestruturaDeManutencaoDaJustica = model.q4522,
                EstadoDeConservacaoDaInfraestruturaDeManutencaoDaJustica = model.q4523,
                PrincipalFonteDeAbastecimentoDeAgua = model.q4524,
                SegundaFonteDeAbastecimentoDeAgua = model.q4525,
                PrincipalFonteDeAbastecimentoDeEnergia = model.q4526,
                SegundaFonteDeAbastecimentoDeEnergia = model.q4527,
                PrincipalTipoDeSaneamentoBasico = model.q4528,
                SegundoTipoDeSaneamentoBasico = model.q4529,
                MeiosDeRecolhaDeLixo = model.q4530,
                MeiosDeTratamentoDeLixo = model.q4531,
                Observacoes = model.q4532,
            };
        }
    }
}
