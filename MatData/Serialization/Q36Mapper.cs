using System;
using Matdata.API.ViewModels;
using MatData.Models.Records;

namespace Matdata.API.Serialization
{
	public class Q36Mapper
	{
		public static Q36Model Serialize(Q36Record record)
		{
			return new Q36Model
			{
				DesignacaoDaEstruturaDeFormacaoProfissional = record.q3606,
				GestaoDaEstruturaDeFormacaoProfissional = record.q3607,
				LocalizacaoDaEstruturaDeFormacaoProfissional = record.q3608,
				IdentificacaoDoServicoOuPessoaDeContacto = record.q3609,
				ContactoTelefonico = record.q3610,
				EnderecoDeEmail = record.q3611,
				Website = record.q3612,
				AnoDeConstrucaoDaEstruturaDeFormacaoProfissional = record.q3613,
				RegistoLegalDaEstruturaDeFormacaoProfissional = record.q3614,
				NumeroDeAlvaraDeAutorizacaoDeFuncionamentoDaEstruturaDeFormacaoProfissional = record.q3615,
				NumeroDeSalasDeAula = record.q3616,
				NumeroDeSalasEspecializadas = record.q3617,
				EspacoParaPraticaDesportiva = record.q3618,
				EspacoDeRecreioEConvivio = record.q3619,
				RegistoFotograficoFrontal = record.q3620,
				RegistoFotograficoLateralDireito = record.q3621,
				RegistoFotograficoLateralEsquerdo = record.q3622,
				RegistoFotograficoInterior1 = record.q3623,
				RegistoFotograficoInterior2 = record.q3624,
				TipoDeEstruturaDeFormacaoProfissional = record.q3625,
				SituacaoDaEstruturaDeFormacaoProfissional = record.q3626,
				EdificioConstruidoComoEstruturaDeFormacaoProfissional = record.q3627,
				TipologiaDeConstrucaoDaEstruturaDeFormacaoProfissional = record.q3628,
				EstadoDeConservacaoDaEstruturaDeFormacaoProfissional = record.q3629,
				PrincipalFonteDeAbastecimentoDeAgua = record.q3630,
				SegundaFonteDeAbastecimentoDeAgua = record.q3631,
				PrincipalFonteDeAbastecimentoDeEnergia = record.q3632,
				SegundaFonteDeAbastecimentoDeEnergia = record.q3633,
				PrincipalTipoDeSaneamentoBasico = record.q3634,
				SegundoTipoDeSaneamentoBasico = record.q3635,
				MeiosDeRecolhaDeLixo = record.q3636,
				MeiosDeTratamentoDeLixo = record.q3637,
				CursosDeFormacaoProfissionalEmFuncionamento = record.q3638,
				NumeroDeFormandosDoSexoMasculinoEmFrequenciaDeCursosProfissionais = record.q3639,
				NumeroDeFormandosDoSexoFemininoEmFrequenciaDeCursosProfissionais = record.q3640,
				NumeroTotalDeFormandosEmFrequenciaDeCursosProfissionais = record.q3641,
				NumeroTotalDeFormandosQueConcluiramCursosProfissionaisNoAnoTransacto = record.q3642,
				NomeDoFormador = record.q3643,
				EstruturaaQueEstaAfecto = record.q3644,
				DataDeinicioDeActividadeNaEstruturaDeFormacaoProfissional = record.q3645,
				Genero = record.q3646,
				DataDeNascimento = record.q3647,
				ProvinciaDeNascimento = record.q3648,
				MunicipioDeNascimento = record.q3649,
				AreaDeFormacao = record.q3650,
				NivelAcademicoMaisElevadoCompleto = record.q3651,
				EntidadeDeFormacaoDoNivelAcademicoMaisElevadoCompleto = record.q3652,
				OutrasFormacoesRelevantesParaaFuncao = record.q3653,
				CategoriaProfissionalActual = record.q3654,
				TipoDeContrato = record.q3655,
				CategoriaDeProvimento = record.q3656,
				Observacoes = record.q3657,
			};
		}
	}
}

