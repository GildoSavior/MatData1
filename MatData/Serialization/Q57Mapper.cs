using MatData.Models.Records;
using MatData.ViewModels;

namespace MatData.Serialization
{
    public static class Q57Mapper
    {
        public static Q57Model Serialize(Q57Record model)
        {
            return new Q57Model
            {
                StructureName = model.q5704,
                IdService = model.q5705,
                Phone = model.q5706,
                Email = model.q5707,
                Website = model.q5708,
                ScopeActionStructure = model.q5709,
                ProjectsProgress = model.q5710,
                PosseInstalations = model.q5711,
                InfraestruturaPhoto1 = model.q5711 == "Sim" ? model.q5712 : null,
                InfraestruturaPhoto2 = model.q5711 == "Sim" ? model.q5713 : null,
                InfrastructureLocation = model.q5711 == "Sim" ? model.q5714 : null,
                Comments = model.q5715,

            };
        }
    }
}
