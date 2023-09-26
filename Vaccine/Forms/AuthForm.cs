using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Vaccine.Models.Interfaces.Services;

namespace Vaccine.Forms
{
    public partial class AuthForm : Form
    {
        private readonly IPatientService _petientService;
        private readonly IVaccineService _vicineService;
        private readonly IVaccinationPlanService _planService;
        private readonly IReportService _reportService;
        public AuthForm(IPatientService patientService, IVaccinationPlanService vaccinationPlanService,
            IReportService reportService, IVaccineService vaccineService)
        {
            InitializeComponent();
            _petientService = patientService;
            _vicineService = vaccineService;
            _reportService = reportService;
            _planService = vaccinationPlanService;
        }

        private void SignIn_Btn_Click(object sender, EventArgs e)
        {
            if (Login_Tb.Text == "Admin" && Password_Tb.Text == "123")
            {
                var main = new MainForm(_petientService, _vicineService, _planService, _reportService);
                main.Show();
                Hide();
            }
            else
            {
                MessageBox.Show("Введите правильные данные");
            }

        }
    }
}
