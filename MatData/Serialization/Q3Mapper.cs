using MatData.Models.Records;

namespace MatData.Serialization
{
    public static class Q3Mapper
    {
        public static Q3Model Serialize(Q3Record model)
        {
            return new Q3Model
            {
                Location = model.q309,
                IdentificationService = model.q305,
                PhoneNumber = model.q306,
                Email = model.q307,
                Website = model.q308,
                Surface = model.q310,
                Comments = model.q311
            };
        }
    }
}
