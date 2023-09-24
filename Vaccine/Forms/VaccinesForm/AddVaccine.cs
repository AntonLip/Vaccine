using Vaccine.Models.DbModels;
using Vaccine.Models.Enums;
using Vaccine.Models.Interfaces.Services;

namespace Vaccine.Forms
{
    public partial class AddVaccine : Form
    {
        private readonly IVaccineService _vaccineService;
        public AddVaccine(IVaccineService vaccineService)
        {
            InitializeComponent();
            InjectionType_Cb.DataSource = Enum.GetValues(typeof(InjectionType));
            PrepareType_Cb.DataSource = Enum.GetValues(typeof(PrepareType));
            _vaccineService = vaccineService;
        }

        private void Add_Btn_Click(object sender, EventArgs e)
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
                            Description = Description_Tb.Text,
                            StorageTemperature = storageTemperature,
                            Dosage = Dosage_Tb.Text,
                            InjectionType = (InjectionType)InjectionType_Cb.SelectedIndex,
                            Manufacturer = Manufacturer_Tb.Text,
                            Name = Name_Tb.Text,
                            PrepareType = (PrepareType)PrepareType_Cb.SelectedIndex
                        };
                        var newVaccine = _vaccineService.Add(vaccines);
                        if (newVaccine != null)
                        {
                            MessageBox.Show("Успешно вакцина добавлена");
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
