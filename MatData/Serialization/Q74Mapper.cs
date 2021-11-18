using MatData.Models.Records;
using MatData.ViewModels;
using System;

namespace MatData.Serialization
{
    public static class Q74Mapper
    {
        public static Q74Model Serialize(Q74Record model)
        {
            return new Q74Model
            {
                NomeEstacaoFerr = model.q7404,
                EstrutEstacaoFerr = model.q7405,
                EstadoConserv = model.q7406,
                FreqServTransFerr = model.q7407,
                TipoServTransFerr = model.q7408,
                HorarioBilheteira = model.q7409,
                DispLugaresPassagem = model.q7410,
                PrecoTitTransporte = model.q7411,
                LocalEstacaoFerr = model.q7412,
                FotografiaFrontal = model.q7413,
                FotografiaInterior = model.q7414,
                FotografiaComboioLinha = model.q7415,
                NumMPassagEmbarca = Int32.Parse(model.q7416),
                NumMPassagDesembarca = Int32.Parse(model.q7417),
                NumMPassagMensalEmbarca = Int32.Parse(model.q7418),
                NumMPassagMensalDesembarca = Int32.Parse(model.q7419),
                VolMCargaDespachada = double.Parse(model.q7420),
                VolMDescarregada = double.Parse(model.q7421),
                VolMCargaMensalDespachada = double.Parse(model.q7422),
                VolMCargaMensalDescarregada = double.Parse(model.q7423),
                DestinosFrequentes = model.q7424,
                PontosOrigemFrequentes = model.q7425,
                Observacoes = model.q7426,
            };
        }
    }
}
