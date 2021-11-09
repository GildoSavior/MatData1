using MatData.Models.Records;
using MatData.ViewModels;

namespace MatData.Serialization
{
    public static class Q18Mapper
    {
        public static Q18Model Serialize(Q18Record model)
        {
            return new Q18Model
            {
                AnoReferencia = model.q1806,
                IndicePluviometriaMensalJaneiro = double.Parse(model.q1807),
                TemperaturaMediaDiurnaMensalJaneiro = double.Parse(model.q1808),
                TemperaturaMediaNocturnaMensalJaneiro = double.Parse(model.q1809),
                IndicePluviometriaMensalFevereiro = double.Parse(model.q1810),
                TemperaturaMediaDiurnaMensalFevereiro = double.Parse(model.q1811),
                TemperaturaMediaNocturnaMensalFevereiro = double.Parse(model.q1812),
                IndicePluviometriaMensalMarco = double.Parse(model.q1813),
                TemperaturaMediaDiurnaMensalMarco = double.Parse(model.q1814),
                TemperaturaMediaNocturnaMensalMarco = double.Parse(model.q1815),
                IndicePluviometriaMensalAbril = double.Parse(model.q1816),
                TemperaturaMediaDiurnaMensalAbril = double.Parse(model.q1817),
                TemperaturaMediaNocturnaMensalAbril = double.Parse(model.q1818),
                IndicePluviometriaMensalMaio = double.Parse(model.q1819),
                TemperaturaMediaDiurnaMensalMaio = double.Parse(model.q1820),
                TemperaturaMediaNocturnaMensalMaio = double.Parse(model.q1821),
                IndicePluviometriaMensalJunho = double.Parse(model.q1822),
                TemperaturaMediaDiurnaMensalJunho = double.Parse(model.q1823),
                TemperaturaMediaNocturnaMensalJunho = double.Parse(model.q1824),
                IndicePluviometriaMensalJulho = double.Parse(model.q1825),
                TemperaturaMediaDiurnaMensalJulho = double.Parse(model.q1826),
                TemperaturaMediaNocturnaMensalJulho = double.Parse(model.q1827),
                IndicePluviometriaMensalAgosto = double.Parse(model.q1828),
                TemperaturaMediaDiurnaMensalAgosto = double.Parse(model.q1829),
                TemperaturaMediaNocturnaMensalAgosto = double.Parse(model.q1830),
                IndicePluviometriaMensalSetembro = double.Parse(model.q1831),
                TemperaturaMediaDiurnaMensalSetembro = double.Parse(model.q1832),
                TemperaturaMediaNocturnaMensalSetembro = double.Parse(model.q1833),
                IndicePluviometriaMensalOutubro = double.Parse(model.q1834),
                TemperaturaMediaDiurnaMensalOutubro = double.Parse(model.q1835),
                TemperaturaMediaNocturnaMensalOutubro = double.Parse(model.q1836),
                IndicePluviometriaMensalNovembro = double.Parse(model.q1837),
                TemperaturaMediaDiurnaMensalNovembro = double.Parse(model.q1838),
                TemperaturaMediaNocturnaMensalNovembro = double.Parse(model.q1839),
                IndicePluviometriaMensalDezembro = double.Parse(model.q1840),
                TemperaturaMediaDiurnaMensalDezembro = double.Parse(model.q1841),
                TemperaturaMediaNocturnaMensalDezembro = double.Parse(model.q1842),
                NumeroMedioAnualDeDiasSemChuva = double.Parse(model.q1843),
                Observacoes = model.q1848
            }; 
        }
    }
}
