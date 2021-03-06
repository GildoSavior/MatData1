using MatData.Models.Records;
using MatData.ViewModels;
using System;

namespace MatData.Serialization
{
    public static class Q80Mapper
    {
        public static Q80Model Serialize(Q80Record model)
        {
            return new Q80Model
            {
                NomeProdutor = model.q8006,
                DataFundacaoOpEco = model.q8007,
                EstadoFuncional = model.q8008,
                Nacionalidade = model.q8009,
                FormaJuridica = model.q8010,
                ClassificacaoProdutor = model.q8011,
                LocalExploPecuaria = model.q8012,
                FotoAcesso = model.q8013,
                FotoZonaAnimais1 = model.q8014,
                FotoZonaAnimais2 = model.q8015,
                NumTituloConcTerra = model.q8016,
                IdServico = model.q8017,
                Contacto = model.q8018,
                Email = model.q8019,
                Website = model.q8020,
                NumEfectBovinoCriAnoTrans = Int32.Parse(model.q8021),
                NumEfectOvinoCriAnoTrans = Int32.Parse(model.q8022),
                NumEfectSuinoCriAnoTrans = Int32.Parse(model.q8023),
                NumEfectAvesCriAnoTrans = Int32.Parse(model.q8024),
                //Acesso a Sistemas de Apoio à Produção(SAP) = model.q800,
                SAPBeneficiou = model.q8025,
                IdEntidadesApoio = model.q8026,
                ValSubscritoCredAgropecAnoCorr = double.Parse(model.q8027),
                ValSubscritoCredAgropecUltimos5Anos = double.Parse(model.q8028),
                //Movimento Associativo = model.q800,
                ProdutorPertenceAssoc = model.q8029,
                IdAssoc = model.q8028 == "Sim" ? model.q8030 : null,
                PrincipBeneficios = model.q8028 == "Sim" ? model.q8031 : null,
                ProdutorPertenceCoop = model.q8032,
                IdCooperativa = model.q8032 == "Sim" ? model.q8033 : null,
                PrincipaisBenefCoop = model.q8032 == "Sim" ? model.q8034 : null,
                //Produção anual = model.q800,
                NumEfectBovComercializadoVivo = Int32.Parse(model.q8035),
                NumEfectBovComercializadoAbatido = Int32.Parse(model.q8036),
                QtdCarneBovinaComercializada = double.Parse(model.q8037),
                NumEfectOvinoComercializadoVivo = Int32.Parse(model.q8038),
                NumEfectOvinoComercializadoAbatido = Int32.Parse(model.q8039),
                QtdCarneOvinaComercializada = double.Parse(model.q8040),
                NumEfectSuinoComercializadoVivo = Int32.Parse(model.q8041),
                NumEfectSuinoComercializadoAbatido = Int32.Parse(model.q8042),
                QtdCarneSuinaComercializada = double.Parse(model.q8043),
                NumEfectAvesComercializadoVivo = Int32.Parse(model.q8044),
                NumEfectAvesComercializadoAbatido = Int32.Parse(model.q8045),
                QtdCarneAvesComercializada = double.Parse(model.q8046),
                //Criação de maior produção CMP = model.q800,
                IdCMP = model.q8047,
                VolProdEspecieAnoTransactoCMP = Int32.Parse(model.q8048),
                CustoProdKgCMP = double.Parse(model.q8049),
                ValVendaProdKgAnimalVivoCMP = double.Parse(model.q8050),
                ValVendaProdKgCarneAbatidaCMP = double.Parse(model.q8051),
                ValVendaProdKgCarneDesmanchadaCMP = double.Parse(model.q8052),
                PrecoKgAnimalVivoComercializacaoCMP = double.Parse(model.q8053),
                PrecoKgCarneAbatidaComercializacaoCMP = double.Parse(model.q8054),
                PrecoKgCarneDesmanchadaComercializacaoCMP = double.Parse(model.q8055),
                //Criação de segunda maior produção (CSMP) = model.q800,
                IdCSMP = model.q8056,
                VolProdEspecieAnoTransactoCSMP = Int32.Parse(model.q8057),
                CustoProdKgCSMP = double.Parse(model.q8058),
                ValVendaProdKgAnimalVivoCSMP = double.Parse(model.q8059),
                ValVendaProdKgCarneAbatidaCSMP = double.Parse(model.q8060),
                ValVendaProdKgCarneDesmanchadaCSMP = double.Parse(model.q8061),
                PrecoKgAnimalVivoComercializacaoCSMP = double.Parse(model.q8062),
                PrecoKgCarneAbatidaComercializacaoCSMP = double.Parse(model.q8063),
                PrecoKgCarneDesmanchadaComercializacaoCSMP = double.Parse(model.q8064),
                //Criação de terceira maior produção(CTP) = model.q800,
                IdCTP = model.q8065,
                VolProdEspecieAnoTransactoCTP = Int32.Parse(model.q8066),
                CustoProdKgCTP = double.Parse(model.q8067),
                ValVendaProdKgAnimalVivoCTP = double.Parse(model.q8068),
                ValVendaProdKgCarneAbatidaCTP = double.Parse(model.q8069),
                ValVendaProdKgCarneDesmanchadaCTP = double.Parse(model.q8070),
                PrecoKgAnimalVivoComercializacaoCTP = double.Parse(model.q8071),
                PrecoKgCarneAbatidaComercializacaoCTP = double.Parse(model.q8072),
                PrecoKgCarneDesmanchadaComercializacaoCTP = double.Parse(model.q8073),
                //Escoamento da Produção = model.q800,
                NumVeiculosEscoamento = Int32.Parse(model.q8074),
                NumVeiculosContratualizadosCampEsc = Int32.Parse(model.q8075),
                GarantiaQualidadeAcondicionamento = model.q8076,
                PrincipDestinosEscoamento = model.q8077,
                //Controlo e vigilância sanitária e vacinação = model.q800,
                ExploracaoPecuaria = model.q8078,
                NumMedicosVeterinarios = Int32.Parse(model.q8079),
                NumTecZootecnica = Int32.Parse(model.q8080),
                PeriodVigiSanitaria = model.q8081,
                PeriodMonitorCondSaude = model.q8082,
                PercentAnimaisVacinados = double.Parse(model.q8083),
                //Condições de abate e desmanche = model.q800,
                ExplorPecuariaPossuiInstalacoes = model.q8084,
                ExplorPecuariaRecorMatExternos = model.q8085,
                ExplorPecuariaGanadariaPossuiInstal = model.q8086,
                ExplorPecuariaGanadariaRecorreServExt = model.q8087,
                //Corredores de Transumância = model.q800,
                GadoTransumancia = model.q8088,
                DefRotaTransumancia = model.q8088 == "Sim" ? model.q8089 : null,
                NumManadasTransumancia = model.q8088 == "Sim" ? Int32.Parse(model.q8090) : 0,
                NumMAnimaisPassamMuni = model.q8088 == "Sim" ? Int32.Parse(model.q8091) : 0,
                //Sub - produtos à Criação Pecuária = model.q800,
                QtdLeiteBovino = double.Parse(model.q8092),
                QtdLeiteOvino = double.Parse(model.q8093),
                QtdOvos = Int32.Parse(model.q8094),
                QtdOutrosSubProdutos = model.q8095,
                //Indicadores do Negócio = model.q800,
                NumClientesAnoTrans = Int32.Parse(model.q8096),
                NumMMensCliente = Int32.Parse(model.q8097),
                DespesasMMensais = double.Parse(model.q8098),
                ReceitasMMensais = double.Parse(model.q8099),
                LucroMMensal = double.Parse(model.q80100),
                ContabilidadeOrganizada = model.q80101,
                VolNegocios = model.q80101 == "Sim" ? double.Parse(model.q80102) : 0,
                SituacaoTribRegularizada = model.q80101 == "Sim" ? model.q80103 : null,
                ValLiquImpostos = model.q80101 == "Sim" ? double.Parse(model.q80104) : 0,
                //Força de Trabalho = model.q800,
                NumDirProd = Int32.Parse(model.q80105),
                NumEspecialistas = Int32.Parse(model.q80106),
                NumTecIntermedios = Int32.Parse(model.q80107),
                NumAdmEquiparados = Int32.Parse(model.q80108),
                NumTrabServicosProteccao = Int32.Parse(model.q80109),
                NumTrabQualificadosCulturas = Int32.Parse(model.q80110),
                NumTrabQualificadosConstrucao = Int32.Parse(model.q80111),
                NumOperVeiculos = Int32.Parse(model.q80112),
                NumTrabNaoQualificados = Int32.Parse(model.q80113),
                PrincipConstraIdentificados = model.q80115,
                Observacoes = model.q80116,
            };
        }
    }
}
