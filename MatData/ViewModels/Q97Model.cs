namespace MatData.ViewModels
{
    public class Q97Model
    {
        //Dados gerais sobre o PIP
        public string PeriodoReferencia {get;set;}
        public string NomeProjecto {get;set;}
        public string NumProjecto {get;set;}
        public string FotoFrontal {get;set;}
        public string FotoGeral {get;set;}
        public string Localizacao {get;set;}
        public double ValorAprovado {get;set;}
        public double ValorExecutadoProjecto {get;set;}
        public double DesvioFinanceiro {get;set;}
        public double PercentagemExecucaoOrçamental {get;set;}
        public double TotalValorAprovado {get;set;}
        public double TotalValorExecutado {get;set;}
        //Ponto de situação do Programa {get;set;}
        public double PercentExecucaoFisica {get;set;}
        public double PercentExecucaoFinanceira {get;set;}
        public string PontoSituacao {get;set;}
        public string OutrasInformacaesRel {get;set;}
        public string Conclusoes {get;set;}
        public string Recomendacoes {get;set;}
        public string Observacoes { get; set; }
    }
}
