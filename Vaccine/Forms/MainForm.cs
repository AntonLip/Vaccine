using Vaccine.Forms;
using Vaccine.Forms.VaccinePlanForms;
using Vaccine.Models.Interfaces.Services;

namespace Vaccine
{
    public partial class MainForm : Form
    {
        private readonly IPatientService _petientService;
        private readonly IVaccineService _vicineService;
        private readonly IVaccinationPlanService _planService;
        public MainForm(IPatientService patientService, IVaccineService vicineService,
            IVaccinationPlanService vaccinationPlanService)
        {
            InitializeComponent();
            _planService = vaccinationPlanService;
            _petientService = patientService;
            _vicineService = vicineService;
        }

        private void Ô‡ˆËÂÌÚ˚ToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void AddPatiens_StripMenuItem_Click(object sender, EventArgs e)
        {
            var form = new AddPatient(_petientService);
            form.Show();
        }

        private void ‚‡ÍˆËÌ˚ToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void ‰Ó·‡‚ËÚ¸ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var form = new AddVaccine(_vicineService);
            form.Show();
        }

        private void VaccineList_StripMenu_Click(object sender, EventArgs e)
        {
            var form = new VaccineListForm(_vicineService);
            form.Show();
        }

        private void ShowPatiensList_StripMenuItem_Click(object sender, EventArgs e)
        {
            var form = new PatientList(_petientService);
            form.Show();
        }

        private void AddVaccinationPlan_StipMenu_Click(object sender, EventArgs e)
        {
            var form = new AddVaccinePlanForm(_petientService, _planService, _vicineService);
            form.Show();
        }

        private void ShowVaccinationPlan_StripMenu_Click(object sender, EventArgs e)
        {
            var form = new ListVaccinationPlanForm(_petientService, _planService, _vicineService);
            form.Show();
        }
    }
}