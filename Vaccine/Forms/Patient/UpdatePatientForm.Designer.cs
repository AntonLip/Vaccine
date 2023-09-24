namespace Vaccine.Forms
{
    partial class UpdatePatientForm
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
            Birthday_Dtp = new DateTimePicker();
            Sex_Cb = new ComboBox();
            Address_Tb = new TextBox();
            Phone_tb = new TextBox();
            LastName_Tb = new TextBox();
            FirstName_Tb = new TextBox();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            Update_Btn = new Button();
            SuspendLayout();
            // 
            // Birthday_Dtp
            // 
            Birthday_Dtp.Location = new Point(184, 149);
            Birthday_Dtp.Name = "Birthday_Dtp";
            Birthday_Dtp.Size = new Size(246, 27);
            Birthday_Dtp.TabIndex = 26;
            // 
            // Sex_Cb
            // 
            Sex_Cb.FormattingEnabled = true;
            Sex_Cb.Items.AddRange(new object[] { "Мужской", "Женский" });
            Sex_Cb.Location = new Point(184, 185);
            Sex_Cb.Name = "Sex_Cb";
            Sex_Cb.Size = new Size(246, 28);
            Sex_Cb.TabIndex = 25;
            // 
            // Address_Tb
            // 
            Address_Tb.Location = new Point(184, 115);
            Address_Tb.Name = "Address_Tb";
            Address_Tb.Size = new Size(246, 27);
            Address_Tb.TabIndex = 24;
            // 
            // Phone_tb
            // 
            Phone_tb.Location = new Point(184, 79);
            Phone_tb.Name = "Phone_tb";
            Phone_tb.Size = new Size(246, 27);
            Phone_tb.TabIndex = 23;
            // 
            // LastName_Tb
            // 
            LastName_Tb.Location = new Point(184, 43);
            LastName_Tb.Name = "LastName_Tb";
            LastName_Tb.Size = new Size(246, 27);
            LastName_Tb.TabIndex = 22;
            // 
            // FirstName_Tb
            // 
            FirstName_Tb.Location = new Point(184, 7);
            FirstName_Tb.Name = "FirstName_Tb";
            FirstName_Tb.Size = new Size(246, 27);
            FirstName_Tb.TabIndex = 21;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(18, 189);
            label6.Name = "label6";
            label6.Size = new Size(37, 20);
            label6.TabIndex = 20;
            label6.Text = "Пол";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(18, 152);
            label5.Name = "label5";
            label5.Size = new Size(116, 20);
            label5.TabIndex = 19;
            label5.Text = "Дата рождения";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(18, 118);
            label4.Name = "label4";
            label4.Size = new Size(51, 20);
            label4.TabIndex = 18;
            label4.Text = "Адрес";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(18, 82);
            label3.Name = "label3";
            label3.Size = new Size(142, 20);
            label3.TabIndex = 17;
            label3.Text = "Контактный номер";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(18, 46);
            label2.Name = "label2";
            label2.Size = new Size(73, 20);
            label2.TabIndex = 16;
            label2.Text = "Фамилия";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(18, 10);
            label1.Name = "label1";
            label1.Size = new Size(39, 20);
            label1.TabIndex = 15;
            label1.Text = "Имя";
            // 
            // Update_Btn
            // 
            Update_Btn.Location = new Point(184, 245);
            Update_Btn.Name = "Update_Btn";
            Update_Btn.Size = new Size(94, 29);
            Update_Btn.TabIndex = 14;
            Update_Btn.Text = "Изменить";
            Update_Btn.UseVisualStyleBackColor = true;
            Update_Btn.Click += Update_Btn_ClickAsync;
            // 
            // UpdatePatientForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(479, 299);
            Controls.Add(Birthday_Dtp);
            Controls.Add(Sex_Cb);
            Controls.Add(Address_Tb);
            Controls.Add(Phone_tb);
            Controls.Add(LastName_Tb);
            Controls.Add(FirstName_Tb);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(Update_Btn);
            Name = "UpdatePatientForm";
            Text = "Изменить данные о пациенте";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DateTimePicker Birthday_Dtp;
        private ComboBox Sex_Cb;
        private TextBox Address_Tb;
        private TextBox Phone_tb;
        private TextBox LastName_Tb;
        private TextBox FirstName_Tb;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private Button Update_Btn;
    }
}