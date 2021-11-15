using MatData.Models.Records;
using MatData.ViewModels;

namespace MatData.Serialization
{
    public static class Q46Mapper
    {
        public static Q46Model Serialize(Q46Record model)
        {
            return new Q46Model
            {
                NumeroHomensSemRegistoDeNascimento = int.Parse(model.q4604),
                NumeroMulheresSemRegistoDeNascimento = int.Parse(model.q4605),
                NumeroHomensComMaisDe6AnosSemBilheteDeIdentidade = int.Parse(model.q4607),
                NumeroMulheresComMaisDe6AnosSemBilheteDeIdentidade = int.Parse(model.q4608),
                NumeroHomensNacionaisComMenosDe18AnosReclusos = int.Parse(model.q4610),
                NumeroHomensNacionaisComMaisDe18AnosReclusos = int.Parse(model.q4611),
                NumeroMulheresNacionaisComMenosDe18AnosReclusos = int.Parse(model.q4612),
                NumeroMulheresNacionaisComMaisDe18AnosReclusos = int.Parse(model.q4613),
                NumeroDeHomensEstrangeirosReclusos = int.Parse(model.q4614),
                NumeroDeMulheresEstrangeirasReclusas = int.Parse(model.q4615),
                Observacoes = model.q4617
            };
        }
    }
}
