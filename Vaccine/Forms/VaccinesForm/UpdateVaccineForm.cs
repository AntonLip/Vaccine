using Vaccine.Models.DbModels;
using Vaccine.Models.Enums;
using Vaccine.Models.Interfaces.Services;

namespace Vaccine.Forms.VaccinesForm
{
    public partial class UpdateVaccineForm : Form
    {
        private readonly IVaccineService _vaccineService;
        Guid _vaccineId;
        public UpdateVaccineForm(IVaccineService vaccineService, Vaccines vaccines)
        {
            InitializeComponent();
            InjectionType_Cb.DataSource = Enum.GetValues(typeof(InjectionType));
            PrepareType_Cb.DataSource = Enum.GetValues(typeof(PrepareType));
            Name_Tb.Text = vaccines.Name;
            _vaccineId = vaccines.Id;
            InjectionType_Cb.SelectedIndex = (int)vaccines.InjectionType;
            PrepareType_Cb.SelectedIndex = (int)vaccines.PrepareType;
            Description_Tb.Text = vaccines.Description;
            Manufacturer_Tb.Text = vaccines.Manufacturer;
            Dosage_Tb.Text = vaccines.Dosage;
            StorageTemperature_Tb.Text = vaccines.StorageTemperature.ToString();
            _vaccineService = vaccineService;
        }
        private void Update_Btn_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(Name_Tb.Text) || String.IsNullOrEmpty(Manufacturer_Tb.Text)
              || String.IsNullOrEmpty(Dosage_Tb.Text) || String.IsNullOrEmpty(Description_Tb.Text)
              || String.IsNullOrEmpty(StorageTemperature_Tb.Text))
            {
                MessageBox.Show("Заполните данные пациента");
            }
            else
            {
                if (InjectionType_Cb.SelectedIndex != -1 || PrepareType_Cb.SelectedIndex != -1)
                {
                    try
                    {
                        int storageTemperature = int.Parse(StorageTemperature_Tb.Text);
                        Vaccines vaccines = new Vaccines
                        {
                            Id = _vaccineId,
                            Description = Description_Tb.Text,
                            StorageTemperature = storageTemperature,
                            Dosage = Dosage_Tb.Text,
                            InjectionType = (InjectionType)InjectionType_Cb.SelectedIndex,
                            Manufacturer = Manufacturer_Tb.Text,
                            Name = Name_Tb.Text,
                            PrepareType = (PrepareType)PrepareType_Cb.SelectedIndex
                        };
                        var newVaccine = _vaccineService.Update(_vaccineId, vaccines);
                        if (newVaccine != null)
                        {
                            MessageBox.Show("Успешно вакцина добавлена");
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
    }
}
