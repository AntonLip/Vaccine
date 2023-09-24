using Microsoft.EntityFrameworkCore;

namespace Vaccine.Models
{
    public static class ModelBuilderExtension
    {
        public static void Seed(this ModelBuilder modelBuilder)
        {

           
            SeedUsers(modelBuilder);
        }

        private static void SeedUsers(ModelBuilder builder)
        {
            
        }

        
    }
}
