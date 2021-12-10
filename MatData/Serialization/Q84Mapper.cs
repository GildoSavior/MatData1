using MatData.Models.Records;
using MatData.ViewModels;
using System;

namespace MatData.Serialization
{
    public static class Q84Mapper
    {
        public static Q84Model Serialize(Q84Record model)
        {
            return new Q84Model
            {
                NomeOperadorComercial = model.q8406,
                DataFundacao = model.q8407,
                EstadFuncional = model.q8408,
                Nacionalidade = model.q8409,
                FormaJuridica = model.q8410,
                TipoEstruturaEmpresarial = model.q8411,
                TipoActComercial = model.q8412,
                ClassifModelComerc = model.q8413,
                TipoLocalTransacçcao = model.q8414,
                LocalUnComercial = model.q8415,
                FotoFrontal = model.q8416,
                FotoInterior = model.q8417,
                AlvavaComercial = model.q8418,
                NumAlvara = model.q8418 == "Sim" ? model.q8419 : null,
                IdServico = model.q8420,
                Contacto = model.q8421,
                Email = model.q8422,
                Website = model.q8423,
                //Acesso a Sistemas de Apoio à actividade comercial = model.q840,
                SisApoioBeneficiou = model.q8424,
                IdEntidadesApoio = model.q8425,
                ValCredSectorAnoCorr = double.Parse(model.q8426),
                ValCredSectorUltimos5Anos = double.Parse(model.q8427),
                //Movimento Associativo = model.q840,
                PertenceAssociacao = model.q8428,
                IdAssociacao = model.q8428 == "Sim" ? model.q8429 : null,
                PrincipBeneficios = model.q8428 == "Sim" ? model.q8430 : null,
                //Condições de armazenamento dos produtos = model.q840,
                FormArmazenamento = model.q8431,
                ExistMeiosEspeciConserv = model.q8432,
                //Indicadores do Negócio = model.q840,
                NumClientes = Int32.Parse(model.q8433),
                NumMensalCliente = Int32.Parse(model.q8434),
                DespesasMensais  = double.Parse(model.q8435),
                ReceitasMensais  = double.Parse(model.q8436),
                LucroMensal  = double.Parse(model.q8437),
                ContabilidadeOrganizada = model.q8438,
                VolumeNegocios = model.q8438 == "Sim" ? double.Parse(model.q8439) : 0,
                SituacaoTributRegularizada = model.q8438 == "Sim" ? model.q8430 : null,
                ValorLiqImpostos = model.q8438 == "Sim" ? double.Parse(model.q8441) : 0,
                //Força de Trabalho = model.q840,
                NumDirProd = Int32.Parse(model.q8442),
                NumEspecialistas = Int32.Parse(model.q8443),
                NumTecIntermedios = Int32.Parse(model.q8444),
                NumAdmEquiparados = Int32.Parse(model.q8445),
                NumTrabServicosProteccao = Int32.Parse(model.q8446),
                NumTrabQualificadosCulturas = Int32.Parse(model.q8447),
                NumTrabQualificadosConstrucao = Int32.Parse(model.q8448),
                NumOperVeiculos = Int32.Parse(model.q8449),
                NumTrabNaoQualificados = Int32.Parse(model.q8450),
                PrincipConstraIdentificados = model.q8452,
                Observacoes = model.q8453,
            };
        }
    }
}
