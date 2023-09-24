using Vaccine.Models.DbModels;

namespace Vaccine.Models.Interfaces.Services
{
    public interface IPatientService : IService<Patient, Patient, Patient, Patient, Guid>
    {
    }
}
