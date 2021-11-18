using MatData.Models.Records;
using MatData.ViewModels;

namespace MatData.Serialization
{
    public static class Q77Mapper
    {
        public static Q77Model Serialize(Q77Record model)
        {
            return new Q77Model
            {
                NomeEstrutProtecaoCivil = model.q7706,
                IdServico = model.q7707,
                Contacto = model.q7708,
                Email = model.q7709,
                Website = model.q7710,
                PrincipaisActividades = model.q7711,
                InstalacoesProprias = model.q7712,
                Localizacao = model.q7712 == "Sim" ? model.q7713 : null,
                FotoInfraestrutura1 = model.q7712 == "Sim" ? model.q7714 : null,
                FotoInfraestrutura2 = model.q7712 == "Sim" ? model.q7715 : null,
                Observacoes = model.q7716,
            };
        }
    }
}
