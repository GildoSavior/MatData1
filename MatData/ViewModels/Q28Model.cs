namespace MatData.ViewModels
{
    public class Q28Model
    {
        public int NumeroMesesComReservaAlimentoNamediaAgregados { get; set; }
        public double QuantidadeMediaAlimentosDisponiveis12Meses { get; set; }
        public int NumeroMesesAnoDisponividadeAlimento { get; set; }
        public double QuantidadeAlimentoDur12Meses { get; set; }
        public double GastoMedioEstimadoCompraAlimentosPeriodo12Meses { get; set; }
        public int NumeroMesesHaDisponibilidadeAguaConsumo { get; set; }
        public double QuantidadeMediaAguaParaConsumoDur12Meses { get; set; }
        public double GastoMedioParaCompraAguaPeriodo12Meses { get; set; }
        public string Observacoes { get; set; }
    }
}
