namespace Vaccine.Forms
{
    partial class AuthForm
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
            Login_Tb = new TextBox();
            Password_Tb = new TextBox();
            SignIn_Btn = new Button();
            SuspendLayout();
            // 
            // Login_Tb
            // 
            Login_Tb.Location = new Point(12, 12);
            Login_Tb.Name = "Login_Tb";
            Login_Tb.Size = new Size(286, 23);
            Login_Tb.TabIndex = 0;
            Login_Tb.Text = "Логин";
            // 
            // Password_Tb
            // 
            Password_Tb.Location = new Point(12, 51);
            Password_Tb.Name = "Password_Tb";
            Password_Tb.Size = new Size(286, 23);
            Password_Tb.TabIndex = 1;
            Password_Tb.Text = "Пароль";
            // 
            // SignIn_Btn
            // 
            SignIn_Btn.Location = new Point(12, 80);
            SignIn_Btn.Name = "SignIn_Btn";
            SignIn_Btn.Size = new Size(286, 23);
            SignIn_Btn.TabIndex = 2;
            SignIn_Btn.Text = "Войти";
            SignIn_Btn.UseVisualStyleBackColor = true;
            SignIn_Btn.Click += SignIn_Btn_Click;
            // 
            // AuthForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(310, 127);
            Controls.Add(SignIn_Btn);
            Controls.Add(Password_Tb);
            Controls.Add(Login_Tb);
            Name = "AuthForm";
            Text = "Войти";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox Login_Tb;
        private TextBox Password_Tb;
        private Button SignIn_Btn;
    }
}