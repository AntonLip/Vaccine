namespace Vaccine.Forms
{
    partial class PatientList
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
            VaccineGridView = new DataGridView();
            FirstName_DGV = new DataGridViewTextBoxColumn();
            LastName_DGV = new DataGridViewTextBoxColumn();
            Phone_DGV = new DataGridViewTextBoxColumn();
            Address_DGV = new DataGridViewTextBoxColumn();
            BirthDay_DGV = new DataGridViewTextBoxColumn();
            Sex_DGV = new DataGridViewTextBoxColumn();
            Remove_Btn = new Button();
            Add_Btn = new Button();
            Update_Btn = new Button();
            ((System.ComponentModel.ISupportInitialize)VaccineGridView).BeginInit();
            SuspendLayout();
            // 
            // VaccineGridView
            // 
            VaccineGridView.AllowUserToAddRows = false;
            VaccineGridView.AllowUserToDeleteRows = false;
            VaccineGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            VaccineGridView.Columns.AddRange(new DataGridViewColumn[] { FirstName_DGV, LastName_DGV, Phone_DGV, Address_DGV, BirthDay_DGV, Sex_DGV });
            VaccineGridView.Location = new Point(12, 12);
            VaccineGridView.Name = "VaccineGridView";
            VaccineGridView.ReadOnly = true;
            VaccineGridView.RowHeadersWidth = 51;
            VaccineGridView.RowTemplate.Height = 29;
            VaccineGridView.Size = new Size(806, 229);
            VaccineGridView.TabIndex = 0;
            // 
            // FirstName_DGV
            // 
            FirstName_DGV.HeaderText = "Имя";
            FirstName_DGV.MinimumWidth = 6;
            FirstName_DGV.Name = "FirstName_DGV";
            FirstName_DGV.ReadOnly = true;
            FirstName_DGV.Width = 125;
            // 
            // LastName_DGV
            // 
            LastName_DGV.HeaderText = "Фамилия";
            LastName_DGV.MinimumWidth = 6;
            LastName_DGV.Name = "LastName_DGV";
            LastName_DGV.ReadOnly = true;
            LastName_DGV.Width = 125;
            // 
            // Phone_DGV
            // 
            Phone_DGV.HeaderText = "Номер телефона";
            Phone_DGV.MinimumWidth = 6;
            Phone_DGV.Name = "Phone_DGV";
            Phone_DGV.ReadOnly = true;
            Phone_DGV.Width = 125;
            // 
            // Address_DGV
            // 
            Address_DGV.HeaderText = "Адрес";
            Address_DGV.MinimumWidth = 6;
            Address_DGV.Name = "Address_DGV";
            Address_DGV.ReadOnly = true;
            Address_DGV.Width = 125;
            // 
            // BirthDay_DGV
            // 
            BirthDay_DGV.HeaderText = "Дата рождения";
            BirthDay_DGV.MinimumWidth = 6;
            BirthDay_DGV.Name = "BirthDay_DGV";
            BirthDay_DGV.ReadOnly = true;
            BirthDay_DGV.Width = 125;
            // 
            // Sex_DGV
            // 
            Sex_DGV.HeaderText = "Пол";
            Sex_DGV.MinimumWidth = 6;
            Sex_DGV.Name = "Sex_DGV";
            Sex_DGV.ReadOnly = true;
            Sex_DGV.Width = 125;
            // 
            // Remove_Btn
            // 
            Remove_Btn.Location = new Point(694, 247);
            Remove_Btn.Name = "Remove_Btn";
            Remove_Btn.Size = new Size(94, 29);
            Remove_Btn.TabIndex = 1;
            Remove_Btn.Text = "Удалить";
            Remove_Btn.UseVisualStyleBackColor = true;
            Remove_Btn.Click += Remove_Btn_Click;
            // 
            // Add_Btn
            // 
            Add_Btn.Location = new Point(12, 247);
            Add_Btn.Name = "Add_Btn";
            Add_Btn.Size = new Size(94, 29);
            Add_Btn.TabIndex = 2;
            Add_Btn.Text = "Добавить";
            Add_Btn.UseVisualStyleBackColor = true;
            Add_Btn.Click += Add_Btn_Click;
            // 
            // Update_Btn
            // 
            Update_Btn.Location = new Point(344, 247);
            Update_Btn.Name = "Update_Btn";
            Update_Btn.Size = new Size(94, 29);
            Update_Btn.TabIndex = 3;
            Update_Btn.Text = "Изменить";
            Update_Btn.UseVisualStyleBackColor = true;
            Update_Btn.Click += Update_Btn_Click;
            // 
            // PatientList
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(856, 306);
            Controls.Add(Update_Btn);
            Controls.Add(Add_Btn);
            Controls.Add(Remove_Btn);
            Controls.Add(VaccineGridView);
            Name = "PatientList";
            Text = "Список пациентов";
            ((System.ComponentModel.ISupportInitialize)VaccineGridView).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView VaccineGridView;
        private Button Remove_Btn;
        private Button Add_Btn;
        private Button Update_Btn;
        private DataGridViewTextBoxColumn FirstName_DGV;
        private DataGridViewTextBoxColumn LastName_DGV;
        private DataGridViewTextBoxColumn Phone_DGV;
        private DataGridViewTextBoxColumn Address_DGV;
        private DataGridViewTextBoxColumn BirthDay_DGV;
        private DataGridViewTextBoxColumn Sex_DGV;
    }
}