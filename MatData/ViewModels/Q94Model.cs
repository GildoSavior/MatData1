namespace MatData.ViewModels
{
    public class Q94Model
    {
        public string PrinEixosAtend {get; set;}
        public int NumAtendRealiAnoTrans {get; set;}
        public int NumAtendRealiAnoCorr {get; set;}
        public int NumMedMensalAtendReali {get; set;}
        public int NumInscricoesMercTrabAnoTrans {get; set;}
        public int NumInscriMercTrabAnoCorr {get; set;}
        public int NumMedMensalInscriMercTrabalho {get; set;}
        public int NumEncamiMercTrabAnoTrans {get; set;}
        public int NumEncamiMercTrabAnoCorr {get; set;}
        public int NumMedMensalEncamiMercTrab {get; set;}
         //Incubadoras de Negócios {get; set;}
        public string IdIncubadoraNegocios {get; set;}
        public string DataInauguracao {get; set;}
        public string EstadoFuncional {get; set;}
        public string TipoInstalacoes {get; set;}
        public string ActividadesAcolhidas {get; set;}
        public string ServicosDisponibilizados {get; set;}
         //Start Ups {get; set;}
        public string IdStartUp {get; set;}
        public string DataInauguracaoStartUp {get; set;}
        public string EstadoFuncStartUp {get; set;}
        public string TipoInstalacoesStartUp {get; set;}
        public string AreaActividadeStartUp {get; set;}
        public string StartUpIncubadoraNeg {get; set;}
         //Distribuição de Kits e apoio ao Auto-emprego pela Administração Municipal {get; set;}
        public string IdeSectoresApoiados {get; set;}
        public int NumKitsEntreguesAnoTrans {get; set;}
        public int NumEmpregosGeradosAnoTrans {get; set;}
        public int NumEspaçcsAutoEmpregoAnoTrans {get; set;}
        public int NumEmpregosActKits {get; set;}
        public int NumKitsEntreguesAnoCorr {get; set;}
        public int NumEmpregosGeradosKitsAnoCorrente {get; set;}
        public int NumEspacosFacilitadosAutoEmpregoAnoCorr {get; set;}
        //PAPE - Plano de Acção para a Promoção da Empregabilidade {get; set;}
        public string ProgPAPECurso {get; set;}
        public string PublicoAlvoMaisRecorProgPAPE {get; set;}
        public int NumPessoasRecorreramPAPEAnoTrans {get; set;}
        public int NumPessoasApoiadaPAPEAnoTrans {get; set;}
        public int NumPessoasRecorreramPAPEAnoCorr {get; set;}
        public int NumPessoasApoiadasPAPEAnoCorr {get; set;}
        public int NumPessoaObteveColocacaoEstagioInicioPAPE {get; set;}
        public int NumPessoasIntegrLocalEstagioPAPE {get; set;}
        public int NumEntidadesAcolheramEstagiosInicioPAPE {get; set;}
        public string SectorMaisEstagiosAcolheuInicioPAPE {get; set;}
        //Outros Programas e Acções de apoio ao empreendedorismo e geração de emprego no Município {get; set;}
        public string IdOutrosProgramas {get; set;}
        public int NumJovensAbrangidosAnoTrans {get; set;}
        public string IdOutrosProgramasAnoCorr {get; set;}
        public int NumJovensAbrangAnoCorr {get; set;}
        public string Observacoes { get; set; }

    }
}
