namespace Vaccine.Forms
{
    partial class AddVaccine
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
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            Add_Btn = new Button();
            InjectionType_Cb = new ComboBox();
            PrepareType_Cb = new ComboBox();
            Name_Tb = new TextBox();
            Manufacturer_Tb = new TextBox();
            Description_Tb = new TextBox();
            Dosage_Tb = new TextBox();
            StorageTemperature_Tb = new TextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 33);
            label1.Name = "label1";
            label1.Size = new Size(77, 20);
            label1.TabIndex = 0;
            label1.Text = "Название";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 77);
            label2.Name = "label2";
            label2.Size = new Size(79, 20);
            label2.TabIndex = 1;
            label2.Text = "Описание";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 118);
            label3.Name = "label3";
            label3.Size = new Size(131, 20);
            label3.TabIndex = 2;
            label3.Text = "Способ введения";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 156);
            label4.Name = "label4";
            label4.Size = new Size(172, 20);
            label4.TabIndex = 3;
            label4.Text = "Способ приготовления";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(12, 194);
            label5.Name = "label5";
            label5.Size = new Size(118, 20);
            label5.TabIndex = 4;
            label5.Text = "Производитель";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(12, 231);
            label6.Name = "label6";
            label6.Size = new Size(85, 20);
            label6.TabIndex = 5;
            label6.Text = "Дозировка";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(12, 265);
            label7.Name = "label7";
            label7.Size = new Size(171, 20);
            label7.TabIndex = 6;
            label7.Text = "Температура хранения";
            // 
            // Add_Btn
            // 
            Add_Btn.Location = new Point(158, 310);
            Add_Btn.Name = "Add_Btn";
            Add_Btn.Size = new Size(94, 29);
            Add_Btn.TabIndex = 7;
            Add_Btn.Text = "Добавить";
            Add_Btn.UseVisualStyleBackColor = true;
            Add_Btn.Click += Add_Btn_Click;
            // 
            // InjectionType_Cb
            // 
            InjectionType_Cb.FormattingEnabled = true;
            InjectionType_Cb.Location = new Point(208, 114);
            InjectionType_Cb.Name = "InjectionType_Cb";
            InjectionType_Cb.Size = new Size(193, 28);
            InjectionType_Cb.TabIndex = 8;
            // 
            // PrepareType_Cb
            // 
            PrepareType_Cb.FormattingEnabled = true;
            PrepareType_Cb.Location = new Point(208, 152);
            PrepareType_Cb.Name = "PrepareType_Cb";
            PrepareType_Cb.Size = new Size(193, 28);
            PrepareType_Cb.TabIndex = 9;
            // 
            // Name_Tb
            // 
            Name_Tb.Location = new Point(208, 30);
            Name_Tb.Name = "Name_Tb";
            Name_Tb.Size = new Size(193, 27);
            Name_Tb.TabIndex = 10;
            // 
            // Manufacturer_Tb
            // 
            Manufacturer_Tb.Location = new Point(209, 191);
            Manufacturer_Tb.Name = "Manufacturer_Tb";
            Manufacturer_Tb.Size = new Size(192, 27);
            Manufacturer_Tb.TabIndex = 11;
            // 
            // Description_Tb
            // 
            Description_Tb.Location = new Point(208, 74);
            Description_Tb.Name = "Description_Tb";
            Description_Tb.Size = new Size(193, 27);
            Description_Tb.TabIndex = 12;
            // 
            // Dosage_Tb
            // 
            Dosage_Tb.Location = new Point(208, 228);
            Dosage_Tb.Name = "Dosage_Tb";
            Dosage_Tb.Size = new Size(193, 27);
            Dosage_Tb.TabIndex = 13;
            // 
            // StorageTemperature_Tb
            // 
            StorageTemperature_Tb.Location = new Point(208, 262);
            StorageTemperature_Tb.Name = "StorageTemperature_Tb";
            StorageTemperature_Tb.Size = new Size(193, 27);
            StorageTemperature_Tb.TabIndex = 14;
            // 
            // AddVaccine
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(456, 369);
            Controls.Add(StorageTemperature_Tb);
            Controls.Add(Dosage_Tb);
            Controls.Add(Description_Tb);
            Controls.Add(Manufacturer_Tb);
            Controls.Add(Name_Tb);
            Controls.Add(PrepareType_Cb);
            Controls.Add(InjectionType_Cb);
            Controls.Add(Add_Btn);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "AddVaccine";
            Text = "Добавить вакцину";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        public Label label2;
        private Button Add_Btn;
        private ComboBox InjectionType_Cb;
        private ComboBox PrepareType_Cb;
        private TextBox Name_Tb;
        private TextBox Manufacturer_Tb;
        private TextBox Description_Tb;
        private TextBox Dosage_Tb;
        private TextBox StorageTemperature_Tb;
    }
}