namespace MatData.ViewModels
{
    public class Q93Model
    {
        //Actividade de Subsistência / Familiar {get;set;}
        public int NumHomensJovens1535OcupamActivSubsisNatureza { get; set; }
        public int NumMulheresJovensOcupamActivSubsisNatureza { get; set; }
        public int NumTotalJovens1535OcupamActivSubsisNatureza
        {
            get { return NumHomensJovens1535OcupamActivSubsisNatureza + NumMulheresJovensOcupamActivSubsisNatureza; }
        }
        public int NumHomensAdultos3560OcupamActivSubsisNatureza { get; set; }
        public int NumMulheresAdultas3560OcupamActivSubsisNatureza { get; set; }
        public int NumTotalAdultos3560OcupamActivSubsisNatureza
        {
            get { return NumHomensAdultos3560OcupamActivSubsisNatureza + NumMulheresAdultas3560OcupamActivSubsisNatureza; }
        }
        public int NumHomensAdultosMais60AnosOcupamActivSubsisNatureza { get; set; }
        public int NumMulheresAdultasMais60AnosOcupamActivSubsisNatureza { get; set; }
        public int NumTotalAdultosMais60AnosOcupamActivSubsisNatureza
        {
            get { return NumHomensJovens1535OcupamActivSubsisNatureza + NumMulheresAdultasMais60AnosOcupamActivSubsisNatureza; }
        }
        public int NumHomensOcupamActivSubsisNatureza
        {
            get { return NumHomensAdultosMais60AnosOcupamActivSubsisNatureza + NumHomensAdultos3560OcupamActivSubsisNatureza + NumHomensAdultosMais60AnosOcupamActivSubsisNatureza; }
        }
        public int NumMulheresOcupamActivSubsisNatureza
        {
            get { return NumMulheresJovensOcupamActivSubsisNatureza + NumMulheresAdultas3560OcupamActivSubsisNatureza + NumMulheresAdultasMais60AnosOcupamActivSubsisNatureza; }
        }
        public int NumTotalPessoasOcupamActivSubsisNatureza
        {
            get { return NumTotalJovens1535OcupamActivSubsisNatureza + NumTotalAdultos3560OcupamActivSubsisNatureza + NumTotalAdultosMais60AnosOcupamActivSubsisNatureza; }
        }
        //Actividade Económica Formal - Operadores Económicos do Sector Primário(Agricultura, Pecuária, Pescas e Mar) {get;set;}
        public int NumHomensJovens1535ServicosOperadoresEcoSectorPrimario { get; set; }
        public int NumMulheresJovens1535PrestamServicosOperadoresEcoSectorPrimario { get; set; }
        public int NumTotalJovens1535PrestamServicosOperadoresEcoSectorPrimário
        {
            get { return NumHomensJovens1535ServicosOperadoresEcoSectorPrimario + NumMulheresJovens1535PrestamServicosOperadoresEcoSectorPrimario; }
        }
        public int NumHomensAdultos3560PrestamServicosOperEcoSectorPrimario { get; set; }
        public int NumMulheresAdultas3560PrestamServicosOperadoresEcoSectorPrimario { get; set; }
        public int NumTotalAdultos3560PrestamServicosOperadoresEcoSectorPrimario
        {
            get { return NumHomensAdultos3560PrestamServicosOperEcoSectorPrimario + NumMulheresAdultas3560PrestamServicosOperadoresEcoSectorPrimario; }
        }
        public int NumHomensAdultosMais60AnosPrestamServicosOperadoresEcoSectorPrimario { get; set; }
        public int NumMulheresAdultasMais60AnosPrestamServicosOperadoresEcoSectorPrimario { get; set; }
        public int NumTotalAdultosMais60AnosPrestamServicosOperadoresEconomicosSectorPrimario
        {
            get { return NumHomensAdultosMais60AnosPrestamServicosOperadoresEcoSectorPrimario + NumMulheresAdultasMais60AnosPrestamServicosOperadoresEcoSectorPrimario; }
        }
        public int NumHomensPrestamServicosOperadoresEconomicosSectorPrimario
        {
            get { return NumHomensJovens1535ServicosOperadoresEcoSectorPrimario + NumHomensAdultos3560PrestamServicosOperEcoSectorPrimario + NumHomensAdultosMais60AnosPrestamServicosOperadoresEcoSectorPrimario; }
        }
        public int NumMulheresPrestamServicosOperadoresEconomicosSectorPrimario
        {
            get { return NumMulheresJovens1535PrestamServicosOperadoresEcoSectorPrimario + NumMulheresAdultas3560PrestamServicosOperadoresEcoSectorPrimario + NumMulheresAdultasMais60AnosPrestamServicosOperadoresEcoSectorPrimario; }
        }
        public int NumTotalPessoasPrestamServicosOperadoresEconomicosSectorPrimario
        {
            get { return NumTotalJovens1535PrestamServicosOperadoresEcoSectorPrimário + NumTotalAdultos3560PrestamServicosOperadoresEcoSectorPrimario + NumTotalAdultosMais60AnosPrestamServicosOperadoresEconomicosSectorPrimario; }
        }
        //Actividade Económica Formal - Operadores Económicos do Sector da Indústria {get;set;}
        public int NumHomensJovens1535PrestamServicosOperadoresEcoIndustria { get; set; }
        public int NumMulheresJovens1535PrestamServicosOperadoresEcoIndustria { get; set; }
        public int NumTotalJovens1535PrestamServicosOperadoresEcoIndustria
        {
            get { return NumHomensJovens1535PrestamServicosOperadoresEcoIndustria + NumMulheresJovens1535PrestamServicosOperadoresEcoIndustria; }
        }
        public int NumHomensAdultos3560PrestamServicosOperadoresEcoIndustria { get; set; }
        public int NumMulheresAdultas3560PrestamServicosOperadoresEcoIndustria { get; set; }
        public int NumTotalAdultos3560PrestamServicosOperadoresEcoIndustria
        {
            get { return NumHomensAdultos3560PrestamServicosOperadoresEcoIndustria + NumMulheresAdultas3560PrestamServicosOperadoresEcoIndustria; }
        }
        public int NumHomensAdultosMais60AnosPrestamServicosOperadoresEcoIndustria { get; set; }
        public int NumMulheresAdultasMais60AnosPrestamServicosOperadoresEcoIndustria { get; set; }
        public int NumTotalAdultosMais60AnosPrestamServicosOperadoresEcoIndustria
        {
            get { return NumHomensAdultosMais60AnosPrestamServicosOperadoresEcoIndustria + NumMulheresAdultasMais60AnosPrestamServicosOperadoresEcoIndustria; }
        }
        public int NumHomensPrestamServicosOperadoresEcoIndustria
        {
            get { return NumHomensJovens1535PrestamServicosOperadoresEcoIndustria + NumHomensAdultos3560PrestamServicosOperadoresEcoIndustria + NumHomensAdultosMais60AnosPrestamServicosOperadoresEcoIndustria; }
        }
        public int NumMulheresPrestamServicosOperadoresEcoIndustria
        {
            get { return NumMulheresJovens1535PrestamServicosOperadoresEcoIndustria + NumMulheresAdultas3560PrestamServicosOperadoresEcoIndustria + NumMulheresAdultasMais60AnosPrestamServicosOperadoresEcoIndustria; }
        }
        public int NumTotalPessoasPrestamServicosOperadoresEcoIndustria
        {
            get { return NumTotalJovens1535PrestamServicosOperadoresEcoIndustria + NumTotalAdultos3560PrestamServicosOperadoresEcoIndustria + NumTotalAdultosMais60AnosPrestamServicosOperadoresEcoIndustria; }
        }
        //Actividade Económica Formal - Operadores Económicos do Sector do Comércio {get;set;}
        public int NumHomensJovens1535PrestamServicosOperadoresEcoComercio { get; set; }
        public int NumMulheresJovens1535PrestamServicosOperadoresEcoComercio { get; set; }
        public int NumTotalJovens1535AnosPrestamServicosOperadoresEcoComercio
        {
            get { return NumHomensJovens1535PrestamServicosOperadoresEcoComercio + NumMulheresJovens1535PrestamServicosOperadoresEcoComercio; }
        }
        public int NumHomensAdultos3560AnosPrestamServicosOperadoresEcoComercio { get; set; }
        public int NumMulheresAdultas3560PrestamServicosOperadoresEcoComercio { get; set; }
        public int NumTotalAdultos3560PrestamServicosOperadoresEcoComercio
        {
            get { return NumHomensAdultos3560AnosPrestamServicosOperadoresEcoComercio + NumMulheresAdultas3560PrestamServicosOperadoresEcoComercio; }
        }
        public int NumHomensAdultosMais60AnosPrestamServicosOperadoresEcoComercio { get; set; }
        public int NumMulheresAdultasMais60AnosPrestamServicosOperadoresEcoComercio { get; set; }
        public int NumTotalAdultosMais60AnosPrestamServicosOperadoresEcoComercio
        {
            get { return NumHomensAdultosMais60AnosPrestamServicosOperadoresEcoComercio + NumMulheresAdultasMais60AnosPrestamServicosOperadoresEcoComercio; }
        }
        public int NumHomensPrestamServicosOperadoresEcoComercio
        {
            get { return NumHomensJovens1535PrestamServicosOperadoresEcoComercio + NumHomensAdultos3560AnosPrestamServicosOperadoresEcoComercio + NumHomensAdultosMais60AnosPrestamServicosOperadoresEcoComercio; }
        }
        public int NumMulheresPrestamServicosOperadoresEcoComercio
        {
            get { return NumMulheresJovens1535PrestamServicosOperadoresEcoComercio + NumMulheresAdultas3560PrestamServicosOperadoresEcoComercio + NumMulheresAdultasMais60AnosPrestamServicosOperadoresEcoComercio; }
        }
        public int NumTotalPessoasPrestamServicosOperadoresEcoComercio
        {
            get { return NumTotalJovens1535AnosPrestamServicosOperadoresEcoComercio + NumTotalAdultos3560PrestamServicosOperadoresEcoComercio + NumTotalAdultosMais60AnosPrestamServicosOperadoresEcoComercio; }
        }
        //Actividade Económica Formal - Operadores Económicos do Sector da Hotelaria, Restauração e Similares {get;set;}
        public int NumHomensJovens1535PrestamServicosOperadoresEcoHotelaria { get; set; }
        public int NumMulheresJovens1535PrestamServicosOperadoresEcoHotelaria { get; set; }
        public int NumTotalJovens1535PrestamServicosOperadoresEcoHotelaria
        {
            get { return NumHomensJovens1535PrestamServicosOperadoresEcoHotelaria + NumMulheresJovens1535PrestamServicosOperadoresEcoHotelaria; }
        }
        public int NumHomensAdultos3560PrestamServicosOperadoresEcoHotelaria { get; set; }
        public int NumMulheresAdultas3560PrestamServicosOperadoresEcoHotelaria { get; set; }
        public int NumTotalAdultos3560PrestamServicosOperadoresEcoHotelaria
        {
            get { return NumHomensAdultos3560PrestamServicosOperadoresEcoHotelaria + NumMulheresAdultas3560PrestamServicosOperadoresEcoHotelaria; }
        }
        public int NumHomensAdultosMais60AnosPrestamServicosOperadoresEcoHotelaria { get; set; }
        public int NumMulheresAdultasMais60AnosPrestamServicosOperadoresEcoHotelaria { get; set; }
        public int NumTotalAdultosMais60AnosPrestamServicosOperadoresEcoHotelaria
        {
            get { return NumHomensAdultosMais60AnosPrestamServicosOperadoresEcoHotelaria + NumMulheresAdultasMais60AnosPrestamServicosOperadoresEcoHotelaria; }
        }
        public int NumHomensPrestamServicosOperadoresEcoHotelaria
        {
            get { return NumHomensJovens1535PrestamServicosOperadoresEcoHotelaria + NumHomensAdultos3560PrestamServicosOperadoresEcoHotelaria + NumHomensAdultosMais60AnosPrestamServicosOperadoresEcoHotelaria; }
        }
        public int NumMulheresPrestamServicosOperadoresEcoHotelaria
        {
            get { return NumMulheresJovens1535PrestamServicosOperadoresEcoHotelaria + NumMulheresAdultas3560PrestamServicosOperadoresEcoHotelaria + NumMulheresAdultasMais60AnosPrestamServicosOperadoresEcoHotelaria; }
        }
        public int NumTotalPessoasPrestamServicosOperadoresEcoHotelaria
        {
            get { return NumTotalJovens1535PrestamServicosOperadoresEcoHotelaria + NumTotalAdultos3560PrestamServicosOperadoresEcoHotelaria + NumTotalAdultosMais60AnosPrestamServicosOperadoresEcoHotelaria; }
        }
        //Actividade Económica Formal - Operadores Económicos do Sector dos Serviços {get;set;}
        public int NumHomensJovens1535PrestamServicosOperadoresEcoServicos { get; set; }
        public int NumMulheresJovens1535PrestamServicosOperadoresEcoServicos { get; set; }
        public int NumTotalJovens1535AnosPrestamServicosOperadoresEcoServicos
        {
            get { return NumHomensJovens1535PrestamServicosOperadoresEcoServicos + NumMulheresJovens1535PrestamServicosOperadoresEcoServicos; }
        }
        public int NumHomensAdultos3560PrestamServicosOperadoresEcoServicos { get; set; }
        public int NumMulheresAdultas3560PrestamServicosOperadoresEcoServicos { get; set; }
        public int NumTotalAdultos3560PrestamServicosOperadoresEcoServicos
        {
            get { return NumHomensAdultos3560PrestamServicosOperadoresEcoServicos + NumMulheresAdultas3560PrestamServicosOperadoresEcoServicos; }
        }
        public int NumHomensAdultosMais60AnosPrestamServicosOperadoresEcoServicos { get; set; }
        public int NumMulheresAdultasMais60AnosPrestamServicosOperadoresEcoServicos { get; set; }
        public int NumTotalAdultosMais60AnosPrestamServicosOperadoresEcoServicos
        {
            get { return NumHomensAdultosMais60AnosPrestamServicosOperadoresEcoServicos + NumMulheresAdultasMais60AnosPrestamServicosOperadoresEcoServicos; }
        }
        public int NumHomensPrestamServicosOperadoresEcoServicos
        {
            get { return NumHomensJovens1535PrestamServicosOperadoresEcoServicos + NumHomensAdultos3560PrestamServicosOperadoresEcoServicos + NumHomensAdultosMais60AnosPrestamServicosOperadoresEcoServicos; }
        }
        public int NumMulheresPrestamServicosOperadoresEcoServicos
        {
            get { return NumMulheresJovens1535PrestamServicosOperadoresEcoServicos + NumMulheresAdultas3560PrestamServicosOperadoresEcoServicos + NumMulheresAdultasMais60AnosPrestamServicosOperadoresEcoServicos; }
        }
        public int NumTotalPessoasPrestamServicosOperadoresEcoServicos
        {
            get { return NumTotalJovens1535AnosPrestamServicosOperadoresEcoServicos + NumTotalAdultos3560PrestamServicosOperadoresEcoServicos + NumTotalAdultosMais60AnosPrestamServicosOperadoresEcoServicos; }
        }
        //Actividade Económica Formal - Sector da Função Pública {get;set;}
        public int NumHomensJovens1535PrestamServicosFuncaoPublica { get; set; }
        public int NumMulheresJovens1535PrestamServicosFuncaoPublica { get; set; }
        public int NumTotalJovens1535PrestamServicosFuncaoPublica
        {
            get { return NumHomensJovens1535PrestamServicosFuncaoPublica + NumMulheresJovens1535PrestamServicosFuncaoPublica; }
        }
        public int NumHomensAdultos3560PrestamServicosFuncaoPublica { get; set; }
        public int NumMulheresAdultas3560PrestamServicosFuncaoPublica { get; set; }
        public int NumTotalAdultos3560PrestamServicosFuncaoPublica
        {
            get { return NumHomensAdultos3560PrestamServicosFuncaoPublica + NumMulheresAdultas3560PrestamServicosFuncaoPublica; }
        }
        public int NumHomensAdultosMais60AnosPrestamServicosFuncaoPublica { get; set; }
        public int NumMulheresAdultasMais60AnosPrestamServicosFuncaoPublica { get; set; }
        public int NumTotalAdultosMais60AnosPrestamServicosFuncaoPublica
        {
            get { return NumHomensAdultosMais60AnosPrestamServicosFuncaoPublica + NumMulheresAdultasMais60AnosPrestamServicosFuncaoPublica; }
        }
        public int NumHomensPrestamServicosFuncaoPublica
        {
            get { return NumHomensJovens1535PrestamServicosFuncaoPublica + NumHomensAdultos3560PrestamServicosFuncaoPublica + NumHomensAdultosMais60AnosPrestamServicosFuncaoPublica; }
        }
        public int NumMulheresPrestamServicosFuncaoPublica
        {
            get { return NumMulheresJovens1535PrestamServicosFuncaoPublica + NumMulheresAdultas3560PrestamServicosFuncaoPublica + NumMulheresAdultasMais60AnosPrestamServicosFuncaoPublica; }
        }
        public int NumTotalPessoasPrestamServicosFuncaoPublica
        {
            get { return NumTotalJovens1535PrestamServicosFuncaoPublica + NumTotalAdultos3560PrestamServicosFuncaoPublica + NumTotalAdultosMais60AnosPrestamServicosFuncaoPublica; }
        }
        //Actividade Económica não regulamentada {get;set;}
        public int NumHomensJovens1535TiveramOcupacaoRemuneradaUltimaSemanaContratoEscrito { get; set; }
        public int NumMulheresJovens1535TiveramOcupacaoRemuneradaUltimaSemanaSemContratoEscrito { get; set; }
        public int NumJovens1535TiveramOcupacaoRemuneradaUltimaSemanaSemContratoEscrito
        {
            get { return NumHomensJovens1535TiveramOcupacaoRemuneradaUltimaSemanaContratoEscrito + NumMulheresJovens1535TiveramOcupacaoRemuneradaUltimaSemanaSemContratoEscrito; }
        }
        public int NumHomensJovens1535CujaOcupacaoNaoEncontraRegistadaOrgaosPublicos { get; set; }
        public int NumMulheresJovens1535CujaOcupacaoNaoEncontraRegistadaOrgaosPublicos { get; set; }
        public int NumJovens1535CujaOcupacaoNaoEncontraRegistadaOrgaosPublicos
        {
            get { return NumHomensJovens1535CujaOcupacaoNaoEncontraRegistadaOrgaosPublicos + NumMulheresJovens1535CujaOcupacaoNaoEncontraRegistadaOrgaosPublicos; }
        }
        public int NumHomensJovens1535NaoBeneficiamQualquerApoioSocialSuaOcupacao { get; set; }
        public int NumMulheresJovens1535NaoBeneficiamQualquerApoioSocialSuaOcupacao { get; set; }
        public int NumJovens1535NaoBeneficiamQualquerApoioSocialOcupação
        {
            get { return NumHomensJovens1535NaoBeneficiamQualquerApoioSocialSuaOcupacao + NumMulheresJovens1535NaoBeneficiamQualquerApoioSocialSuaOcupacao; }
        }
        public int NumHomensJovens1535NaoInscritosINSS { get; set; }
        public int NumMulheresJovens1535NaoInscritosINSS { get; set; }
        public int NumJovens1535NaoInscritosINSS
        {
            get { return NumHomensJovens1535NaoInscritosINSS + NumMulheresJovens1535NaoInscritosINSS; }
        }
        public int NumHomensAdultos3560TiveramOcupacaoRemuneradaUltimaSemanaSemContratoEscrito { get; set; }
        public int NumMulheresAdultas3560TiveramOcupacaoRemuneradaUltimaSemanaSemContratoEscrito { get; set; }
        public int NumAdultos3560TiveramOcupacaoRemuneradaUltimaSemanaSemContratoEscrito
        {
            get { return NumHomensAdultos3560TiveramOcupacaoRemuneradaUltimaSemanaSemContratoEscrito + NumMulheresAdultas3560TiveramOcupacaoRemuneradaUltimaSemanaSemContratoEscrito; }
        }
        public int NumHomensAdultos3560CujaOcupacaoNaoEncontraRegistadaOrgaosPublicos { get; set; }
        public int NumMulheresAdultas3560CujaOcupacaoNaoEncontraRegistadaOrgaosPublicos { get; set; }
        public int NumAdultos3560CujaOcupacaoNaoEncontraRegistadaOrgaosPublicos
        {
            get { return NumHomensAdultos3560CujaOcupacaoNaoEncontraRegistadaOrgaosPublicos + NumMulheresAdultas3560CujaOcupacaoNaoEncontraRegistadaOrgaosPublicos; }
        }
        public int NumHomensAdultos3560NaoBeneficiamQualquerApoioSocialOcupacao { get; set; }
        public int NumMulheresAdultas3560NaoBeneficiamQualquerApoioSocialOcupacao { get; set; }
        public int NumAdultos3560BeneficiamQualquerApoioSocialOcupacao
        {
            get { return NumHomensAdultos3560NaoBeneficiamQualquerApoioSocialOcupacao + NumMulheresAdultas3560NaoBeneficiamQualquerApoioSocialOcupacao; }
        }
        public int NumHomensAdultos3560NaoInscritosINSS { get; set; }
        public int NumMulheresAdultas3560NaoEstaoInscritosINSS { get; set; }
        public int NumAdultos3560NaoEstaoInscritosINSS
        {
            get { return NumHomensAdultos3560NaoInscritosINSS + NumMulheresAdultas3560NaoEstaoInscritosINSS; }
        }
        public int NumHomensAdultosMaior60AnosTiveramOcupacaoRemuneradaUltimaSemanaSemContratoEscrito { get; set; }
        public int NumMulheresAdultasMaior60TiveramOcupacaoRemuneradaUltimaSemanaSemContratoEscrito { get; set; }
        public int NumAdultosMaior60TiveramOcupacaoRemuneradaUltimaSemanaSemContratoEscrito
        {
            get { return NumHomensAdultosMaior60AnosTiveramOcupacaoRemuneradaUltimaSemanaSemContratoEscrito + NumMulheresAdultasMaior60TiveramOcupacaoRemuneradaUltimaSemanaSemContratoEscrito; }
        }
        public int NumHomensAdultosMaior60CujaOcupacaoNaoEncontraRegistadaOrgaosPublicos { get; set; }
        public int NumMulheresAdultasMaior60CujaOcupacaoNaoEncontraRegistadaOrgaosPublicos { get; set; }
        public int NumAdultosMaior60CujaOcupacaoNaoEncontraRegistadaOrgaosPublicos
        {
            get { return NumHomensAdultosMaior60CujaOcupacaoNaoEncontraRegistadaOrgaosPublicos + NumMulheresAdultasMaior60CujaOcupacaoNaoEncontraRegistadaOrgaosPublicos; }
        }
        public int NumHomensAdultosMaior60NaoBeneficiamQualquerApoioSocialOcupacao { get; set; }
        public int NumMulheresAdultasMaior60NaoBeneficiamQualquerApoioSocialOcupacao { get; set; }
        public int NumAdultosMaior60NaoBeneficiamQualquerApoioSocialSuaOcupacao
        {
            get { return NumHomensAdultosMaior60NaoBeneficiamQualquerApoioSocialOcupacao + NumMulheresAdultasMaior60NaoBeneficiamQualquerApoioSocialOcupacao; }
        }
        public int NumHomensAdultosMaior60NaoEstaoInscritosINSS { get; set; }
        public int NumMulheresAdultasMaior60NaoEstaoInscritosINSS { get; set; }
        public int NumAdultos60NaoEstaoInscritosINSS
        {
            get { return NumHomensAdultosMaior60NaoEstaoInscritosINSS + NumMulheresAdultasMaior60NaoEstaoInscritosINSS; }
        }

    }
}
