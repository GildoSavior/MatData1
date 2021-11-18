using MatData.Models.Records;
using MatData.ViewModels;

namespace MatData.Serialization
{
    public static class Q54Mapper
    {
        public static Q54Model Serialize(Q54Record model)
        {
            return new Q54Model
            {
                ExistSignalPublicTelevision = model.q5406,
                ExistSignalPublicRadio = model.q5407,
                ExistSignalPhone = model.q5408,
                ExistSignalInternet = model.q5409,
                ExistDistribServicesTelevision = model.q5410,
                DistribRegularNewspeparDayly = model.q5411,
                DistribRegularPubliPeriodic = model.q5412,
                Comments = model.q5413,
            };
        }
    }
}
