using MatData.Models.Records;
using MatData.ViewModels;
using System;

namespace MatData.Serialization
{
    public static class Q69Mapper
    {
        public static Q69Model Serialize(Q69Record model)
        {
            return new Q69Model
            {
                ExistPlanDirMuniAprovado = model.q6904,
                IdenActoNormatAprovacao = model.q6904 == "Sim" ? model.q6905 : null,
                ExistInstruMuniOrdTerrPlanUrban = model.q6906,
                IdentActoAprovacao = model.q6906 == "Sim" ? model.q6907 : null,
                ExistPlanToponimia = model.q6908,
                IdActoAprovacao = model.q6908 == "Sim" ? model.q6909 : null,
                ExistCadastroTerras = model.q6910,
                IdActoNormAprov = model.q6910 == "Sim" ? model.q6911 : null,
                ExistDocOrientUsoTerras = model.q6912,
                IdActNorAprovacao = model.q6912 == "Sim" ? model.q6913 : null,
                ExistDocOrientZoneamento = model.q6914,
                IdActoNormativApro = model.q6914 == "Sim" ? model.q6915 : null,
                ExistDocOrientDefPerimetro = model.q6916,
                IdActoNormativo = model.q6916 == "Sim" ? model.q6917 : null,
                NumAgloPopSArrDefinidos = Int32.Parse(model.q6918),
                NumAgloPopCArrTerraBatida = Int32.Parse(model.q6919),
                NumAgloPopCArrEmpedrados = Int32.Parse(model.q6920),
                NumAgloPopCArrAsfaltados = Int32.Parse(model.q6921),
                NumAgloPopCArrEstruOM = Int32.Parse(model.q6922),
                PercentArrLaterPrepCircPeoes = double.Parse(model.q6923),
                PercentArrPasseiosAcessCadRodas = double.Parse(model.q6924),
                NumJardins = Int32.Parse(model.q6925),
                NumEspacosLazer = Int32.Parse(model.q6926),
                NumParquesInfantis = Int32.Parse(model.q6927),
                NumAgloPopPlacasToponímicas = Int32.Parse(model.q6928),
                NumAgloPopPlacasInformativas = Int32.Parse(model.q6929),
                NumAgloPopSinalTransito = Int32.Parse(model.q6930),
                NumCemiterios = Int32.Parse(model.q6931),
                Observacoes = model.q6932,

            };
        }
    }
}
