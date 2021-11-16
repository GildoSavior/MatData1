namespace MatData.ViewModels
{
    public class Q30Model
    {
        public string DesignacaoDaEstruturaEscolar { get; set; }
        public int NumeroDeAlunosDe0a4AnosDeIdadeDestaEstruturaEscolar { get; set; }
        public int NumeroAlunosDe5a9AnosDeIdadeDestaEstruturaEscolar { get; set; }
        public int NumeroAlunosDe10a14AnosDeIdadeDestaEstruturaEscolar { get; set; }
        public int NumeroAlunosDe15a19AnosDeIdadeDestaEstruturaEscolar { get; set; }
        public int NumeroAlunosDe20a24AnosDeIdadeDestaEstruturaEscolar { get; set; }
        public int NumeroAlunosDe25a29AnosDeIdadeDestaEstruturaEscolar { get; set; }
        public int NumeroAlunosDe30a34AnosDeIdadeDestaEstruturaEscolar { get; set; }
        public int NumeroAlunosDe35a39AnosDeIdadeDestaEstruturaEscolar { get; set; }
        public int NumeroAlunosDe40OuMaisAnosDeIdadeDestaEstruturaEscolar { get; set; }
        public int NumeroDeTotalDeAlunosDoSexoMasculino
        {
            get
            {
                return 
                    NumeroDeAlunosDe0a4AnosDeIdadeDestaEstruturaEscolar +
                    NumeroAlunosDe5a9AnosDeIdadeDestaEstruturaEscolar +
                    NumeroAlunosDe10a14AnosDeIdadeDestaEstruturaEscolar +
                    NumeroAlunosDe15a19AnosDeIdadeDestaEstruturaEscolar +
                    NumeroAlunosDe20a24AnosDeIdadeDestaEstruturaEscolar +
                    NumeroAlunosDe25a29AnosDeIdadeDestaEstruturaEscolar +
                    NumeroAlunosDe30a34AnosDeIdadeDestaEstruturaEscolar +
                    NumeroAlunosDe35a39AnosDeIdadeDestaEstruturaEscolar +
                    NumeroAlunosDe40OuMaisAnosDeIdadeDestaEstruturaEscolar;
            }
        }
        public int NumeroAlunas0a4AnosDeIdadeDestaEstruturaEscolar { get; set; }
        public int NumeroAlunas5a9AnosDeIdadeDestaEstruturaEscolar { get; set; }
        public int NumeroAlunas10a14AnosDeIdadeDestaEstruturaEscolar { get; set; }
        public int NumeroAlunas15a19AnosDeIdadeDestaEstruturaEscolar { get; set; }
        public int NumeroAlunas20a24AnosDeIdadeDestaEstruturaEscolar { get; set; }
        public int NumeroAlunas25a29AnosDeIdadeDestaEstruturaEscolar { get; set; }
        public int NumeroAlunas30a34AnosDeIdadeDestaEstruturaEscolar { get; set; }
        public int NumeroAlunas35a39AnosDeIdadeDestaEstruturaEscolar { get; set; }
        public int NumeroAlunas40OuMaisAnosDeIdadeDestaEstruturaEscolar { get; set; }
        public int NumeroDeTotalDeAlunasDoSexoFeminino { get; set; }
        public int NumeroTotalDeAlunos
        {
            get
            {
                return 
                    NumeroAlunas0a4AnosDeIdadeDestaEstruturaEscolar +
                    NumeroAlunas5a9AnosDeIdadeDestaEstruturaEscolar +
                    NumeroAlunas10a14AnosDeIdadeDestaEstruturaEscolar +
                    NumeroAlunas15a19AnosDeIdadeDestaEstruturaEscolar +
                    NumeroAlunas20a24AnosDeIdadeDestaEstruturaEscolar +
                    NumeroAlunas25a29AnosDeIdadeDestaEstruturaEscolar +
                    NumeroAlunas30a34AnosDeIdadeDestaEstruturaEscolar +
                    NumeroAlunas35a39AnosDeIdadeDestaEstruturaEscolar +
                    NumeroAlunas40OuMaisAnosDeIdadeDestaEstruturaEscolar +
                    NumeroDeTotalDeAlunasDoSexoFeminino;
            }
        }
        public int EducacaoPreEscolarMatriculados { get; set; }
        public int EnsinoPrimarioMatriculados { get; set; }
        public int ICicloDoEnsinoSecundarioMatriculados { get; set; }
        public int IiCicloDoEnsinoSecundarioMatriculados { get; set; }
        public int EnsinoTecnicoProfissionalEArtisticoMatriculados { get; set; }
        public int EscolaDeFormacaoDeProfessoresMatriculados { get; set; }
        public int EnsinoSuperiorMatriculados { get; set; }
        public int EducacaoPreEscolarAlunosNaoTerminaram { get; set; }
        public int EnsinoPrimarioNaoTerminaram { get; set; }
        public int ICicloDoEnsinoSecundarioNaoTerminaram { get; set; }
        public int IiCicloDoEnsinoSecundarioNaoTerminaram { get; set; }
        public int EnsinoTecnicoProfissionalEArtisticoNaoTerminaram { get; set; }
        public int EscolaDeFormacaoDeProfessoresNaoTerminaram { get; set; }
        public int EnsinoSuperiorNaoTerminaram { get; set; }
        public string Observacoes { get; set; }
    }
}
