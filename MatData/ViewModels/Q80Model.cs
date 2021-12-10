namespace MatData.ViewModels
{
    public class Q80Model
    {
        public string NomeProdutor {get;set;}
        public string DataFundacaoOpEco {get;set;}
        public string EstadoFuncional {get;set;}
        public string Nacionalidade {get;set;}
        public string FormaJuridica {get;set;}
        public string ClassificacaoProdutor {get;set;}
        public string LocalExploPecuaria {get;set;}
        public string FotoAcesso {get;set;}
        public string FotoZonaAnimais1 {get;set;}
        public string FotoZonaAnimais2 {get;set;}
        public string NumTituloConcTerra {get;set;}
        public string IdServico {get;set;}
        public string Contacto {get;set;}
        public string Email {get;set;}
        public string Website {get;set;}
        public int NumEfectBovinoCriAnoTrans {get;set;}
        public int NumEfectOvinoCriAnoTrans {get;set;}
        public int NumEfectSuinoCriAnoTrans {get;set;}
        public int NumEfectAvesCriAnoTrans {get;set;}
        //Acesso a Sistemas de Apoio à Produção(SAP)
        public string[] SAPBeneficiou {get;set;}
        public string IdEntidadesApoio {get;set;}
        public double ValSubscritoCredAgropecAnoCorr {get;set;}
        public double ValSubscritoCredAgropecUltimos5Anos {get;set;}
        //Movimento Associativo
        public string ProdutorPertenceAssoc {get;set;}
        public string IdAssoc {get;set;}
        public string[] PrincipBeneficios {get;set;}
        public string ProdutorPertenceCoop {get;set;}
        public string IdCooperativa {get;set;}
        public string PrincipaisBenefCoop {get;set;}
        //Produção anual
        public int NumEfectBovComercializadoVivo {get;set;}
        public int NumEfectBovComercializadoAbatido {get;set;}
        public double QtdCarneBovinaComercializada {get;set;}
        public int NumEfectOvinoComercializadoVivo {get;set;}
        public int NumEfectOvinoComercializadoAbatido {get;set;}
        public double QtdCarneOvinaComercializada {get;set;}
        public int NumEfectSuinoComercializadoVivo {get;set;}
        public int NumEfectSuinoComercializadoAbatido {get;set;}
        public double QtdCarneSuinaComercializada {get;set;}
        public int NumEfectAvesComercializadoVivo {get;set;}
        public int NumEfectAvesComercializadoAbatido {get;set;}
        public double QtdCarneAvesComercializada {get;set;}
        //Criação de maior produção CMP
        public string IdCMP {get;set;}
        public int VolProdEspecieAnoTransactoCMP {get;set;}
        public double CustoProdKgCMP {get;set;}
        public double ValVendaProdKgAnimalVivoCMP {get;set;}
        public double ValVendaProdKgCarneAbatidaCMP {get;set;}
        public double ValVendaProdKgCarneDesmanchadaCMP {get;set;}
        public double PrecoKgAnimalVivoComercializacaoCMP {get;set;}
        public double PrecoKgCarneAbatidaComercializacaoCMP {get;set;}
        public double PrecoKgCarneDesmanchadaComercializacaoCMP {get;set;}
        //Criação de segunda maior produção (CSMP)
        public string IdCSMP {get;set;}
        public int VolProdEspecieAnoTransactoCSMP {get;set;}
        public double CustoProdKgCSMP {get;set;}
        public double ValVendaProdKgAnimalVivoCSMP {get;set;}
        public double ValVendaProdKgCarneAbatidaCSMP {get;set;}
        public double ValVendaProdKgCarneDesmanchadaCSMP {get;set;}
        public double PrecoKgAnimalVivoComercializacaoCSMP {get;set;}
        public double PrecoKgCarneAbatidaComercializacaoCSMP {get;set;}
        public double PrecoKgCarneDesmanchadaComercializacaoCSMP {get;set;}
        //Criação de terceira maior produção(CTP)
        public string IdCTP {get;set;}
        public int VolProdEspecieAnoTransactoCTP {get;set;}
        public double CustoProdKgCTP {get;set;}
        public double ValVendaProdKgAnimalVivoCTP {get;set;}
        public double ValVendaProdKgCarneAbatidaCTP {get;set;}
        public double ValVendaProdKgCarneDesmanchadaCTP {get;set;}
        public double PrecoKgAnimalVivoComercializacaoCTP {get;set;}
        public double PrecoKgCarneAbatidaComercializacaoCTP {get;set;}
        public double PrecoKgCarneDesmanchadaComercializacaoCTP {get;set;}
        //Escoamento da Produção
        public int NumVeiculosEscoamento {get;set;}
        public int NumVeiculosContratualizadosCampEsc {get;set;}
        public string GarantiaQualidadeAcondicionamento {get;set;}
        public string PrincipDestinosEscoamento {get;set;}
        //Controlo e vigilância sanitária e vacinação
        public string ExploracaoPecuaria {get;set;}
        public int NumMedicosVeterinarios {get;set;}
        public int NumTecZootecnica {get;set;}
        public string PeriodVigiSanitaria {get;set;}
        public string PeriodMonitorCondSaude {get;set;}
        public double PercentAnimaisVacinados {get;set;}
        //Condições de abate e desmanche
        public string ExplorPecuariaPossuiInstalacoes {get;set;}
        public string ExplorPecuariaRecorMatExternos {get;set;}
        public string ExplorPecuariaGanadariaPossuiInstal {get;set;}
        public string ExplorPecuariaGanadariaRecorreServExt {get;set;}
        //Corredores de Transumância
        public string GadoTransumancia {get;set;}
        public string DefRotaTransumancia {get;set;}
        public int NumManadasTransumancia {get;set;}
        public int NumMAnimaisPassamMuni {get;set;}
        //Sub - produtos à Criação Pecuária
        public double QtdLeiteBovino {get;set;}
        public double QtdLeiteOvino {get;set;}
        public int QtdOvos {get;set;}
        public string QtdOutrosSubProdutos {get;set;}
        //Indicadores do Negócio
        public int NumClientesAnoTrans {get;set;}
        public int NumMMensCliente {get;set;}
        public double DespesasMMensais {get;set;}
        public double ReceitasMMensais {get;set;}
        public double LucroMMensal {get;set;}
        public string ContabilidadeOrganizada {get;set;}
        public double VolNegocios {get;set;}
        public string SituacaoTribRegularizada {get;set;}
        public double ValLiquImpostos {get;set;}
        //Força de Trabalho 
        public int NumDirProd {get;set;}
        public int NumEspecialistas {get;set;}
        public int NumTecIntermedios {get;set;}
        public int NumAdmEquiparados {get;set;}
        public int NumTrabServicosProteccao {get;set;}
        public int NumTrabQualificadosCulturas {get;set;}
        public int NumTrabQualificadosConstrucao {get;set;}
        public int NumOperVeiculos {get;set;}
        public int NumTrabNaoQualificados {get;set;}
        public int NumTotalTrabalhadores {
            get { return NumDirProd + NumEspecialistas + NumTecIntermedios + NumAdmEquiparados + NumTrabServicosProteccao + NumTrabQualificadosCulturas + NumTrabQualificadosConstrucao + NumOperVeiculos + NumTrabNaoQualificados; }
        }
        public string PrincipConstraIdentificados {get;set;}
        public string Observacoes {get;set;}

    }
}
