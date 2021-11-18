using MatData.Models.Records;
using MatData.ViewModels;

namespace MatData.Serialization
{
    public static class Q68Mapper
    {
        public static Q68Model Serialize(Q68Record model)
        {
            return new Q68Model
            {
             IdTipoPatrimonio = model.q6806,
             IdPatrimonio = model.q6807,
             EstadoConservacao = model.q6808,
             EntidadeRespManutencao = model.q6809,
             LocalPatrimonio = model.q6810,
             Fotografia1 = model.q6811,
             Fotografia2 = model.q6812,
             Observacoes = model.q6813,
            };
        }
    }
}
