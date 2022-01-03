using MatData.Models.Records;
using MatData.ViewModels;

namespace MatData.Serialization
{
    public class Q11Mapper
    {
        public static Q11Model Serialize(Q11Record model)
        {
            return new Q11Model
            {
                CensoNumHomens2014 = model.q1106 == "Sim" ? model.q1107 : 0,
                CensoNumMulheres2014 = model.q1106 == "Sim" ? model.q1108 : 0,
                TotalMen0Ate4TransactYearsAge = model.q1110,
                TotalMen5Ate9TransactYearsAge = model.q1111,
                TotalMen10Ate14TransactYearsAge = model.q1112,
                TotalMen15Ate19TransactYearsAge = model.q1113,
                TotalMen20Ate24TransactYearsAge = model.q1114,
                TotalMen25Ate29TransactYearsAge = model.q1115,
                TotalMen30Ate34TransactYearsAge = model.q1116,
                TotalMen35Ate39TransactYearsAge = model.q1117,
                TotalMen40Ate44TransactYearsAge = model.q1118,
                TotalMen45Ate49TransactYearsAge = model.q1119,
                TotalMen50Ate54TransactYearsAge = model.q1120,
                TotalMen55Ate59TransactYearsAge = model.q1121,
                TotalMenGreaterOrIgual60TransactYearsAge = model.q1122,

                TotalWomen0Ate4TransactYearsAge = model.q1124,
                TotalWomen5Ate9TransactYearsAge = model.q1125,
                TotalWomen10Ate14TransactYearsAge = model.q1126,
                TotalWomen15Ate19TransactYearsAge = model.q1127,
                TotalWomen20Ate24TransactYearsAge = model.q1128,
                TotalWomen25Ate29TransactYearsAge = model.q1129,
                TotalWomen30Ate34TransactYearsAge = model.q1130,
                TotalWomen35Ate39TransactYearsAge = model.q1131,
                TotalWomen40Ate44TransactYearsAge = model.q1132,
                TotalWomen45Ate49TransactYearsAge = model.q1133,
                TotalWomen50Ate54TransactYearsAge = model.q1134,
                TotalWomen55Ate59TransactYearsAge = model.q1135,
                TotalWomen60GreaterThenOrIgualTransactYearsAge = model.q1136,

                TotalMen0Ate4ActualYearsAge = model.q1139,
                TotalMen5Ate9ActualYearsAge = model.q1140,
                TotalMen10Ate14ActualYearsAge = model.q1141,
                TotalMen15Ate19ActualYearsAge = model.q1142,
                TotalMen20Ate24ActualYearsAge = model.q1143,
                TotalMen25Ate29ActualYearsAge = model.q1144,
                TotalMen30Ate34ActualYearsAge = model.q1145,
                TotalMen35Ate39ActualYearsAge = model.q1146,
                TotalMen40Ate44ActualYearsAge = model.q1147,
                TotalMen45Ate49ActualYearsAge = model.q1148,
                TotalMen50Ate54ActualYearsAge = model.q1149,
                TotalMen55Ate59ActualYearsAge = model.q1150,
                TotalMenGreaterOrIgual60ActualYearsAge = model.q1151,

                TotalWomen0Ate4ActualYearsAge = model.q1153,
                TotalWomen5Ate9ActualYearsAge = model.q1154,
                TotalWomen10Ate14ActualYearsAge = model.q1155,
                TotalWomen15Ate19ActualYearsAge = model.q1156,
                TotalWomen20Ate24ActualYearsAge = model.q1157,
                TotalWomen25Ate29ActualYearsAge = model.q1158,
                TotalWomen30Ate34ActualYearsAge = model.q1159,
                TotalWomen35Ate39ActualYearsAge = model.q1160,
                TotalWomen40Ate44ActualYearsAge = model.q1161,
                TotalWomen45Ate49ActualYearsAge = model.q1162,
                TotalWomen50Ate54ActualYearsAge = model.q1163,
                TotalWomen55Ate59ActualYearsAge = model.q1164,
                TotalWomen60GreaterThenOrIgualActualYearsAge = model.q1165,

                TotalAgreFamAldeiaOuBairro = model.q1168,
                TotalAgreFamAldeiaOuBairroExpostosARiscosNaturaisAmbientais = model.q1169,
                TotalAgreFamAldeiaOuBairroCadastradaosProgKwenda = model.q1170,
                TotalAgreFamAldeiaOuBairroCadastradaosProApoioSocial = model.q1171,
                Observacoes = model.q1172,
            };
        }
    }
}
