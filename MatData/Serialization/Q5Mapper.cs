using MatData.Models.Records;
using MatData.ViewModels;

namespace MatData.Serialization
{
    public class Q5Mapper
    {
        public static Q5Model Serialize(Q5Record record)
        {
            return new Q5Model
            {
                EmployeeName = record.q504,
                EmployeeNumber = record.q505,
                MunicipalStructure = record.q506,
                ManagmentPosition = record.q508,
                AppointmentDate = record.q509,
                Genre = record.q510,
                Photo = record.q511,
                BirthDate = record.q512,
                ProvinceBirth = record.q513,
                MunicipeBirth = record.q514,
                TrainingArea = record.q515,
                AcademicLevel = record.q516,
                TrainingEntity = record.q517,
                OtherTrainings = record.q518,
                PreviousPositions = record.q519,
                ProfessionalCategory = record.q520,
                ContractType = record.q521,
                SupplyCategory = record.q522,
                CargoDeDireccao = record.q523,
                Comments = record.q524,
            };
        }
    }
}
