namespace MatData.ViewModels
{
    public class Q100Model
    {
        //Actos Administrativos e Atestados {get;set;}
        public int NumActAdmPrestadosAnoTransacto {get;set;}
        public int NumActAdmPrestadosAnoCorrente {get;set;}
        public double ValorArrecadadoEmolumentosAnoTransacto {get;set;}
        public double ValorArrecadadoEmolumentosAnoCorrente {get;set;}
        //Mercados {get;set;}
        public int NumMercados {get;set;}
        public int NumVendedoresMercados {get;set;}
        public double ValorTaxaVendaPagaVendedorMes {get;set;}
        public double ValorArrecadadoAdmCobranTaxasAnoTransacto {get;set;}
        public double ValorArrecadadoAdmCobrancaTaxasAnoCorrente {get;set;}
        //Licenciamentos, Loteamento e Apreciação de Projectos {get;set;}
        public int NumActLicencProjectPrestAnoTrans {get;set;}
        public int NumActLicencProjectPrestAnoCorr {get;set;}
        public double ValArrecadadoCobLicencAnoTransacto {get;set;}
        public double ValArrecadadoCobLicencAnoCorrente {get;set;}
        //Vistorias {get;set;}
        public int NumVistoriasRealizadasAnoTrans {get;set;}
        public int NumVistoriasRealizadasAnoCorr {get;set;}
        public double ValorArrecadadoCobrancaVistoriasAnoTransacto {get;set;}
        public double ValorArrecadadoCobrancaVistoriasAnoCorrente {get;set;}
        //Multas por transgressões {get;set;}
        public int NumMultasCobradasAnoTransacto {get;set;}
        public int NumMultasCobradasAnoCorrente {get;set;}
        public double ValArrecadadoAdmCobrancaMultasAnoTransacto {get;set;}
        public double ValArrecadadoAdmCobrancaMultasAnocorrente {get;set;}
        //Licenciamento de Actividades Recreativas ou Festivas {get;set;}
        public int NumLicencasActivRecreativasEmitidasAnoTransacto {get;set;}
        public int NumLicencasActivRecreativasEmitidasAnoCorrente {get;set;}
        public double ValArrecadadoLicencasActivRecreativasEmitidasAnoTransacto {get;set;}
        public double ValArrecadadoLicencasActivRecreativasEmitidasAnoCorrente {get;set;}
        //Outras fontes de receita do Município {get;set;}
        public string IdFontesReceitaNaoEspecificadasAnteriormente {get;set;}
        public int NumActosFontesReceitaNaoEspeciAnterAnoTransacto {get;set;}
        public int NumActosFontesReceitaNaoEspeciAnterAnoCorrente {get;set;}
        public double ValArrecadAdmFontesReceitaNaoEspecifAnterAnoTransacto {get;set;}
        public double ValArrecadAdmFontesReceitaNaoEspecifAnterAnoCorrente {get;set;}
        //Despesas Ordinárias da Gestão Municipal no ano transacto {get;set;}
        public double DespesasPagamentoSalarios {get;set;}
        public double DespesasEstrutura {get;set;}
        public double DespesasServicosSectoriais {get;set;}
        public double DespesasRepresentacaoProtocolo {get;set;}
        public string OutrasDespesasRegulares {get;set;}
        public double ValorDasOutrasDespesasRegularesIdentificadas {get;set;}
        //Despesas extraordinárias da Gestão Municipal no ano transacto {get;set;}
        public double DespesaEncargosOcorrenciasNaoProgramadas {get;set;}
        public double DespesasResultantesSituacoesEmergenciaPublica {get;set;}
        public string IdOutrasDespesasExtraordinarias {get;set;}
        public double ValorOutrasDespesasExtraordinarias {get;set;}
        //Dotações Orçamentais Extraordinárias recebidas pela Administração Municipal no ano transacto {get;set;}
        public string IdRubricasOrigemDotacoes {get;set;}
        public double MontanteDotacoesOrcamentais {get;set;}
        public string Observacoes { get; set; }

    }
}
