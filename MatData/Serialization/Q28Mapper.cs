using MatData.Models.Records;
using MatData.ViewModels;

namespace MatData.Serialization
{
    public static class Q28Mapper
    {
        public static Q28Model Serialize(Q28Record model)
        {
            return new Q28Model
            {
                NumeroMesesComReservaAlimentoNamediaAgregados = int.Parse(model.q2806),
                QuantidadeMediaAlimentosDisponiveis12Meses = double.Parse(model.q2807),
                NumeroMesesAnoDisponividadeAlimento = int.Parse(model.q2808),
                QuantidadeAlimentoDur12Meses = double.Parse(model.q2809),
                GastoMedioEstimadoCompraAlimentosPeriodo12Meses = double.Parse(model.q2810),
                NumeroMesesHaDisponibilidadeAguaConsumo = int.Parse(model.q2811),
                QuantidadeMediaAguaParaConsumoDur12Meses = double.Parse(model.q2812),
                GastoMedioParaCompraAguaPeriodo12Meses = double.Parse(model.q2813),
                Observacoes = model.q2814,
            };
        }
    }
}
