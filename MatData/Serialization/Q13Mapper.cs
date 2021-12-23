using MatData.Models.Records;
using MatData.ViewModels;

namespace MatData.Serialization
{
    public static class Q13Mapper
    {
        public static Q13Model Serialize(Q13Record model)
        {
            return new Q13Model
            {
                DataAcontecimentoQueMarcouAHistoriaLocal = model.q1306,
                DescricaoAcontecimento = model.q1307,
                Observacoes = model.q1308
            };
        }
    }
}
