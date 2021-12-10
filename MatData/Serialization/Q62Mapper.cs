using MatData.Models.Records;
using MatData.ViewModels;

namespace MatData.Serialization
{
    public static class Q62Mapper
    {
        public static Q62Model Serialize(Q62Record model)
        {
            return new Q62Model
            {
                InfraestruturaAgua = model.q6206,
                NomeOperador = model.q6207,
                NumAlvara = model.q6208,
                IdServico = model.q6209,
                ContactoTelefonico = model.q6210,
                Email = model.q6211,
                Website = model.q6212,
                LocalizacaoInfraestrutura = model.q6213,
                FotografiaFrontal = model.q6214,
                FotografiaOutra = model.q6215,
                Observacoes = model.q6216,

            };
        }
    }
}
