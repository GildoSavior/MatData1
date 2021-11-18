using MatData.Models.Records;
using MatData.ViewModels;
using System;

namespace MatData.Services.DynamicProfile
{
    public static class Q63Mapper
    {
        public static Q63Model Serialize(Q63Record model)
        {
            return new Q63Model
            {
              NumLigacoesDomiAT = Int32.Parse(model.q6306),
              NumClientesAguaAT = Int32.Parse(model.q6307),
              NumBenefAguaAT = Int32.Parse(model.q6308),
              NumLigacoesDomiciliaresAC = Int32.Parse(model.q6309),
              NumClientesAguaAC = Int32.Parse(model.q6310),
              NumBenefAC = Int32.Parse(model.q6311),
              NumAFCaptacaoAN = Int32.Parse(model.q6312),
              NumAFCaptacaoPoços = Int32.Parse(model.q6313),
              NumAFBuscCP = Int32.Parse(model.q6314),
              NumAFCompramAguaCisterna = Int32.Parse(model.q6315),
              Observacoes = model.q6316,
            };
        }
    }
}
