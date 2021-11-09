using MatData.Models.Records;
using MatData.ViewModels;

namespace MatData.Serialization
{
    public static class Q21Mapper
    {
        public static Q21Model Serialize(Q21Record model)
        {
            return new Q21Model
            {
                NomeEspecie = model.q2106,
                ClassificacaoEmClassBiologica = model.q2107,
                PercepcaoNumeroEfectivosNoTerritorioLocal = model.q2108,
                Observacoes = model.q2109,
            };
        }
    }
}
