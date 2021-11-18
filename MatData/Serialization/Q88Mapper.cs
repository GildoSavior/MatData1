using MatData.Models.Records;
using MatData.ViewModels;
using System;

namespace MatData.Serialization
{
    public static class Q88Mapper
    {
        public static Q88Model Serialize(Q88Record model)
        {
            return new Q88Model
            {
                NomeUnPrestServicos = model.q8806,
                DataFundacao = model.q8807,
                EstadoFuncional = model.q8808,
                Nacionalidade = model.q8809,
                FormJuridica = model.q8810,
                TipoInstalOperador = model.q8811,
                TipoEstruturaEmpresarial = model.q8812,
                PrincipalActividade = model.q8813,
                LocalUnidade = model.q8814,
                FotoFrontal = model.q8815,
                FotoInterior = model.q8816,
                AlvaraComercial = model.q8817,
                NumAlvara = model.q8818 == "Sim" ? model.q8818 : null,
                IdServico = model.q8819,
                Contacto = model.q8820,
                Email = model.q8821,
                Website = model.q8822,
                //Acesso a Sistemas de Apoio à actividade de Prestação de Serviços
                SisApoioBeneficiou = model.q8823,
                IdEntidadesApoio = model.q8824,
                ValCredSectorAnoCorr = double.Parse(model.q8825),
                ValCredSectorUltimos5Anos = double.Parse(model.q8826),
                //Movimento Associativo  = model.q860,
                PertenceAssociacao = model.q8827,
                IdAssociacao = model.q8827 == "Sim" ? model.q8828 : null,
                PrincipBeneficios = model.q8827 == "Sim" ? model.q8829 : null,
                //Indicadores do Negócio  = model.q860,
                NumClientes = Int32.Parse(model.q8830),
                NumMensalCliente = Int32.Parse(model.q8831),
                DespesasMensais = double.Parse(model.q8832),
                ReceitasMensais = double.Parse(model.q8833),
                LucroMensal = double.Parse(model.q8834),
                ContabilidadeOrganizada = model.q8835,
                VolumeNegocios = model.q8835 == "Sim" ? double.Parse(model.q8836) : 0,
                SituacaoTributRegularizada = model.q8835 == "Sim" ? model.q8837 : null,
                ValorLiqImpostos = model.q8835 == "Sim" ? double.Parse(model.q8838) : 0,
                //Força de Trabalho = model.q860,
                NumDirProd = Int32.Parse(model.q8839),
                NumEspecialistas = Int32.Parse(model.q8840),
                NumTecIntermedios = Int32.Parse(model.q8841),
                NumAdmEquiparados = Int32.Parse(model.q8842),
                NumTrabServicosProteccao = Int32.Parse(model.q8843),
                NumTrabQualificadosCulturas = Int32.Parse(model.q8844),
                NumTrabQualificadosConstrucao = Int32.Parse(model.q8845),
                NumOperVeiculos = Int32.Parse(model.q8846),
                NumTrabNaoQualificados = Int32.Parse(model.q8847),
                PrincipConstraIdentificados = model.q8849,
                Observacoes = model.q8850,

            };
        }
    }
}
