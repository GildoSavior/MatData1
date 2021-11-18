using MatData.Models.Records;
using MatData.ViewModels;
using System;

namespace MatData.Serialization
{
    public static class Q53Mapper
    {
        public static Q53Model Serialize(Q53Record model)
        {
            return new Q53Model
            {
                ListClubsSports = model.q5304,
                AnotherEntities = model.q5305,
                EventsSport = model.q5306,
                NumberPractitionersManNotFedModColect = Int32.Parse(model.q5307),
                NumberPractitionersMaleNotFedModColect = Int32.Parse(model.q5308),
                NumberPractitionersMenFedModColect = Int32.Parse(model.q5310),
                NumberPractitionersMaleFedModColect = Int32.Parse(model.q5311),
                NumberPractitionersManNotFedModSingle = Int32.Parse(model.q5313),
                NumberPractitionersMaleNotFedModSingle = Int32.Parse(model.q5314),
                NumberPractitionersManFedModSingle = Int32.Parse(model.q5316),
                NumberPractitionersMaleFedModSingle = Int32.Parse(model.q5317),
                Comments = model.q5319,
            };
        }


    }
}
