namespace Vaccine.Forms.VaccinesForm
{
    partial class VaccineInjectedForm
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
            Update_Btn = new Button();
            label1 = new Label();
            CurrentVaccinationDate = new DateTimePicker();
            FirstName_lbl = new Label();
            LastName_lbl = new Label();
            VaccineName_lbl = new Label();
            CountVaccine_lbl = new Label();
            SuspendLayout();
            // 
            // Update_Btn
            // 
            Update_Btn.Location = new Point(22, 156);
            Update_Btn.Name = "Update_Btn";
            Update_Btn.Size = new Size(296, 23);
            Update_Btn.TabIndex = 0;
            Update_Btn.Text = "Подтвердить";
            Update_Btn.UseVisualStyleBackColor = true;
            Update_Btn.Click += Update_Btn_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(22, 116);
            label1.Name = "label1";
            label1.Size = new Size(89, 15);
            label1.TabIndex = 1;
            label1.Text = "Дата инъекций";
            // 
            // CurrentVaccinationDate
            // 
            CurrentVaccinationDate.Location = new Point(118, 110);
            CurrentVaccinationDate.Name = "CurrentVaccinationDate";
            CurrentVaccinationDate.Size = new Size(200, 23);
            CurrentVaccinationDate.TabIndex = 2;
            // 
            // FirstName_lbl
            // 
            FirstName_lbl.AutoSize = true;
            FirstName_lbl.Location = new Point(22, 9);
            FirstName_lbl.Name = "FirstName_lbl";
            FirstName_lbl.Size = new Size(0, 15);
            FirstName_lbl.TabIndex = 3;
            // 
            // LastName_lbl
            // 
            LastName_lbl.AutoSize = true;
            LastName_lbl.Location = new Point(162, 9);
            LastName_lbl.Name = "LastName_lbl";
            LastName_lbl.Size = new Size(0, 15);
            LastName_lbl.TabIndex = 4;
            // 
            // VaccineName_lbl
            // 
            VaccineName_lbl.AutoSize = true;
            VaccineName_lbl.Location = new Point(22, 46);
            VaccineName_lbl.Name = "VaccineName_lbl";
            VaccineName_lbl.Size = new Size(0, 15);
            VaccineName_lbl.TabIndex = 5;
            // 
            // CountVaccine_lbl
            // 
            CountVaccine_lbl.AutoSize = true;
            CountVaccine_lbl.Location = new Point(22, 74);
            CountVaccine_lbl.Name = "CountVaccine_lbl";
            CountVaccine_lbl.Size = new Size(0, 15);
            CountVaccine_lbl.TabIndex = 6;
            // 
            // VaccineInjectedForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(367, 220);
            Controls.Add(CountVaccine_lbl);
            Controls.Add(VaccineName_lbl);
            Controls.Add(LastName_lbl);
            Controls.Add(FirstName_lbl);
            Controls.Add(CurrentVaccinationDate);
            Controls.Add(label1);
            Controls.Add(Update_Btn);
            Name = "VaccineInjectedForm";
            Text = "Ввод вакцины";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button Update_Btn;
        private Label label1;
        private DateTimePicker CurrentVaccinationDate;
        private Label FirstName_lbl;
        private Label LastName_lbl;
        private Label VaccineName_lbl;
        private Label CountVaccine_lbl;
    }
}