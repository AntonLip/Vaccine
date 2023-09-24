using Vaccine.DataAccess.DisciplinesAPI.DataAccess;
using Vaccine.Models.DbModels;
using Vaccine.Models.Interfaces.Repository;

namespace Vaccine.DataAccess
{
    public class PatientRepository : BaseRepository<Patient>, IPatientRepository
    {
        public PatientRepository(AppDbContext context) : base(context)
        {
        }
    }
}
