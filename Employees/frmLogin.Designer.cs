namespace Hotel_Reservations_System
{
    partial class frmLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLogin));
            this.lblTitle = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.chxRememberMe = new Guna.UI2.WinForms.Guna2CustomCheckBox();
            this.guna2HtmlLabel1 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.btnLogin = new SiticoneNetFrameworkUI.SiticoneActivityButton();
            this.txtUsername = new SiticoneNetFrameworkUI.SiticoneTextBoxAdvanced();
            this.txtPassword = new SiticoneNetFrameworkUI.SiticoneTextBoxAdvanced();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.BackColor = System.Drawing.Color.Transparent;
            resources.ApplyResources(this.lblTitle, "lblTitle");
            this.lblTitle.ForeColor = System.Drawing.Color.Maroon;
            this.lblTitle.Name = "lblTitle";
            // 
            // chxRememberMe
            // 
            this.chxRememberMe.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.chxRememberMe.CheckedState.BorderRadius = 2;
            this.chxRememberMe.CheckedState.BorderThickness = 0;
            this.chxRememberMe.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            resources.ApplyResources(this.chxRememberMe, "chxRememberMe");
            this.chxRememberMe.Name = "chxRememberMe";
            this.chxRememberMe.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.chxRememberMe.UncheckedState.BorderRadius = 2;
            this.chxRememberMe.UncheckedState.BorderThickness = 0;
            this.chxRememberMe.UncheckedState.FillColor = System.Drawing.Color.Silver;
            // 
            // guna2HtmlLabel1
            // 
            this.guna2HtmlLabel1.BackColor = System.Drawing.Color.Transparent;
            resources.ApplyResources(this.guna2HtmlLabel1, "guna2HtmlLabel1");
            this.guna2HtmlLabel1.ForeColor = System.Drawing.Color.Maroon;
            this.guna2HtmlLabel1.Name = "guna2HtmlLabel1";
            // 
            // btnLogin
            // 
            this.btnLogin.ActivityDuration = 2000;
            this.btnLogin.ActivityIndicatorColor = System.Drawing.Color.Wheat;
            this.btnLogin.ActivityIndicatorSize = 4;
            this.btnLogin.ActivityIndicatorSpeed = 100;
            this.btnLogin.ActivityText = "Processing...";
            this.btnLogin.AnimationEasing = SiticoneNetFrameworkUI.SiticoneActivityButton.AnimationEasingType.EaseOutQuad;
            this.btnLogin.BackColor = System.Drawing.Color.Transparent;
            this.btnLogin.BaseColor = System.Drawing.Color.Maroon;
            this.btnLogin.BorderColor = System.Drawing.Color.Transparent;
            this.btnLogin.BorderWidth = 2;
            this.btnLogin.CornerRadiusBottomLeft = 10;
            this.btnLogin.CornerRadiusBottomRight = 10;
            this.btnLogin.CornerRadiusTopLeft = 10;
            this.btnLogin.CornerRadiusTopRight = 10;
            this.btnLogin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLogin.DisabledColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(160)))), ((int)(((byte)(160)))));
            this.btnLogin.Elevation = 2F;
            resources.ApplyResources(this.btnLogin, "btnLogin");
            this.btnLogin.HoverAnimationDuration = 200;
            this.btnLogin.HoverColor = System.Drawing.Color.DarkRed;
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.PressAnimationDuration = 150;
            this.btnLogin.PressedColor = System.Drawing.Color.RosyBrown;
            this.btnLogin.PressedElevation = 1F;
            this.btnLogin.RippleColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
            this.btnLogin.RippleDuration = 1800;
            this.btnLogin.RippleSize = 5;
            this.btnLogin.ShowActivityText = true;
            this.btnLogin.TextColor = System.Drawing.Color.Wheat;
            this.btnLogin.Theme = SiticoneNetFrameworkUI.SiticoneActivityButton.ActivityButtonTheme.Custom;
            this.btnLogin.UltraPerformanceMode = true;
            this.btnLogin.UseAnimation = true;
            this.btnLogin.UseElevation = false;
            this.btnLogin.UseRippleEffect = true;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // txtUsername
            // 
            this.txtUsername.BackColor = System.Drawing.Color.Transparent;
            this.txtUsername.BackgroundColor = System.Drawing.Color.AntiqueWhite;
            this.txtUsername.BorderColor = System.Drawing.Color.Maroon;
            this.txtUsername.BottomLeftCornerRadius = 8;
            this.txtUsername.BottomRightCornerRadius = 8;
            this.txtUsername.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtUsername.FocusBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(215)))));
            this.txtUsername.FocusImage = null;
            this.txtUsername.ForeColor = System.Drawing.Color.Black;
            this.txtUsername.HoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(129)))), ((int)(((byte)(140)))), ((int)(((byte)(248)))));
            this.txtUsername.HoverImage = null;
            this.txtUsername.IdleImage = null;
            resources.ApplyResources(this.txtUsername, "txtUsername");
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.PlaceholderColor = System.Drawing.Color.Gray;
            this.txtUsername.PlaceholderFont = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.txtUsername.PlaceholderText = "Enter username...";
            this.txtUsername.ReadOnlyColors.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(245)))), ((int)(((byte)(245)))));
            this.txtUsername.ReadOnlyColors.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.txtUsername.ReadOnlyColors.PlaceholderColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(150)))), ((int)(((byte)(150)))));
            this.txtUsername.ReadOnlyColors.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.txtUsername.TextColor = System.Drawing.Color.Black;
            this.txtUsername.TextContent = "";
            this.txtUsername.TopLeftCornerRadius = 8;
            this.txtUsername.TopRightCornerRadius = 8;
            this.txtUsername.ValidationPattern = "";
            // 
            // txtPassword
            // 
            this.txtPassword.BackColor = System.Drawing.Color.Transparent;
            this.txtPassword.BackgroundColor = System.Drawing.Color.AntiqueWhite;
            this.txtPassword.BorderColor = System.Drawing.Color.Maroon;
            this.txtPassword.BottomLeftCornerRadius = 8;
            this.txtPassword.BottomRightCornerRadius = 8;
            this.txtPassword.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPassword.ErrorColor = System.Drawing.SystemColors.ScrollBar;
            this.txtPassword.FocusBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(215)))));
            this.txtPassword.FocusImage = null;
            this.txtPassword.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtPassword.HoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(129)))), ((int)(((byte)(140)))), ((int)(((byte)(248)))));
            this.txtPassword.HoverImage = null;
            this.txtPassword.IdleImage = null;
            this.txtPassword.InputType = SiticoneNetFrameworkUI.AdvancedTextBoxInputType.Password;
            resources.ApplyResources(this.txtPassword, "txtPassword");
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PlaceholderColor = System.Drawing.Color.Gray;
            this.txtPassword.PlaceholderFont = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.txtPassword.PlaceholderText = "Enter password...";
            this.txtPassword.ReadOnlyColors.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(245)))), ((int)(((byte)(245)))));
            this.txtPassword.ReadOnlyColors.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.txtPassword.ReadOnlyColors.PlaceholderColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(150)))), ((int)(((byte)(150)))));
            this.txtPassword.ReadOnlyColors.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.txtPassword.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtPassword.TextContent = "";
            this.txtPassword.TopLeftCornerRadius = 8;
            this.txtPassword.TopRightCornerRadius = 8;
            this.txtPassword.ValidationEnabled = false;
            this.txtPassword.ValidationPattern = "";
            // 
            // frmLogin
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AntiqueWhite;
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.txtUsername);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.guna2HtmlLabel1);
            this.Controls.Add(this.chxRememberMe);
            this.Controls.Add(this.lblTitle);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmLogin";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmLogin_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Guna.UI2.WinForms.Guna2HtmlLabel lblTitle;
        private Guna.UI2.WinForms.Guna2CustomCheckBox chxRememberMe;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel1;
        private SiticoneNetFrameworkUI.SiticoneActivityButton btnLogin;
        private SiticoneNetFrameworkUI.SiticoneTextBoxAdvanced txtUsername;
        private SiticoneNetFrameworkUI.SiticoneTextBoxAdvanced txtPassword;
    }
}

