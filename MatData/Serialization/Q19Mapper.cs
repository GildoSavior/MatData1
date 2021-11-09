using MatData.Models.Records;

namespace MatData.Serialization
{
    public static class Q19Mapper
    {
        public static Q19Model Serialize (Q19Record model)
        {
            return new Q19Model
            {
                TipoDominanteSolo = model.q1906,
                ConsistenciaDominanteSolo = model.q1907,
                SuperficieSolo = model.q1908,
                Observacoes = model.q1909,
            };
        }
    }
}
