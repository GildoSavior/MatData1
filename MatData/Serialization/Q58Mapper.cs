using MatData.Models.Records;
using MatData.ViewModels;

namespace MatData.Serialization
{
    public static class Q58Mapper
    {
        public static Q58Model Serialize(Q58Record model)
        {
            return new Q58Model
            {
                OrganizationName = model.q5804,
                OrganizationAssocCNJ = model.q5805,
                IdService = model.q5806,
                Phone = model.q5807,
                Email = model.q5808,
                Website = model.q5809,
                ScopeActOrg = model.q5810,
                ProjectsProgress = model.q5811,
                PosseInstOwn = model.q5812,
                InfrastructurePhoto1 = model.q5813,
                InfrastructurePhoto2 = model.q5814,
                Location = model.q5815,
                Comments = model.q5816,

            };
        }
    }

}
