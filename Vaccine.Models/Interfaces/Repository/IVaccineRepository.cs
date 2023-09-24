using Vaccine.Models.DbModels;

namespace Vaccine.Models.Interfaces.Repository
{
    public interface IVaccineRepository : IRepository<Vaccines, Guid>
    {
    }
}
