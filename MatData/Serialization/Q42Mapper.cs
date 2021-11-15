using MatData.Models.Records;
using MatData.ViewModels;

namespace MatData.Serialization
{
    public static class Q42Mapper
    {
        public static Q42Model Serialize(Q42Record model)
        {
            return new Q42Model
            {
                NumeroCriancasDe0a4anosAtendidasPorMalnutricaoModeradanoNoAnoTransacto = int.Parse(model.q4204),
                NumeroCriancasDe0a4anosAtendidasPorMalnutricaoAgudanoNoAnoTransacto = int.Parse(model.q4205),
                NumeroCriancasDe5a9anosAtendidasPorMalnutricaoModeradanoNoAnoTransacto = int.Parse(model.q4206),
                NumeroCriancasDe5a9anosAtendidasPorMalnutricaoAgudanoNoAnoTransacto = int.Parse(model.q4207),
                NumeroCriancasDe10a14anosAtendidasPorMalnutricaoModeradanoNoAnoTransacto = int.Parse(model.q4208),
                NumeroCriancasDe10a14anosAtendidasPorMalnutricaoAgudanoNoAnoTransacto = int.Parse(model.q4209),
                NumeroCriancasDe0a4anosAtendidasPorMalnutricaomoderadaNoAnoCorrente = int.Parse(model.q4211),
                NumeroCriancasDe0a4anosAtendidasPorMalnutricaoagudaNoAnoCorrente = int.Parse(model.q4212),
                NumeroCriancasDe5a9anosAtendidasPorMalnutricaomoderadaNoAnoCorrente = int.Parse(model.q4213),
                NumeroCriancasDe5a9anosAtendidasPorMalnutricaoagudaNoAnoCorrente = int.Parse(model.q4214),
                NumeroCriancasDe10a14anosAtendidasPorMalnutricaomoderadaNoAnoCorrente = int.Parse(model.q4215),
                NumeroCriancasDe10a14anosAtendidasPorMalnutricaoAgudaNoAnoCorrente = int.Parse(model.q4216),
                Observacoes = model.q4218,
            };
        }
    }
}
