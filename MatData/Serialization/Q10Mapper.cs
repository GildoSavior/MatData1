using MatData.Models.Records;
using MatData.ViewModels;
using System;

namespace MatData.Serialization
{
    public static class Q10Mapper
    {
        public static Q10Model Serialize (Q10Record model)
        {
            return new Q10Model
            {
                Name = model.q1006,
                PhoneNumber = model.q1007,
                Photo = model.q1008,
                BirthDate = model.q1009,
                Genre = model.q1010,
                Membership = model.q1011,
                AdmissionMethod = model.q1012,
                AppointmentDate = model.q1013 ,
                LimiteTerritorial = model.q1014,
                AdministrationRecognition = model.q1015,
                EarnsSubsidy = model.q1016,
                Comments = model.q1017,
            };
        }
    }
}
