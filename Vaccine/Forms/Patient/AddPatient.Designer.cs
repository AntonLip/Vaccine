namespace Vaccine.Forms
{
    partial class AddPatient
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
            Create_Btn = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            FirstName_Tb = new TextBox();
            LastName_Tb = new TextBox();
            Phone_tb = new TextBox();
            Address_Tb = new TextBox();
            Sex_Cb = new ComboBox();
            Birthday_Dtp = new DateTimePicker();
            SuspendLayout();
            // 
            // Create_Btn
            // 
            Create_Btn.Location = new Point(115, 239);
            Create_Btn.Name = "Create_Btn";
            Create_Btn.Size = new Size(94, 29);
            Create_Btn.TabIndex = 0;
            Create_Btn.Text = "Добавить";
            Create_Btn.UseVisualStyleBackColor = true;
            Create_Btn.Click += Create_Btn_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(39, 20);
            label1.TabIndex = 1;
            label1.Text = "Имя";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 45);
            label2.Name = "label2";
            label2.Size = new Size(73, 20);
            label2.TabIndex = 2;
            label2.Text = "Фамилия";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 81);
            label3.Name = "label3";
            label3.Size = new Size(142, 20);
            label3.TabIndex = 3;
            label3.Text = "Контактный номер";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 117);
            label4.Name = "label4";
            label4.Size = new Size(51, 20);
            label4.TabIndex = 4;
            label4.Text = "Адрес";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(12, 151);
            label5.Name = "label5";
            label5.Size = new Size(116, 20);
            label5.TabIndex = 5;
            label5.Text = "Дата рождения";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(12, 188);
            label6.Name = "label6";
            label6.Size = new Size(37, 20);
            label6.TabIndex = 6;
            label6.Text = "Пол";
            // 
            // FirstName_Tb
            // 
            FirstName_Tb.Location = new Point(178, 6);
            FirstName_Tb.Name = "FirstName_Tb";
            FirstName_Tb.Size = new Size(246, 27);
            FirstName_Tb.TabIndex = 7;
            // 
            // LastName_Tb
            // 
            LastName_Tb.Location = new Point(178, 42);
            LastName_Tb.Name = "LastName_Tb";
            LastName_Tb.Size = new Size(246, 27);
            LastName_Tb.TabIndex = 8;
            // 
            // Phone_tb
            // 
            Phone_tb.Location = new Point(178, 78);
            Phone_tb.Name = "Phone_tb";
            Phone_tb.Size = new Size(246, 27);
            Phone_tb.TabIndex = 9;
            // 
            // Address_Tb
            // 
            Address_Tb.Location = new Point(178, 114);
            Address_Tb.Name = "Address_Tb";
            Address_Tb.Size = new Size(246, 27);
            Address_Tb.TabIndex = 10;
            // 
            // Sex_Cb
            // 
            Sex_Cb.FormattingEnabled = true;
            Sex_Cb.Items.AddRange(new object[] { "Мужской", "Женский" });
            Sex_Cb.Location = new Point(178, 184);
            Sex_Cb.Name = "Sex_Cb";
            Sex_Cb.Size = new Size(246, 28);
            Sex_Cb.TabIndex = 12;
            // 
            // Birthday_Dtp
            // 
            Birthday_Dtp.Location = new Point(178, 148);
            Birthday_Dtp.Name = "Birthday_Dtp";
            Birthday_Dtp.Size = new Size(246, 27);
            Birthday_Dtp.TabIndex = 13;
            // 
            // AddPatient
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(436, 285);
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
            Controls.Add(Create_Btn);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Name = "AddPatient";
            Text = "Добавить пациента";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button Create_Btn;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private TextBox FirstName_Tb;
        private TextBox LastName_Tb;
        private TextBox Phone_tb;
        private TextBox Address_Tb;
        private ComboBox Sex_Cb;
        private DateTimePicker Birthday_Dtp;
    }
}