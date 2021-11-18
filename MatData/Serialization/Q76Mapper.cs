using MatData.Models.Records;
using MatData.ViewModels;
using System;

namespace MatData.Serialization
{
    public class Q76Mapper
    {
        public static Q76Model Serialize(Q76Record model)
        {
            return new Q76Model
            {
                NomeAreaSuporte = model.q7604,
                TipoArea = model.q7605,
                TipoGestAreaSuporte = model.q7606,
                IdResponsavel = model.q7607,
                NumLicença = model.q7608,
                IdServico = model.q7609,
                Contacto = model.q7610,
                Email = model.q7611,
                Website = model.q7612,
                LocalArea = model.q7613,
                FotografiaArea = model.q7614,
                FotografiaLocalEmbarqu = model.q7615,
                FotografiaAeronaves = model.q7616,
                OperacoesArea = model.q7617,
                AreSuportTransAereos = model.q7618,
                NumAeronaves = model.q7618 == "Sim" ? Int32.Parse(model.q7619) : 0,
                Companhias = model.q7618 == "Sim" ? model.q7620 : null,
                IdTipologiaPercursos = model.q7618 == "Sim" ? model.q7621 : null,
                TipEstruturArea = model.q7618 == "Sim" ? model.q7622 : null,
                EstadoConservArea = model.q7618 == "Sim" ? model.q7623 : null,
                TipoEstruturaCais = model.q7618 == "Sim" ? model.q7624 : null,
                EstadoConservCais = model.q7618 == "Sim" ? model.q7625 : null,
                FreqServico = model.q7618 == "Sim" ? model.q7626 : null,
                TipoServico = model.q7618 == "Sim" ? model.q7627 : null,
                HorarioBilheteira = model.q7618 == "Sim" ? model.q7628 : null,
                DisponibilidadeLugares = model.q7618 == "Sim" ? model.q7629 : null,
                PrecoTitulos = model.q7618 == "Sim" ? model.q7630 : null,
                IdPercursosFreq = model.q7618 == "Sim" ? model.q7631 : null,
                DistanciaPercFrequente = model.q7618 == "Sim" ? model.q7632 : null,
                TempoMPercFrequente = model.q7618 == "Sim" ? model.q7633 : null,
                Observacoes = model.q7634,
            };
        }
    }
}
