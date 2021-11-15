namespace MatData.ViewModels
{
    public class Q42Model
    {
        public int NumeroCriancasDe0a4anosAtendidasPorMalnutricaoModeradanoNoAnoTransacto { get; set; }
        public int NumeroCriancasDe0a4anosAtendidasPorMalnutricaoAgudanoNoAnoTransacto { get; set; }
        public int NumeroCriancasDe5a9anosAtendidasPorMalnutricaoModeradanoNoAnoTransacto { get; set; }
        public int NumeroCriancasDe5a9anosAtendidasPorMalnutricaoAgudanoNoAnoTransacto { get; set; }
        public int NumeroCriancasDe10a14anosAtendidasPorMalnutricaoModeradanoNoAnoTransacto { get; set; }
        public int NumeroCriancasDe10a14anosAtendidasPorMalnutricaoAgudanoNoAnoTransacto { get; set; }
        public int NumeroTotalCriancasAtendidasPorMalnutricaoNoAnoTransacto
        {
            get
            {
                return NumeroCriancasDe0a4anosAtendidasPorMalnutricaoModeradanoNoAnoTransacto +
                        NumeroCriancasDe0a4anosAtendidasPorMalnutricaoAgudanoNoAnoTransacto +
                        NumeroCriancasDe5a9anosAtendidasPorMalnutricaoModeradanoNoAnoTransacto +
                        NumeroCriancasDe5a9anosAtendidasPorMalnutricaoAgudanoNoAnoTransacto +
                        NumeroCriancasDe10a14anosAtendidasPorMalnutricaoModeradanoNoAnoTransacto +
                        NumeroCriancasDe10a14anosAtendidasPorMalnutricaoAgudanoNoAnoTransacto;
            }
        }
        public int NumeroCriancasDe0a4anosAtendidasPorMalnutricaomoderadaNoAnoCorrente { get; set; }
        public int NumeroCriancasDe0a4anosAtendidasPorMalnutricaoagudaNoAnoCorrente { get; set; }
        public int NumeroCriancasDe5a9anosAtendidasPorMalnutricaomoderadaNoAnoCorrente { get; set; }
        public int NumeroCriancasDe5a9anosAtendidasPorMalnutricaoagudaNoAnoCorrente { get; set; }
        public int NumeroCriancasDe10a14anosAtendidasPorMalnutricaomoderadaNoAnoCorrente { get; set; }
        public int NumeroCriancasDe10a14anosAtendidasPorMalnutricaoAgudaNoAnoCorrente { get; set; }
        public int NumeroTotalCriancasAtendidasPorMalnutricaoNoAnoCorrente 
        {
            get
            {
                return NumeroCriancasDe0a4anosAtendidasPorMalnutricaomoderadaNoAnoCorrente +
                        NumeroCriancasDe0a4anosAtendidasPorMalnutricaoagudaNoAnoCorrente +
                        NumeroCriancasDe5a9anosAtendidasPorMalnutricaomoderadaNoAnoCorrente +
                        NumeroCriancasDe5a9anosAtendidasPorMalnutricaoagudaNoAnoCorrente +
                        NumeroCriancasDe10a14anosAtendidasPorMalnutricaomoderadaNoAnoCorrente +
                        NumeroCriancasDe10a14anosAtendidasPorMalnutricaoAgudaNoAnoCorrente;
            }
        }
        public string Observacoes { get; set; }

    }
}
