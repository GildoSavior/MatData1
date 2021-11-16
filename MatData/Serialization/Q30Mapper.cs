using MatData.Models.Records;
using MatData.ViewModels;

namespace MatData.Serialization
{
    public static class Q30Mapper
    {
        public static Q30Model Serialize(Q30Record model)
        {
            return new Q30Model
            {
                DesignacaoDaEstruturaEscolar = model.q3006,
                NumeroDeAlunosDe0a4AnosDeIdadeDestaEstruturaEscolar = int.Parse(model.q3007),
                NumeroAlunosDe5a9AnosDeIdadeDestaEstruturaEscolar = int.Parse(model.q3008),
                NumeroAlunosDe10a14AnosDeIdadeDestaEstruturaEscolar = int.Parse(model.q3009),
                NumeroAlunosDe15a19AnosDeIdadeDestaEstruturaEscolar = int.Parse(model.q3010),
                NumeroAlunosDe20a24AnosDeIdadeDestaEstruturaEscolar = int.Parse(model.q3011),
                NumeroAlunosDe25a29AnosDeIdadeDestaEstruturaEscolar = int.Parse(model.q3012),
                NumeroAlunosDe30a34AnosDeIdadeDestaEstruturaEscolar = int.Parse(model.q3013),
                NumeroAlunosDe35a39AnosDeIdadeDestaEstruturaEscolar = int.Parse(model.q3014),
                NumeroAlunosDe40OuMaisAnosDeIdadeDestaEstruturaEscolar = int.Parse(model.q3015),
                
                NumeroAlunas0a4AnosDeIdadeDestaEstruturaEscolar = int.Parse(model.q3017),
                NumeroAlunas5a9AnosDeIdadeDestaEstruturaEscolar = int.Parse(model.q3018),
                NumeroAlunas10a14AnosDeIdadeDestaEstruturaEscolar = int.Parse(model.q3019),
                NumeroAlunas15a19AnosDeIdadeDestaEstruturaEscolar = int.Parse(model.q3020),
                NumeroAlunas20a24AnosDeIdadeDestaEstruturaEscolar = int.Parse(model.q3021),
                NumeroAlunas25a29AnosDeIdadeDestaEstruturaEscolar = int.Parse(model.q3022),
                NumeroAlunas30a34AnosDeIdadeDestaEstruturaEscolar = int.Parse(model.q3023),
                NumeroAlunas35a39AnosDeIdadeDestaEstruturaEscolar = int.Parse(model.q3024),
                NumeroAlunas40OuMaisAnosDeIdadeDestaEstruturaEscolar = int.Parse(model.q3025),

                EducacaoPreEscolarMatriculados = int.Parse(model.q3027),
                EnsinoPrimarioMatriculados = int.Parse(model.q3028),
                ICicloDoEnsinoSecundarioMatriculados = int.Parse(model.q3029),
                IiCicloDoEnsinoSecundarioMatriculados = int.Parse(model.q3030),
                EnsinoTecnicoProfissionalEArtisticoMatriculados = int.Parse(model.q3031),
                EscolaDeFormacaoDeProfessoresMatriculados = int.Parse(model.q3032),
                EnsinoSuperiorMatriculados = int.Parse(model.q3033),
                EducacaoPreEscolarAlunosNaoTerminaram = int.Parse(model.q3034),
                EnsinoPrimarioNaoTerminaram = int.Parse(model.q3035),
                ICicloDoEnsinoSecundarioNaoTerminaram = int.Parse(model.q3026),
                IiCicloDoEnsinoSecundarioNaoTerminaram = int.Parse(model.q3027),
                EnsinoTecnicoProfissionalEArtisticoNaoTerminaram = int.Parse(model.q3028),
                EscolaDeFormacaoDeProfessoresNaoTerminaram = int.Parse(model.q3029),
                EnsinoSuperiorNaoTerminaram = int.Parse(model.q3030),
                Observacoes = model.q3031
            };
        }
    }
}
