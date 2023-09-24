using Vaccine.DataAccess.DisciplinesAPI.DataAccess;
using Vaccine.Models.DbModels;
using Vaccine.Models.Interfaces.Repository;

namespace Vaccine.DataAccess
{
    public class VaccineRepository : BaseRepository<Vaccines>, IVaccineRepository
    {
        public VaccineRepository(AppDbContext context) : base(context)
        {
        }
    }
}
