using MatData.Models.Records;
using MatData.ViewModels;

namespace MatData.Serialization
{
    public class Q16Mapper
    {
        public static Q16Model Serialize(Q16Record model)
        {
            return new Q16Model
            {
                NomeAdministradorMunicipal = model.q1604,
                Genero = model.q1605,
                AnoNascimento = model.q1606,
                AnoMorte = model.q1607,
                Fotografia = model.q1608,
                ResumoCv = model.q1609,
                DataInicioMandato = model.q1610,
                DataFimMandato = model.q1611,
                Observacoes = model.q1612,
            };
        }
    }
}
