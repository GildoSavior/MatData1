using MatData.Models.Records;
using MatData.ViewModels;

namespace MatData.Serialization
{
    public static class Q24Mapper
    {
        public static Q24Model Serialize(Q24Record model)
        {
            return new Q24Model
            {
                TipoDeRecursoMineral = model.q2406,
                CamadaExtractiva = model.q2407,
                AreaExistenciaRecursoMineral = model.q2408,
                RegistoFotografico1 = model.q2409,
                RegistoFotografico2 = model.q2410,
                ActividadeExtractivaPassado = model.q2411,
                ActividadeExtractivaActiva = model.q2412,
                Observacoes = model.q2413,
            };
        }
    }
}
