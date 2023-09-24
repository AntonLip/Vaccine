using Vaccine.Forms.VaccinesForm;
using Vaccine.Models.DbModels;
using Vaccine.Models.Enums;
using Vaccine.Models.Interfaces.Services;

namespace Vaccine.Forms
{
    public partial class VaccineListForm : Form
    {
        private readonly IVaccineService _patientService;
        private List<Vaccines> _vaccines = new List<Vaccines>();
        public VaccineListForm(IVaccineService vaccineService)
        {
            InitializeComponent();
            _patientService = vaccineService;
            UpdateUI();
        }

        private void Remove_Btn_ClickAsync(object sender, EventArgs e)
        {
            try
            {
                var deleteItem = VaccineGridView.CurrentCell;
                if (deleteItem != null)
                {
                    var item = _patientService.Remove(_vaccines[(deleteItem.RowIndex)].Id);
                    if (item is null)
                        MessageBox.Show("НЕ УДАЛИЛОСЬ");
                }
                else
                    MessageBox.Show("Сделайте выбор");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            UpdateUI();
        }

        private void UpdateUI()
        {
            try
            {
                int count = _patientService.GetCountEntity();
                _vaccines.Clear();
                _vaccines = (List<Vaccines>)_patientService.GetAll();
                VaccineGridView.Rows.Clear();
                foreach (var vacccine in _vaccines)
                {
                    VaccineGridView.Rows.Add();
                    VaccineGridView[0, VaccineGridView.RowCount - 1].Value = vacccine.Name;
                    VaccineGridView[1, VaccineGridView.RowCount - 1].Value = vacccine.Manufacturer;
                    VaccineGridView[2, VaccineGridView.RowCount - 1].Value = vacccine.Description;
                    VaccineGridView[3, VaccineGridView.RowCount - 1].Value = vacccine.Dosage;
                    VaccineGridView[4, VaccineGridView.RowCount - 1].Value = vacccine.StorageTemperature.ToString();
                    VaccineGridView[5, VaccineGridView.RowCount - 1].Value = (InjectionType)vacccine.InjectionType;
                    VaccineGridView[6, VaccineGridView.RowCount - 1].Value = (PrepareType)vacccine.PrepareType;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void Update_Btn_Click(object sender, EventArgs e)
        {
            var chooseItem = VaccineGridView.CurrentCell;
            if (chooseItem != null)
            {
                var form = new UpdateVaccineForm(_patientService, _vaccines[(chooseItem.RowIndex)]);
                form.Show();
            }
            else
                MessageBox.Show("Выберите вакцину");
        }
    }
}
