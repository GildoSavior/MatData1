using MatData.Models.Records;
using MatData.ViewModels;

namespace MatData.Serialization
{
    public static class Q31Mapper
    {
        public static Q31Model Serialize(Q31Record model)
        {
            return new Q31Model
            {
                DesignacaodaEstruturaEscolar = model.q3106,
                EducacaoPreEscolarNumeroDeProfessoresPorSubsistemaDeEnsino = int.Parse(model.q3107),
                EnsinoPrimarioNumeroDeProfessoresPorSubsistemaDeEnsino = int.Parse(model.q3108),
                ICiclodoEnsinoSecundarioNumeroDeProfessoresPorSubsistemaDeEnsino = int.Parse(model.q3109),
                IICiclodoEnsinoSecundarioNumeroDeProfessoresPorSubsistemaDeEnsino = int.Parse(model.q3110),
                EnsinoTecnicoProfissionaleArtisticoNumeroDeProfessoresPorSubsistemaDeEnsino = int.Parse(model.q3111),
                EscoladeFormacaodeProfessoresNumeroDeProfessoresPorSubsistemaDeEnsino = int.Parse(model.q3112),
                EnsinoSuperiorNumeroDeProfessoresPorSubsistemaDeEnsino = int.Parse(model.q3113),

                EducacaoPreEscolarNumeroDeTurmasPorSubsistemaDeEnsino = int.Parse(model.q3115),
                EnsinoPrimarioNumeroDeTurmasPorSubsistemaDeEnsino = int.Parse(model.q3116),
                ICiclodoEnsinoSecundarioNumeroDeTurmasPorSubsistemaDeEnsino = int.Parse(model.q3117),
                IICiclodoEnsinoSecundarioNumeroDeTurmasPorSubsistemaDeEnsino = int.Parse(model.q3118),
                EnsinoTecnicoProfissionaleArtisticoNumeroDeTurmasPorSubsistemaDeEnsino = int.Parse(model.q3119),
                EscoladeFormacaodeProfessoresNumeroDeTurmasPorSubsistemaDeEnsino = int.Parse(model.q3120),
                EnsinoSuperiorNumeroDeTurmasPorSubsistemaDeEnsino = int.Parse(model.q3121),

                EducacaoPreEscolarGrauDeAproveitamentoNoAnoTransacto = int.Parse(model.q3123),
                EnsinoPrimarioGrauDeAproveitamentoNoAnoTransacto = int.Parse(model.q3124),
                ICiclodoEnsinoSecundarioGrauDeAproveitamentoNoAnoTransacto = int.Parse(model.q3125),
                IICiclodoEnsinoSecundarioGrauDeAproveitamentoNoAnoTransacto = int.Parse(model.q3126),
                EnsinoTecnicoProfissionaleArtisticoGrauDeAproveitamentoNoAnoTransacto = int.Parse(model.q3127),
                EscoladeFormacaodeProfessoresGrauDeAproveitamentoNoAnoTransacto = int.Parse(model.q3128),
                EnsinoSuperiorGrauDeAproveitamentoNoAnoTransacto = int.Parse(model.q3129),

                ServicodeMerendaEscolarnestaEstruturaEscolar = model.q3132,
                NumerodealunosbeneficiadoscomaMerendaEscolar = int.Parse(model.q3133),
                ProveniencialocaldosprodutosqueconstituemaMerendaEscolar = model.q3134,
                ProdutosquecompoemaMerendaescolar = model.q3135,
                PercepcaodofuncionamentodaComissaodePaiseEncarregadosdeEducacao = model.q3136,
                Observacoes = model.q3137
            };
        }
    }
}
