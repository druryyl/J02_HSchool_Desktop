namespace HSchool.Winform
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.ribbon1 = new System.Windows.Forms.Ribbon();
            this.ribbonTab1 = new System.Windows.Forms.RibbonTab();
            this.ribbonPanel1 = new System.Windows.Forms.RibbonPanel();
            this.ProfileMenu = new System.Windows.Forms.RibbonButton();
            this.RegistrationMenu = new System.Windows.Forms.RibbonButton();
            this.ribbonPanel2 = new System.Windows.Forms.RibbonPanel();
            this.AttendanceMenu = new System.Windows.Forms.RibbonButton();
            this.AssesmentMenu = new System.Windows.Forms.RibbonButton();
            this.ribbonPanel3 = new System.Windows.Forms.RibbonPanel();
            this.BillingMenu = new System.Windows.Forms.RibbonButton();
            this.PaymentMenu = new System.Windows.Forms.RibbonButton();
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
            this.ribbon1.Size = new System.Drawing.Size(892, 114);
            this.ribbon1.TabIndex = 1;
            this.ribbon1.Tabs.Add(this.ribbonTab1);
            this.ribbon1.TabsMargin = new System.Windows.Forms.Padding(6, 2, 20, 0);
            this.ribbon1.TabSpacing = 3;
            this.ribbon1.Text = "ribbon1";
            this.ribbon1.ThemeColor = System.Windows.Forms.RibbonTheme.Black;
            // 
            // ribbonTab1
            // 
            this.ribbonTab1.Name = "ribbonTab1";
            this.ribbonTab1.Panels.Add(this.ribbonPanel1);
            this.ribbonTab1.Panels.Add(this.ribbonPanel2);
            this.ribbonTab1.Panels.Add(this.ribbonPanel3);
            this.ribbonTab1.Text = "Activity";
            // 
            // ribbonPanel1
            // 
            this.ribbonPanel1.ButtonMoreEnabled = false;
            this.ribbonPanel1.ButtonMoreVisible = false;
            this.ribbonPanel1.Items.Add(this.ProfileMenu);
            this.ribbonPanel1.Items.Add(this.RegistrationMenu);
            this.ribbonPanel1.Name = "ribbonPanel1";
            this.ribbonPanel1.Text = "";
            // 
            // ProfileMenu
            // 
            this.ProfileMenu.Image = global::HSchool.Winform.Properties.Resources.profile_48px;
            this.ProfileMenu.LargeImage = global::HSchool.Winform.Properties.Resources.profile_48px;
            this.ProfileMenu.Name = "ProfileMenu";
            this.ProfileMenu.SmallImage = ((System.Drawing.Image)(resources.GetObject("ProfileMenu.SmallImage")));
            this.ProfileMenu.Text = "Profile";
            this.ProfileMenu.Click += new System.EventHandler(this.Menu_Click);
            // 
            // RegistrationMenu
            // 
            this.RegistrationMenu.Image = global::HSchool.Winform.Properties.Resources.add_user_male_48px;
            this.RegistrationMenu.LargeImage = global::HSchool.Winform.Properties.Resources.add_user_male_48px;
            this.RegistrationMenu.Name = "RegistrationMenu";
            this.RegistrationMenu.SmallImage = ((System.Drawing.Image)(resources.GetObject("RegistrationMenu.SmallImage")));
            this.RegistrationMenu.Text = "Registration";
            this.RegistrationMenu.Click += new System.EventHandler(this.Menu_Click);
            // 
            // ribbonPanel2
            // 
            this.ribbonPanel2.ButtonMoreEnabled = false;
            this.ribbonPanel2.ButtonMoreVisible = false;
            this.ribbonPanel2.Items.Add(this.AttendanceMenu);
            this.ribbonPanel2.Items.Add(this.AssesmentMenu);
            this.ribbonPanel2.Name = "ribbonPanel2";
            this.ribbonPanel2.Text = "";
            // 
            // AttendanceMenu
            // 
            this.AttendanceMenu.Image = global::HSchool.Winform.Properties.Resources.queue_48px;
            this.AttendanceMenu.LargeImage = global::HSchool.Winform.Properties.Resources.queue_48px;
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
            // ribbonPanel3
            // 
            this.ribbonPanel3.ButtonMoreEnabled = false;
            this.ribbonPanel3.ButtonMoreVisible = false;
            this.ribbonPanel3.Items.Add(this.BillingMenu);
            this.ribbonPanel3.Items.Add(this.PaymentMenu);
            this.ribbonPanel3.Name = "ribbonPanel3";
            this.ribbonPanel3.Text = "";
            // 
            // BillingMenu
            // 
            this.BillingMenu.Image = global::HSchool.Winform.Properties.Resources.estimate_48px;
            this.BillingMenu.LargeImage = global::HSchool.Winform.Properties.Resources.estimate_48px;
            this.BillingMenu.Name = "BillingMenu";
            this.BillingMenu.SmallImage = ((System.Drawing.Image)(resources.GetObject("BillingMenu.SmallImage")));
            this.BillingMenu.Text = "Billing";
            // 
            // PaymentMenu
            // 
            this.PaymentMenu.Image = global::HSchool.Winform.Properties.Resources.cash_in_hand_48px;
            this.PaymentMenu.LargeImage = global::HSchool.Winform.Properties.Resources.cash_in_hand_48px;
            this.PaymentMenu.Name = "PaymentMenu";
            this.PaymentMenu.SmallImage = ((System.Drawing.Image)(resources.GetObject("PaymentMenu.SmallImage")));
            this.PaymentMenu.Text = "Payment";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(892, 625);
            this.Controls.Add(this.ribbon1);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IsMdiContainer = true;
            this.KeyPreview = true;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "HSchool 1.0";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Resize += new System.EventHandler(this.Form1_Resize);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Ribbon ribbon1;
        private System.Windows.Forms.RibbonTab ribbonTab1;
        private System.Windows.Forms.RibbonPanel ribbonPanel1;
        private System.Windows.Forms.RibbonButton RegistrationMenu;
        private System.Windows.Forms.RibbonButton ProfileMenu;
        private System.Windows.Forms.RibbonPanel ribbonPanel2;
        private System.Windows.Forms.RibbonButton AttendanceMenu;
        private System.Windows.Forms.RibbonButton AssesmentMenu;
        private System.Windows.Forms.RibbonPanel ribbonPanel3;
        private System.Windows.Forms.RibbonButton BillingMenu;
        private System.Windows.Forms.RibbonButton PaymentMenu;
    }
}

