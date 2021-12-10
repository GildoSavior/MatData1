using System;
using MatData.Models.Records;
using MatData.ViewModels;

namespace MatData.Serialization
{
    public static class Q4Mapper
    {
        public static Q4Model Serialize(Q4Record model)
        {
            return new Q4Model
            {
                OrgClass = model.q406,
                Name = model.q407,
                Photo1 = model.q408,
                Photo2 = model.q409,
                Photo3 = model.q410,
                Photo4 = model.q411,
                Photo5 = model.q412,
                Location = model.q413,
                IdenticationService = model.q414,
                PhoneNumber = model.q415,
                Email = model.q416,
                TotalServices = model.q418,
                ExistentServicesList = model.q406 == "A" ?
                    model.q419 : model.q406 == "B" ?
                    model.q420 : model.q406 == "C" ?
                    model.q421 : model.q406 == "D" ?
                    model.q422 : Array.Empty<string>(),
                BuildingTypology = model.q423,
                ConservationState = model.q424,
                BuildingDate = model.q425,
                Comments = model.q426
            };
        }
    }
}
