using Vaccine.Models.DbModels;
using Vaccine.Models.Interfaces.Services;

namespace Vaccine.Forms.VaccinePlanForms
{
    public partial class AddVaccinePlanForm : Form
    {
        private readonly IPatientService _petientService;
        private readonly IVaccinationPlanService _vaccinationPlanService;
        private readonly IVaccineService _vaccineService;
        private List<Patient> _patients;
        private List<Vaccines> _vaccines;

        public AddVaccinePlanForm(IPatientService patientService, IVaccinationPlanService ivaccinationPlanService, IVaccineService ivaccineService)
        {
            InitializeComponent();
            
            _petientService = patientService;
            _vaccinationPlanService = ivaccinationPlanService;
            _vaccineService = ivaccineService;
            UpdateUi();
        }

        private void AddVaccinePlanForm_Load(object sender, EventArgs e)
        {

        }

        private void Add_Btn_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(InjectionCount_Tb.Text) || 
                InjectionDate_Dtp.Value.ToShortDateString() == DateTime.Today.ToShortDateString())
            {
                MessageBox.Show("Заполните количество требуемых инъекций");
            }
            else
            {
                if (Patient_Cb.SelectedIndex != -1 || Vaccine_Cb.SelectedIndex != -1)
                {
                    try
                    {
                        VaccinationPlan vaccinationPlan = new VaccinationPlan
                        {
                            CountDone = 0,
                            CountNeed = int.Parse(InjectionCount_Tb.Text),
                            Isfulfill = false,
                            LastDone = DateTime.MinValue,
                            NextDone = InjectionDate_Dtp.Value,
                            PatientId = _patients[Patient_Cb.SelectedIndex].Id,
                            VaccineId = _vaccines[Patient_Cb.SelectedIndex].Id,
                        };

                        var newVaccinationPlan = _vaccinationPlanService.Add(vaccinationPlan);
                        if (newVaccinationPlan != null)
                        {
                            MessageBox.Show("Расписание обнавлено");
                            this.Close();
                        }
                        else
                        {
                            MessageBox.Show("Что-то пошло не так");
                        }
                    }
                    catch (Exception ex)
                    {

                        MessageBox.Show(ex.Message);
                    }
                }
                else
                {
                    MessageBox.Show("Выберите типы инъекции и производства");
                }
            }
        }

        private async void  UpdateUi()
        {
            int countPatient = _petientService.GetCountEntity();
            _patients = (List<Patient>)(_petientService.GetAll());
            foreach (var patient in _patients)
            {
                Patient_Cb.Items.Add(patient.FirstName + " " + patient.LastName);
            }
            int countVaccine = _vaccineService.GetCountEntity();
            _vaccines = (List<Vaccines>)_vaccineService.GetAll();
            foreach (var vaccine in _vaccines)
            {
                Vaccine_Cb.Items.Add(vaccine.Name);
            }
        }
    }
}
