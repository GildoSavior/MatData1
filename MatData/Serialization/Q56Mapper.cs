using MatData.Models.Records;
using MatData.ViewModels;

namespace MatData.Serialization
{
    public static class Q56Mapper
    {
        public static Q56Model Serialize(Q56Record model)
        {
            return new Q56Model
            {
                OSCName = model.q5606,
                IdService = model.q5607,
                Phone = model.q5608,
                Email = model.q5609,
                Website = model.q5610,
                OSCType = model.q5611,
                InfrastructurePhoto1 = model.q5612,
                InfrastructurePhoto2 = model.q5613,
                Localition = model.q5614,
                ZoneIntervetionOSC = model.q5615,
                ProjectsProgress = model.q5616,
                ExistStateLegal = model.q5617,
                ExistRuleInside = model.q5618,
                RecordDirOrgNotGov = model.q5619,
                Comments = model.q5620,

            };
        }
    }
}
