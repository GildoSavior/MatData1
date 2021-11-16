using MatData.Models.Records;
using MatData.ViewModels;

namespace MatData.Serialization
{
    public  static class Q40Mapper
    {
        public static Q40Model Serialize(Q40Record model)
        {
            return new Q40Model
            {
                HospitalNacional = int.Parse(model.q4006),
                HospitalProvincial = int.Parse(model.q4007),
                HospitalMunicipal = int.Parse(model.q4008),
                CentroDeSaude = int.Parse(model.q4009),
                PostoDeSaude = int.Parse(model.q4010),
                CentroMaternoInfantil = int.Parse(model.q4011),
                Clinica = int.Parse(model.q4012),
                CentroDeanálisesClinicas = int.Parse(model.q4013),
                Outros = int.Parse(model.q4014),
                NumeroDeCamasDoMunicipio = int.Parse(model.q4015),
                NumeroDeUsComBlocoOperatorio = int.Parse(model.q4016),
                NumeroDeUsComLaboratorio = int.Parse(model.q4017),
                NumeroDeUsComBancoDeSangue = int.Parse(model.q4018),
                NumeroDeUsComPostoFixoDeVacinacao = int.Parse(model.q4019),
                NumeroDeUsComPacoteCompletoDeMedicamentosEssenciais = int.Parse(model.q4020),
                NumeroDeAmbulânciasaFuncionar = int.Parse(model.q4021),
                NumeroDeCarrosParaAbastecimentoDeLogisticasESupervisao = int.Parse(model.q4022),
                NumeroDeMedicos1000Habitantes = int.Parse(model.q4023),
                NumeroDeEnfermeiros1000Habitantes = int.Parse(model.q4024),
                NumeroDeTecnicosDeDiagnostico1000Habitantes = int.Parse(model.q4025),
                ExistenciaDeArmazemMunicipalDeMedicamentosEmFuncionamento = model.q4026,
                TemSistemaDeRefrigeracao = model.q4027,
                NumeroMedioMensalDeSessoesDeEquipasAvancadasMoveisRealizadasaPopulacoesSemAcessoaUs = int.Parse(model.q4028),
                NumeroDeEquipasIntegradasDeControloDeVectoresFuncionais = int.Parse(model.q4029),
                NumeroDeUsComPrevencaoDaTransmissaoVerticalDeVihDeMaeParaFilho = int.Parse(model.q4030),
                NumeroDeUsComDiagnosticoETratamentoDeTuberculose = int.Parse(model.q4031),
                NumeroDeUsComMeiosDeTestagemEControloDaCovid19 = int.Parse(model.q4032),
                Observacoes = model.q4033
            };
        }
    }
}
