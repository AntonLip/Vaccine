using System.ComponentModel.DataAnnotations.Schema;
using Vaccine.Models.Interfaces;

namespace Vaccine.Models.DbModels
{
    public class VaccinationPlan : IEntity<Guid>
    {
        public Guid Id { get; set; }
        public Guid PatientId { get; set; }
        
        [ForeignKey("PatientId")]
        public Patient Patient { get; set; }

        public Guid VaccineId { get; set; }

        [ForeignKey("VaccineId")]
        public Vaccines Vaccine { get; set; }
        public int CountDone { get; set; }
        public DateTime LastDone { get; set; }
        public DateTime NextDone { get; set; }
        public int CountNeed { get; set; }
        public bool Isfulfill { get; set; }

    }
}
