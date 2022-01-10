using MatData.Models.Records;
using MatData.ViewModels;

namespace MatData.Serialization
{
    public class Q25Mapper
    {
        public static Q25Model Serialize(Q25Record model)
        {
            return new Q25Model
            {
                NomeAreaProtegida = model.q2506,
                IdentificacaoAreaProtegida = model.q2507,
                LocalizacaoPrincipalAcesso = model.q2508,
                AreaProtegica = model.q2509,
                Fotografia1 = model.q2510,
                Fotografia2 = model.q2511,
                Fotografia3 = model.q2512,
                Fotografia4 = model.q2513,
                Fotografia5 = model.q2514,
                Observacoes = model.q2515,
            };
        }
    }
}
