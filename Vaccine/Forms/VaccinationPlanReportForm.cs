using Vaccine.Models.Interfaces.Services;

namespace Vaccine.Forms
{
    public partial class VaccinationPlanReportForm : Form
    {
        public VaccinationPlanReportForm(IPatientService patientService, IVaccinationPlanService vaccinationPlanService, IVaccineService vaccineService)
        {
            InitializeComponent();
            var plan = vaccinationPlanService.GetAll();
            int y = 20;
            foreach (var item in plan)
            {
                Label name = new Label();
                name.Location = new Point(20, y);
                var patient = patientService.GetById(item.PatientId);
                name.Text = $"{patient.LastName} {patient.FirstName}";
                name.Width = 200;
                name.Height = 20;
                Controls.Add(name);

                Label vaccineName = new Label();
                vaccineName.Location = new Point(20 + name.Width, y);
                var vaccine = vaccineService.GetById(item.VaccineId);
                vaccineName.Text = $"{vaccine.Name}";
                vaccineName.Width = 80;
                vaccineName.Height = 20;
                Controls.Add(vaccineName);

                ProgressBar pBar = new ProgressBar();
                pBar.Location = new Point(40 + name.Width + vaccineName.Width, y);
                pBar.Name = "progressBar1";
                pBar.Width = 40;
                pBar.Height = 10;
                pBar.Minimum = 0;
                pBar.Maximum = item.CountNeed;
                pBar.Value = item.CountDone;
                Controls.Add(pBar);
                y += pBar.Height + 10;
            }
        }

        private void VaccinationPlanReportForm_Load(object sender, EventArgs e)
        {

        }
    }
}
