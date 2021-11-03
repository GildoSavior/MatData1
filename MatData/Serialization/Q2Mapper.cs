using MatData.Models.Records;

namespace MatData.Serialization
{
    public static class Q2Mapper
    {
        public static Q2Model Serialize(Q2Record model)
        {
            return new Q2Model
            {
                IdentificationService = model.q205,
                PhoneNumber = model.q206,
                Email = model.q207,
                Website = model.q208,
                Location = model.q209,
                Surface = model.q210,
                Comments = model.q211
            };
        }
    }
}
