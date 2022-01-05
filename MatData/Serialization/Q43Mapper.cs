using MatData.Models.Records;
using MatData.ViewModels;

namespace MatData.Serialization
{
    public class Q43Mapper
    {
        public static Q43Model Serialize(Q43Record model)
        {
            return new Q43Model
            {
                TipoDeInfraestruturaDeProteccaoSocial = model.q4306,
                NomeDaInfraestruturaDeProteccaoSocial = model.q4307,
                FotografiaDaInfraestruturaFrontal = model.q4308,
                FotografiaDaInfraestruturaLateralDireito = model.q4309,
                FotografiaDaInfraestruturaLateralEsquerdo = model.q4310,
                FotografiaDaInfraestruturaInterior1 = model.q4311,
                FotografiaDaInfraestruturaInterior2 = model.q4312,
                LocalizacaoDaInfraestrutura = model.q4313,
                IdentificacaoDoServicoOuPessoaDeContacto = model.q4314,
                ContactoTelefonico = model.q4315,
                EnderecoDeEmail = model.q4316,
                Website = model.q4317,
                UtentesDosServicosPrestados = model.q4318,
                LotacaoPrevistaDaInfraestruturaDeProteccaoSocial = model.q4319,
                NumeroDeUtentesDeSexoMasculinoDaInfraestruturaDeProteccaoSocial = int.Parse(model.q4320),
                NumeroDeUtentesDeSexoFemininoDaInfraestruturaDeProteccaoSocial = int.Parse(model.q4321),
                SituacaoDaInfraestruturaDeProteccaoSocial = model.q4323,
                GestaoDaInfraestruturaDeProteccaoSocial = model.q4324,
                RegistoLegalDaInfraestruturaNoSectorDeTutela = model.q4325,
                NumeroDoRegistoLegal = model.q4325 != "Sim" ? model.q4326 : null,
                EstadoDeConservacaoDaInfraestruturaDeProteccaoSocial = model.q4327,
                PrincipalFonteDeAbastecimentoDeAgua = model.q4328,
                SegundaFonteDeAbastecimentoDeAgua = model.q4329,
                PrincipalFonteDeAbastecimentoDeEnergia = model.q4330,
                SegundaFonteDeAbastecimentoDeEnergia = model.q4331,
                PrincipalTipoDeSaneamentoBasico = model.q4332,
                SegundoTipoDeSaneamentoBasico = model.q4333,
                MeiosDeRecolhaDeLixo = model.q4334,
                MeiosDeTratamentoDeLixo = model.q4335,
                Observacões = model.q4336
            };
        }
    }
}
