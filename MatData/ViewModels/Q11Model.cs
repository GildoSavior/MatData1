namespace MatData.ViewModels
{
    public class Q11Model
    {
        public int TotalMen0Ate4TransactYearsAge { get; set; }
        public int TotalMen5Ate9TransactYearsAge { get; set; }
        public int TotalMen10Ate14TransactYearsAge { get; set; }
        public int TotalMen15Ate19TransactYearsAge { get; set; }
        public int TotalMen20Ate24TransactYearsAge { get; set; }
        public int TotalMen25Ate29TransactYearsAge { get; set; }
        public int TotalMen30Ate34TransactYearsAge { get; set; }
        public int TotalMen35Ate39TransactYearsAge { get; set; }
        public int TotalMen40Ate44TransactYearsAge { get; set; }
        public int TotalMen45Ate49TransactYearsAge { get; set; }
        public int TotalMen50Ate54TransactYearsAge { get; set; }
        public int TotalMen55Ate59TransactYearsAge { get; set; }
        public int TotalMenGreaterOrIgual60TransactYearsAge { get; set; }
        public int TotalMenTransactYearsAge
        {
            get
            {
                return
                  TotalMen0Ate4TransactYearsAge
                  + TotalMen5Ate9TransactYearsAge
                  + TotalMen10Ate14TransactYearsAge
                  + TotalMen15Ate19TransactYearsAge
                  + TotalMen20Ate24TransactYearsAge
                  + TotalMen25Ate29TransactYearsAge
                  + TotalMen30Ate34TransactYearsAge
                  + TotalMen35Ate39TransactYearsAge
                  + TotalMen40Ate44TransactYearsAge
                  + TotalMen45Ate49TransactYearsAge
                  + TotalMen50Ate54TransactYearsAge
                  + TotalMen55Ate59TransactYearsAge
                  + TotalMenGreaterOrIgual60TransactYearsAge;
            }
        }
        public int TotalWomen0Ate4TransactYearsAge { get; set; }
        public int TotalWomen5Ate9TransactYearsAge { get; set; }
        public int TotalWomen10Ate14TransactYearsAge { get; set; }
        public int TotalWomen15Ate19TransactYearsAge { get; set; }
        public int TotalWomen20Ate24TransactYearsAge { get; set; }
        public int TotalWomen25Ate29TransactYearsAge { get; set; }
        public int TotalWomen30Ate34TransactYearsAge { get; set; }
        public int TotalWomen35Ate39TransactYearsAge { get; set; }
        public int TotalWomen40Ate44TransactYearsAge { get; set; }
        public int TotalWomen45Ate49TransactYearsAge { get; set; }
        public int TotalWomen50Ate54TransactYearsAge { get; set; }
        public int TotalWomen55Ate59TransactYearsAge { get; set; }
        public int TotalWomen60GreaterThenOrIgualTransactYearsAge { get; set; }
        public int TotalWomenTransactYearsAge
        {
            get
            {
                return TotalWomen0Ate4TransactYearsAge +
                        TotalWomen5Ate9TransactYearsAge +
                        TotalWomen10Ate14TransactYearsAge +
                        TotalWomen15Ate19TransactYearsAge +
                        TotalWomen20Ate24TransactYearsAge +
                        TotalWomen25Ate29TransactYearsAge +
                        TotalWomen30Ate34TransactYearsAge +
                        TotalWomen35Ate39TransactYearsAge +
                        TotalWomen40Ate44TransactYearsAge +
                        TotalWomen45Ate49TransactYearsAge +
                        TotalWomen50Ate54TransactYearsAge +
                        TotalWomen55Ate59TransactYearsAge +
                        TotalWomen60GreaterThenOrIgualTransactYearsAge;
            }
        }

        public int TotalMenAndWomenTransactYearsAge
        {
            get
            {
                return TotalMenTransactYearsAge + TotalWomenTransactYearsAge;
            }
        }

        public int TotalMen0Ate4ActualYearsAge { get; set; }
        public int TotalMen5Ate9ActualYearsAge { get; set; }
        public int TotalMen10Ate14ActualYearsAge { get; set; }
        public int TotalMen15Ate19ActualYearsAge { get; set; }
        public int TotalMen20Ate24ActualYearsAge { get; set; }
        public int TotalMen25Ate29ActualYearsAge { get; set; }
        public int TotalMen30Ate34ActualYearsAge { get; set; }
        public int TotalMen35Ate39ActualYearsAge { get; set; }
        public int TotalMen40Ate44ActualYearsAge { get; set; }
        public int TotalMen45Ate49ActualYearsAge { get; set; }
        public int TotalMen50Ate54ActualYearsAge { get; set; }
        public int TotalMen55Ate59ActualYearsAge { get; set; }
        public int TotalMenGreaterOrIgual60ActualYearsAge { get; set; }
        public int TotalMenActualYearsAge
        {
            get
            {
                return
                  TotalMen0Ate4ActualYearsAge
                  + TotalMen5Ate9ActualYearsAge
                  + TotalMen10Ate14ActualYearsAge
                  + TotalMen15Ate19ActualYearsAge
                  + TotalMen20Ate24ActualYearsAge
                  + TotalMen25Ate29ActualYearsAge
                  + TotalMen30Ate34ActualYearsAge
                  + TotalMen35Ate39ActualYearsAge
                  + TotalMen40Ate44ActualYearsAge
                  + TotalMen45Ate49ActualYearsAge
                  + TotalMen50Ate54ActualYearsAge
                  + TotalMen55Ate59ActualYearsAge
                  + TotalMenGreaterOrIgual60ActualYearsAge;
            }
        }
        public int TotalWomen0Ate4ActualYearsAge { get; set; }
        public int TotalWomen5Ate9ActualYearsAge { get; set; }
        public int TotalWomen10Ate14ActualYearsAge { get; set; }
        public int TotalWomen15Ate19ActualYearsAge { get; set; }
        public int TotalWomen20Ate24ActualYearsAge { get; set; }
        public int TotalWomen25Ate29ActualYearsAge { get; set; }
        public int TotalWomen30Ate34ActualYearsAge { get; set; }
        public int TotalWomen35Ate39ActualYearsAge { get; set; }
        public int TotalWomen40Ate44ActualYearsAge { get; set; }
        public int TotalWomen45Ate49ActualYearsAge { get; set; }
        public int TotalWomen50Ate54ActualYearsAge { get; set; }
        public int TotalWomen55Ate59ActualYearsAge { get; set; }
        public int TotalWomen60GreaterThenOrIgualActualYearsAge { get; set; }
        public int TotalWomenActualYearsAge
        {
            get
            {
                return TotalWomen0Ate4ActualYearsAge +
                        TotalWomen5Ate9ActualYearsAge +
                        TotalWomen10Ate14ActualYearsAge +
                        TotalWomen15Ate19ActualYearsAge +
                        TotalWomen20Ate24ActualYearsAge +
                        TotalWomen25Ate29ActualYearsAge +
                        TotalWomen30Ate34ActualYearsAge +
                        TotalWomen35Ate39ActualYearsAge +
                        TotalWomen40Ate44ActualYearsAge +
                        TotalWomen45Ate49ActualYearsAge +
                        TotalWomen50Ate54ActualYearsAge +
                        TotalWomen55Ate59ActualYearsAge +
                        TotalWomen60GreaterThenOrIgualActualYearsAge;
            }
        }

        public int TotalMenAndWomenActualYearsAge
        {
            get
            {
                return TotalMenActualYearsAge + TotalWomenActualYearsAge;
            }
        }

        public int TotalAgreFamAldeiaOuBairro { get; set; }
        public int TotalAgreFamAldeiaOuBairroExpostosARiscosNaturaisAmbientais { get; set; }
        public int TotalAgreFamAldeiaOuBairroCadastradaosProgKwenda { get; set; }
        public int TotalAgreFamAldeiaOuBairroCadastradaosProApoioSocial { get; set; }
        public string Observacoes { get; set; }


    }
}
