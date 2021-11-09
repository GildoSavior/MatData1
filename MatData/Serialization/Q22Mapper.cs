using MatData.Models.Records;
using MatData.ViewModels;

namespace MatData.Serialization
{
    public static class Q22Mapper
    {
        public static Q22Model Serialize(Q22Record model)
        {
            return new Q22Model
            {
                TipoPredominanteDeVegetacao = model.q2206,
                PlantasUtilizadasParaFinsMedicinaisTradicionais = model.q2207,
                Observacoes = model.q2208
            };
        }
    }
}
