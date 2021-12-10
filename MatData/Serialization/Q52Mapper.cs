using MatData.Models.Records;
using MatData.ViewModels;

namespace MatData.Serialization
{
    public static class Q52Mapper
    {
        public static Q52Model Serialize(Q52Record model)
        {
            return new Q52Model
            {
                SportInfrastructureName = model.q5206,
                PhotoFront = model.q5207,
                PhotoInside = model.q5208,
                Photo3 = model.q5209,
                InfrastructureLocation = model.q5210,
                IdServices = model.q5211,
                Phone = model.q5212,
                Email = model.q5213,
                Website = model.q5214,
                InfrastructureSituation = model.q5215,
                StateInfrastructuraConservation = model.q5216,
                TutelaInfrastructure = model.q5217,
                InfrastructureModalities = model.q5218,
                CalendarEvent = model.q5219,
                Comments = model.q5220,
            };
        }
    }
}
