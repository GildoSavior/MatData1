namespace MatData.ViewModels
{
    public class Q49Model
    {
        public string NomeDaOrganizacaoReligiosa { get; set; }
        public string ReligiaoProfessada { get; set; }
        public string IdentificacaoDoServicoOuPessoaDeContacto { get; set; }
        public string ContactoTelefonico { get; set; }
        public string EnderecoDeEmail { get; set; }
        public string Website { get; set; }
        public string ReconhecimentoDaOrganizacaoReligiosaPeloGovernoDeAngola { get; set; }
        public int NumeroDoDecretoPresidencialDeAutorizacao { get; set; } = 0;
        public string TipoDeEspacoDeCulto { get; set; }
        public string FotografiaDoEspacoDeCultoFrontal { get; set; }
        public string FotografiaDoEspacoDeCultoOutra { get; set; }
        public string LocalizacaoDoEspacoDeCulto { get; set; }
        public string FrequenciaDeAberturaAComunidade { get; set; }
        public int NumeroMedioDePessoasQueSemanalmenteFrequentamOEspacoDeCulto { get; set; }
        public string Observacões { get; set; }

    }
}
