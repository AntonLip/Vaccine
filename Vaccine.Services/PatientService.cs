using AutoMapper;
using Vaccine.Models.DbModels;
using Vaccine.Models.Interfaces.Repository;
using Vaccine.Models.Interfaces.Services;

namespace Vaccine.Services
{
    public class PatientService : BaseService<Patient, Patient, Patient, Patient>, IPatientService
    {
        public PatientService(IPatientRepository repository, IMapper mapper) : base(repository, mapper)
        {
        }
    }
}
