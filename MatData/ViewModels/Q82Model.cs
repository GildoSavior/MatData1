namespace MatData.ViewModels
{
    public class Q82Model
    {
        public string NomeOperadorIndustrial {get; set;}
        public string DataFundacao {get; set;}
        public string EstadoFuncional {get; set;}
        public string Nacionalidade {get; set;}
        public string FormaJuridica {get; set;}
        public string TipoMateriaPrimaExplorado {get; set;}
        public string TipoExploracao {get; set;}
        public string LocalizacaoEntidade {get; set;}
        public string FotoFrontal {get; set;}
        public string FotoInterior {get; set;}
        public string FotoMateriaPrima {get; set;}
        public string EntidadeLicenciada {get; set;}
        public string NumAlvara {get; set;}
        public string EntidadeCertificacaoAmbiental {get; set;}
        public string NumCertificacao {get; set;}
        public string IdServico {get; set;}
        public string Contacto {get; set;}
        public string Email {get; set;}
        public string Website {get; set;}
        public double PercentMateriaPrimaTransformada {get; set;}
         //Acesso a Sistemas de Apoio à actividade extractiva 
        public string SisApoioBeneficiou {get; set;}
        public string IdEntidadesApoio {get; set;}
        public double ValCredSectorAnoCorr {get; set;}
        public double ValCredSectorUltimos5Anos {get; set;}
        //Movimento Associativo 
        public string PertenceAssociacao {get; set;}
        public string IdAssociacao {get; set;}
        public string PrincipaisBenef {get; set;}
         //Actividade Extractiva 
        public string MateriaPrimaExtraida {get; set;}
        public string IdLocaisExploracao {get; set;}
         //Matéria - prima mais extraída(MPME) {get; set;}
        public string IdMateriaPrimaMPME {get; set;}
        public string IdlocaisExtraccaoMPME {get; set;}
        public string QtdMPMEExtraidaAnoTransactoMPME {get; set;}
        public string QtdMPMETrimestralmenteMPME {get; set;}
        public double CustosExtraccaoMPUnMPME {get; set;}
        public double ValVendaMPUnMPME {get; set;}
        public double PrecoComercializacaoUnMPME {get; set;}
        //Segunda matéria - prima mais extraída(SMPE) {get; set;}
        public string IdMateriaPrimaSMPE {get; set;}
        public string IdlocaisExtraccaoSMPE {get; set;}
        public string QtdMPMEExtraidaAnoTransactoSMPE {get; set;}
        public string QtdMPMETrimestralmenteSMPE {get; set;}
        public double CustosExtraccaoMPUnSMPE {get; set;}
        public double ValVendaMPUnSMPE {get; set;}
        public double PrecoComercializacaoUnSMPE {get; set;}
         //Terceira matéria - prima mais extraída(TMPE) {get; set;}
        public string IdMateriaPrimaTMPE {get; set;}
        public string IdlocaisExtraccaoTMPE {get; set;}
        public string QtdMPMEExtraidaAnoTransactoTMPE {get; set;}
        public string QtdMPMETrimestralmenteTMPE {get; set;}
        public double CustosExtraccaoMPUnTMPE {get; set;}
        public double ValVendaMPUnTMPE {get; set;}
        public double PrecoComercializacaoUnTMPE {get; set;}
         //Escoamento da matéria-prima e condições de armazenamento e transporte {get; set;}
        public int NVeiculosPropriosEscoamento {get; set;}
        public int NVeiculosContratualizadosAnoTransactoEscoamento {get; set;}
        public string PrincipDestinosEscoamento {get; set;}
        //Indicadores do Negócio {get; set;}
        public int NumClientes {get; set;}
        public int NumMensalCliente {get; set;}
        public double DespesasMensais {get; set;}
        public double ReceitasMensais {get; set;}
        public double LucroMensal {get; set;}
        public string ContabilidadeOrganizada {get; set;}
        public double VolumeNegocios {get; set;}
        public string SituacaoTributRegularizada {get; set;}
        public double ValorLiqImpostos {get; set;}
        //Força de Trabalho {get; set;}
        public int NumDirProd {get; set;}
        public int NumEspecialistas {get; set;}
        public int NumTecIntermedios {get; set;}
        public int NumAdmEquiparados {get; set;}
        public int NumTrabServicosProteccao {get; set;}
        public int NumTrabQualificadosCulturas {get; set;}
        public int NumTrabQualificadosConstrucao {get; set;}
        public int NumOperVeiculos {get; set;}
        public int NumTrabNaoQualificados {get; set;}
        public int NumTotalTrabalhadores
        {
            get { return NumDirProd + NumEspecialistas + NumTecIntermedios + NumAdmEquiparados + NumTrabServicosProteccao + NumTrabQualificadosCulturas + NumTrabQualificadosConstrucao + NumOperVeiculos + NumTrabNaoQualificados; }
        }
        public string PrincipConstraIdentificados {get; set;}
        public string Observacoes { get; set; }

    }
}
