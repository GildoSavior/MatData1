using MatData.Models.Records;

namespace MatData.Serialization
{
    public class Q15Mapper
    {
        public static Q15Model Serialize(Q15Record model)
        {
            return new Q15Model
            {
                LinguaNacionalOrigemAfricana = model.q1505,
                GrupoEtnoLinguisticosPresentesComunidade = model.q1506,
                ExistenciaReinadosOuPrincipadosOrientacao = model.q1507,
                NomeReisOuRainhasNaOrientacaoComunidade = model.q1508,
                DescritivoCaracteristicasReinadosPrincipados = model.q1509,
                DescritivoAspectosAssociadosAOrgEtnicaComunidade = model.q1510,
                ExistenciaFigurasEtnicasReferenciaComunidade = model.q1511,
                NomeOuPostoDasFigurasEtnicasReferenciaComunidade = model.q1512,
                FestejosEtnograficosRegularesComunidade = model.q1513,
                PraticasRaizEtnicaPresentesNaComunidade = model.q1514,
                DescricaoUtilizacaoPlantasLocais = model.q1515,
                Observacoes = model.q1516
            };
        }
    }
}
