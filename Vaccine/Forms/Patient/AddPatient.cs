using System.Text.RegularExpressions;
using Vaccine.Models.DbModels;
using Vaccine.Models.Enums;
using Vaccine.Models.Interfaces.Services;

namespace Vaccine.Forms
{
    public partial class AddPatient : Form
    {
        private readonly IPatientService _patientService;
        public AddPatient(IPatientService patientService)
        {
            InitializeComponent();
            _patientService = patientService;
        }

        private void Create_Btn_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(FirstName_Tb.Text) || String.IsNullOrEmpty(LastName_Tb.Text)
                && String.IsNullOrEmpty(Address_Tb.Text) || String.IsNullOrEmpty(Phone_tb.Text))
            {
                MessageBox.Show("Заполните данные пациента");
            }
            else if (Birthday_Dtp.Value.ToShortDateString() == DateTime.Today.ToShortDateString())
            {
                MessageBox.Show("Заполните данные пациента");

            }
            else if (Sex_Cb.SelectedIndex == -1)
            {
                MessageBox.Show("Заполните данные пациента");

            }
            else
            {
                Regex regexObj = new Regex(@"^\+?(\d[\d-. ]+)?(\([\d-. ]+\))?[\d-. ]+\d$");
                if (!regexObj.IsMatch(Phone_tb.Text))
                {
                    MessageBox.Show("Проверьте номер телефона");
                }
                else
                {
                    Patient patient = new Patient
                    {
                        Address = Address_Tb.Text,
                        Phone = Phone_tb.Text,
                        BirthDay = Birthday_Dtp.Value,
                        FirstName = FirstName_Tb.Text,
                        LastName = LastName_Tb.Text,
                        Sex = (Sex)Sex_Cb.SelectedIndex
                    };
                    var createdPatient = _patientService.Add(patient);
                    if (createdPatient != null)
                    {
                        MessageBox.Show($"{createdPatient.FirstName} {createdPatient.LastName} успешно добавлен");
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Что-то пошло не так");
                    }
                }
            }
        }
    }
}
