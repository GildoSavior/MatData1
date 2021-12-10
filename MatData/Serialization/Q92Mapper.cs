using MatData.Models.Records;
using MatData.ViewModels;
using System;

namespace MatData.Serialization
{
    public static class Q92Mapper
    {
        public static Q92Model Serialize(Q92Record model)
        {
            return new Q92Model
            {
                NomeUnPrestServicos = model.q9206,
                DataFundacao = model.q9207,
                EstadoFuncional = model.q9208,
                Nacionalidade = model.q9209,
                FormJuridica = model.q9210,
                TipoInstalOperador = model.q9211,
                TipoEstruturaEmpresarial = model.q9212,
                PrincipalActividade = model.q9213,
                LocalUnidade = model.q9214,
                FotoFrontal = model.q9215,
                FotoInterior = model.q9216,
                AlvaraComercial = model.q9217,
                NumAlvara = model.q9218 == "Sim" ? model.q9218 : null,
                IdServico = model.q9219,
                Contacto = model.q9220,
                Email = model.q9221,
                Website = model.q9222,                
                //Indicadores do Negócio  = model.q860,
                NumClientes = Int32.Parse(model.q9223),
                NumMensalCliente = Int32.Parse(model.q9224),
                DespesasMensais = double.Parse(model.q9225),
                ReceitasMensais = double.Parse(model.q9226),
                LucroMensal = double.Parse(model.q9227),
                ContabilidadeOrganizada = model.q9228,
                VolumeNegocios = model.q9228 == "Sim" ? double.Parse(model.q9229) : 0,
                SituacaoTributRegularizada = model.q9228 == "Sim" ? model.q9230 : null,
                ValorLiqImpostos = model.q9228 == "Sim" ? double.Parse(model.q9231) : 0,
                //Força de Trabalho = model.q860,
                NumDirProd = Int32.Parse(model.q9232),
                NumEspecialistas = Int32.Parse(model.q9233),
                NumTecIntermedios = Int32.Parse(model.q9234),
                NumAdmEquiparados = Int32.Parse(model.q9235),
                NumTrabServicosProteccao = Int32.Parse(model.q9236),
                NumTrabQualificadosCulturas = Int32.Parse(model.q9237),
                NumTrabQualificadosConstrucao = Int32.Parse(model.q9238),
                NumOperVeiculos = Int32.Parse(model.q9239),
                NumTrabNaoQualificados = Int32.Parse(model.q9240),
                PrincipConstraIdentificados = model.q9242,
                Observacoes = model.q9243,

            };
        }
    }
}
