using MatData.Models.Records;
using MatData.ViewModels;

namespace MatData.Serialization
{
    public class Q41Mapper
    {
        public static Q41Model Serialize(Q41Record model)
        {
            return new Q41Model
            {
                NomeProfissionalSaude = model.q4104,
                EstruturaAQueEstaAfecto = model.q4105,
                DataAfectacaoEstrutura = model.q4106,
                NomeEstruturaSaude = model.q4107,
                Genero = model.q4108,
                DataNascimento = model.q4109,
                PrivinciaNascimento = model.q4110,
                MunicipioNascimento = model.q4111,
                AreaFormacao = model.q4112,
                NivelAcadenicoMaisElavadoCompleto = model.q4113,
                EntidadeFormacaoNicelAcademicoMaisElevadoCompleto = model.q4114,
                OutrasFormacoesRelevantesParaFuncao = model.q4115,
                CategoriaProfissionalActual = model.q4116,
                TipoContracto = model.q4117,
                CategoriaProvimento = model.q4118,
                Observacoes = model.q4119,
            };
        }

    }
}
