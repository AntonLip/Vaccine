namespace Vaccine.Forms.VaccinePlanForms
{
    partial class ListVaccinationPlanForm
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
            VaccinationPlanGridView = new DataGridView();
            Patient = new DataGridViewTextBoxColumn();
            Vaccine = new DataGridViewTextBoxColumn();
            InjectionNeed = new DataGridViewTextBoxColumn();
            InjectionCount = new DataGridViewTextBoxColumn();
            LastInjection = new DataGridViewTextBoxColumn();
            NextInjection = new DataGridViewTextBoxColumn();
            groupBox1 = new GroupBox();
            StartInjectionDate = new DateTimePicker();
            EndInjectionDate = new DateTimePicker();
            label4 = new Label();
            label3 = new Label();
            Find_Btn = new Button();
            label2 = new Label();
            Vaccine_Cb = new ComboBox();
            label1 = new Label();
            Patient_Cb = new ComboBox();
            Refresh_Btn = new Button();
            ((System.ComponentModel.ISupportInitialize)VaccinationPlanGridView).BeginInit();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // VaccinationPlanGridView
            // 
            VaccinationPlanGridView.AllowUserToAddRows = false;
            VaccinationPlanGridView.AllowUserToDeleteRows = false;
            VaccinationPlanGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            VaccinationPlanGridView.Columns.AddRange(new DataGridViewColumn[] { Patient, Vaccine, InjectionNeed, InjectionCount, LastInjection, NextInjection });
            VaccinationPlanGridView.Location = new Point(12, 12);
            VaccinationPlanGridView.Name = "VaccinationPlanGridView";
            VaccinationPlanGridView.ReadOnly = true;
            VaccinationPlanGridView.RowHeadersWidth = 51;
            VaccinationPlanGridView.RowTemplate.Height = 29;
            VaccinationPlanGridView.Size = new Size(1072, 250);
            VaccinationPlanGridView.TabIndex = 0;
            // 
            // Patient
            // 
            Patient.HeaderText = "Пациент";
            Patient.MinimumWidth = 6;
            Patient.Name = "Patient";
            Patient.ReadOnly = true;
            Patient.Width = 150;
            // 
            // Vaccine
            // 
            Vaccine.HeaderText = "Вакцина";
            Vaccine.MinimumWidth = 6;
            Vaccine.Name = "Vaccine";
            Vaccine.ReadOnly = true;
            Vaccine.Width = 125;
            // 
            // InjectionNeed
            // 
            InjectionNeed.HeaderText = "Сделано инъекций";
            InjectionNeed.MinimumWidth = 6;
            InjectionNeed.Name = "InjectionNeed";
            InjectionNeed.ReadOnly = true;
            InjectionNeed.Width = 170;
            // 
            // InjectionCount
            // 
            InjectionCount.HeaderText = "Всего инъекций";
            InjectionCount.MinimumWidth = 6;
            InjectionCount.Name = "InjectionCount";
            InjectionCount.ReadOnly = true;
            InjectionCount.Width = 170;
            // 
            // LastInjection
            // 
            LastInjection.HeaderText = "Последняя Инъекция";
            LastInjection.MinimumWidth = 6;
            LastInjection.Name = "LastInjection";
            LastInjection.ReadOnly = true;
            LastInjection.Width = 200;
            // 
            // NextInjection
            // 
            NextInjection.HeaderText = "Следующая инъекция";
            NextInjection.MinimumWidth = 6;
            NextInjection.Name = "NextInjection";
            NextInjection.ReadOnly = true;
            NextInjection.Width = 200;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(Refresh_Btn);
            groupBox1.Controls.Add(StartInjectionDate);
            groupBox1.Controls.Add(EndInjectionDate);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(Find_Btn);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(Vaccine_Cb);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(Patient_Cb);
            groupBox1.Location = new Point(45, 268);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(1003, 187);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "Поиск";
            // 
            // StartInjectionDate
            // 
            StartInjectionDate.Location = new Point(714, 35);
            StartInjectionDate.Name = "StartInjectionDate";
            StartInjectionDate.Size = new Size(250, 27);
            StartInjectionDate.TabIndex = 9;
            // 
            // EndInjectionDate
            // 
            EndInjectionDate.Location = new Point(714, 71);
            EndInjectionDate.Name = "EndInjectionDate";
            EndInjectionDate.Size = new Size(250, 27);
            EndInjectionDate.TabIndex = 8;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(518, 79);
            label4.Name = "label4";
            label4.Size = new Size(151, 20);
            label4.TabIndex = 7;
            label4.Text = "Ввести инъекции по";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(518, 34);
            label3.Name = "label3";
            label3.Size = new Size(140, 20);
            label3.TabIndex = 5;
            label3.Text = "Ввести инъекции с";
            // 
            // Find_Btn
            // 
            Find_Btn.Location = new Point(6, 116);
            Find_Btn.Name = "Find_Btn";
            Find_Btn.Size = new Size(983, 29);
            Find_Btn.TabIndex = 4;
            Find_Btn.Text = "Поиск";
            Find_Btn.UseVisualStyleBackColor = true;
            Find_Btn.Click += Find_Btn_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(6, 79);
            label2.Name = "label2";
            label2.Size = new Size(68, 20);
            label2.TabIndex = 3;
            label2.Text = "Вакцина";
            // 
            // Vaccine_Cb
            // 
            Vaccine_Cb.FormattingEnabled = true;
            Vaccine_Cb.Location = new Point(157, 71);
            Vaccine_Cb.Name = "Vaccine_Cb";
            Vaccine_Cb.Size = new Size(320, 28);
            Vaccine_Cb.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(6, 34);
            label1.Name = "label1";
            label1.Size = new Size(69, 20);
            label1.TabIndex = 1;
            label1.Text = "Пациент";
            // 
            // Patient_Cb
            // 
            Patient_Cb.FormattingEnabled = true;
            Patient_Cb.Location = new Point(157, 34);
            Patient_Cb.Name = "Patient_Cb";
            Patient_Cb.Size = new Size(320, 28);
            Patient_Cb.TabIndex = 0;
            // 
            // Refresh_Btn
            // 
            Refresh_Btn.Location = new Point(6, 151);
            Refresh_Btn.Name = "Refresh_Btn";
            Refresh_Btn.Size = new Size(983, 29);
            Refresh_Btn.TabIndex = 10;
            Refresh_Btn.Text = "Сбросить параметры поиска";
            Refresh_Btn.UseVisualStyleBackColor = true;
            Refresh_Btn.Click += Refresh_Btn_Click;
            // 
            // ListVaccinationPlanForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1125, 467);
            Controls.Add(groupBox1);
            Controls.Add(VaccinationPlanGridView);
            Name = "ListVaccinationPlanForm";
            Text = "ListVaccinationPlanForm";
            ((System.ComponentModel.ISupportInitialize)VaccinationPlanGridView).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView VaccinationPlanGridView;
        private DataGridViewTextBoxColumn Patient;
        private DataGridViewTextBoxColumn Vaccine;
        private DataGridViewTextBoxColumn InjectionNeed;
        private DataGridViewTextBoxColumn InjectionCount;
        private DataGridViewTextBoxColumn LastInjection;
        private DataGridViewTextBoxColumn NextInjection;
        private GroupBox groupBox1;
        private Label label3;
        private Button Find_Btn;
        private Label label2;
        private ComboBox Vaccine_Cb;
        private Label label1;
        private ComboBox Patient_Cb;
        private Label label4;
        private DateTimePicker StartInjectionDate;
        private DateTimePicker EndInjectionDate;
        private Button Refresh_Btn;
    }
}