namespace MatData.ViewModels
{
    public class Q85Model
    {
         public string NomeUnHoteleira {get; set;}
         public string DataFundacao {get; set;}
         public string EstadoFuncional {get; set;}
         public string Nacionalidade {get; set;}
         public string FormaJuridica {get; set;}
         public string TipoInstalacoes {get; set;}
         public string TipoEstrutEmpresarial {get; set;}
         public string PrincipTipoActividade {get; set;}
         public string LocalUnHoteleira {get; set;}
         public string FotoFrontal {get; set;}
         public string FotoInterior {get; set;}
         public string AlvaraComercial {get; set;}
         public string NumAlvara {get; set;}
         public string IdServico {get; set;}
         public string Contacto {get; set;}
         public string Email {get; set;}
         public string Website {get; set;}
         //Lotação dos serviços {get; set;}
         public int NumQuartos {get; set;}
         public int NumCamas {get; set;}
         public int NumMesas {get; set;}
         public int NumCadeiras {get; set;}
         public int NumTuristasNacionaisAnoTrans {get; set;}
         public int NumMedTuristasNacionaisMes {get; set;}
         public int NumTuristasEstrageirosAnoTrans {get; set;}
         public int NumMedTuristasEstrageirosMes {get; set;}
         public double TaxaMedOcupacaoAnoTrans {get; set;}
         public double TaxaMedcupacaoMensal {get; set;}
         //Acesso a Sistemas de Apoio à actividade comercial {get; set;}
         public string SisApoioBeneficiou {get; set;}
         public string IdEntidadesApoio {get; set;}
         public double ValCredSectorAnoCorr {get; set;}
         public double ValCredSectorUltimos5Anos {get; set;}
         //Movimento Associativo {get; set;}
         public string PertenceAssociacao {get; set;}
         public string IdAssociacao {get; set;}
         public string PrincipBeneficios {get; set;}
         //Condições de armazenamento de stocks {get; set;}
         public string FormArmazenamento {get; set;}
         public string ExistMeiosEspeciConserv {get; set;}
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
