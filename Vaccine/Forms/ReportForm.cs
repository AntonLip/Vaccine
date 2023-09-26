using Vaccine.Models.Interfaces.Services;

namespace Vaccine.Forms
{
    public partial class ReportForm : Form
    {
        private readonly IReportService _reportService;
        public ReportForm(IReportService reportService)
        {
            InitializeComponent();
            dateTimePicker1.Visible = false;
            dateTimePicker2.Visible = false;
            _reportService = reportService;
        }

        private void GenerateReport_Btn_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex == -1)
            {
                MessageBox.Show("Выберите тип отчета");
            }

            else
            {
                if (comboBox1.SelectedIndex == 0)
                {
                    try
                    {
                        _reportService.GetPatientReport();
                        MessageBox.Show("Файл сохранен в Папке Reports");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
                else if (comboBox1.SelectedIndex == 1)
                {
                    try
                    {
                        if (dateTimePicker1.Value.ToShortDateString() != DateTime.Today.ToShortDateString() ||
                        dateTimePicker2.Value.ToShortDateString() != DateTime.Today.ToShortDateString())
                        {
                            _reportService.GetPlan(dateTimePicker1.Value, dateTimePicker2.Value);
                            MessageBox.Show("Файл сохранен в Папке Reports");
                        }
                        else
                        {
                            MessageBox.Show("Выберите даты");
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
            }
        }
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex == 1)
            {
                dateTimePicker1.Visible = true;
                dateTimePicker2.Visible = true;
            }
            else if (comboBox1.SelectedIndex != 1)
            {
                dateTimePicker1.Visible = false;
                dateTimePicker2.Visible = false;
            }
        }
    }
}
