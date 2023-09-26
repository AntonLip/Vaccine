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
            Create_Btn.Location = new Point(10, 181);
            Create_Btn.Margin = new Padding(3, 2, 3, 2);
            Create_Btn.Name = "Create_Btn";
            Create_Btn.Size = new Size(360, 22);
            Create_Btn.TabIndex = 0;
            Create_Btn.Text = "Добавить";
            Create_Btn.UseVisualStyleBackColor = true;
            Create_Btn.Click += Create_Btn_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(10, 7);
            label1.Name = "label1";
            label1.Size = new Size(31, 15);
            label1.TabIndex = 1;
            label1.Text = "Имя";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(10, 34);
            label2.Name = "label2";
            label2.Size = new Size(58, 15);
            label2.TabIndex = 2;
            label2.Text = "Фамилия";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(10, 61);
            label3.Name = "label3";
            label3.Size = new Size(112, 15);
            label3.TabIndex = 3;
            label3.Text = "Контактный номер";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(10, 88);
            label4.Name = "label4";
            label4.Size = new Size(40, 15);
            label4.TabIndex = 4;
            label4.Text = "Адрес";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(10, 113);
            label5.Name = "label5";
            label5.Size = new Size(90, 15);
            label5.TabIndex = 5;
            label5.Text = "Дата рождения";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(10, 141);
            label6.Name = "label6";
            label6.Size = new Size(30, 15);
            label6.TabIndex = 6;
            label6.Text = "Пол";
            // 
            // FirstName_Tb
            // 
            FirstName_Tb.Location = new Point(156, 4);
            FirstName_Tb.Margin = new Padding(3, 2, 3, 2);
            FirstName_Tb.Name = "FirstName_Tb";
            FirstName_Tb.Size = new Size(216, 23);
            FirstName_Tb.TabIndex = 7;
            // 
            // LastName_Tb
            // 
            LastName_Tb.Location = new Point(156, 32);
            LastName_Tb.Margin = new Padding(3, 2, 3, 2);
            LastName_Tb.Name = "LastName_Tb";
            LastName_Tb.Size = new Size(216, 23);
            LastName_Tb.TabIndex = 8;
            // 
            // Phone_tb
            // 
            Phone_tb.Location = new Point(156, 58);
            Phone_tb.Margin = new Padding(3, 2, 3, 2);
            Phone_tb.Name = "Phone_tb";
            Phone_tb.Size = new Size(216, 23);
            Phone_tb.TabIndex = 9;
            // 
            // Address_Tb
            // 
            Address_Tb.Location = new Point(156, 86);
            Address_Tb.Margin = new Padding(3, 2, 3, 2);
            Address_Tb.Name = "Address_Tb";
            Address_Tb.Size = new Size(216, 23);
            Address_Tb.TabIndex = 10;
            // 
            // Sex_Cb
            // 
            Sex_Cb.FormattingEnabled = true;
            Sex_Cb.Items.AddRange(new object[] { "Мужской", "Женский" });
            Sex_Cb.Location = new Point(156, 138);
            Sex_Cb.Margin = new Padding(3, 2, 3, 2);
            Sex_Cb.Name = "Sex_Cb";
            Sex_Cb.Size = new Size(216, 23);
            Sex_Cb.TabIndex = 12;
            // 
            // Birthday_Dtp
            // 
            Birthday_Dtp.Location = new Point(156, 111);
            Birthday_Dtp.Margin = new Padding(3, 2, 3, 2);
            Birthday_Dtp.Name = "Birthday_Dtp";
            Birthday_Dtp.Size = new Size(216, 23);
            Birthday_Dtp.TabIndex = 13;
            // 
            // AddPatient
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(382, 214);
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
            Margin = new Padding(3, 2, 3, 2);
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