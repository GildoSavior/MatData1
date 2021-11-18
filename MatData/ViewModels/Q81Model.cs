namespace MatData.ViewModels
{
    public class Q81Model
    {
        public string NomeArmador {get;set;}
        public string DataFundacao {get;set;}
        public string EstadoFuncional {get;set;}
        public string Nacionalidade {get;set;}
        public string FormaJuridica {get;set;}
        public string ClassificacaoArmador {get;set;}
        public string Localizacao {get;set;}
        public string FotoAcess {get;set;}
        public string FotoInterior {get;set;}
        public string FotoEmbarcacoes {get;set;}
        public string NumLicenca {get;set;}
        public string IdServico {get;set;}
        public string Contacto {get;set;}
        public string Email {get;set;}
        public string Website {get;set;}
        public string TipoPescador {get;set;}
        public int NumEmbarcPeqPorte {get;set;}
        public int NumEmbarcMedPorte {get;set;}
        public int NumEmbarcGrandPorte {get;set;}
        public int NumSaidasPesca {get;set;}
        public string PeriodSaidasPesca {get;set;}
        public int QtdPeixeCapturado {get;set;}
        public int QtdMedPeixeCapturado {get;set;}
        //Sub - produtos às pescas e ao mar: secagem e salga artesanal de peixe e extracção artesanal de sal 
        public double QtdPeixeSobraNaoFrescoSecar {get;set;}
        public double QtdPeixeSobraNaoFrescoSalga {get;set;}
        public double QtdSalExtraido {get;set;}
        public string QtdProdOutrosSubProdutos {get;set;}
         //Acesso a Sistemas de Apoio à Produção
        public string SistemasApoioProducao {get;set;}
        public string IdEntidadesApoio {get;set;}
        public double ValCredAnoCorrente {get;set;}
        public double ValCredUltimos5Anos {get;set;}
        //Movimento Associativo {get;set;}
        public string PertenceAssociacao {get;set;}
        public string IdAssociacao {get;set;}
        public string PrincipaiBeneficios {get;set;}
         //Captura anual {get;set;}
        public double QtdSardinhaCapturada {get;set;}
        public double QtdCarapauCapturada {get;set;}
        public double QtdPargoCapturada {get;set;}
        public double QtdAtumCapturada {get;set;}
        public double QtdCherneCapturada {get;set;}
        public double QtdCorvinaCapturada {get;set;}
        public double QtdEspadaCapturada {get;set;}
        public double QtdGaloCapturada {get;set;}
        public double QtdBagreCapturada {get;set;}
        public double QtdCacussoCapturada {get;set;}
        public double QtdCachucho {get;set;}
        public double QtdLagosta {get;set;}
        public double QtdCaranguejo {get;set;}
        public double QtdCamarao {get;set;}
        public double QtdOutrasEspecies {get;set;}
         //Aquicultura {get;set;}
        public string ArmadorPossuiTanques {get;set;}
        public int NumTanquesAquicultura {get;set;}
        public double CapacidadeTotalTanques {get;set;}
        public string LocalizacaoTanques {get;set;}
        public string FotoAcesso {get;set;}
        public string FotoTanque {get;set;}
        public string  FotoProducao {get;set;}
        public string EspeciesPeixeCriadas {get;set;}
        public double QtdPeixeCriadoAnoTransacto {get;set;}
        public double QtdPeixeCriadoTrimestralmente {get;set;}
         //Espécie de maior captura(EMC) {get;set;}
        public string IdEspecieMaiorCapturaEMC {get;set;}
        public double QtdEspecieCapturadaEMC {get;set;}
        public double CustosCapturaToneladaPescadoEMC {get;set;}
        public double ValVendaPescadoEMC {get;set;}
        public double PrecoKgPescadoEMC {get;set;}
       //Espécie de segunda maior captura(ESMC) {get;set;}
        public string IdEspecieMaiorCapturaESMC {get;set;}
        public double QtdEspecieCapturadaESMC {get;set;}
        public double CustosCapturaToneladaPescadoESMC {get;set;}
        public double ValVendaPescadoESMC {get;set;}
        public double PrecoKgPescadoESMC {get;set;}
        //Espécie de terceira maior captura(ETMC) {get;set;}
        public string IdEspecieMaiorCapturaETMC {get;set;}
        public double QtdEspecieCapturadaETMC {get;set;}
        public double CustosCapturaToneladaPescadoETMC {get;set;}
        public double ValVendaPescadoETMC {get;set;}
        public double PrecoKgPescadoETMC {get;set;}
        //Escoamento do pescado e condições de armazenamento e transporte {get;set;}
        public int NumVeiculosPropEscoamento {get;set;}
        public int NumVeiculosContratEscoamento {get;set;}
        public string GarantRefrigAcondPescBarco {get;set;}
        public string GarantRefrigAcondPescTransporte {get;set;}
        public string GarantRefrigAcondPescDoca {get;set;}
        public string PrincipDestinosEscoamento {get;set;}
        //Indicadores do Negócio {get;set;}
        public int NumClientesAnoTrans {get;set;}
        public int NumMedMensal {get;set;}
        public double DespesasMedMensais {get;set;}
        public double ReceitasMedMensais {get;set;}
        public double LucroMedMensal {get;set;}
        public string ContabilidadeOrganizada {get;set;}
        public double VolNegocios {get;set;}
        public string SituacaoTribRegularizada {get;set;}
        public double ValLiquidImpostos {get;set;}
        //Força de Trabalho {get;set;}
        public int NumDirProd {get;set;}
        public int NumEspecialistas {get;set;}
        public int NumTecIntermedios {get;set;}
        public int NumAdmEquiparados {get;set;}
        public int NumTrabServicosProteccao {get;set;}
        public int NumTrabQualificadosCulturas {get;set;}
        public int NumTrabQualificadosConstrucao {get;set;}
        public int NumOperVeiculos {get;set;}
        public int NumTrabNaoQualificados {get;set;}
        public int NumTotalTrabalhadores
        {
            get { return NumDirProd + NumEspecialistas + NumTecIntermedios + NumAdmEquiparados + NumTrabServicosProteccao + NumTrabQualificadosCulturas + NumTrabQualificadosConstrucao + NumOperVeiculos + NumTrabNaoQualificados; }
        }
        public string PrincipConstraIdentificados {get;set;}
        public string Observacoes { get; set; }

    }
}
