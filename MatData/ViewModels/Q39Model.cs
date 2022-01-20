namespace MatData.ViewModels
{
    public class Q39Model
    {
        public string DesignacaodaUnidadedeSaude { get; set; }
        public string TipologiadeUnidadedeSaude { get; set; }
        public int Medicos { get; set; }
        public int EnfermeirosTecnicosSuperiores { get; set; }
        public int EnfermeirosTecnicosMedios { get; set; }
        public int Parteiras { get; set; }
        public int TecnicosdeDiagnostico { get; set; }
        public int OutrosProfissionaisdeSaude { get; set; }
        public int NumerototaldeProfissionaisdeSaudedestaUS
        {
            get
            {
                return Medicos +
                    EnfermeirosTecnicosSuperiores +
                    EnfermeirosTecnicosMedios +
                    Parteiras +
                    TecnicosdeDiagnostico +
                    OutrosProfissionaisdeSaude;
            }
        }
        public string Observacoes { get; set; }

    }
}
