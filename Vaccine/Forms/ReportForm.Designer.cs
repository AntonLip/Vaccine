namespace Vaccine.Forms
{
    partial class ReportForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            GenerateReport_Btn = new Button();
            label1 = new Label();
            comboBox1 = new ComboBox();
            dateTimePicker1 = new DateTimePicker();
            dateTimePicker2 = new DateTimePicker();
            SuspendLayout();
            // 
            // GenerateReport_Btn
            // 
            GenerateReport_Btn.Location = new Point(12, 151);
            GenerateReport_Btn.Name = "GenerateReport_Btn";
            GenerateReport_Btn.Size = new Size(200, 23);
            GenerateReport_Btn.TabIndex = 0;
            GenerateReport_Btn.Text = "Сгенерировать";
            GenerateReport_Btn.UseVisualStyleBackColor = true;
            GenerateReport_Btn.Click += GenerateReport_Btn_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(83, 10);
            label1.Name = "label1";
            label1.Size = new Size(66, 15);
            label1.TabIndex = 1;
            label1.Text = "Тип отчета";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Список вакцинированных", "План вакцинации" });
            comboBox1.Location = new Point(12, 28);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(200, 23);
            comboBox1.TabIndex = 2;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(12, 67);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(200, 23);
            dateTimePicker1.TabIndex = 3;
            dateTimePicker1.Visible = false;
            // 
            // dateTimePicker2
            // 
            dateTimePicker2.Location = new Point(12, 107);
            dateTimePicker2.Name = "dateTimePicker2";
            dateTimePicker2.Size = new Size(200, 23);
            dateTimePicker2.TabIndex = 4;
            dateTimePicker2.Visible = false;
            // 
            // ReportForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(261, 202);
            Controls.Add(dateTimePicker2);
            Controls.Add(dateTimePicker1);
            Controls.Add(comboBox1);
            Controls.Add(label1);
            Controls.Add(GenerateReport_Btn);
            Name = "ReportForm";
            Text = "Отчеты";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button GenerateReport_Btn;
        private Label label1;
        private ComboBox comboBox1;
        private DateTimePicker dateTimePicker1;
        private DateTimePicker dateTimePicker2;
    }
}