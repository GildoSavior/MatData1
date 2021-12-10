using MatData.Models.Records;
using MatData.ViewModels;
using System;

namespace MatData.Serialization
{
    public static class Q89Mapper
    {
        public static Q89Model Serialize(Q89Record model)
        {
            return new Q89Model
            {
                NomeUnPrestServicos = model.q8906,
                DataFundacao = model.q8907,
                EstadoFuncional = model.q8908,
                Nacionalidade = model.q8909,
                FormJuridica = model.q8910,
                TipoInstalOperador = model.q8911,
                TipoEstruturaEmpresarial = model.q8912,
                PrincipalActividade = model.q8913,
                LocalUnidade = model.q8914,
                FotoFrontal = model.q8915,
                FotoInterior = model.q8916,
                AlvaraComercial = model.q8917,
                NumAlvara = model.q8918 == "Sim" ? model.q8918 : null,
                IdServico = model.q8919,
                Contacto = model.q8920,
                Email = model.q8921,
                Website = model.q8922,
                //Acesso a Sistemas de Apoio à actividade de Prestação de Serviços
                SisApoioBeneficiou = model.q8923,
                IdEntidadesApoio = model.q8924,
                ValCredSectorAnoCorr = double.Parse(model.q8925),
                ValCredSectorUltimos5Anos = double.Parse(model.q8926),
                //Movimento Associativo  = model.q860,
                PertenceAssociacao = model.q8927,
                IdAssociacao = model.q8927 == "Sim" ? model.q8928 : null,
                PrincipBeneficios = model.q8927 == "Sim" ? model.q8929 : null,
                //Indicadores do Negócio  = model.q860,
                NumClientes = Int32.Parse(model.q8930),
                NumMensalCliente = Int32.Parse(model.q8931),
                DespesasMensais = double.Parse(model.q8932),
                ReceitasMensais = double.Parse(model.q8933),
                LucroMensal = double.Parse(model.q8934),
                ContabilidadeOrganizada = model.q8935,
                VolumeNegocios = model.q8935 == "Sim" ? double.Parse(model.q8936) : 0,
                SituacaoTributRegularizada = model.q8935 == "Sim" ? model.q8937 : null,
                ValorLiqImpostos = model.q8935 == "Sim" ? double.Parse(model.q8938) : 0,
                //Força de Trabalho = model.q860,
                NumDirProd = Int32.Parse(model.q8939),
                NumEspecialistas = Int32.Parse(model.q8940),
                NumTecIntermedios = Int32.Parse(model.q8941),
                NumAdmEquiparados = Int32.Parse(model.q8942),
                NumTrabServicosProteccao = Int32.Parse(model.q8943),
                NumTrabQualificadosCulturas = Int32.Parse(model.q8944),
                NumTrabQualificadosConstrucao = Int32.Parse(model.q8945),
                NumOperVeiculos = Int32.Parse(model.q8946),
                NumTrabNaoQualificados = Int32.Parse(model.q8947),
                PrincipConstraIdentificados = model.q8949,
                Observacoes = model.q8950,

            };
        }
    }
}
