namespace MatData.ViewModels
{
    public class Q79Model
    {
          public string NomeExploracaoAgricola {get; set;}
          public string ClassifiAgricultor {get; set;}
          public string DataFundOperEconomico {get; set;}
          public string EstadoFuncOperEconomico {get; set;}
          public string NacionalidadeOperador {get; set;}
          public string FormaJuridica {get; set;}
          public string LocalTerritorioAgri {get; set;}
          public string FotoAcessoTerriAgri {get; set;}
          public string FotoZonaCulturas1 {get; set;}
          public string FotoZonaCulturas2 {get; set;}
          public string NumTitulo {get; set;}
          public string IdServico {get; set;}
          public string Contacto {get; set;}
          public string Email {get; set;}
          public string Website {get; set;}
          public double NumTotalHectExploradosCampAnter {get; set;}
          public double NumTotalHectDispoCultivCampAnterior {get; set;}
          public double NumTotalHectExploradosCampCurso {get; set;}
          public double NumTotalHectDispoCultivCampCurso {get; set;}
           //Acesso a Sistemas de Apoio à Produção {get; set;}
          public string SistemaApoioProducao {get; set;}
          public string IdEntidadesApoio {get; set;}
          public double ValorCreditosAgropecuariosAC {get; set;}
          public double ValorCreditosAgropecuariosUlt5Anos {get; set;}
          //Movimento Associativo 
          public string PertenceAssociacao {get; set;}
          public string IdAssociacao {get; set;}
          public string PrincipaisBenef {get; set;}
           //Produção
          public string ProdFileiraCereais {get; set;}
          public string ProdFileiraLeguminosas {get; set;}
          public string ProdFileiraRaizes {get; set;}
          public string ProdFileiraHorticolas {get; set;}
          public string ProdFileiraFruticolas {get; set;}
          public string ProdOutrasFileirasProduzidos {get; set;}
           //Cultura de maior produção(CMP) 
          public string IdCMP {get; set;}
          public double VolProdCultCampTransCMP {get; set;}
          public double NumHectCultivadosAnoTransCMP {get; set;}
          public double NumHectCultivadosAnoCorrenteCMP {get; set;}
          public double CustoProdCMP {get; set;}
          public double ValorVendaProdutorCMP {get; set;}
          public double PrecoKgProdComercializacaoCMP {get; set;}
          //Cultura de segunda maior produção(CSMP)
          public string IdCSMP {get; set;}
          public double VolProdCultCampTransCSMP {get; set;}
          public double NumHectCultivadosAnoTransCSMP {get; set;}
          public double NumHectCultivadosAnoCorrenteCSMP {get; set;}
          public double CustoProdCSMP {get; set;}
          public double ValorVendaProdutorCSMP {get; set;}
          public double PrecoKgProdComercializacaoCSMP {get; set;}

          //Cultura de terceira maior produção(CTMP) 
          public string IdCTMP {get; set;}
          public double VolProdCultCampTransCTMP {get; set;}
          public double NumHectCultivadosAnoTransCTMP {get; set;}
          public double NumHectCultivadosAnoCorrente {get; set;}
          public double CustoProdCTMP {get; set;}
          public double ValorVendaProdutorCTMP {get; set;}
          public double PrecoKgProdComercializacaoCTMP {get; set;}

          //Escoamento da Produção 
          public int NumVeiculosEscoamento {get; set;}
          public int NumVeiculosContratualizados {get; set;}
          public string PrincipDestinosEscoamento {get; set;}
          
          //Indicadores do Negócio 
          public int NumClientesAnoTransacto {get; set;}
          public double NumMedMensalCliente {get; set;}
          public double DespesasMensais {get; set;}
          public double ReceitasMensais {get; set;}
          public double LucroMensal {get; set;}
          public string ContabilidadeOrganizada {get; set;}
          public double VolNegocios {get; set;}
          public string SituacaoTributRegularizada {get; set;}
          public double ValLiquidadoImpostos {get; set;}
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
          public int NumTotalTrabalhadores { 
            get { return NumDirProd + NumEspecialistas + NumTecIntermedios + NumAdmEquiparados + NumTrabServicosProteccao + NumTrabQualificadosCulturas + NumTrabQualificadosConstrucao + NumOperVeiculos + NumTrabNaoQualificados; } 
        }
          public string PrincipConstraIdentificados { get; set;}
          public string Observacoes { get; set; }

    }
}
