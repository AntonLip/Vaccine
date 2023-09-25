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
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { вакциныToolStripMenuItem, пациентыToolStripMenuItem, планВакцинацииToolStripMenuItem, Report_StripMenu });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(901, 24);
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
            Report_StripMenu.Name = "Report_StripMenu";
            Report_StripMenu.Size = new Size(60, 20);
            Report_StripMenu.Text = "Отчеты";
            Report_StripMenu.Click += Report_StripMenu_Click;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(901, 516);
            Controls.Add(menuStrip1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MainMenuStrip = menuStrip1;
            Name = "MainForm";
            Text = "Вакцинация";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
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
    }
}