using Vaccine.Models.Interfaces.Services;

namespace Vaccine.Forms
{
    public partial class ReportForm : Form
    {
        private readonly IPatientService _petientService;
        private readonly IVaccinationPlanService _vaccinationPlanService;
        private readonly IVaccineService _vaccineService;
        public ReportForm(IPatientService patientService, IVaccinationPlanService vaccinationPlanService, IVaccineService vaccineService)
        {
            InitializeComponent();
            _petientService = patientService;
            _vaccinationPlanService = vaccinationPlanService;
            _vaccineService = vaccineService;
        }

        private void GenerateReport_Btn_Click(object sender, EventArgs e)
        {

        }
    }
}
