using MatData.Models.Records;
using MatData.ViewModels;

namespace MatData.Serialization
{
    public static class Q55Mapper
    {
        public static Q55Model Serialize(Q55Record model)
        {
            return new Q55Model
            {
                TypeStructureSocialComunication = model.q5506,
                Photo1Structure = model.q5507,
                Photo2Structure = model.q5508,
                Location = model.q5509,
                Comments = model.q5510,
            };
        }
    }
}
