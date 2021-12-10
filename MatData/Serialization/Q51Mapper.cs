using MatData.Models.Records;
using MatData.ViewModels;
using System;

namespace MatData.Serialization
{
    public static class Q51Mapper
    {
        public static Q51Model Serialize(Q51Record model) => new Q51Model
        {
            NumberTheaterGroups = Int32.Parse(model.q5104),
            NumberDanceGroup = Int32.Parse(model.q5105),
            NumberMusicalGroupings = Int32.Parse(model.q5106),
            NumberEthnographicGroups = Int32.Parse(model.q5107),
            NumberCarnivalGroups = Int32.Parse(model.q5108),
            OtherCulturalGroups = model.q5109,
            NumberCreatorsInFineArts = Int32.Parse(model.q5110),
            NumberCreatorsInMusicalArts = Int32.Parse(model.q5111),
            NumberCreatorsInArtsMovement = Int32.Parse(model.q5112),
            NumberCreatorsInPerformingArts = Int32.Parse(model.q5113),
            NumberCreatorsInLiteraryArts = Int32.Parse(model.q5114),
            NumberOfCreatorsInLocalTraditionalArts = Int32.Parse(model.q5115),
            NumberCreatorsInOtherArtisticFields = Int32.Parse(model.q5116),
            NumberArtisticEventsPromoters = Int32.Parse(model.q5117),
            NumberCulturalEventsPromoters = Int32.Parse(model.q5118),
            NumberPromotersPlayfulEntertainmentEvents = Int32.Parse(model.q5119),
            NumberNightlifePromoters = Int32.Parse(model.q5120),
            NumberFilmScreeningPromoters = Int32.Parse(model.q5121),
            NumberRecordingStudios = Int32.Parse(model.q5122),
            NumberPromotersOtherCulturalAreas = Int32.Parse(model.q5123),
            Festivals = model.q5124,
            CulturalMeetings = model.q5125,
            ArtisticNaturalHeritageAnimation = model.q5126,
            EthnoCulturalManifestations = model.q5127,
            OtherCulturalManifestations = model.q5128,
            Comments = model.q5129,
        };
    }
}
