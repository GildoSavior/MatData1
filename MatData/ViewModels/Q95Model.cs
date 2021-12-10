namespace MatData.ViewModels
{
    public class Q95Model
    {
        //Dados gerais do Orçamento {get;set;}
        public string PeriodExecOrcamental {get;set;}
        public double OrcamentoProposto {get;set;}
        public double ValorOrçamentado {get;set;}
        public double ValorCabimentado {get;set;}
        public double ValorExecutado {get;set;}
        public double PercentExecucaoOrcamental {get;set;}
        //Dívida Registada na Unidade de Gestão da Dívida Pública do MINFIN(DR) {get;set;}
        public double ValorDividaDR {get;set;}
        public string DescriDespesaDR {get;set;}
        public string DataRegistoDR {get;set;}
        public string ObservacoesPontoSituacaoDR {get;set;}
        public double ValorTotalDividaRegistadaDR {get;set;}
        //Dívida não Registada na Unidade de Gestão da Dívida Pública do MINFIN(DNR) {get;set;}
        public double ValorDividaDNR {get;set;}
        public string DescriDespesaDNR {get;set;}
        public string DataRegistoDNR {get;set;}
        public string ObservacoesPontoSituacaoDNR {get;set;}
        public double ValorTotalDividaRegistadaDNR {get;set;}
        //Ponto de situação da Execução Financeira {get;set;}
        public string PontoSituacao {get;set;}
        public string OutrasInformRelevantes {get;set;}
        public string Conclusoes {get;set;}
        public string Recomendacoes {get;set;}
        public string Observacoes { get; set; }

    }
}
