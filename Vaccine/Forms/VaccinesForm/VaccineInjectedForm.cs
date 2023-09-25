using Vaccine.Models.DbModels;
using Vaccine.Models.Interfaces.Services;

namespace Vaccine.Forms.VaccinesForm
{
    public partial class VaccineInjectedForm : Form
    {
        private readonly IPatientService _petientService;
        private readonly IVaccinationPlanService _vaccinationPlanService;
        private readonly IVaccineService _vaccineService;
        private VaccinationPlan _vaccinationPlan;
        public VaccineInjectedForm(IPatientService patientService, IVaccinationPlanService vaccinationPlanService, IVaccineService vaccineService, VaccinationPlan vaccinationPlan)
        {
            InitializeComponent();
            _petientService = patientService;
            _vaccinationPlanService = vaccinationPlanService;
            _vaccineService = vaccineService;
            var vaccine = _vaccineService.GetById(vaccinationPlan.VaccineId);
            var patient = _petientService.GetById(vaccinationPlan.PatientId);
            _vaccinationPlan = vaccinationPlan;
            FirstName_lbl.Text = patient.FirstName;
            LastName_lbl.Text = patient.LastName;
            VaccineName_lbl.Text = $"Вакцинируется {vaccine.Name} дозировка {vaccine.Dosage}";
            CountVaccine_lbl.Text = $"{vaccinationPlan.CountDone} инъекция из {vaccinationPlan.CountNeed}";
        }

        private void Update_Btn_Click(object sender, EventArgs e)
        {
            try
            {
                var vaccinationPlan = _vaccinationPlanService.GetById(_vaccinationPlan.Id);
                if (vaccinationPlan == null)
                {
                    throw new ArgumentNullException("Нет в плане");
                }
                if (vaccinationPlan.CountDone == (vaccinationPlan.CountNeed - 1))
                {
                    vaccinationPlan.CountDone += 1;
                    vaccinationPlan.Isfulfill = true;
                }
                else if (vaccinationPlan.CountDone == vaccinationPlan.CountNeed)
                {
                    MessageBox.Show("Все инъекции сделаны");
                }
                else
                {
                    vaccinationPlan.CountDone += 1;
                }
                vaccinationPlan.LastDone = DateTime.Now;
                if(CurrentVaccinationDate.Value.ToShortDateString() != DateTime.Now.ToShortDateString())
                {
                    vaccinationPlan.NextDone = CurrentVaccinationDate.Value;
                    var newPlan = _vaccinationPlanService.Update(vaccinationPlan.Id, vaccinationPlan);
                    if (newPlan is null)
                    {
                        MessageBox.Show("Что-то пошло не так");
                    }
                    else
                    {
                        MessageBox.Show("Инъекция зарегистрирована");
                        this.Close();
                    }
                }
                else
                {
                    MessageBox.Show("Введите дату следующей инъекции");
                }
                
            }
            catch (Exception)
            {

                throw;
            }
            
        }
    }
}
