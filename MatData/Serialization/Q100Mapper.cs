using MatData.Models.Records;
using MatData.ViewModels;
using System;

namespace MatData.Serialization
{
    public static class Q100Mapper
    {
        public static Q100Model Serialize(Q100Record model)
        {
            return new Q100Model
            {
                //Actos Administrativos e Atestados = model.q1000,
                NumActAdmPrestadosAnoTransacto = Int32.Parse(model.q10004),
                NumActAdmPrestadosAnoCorrente =  Int32.Parse(model.q10005),
                ValorArrecadadoEmolumentosAnoTransacto = double.Parse(model.q10006),
                ValorArrecadadoEmolumentosAnoCorrente = double.Parse(model.q10007),
                //Mercados
                NumMercados = Int32.Parse(model.q10008),
                NumVendedoresMercados = Int32.Parse(model.q10009),
                ValorTaxaVendaPagaVendedorMes = double.Parse(model.q10010),
                ValorArrecadadoAdmCobranTaxasAnoTransacto = double.Parse(model.q10011),
                ValorArrecadadoAdmCobrancaTaxasAnoCorrente = double.Parse(model.q10012),
                //Licenciamentos, Loteamento e Apreciação de Projectos =double.Parse( model.q1000),
                NumActLicencProjectPrestAnoTrans = Int32.Parse(model.q10013),
                NumActLicencProjectPrestAnoCorr = Int32.Parse(model.q10014),
                ValArrecadadoCobLicencAnoTransacto = double.Parse(model.q10015),
                ValArrecadadoCobLicencAnoCorrente = double.Parse(model.q10016),
                //Vistorias =double.Parse( model.q1000),
                NumVistoriasRealizadasAnoTrans = Int32.Parse(model.q10017),
                NumVistoriasRealizadasAnoCorr = Int32.Parse(model.q10018),
                ValorArrecadadoCobrancaVistoriasAnoTransacto = double.Parse(model.q10019),
                ValorArrecadadoCobrancaVistoriasAnoCorrente = double.Parse(model.q10020),
                //Multas por transgressões =double.Parse( model.q1000),
                NumMultasCobradasAnoTransacto = Int32.Parse(model.q10021),
                NumMultasCobradasAnoCorrente = Int32.Parse(model.q10022),
                ValArrecadadoAdmCobrancaMultasAnoTransacto = double.Parse(model.q10023),
                ValArrecadadoAdmCobrancaMultasAnocorrente = double.Parse(model.q10024),
                //Licenciamento de Actividades Recreativas ou Festivas =double.Parse( model.q1000),
                NumLicencasActivRecreativasEmitidasAnoTransacto = Int32.Parse(model.q10025),
                NumLicencasActivRecreativasEmitidasAnoCorrente = Int32.Parse(model.q10026),
                ValArrecadadoLicencasActivRecreativasEmitidasAnoTransacto = double.Parse(model.q10027),
                ValArrecadadoLicencasActivRecreativasEmitidasAnoCorrente = double.Parse(model.q10028),
                //Outras fontes de receita do Município =double.Parse( model.q1000),
                IdFontesReceitaNaoEspecificadasAnteriormente = model.q10029,
                NumActosFontesReceitaNaoEspeciAnterAnoTransacto = Int32.Parse(model.q10030),
                NumActosFontesReceitaNaoEspeciAnterAnoCorrente = Int32.Parse(model.q10031),
                ValArrecadAdmFontesReceitaNaoEspecifAnterAnoTransacto = double.Parse(model.q10032),
                ValArrecadAdmFontesReceitaNaoEspecifAnterAnoCorrente = double.Parse(model.q10033),
                //Despesas Ordinárias da Gestão Municipal no ano transacto =double.Parse( model.q1000),
                DespesasPagamentoSalarios = double.Parse(model.q10034),
                DespesasEstrutura = double.Parse(model.q10035),
                DespesasServicosSectoriais = double.Parse(model.q10036),
                DespesasRepresentacaoProtocolo = double.Parse(model.q10037),
                OutrasDespesasRegulares = model.q10038,
                ValorDasOutrasDespesasRegularesIdentificadas = double.Parse(model.q10039),
                //Despesas extraordinárias da Gestão Municipal no ano transacto =double.Parse( model.q1000),
                DespesaEncargosOcorrenciasNaoProgramadas = double.Parse(model.q10040),
                DespesasResultantesSituacoesEmergenciaPublica = double.Parse(model.q10041),
                IdOutrasDespesasExtraordinarias = model.q10042,
                ValorOutrasDespesasExtraordinarias = double.Parse(model.q10043),
                //Dotações Orçamentais Extraordinárias recebidas pela Administração Municipal no ano transacto =double.Parse( model.q1000),
                IdRubricasOrigemDotacoes = model.q10044,
                MontanteDotacoesOrcamentais = double.Parse(model.q10045),
                Observacoes = model.q10046,
            };
        }
    }
}
