using MatData.Models.Records;
using MatData.ViewModels;
using System;

namespace MatData.Serialization
{
    public static class Q93Mapper
    {
        public static Q93Model Serialize(Q93Record model)
        {
            return new Q93Model
            {
                //Actividade de Subsistência / Familiar {get;set;}
                NumHomensJovens1535OcupamActivSubsisNatureza = Int32.Parse(model.q9306),
                NumMulheresJovensOcupamActivSubsisNatureza = Int32.Parse(model.q9307),
                NumHomensAdultos3560OcupamActivSubsisNatureza = Int32.Parse(model.q9309),
                NumMulheresAdultas3560OcupamActivSubsisNatureza  = Int32.Parse(model.q9310),
                NumHomensAdultosMais60AnosOcupamActivSubsisNatureza = Int32.Parse(model.q9312),
                NumMulheresAdultasMais60AnosOcupamActivSubsisNatureza = Int32.Parse(model.q9313),
                //Actividade Económica Formal - Operadores Económicos do Sector Primário(Agricultura, Pecuária, PeInt32.Parse(scas eq Mar))
                NumHomensJovens1535ServicosOperadoresEcoSectorPrimario = Int32.Parse(model.q9318),
                NumMulheresJovens1535PrestamServicosOperadoresEcoSectorPrimario = Int32.Parse(model.q9319),
                NumHomensAdultos3560PrestamServicosOperEcoSectorPrimario = Int32.Parse(model.q9321),
                NumMulheresAdultas3560PrestamServicosOperadoresEcoSectorPrimario = Int32.Parse(model.q9322),
                NumHomensAdultosMais60AnosPrestamServicosOperadoresEcoSectorPrimario = Int32.Parse(model.q9324),
                NumMulheresAdultasMais60AnosPrestamServicosOperadoresEcoSectorPrimario = Int32.Parse(model.q9325),
                //Actividade Económica Formal - Operadores Económicos do Sector dInt32.Parse(a Indúqstri)a
                NumHomensJovens1535PrestamServicosOperadoresEcoIndustria = Int32.Parse(model.q9330),
                NumMulheresJovens1535PrestamServicosOperadoresEcoIndustria = Int32.Parse(model.q9331),
                NumHomensAdultos3560PrestamServicosOperadoresEcoIndustria  = Int32.Parse(model.q9333),
                NumMulheresAdultas3560PrestamServicosOperadoresEcoIndustria = Int32.Parse(model.q9334),
                NumHomensAdultosMais60AnosPrestamServicosOperadoresEcoIndustria = Int32.Parse(model.q9336),
                NumMulheresAdultasMais60AnosPrestamServicosOperadoresEcoIndustria = Int32.Parse(model.q9337),
                //Actividade Económica Formal - Operadores Económicos do Sector Int32.Parse(do Comqérci)o
                NumHomensJovens1535PrestamServicosOperadoresEcoComercio = Int32.Parse(model.q9342),
                NumMulheresJovens1535PrestamServicosOperadoresEcoComercio = Int32.Parse(model.q9343),
                NumHomensAdultos3560AnosPrestamServicosOperadoresEcoComercio  = Int32.Parse(model.q9345),
                NumMulheresAdultas3560PrestamServicosOperadoresEcoComercio = Int32.Parse(model.q9346),
                NumHomensAdultosMais60AnosPrestamServicosOperadoresEcoComercio = Int32.Parse(model.q9348),
                NumMulheresAdultasMais60AnosPrestamServicosOperadoresEcoComercio = Int32.Parse(model.q9349),
                //Actividade Económica Formal - Operadores Económicos do Sector da Hotelaria, Restauração Int32.Parse(e Simiqlare)s
                NumHomensJovens1535PrestamServicosOperadoresEcoHotelaria = Int32.Parse(model.q9354),
                NumMulheresJovens1535PrestamServicosOperadoresEcoHotelaria = Int32.Parse(model.q9355),
                NumHomensAdultos3560PrestamServicosOperadoresEcoHotelaria = Int32.Parse(model.q9357),
                NumMulheresAdultas3560PrestamServicosOperadoresEcoHotelaria = Int32.Parse(model.q9358),
                NumHomensAdultosMais60AnosPrestamServicosOperadoresEcoHotelaria = Int32.Parse(model.q9360),
                NumMulheresAdultasMais60AnosPrestamServicosOperadoresEcoHotelaria = Int32.Parse(model.q9361),
                //Actividade Económica Formal - Operadores Económicos do Sector doInt32.Parse(s Servqiços) 
                NumHomensJovens1535PrestamServicosOperadoresEcoServicos = Int32.Parse(model.q9366),
                NumMulheresJovens1535PrestamServicosOperadoresEcoServicos = Int32.Parse(model.q9367),
                NumHomensAdultos3560PrestamServicosOperadoresEcoServicos = Int32.Parse(model.q9369),
                NumMulheresAdultas3560PrestamServicosOperadoresEcoServicos = Int32.Parse(model.q9370),
                NumHomensAdultosMais60AnosPrestamServicosOperadoresEcoServicos = Int32.Parse(model.q9372),
                NumMulheresAdultasMais60AnosPrestamServicosOperadoresEcoServicos = Int32.Parse(model.q9373),
                //Actividade Económica Formal - Sector da FunInt32.Parse(ção Púqblic)a
                NumHomensJovens1535PrestamServicosFuncaoPublica = Int32.Parse(model.q9378),
                NumMulheresJovens1535PrestamServicosFuncaoPublica = Int32.Parse(model.q9379),
                NumHomensAdultos3560PrestamServicosFuncaoPublica = Int32.Parse(model.q9381),
                NumMulheresAdultas3560PrestamServicosFuncaoPublica = Int32.Parse(model.q9382),
                NumHomensAdultosMais60AnosPrestamServicosFuncaoPublica = Int32.Parse(model.q9384),
                NumMulheresAdultasMais60AnosPrestamServicosFuncaoPublica = Int32.Parse(model.q9385),
                //Actividade Económica não reInt32.Parse(gulameqntad)a
                NumHomensJovens1535TiveramOcupacaoRemuneradaUltimaSemanaContratoEscrito = Int32.Parse(model.q9390),
                NumMulheresJovens1535TiveramOcupacaoRemuneradaUltimaSemanaSemContratoEscrito = Int32.Parse(model.q9391),
                NumHomensJovens1535CujaOcupacaoNaoEncontraRegistadaOrgaosPublicos = Int32.Parse(model.q9393),
                NumMulheresJovens1535CujaOcupacaoNaoEncontraRegistadaOrgaosPublicos = Int32.Parse(model.q9394),
                NumHomensJovens1535NaoBeneficiamQualquerApoioSocialSuaOcupacao = Int32.Parse(model.q9396),
                NumMulheresJovens1535NaoBeneficiamQualquerApoioSocialSuaOcupacao = Int32.Parse(model.q9397),
                NumHomensJovens1535NaoInscritosINSS = Int32.Parse(model.q9399),
                NumMulheresJovens1535NaoInscritosINSS = Int32.Parse(model.q93100),
                NumHomensAdultos3560TiveramOcupacaoRemuneradaUltimaSemanaSemContratoEscrito = Int32.Parse(model.q93102),
                NumMulheresAdultas3560TiveramOcupacaoRemuneradaUltimaSemanaSemContratoEscrito = Int32.Parse(model.q93103),
                NumHomensAdultos3560CujaOcupacaoNaoEncontraRegistadaOrgaosPublicos = Int32.Parse(model.q93105),
                NumMulheresAdultas3560CujaOcupacaoNaoEncontraRegistadaOrgaosPublicos = Int32.Parse(model.q93106),
                NumHomensAdultos3560NaoBeneficiamQualquerApoioSocialOcupacao = Int32.Parse(model.q93108),
                NumMulheresAdultas3560NaoBeneficiamQualquerApoioSocialOcupacao = Int32.Parse(model.q93109),
                NumHomensAdultos3560NaoInscritosINSS = Int32.Parse(model.q93111),
                NumMulheresAdultas3560NaoEstaoInscritosINSS = Int32.Parse(model.q93112),
                NumHomensAdultosMaior60AnosTiveramOcupacaoRemuneradaUltimaSemanaSemContratoEscrito = Int32.Parse(model.q93114),
                NumMulheresAdultasMaior60TiveramOcupacaoRemuneradaUltimaSemanaSemContratoEscrito = Int32.Parse(model.q93115),
                NumHomensAdultosMaior60CujaOcupacaoNaoEncontraRegistadaOrgaosPublicos = Int32.Parse(model.q93117),
                NumMulheresAdultasMaior60CujaOcupacaoNaoEncontraRegistadaOrgaosPublicos = Int32.Parse(model.q93118),
                NumHomensAdultosMaior60NaoBeneficiamQualquerApoioSocialOcupacao = Int32.Parse(model.q93120),
                NumMulheresAdultasMaior60NaoBeneficiamQualquerApoioSocialOcupacao = Int32.Parse(model.q93121),
                NumHomensAdultosMaior60NaoEstaoInscritosINSS = Int32.Parse(model.q93123),
                NumMulheresAdultasMaior60NaoEstaoInscritosINSS = Int32.Parse(model.q93124),

    };
        }
    }
}
