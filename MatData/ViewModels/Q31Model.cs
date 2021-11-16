namespace MatData.ViewModels
{
    public class Q31Model
    {
        public string DesignacaodaEstruturaEscolar { get; set; }
        public int EducacaoPreEscolarNumeroDeProfessoresPorSubsistemaDeEnsino { get; set; }
        public int EnsinoPrimarioNumeroDeProfessoresPorSubsistemaDeEnsino { get; set; }
        public int ICiclodoEnsinoSecundarioNumeroDeProfessoresPorSubsistemaDeEnsino { get; set; }
        public int IICiclodoEnsinoSecundarioNumeroDeProfessoresPorSubsistemaDeEnsino { get; set; }
        public int EnsinoTecnicoProfissionaleArtisticoNumeroDeProfessoresPorSubsistemaDeEnsino { get; set; }
        public int EscoladeFormacaodeProfessoresNumeroDeProfessoresPorSubsistemaDeEnsino { get; set; }
        public int EnsinoSuperiorNumeroDeProfessoresPorSubsistemaDeEnsino { get; set; }
        public int NumerototaldeProfessoresdestaEstruturaEscolarNumeroDeProfessoresPorSubsistemaDeEnsino
        {
            get
            {
                return EducacaoPreEscolarNumeroDeProfessoresPorSubsistemaDeEnsino +
                    EnsinoPrimarioNumeroDeProfessoresPorSubsistemaDeEnsino +
                    ICiclodoEnsinoSecundarioNumeroDeProfessoresPorSubsistemaDeEnsino +
                    IICiclodoEnsinoSecundarioNumeroDeProfessoresPorSubsistemaDeEnsino +
                    EnsinoTecnicoProfissionaleArtisticoNumeroDeProfessoresPorSubsistemaDeEnsino +
                    EscoladeFormacaodeProfessoresNumeroDeProfessoresPorSubsistemaDeEnsino +
                    EnsinoSuperiorNumeroDeProfessoresPorSubsistemaDeEnsino;
            }
        }
        public int EducacaoPreEscolarNumeroDeTurmasPorSubsistemaDeEnsino { get; set; }
        public int EnsinoPrimarioNumeroDeTurmasPorSubsistemaDeEnsino { get; set; }
        public int ICiclodoEnsinoSecundarioNumeroDeTurmasPorSubsistemaDeEnsino { get; set; }
        public int IICiclodoEnsinoSecundarioNumeroDeTurmasPorSubsistemaDeEnsino { get; set; }
        public int EnsinoTecnicoProfissionaleArtisticoNumeroDeTurmasPorSubsistemaDeEnsino { get; set; }
        public int EscoladeFormacaodeProfessoresNumeroDeTurmasPorSubsistemaDeEnsino { get; set; }
        public int EnsinoSuperiorNumeroDeTurmasPorSubsistemaDeEnsino { get; set; }
        public int NumerototaldeTurmasdestaEstruturaEscolar
        {
            get
            {
                return EducacaoPreEscolarNumeroDeTurmasPorSubsistemaDeEnsino +
                    EnsinoPrimarioNumeroDeTurmasPorSubsistemaDeEnsino +
                    ICiclodoEnsinoSecundarioNumeroDeTurmasPorSubsistemaDeEnsino +
                    IICiclodoEnsinoSecundarioNumeroDeTurmasPorSubsistemaDeEnsino +
                    EnsinoTecnicoProfissionaleArtisticoNumeroDeTurmasPorSubsistemaDeEnsino +
                    EscoladeFormacaodeProfessoresNumeroDeTurmasPorSubsistemaDeEnsino +
                    EnsinoSuperiorNumeroDeTurmasPorSubsistemaDeEnsino;
            }
        }
        public double EducacaoPreEscolarGrauDeAproveitamentoNoAnoTransacto { get; set; }
        public double EnsinoPrimarioGrauDeAproveitamentoNoAnoTransacto { get; set; }
        public double ICiclodoEnsinoSecundarioGrauDeAproveitamentoNoAnoTransacto { get; set; }
        public double IICiclodoEnsinoSecundarioGrauDeAproveitamentoNoAnoTransacto { get; set; }
        public double EnsinoTecnicoProfissionaleArtisticoGrauDeAproveitamentoNoAnoTransacto { get; set; }
        public double EscoladeFormacaodeProfessoresGrauDeAproveitamentoNoAnoTransacto { get; set; }
        public double EnsinoSuperiorGrauDeAproveitamentoNoAnoTransacto { get; set; }
        public string ServicodeMerendaEscolarnestaEstruturaEscolar { get; set; }
        public int NumerodealunosbeneficiadoscomaMerendaEscolar { get; set; }
        public string ProveniencialocaldosprodutosqueconstituemaMerendaEscolar { get; set; }
        public string ProdutosquecompoemaMerendaescolar { get; set; }
        public string PercepcaodofuncionamentodaComissaodePaiseEncarregadosdeEducacao { get; set; }
        public string Observacoes { get; set; }

    }
}
