using MatData.Models.Records;

namespace MatData.Serialization
{
    public static class Q3Mapper
    {
        public static Q3Model Serialize(Q3Record model)
        {
            return new Q3Model
            {
                Location = model.q306,
                IdentificationService = model.q307,
                PhoneNumber = model.q308,
                Email = model.q309,
                Website = model.q310,
                Surface = model.q311,
                Comments = model.q312
            };
        }
    }
}
