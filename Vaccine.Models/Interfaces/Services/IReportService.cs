namespace Vaccine.Models.Interfaces.Services
{
    public interface IReportService
    {
        void GetPatientReport();
        void GetPlan(DateTime start, DateTime end);
    }
}
