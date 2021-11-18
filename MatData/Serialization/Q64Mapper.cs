using MatData.Models.Records;
using MatData.ViewModels;
using System;

namespace MatData.Serialization
{
    public static class Q64Mapper
    {
        public static Q64Model Serialize(Q64Record model)
        {
            return new Q64Model
            {
                NumNovasLigacoesDomiAT = Int32.Parse(model.q6404),
                NumNovasLigacoesDomiAC = Int32.Parse(model.q6405),
                NumLigacoesDomiMunicipio = Int32.Parse(model.q6406),
                NumBeneficiaMunicipio = Int32.Parse(model.q6407),
                NumCentraisTratamentoConsumo = Int32.Parse(model.q6408),
                CapacidadeProdAPotavel = double.Parse(model.q6409),
                QtdAPotavel = double.Parse(model.q6410),
                Observacoes = model.q6411,
            };
        }
    }
}
