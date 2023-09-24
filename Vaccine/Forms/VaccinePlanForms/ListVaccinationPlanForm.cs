using Vaccine.Models.DbModels;
using Vaccine.Models.Interfaces.Services;

namespace Vaccine.Forms.VaccinePlanForms
{
    public partial class ListVaccinationPlanForm : Form
    {
        private readonly IPatientService _petientService;
        private readonly IVaccinationPlanService _vaccinationPlanService;
        private readonly IVaccineService _vaccineService;
        private List<Patient> _patients;
        private List<Vaccines> _vaccines;
        private List<VaccinationPlan> _vaccinationPlans = new List<VaccinationPlan>();
        public ListVaccinationPlanForm(IPatientService patientService, IVaccinationPlanService vaccinationPlanService,
            IVaccineService vaccineService)
        {
            InitializeComponent();
            _petientService = patientService;
            _vaccinationPlanService = vaccinationPlanService;
            _vaccineService = vaccineService;
            UpadteCompobox();
            Refresh();

        }

        private void Find_Btn_Click(object sender, EventArgs e)
        {
            List<VaccinationPlan> vaccinationPlans = null;

            if (Patient_Cb.SelectedIndex != -1)
            {
                if(vaccinationPlans is null)
                {
                    vaccinationPlans = _vaccinationPlans.
                        Where(p => p.PatientId == _patients[Patient_Cb.SelectedIndex].Id).ToList();
                }
            }
            if (Vaccine_Cb.SelectedIndex != -1)
            {
                if (vaccinationPlans is null)
                {
                    vaccinationPlans = _vaccinationPlans.
                        Where(p => p.VaccineId == _vaccines[Vaccine_Cb.SelectedIndex].Id).ToList();
                }
                else
                {
                    //vaccinationPlans = _vaccinationPlans
                }
            }
            
            if (StartInjectionDate.Value.ToShortDateString() != DateTime.Now.ToShortDateString() &&
                EndInjectionDate.Value.ToShortDateString() == DateTime.Now.ToShortDateString())
            {
                if (vaccinationPlans.Count > 0)
                {
                    vaccinationPlans.AddRange(_vaccinationPlans.Where(p => p.NextDone.Date > StartInjectionDate.Value.Date));
                }
                else
                {
                    vaccinationPlans.AddRange(_vaccinationPlans.Where(p => p.NextDone.Date > StartInjectionDate.Value.Date));
                }
            }
            if (StartInjectionDate.Value.ToShortDateString() == DateTime.Now.ToShortDateString() &&
                EndInjectionDate.Value.ToShortDateString() != DateTime.Now.ToShortDateString())
            {
                if (vaccinationPlans.Count > 0)
                {
                    vaccinationPlans.AddRange(_vaccinationPlans.Where(p => p.NextDone.Date < EndInjectionDate.Value.Date));
                }
                else
                {
                    vaccinationPlans.AddRange(_vaccinationPlans.Where(p => p.NextDone.Date < EndInjectionDate.Value.Date));
                }
            }
            if (StartInjectionDate.Value.ToShortDateString() != DateTime.Now.ToShortDateString() &&
                EndInjectionDate.Value.ToShortDateString() != DateTime.Now.ToShortDateString())
            {
                if (vaccinationPlans.Count > 0)
                {
                    vaccinationPlans.AddRange(_vaccinationPlans.
                        Where(p => p.NextDone.Date < EndInjectionDate.Value.Date && p.NextDone.Date > StartInjectionDate.Value.Date));
                }
                else
                {
                    vaccinationPlans.AddRange(_vaccinationPlans.
                        Where(p => p.NextDone.Date < EndInjectionDate.Value.Date && p.NextDone.Date > StartInjectionDate.Value.Date));
                }
            }
            UpdateDataGridView(vaccinationPlans);
        }

        private void UpadteCompobox()
        {
            try
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
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void UpdateDataGridView(List<VaccinationPlan> vaccinationPlans)
        {
            try
            {
                VaccinationPlanGridView.Rows.Clear();
                foreach (var vaccinationPlan in vaccinationPlans)
                {
                    VaccinationPlanGridView.Rows.Add();
                    var patient = _petientService.GetById(vaccinationPlan.PatientId);
                    VaccinationPlanGridView[0, VaccinationPlanGridView.RowCount - 1].Value = $"{patient.FirstName} {patient.LastName}";
                    var vaccine = _vaccineService.GetById(vaccinationPlan.VaccineId);
                    VaccinationPlanGridView[1, VaccinationPlanGridView.RowCount - 1].Value = vaccine.Name;
                    VaccinationPlanGridView[2, VaccinationPlanGridView.RowCount - 1].Value = vaccinationPlan.CountDone;
                    VaccinationPlanGridView[3, VaccinationPlanGridView.RowCount - 1].Value = vaccinationPlan.CountNeed;
                    if (vaccinationPlan.LastDone == DateTime.MinValue)
                        VaccinationPlanGridView[4, VaccinationPlanGridView.RowCount - 1].Value = "Не вводилась";
                    else
                        VaccinationPlanGridView[4, VaccinationPlanGridView.RowCount - 1].Value = vaccinationPlan.LastDone;
                    if (vaccinationPlan.Isfulfill)
                        VaccinationPlanGridView[5, VaccinationPlanGridView.RowCount - 1].Value = "Все введено";
                    else
                        VaccinationPlanGridView[5, VaccinationPlanGridView.RowCount - 1].Value = vaccinationPlan.NextDone;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }


        private void Refresh()
        {
            var vaccinationPlan = _vaccinationPlanService.GetAll();
            _vaccinationPlans = vaccinationPlan.ToList();
            UpdateDataGridView(vaccinationPlan.ToList());
        }

        private void Refresh_Btn_Click(object sender, EventArgs e)
        {
            Refresh();
        }
    }
}
