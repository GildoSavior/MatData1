namespace MatData.ViewModels
{
    public class Q43Model
    {
        public string TipoDeInfraestruturaDeProteccaoSocial { get; set; }
        public string NomeDaInfraestruturaDeProteccaoSocial { get; set; }
        public string FotografiaDaInfraestruturaFrontal { get; set; }
        public string FotografiaDaInfraestruturaLateralDireito { get; set; }
        public string FotografiaDaInfraestruturaLateralEsquerdo { get; set; }
        public string FotografiaDaInfraestruturaInterior1 { get; set; }
        public string FotografiaDaInfraestruturaInterior2 { get; set; }
        public string LocalizacaoDaInfraestrutura { get; set; }
        public string IdentificacaoDoServicoOuPessoaDeContacto { get; set; }
        public string ContactoTelefonico { get; set; }
        public string EnderecoDeEmail { get; set; }
        public string Website { get; set; }
        public string UtentesDosServicosPrestados { get; set; }
        public string LotacaoPrevistaDaInfraestruturaDeProteccaoSocial { get; set; }
        public int NumeroDeUtentesDeSexoMasculinoDaInfraestruturaDeProteccaoSocial { get; set; }
        public int NumeroDeUtentesDeSexoFemininoDaInfraestruturaDeProteccaoSocial { get; set; }
        public int NumeroTotalDeUtentesDaInfraestruturaDeProteccaoSocial
        {
            get
            {
                return NumeroDeUtentesDeSexoMasculinoDaInfraestruturaDeProteccaoSocial + NumeroDeUtentesDeSexoFemininoDaInfraestruturaDeProteccaoSocial;
            }
        }
        public string SituacaoDaInfraestruturaDeProteccaoSocial { get; set; }
        public string GestaoDaInfraestruturaDeProteccaoSocial { get; set; }
        public string RegistoLegalDaInfraestruturaNoSectorDeTutela { get; set; }
        public string NumeroDoRegistoLegal { get; set; }
        public string EstadoDeConservacaoDaInfraestruturaDeProteccaoSocial { get; set; }
        public string PrincipalFonteDeAbastecimentoDeAgua { get; set; }
        public string SegundaFonteDeAbastecimentoDeAgua { get; set; }
        public string PrincipalFonteDeAbastecimentoDeEnergia { get; set; }
        public string SegundaFonteDeAbastecimentoDeEnergia { get; set; }
        public string PrincipalTipoDeSaneamentoBasico { get; set; }
        public string SegundoTipoDeSaneamentoBasico { get; set; }
        public string MeiosDeRecolhaDeLixo { get; set; }
        public string MeiosDeTratamentoDeLixo { get; set; }
        public string Observacões { get; set; }


    }
}
