using MatData.Models.Records;
using MatData.ViewModels;
using System;

namespace MatData.Serialization
{
    public static class Q85Mapper
    {
        public static Q85Model Serialize(Q85Record model)
        {
            return new Q85Model
            {
              NomeUnHoteleira = model.q8506,
              DataFundacao = model.q8507,
              EstadoFuncional = model.q8508,
              Nacionalidade = model.q8509,
              FormaJuridica = model.q8510,
              TipoInstalacoes = model.q8511,
              TipoEstrutEmpresarial = model.q8512,
              PrincipTipoActividade = model.q8513,
              LocalUnHoteleira = model.q8514,
              FotoFrontal = model.q8515,
              FotoInterior = model.q8516,
              AlvaraComercial = model.q8517,
              NumAlvara = model.q8517 == "Sim" ? model.q8518 : null,
              IdServico = model.q8519,
              Contacto = model.q8520,
              Email = model.q8521,
              Website = model.q8522,
              //Lotação dos serviços = model.q850,
              NumQuartos = Int32.Parse(model.q8523),
              NumCamas = Int32.Parse(model.q8524),
              NumMesas = Int32.Parse(model.q8525),
              NumCadeiras = Int32.Parse(model.q8526),
              NumTuristasNacionaisAnoTrans = Int32.Parse(model.q8527),
              NumMedTuristasNacionaisMes = Int32.Parse(model.q8528),
              NumTuristasEstrageirosAnoTrans = Int32.Parse(model.q8529),
              NumMedTuristasEstrageirosMes = Int32.Parse(model.q8530),
              TaxaMedOcupacaoAnoTrans = double.Parse(model.q8531),
              TaxaMedcupacaoMensal = double.Parse(model.q8532),
              //Acesso a Sistemas de Apoio à actividade comercial = model.q850,
              SisApoioBeneficiou = model.q8533,
              IdEntidadesApoio = model.q8534,
              ValCredSectorAnoCorr = double.Parse(model.q8535),
              ValCredSectorUltimos5Anos = double.Parse(model.q8536),
              //Movimento Associativo = model.q850,
              PertenceAssociacao = model.q8537,
              IdAssociacao = model.q8537 == "Sim" ? model.q8538 : null,
              PrincipBeneficios = model.q8537 == "Sim" ? model.q8539 : null,
              //Condições de armazenamento de stocks = model.q850,
              FormArmazenamento = model.q8540,
              ExistMeiosEspeciConserv = model.q8541,
              //Indicadores do Negócio = model.q850,
              NumClientes = Int32.Parse(model.q8542),
              NumMensalCliente = Int32.Parse(model.q8543),
              DespesasMensais = double.Parse(model.q8544),
              ReceitasMensais = double.Parse(model.q8545),
              LucroMensal = double.Parse(model.q8546),
              ContabilidadeOrganizada = model.q8547,
              VolumeNegocios = double.Parse(model.q8548),
              SituacaoTributRegularizada = model.q8549,
              ValorLiqImpostos = double.Parse(model.q8550),
              //Força de Trabalho = model.q850,
              NumDirProd = Int32.Parse(model.q8551),
              NumEspecialistas = Int32.Parse(model.q8552),
              NumTecIntermedios = Int32.Parse(model.q8553),
              NumAdmEquiparados = Int32.Parse(model.q8554),
              NumTrabServicosProteccao = Int32.Parse(model.q8555),
              NumTrabQualificadosCulturas = Int32.Parse(model.q8556),
              NumTrabQualificadosConstrucao = Int32.Parse(model.q8557),
              NumOperVeiculos = Int32.Parse(model.q8558),
              NumTrabNaoQualificados = Int32.Parse(model.q8559),
              PrincipConstraIdentificados = model.q8561,
              Observacoes = model.q8562,

            };
        }
    }
}
