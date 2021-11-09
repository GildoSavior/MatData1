using MatData.Models.Records;
using MatData.ViewModels;

namespace MatData.Serialization
{
    public static class Q23Mapper
    {
        public static Q23Model Serialize(Q23Record model)
        {
            return new Q23Model
            {
                ExistenciaRecursosPiscatorioMarinho = model.q2306,
                NomeComumEspeciesPeixeMarIdentificadas = model.q2307,
                ExistenciaRecursosPiscatorioContinentais = model.q2308,
                NomeComumEspeciesPeixeRioELagoaIdentificadas = model.q2309,
                ExistenciaRecursosPiscatorioFluxoCiclico = model.q2310,
                NomeComumEspeciesPeixeLocaisFluxoCiclicoIdentificadas = model.q2311,
                Observacoes = model.q2312
            };
        }
    }
}
