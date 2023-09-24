namespace Vaccine.Forms
{
    partial class VaccineListForm
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
            Name = new DataGridViewTextBoxColumn();
            Manufactor = new DataGridViewTextBoxColumn();
            Describe = new DataGridViewTextBoxColumn();
            Dosage = new DataGridViewTextBoxColumn();
            StorageTemperature = new DataGridViewTextBoxColumn();
            InjectionType = new DataGridViewTextBoxColumn();
            PrepareType = new DataGridViewTextBoxColumn();
            Remove_Btn = new Button();
            Update_Btn = new Button();
            Add_Btn = new Button();
            ((System.ComponentModel.ISupportInitialize)VaccineGridView).BeginInit();
            SuspendLayout();
            // 
            // VaccineGridView
            // 
            VaccineGridView.AllowUserToAddRows = false;
            VaccineGridView.AllowUserToDeleteRows = false;
            VaccineGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            VaccineGridView.Columns.AddRange(new DataGridViewColumn[] { Name, Manufactor, Describe, Dosage, StorageTemperature, InjectionType, PrepareType });
            VaccineGridView.Location = new Point(12, 12);
            VaccineGridView.Name = "VaccineGridView";
            VaccineGridView.ReadOnly = true;
            VaccineGridView.RowHeadersWidth = 51;
            VaccineGridView.RowTemplate.Height = 29;
            VaccineGridView.Size = new Size(932, 225);
            VaccineGridView.TabIndex = 0;
            // 
            // Name
            // 
            Name.HeaderText = "Название";
            Name.MinimumWidth = 6;
            Name.Name = "Name";
            Name.ReadOnly = true;
            Name.Width = 125;
            // 
            // Manufactor
            // 
            Manufactor.HeaderText = "Производитель";
            Manufactor.MinimumWidth = 6;
            Manufactor.Name = "Manufactor";
            Manufactor.ReadOnly = true;
            Manufactor.Width = 125;
            // 
            // Describe
            // 
            Describe.HeaderText = "Описание";
            Describe.MinimumWidth = 6;
            Describe.Name = "Describe";
            Describe.ReadOnly = true;
            Describe.Width = 125;
            // 
            // Dosage
            // 
            Dosage.HeaderText = "Дозировка";
            Dosage.MinimumWidth = 6;
            Dosage.Name = "Dosage";
            Dosage.ReadOnly = true;
            Dosage.Width = 125;
            // 
            // StorageTemperature
            // 
            StorageTemperature.HeaderText = "Температура хранения";
            StorageTemperature.MinimumWidth = 6;
            StorageTemperature.Name = "StorageTemperature";
            StorageTemperature.ReadOnly = true;
            StorageTemperature.Width = 125;
            // 
            // InjectionType
            // 
            InjectionType.HeaderText = "Способ введения";
            InjectionType.MinimumWidth = 6;
            InjectionType.Name = "InjectionType";
            InjectionType.ReadOnly = true;
            InjectionType.Width = 125;
            // 
            // PrepareType
            // 
            PrepareType.HeaderText = "Способ приготовления";
            PrepareType.MinimumWidth = 6;
            PrepareType.Name = "PrepareType";
            PrepareType.ReadOnly = true;
            PrepareType.Width = 125;
            // 
            // Remove_Btn
            // 
            Remove_Btn.Location = new Point(685, 254);
            Remove_Btn.Name = "Remove_Btn";
            Remove_Btn.Size = new Size(94, 29);
            Remove_Btn.TabIndex = 1;
            Remove_Btn.Text = "Удалить";
            Remove_Btn.UseVisualStyleBackColor = true;
            Remove_Btn.Click += Remove_Btn_ClickAsync;
            // 
            // Update_Btn
            // 
            Update_Btn.Location = new Point(361, 254);
            Update_Btn.Name = "Update_Btn";
            Update_Btn.Size = new Size(94, 29);
            Update_Btn.TabIndex = 2;
            Update_Btn.Text = "Изменить";
            Update_Btn.UseVisualStyleBackColor = true;
            Update_Btn.Click += Update_Btn_Click;
            // 
            // Add_Btn
            // 
            Add_Btn.Location = new Point(12, 254);
            Add_Btn.Name = "Add_Btn";
            Add_Btn.Size = new Size(94, 29);
            Add_Btn.TabIndex = 3;
            Add_Btn.Text = "Добавить";
            Add_Btn.UseVisualStyleBackColor = true;
            // 
            // VaccineListForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(955, 296);
            Controls.Add(Add_Btn);
            Controls.Add(Update_Btn);
            Controls.Add(Remove_Btn);
            Controls.Add(VaccineGridView);

            Text = "Список вакцин";
            ((System.ComponentModel.ISupportInitialize)VaccineGridView).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView VaccineGridView;
        private Button Remove_Btn;
        private Button Update_Btn;
        private Button Add_Btn;
        private DataGridViewTextBoxColumn Name;
        private DataGridViewTextBoxColumn Manufactor;
        private DataGridViewTextBoxColumn Describe;
        private DataGridViewTextBoxColumn Dosage;
        private DataGridViewTextBoxColumn StorageTemperature;
        private DataGridViewTextBoxColumn InjectionType;
        private DataGridViewTextBoxColumn PrepareType;
    }
}