using MatData.Models.Records;
using MatData.ViewModels;
using System;

namespace MatData.Serialization
{
    public static class Q1Mapper
    {
        public static Q1Model Serialize (Q1Record model)
        {
            return new Q1Model
            {
                IdentificationService = model.q105,
                PhoneNumber = model.q106,
                Email = model.q107,
                Website = model.q108,
                Surface = model.q109,
                Comments = model.q110
            };
        }
    }
}
