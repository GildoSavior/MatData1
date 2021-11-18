using MatData.Models.Records;
using MatData.ViewModels;
using System;

namespace MatData.Serialization
{
    public static class Q86Mapper
    {
        public static Q86Model Serialize(Q86Record model)
        {
            return new Q86Model
            {
                NomeUnPrestServicos = model.q8606,
                DataFundacao = model.q8607,
                EstadoFuncional = model.q8608,
                Nacionalidade = model.q8609,
                FormJuridica = model.q8610,
                TipoInstalOperador = model.q8611,
                TipoEstruturaEmpresarial = model.q8612,
                PrincipalActividade = model.q8613,
                LocalUnidade = model.q8614,
                FotoFrontal = model.q8615,
                FotoInterior = model.q8616,
                AlvaraComercial = model.q8617,
                NumAlvara = model.q8618 == "Sim" ? model.q8618 : null,
                IdServico = model.q8619,
                Contacto = model.q8620,
                Email = model.q8621,
                Website = model.q8622,
                //Acesso a Sistemas de Apoio à actividade de Prestação de Serviços
                SisApoioBeneficiou  = model.q8623,
                IdEntidadesApoio  = model.q8624,
                ValCredSectorAnoCorr  = double.Parse(model.q8625),
                ValCredSectorUltimos5Anos  = double.Parse(model.q8626),
                //Movimento Associativo  = model.q860,
                PertenceAssociacao = model.q8627,
                IdAssociacao = model.q8627 == "Sim" ? model.q8628 : null,
                PrincipBeneficios = model.q8627 == "Sim" ? model.q8629 : null,
                //Indicadores do Negócio  = model.q860,
                NumClientes = Int32.Parse(model.q8630),
                NumMensalCliente = Int32.Parse(model.q8631),
                DespesasMensais = double.Parse(model.q8632),
                ReceitasMensais = double.Parse(model.q8633),
                LucroMensal = double.Parse(model.q8634),
                ContabilidadeOrganizada = model.q8635,
                VolumeNegocios = model.q8635 == "Sim" ? double.Parse(model.q8636) : 0,
                SituacaoTributRegularizada = model.q8635 == "Sim" ? model.q8637 : null,
                ValorLiqImpostos = model.q8635 == "Sim" ? double.Parse(model.q8638) : 0,
                //Força de Trabalho = model.q860,
                NumDirProd = Int32.Parse(model.q8639),
                NumEspecialistas = Int32.Parse(model.q8640),
                NumTecIntermedios = Int32.Parse(model.q8641),
                NumAdmEquiparados = Int32.Parse(model.q8642),
                NumTrabServicosProteccao = Int32.Parse(model.q8643),
                NumTrabQualificadosCulturas = Int32.Parse(model.q8644),
                NumTrabQualificadosConstrucao = Int32.Parse(model.q8645),
                NumOperVeiculos = Int32.Parse(model.q8646),
                NumTrabNaoQualificados = Int32.Parse(model.q8647),
                PrincipConstraIdentificados = model.q8649,
                Observacoes = model.q8650,

            };
        }

    }
}