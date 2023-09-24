using AutoMapper;
using Vaccine.Models.DbModels;
using Vaccine.Models.Interfaces.Repository;
using Vaccine.Models.Interfaces.Services;

namespace Vaccine.Services
{
    public class VaccinationPlanService : BaseService<VaccinationPlan, VaccinationPlan, VaccinationPlan, VaccinationPlan>, IVaccinationPlanService
    {
        public VaccinationPlanService(IVaccinationPlanRepository repository, IMapper mapper) : base(repository, mapper)
        {
        }
    }
}
