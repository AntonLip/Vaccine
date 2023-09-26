using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Vaccine.Models.DbModels;
using Vaccine.Models.Enums;
using Vaccine.Models.Interfaces.Services;

namespace Vaccine.Forms
{
    public partial class PatientList : Form
    {
        private readonly IPatientService _patientService;
        private List<Patient> _patients = new List<Patient>();
        public PatientList(IPatientService patientService)
        {
            InitializeComponent();
            _patientService = patientService;
            UpdateUI();
        }

        private void UpdateUI()
        {
            try
            {
                _patients.Clear();
                _patients = (List<Patient>)_patientService.GetAll();
                VaccineGridView.Rows.Clear();
                foreach (var patient in _patients)
                {
                    VaccineGridView.Rows.Add();
                    VaccineGridView[0, VaccineGridView.RowCount - 1].Value = patient.FirstName;
                    VaccineGridView[1, VaccineGridView.RowCount - 1].Value = patient.LastName;
                    VaccineGridView[2, VaccineGridView.RowCount - 1].Value = patient.Phone;
                    VaccineGridView[3, VaccineGridView.RowCount - 1].Value = patient.Address;
                    VaccineGridView[4, VaccineGridView.RowCount - 1].Value = patient.BirthDay.ToShortDateString();
                    VaccineGridView[5, VaccineGridView.RowCount - 1].Value = (Sex)patient.Sex;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void Remove_Btn_Click(object sender, EventArgs e)
        {
            try
            {
                var deleteItem = VaccineGridView.CurrentCell;
                if (deleteItem != null)
                {
                    var item = _patientService.Remove(_patients[(deleteItem.RowIndex)].Id);
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

        private void Add_Btn_Click(object sender, EventArgs e)
        {
            var form = new AddPatient(_patientService);
            form.Show();
        }

        private void Update_Btn_Click(object sender, EventArgs e)
        {
            var chooseItem = VaccineGridView.CurrentCell;
            var form = new UpdatePatientForm(_patientService, _patients[(chooseItem.RowIndex)]);
            form.Show();
            UpdateUI();
        }

        private void PatientList_Activated(object sender, EventArgs e)
        {
            UpdateUI();
        }
    }
}
