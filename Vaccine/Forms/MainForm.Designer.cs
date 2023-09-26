namespace Vaccine
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            menuStrip1 = new MenuStrip();
            вакциныToolStripMenuItem = new ToolStripMenuItem();
            добавитьToolStripMenuItem = new ToolStripMenuItem();
            VaccineList_StripMenu = new ToolStripMenuItem();
            пациентыToolStripMenuItem = new ToolStripMenuItem();
            AddPatiens_StripMenuItem = new ToolStripMenuItem();
            ShowPatiensList_StripMenuItem = new ToolStripMenuItem();
            планВакцинацииToolStripMenuItem = new ToolStripMenuItem();
            AddVaccinationPlan_StipMenu = new ToolStripMenuItem();
            ShowVaccinationPlan_StripMenu = new ToolStripMenuItem();
            Report_StripMenu = new ToolStripMenuItem();
            выполнениеВакцинацииToolStripMenuItem = new ToolStripMenuItem();
            File_StripMenu = new ToolStripMenuItem();
            pictureBox1 = new PictureBox();
            menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { вакциныToolStripMenuItem, пациентыToolStripMenuItem, планВакцинацииToolStripMenuItem, Report_StripMenu });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(632, 24);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // вакциныToolStripMenuItem
            // 
            вакциныToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { добавитьToolStripMenuItem, VaccineList_StripMenu });
            вакциныToolStripMenuItem.Name = "вакциныToolStripMenuItem";
            вакциныToolStripMenuItem.Size = new Size(68, 20);
            вакциныToolStripMenuItem.Text = "Вакцины";
            вакциныToolStripMenuItem.Click += вакциныToolStripMenuItem_Click;
            // 
            // добавитьToolStripMenuItem
            // 
            добавитьToolStripMenuItem.Name = "добавитьToolStripMenuItem";
            добавитьToolStripMenuItem.Size = new Size(126, 22);
            добавитьToolStripMenuItem.Text = "Добавить";
            добавитьToolStripMenuItem.Click += добавитьToolStripMenuItem_Click;
            // 
            // VaccineList_StripMenu
            // 
            VaccineList_StripMenu.Name = "VaccineList_StripMenu";
            VaccineList_StripMenu.Size = new Size(126, 22);
            VaccineList_StripMenu.Text = "Список";
            VaccineList_StripMenu.Click += VaccineList_StripMenu_Click;
            // 
            // пациентыToolStripMenuItem
            // 
            пациентыToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { AddPatiens_StripMenuItem, ShowPatiensList_StripMenuItem });
            пациентыToolStripMenuItem.Name = "пациентыToolStripMenuItem";
            пациентыToolStripMenuItem.Size = new Size(75, 20);
            пациентыToolStripMenuItem.Text = "Пациенты";
            пациентыToolStripMenuItem.Click += пациентыToolStripMenuItem_Click;
            // 
            // AddPatiens_StripMenuItem
            // 
            AddPatiens_StripMenuItem.Name = "AddPatiens_StripMenuItem";
            AddPatiens_StripMenuItem.Size = new Size(166, 22);
            AddPatiens_StripMenuItem.Text = "Добавить";
            AddPatiens_StripMenuItem.Click += AddPatiens_StripMenuItem_Click;
            // 
            // ShowPatiensList_StripMenuItem
            // 
            ShowPatiensList_StripMenuItem.Name = "ShowPatiensList_StripMenuItem";
            ShowPatiensList_StripMenuItem.Size = new Size(166, 22);
            ShowPatiensList_StripMenuItem.Text = "Показать список";
            ShowPatiensList_StripMenuItem.Click += ShowPatiensList_StripMenuItem_Click;
            // 
            // планВакцинацииToolStripMenuItem
            // 
            планВакцинацииToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { AddVaccinationPlan_StipMenu, ShowVaccinationPlan_StripMenu });
            планВакцинацииToolStripMenuItem.Name = "планВакцинацииToolStripMenuItem";
            планВакцинацииToolStripMenuItem.Size = new Size(117, 20);
            планВакцинацииToolStripMenuItem.Text = "План вакцинации";
            // 
            // AddVaccinationPlan_StipMenu
            // 
            AddVaccinationPlan_StipMenu.Name = "AddVaccinationPlan_StipMenu";
            AddVaccinationPlan_StipMenu.Size = new Size(192, 22);
            AddVaccinationPlan_StipMenu.Text = "Добавить запись";
            AddVaccinationPlan_StipMenu.Click += AddVaccinationPlan_StipMenu_Click;
            // 
            // ShowVaccinationPlan_StripMenu
            // 
            ShowVaccinationPlan_StripMenu.Name = "ShowVaccinationPlan_StripMenu";
            ShowVaccinationPlan_StripMenu.Size = new Size(192, 22);
            ShowVaccinationPlan_StripMenu.Text = "Показать расписание";
            ShowVaccinationPlan_StripMenu.Click += ShowVaccinationPlan_StripMenu_Click;
            // 
            // Report_StripMenu
            // 
            Report_StripMenu.DropDownItems.AddRange(new ToolStripItem[] { выполнениеВакцинацииToolStripMenuItem, File_StripMenu });
            Report_StripMenu.Name = "Report_StripMenu";
            Report_StripMenu.Size = new Size(60, 20);
            Report_StripMenu.Text = "Отчеты";
            Report_StripMenu.Click += Report_StripMenu_Click;
            // 
            // выполнениеВакцинацииToolStripMenuItem
            // 
            выполнениеВакцинацииToolStripMenuItem.Name = "выполнениеВакцинацииToolStripMenuItem";
            выполнениеВакцинацииToolStripMenuItem.Size = new Size(213, 22);
            выполнениеВакцинацииToolStripMenuItem.Text = "Выполнение вакцинации";
            выполнениеВакцинацииToolStripMenuItem.Click += выполнениеВакцинацииToolStripMenuItem_Click;
            // 
            // File_StripMenu
            // 
            File_StripMenu.Name = "File_StripMenu";
            File_StripMenu.Size = new Size(213, 22);
            File_StripMenu.Text = "Файл";
            File_StripMenu.Click += File_StripMenu_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(21, 27);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(607, 460);
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(632, 492);
            Controls.Add(pictureBox1);
            Controls.Add(menuStrip1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MainMenuStrip = menuStrip1;
            Name = "MainForm";
            Text = "Вакцинация";
            FormClosed += MainForm_FormClosed;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem вакциныToolStripMenuItem;
        private ToolStripMenuItem пациентыToolStripMenuItem;
        private ToolStripMenuItem планВакцинацииToolStripMenuItem;
        private ToolStripMenuItem Report_StripMenu;
        private ToolStripMenuItem AddPatiens_StripMenuItem;
        private ToolStripMenuItem ShowPatiensList_StripMenuItem;
        private ToolStripMenuItem добавитьToolStripMenuItem;
        private ToolStripMenuItem VaccineList_StripMenu;
        private ToolStripMenuItem AddVaccinationPlan_StipMenu;
        private ToolStripMenuItem ShowVaccinationPlan_StripMenu;
        private ToolStripMenuItem выполнениеВакцинацииToolStripMenuItem;
        private PictureBox pictureBox1;
        private ToolStripMenuItem File_StripMenu;
    }
}