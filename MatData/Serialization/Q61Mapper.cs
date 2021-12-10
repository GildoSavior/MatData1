using MatData.Models.Records;
using MatData.ViewModels;
using System;

namespace MatData.Serialization
{
    public static class Q61Mapper
    {
        public static Q61Model Serialize(Q61Record model)
        {
            return new Q61Model
            {
                NumMiniHidricas = Int32.Parse(model.q6104),
                NumCentraisEnergiaSolar = Int32.Parse(model.q6105),
                NumCentraisEnergiaEolicas = Int32.Parse(model.q6106),
                NumCentraisEnergiaBiomassa = Int32.Parse(model.q6107),
                NumCentraisTermicas = Int32.Parse(model.q6108),
                NumEstacoesElectricas = Int32.Parse(model.q6109),
                NumRedesMTBT = Int32.Parse(model.q6110),
                NumPT = Int32.Parse(model.q6111),
                NumNovasLigDomiciAT = Int32.Parse(model.q6112),
                NumNovasLigDomicAC = Int32.Parse(model.q6113),
                NumFocosIP = Int32.Parse(model.q6114),
                PotenciaMW = Int32.Parse(model.q6115),
                TotalBenefEnergiaMuni = Int32.Parse(model.q6116),
                Observacoes = model.q6117,
            };
        }


    }
}
