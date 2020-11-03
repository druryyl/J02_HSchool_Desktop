namespace HSchool.Winform
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.ribbon1 = new System.Windows.Forms.Ribbon();
            this.ribbonTab1 = new System.Windows.Forms.RibbonTab();
            this.ribbonPanel1 = new System.Windows.Forms.RibbonPanel();
            this.RegistrationMenu = new System.Windows.Forms.RibbonButton();
            this.AttendanceMenu = new System.Windows.Forms.RibbonButton();
            this.AssesmentMenu = new System.Windows.Forms.RibbonButton();
            this.PayumentMenu = new System.Windows.Forms.RibbonButton();
            this.SuspendLayout();
            // 
            // ribbon1
            // 
            this.ribbon1.CaptionBarVisible = false;
            this.ribbon1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.ribbon1.Location = new System.Drawing.Point(0, 0);
            this.ribbon1.Minimized = false;
            this.ribbon1.Name = "ribbon1";
            // 
            // 
            // 
            this.ribbon1.OrbDropDown.BorderRoundness = 8;
            this.ribbon1.OrbDropDown.Location = new System.Drawing.Point(0, 0);
            this.ribbon1.OrbDropDown.Name = "";
            this.ribbon1.OrbDropDown.Size = new System.Drawing.Size(527, 447);
            this.ribbon1.OrbDropDown.TabIndex = 0;
            this.ribbon1.OrbStyle = System.Windows.Forms.RibbonOrbStyle.Office_2010;
            this.ribbon1.OrbVisible = false;
            this.ribbon1.RibbonTabFont = new System.Drawing.Font("Trebuchet MS", 9F);
            this.ribbon1.Size = new System.Drawing.Size(892, 116);
            this.ribbon1.TabIndex = 1;
            this.ribbon1.Tabs.Add(this.ribbonTab1);
            this.ribbon1.TabsMargin = new System.Windows.Forms.Padding(6, 2, 20, 0);
            this.ribbon1.TabSpacing = 3;
            this.ribbon1.Text = "ribbon1";
            // 
            // ribbonTab1
            // 
            this.ribbonTab1.Name = "ribbonTab1";
            this.ribbonTab1.Panels.Add(this.ribbonPanel1);
            this.ribbonTab1.Text = "Activity";
            // 
            // ribbonPanel1
            // 
            this.ribbonPanel1.ButtonMoreEnabled = false;
            this.ribbonPanel1.ButtonMoreVisible = false;
            this.ribbonPanel1.Items.Add(this.RegistrationMenu);
            this.ribbonPanel1.Items.Add(this.AttendanceMenu);
            this.ribbonPanel1.Items.Add(this.AssesmentMenu);
            this.ribbonPanel1.Items.Add(this.PayumentMenu);
            this.ribbonPanel1.Name = "ribbonPanel1";
            this.ribbonPanel1.Text = "";
            // 
            // RegistrationMenu
            // 
            this.RegistrationMenu.Image = global::HSchool.Winform.Properties.Resources.add_user_male_48px;
            this.RegistrationMenu.LargeImage = global::HSchool.Winform.Properties.Resources.add_user_male_48px;
            this.RegistrationMenu.Name = "RegistrationMenu";
            this.RegistrationMenu.SmallImage = ((System.Drawing.Image)(resources.GetObject("RegistrationMenu.SmallImage")));
            this.RegistrationMenu.Text = "Registration";
            // 
            // AttendanceMenu
            // 
            this.AttendanceMenu.Image = global::HSchool.Winform.Properties.Resources.myspace_48px;
            this.AttendanceMenu.LargeImage = global::HSchool.Winform.Properties.Resources.myspace_48px;
            this.AttendanceMenu.Name = "AttendanceMenu";
            this.AttendanceMenu.SmallImage = ((System.Drawing.Image)(resources.GetObject("AttendanceMenu.SmallImage")));
            this.AttendanceMenu.Text = "Attendance";
            // 
            // AssesmentMenu
            // 
            this.AssesmentMenu.Image = global::HSchool.Winform.Properties.Resources.increase_48px;
            this.AssesmentMenu.LargeImage = global::HSchool.Winform.Properties.Resources.increase_48px;
            this.AssesmentMenu.Name = "AssesmentMenu";
            this.AssesmentMenu.SmallImage = ((System.Drawing.Image)(resources.GetObject("AssesmentMenu.SmallImage")));
            this.AssesmentMenu.Text = "Assesment";
            // 
            // PayumentMenu
            // 
            this.PayumentMenu.Image = global::HSchool.Winform.Properties.Resources.cash_in_hand_48px;
            this.PayumentMenu.LargeImage = global::HSchool.Winform.Properties.Resources.cash_in_hand_48px;
            this.PayumentMenu.Name = "PayumentMenu";
            this.PayumentMenu.SmallImage = ((System.Drawing.Image)(resources.GetObject("PayumentMenu.SmallImage")));
            this.PayumentMenu.Text = "Payment";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(892, 515);
            this.Controls.Add(this.ribbon1);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IsMdiContainer = true;
            this.KeyPreview = true;
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Ribbon ribbon1;
        private System.Windows.Forms.RibbonTab ribbonTab1;
        private System.Windows.Forms.RibbonPanel ribbonPanel1;
        private System.Windows.Forms.RibbonButton RegistrationMenu;
        private System.Windows.Forms.RibbonButton AttendanceMenu;
        private System.Windows.Forms.RibbonButton AssesmentMenu;
        private System.Windows.Forms.RibbonButton PayumentMenu;
    }
}

