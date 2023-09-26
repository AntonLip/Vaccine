using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Newtonsoft.Json;
using System;
using Vaccine.DataAccess;
using Vaccine.DataAccess.DisciplinesAPI.DataAccess;
using Vaccine.Forms;
using Vaccine.Models;
using Vaccine.Models.DbModels;
using Vaccine.Models.Interfaces.Repository;
using Vaccine.Models.Interfaces.Services;
using Vaccine.Services;

namespace Vaccine
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            var services = new ServiceCollection();

            ConfigureServices(services);
            using (ServiceProvider serviceProvider = services.BuildServiceProvider())
            {
                var form1 = serviceProvider.GetRequiredService<AuthForm>();
                Application.Run(form1);
            }
        }
        private static void ConfigureServices(ServiceCollection services)
        {
            services.AddTransient<IVaccineRepository, VaccineRepository>();
            services.AddTransient<IVaccinationPlanRepository, VaccinationPlanRepository>();
            services.AddTransient<IPatientRepository, PatientRepository>();
            services.AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies());
            services.AddTransient<IVaccineService, VaccineService>();
            services.AddTransient<IVaccinationPlanService, VaccinationPlanService>();
            services.AddTransient<IPatientService, PatientService>();
            services.AddTransient<IReportService, ReportService>();

            services.AddScoped<AuthForm>();
            services.AddDbContext<AppDbContext>(options =>
                options.UseMySql(GetConnectionString(), new MySqlServerVersion(new Version(8, 0, 11))
                ));
            
        }
        public static string GetConnectionString()
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
