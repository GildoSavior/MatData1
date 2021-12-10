﻿using MatData.Models.Records;
using MatData.ViewModels;
using System;

namespace MatData.Serialization
{
    public static class Q82Mapper
    {
        public static Q82Model Serialize(Q82Record model)
        {
            return new Q82Model
            {
                NomeOperadorIndustrial = model.q8206,
                DataFundacao = model.q8207,
                EstadoFuncional = model.q8208,
                Nacionalidade = model.q8209,
                FormaJuridica = model.q8210,
                TipoMateriaPrimaExplorado = model.q8211,
                TipoExploracao = model.q8212,
                LocalizacaoEntidade = model.q8213,
                FotoFrontal = model.q8214,
                FotoInterior = model.q8215,
                FotoMateriaPrima = model.q8216,
                EntidadeLicenciada = model.q8217,
                NumAlvara = model.q8217 == "Sim" ? model.q8218 : null,
                EntidadeCertificacaoAmbiental = model.q8219,
                NumCertificacao = model.q8219 == "Sim" ? model.q8220 : null,
                IdServico = model.q8221,
                Contacto = Int32.Parse(model.q8222),
                Email = model.q8223,
                Website = model.q8224,
                PercentMateriaPrimaTransformada = double.Parse(model.q8225),
                //Acesso a Sistemas de Apoio à actividade extractiva = model.q820,
                SisApoioBeneficiou = model.q8226,
                IdEntidadesApoio = model.q8227,
                ValCredSectorAnoCorr = model.q8228,
                ValCredSectorUltimos5Anos = model.q8229,
                //Movimento Associativo = model.q820,
                PertenceAssociacao = model.q8230,
                IdAssociacao = model.q8230 == "Sim" ? model.q8231 : null,
                PrincipaisBenef = model.q8230 == "Sim" ? model.q8232 : null,
                //Actividade Extractiva = model.q820,
                MateriaPrimaExtraida = model.q8233,
                IdLocaisExploracao = model.q8234,
                //Matéria - prima mais extraída(MPME) = model.q820,
                IdMateriaPrimaMPME = model.q8235,
                IdlocaisExtraccaoMPME = model.q8236,
                QtdMPMEExtraidaAnoTransactoMPME = model.q8237,
                QtdMPMETrimestralmenteMPME = model.q8238,
                CustosExtraccaoMPUnMPME = double.Parse(model.q8239),
                ValVendaMPUnMPME = double.Parse(model.q8240),
                PrecoComercializacaoUnMPME = double.Parse(model.q8241),
                //Segunda matéria - prima mais extraída(SMPE) = model.q820,
                IdMateriaPrimaSMPE = model.q8242,
                IdlocaisExtraccaoSMPE = model.q8243,
                QtdMPMEExtraidaAnoTransactoSMPE = model.q8244,
                QtdMPMETrimestralmenteSMPE = model.q8245,
                CustosExtraccaoMPUnSMPE = double.Parse(model.q8246),
                ValVendaMPUnSMPE = double.Parse(model.q8247),
                PrecoComercializacaoUnSMPE = double.Parse(model.q8248),
                //Terceira matéria - prima mais extraída(TMPE) = model.q820,
                IdMateriaPrimaTMPE = model.q8249,
                IdlocaisExtraccaoTMPE = model.q8250,
                QtdMPMEExtraidaAnoTransactoTMPE = model.q8251,
                QtdMPMETrimestralmenteTMPE = model.q8252,
                CustosExtraccaoMPUnTMPE = model.q8243,
                ValVendaMPUnTMPE = model.q8254,
                PrecoComercializacaoUnTMPE = model.q8255,
                //Escoamento da matéria-prima e condições de armazenamento e transporte = model.q820,
                NVeiculosPropriosEscoamento = Int32.Parse(model.q8256),
                NVeiculosContratualizadosAnoTransactoEscoamento = Int32.Parse(model.q8257),
                PrincipDestinosEscoamento = model.q8258,
                //Indicadores do Negócio = model.q820,
                NumClientes = Int32.Parse(model.q8259),
                NumMensalCliente = Int32.Parse(model.q8260),
                DespesasMensais = model.q8261,
                ReceitasMensais = model.q8262,
                LucroMensal = model.q8263,
                ContabilidadeOrganizada = model.q8264,
                VolumeNegocios = model.q8264 == "Sim" ? model.q8265 : null,
                SituacaoTributRegularizada = model.q8264 == "Sim" ? model.q8266 : null,
                ValorLiqImpostos = model.q8264 == "Sim" ? model.q8267 : null,
                //Força de Trabalho = model.q820,
                NumDirProd = Int32.Parse(model.q8268),
                NumEspecialistas = Int32.Parse(model.q8269),
                NumTecIntermedios = Int32.Parse(model.q8270),
                NumAdmEquiparados = Int32.Parse(model.q8271),
                NumTrabServicosProteccao = Int32.Parse(model.q8272),
                NumTrabQualificadosCulturas = Int32.Parse(model.q8273),
                NumTrabQualificadosConstrucao = Int32.Parse(model.q8274),
                NumOperVeiculos = Int32.Parse(model.q8275),
                NumTrabNaoQualificados = Int32.Parse(model.q8276),
                PrincipConstraIdentificados = model.q8278,
                Observacoes = model.q8279,

            };
        }
    }
}
