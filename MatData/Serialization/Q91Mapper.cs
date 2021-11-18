using MatData.Models.Records;
using MatData.ViewModels;
using System;

namespace MatData.Serialization
{
    public static class Q91Mapper
    {
        public static Q91Model Serialize(Q91Record model)
        {
            return new Q91Model
            {
                NomeUnPrestServicos = model.q9106,
                DataFundacao = model.q9107,
                EstadoFuncional = model.q9108,
                Nacionalidade = model.q9109,
                FormJuridica = model.q9110,
                TipoInstalOperador = model.q9111,
                TipoEstruturaEmpresarial = model.q9112,
                PrincipalActividade = model.q9113,
                LocalUnidade = model.q9114,
                FotoFrontal = model.q9115,
                FotoInterior = model.q9116,
                AlvaraComercial = model.q9117,
                NumAlvara = model.q9118 == "Sim" ? model.q9118 : null,
                IdServico = model.q9119,
                Contacto = model.q9120,
                Email = model.q9121,
                Website = model.q9122,
                //Acesso a Sistemas de Apoio à actividade de Prestação de Serviços
                SisApoioBeneficiou = model.q9123,
                IdEntidadesApoio = model.q9124,
                ValCredSectorAnoCorr = double.Parse(model.q9125),
                ValCredSectorUltimos5Anos = double.Parse(model.q9126),
                //Movimento Associativo  = model.q860,
                PertenceAssociacao = model.q9127,
                IdAssociacao = model.q9127 == "Sim" ? model.q9128 : null,
                PrincipBeneficios = model.q9127 == "Sim" ? model.q9129 : null,
                //Indicadores do Negócio  = model.q860,
                NumClientes = Int32.Parse(model.q9130),
                NumMensalCliente = Int32.Parse(model.q9131),
                DespesasMensais = double.Parse(model.q9132),
                ReceitasMensais = double.Parse(model.q9133),
                LucroMensal = double.Parse(model.q9134),
                ContabilidadeOrganizada = model.q9135,
                VolumeNegocios = model.q9135 == "Sim" ? double.Parse(model.q9136) : 0,
                SituacaoTributRegularizada = model.q9135 == "Sim" ? model.q9137 : null,
                ValorLiqImpostos = model.q9135 == "Sim" ? double.Parse(model.q9138) : 0,
                //Força de Trabalho = model.q860,
                NumDirProd = Int32.Parse(model.q9139),
                NumEspecialistas = Int32.Parse(model.q9140),
                NumTecIntermedios = Int32.Parse(model.q9141),
                NumAdmEquiparados = Int32.Parse(model.q9142),
                NumTrabServicosProteccao = Int32.Parse(model.q9143),
                NumTrabQualificadosCulturas = Int32.Parse(model.q9144),
                NumTrabQualificadosConstrucao = Int32.Parse(model.q9145),
                NumOperVeiculos = Int32.Parse(model.q9146),
                NumTrabNaoQualificados = Int32.Parse(model.q9147),
                PrincipConstraIdentificados = model.q9149,
                Observacoes = model.q9150,

            };
        }
    }
}
