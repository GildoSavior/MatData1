using MatData.Models.Records;
using MatData.ViewModels;

namespace MatData.Serialization
{
    public static class Q50Mapper
    {
        public static Q50Model Serialize(Q50Record model)
        {
            return new Q50Model
            {
                NomeDaInfraestruturaDeCultura = model.q5006,
                TipoDeInfraestruturaDeCultura = model.q5007,
                LocalizacaoDaInfraestruturaDeCultura = model.q5008,
                IdentificacaoDoServicoOuPessoaDeContacto = model.q5009,
                ContactoTelefonico = model.q5010,
                EnderecoDeEmail = model.q5011,
                Website = model.q5012,
                Fotografia1Frontal = model.q5013,
                Fotografia2Outra = model.q5014,
                SituacaoDaInfraestruturaDeCultura = model.q5015,
                EstadoDeConservacaoDaInfraestruturaDeCultura = model.q5016,
                TutelaDaInfraestruturaDeCultura = model.q5017,
                ExistenciaDeAgendaRegularDeEventosCulturais = model.q5018,
                Observacoes = model.q5019
            };
        } 
    }
}
