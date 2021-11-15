using MatData.Models.Records;
using MatData.ViewModels;

namespace MatData.Serialization
{
    public static class Q33Mapper
    {
        public static Q33Model Serialize(Q33Record model)
        {
            return new Q33Model
            {
                NomeProfessor = model.q3304,
                EstruturaAfecto = model.q3305,
                DataAfectacao = model.q3306,
                NomeEstrutura = model.q3307,
                FuncaoEstrutura = model.q3308,
                Genero = model.q3309,
                DataNascimento = model.q3310,
                ProvinciaNascimento = model.q3311,
                MunicipioNascimento = model.q3312,
                AreaFormacao = model.q3313,
                NivelAcademicoElevadoCompleto = model.q3314,
                EntidadeFormacaoNivelAcademicoElevadoCompleto = model.q3315,
                OutrasFormacoesRelevantesLista = model.q3316,
                CategoriaProfissionalActual = model.q3317,
                TipoContracto = model.q3318,
                CategoriaProvimento = model.q3319,
                Observacoes = model.q3320
            };
        }
    }
}
