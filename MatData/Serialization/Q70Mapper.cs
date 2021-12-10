using MatData.Models.Records;
using MatData.ViewModels;

namespace MatData.Serialization
{
    public static class Q70Mapper
    {
        public static Q70Model Serialize(Q70Record model)
        {
            return new Q70Model
            {
                EstradaAcessoAldeia = model.q7006,
                Designacao = model.q7006 == "Sim" ? model.q7007 : null,
                ClassificacaoVia = model.q7006 == "Sim" ? model.q7008 : null,
                EntidadeResponsavel = model.q7006 == "Sim" ? model.q7009 : null,
                TipoVia = model.q7006 == "Sim" ? model.q7010 : null,
                EstadoConservacao = model.q7006 == "Sim" ? model.q7011 : null,
                IdCondTempCirculaFN = model.q7006 == "Sim" ? model.q7012 : null,
                IdPontosCriticos = model.q7006 == "Sim" ? model.q7013 : null,
                ComprimentoTroco = model.q7006 == "Sim" ? double.Parse(model.q7014) : 0,
                NumKMTrocoViaAsfaltados = model.q7006 == "Sim" ? double.Parse(model.q7015) : 0,
                NumKMTrocoViaTerraBatida = model.q7006 == "Sim" ? double.Parse(model.q7016) : 0,
                NumKMTrocoViaBomEstado = model.q7006 == "Sim" ? double.Parse(model.q7017) : 0,
                NumKMTrocoViaCProbCirculacao = model.q7006 == "Sim" ? double.Parse(model.q7018) : 0,
                NumKMTrocoViaNaoTransitaveis = model.q7006 == "Sim" ? double.Parse(model.q7019) : 0,
                IdLocalInicioVia = model.q7006 == "Sim" ? model.q7020 : null,
                LocalInicioVia = model.q7006 == "Sim" ? model.q7021 : null,
                FotografiaInicioVia = model.q7006 == "Sim" ? model.q7022 : null,
                IdLocalFimVia = model.q7006 == "Sim" ? model.q7023 : null,
                LocalFimVia = model.q7006 == "Sim" ? model.q7024 : null,
                FotografiaFimVia = model.q7006 == "Sim" ? model.q7025 : null,
                CirculacaoSujPagTaxa = model.q7006 == "Sim" ? model.q7026 : null,
                Observacoes = model.q7027,


            };
        }
    }
}
