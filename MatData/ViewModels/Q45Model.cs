namespace MatData.ViewModels
{
    public class Q45Model
    {
        public string NomeDeInfraestruturaDeManutencaoDaJusticaEDireitosHumanos { get; set; }
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
        public string LotacaoPrevistaDaInfraestruturaDeManutencaoDaJustica { get; set; }
        public int NumeroDeUtentesDeSexoMasculinoDaInfraestruturaDeManutencaoDaJustica { get; set; }
        public int NumeroDeUtentesDeSexoFemininoDaInfraestruturaDeManutencaoDaJustica { get; set; }
        public int NumeroTotalDeUtentesDaInfraestruturaDeManutencaoDaJustica
        {
            get {
                return NumeroDeUtentesDeSexoMasculinoDaInfraestruturaDeManutencaoDaJustica + NumeroDeUtentesDeSexoFemininoDaInfraestruturaDeManutencaoDaJustica;
            }
        }
        public string SituacaoDaInfraestruturaDeManutencaoDaJustica { get; set; }
        public string GestaoDaInfraestruturaDeManutencaoDaJustica { get; set; }
        public string EstadoDeConservacaoDaInfraestruturaDeManutencaoDaJustica { get; set; }
        public string PrincipalFonteDeAbastecimentoDeAgua { get; set; }
        public string SegundaFonteDeAbastecimentoDeAgua { get; set; }
        public string PrincipalFonteDeAbastecimentoDeEnergia { get; set; }
        public string SegundaFonteDeAbastecimentoDeEnergia { get; set; }
        public string PrincipalTipoDeSaneamentoBasico { get; set; }
        public string SegundoTipoDeSaneamentoBasico { get; set; }
        public string MeiosDeRecolhaDeLixo { get; set; }
        public string MeiosDeTratamentoDeLixo { get; set; }
        public string Observacoes { get; set; }
    }
}
