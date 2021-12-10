using MatData.Models.Records;
using MatData.ViewModels;
using System;

namespace MatData.Serialization
{
    public static class Q94Mapper
    {
        public static Q94Model Serialize(Q94Record model)
        {
            return new Q94Model
            {
                //CLESE - Centro Local de Empreendedorismo e Serviço de Emprego = model.q940,
                PrinEixosAtend = model.q9404,
                NumAtendRealiAnoTrans = Int32.Parse(model.q9405),
                NumAtendRealiAnoCorr = Int32.Parse(model.q9406),
                NumMedMensalAtendReali = Int32.Parse(model.q9407),
                NumInscricoesMercTrabAnoTrans = Int32.Parse(model.q9408),
                NumInscriMercTrabAnoCorr = Int32.Parse(model.q9409),
                NumMedMensalInscriMercTrabalho = Int32.Parse(model.q9410),
                NumEncamiMercTrabAnoTrans = Int32.Parse(model.q9411),
                NumEncamiMercTrabAnoCorr = Int32.Parse(model.q9412),
                NumMedMensalEncamiMercTrab = Int32.Parse(model.q9413),
                //Incubadoras de Negócios = model.q940,
                IdIncubadoraNegocios = model.q9414,
                DataInauguracao = model.q9415,
                EstadoFuncional = model.q9416,
                TipoInstalacoes = model.q9417,
                ActividadesAcolhidas = model.q9418,
                ServicosDisponibilizados = model.q9419,
                //Start Ups = model.q940,
                IdStartUp = model.q9420,
                DataInauguracaoStartUp = model.q9421,
                EstadoFuncStartUp = model.q9422,
                TipoInstalacoesStartUp = model.q9423,
                AreaActividadeStartUp = model.q9424,
                StartUpIncubadoraNeg = model.q9425,
                //Distribuição de Kits e apoio ao Auto-emprego pela Administração Municipal = model.q940,
                IdeSectoresApoiados = model.q9426,
                NumKitsEntreguesAnoTrans = Int32.Parse(model.q9427),
                NumEmpregosGeradosAnoTrans = Int32.Parse(model.q9428),
                NumEspaçcsAutoEmpregoAnoTrans = Int32.Parse(model.q9429),
                NumEmpregosActKits = Int32.Parse(model.q9430),
                NumKitsEntreguesAnoCorr = Int32.Parse(model.q9431),
                NumEmpregosGeradosKitsAnoCorrente = Int32.Parse(model.q9432),
                NumEspacosFacilitadosAutoEmpregoAnoCorr = Int32.Parse(model.q9433),
                //PAPE - Plano de Acção para a Promoção da Empregabilidade = model.q940,
                ProgPAPECurso = model.q9434,
                PublicoAlvoMaisRecorProgPAPE = model.q9435,
                NumPessoasRecorreramPAPEAnoTrans = Int32.Parse(model.q9436),
                NumPessoasApoiadaPAPEAnoTrans = Int32.Parse(model.q9437),
                NumPessoasRecorreramPAPEAnoCorr = Int32.Parse(model.q9438),
                NumPessoasApoiadasPAPEAnoCorr = Int32.Parse(model.q9439),
                NumPessoaObteveColocacaoEstagioInicioPAPE = Int32.Parse(model.q9440),
                NumPessoasIntegrLocalEstagioPAPE = Int32.Parse(model.q9441),
                NumEntidadesAcolheramEstagiosInicioPAPE = Int32.Parse(model.q9442),
                SectorMaisEstagiosAcolheuInicioPAPE = model.q9443,
                //Outros Programas e Acções de apoio ao empreendedorismo e geração de emprego no Município = model.q940,
                IdOutrosProgramas = model.q9444,
                NumJovensAbrangidosAnoTrans = Int32.Parse(model.q9445),
                IdOutrosProgramasAnoCorr = model.q9446,
                NumJovensAbrangAnoCorr = Int32.Parse(model.q9447),
                Observacoes = model.q9448,
            };
        }
    }
}
