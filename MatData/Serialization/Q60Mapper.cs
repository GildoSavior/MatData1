using MatData.Models.Records;
using MatData.ViewModels;

namespace MatData.Serialization
{
    public static class Q60Mapper
    {
        public static Q60Model Serialize(Q60Record model)
        {
            return new Q60Model
            {
                NumLigacoesDomiciliares = model.q6006,
                NumFocosIP = model.q6007,
                NumTotalBeneficiariosEnergia = model.q6008,
                NumClientesEnergiaBaixaTensaoPosPago = model.q6009,
                NumClientesEnergiaBaixaTensaoPrePago = model.q6010,
                NumClientesEnergiaMediaTensaoAnoTransacto = model.q6011,
                NumLigacoesDomiciliaresAnoCorrente = model.q6012,
                NumFocosIPAnoCorrente = model.q6013,
                NumTotalBeneficiariosEnerg = model.q6014,
                NumCliEnergiaBaixaTensao = model.q6015,
                NumCliEnergiaBaixaTensaoPrePago = model.q6016,
                NumCliEnergiaMediaTensao = model.q6017,
                PercentZonasPubInstalacao = double.Parse(model.q6018),
                PercentZonasPubIluminacao = double.Parse(model.q6019),
                Observacoes = model.q6020,


            };
        }

    }
}
