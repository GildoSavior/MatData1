using MatData.Models.Records;
using MatData.ViewModels;
using System;

namespace MatData.Serialization
{
    public static class Q78Mapper
    {
        public static Q78Model Serialize(Q78Record model)
        {
            return new Q78Model
            {
                //Agricultura de subsistência / familiar
                NumAgregPraticamAgricSub = Int32.Parse(model.q7806),
                NumAgregConsomemProd = Int32.Parse(model.q7807),
                DestinoProdAS = model.q7808,
                ValorMensalObtidoAS = double.Parse(model.q7809),
                NumTitulos = Int32.Parse(model.q7810),
                NumTotalHectConcTitulo = double.Parse(model.q7811),
                NumTotalHectExplorados = double.Parse(model.q7812),
                NumTotalHectDispCultivo = double.Parse(model.q7813),
                NumTotalHectExplorad = double.Parse(model.q7814),
                NumTotalHectDispCampCurso = double.Parse(model.q7815),
                ProdFileiraCereaisCampAnter = model.q7816,
                ProdFileiraLegumesCampAnter = model.q7817,
                ProdFileiraRaizCampAnter = model.q7818,
                ProdFileiraHorticolasCampAnter = model.q7819,
                ProdFileiraFrutCampAnter = model.q7820,
                ProdOutrasFileiras = model.q7821,
                //Pecuária de subsistência / familiar(PS) = model.q780,
                NumAgregPraticamPecuaria = Int32.Parse(model.q7822),
                NumAgregConsomemPS = Int32.Parse(model.q7823),
                DestinoProdExced = model.q7824,
                ValorMensalObtido = double.Parse(model.q7825),
                NumCurrais = model.q7826,
                NumEstBovinosAnoTrans = model.q7827,
                NumEstOvinosAnoTrans = model.q7828,
                NumEstSuinosAnoTrans = model.q7829,
                NumEstAvesAnoTrans = double.Parse(model.q7830),
                //Pesca de subsistência / familiar(PS)
                NumAgregPraticamPS = Int32.Parse(model.q7831),
                NumAgregConsomemSuaProd = Int32.Parse(model.q7832),
                DestinoProdExcedentaria = model.q7833,
                ValMensalObtido = double.Parse(model.q7834),
                UtilizacaoEmbarcPS = model.q7835,
                NumEmbarc = model.q7835 == "Sim" ? Int32.Parse(model.q7836) : 0,
                PrinEspeciesCaptur = model.q7837,
                QtdEstimadaPeixe = double.Parse(model.q7838),
                //Caça de subsistência / familiar (CS)
                NumAgregPraticamCS = Int32.Parse(model.q7839),
                NumAgregConsomemCS = Int32.Parse(model.q7840),
                DestinoExcedent = model.q7841,
                ValMesObtido = double.Parse(model.q7842),
                PrincipInstrument = model.q7843,
                PrincipEspeCapturCS = model.q7844,
                NumEstCarne = double.Parse(model.q7845),
                //Actividades de recolecção de subsistência / familiar em floresta(RS)
                NumAgregPraticamRS = Int32.Parse(model.q7846),
                NumConsomemRS = Int32.Parse(model.q7847),
                DestinoExced = model.q7848,
                ValMensObtidoRS = double.Parse(model.q7849),
                PrincipProdAlimentares = model.q7850,
                PrincipProdNaoAlimentares = model.q7851,
                QtdEstimadaProdAlimentares = double.Parse(model.q7852),
                QtdEstimadaProdNaoAlimentares = double.Parse(model.q7853),
                Observacoes = model.q7854,

            };
        }

    }
}
