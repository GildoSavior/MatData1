using MatData.Models.Records;
using MatData.ViewModels;
using System;

namespace MatData.Serialization
{
    public static class Q66Mapper
    {
        public static Q66Model Serialize(Q66Record model)
        {
            return new Q66Model
            {
              IdAreaEARD = model.q6606,
              SuperficieEstabilizEARD = double.Parse(model.q6607),
              LocalAreaEstabilizEARD = model.q6608,
              FotografiaFrontal1 = model.q6609,
              FotografiaOutra2 = model.q6610,
              IdZonaRZR = model.q6611,
              SuperficieRecuperadaRZR = double.Parse(model.q6612),
              LocalZonaRecRZR = model.q6613,
              FotografiaFrontal1RZR = model.q6614,
              FotografiaOutraRZR2 = model.q6615,
              IdZonaDRCA = model.q6616,
              CursoRegularizadoDRCA = double.Parse(model.q6617),
              LocalCursoAIntervencionadoDRCA = model.q6618,
              FotografiaFrontalDRCA = model.q6619,
              FotografiaOutraDRCA = model.q6620,
              IdZonaIIA = model.q6621,
              TipologiaActoIIAControl = model.q6622,
              LocalZonaControladaIIA = model.q6623,
              FotografiaIIA1 = model.q6624,
              FotografiaIIA2 = model.q6625,
              IdZonaCPRZRA = model.q6626,
              TipoRiscIdentCPRZRA = model.q6627,
              LocalZonaCPRZRA = model.q6628,
              FotografiaCPRZRA1 = model.q6629,
              FotografiaCPRZRA2 = model.q6630,
              NumHabSituacaoRisAmb = Int32.Parse(model.q6631),
              NumAgregFamSitRisAmb = Int32.Parse(model.q6632),
              NumTotalPessoasSitRisAmb = Int32.Parse(model.q6633),
              ExistProjecInterPreserAmb = model.q6634,
              NomeProjectInterPreserAmb = model.q6634 == "Sim" ? model.q6635 : null,
              EntidadeRespImplemenProjectPreserAmb = model.q6634 == "Sim" ? model.q6636 : null,
              IdServico = model.q6634 == "Sim" ? model.q6637 : null,
              ContactoTelefonico = model.q6634 == "Sim" ? model.q6638 : null,
              Email = model.q6634 == "Sim" ? model.q6639 : null,
              Website = model.q6634 == "Sim" ? model.q6640 : null,
              AmbitoInterProjectAmb = model.q6634 == "Sim" ? model.q6641 : null,
              NumPessoasEntidadEnvolvRegularProj = model.q6634 == "Sim" ? Int32.Parse(model.q6642) : 0,
              NumPessoasComuniEnvolProjecto = model.q6634 == "Sim" ? Int32.Parse(model.q6643) : 0,
              Observacoes = model.q6644,

    };
        }
    }
}
