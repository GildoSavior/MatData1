using MatData.Models.Records;
using MatData.ViewModels;

namespace MatData.Serialization
{
    public static class Q6Mapper
    {
        public static Q6Model Serialize(Q6Record record)
        {
            return new Q6Model
            {
                EmployeeName = record.q604,
                EmployeeNumber = record.q605,
                MunicipalStructure = record.q606,
                RolePerformed = record.q608,
                AppointmentDate = record.q609,
                Genre = record.q610,
                BirthDate = record.q611,
                ProvinceBirth = record.q612,
                MunicipeBirth = record.q613,
                TrainingArea = record.q614,
                AcademicLevel = record.q615,
                TrainingEntity = record.q616,
                OtherTrainings = record.q617,
                ProfessionalCategory = record.q618,
                ContractType = record.q619,
                SupplyCategory = record.q620,
                Comments = record.q621,
            };
        }
    }
}
