using MatData.Models.Records;
using MatData.ViewModels;

namespace MatData.Serialization
{
    public static partial class Q35Mapper
    {
        public static Q35Model Serialize(Q35Record model)
        {
            return new Q35Model
            {
                CursosFormacaoTecnicaProfissionalArtisticaEmFuncionamento = Helpers.StringToArray(model.q3504),
                CursosFormacaoSuperiorEmFuncionamento = Helpers.StringToArray(model.q3505),
                CursosExtensaoUniversitariaEmFuncionamento = Helpers.StringToArray(model.q3506),
                Observacoes = model.q3507,
            };
        }
    }
}
