namespace Vaccine.Forms.VaccinePlanForms
{
    partial class AddVaccinePlanForm
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            Patient_Cb = new ComboBox();
            Vaccine_Cb = new ComboBox();
            InjectionCount_Tb = new TextBox();
            InjectionDate_Dtp = new DateTimePicker();
            Add_Btn = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(69, 20);
            label1.TabIndex = 0;
            label1.Text = "Пациент";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 55);
            label2.Name = "label2";
            label2.Size = new Size(68, 20);
            label2.TabIndex = 1;
            label2.Text = "Вакцина";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 105);
            label3.Name = "label3";
            label3.Size = new Size(163, 20);
            label3.TabIndex = 2;
            label3.Text = "Количество инъекций";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 157);
            label4.Name = "label4";
            label4.Size = new Size(114, 20);
            label4.TabIndex = 3;
            label4.Text = "Дата инъекции";
            // 
            // Patient_Cb
            // 
            Patient_Cb.FormattingEnabled = true;
            Patient_Cb.Location = new Point(208, 6);
            Patient_Cb.Name = "Patient_Cb";
            Patient_Cb.Size = new Size(250, 28);
            Patient_Cb.TabIndex = 4;
            // 
            // Vaccine_Cb
            // 
            Vaccine_Cb.FormattingEnabled = true;
            Vaccine_Cb.Location = new Point(208, 55);
            Vaccine_Cb.Name = "Vaccine_Cb";
            Vaccine_Cb.Size = new Size(250, 28);
            Vaccine_Cb.TabIndex = 5;
            // 
            // InjectionCount_Tb
            // 
            InjectionCount_Tb.Location = new Point(208, 105);
            InjectionCount_Tb.Name = "InjectionCount_Tb";
            InjectionCount_Tb.Size = new Size(250, 27);
            InjectionCount_Tb.TabIndex = 6;
            // 
            // InjectionDate_Dtp
            // 
            InjectionDate_Dtp.Location = new Point(208, 157);
            InjectionDate_Dtp.Name = "InjectionDate_Dtp";
            InjectionDate_Dtp.Size = new Size(250, 27);
            InjectionDate_Dtp.TabIndex = 7;
            // 
            // Add_Btn
            // 
            Add_Btn.Location = new Point(12, 211);
            Add_Btn.Name = "Add_Btn";
            Add_Btn.Size = new Size(446, 29);
            Add_Btn.TabIndex = 8;
            Add_Btn.Text = "Добавить";
            Add_Btn.UseVisualStyleBackColor = true;
            Add_Btn.Click += Add_Btn_Click;
            // 
            // AddVaccinePlanForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(499, 267);
            Controls.Add(Add_Btn);
            Controls.Add(InjectionDate_Dtp);
            Controls.Add(InjectionCount_Tb);
            Controls.Add(Vaccine_Cb);
            Controls.Add(Patient_Cb);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "AddVaccinePlanForm";
            Text = "AddVaccinePlanForm";
            Load += AddVaccinePlanForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private ComboBox Patient_Cb;
        private ComboBox Vaccine_Cb;
        private TextBox InjectionCount_Tb;
        private DateTimePicker InjectionDate_Dtp;
        private Button Add_Btn;
    }
}