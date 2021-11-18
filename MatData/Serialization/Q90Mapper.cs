using MatData.Models.Records;
using MatData.ViewModels;
using System;

namespace MatData.Serialization
{
    public static class Q90Mapper
    {
        public static Q90Model Serialize(Q90Record model)
        {
            return new Q90Model
            {
                NomeUnPrestServicos = model.q9006,
                DataFundacao = model.q9007,
                EstadoFuncional = model.q9008,
                Nacionalidade = model.q9009,
                FormJuridica = model.q9010,
                TipoInstalOperador = model.q9011,
                TipoEstruturaEmpresarial = model.q9012,
                PrincipalActividade = model.q9013,
                LocalUnidade = model.q9014,
                FotoFrontal = model.q9015,
                FotoInterior = model.q9016,
                AlvaraComercial = model.q9017,
                NumAlvara = model.q9018 == "Sim" ? model.q9018 : null,
                IdServico = model.q9019,
                Contacto = model.q9020,
                Email = model.q9021,
                Website = model.q9022,
                //Acesso a Sistemas de Apoio à actividade de Prestação de Serviços
                SisApoioBeneficiou = model.q9023,
                IdEntidadesApoio = model.q9024,
                ValCredSectorAnoCorr = double.Parse(model.q9025),
                ValCredSectorUltimos5Anos = double.Parse(model.q9026),
                //Movimento Associativo  = model.q860,
                PertenceAssociacao = model.q9027,
                IdAssociacao = model.q9027 == "Sim" ? model.q9028 : null,
                PrincipBeneficios = model.q9027 == "Sim" ? model.q9029 : null,
                //Indicadores do Negócio  = model.q860,
                NumClientes = Int32.Parse(model.q9030),
                NumMensalCliente = Int32.Parse(model.q9031),
                DespesasMensais = double.Parse(model.q9032),
                ReceitasMensais = double.Parse(model.q9033),
                LucroMensal = double.Parse(model.q9034),
                ContabilidadeOrganizada = model.q9035,
                VolumeNegocios = model.q9035 == "Sim" ? double.Parse(model.q9036) : 0,
                SituacaoTributRegularizada = model.q9035 == "Sim" ? model.q9037 : null,
                ValorLiqImpostos = model.q9035 == "Sim" ? double.Parse(model.q9038) : 0,
                //Força de Trabalho = model.q860,
                NumDirProd = Int32.Parse(model.q9039),
                NumEspecialistas = Int32.Parse(model.q9040),
                NumTecIntermedios = Int32.Parse(model.q9041),
                NumAdmEquiparados = Int32.Parse(model.q9042),
                NumTrabServicosProteccao = Int32.Parse(model.q9043),
                NumTrabQualificadosCulturas = Int32.Parse(model.q9044),
                NumTrabQualificadosConstrucao = Int32.Parse(model.q9045),
                NumOperVeiculos = Int32.Parse(model.q9046),
                NumTrabNaoQualificados = Int32.Parse(model.q9047),
                PrincipConstraIdentificados = model.q9049,
                Observacoes = model.q9050,

            };
        }
    }
}
