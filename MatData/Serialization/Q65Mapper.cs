using MatData.Models.Records;
using MatData.ViewModels;

namespace MatData.Serialization
{
    public static class Q65Mapper
    {
        public static Q65Model Serialize(Q65Record model)
        {
            return new Q65Model
            {
                ExistPlanoSanit = model.q6505,
                ExistSisEsgotosSanit = model.q6506,
                ExistSisRecolhaAREI = model.q6507,
                ExistSisGestAP = model.q6508,
                ExistETAR = model.q6509,
                ExistSisRecolhaRS = model.q6510,
                EntidadeResponRecLixo = model.q6511,
                PeriodRecLixo = model.q6512,
                DestinoLixo = model.q6513,
                ExistRecTratEspRI = model.q6514,
                EntRespRecRI = model.q6514 == "Sim" ? model.q6515 : null,
                ExistRecoTratERH = model.q6516,
                EntRespRH = model.q6516 == "Sim" ? model.q6517 : null,
                EntRespLimpezaVP = model.q6518,
                Observacoes = model.q6519,
            };
        }
    }
}
