namespace MatData.ViewModels
{
    public class Q46Model
    {
        public int NumeroHomensSemRegistoDeNascimento { get; set; }
        public int NumeroMulheresSemRegistoDeNascimento { get; set; }
        public int MunicipesSemRegistoDeNascimento
        {
            get
            {
                return NumeroHomensSemRegistoDeNascimento + NumeroMulheresSemRegistoDeNascimento;
            }
        }
        public int NumeroHomensComMaisDe6AnosSemBilheteDeIdentidade { get; set; }
        public int NumeroMulheresComMaisDe6AnosSemBilheteDeIdentidade { get; set; }
        public int MunicipesComMaisDe6AnosSemBilheteDeIdentidade
        {
            get
            {
                return NumeroHomensComMaisDe6AnosSemBilheteDeIdentidade + NumeroMulheresComMaisDe6AnosSemBilheteDeIdentidade;
            }
        }
        public int NumeroHomensNacionaisComMenosDe18AnosReclusos { get; set; }
        public int NumeroHomensNacionaisComMaisDe18AnosReclusos { get; set; }
        public int NumeroMulheresNacionaisComMenosDe18AnosReclusos { get; set; }
        public int NumeroMulheresNacionaisComMaisDe18AnosReclusos { get; set; }
        public int NumeroDeHomensEstrangeirosReclusos { get; set; }
        public int NumeroDeMulheresEstrangeirasReclusas { get; set; }
        public int NumeroDeReclusos
        {
            get
            {
                return NumeroHomensComMaisDe6AnosSemBilheteDeIdentidade + NumeroMulheresComMaisDe6AnosSemBilheteDeIdentidade;
            }
        }
        public string Observacoes { get; set; }
    }
}
