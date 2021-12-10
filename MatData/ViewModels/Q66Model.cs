namespace MatData.ViewModels
{
    public class Q66Model
    {
        //Estabilização de áreas de risco de deslizamento(EARD)
        public string IdAreaEARD {get; set;}
        public double SuperficieEstabilizEARD {get; set;}
        public string LocalAreaEstabilizEARD {get; set;}
        public string FotografiaFrontal1 {get; set;}
        public string FotografiaOutra2 { get; set; }

        //Recuperação de zonas ravinadas(RZR)
        public string IdZonaRZR {get; set;}
        public double SuperficieRecuperadaRZR {get; set;}
        public string LocalZonaRecRZR {get; set;}
        public string FotografiaFrontal1RZR {get; set;}
        public string FotografiaOutraRZR2 { get; set; }

        //Desassoriamento e regularização de cursos de água(DRCA)
        public string IdZonaDRCA {get; set;}
        public double CursoRegularizadoDRCA {get; set;}
        public string LocalCursoAIntervencionadoDRCA {get; set;}
        public string FotografiaFrontalDRCA {get; set;}
        public string FotografiaOutraDRCA { get; set; }

        //Vigilância e controlo sobre actos de Intervenção e Impacto Ambiental(IIA)
        public string IdZonaIIA {get; set;}
        public string TipologiaActoIIAControl {get; set;}
        public string LocalZonaControladaIIA {get; set;}
        public string FotografiaIIA1 {get; set;}
        public string FotografiaIIA2 { get; set; }

        //Cadastramento de população a residir em zonas de risco ambiental(CPRZRA)
        public string IdZonaCPRZRA {get; set;}
        public string TipoRiscIdentCPRZRA {get; set;}
        public string LocalZonaCPRZRA {get; set;}
        public string FotografiaCPRZRA1 {get; set;}
        public string FotografiaCPRZRA2 { get; set; }
        //
        public int NumHabSituacaoRisAmb {get; set;}
        public int NumAgregFamSitRisAmb {get; set;}
        public int NumTotalPessoasSitRisAmb {get; set;}
        public string ExistProjecInterPreserAmb {get; set;}
        public string NomeProjectInterPreserAmb {get; set;}
        public string EntidadeRespImplemenProjectPreserAmb {get; set;}
        public string IdServico {get; set;}
        public string ContactoTelefonico {get; set;}
        public string Email {get; set;}
        public string Website {get; set;}
        public string AmbitoInterProjectAmb {get; set;}
        public int NumPessoasEntidadEnvolvRegularProj {get; set;}
        public int NumPessoasComuniEnvolProjecto {get; set;}
        public string Observacoes { get; set; }
    }
}
