using MatData.Models.Records;
using MatData.ViewModels;

namespace MatData.Serialization
{
    public static class Q49Mapper
    {
        public static Q49Model Serialize(Q49Record model)
        {
            return new Q49Model
            {
                NomeDaOrganizacaoReligiosa = model.q4906,
                ReligiaoProfessada = model.q4907,
                IdentificacaoDoServicoOuPessoaDeContacto = model.q4908,
                ContactoTelefonico = model.q4909,
                EnderecoDeEmail = model.q4910,
                Website = model.q4911,
                ReconhecimentoDaOrganizacaoReligiosaPeloGovernoDeAngola = model.q4912,
                NumeroDoDecretoPresidencialDeAutorizacao = int.Parse(model.q4913),
                TipoDeEspacoDeCulto = model.q4914,
                FotografiaDoEspacoDeCultoFrontal = model.q4915,
                FotografiaDoEspacoDeCultoOutra = model.q4916,
                LocalizacaoDoEspacoDeCulto = model.q4917,
                FrequenciaDeAberturaAComunidade = model.q4918,
                NumeroMedioDePessoasQueSemanalmenteFrequentamOEspacoDeCulto = int.Parse(model.q4919),
                Observacões = model.q4920
            };
        }
    }
}
