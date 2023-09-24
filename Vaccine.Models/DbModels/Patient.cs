using System.ComponentModel.DataAnnotations.Schema;
using Vaccine.Models.Enums;
using Vaccine.Models.Interfaces;

namespace Vaccine.Models.DbModels
{
    public class Patient : IEntity<Guid>
    {
        public Guid Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Phone { get; set; }
        public string Address { get; set; }
        public DateTime BirthDay { get; set; }
        public Sex Sex { get; set; }
        
    }
}
