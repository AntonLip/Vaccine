using Vaccine.DataAccess.DisciplinesAPI.DataAccess;
using Vaccine.Models.DbModels;
using Vaccine.Models.Interfaces.Repository;

namespace Vaccine.DataAccess
{
    public class VaccinationPlanRepository : BaseRepository<VaccinationPlan>, IVaccinationPlanRepository
    {
        public VaccinationPlanRepository(AppDbContext context) : base(context)
        {
        }
    }
}
