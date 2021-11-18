using MatData.Models.Records;
using MatData.ViewModels;

namespace MatData.Serialization
{
    public static class Q72Mapper
    {
        public static Q72Model Serialize(Q72Record model)
        {
            return new Q72Model
            {
                ServDispTransRodoviarioPass = model.q7206,
                IdServOpTransRodoviarioPass = model.q7207,
                ServDispTransRodoviarioCarga = model.q7208,
                IdServOpTransRodoviarioCarga = model.q7209,
                ValGasto1PassDeslocAldeiaMunicipal = double.Parse(model.q7210),
                ValorGasto1PassDeslocAldeiaProvincial = double.Parse(model.q7211),
                ValorGasto1PassDeslocAldeiaCapital = double.Parse(model.q7212),
                Observacoes = model.q7213,
            };
        }
    }
}
