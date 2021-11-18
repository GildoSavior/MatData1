namespace MatData.ViewModels
{
    public class Q83Model
    {
         public string NomeOperadorIndustrial{get; set;}
         public string DataFundacao{get; set;}
         public string EstadoFuncional{get; set;}
         public string Nacionalidade{get; set;}
         public string FormaJuridica{get; set;}
         public string TipoIndustriaTransformadora{get; set;}
         public string TipoIndustriaAcordoDimensao{get; set;}
         public string EnquadramentoPoloDesenvol{get; set;}
         public string IdPolo{get; set;}
         public string LocalUnFabril{get; set;}
         public string FotoFrontal{get; set;}
         public string FotoInterior{get; set;}
         public string FotoProducao{get; set;}
         public string EntidadeAlvaraIndustrial{get; set;}
         public string NumAlvara{get; set;}
         public string EntidadeCertificAmbient{get; set;}
         public string NumCertificacao{get; set;}
         public string IdServico{get; set;}
         public string Contacto{get; set;}
         public string Email{get; set;}
         public string Website{get; set;}
         public string IdPrincipaisProdProduzidos{get; set;}
         //Acesso a Sistemas de Apoio à actividade industrial
         public string SisApoioBeneficiou{get; set;}
         public string IdEntidadesApoio{get; set;}
         public double ValCredSectorAnoCorr{get; set;}
         public double ValCredSectorUltimos5Anos{get; set;}
         //Movimento Associativo
         public string PertenceAssociacao{get; set;}
         public string IdAssociacao{get; set;}
         public string PrincipBeneficios{get; set;}
         //Produto de maior produção(PMP)
         public string IdProdutoPMP{get; set;}
         public string QtdProdProduzidoAnoTransPMP{get; set;}
         public string QtdProdProduzidoTrimestralmentePMP{get; set;}
         public double CustoProducaoUnMedidaPMP{get; set;}
         public double ValVendaProdutoProduzidoUnPMP{get; set;}
         public double PrecoComercializacaoUnPMP{get; set;}
         //Produto de segunda maior produção(PSMP)
         public string IdProdutoPSMP{get; set;}
         public string QtdProdProduzidoAnoTransPSMP{get; set;}
         public string QtdProdProduzidoTrimestralmentePSMP{get; set;}
         public double CustoProducaoUnMedidaPSMP{get; set;}
         public double ValVendaProdutoProduzidoUnPSMP{get; set;}
         public double PrecoComercializacaoUnPSMP{get; set;}
         //Produto de terceira maior produção(PTMP)
         public string IdProdutoPTMP{get; set;}
         public string QtdProdProduzidoAnoTransPTMP{get; set;}
         public string QtdProdProduzidoTrimestralmentePTMP{get; set;}
         public double CustoProducaoUnMedidaPTMP{get; set;}
         public double ValVendaProdutoProduzidoUnPTMP{get; set;}
         public double PrecoComercializacaoUnPTMP{get; set;}
         //Escoamento do produto e condições de armazenamento e transporte
         public string PrincipaisDestinosEscoamento{get; set;}
         public string FormArmazenamento{get; set;}
         public string CadeiaDistribuicao{get; set;}
         //Indicadores do Negócio
         public int NumClientes{get; set;}
         public int NumMensalCliente{get; set;}
         public double DespesasMensais{get; set;}
         public double ReceitasMensais{get; set;}
         public double LucroMensal{get; set;}
         public string ContabilidadeOrganizada{get; set;}
         public double VolumeNegocios{get; set;}
         public string SituacaoTributRegularizada{get; set;}
         public double ValorLiqImpostos{get; set;}
         //Força de Trabalho{get; set;}
         public int NumDirProd{get; set;}
         public int NumEspecialistas{get; set;}
         public int NumTecIntermedios{get; set;}
         public int NumAdmEquiparados{get; set;}
         public int NumTrabServicosProteccao{get; set;}
         public int NumTrabQualificadosCulturas{get; set;}
         public int NumTrabQualificadosConstrucao{get; set;}
         public int NumOperVeiculos{get; set;}
         public int NumTrabNaoQualificados{get; set;}
         public int NumTotalTrabalhadores
         {
             get { return NumDirProd + NumEspecialistas + NumTecIntermedios + NumAdmEquiparados + NumTrabServicosProteccao + NumTrabQualificadosCulturas + NumTrabQualificadosConstrucao + NumOperVeiculos + NumTrabNaoQualificados; }
         }
         public string PrincipConstraIdentificados{get; set;}
         public string Observacoes { get; set; }

    }
}
