using MatData.Models.Records;

namespace MatData.Serialization
{
    public static class Q20Mapper
    {
        public static dynamic Serialize(Q20Record model)
        {
            if (model.q2006 == "Rio")
            {
                return new
                {
                    Recurso = model.q2006,
                    NomeRio = model.q2007,
                    LocalizacaoRio = model.q2008,
                    Fotografia1 = model.q2009,
                    Fotografia2 = model.q2010,
                    FormaRio = model.q2011,
                    TipoRio = model.q2012,
                    ExtensaoRio = double.Parse(model.q2013),
                    VolumeAguaNoCacimbo = double.Parse(model.q2014),
                    VolumeAguaNoTempoCalor = double.Parse(model.q2015),
                    AcidentesNoCursoDoRio = model.q2016,
                    FotografiaDosAcidentesDoRio = model.q2017,
                    Observacoes = model.q2034,
                };
            }

            if (model.q2006 == "Lago")
            {
                return new
                {
                    Recurso = model.q2006,
                    NomeLago = model.q2018,
                    LocalizacaoLago = model.q2019,
                    AreaLago = model.q2020,
                    Fotografia1 = model.q2021,
                    Fotografia2 = model.q2022,
                    Observacoes = model.q2034
                };
            }

            if (model.q2006 == "Lagoa")
            {
                return new
                {
                    Recurso = model.q2006,
                    NomeLagoa = model.q2023,
                    LocalizacaoLagoa = model.q2024,
                    AreaLagoa = model.q2025,
                    Fotografia1 = model.q2026,
                    Fotografia2 = model.q2027,
                    Observacoes = model.q2034
                };
            }

            if (model.q2006 == "Fluxo-hídrico-cíclico")
            {
                return new
                {
                    Recurso = model.q2006,
                    NomeFluxoHidrico = model.q2028,
                    LocalizacaoFluxoHidrico = model.q2029,
                    Fotografia1 = model.q2030,
                    Fotografia2 = model.q2031,
                    TipologiaFluxoHidrico = model.q2032,
                    DuracaoMediaAnualFluxoHidrico = model.q2033,
                    Observacoes = model.q2034
                };
            }

            return null;
        }
    }
}
