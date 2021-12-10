namespace MatData.ViewModels
{
    public class Q78Model
    {
          //Agricultura de subsistência / familiar(AS)
          public int NumAgregPraticamAgricSub {get; set;}
          public int NumAgregConsomemProd {get; set;}
          public string DestinoProdAS {get; set;}
          public double ValorMensalObtidoAS {get; set;}
          public int NumTitulos {get; set;}
          public double NumTotalHectConcTitulo {get; set;}
          public double NumTotalHectExplorados {get; set;}
          public double NumTotalHectDispCultivo {get; set;}
          public double NumTotalHectExplorad {get; set;}
          public double NumTotalHectDispCampCurso {get; set;}
          public string[] ProdFileiraCereaisCampAnter {get; set;}
          public string[] ProdFileiraLegumesCampAnter {get; set;}
          public string[] ProdFileiraRaizCampAnter {get; set;}
          public string[] ProdFileiraHorticolasCampAnter {get; set;}
          public string[] ProdFileiraFrutCampAnter {get; set;}
          public string[] ProdOutrasFileiras {get; set;}
          //Pecuária de subsistência / familiar(PS) {get; set;}
          public int NumAgregPraticamPecuaria {get; set;}
          public int NumAgregConsomemPS {get; set;}
          public string DestinoProdExced {get; set;}
          public double ValorMensalObtido {get; set;}
          public string NumCurrais {get; set;}
          public string NumEstBovinosAnoTrans {get; set;}
          public string NumEstOvinosAnoTrans {get; set;}
          public string NumEstSuinosAnoTrans {get; set;}
          public double NumEstAvesAnoTrans {get; set;}
           //Pesca de subsistência / familiar(PS) {get; set;}
          public int NumAgregPraticamPS {get; set;}
          public int NumAgregConsomemSuaProd {get; set;}
          public string DestinoProdExcedentaria {get; set;}
          public double ValMensalObtido {get; set;}
          public string UtilizacaoEmbarcPS {get; set;}
          public int NumEmbarc {get; set;}
          public string PrinEspeciesCaptur {get; set;}
          public double QtdEstimadaPeixe {get; set;}
           //Caça de subsistência / familiar (CS) {get; set;}
          public int NumAgregPraticamCS {get; set;}
          public int NumAgregConsomemCS {get; set;}
          public string DestinoExcedent {get; set;}
          public double ValMesObtido {get; set;}
          public string PrincipInstrument {get; set;}
          public string PrincipEspeCapturCS {get; set;}
          public double NumEstCarne {get; set;}
           //Actividades de recolecção de subsistência / familiar em floresta(RS) {get; set;}
          public int NumAgregPraticamRS {get; set;}
          public int NumConsomemRS {get; set;}
          public string DestinoExced {get; set;}
          public double ValMensObtidoRS {get; set;}
          public string PrincipProdAlimentares {get; set;}
          public string PrincipProdNaoAlimentares {get; set;}
          public double QtdEstimadaProdAlimentares {get; set;}
          public double QtdEstimadaProdNaoAlimentares {get; set;}
          public string Observacoes { get; set; }

    }
}
