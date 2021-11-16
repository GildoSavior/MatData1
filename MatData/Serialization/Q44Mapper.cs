using MatData.Models.Records;
using MatData.ViewModels;

namespace MatData.Serialization
{
    public class Q44Mapper
    {
        public static Q44Model Serialize(Q44Record model)
        {
            return new Q44Model
            {
                NumeroDeHomensInscritosNasEstruturaLocaisDoInss = int.Parse(model.q4404),
                NumeroDeMulheresInscritasNasEstruturaLocaisDoInss = int.Parse(model.q4405),
                PessoasInscritasNasEstruturaLocaisDoInss = model.q4406,
                NumeroDeHomensInscritosNasEstruturaLocaisDeTs = int.Parse(model.q4407),
                NumeroDeMulheresInscritasNasEstruturaLocaisDeTs = int.Parse(model.q4408),
                PessoasInscritasNasEstruturaLocaisDeTranferênciasSociais = model.q4409,
                NumeroDeHomensInscritosNasEstruturaLocaisDaCaixaSocialDasFaas = int.Parse(model.q4410),
                NumeroDeMulheresInscritasNasEstruturaLocaisDaCaixaSocialDasFaas = int.Parse(model.q4411),
                PessoasInscritasNasEstruturaLocaisDaCaixaSocialDasFaas = model.q4412,
                NumeroDeHomensInscritosEmOutrasEstruturaLocaisDeProteccãoSocial = int.Parse(model.q4413),
                NumeroDeMulheresInscritasEmOutrasEstruturaLocaisDeProteccãoSocial = int.Parse(model.q4414),
                PessoasInscritasEmOutrasEstruturaLocaisDeProteccãoSocial = model.q4415,
                NumeroDeAgregadosFamiliaresCadastradosNoProgramaKwenda = int.Parse(model.q4416),
                NumeroDeAgregadosFamiliaresBeneficiáriosDaTransferênciaDeRendaFixaKwenda = int.Parse(model.q4417),
                NumeroDeCriancasMasculinasDe0a4AnosDeIdadeHospedadosNosLaresDeOrfaos = int.Parse(model.q4418),
                NumeroDeCriancasMasculinasDe5a9AnosDeIdadeHospedadosNosLaresDeOrfaos = int.Parse(model.q4419),
                NumeroDeCriancasMasculinasDe10a14AnosDeIdadeHospedadosNosLaresDeOrfaos = int.Parse(model.q4420),
                NumeroDeCriancasMasculinasDe15a18AnosDeIdadeHospedadosNosLaresDeOrfaos = int.Parse(model.q4421),
                NumeroDeCriancasFemininasDe0a4AnosDeIdadeHospedadasNosLaresDeOrfaos = int.Parse(model.q4422),
                NumeroDeCriancasFemininasDe5a9AnosDeIdadeHospedadasNosLaresDeOrfaos = int.Parse(model.q4423),
                NumeroDeCriancasFemininasDe10a14AnosDeIdadeHospedadasNosLaresDeOrfaos = int.Parse(model.q4424),
                NumeroDeCriancasFemininasDe15a18AnosDeIdadeHospedadasNosLaresDeOrfaos = int.Parse(model.q4425),
                CriancasHospedadasNosLaresDeOrfaos = model.q4426,
                NumeroDeHomensHospedadosNosLaresDe3raIdade = int.Parse(model.q4427),
                NumeroDeMulheresHospedadasNosLaresDe3raIdade = int.Parse(model.q4428),
                PessoasHospedadasNosLaresDe3raIdade = model.q4429,
                NumeroDeHomensHospedadosNasCasasDeAbrigo = int.Parse(model.q4430),
                NumeroDeMulheresHospedadasNasCasasDeAbrigo = int.Parse(model.q4431),
                PessoasHospedadasNasCasasDeAbrigo = model.q4432,
                NumeroDeHomensHospedadosNasEstruturasDeApoioaDeficientes = int.Parse(model.q4433),
                NumeroDeMulheresHospedadasNasEstruturasDeApoioaDeficientes = int.Parse(model.q4434),
                PessoasHospedadasNasEstruturasDeApoioaDeficientes = model.q4435,
                OutrasEstruturasDeApoioSocialQuais = model.q4436,
                NumeroDeHomensHospedadosEmOutrasEstruturasDeApoioSocial = int.Parse(model.q4437),
                NumeroDeMulheresHospedadasEmOutrasEstruturasDeApoioSocial = int.Parse(model.q4438),
                PessoasHospedadasEmOutrasEstruturasDeApoioSocial = model.q4439,
                Observacoes = model.q4440,
            };
        }
    }
}
