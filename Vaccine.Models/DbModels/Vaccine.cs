using Vaccine.Models.Enums;
using Vaccine.Models.Interfaces;

namespace Vaccine.Models.DbModels
{
    public class Vaccines : IEntity<Guid>

    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public InjectionType InjectionType { get; set; }
        public PrepareType PrepareType{ get; set; }
        public string Manufacturer { get; set; }
        public string Dosage { get; set; }
        public double StorageTemperature { get; set; }
    }
}
