using MatData.Models.Records;
using MatData.ViewModels;

namespace MatData.Serialization
{
    public static class Q73Mapper
    {
        public static Q73Model Serialize(Q73Record model)
        {
            return new Q73Model
            {
              DesigRedeFerroviaria = model.q7304,
              IdRamal = model.q7305,
              EstadoConservacaoFerrovia = model.q7306,
              ComprimentoTroco = double.Parse(model.q7307),
              IdLocalEntradaFerrovia = model.q7308,
              LocalEntradaFerrovia = model.q7309,
              FotoLocalEntrada = model.q7310,
              IdLocalSaidaFerrovia = model.q7311,
              LocalSaidaFerrovia = model.q7312,
              FotoLocalSaidaFerrovia = model.q7313,
              Observacoes = model.q7314,

            };
        }
    }
}
