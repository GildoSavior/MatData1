using MatData.Models.Records;
using MatData.ViewModels;
using System;

namespace MatData.Serialization
{
    public static class Q87Mapper
    {
        public static Q87Model Serialize(Q87Record model)
        {
            return new Q87Model
            {
                NomeUnPrestServicos = model.q8706,
                DataFundacao = model.q8707,
                EstadoFuncional = model.q8708,
                Nacionalidade = model.q8709,
                FormJuridica = model.q8710,
                TipoInstalOperador = model.q8711,
                TipoEstruturaEmpresarial = model.q8712,
                PrincipalActividade = model.q8713,
                LocalUnidade = model.q8714,
                FotoFrontal = model.q8715,
                FotoInterior = model.q8716,
                AlvaraComercial = model.q8717,
                NumAlvara = model.q8718 == "Sim" ? model.q8718 : null,
                IdServico = model.q8719,
                Contacto = model.q8720,
                Email = model.q8721,
                Website = model.q8722,
                //Acesso a Sistemas de Apoio à actividade de Prestação de Serviços
                SisApoioBeneficiou = model.q8723,
                IdEntidadesApoio = model.q8724,
                ValCredSectorAnoCorr = double.Parse(model.q8725),
                ValCredSectorUltimos5Anos = double.Parse(model.q8726),
                //Movimento Associativo  = model.q860,
                PertenceAssociacao = model.q8727,
                IdAssociacao = model.q8727 == "Sim" ? model.q8728 : null,
                PrincipBeneficios = model.q8727 == "Sim" ? model.q8729 : null,
                //Indicadores do Negócio  = model.q860,
                NumClientes = Int32.Parse(model.q8730),
                NumMensalCliente = Int32.Parse(model.q8731),
                DespesasMensais = double.Parse(model.q8732),
                ReceitasMensais = double.Parse(model.q8733),
                LucroMensal = double.Parse(model.q8734),
                ContabilidadeOrganizada = model.q8735,
                VolumeNegocios = model.q8735 == "Sim" ? double.Parse(model.q8736) : 0,
                SituacaoTributRegularizada = model.q8735 == "Sim" ? model.q8737 : null,
                ValorLiqImpostos = model.q8735 == "Sim" ? double.Parse(model.q8738) : 0,
                //Força de Trabalho = model.q860,
                NumDirProd = Int32.Parse(model.q8739),
                NumEspecialistas = Int32.Parse(model.q8740),
                NumTecIntermedios = Int32.Parse(model.q8741),
                NumAdmEquiparados = Int32.Parse(model.q8742),
                NumTrabServicosProteccao = Int32.Parse(model.q8743),
                NumTrabQualificadosCulturas = Int32.Parse(model.q8744),
                NumTrabQualificadosConstrucao = Int32.Parse(model.q8745),
                NumOperVeiculos = Int32.Parse(model.q8746),
                NumTrabNaoQualificados = Int32.Parse(model.q8747),
                PrincipConstraIdentificados = model.q8749,
                Observacoes = model.q8750,

            };
        }
    }
}
