using MatData.Models.Records;
using MatData.ViewModels;

namespace MatData.Serialization
{
    public class Q32Mapper
    {
        public static Q32Model Serialize(Q32Record model)
        {
            return new Q32Model
            {
                TotalEduPreEscolar = int.Parse(model.q3206),
                TotalEnsinoPrimario= int.Parse(model.q3207),
                TotalICicloEnsSecundario = int.Parse(model.q3208),
                TotalIICicloEnsSecundario = int.Parse(model.q3209),
                TotalEnsTecnicoProfessionaEArtistico = int.Parse(model.q3210),
                TotalEscolaFormProfessores = int.Parse(model.q3211),
                TotalEnsinoSuperior = int.Parse(model.q3212),
                TotalCriancasForaSubsistemaEnsinoMunicipio = int.Parse(model.q3213),
                Observacoes = model.q3214
            };
        }
    }
}
