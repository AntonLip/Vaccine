using AutoMapper;
using Vaccine.Models.DbModels;
using Vaccine.Models.Interfaces.Repository;
using Vaccine.Models.Interfaces.Services;

namespace Vaccine.Services
{
    public class VaccineService : BaseService<Vaccines, Vaccines, Vaccines, Vaccines>, IVaccineService
    {
        public VaccineService(IVaccineRepository repository, IMapper mapper) : base(repository, mapper)
        {
        }
    }
}
