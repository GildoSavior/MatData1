using MatData.Models.Records;
using MatData.ViewModels;

namespace MatData.Serialization
{
    public static class Q71Mapper
    {
        public static Q71Model Serialize(Q71Record model)
        {
            return new Q71Model
            {
                NomePonte = model.q7106,
                TipoEstrutura = model.q7107,
                TipoPavimento = model.q7108,
                EntidadeResponsavel = model.q7109,
                TravessiaSujeitaPagTaxa = model.q7110,
                EstadoConservacao = model.q7111,
                ComprimentoTrocoPonte = double.Parse(model.q7112),
                LocalPonte = model.q7113,
                FotografiaGeral = model.q7114,
                FotografiaEvidenciaEstrut = model.q7115,
                FotografiaEvidenciaTabuleiro = model.q7116,
                Observacoes = model.q7117,
            };
        }
    }
}
