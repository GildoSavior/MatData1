using MatData.Models.Records;
using MatData.ViewModels;

namespace MatData.Serialization
{
    public static class Q59Mapper
    {
        public static Q59Model Serialize(Q59Record model)
        {
            return new Q59Model
            {
              InfraestruturaEnergia = model.q5906,
              ZonaMatrizEnergeticaPertenceTerritório = model.q5907,
              NomeOperadorEnergia = model.q5908,
              NumAlvara = model.q5909,
              IdentificacaoServico = model.q5910,
              ContactoTelefonico = model.q5911,
              EnderecoEmail = model.q5912,
              Website = model.q5913,
              TipologiaInfraestrutura = model.q5914,
              LocalizacaoInfraestrutura = model.q5915,
              FotografiaFrontal1 = model.q5916,
              Fotografia2 = model.q5917,
              Observacoes = model.q5918,


            };
        }
    }
}
