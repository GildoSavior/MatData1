using MatData.Models.Records;
using MatData.ViewModels;
using System;

namespace MatData.Serialization
{
    public static class Q75Mapper
    {
        public static Q75Model Serialize(Q75Record model)
        {
            return new Q75Model
            {
                DesignacaoPorto = model.q7504,
                IdEspacoNav = model.q7505,
                NomeRio = model.q7505 == "Fluvial" ? model.q7506 : null,
                TipoGestPorto = model.q7507,
                IdResponsavel = model.q7508,
                NumAlvara = model.q7509,
                IdServico = model.q7510,
                Contacto = model.q7511,
                Email = model.q7512,
                Website = model.q7513,
                NumeEmbarcOperamRegularmente = Int32.Parse(model.q7514),
                IdPercursosDisponiveis = model.q7515,
                TipoEstrutura = model.q7516,
                EstadoConservacao = model.q7517,
                TipoEstruturaCais = model.q7518,
                EstadoConservacaoCais = model.q7519,
                FreqServicoTransMaritimo = model.q7520,
                TipoServico = model.q7521,
                HorarioBilheteira = model.q7522,
                DisponibilidadeLugares = model.q7523,
                PrecoTitulosTransporte = model.q7524,
                DistanciaPercursosFreq = model.q7525,
                TempoMPercFreq = model.q7526,
                LocalizacaoPorto = model.q7527,
                FotografiaGeral = model.q7528,
                FotografiaCais = model.q7529,
                FotografiaEmbarcações = model.q7530,
                Observacoes = model.q7531,
            };
        }
    }
}
