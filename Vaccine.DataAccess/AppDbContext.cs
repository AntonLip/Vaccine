using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;
using Vaccine.Models;
using Vaccine.Models.DbModels;

namespace Vaccine.DataAccess
{
    namespace DisciplinesAPI.DataAccess
    {
        public class AppDbContext : DbContext
        {
            public AppDbContext()
            {
                
            }
            public AppDbContext(DbContextOptions<AppDbContext> options)
                : base(options)
            {

                Database.EnsureCreated();
            }
            public DbSet<Patient> Patients { get; set; }
            public DbSet<Vaccines> Vaccines { get; set; }
            public DbSet<VaccinationPlan> VaccinationPlans { get; set; }
            protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
            {
                optionsBuilder.UseMySql(
                    GetConnectionString(),
                    new MySqlServerVersion(new Version(8, 0, 11))
                );
            }
            protected override void OnModelCreating(ModelBuilder modelBuilder)
            {
                base.OnModelCreating(modelBuilder);
                modelBuilder.Seed();
            }
            private static string GetConnectionString()
            {
                using (StreamReader r = new StreamReader("appsettings.json"))
                {
                    string json = r.ReadToEnd();
                    var dbSettings = JsonConvert.DeserializeObject<DbSettings>(json);
                    return $"server={dbSettings.DbServer};user={dbSettings.DbUser};password={dbSettings.DbPassword};database={dbSettings.Database};";
                }
            }
        }
    }
}