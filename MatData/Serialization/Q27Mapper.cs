using MatData.Models.Records;
using MatData.ViewModels;

namespace MatData.Serialization
{
    public static class Q27Mapper
    {
        public static Q27Model Serialize(Q27Record model)
        {
            return new Q27Model
            {
                LocalizacaoAareaPotencialmenteMinada = model.q2706,
                Fotografia1 = model.q2707,
                Fotografia2 = model.q2708,
                ExtensaoAareaPotencialmenteMinada = model.q2709,
                Observacoes = model.q2710
            };
        }
    }
}
