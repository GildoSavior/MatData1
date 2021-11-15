using MatData.Models.Records;
using MatData.ViewModels;

namespace MatData.Serialization
{
    public static class Q34Mapper
    {
        public static Q34Model Serialize(Q34Record model)
        {
            return new Q34Model
            {
                NumeroJovensAdultosComAtrasoEscolarEnsinoPrimario = int.Parse(model.q3406),
                NumeroAlunosFrequenciaOfertasEnsinoPrimario = int.Parse(model.q3407),
                NumeroAlfabetizadoresDinamizacaoOfertasEnsinoPrimario = int.Parse(model.q3408),
                NumeroJovensAdultosComAtrasoEscolarICicloEnsinoSecundario = int.Parse(model.q3409),
                NumeroAlunosFrequenciaOfertasICicloEnsinoSecundario = int.Parse(model.q3410),
                NumeroAlfabetizadoresDinamizacaoOfertasICicloEnsinoSecundario = int.Parse(model.q3411),
                NumeroJovensAdultosComAtrasoEscolarIICicloEnsinoSecundario = int.Parse(model.q3412),
                NumeroAlunosFrequenciaOfertasIICicloEnsinoSecundario = int.Parse(model.q3413),
                NumeroAlfabetizadoresDinamizacaoOfertasIICicloEnsinoSecundario = int.Parse(model.q3414),
                NumeroJovensAdultosEncaminhadosCursosFormacaoProfissional = int.Parse(model.q3415),
                Observacoes = model.q3416,
            };
        }
    }
}
