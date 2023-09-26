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
        private readonly IReportService _reportService;
        public MainForm(IPatientService patientService, IVaccineService vicineService,
            IVaccinationPlanService vaccinationPlanService, IReportService reportService)
        {
            InitializeComponent();
            _planService = vaccinationPlanService;
            _petientService = patientService;
            _vicineService = vicineService;
            _reportService = reportService;
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

        private void Report_StripMenu_Click(object sender, EventArgs e)
        {

        }

        private void ‚˚ÔÓÎÌÂÌËÂ¬‡ÍˆËÌ‡ˆËËToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var form = new VaccinationPlanReportForm(_petientService, _planService, _vicineService);
            form.Show();
        }

        private void File_StripMenu_Click(object sender, EventArgs e)
        {
            var form = new ReportForm(_reportService);
            form.Show();
        }

        private void MainForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}