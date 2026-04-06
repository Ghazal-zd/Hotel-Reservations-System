namespace Hotel_Reservations_System
{
    partial class frmChangePassword
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
            this.components = new System.ComponentModel.Container();
            this.txtNewPassword = new SiticoneNetFrameworkUI.SiticoneTextBox();
            this.txtCurrentPassword = new SiticoneNetFrameworkUI.SiticoneTextBox();
            this.lblTitle = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.btnSavePassword = new SiticoneNetFrameworkUI.SiticoneButtonAdvanced();
            this.btnClose = new SiticoneNetFrameworkUI.SiticoneButtonAdvanced();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.txtConfirmPassword = new SiticoneNetFrameworkUI.SiticoneTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtNewPassword
            // 
            this.txtNewPassword.AccessibleDescription = "A customizable text input field.";
            this.txtNewPassword.AccessibleName = "Text Box";
            this.txtNewPassword.AccessibleRole = System.Windows.Forms.AccessibleRole.Text;
            this.txtNewPassword.BackColor = System.Drawing.Color.Transparent;
            this.txtNewPassword.BlinkCount = 3;
            this.txtNewPassword.BlinkShadow = false;
            this.txtNewPassword.BorderColor1 = System.Drawing.Color.LightSlateGray;
            this.txtNewPassword.BorderColor2 = System.Drawing.Color.LightSlateGray;
            this.txtNewPassword.BorderFocusColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(77)))), ((int)(((byte)(255)))));
            this.txtNewPassword.BorderFocusColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(77)))), ((int)(((byte)(255)))));
            this.txtNewPassword.CanShake = true;
            this.txtNewPassword.ContinuousBlink = false;
            this.txtNewPassword.CornerRadiusBottomLeft = 10;
            this.txtNewPassword.CornerRadiusBottomRight = 10;
            this.txtNewPassword.CornerRadiusTopLeft = 10;
            this.txtNewPassword.CornerRadiusTopRight = 10;
            this.txtNewPassword.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtNewPassword.CursorBlinkRate = 500;
            this.txtNewPassword.CursorColor = System.Drawing.Color.Black;
            this.txtNewPassword.CursorHeight = 26;
            this.txtNewPassword.CursorOffset = 0;
            this.txtNewPassword.CursorStyle = SiticoneNetFrameworkUI.Helpers.DrawingStyle.SiticoneDrawingStyle.Solid;
            this.txtNewPassword.CursorWidth = 1;
            this.txtNewPassword.DisabledBackColor = System.Drawing.Color.WhiteSmoke;
            this.txtNewPassword.DisabledBorderColor = System.Drawing.Color.LightGray;
            this.txtNewPassword.DisabledTextColor = System.Drawing.Color.Gray;
            this.txtNewPassword.EnableDropShadow = false;
            this.txtNewPassword.FillColor1 = System.Drawing.Color.White;
            this.txtNewPassword.FillColor2 = System.Drawing.Color.White;
            this.txtNewPassword.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.txtNewPassword.ForeColor = System.Drawing.Color.DimGray;
            this.txtNewPassword.HoverBorderColor1 = System.Drawing.Color.Gray;
            this.txtNewPassword.HoverBorderColor2 = System.Drawing.Color.Gray;
            this.txtNewPassword.IsEnabled = true;
            this.txtNewPassword.Location = new System.Drawing.Point(46, 184);
            this.txtNewPassword.MaxLength = 50;
            this.txtNewPassword.Name = "txtNewPassword";
            this.txtNewPassword.PlaceholderColor = System.Drawing.Color.Gray;
            this.txtNewPassword.PlaceholderText = "New password*";
            this.txtNewPassword.ReadOnlyBorderColor1 = System.Drawing.Color.LightGray;
            this.txtNewPassword.ReadOnlyBorderColor2 = System.Drawing.Color.LightGray;
            this.txtNewPassword.ReadOnlyFillColor1 = System.Drawing.Color.WhiteSmoke;
            this.txtNewPassword.ReadOnlyFillColor2 = System.Drawing.Color.WhiteSmoke;
            this.txtNewPassword.ReadOnlyPlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtNewPassword.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(77)))), ((int)(((byte)(255)))));
            this.txtNewPassword.ShadowAnimationDuration = 1;
            this.txtNewPassword.ShadowBlur = 10;
            this.txtNewPassword.ShadowColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.txtNewPassword.Size = new System.Drawing.Size(438, 46);
            this.txtNewPassword.SolidBorderColor = System.Drawing.Color.LightSlateGray;
            this.txtNewPassword.SolidBorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(77)))), ((int)(((byte)(255)))));
            this.txtNewPassword.SolidBorderHoverColor = System.Drawing.Color.Gray;
            this.txtNewPassword.SolidFillColor = System.Drawing.Color.White;
            this.txtNewPassword.TabIndex = 22;
            this.txtNewPassword.TextPadding = new System.Windows.Forms.Padding(13, 1, 13, 1);
            this.txtNewPassword.UseSystemPasswordChar = true;
            this.txtNewPassword.ValidationErrorMessage = "Invalid input.";
            this.txtNewPassword.ValidationFunction = null;
            this.txtNewPassword.Validating += new System.ComponentModel.CancelEventHandler(this.txtNewPassword_Validating);
            // 
            // txtCurrentPassword
            // 
            this.txtCurrentPassword.AccessibleDescription = "A customizable text input field.";
            this.txtCurrentPassword.AccessibleName = "Text Box";
            this.txtCurrentPassword.AccessibleRole = System.Windows.Forms.AccessibleRole.Text;
            this.txtCurrentPassword.BackColor = System.Drawing.Color.Transparent;
            this.txtCurrentPassword.BlinkCount = 3;
            this.txtCurrentPassword.BlinkShadow = false;
            this.txtCurrentPassword.BorderColor1 = System.Drawing.Color.LightSlateGray;
            this.txtCurrentPassword.BorderColor2 = System.Drawing.Color.LightSlateGray;
            this.txtCurrentPassword.BorderFocusColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(77)))), ((int)(((byte)(255)))));
            this.txtCurrentPassword.BorderFocusColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(77)))), ((int)(((byte)(255)))));
            this.txtCurrentPassword.CanShake = true;
            this.txtCurrentPassword.ContinuousBlink = false;
            this.txtCurrentPassword.CornerRadiusBottomLeft = 10;
            this.txtCurrentPassword.CornerRadiusBottomRight = 10;
            this.txtCurrentPassword.CornerRadiusTopLeft = 10;
            this.txtCurrentPassword.CornerRadiusTopRight = 10;
            this.txtCurrentPassword.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtCurrentPassword.CursorBlinkRate = 500;
            this.txtCurrentPassword.CursorColor = System.Drawing.Color.Black;
            this.txtCurrentPassword.CursorHeight = 26;
            this.txtCurrentPassword.CursorOffset = 0;
            this.txtCurrentPassword.CursorStyle = SiticoneNetFrameworkUI.Helpers.DrawingStyle.SiticoneDrawingStyle.Solid;
            this.txtCurrentPassword.CursorWidth = 1;
            this.txtCurrentPassword.DisabledBackColor = System.Drawing.Color.WhiteSmoke;
            this.txtCurrentPassword.DisabledBorderColor = System.Drawing.Color.LightGray;
            this.txtCurrentPassword.DisabledTextColor = System.Drawing.Color.Gray;
            this.txtCurrentPassword.EnableDropShadow = false;
            this.txtCurrentPassword.FillColor1 = System.Drawing.Color.White;
            this.txtCurrentPassword.FillColor2 = System.Drawing.Color.White;
            this.txtCurrentPassword.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.txtCurrentPassword.ForeColor = System.Drawing.Color.DimGray;
            this.txtCurrentPassword.HoverBorderColor1 = System.Drawing.Color.Gray;
            this.txtCurrentPassword.HoverBorderColor2 = System.Drawing.Color.Gray;
            this.txtCurrentPassword.IsEnabled = true;
            this.txtCurrentPassword.Location = new System.Drawing.Point(46, 110);
            this.txtCurrentPassword.MaxLength = 50;
            this.txtCurrentPassword.Name = "txtCurrentPassword";
            this.txtCurrentPassword.PlaceholderColor = System.Drawing.Color.Gray;
            this.txtCurrentPassword.PlaceholderText = "Current password*";
            this.txtCurrentPassword.ReadOnlyBorderColor1 = System.Drawing.Color.LightGray;
            this.txtCurrentPassword.ReadOnlyBorderColor2 = System.Drawing.Color.LightGray;
            this.txtCurrentPassword.ReadOnlyFillColor1 = System.Drawing.Color.WhiteSmoke;
            this.txtCurrentPassword.ReadOnlyFillColor2 = System.Drawing.Color.WhiteSmoke;
            this.txtCurrentPassword.ReadOnlyPlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtCurrentPassword.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(77)))), ((int)(((byte)(255)))));
            this.txtCurrentPassword.ShadowAnimationDuration = 1;
            this.txtCurrentPassword.ShadowBlur = 10;
            this.txtCurrentPassword.ShadowColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.txtCurrentPassword.Size = new System.Drawing.Size(438, 46);
            this.txtCurrentPassword.SolidBorderColor = System.Drawing.Color.LightSlateGray;
            this.txtCurrentPassword.SolidBorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(77)))), ((int)(((byte)(255)))));
            this.txtCurrentPassword.SolidBorderHoverColor = System.Drawing.Color.Gray;
            this.txtCurrentPassword.SolidFillColor = System.Drawing.Color.White;
            this.txtCurrentPassword.TabIndex = 21;
            this.txtCurrentPassword.TextPadding = new System.Windows.Forms.Padding(16, 0, 6, 0);
            this.txtCurrentPassword.UseSystemPasswordChar = true;
            this.txtCurrentPassword.ValidationErrorMessage = "Invalid input.";
            this.txtCurrentPassword.ValidationFunction = null;
            this.txtCurrentPassword.Validating += new System.ComponentModel.CancelEventHandler(this.txtCurrentPassword_Validating);
            // 
            // lblTitle
            // 
            this.lblTitle.BackColor = System.Drawing.Color.Transparent;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI Black", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.Maroon;
            this.lblTitle.Location = new System.Drawing.Point(125, 23);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Padding = new System.Windows.Forms.Padding(0, 0, 200, 20);
            this.lblTitle.Size = new System.Drawing.Size(437, 59);
            this.lblTitle.TabIndex = 24;
            this.lblTitle.Text = "Change Password";
            // 
            // btnSavePassword
            // 
            this.btnSavePassword.BackColor = System.Drawing.Color.Transparent;
            this.btnSavePassword.BadgeBackColor = System.Drawing.Color.Red;
            this.btnSavePassword.BadgeForeColor = System.Drawing.Color.White;
            this.btnSavePassword.BadgeRadius = 8;
            this.btnSavePassword.BadgeRightMargin = 10;
            this.btnSavePassword.BadgeValue = 0;
            this.btnSavePassword.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnSavePassword.BorderColorEnd = System.Drawing.Color.Gray;
            this.btnSavePassword.BorderColorStart = System.Drawing.Color.White;
            this.btnSavePassword.BorderRadiusBottomLeft = 10;
            this.btnSavePassword.BorderRadiusBottomRight = 10;
            this.btnSavePassword.BorderRadiusTopLeft = 10;
            this.btnSavePassword.BorderRadiusTopRight = 10;
            this.btnSavePassword.BorderThickness = 1;
            this.btnSavePassword.ButtonColorEnd = System.Drawing.Color.Maroon;
            this.btnSavePassword.ButtonColorStart = System.Drawing.Color.Maroon;
            this.btnSavePassword.ButtonImage = null;
            this.btnSavePassword.CanBeep = false;
            this.btnSavePassword.CanShake = false;
            this.btnSavePassword.ClickSoundPath = null;
            this.btnSavePassword.DisabledOverlayOpacity = 0.5F;
            this.btnSavePassword.EnableBorderGradient = false;
            this.btnSavePassword.EnableClickSound = false;
            this.btnSavePassword.EnableFocusBorder = false;
            this.btnSavePassword.EnableHoverSound = false;
            this.btnSavePassword.EnablePressScale = false;
            this.btnSavePassword.EnableTextShadow = false;
            this.btnSavePassword.FocusBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(150)))), ((int)(((byte)(255)))));
            this.btnSavePassword.FocusBorderThickness = 2;
            this.btnSavePassword.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSavePassword.ForeColor = System.Drawing.Color.White;
            this.btnSavePassword.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnSavePassword.HoverSoundPath = null;
            this.btnSavePassword.HoverTransitionSpeed = 0.08F;
            this.btnSavePassword.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSavePassword.ImageLeftMargin = 5;
            this.btnSavePassword.ImageRightMargin = 8;
            this.btnSavePassword.ImageSize = 24;
            this.btnSavePassword.IsReadOnly = false;
            this.btnSavePassword.Location = new System.Drawing.Point(299, 323);
            this.btnSavePassword.MakeRadial = false;
            this.btnSavePassword.Name = "btnSavePassword";
            this.btnSavePassword.PressAnimationSpeed = 0.2F;
            this.btnSavePassword.PressDepth = 1;
            this.btnSavePassword.RippleColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnSavePassword.RippleExpandSpeedFactor = 0.05F;
            this.btnSavePassword.RippleFadeSpeedFactor = 0.03F;
            this.btnSavePassword.ShadowBlurFactor = 0.85F;
            this.btnSavePassword.ShadowColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnSavePassword.ShadowOffsetX = 3;
            this.btnSavePassword.ShadowOffsetY = 3;
            this.btnSavePassword.Size = new System.Drawing.Size(185, 53);
            this.btnSavePassword.TabIndex = 25;
            this.btnSavePassword.Text = "Save";
            this.btnSavePassword.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnSavePassword.TextPaddingBottom = 0;
            this.btnSavePassword.TextPaddingLeft = 0;
            this.btnSavePassword.TextPaddingRight = 0;
            this.btnSavePassword.TextPaddingTop = 0;
            this.btnSavePassword.TextShadowColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnSavePassword.TextShadowOffsetX = 1;
            this.btnSavePassword.TextShadowOffsetY = 1;
            this.btnSavePassword.Click += new System.EventHandler(this.btnSavePassword_Click);
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.Transparent;
            this.btnClose.BadgeBackColor = System.Drawing.Color.Red;
            this.btnClose.BadgeForeColor = System.Drawing.Color.White;
            this.btnClose.BadgeRadius = 8;
            this.btnClose.BadgeRightMargin = 10;
            this.btnClose.BadgeValue = 0;
            this.btnClose.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnClose.BorderColorEnd = System.Drawing.Color.Gray;
            this.btnClose.BorderColorStart = System.Drawing.Color.White;
            this.btnClose.BorderRadiusBottomLeft = 10;
            this.btnClose.BorderRadiusBottomRight = 10;
            this.btnClose.BorderRadiusTopLeft = 10;
            this.btnClose.BorderRadiusTopRight = 10;
            this.btnClose.BorderThickness = 1;
            this.btnClose.ButtonColorEnd = System.Drawing.Color.Maroon;
            this.btnClose.ButtonColorStart = System.Drawing.Color.Maroon;
            this.btnClose.ButtonImage = null;
            this.btnClose.CanBeep = false;
            this.btnClose.CanShake = false;
            this.btnClose.ClickSoundPath = null;
            this.btnClose.DisabledOverlayOpacity = 0.5F;
            this.btnClose.EnableBorderGradient = false;
            this.btnClose.EnableClickSound = false;
            this.btnClose.EnableFocusBorder = false;
            this.btnClose.EnableHoverSound = false;
            this.btnClose.EnablePressScale = false;
            this.btnClose.EnableTextShadow = false;
            this.btnClose.FocusBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(150)))), ((int)(((byte)(255)))));
            this.btnClose.FocusBorderThickness = 2;
            this.btnClose.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.ForeColor = System.Drawing.Color.White;
            this.btnClose.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnClose.HoverSoundPath = null;
            this.btnClose.HoverTransitionSpeed = 0.08F;
            this.btnClose.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnClose.ImageLeftMargin = 5;
            this.btnClose.ImageRightMargin = 8;
            this.btnClose.ImageSize = 24;
            this.btnClose.IsReadOnly = false;
            this.btnClose.Location = new System.Drawing.Point(45, 323);
            this.btnClose.MakeRadial = false;
            this.btnClose.Name = "btnClose";
            this.btnClose.PressAnimationSpeed = 0.2F;
            this.btnClose.PressDepth = 1;
            this.btnClose.RippleColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnClose.RippleExpandSpeedFactor = 0.05F;
            this.btnClose.RippleFadeSpeedFactor = 0.03F;
            this.btnClose.ShadowBlurFactor = 0.85F;
            this.btnClose.ShadowColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnClose.ShadowOffsetX = 3;
            this.btnClose.ShadowOffsetY = 3;
            this.btnClose.Size = new System.Drawing.Size(185, 53);
            this.btnClose.TabIndex = 26;
            this.btnClose.Text = "Close";
            this.btnClose.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnClose.TextPaddingBottom = 0;
            this.btnClose.TextPaddingLeft = 0;
            this.btnClose.TextPaddingRight = 0;
            this.btnClose.TextPaddingTop = 0;
            this.btnClose.TextShadowColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnClose.TextShadowOffsetX = 1;
            this.btnClose.TextShadowOffsetY = 1;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // txtConfirmPassword
            // 
            this.txtConfirmPassword.AccessibleDescription = "A customizable text input field.";
            this.txtConfirmPassword.AccessibleName = "Text Box";
            this.txtConfirmPassword.AccessibleRole = System.Windows.Forms.AccessibleRole.Text;
            this.txtConfirmPassword.BackColor = System.Drawing.Color.Transparent;
            this.txtConfirmPassword.BlinkCount = 3;
            this.txtConfirmPassword.BlinkShadow = false;
            this.txtConfirmPassword.BorderColor1 = System.Drawing.Color.LightSlateGray;
            this.txtConfirmPassword.BorderColor2 = System.Drawing.Color.LightSlateGray;
            this.txtConfirmPassword.BorderFocusColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(77)))), ((int)(((byte)(255)))));
            this.txtConfirmPassword.BorderFocusColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(77)))), ((int)(((byte)(255)))));
            this.txtConfirmPassword.CanShake = true;
            this.txtConfirmPassword.ContinuousBlink = false;
            this.txtConfirmPassword.CornerRadiusBottomLeft = 10;
            this.txtConfirmPassword.CornerRadiusBottomRight = 10;
            this.txtConfirmPassword.CornerRadiusTopLeft = 10;
            this.txtConfirmPassword.CornerRadiusTopRight = 10;
            this.txtConfirmPassword.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtConfirmPassword.CursorBlinkRate = 500;
            this.txtConfirmPassword.CursorColor = System.Drawing.Color.Black;
            this.txtConfirmPassword.CursorHeight = 26;
            this.txtConfirmPassword.CursorOffset = 0;
            this.txtConfirmPassword.CursorStyle = SiticoneNetFrameworkUI.Helpers.DrawingStyle.SiticoneDrawingStyle.Solid;
            this.txtConfirmPassword.CursorWidth = 1;
            this.txtConfirmPassword.DisabledBackColor = System.Drawing.Color.WhiteSmoke;
            this.txtConfirmPassword.DisabledBorderColor = System.Drawing.Color.LightGray;
            this.txtConfirmPassword.DisabledTextColor = System.Drawing.Color.Gray;
            this.txtConfirmPassword.EnableDropShadow = false;
            this.txtConfirmPassword.FillColor1 = System.Drawing.Color.White;
            this.txtConfirmPassword.FillColor2 = System.Drawing.Color.White;
            this.txtConfirmPassword.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.txtConfirmPassword.ForeColor = System.Drawing.Color.DimGray;
            this.txtConfirmPassword.HoverBorderColor1 = System.Drawing.Color.Gray;
            this.txtConfirmPassword.HoverBorderColor2 = System.Drawing.Color.Gray;
            this.txtConfirmPassword.IsEnabled = true;
            this.txtConfirmPassword.Location = new System.Drawing.Point(45, 253);
            this.txtConfirmPassword.MaxLength = 50;
            this.txtConfirmPassword.Name = "txtConfirmPassword";
            this.txtConfirmPassword.PlaceholderColor = System.Drawing.Color.Gray;
            this.txtConfirmPassword.PlaceholderText = "Confirm password*";
            this.txtConfirmPassword.ReadOnlyBorderColor1 = System.Drawing.Color.LightGray;
            this.txtConfirmPassword.ReadOnlyBorderColor2 = System.Drawing.Color.LightGray;
            this.txtConfirmPassword.ReadOnlyFillColor1 = System.Drawing.Color.WhiteSmoke;
            this.txtConfirmPassword.ReadOnlyFillColor2 = System.Drawing.Color.WhiteSmoke;
            this.txtConfirmPassword.ReadOnlyPlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtConfirmPassword.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(77)))), ((int)(((byte)(255)))));
            this.txtConfirmPassword.ShadowAnimationDuration = 1;
            this.txtConfirmPassword.ShadowBlur = 10;
            this.txtConfirmPassword.ShadowColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.txtConfirmPassword.Size = new System.Drawing.Size(438, 46);
            this.txtConfirmPassword.SolidBorderColor = System.Drawing.Color.LightSlateGray;
            this.txtConfirmPassword.SolidBorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(77)))), ((int)(((byte)(255)))));
            this.txtConfirmPassword.SolidBorderHoverColor = System.Drawing.Color.Gray;
            this.txtConfirmPassword.SolidFillColor = System.Drawing.Color.White;
            this.txtConfirmPassword.TabIndex = 27;
            this.txtConfirmPassword.TextPadding = new System.Windows.Forms.Padding(16, 0, 6, 0);
            this.txtConfirmPassword.UseSystemPasswordChar = true;
            this.txtConfirmPassword.ValidationErrorMessage = "Invalid input.";
            this.txtConfirmPassword.ValidationFunction = null;
            // 
            // frmChangePassword
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AntiqueWhite;
            this.ClientSize = new System.Drawing.Size(532, 420);
            this.Controls.Add(this.txtConfirmPassword);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnSavePassword);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.txtNewPassword);
            this.Controls.Add(this.txtCurrentPassword);
            this.Name = "frmChangePassword";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmChangePassword";
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private SiticoneNetFrameworkUI.SiticoneTextBox txtNewPasswordtxtConfirmPassword;
        private SiticoneNetFrameworkUI.SiticoneTextBox txtNewPassword;
        private SiticoneNetFrameworkUI.SiticoneTextBox txtCurrentPassword;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblTitle;
        private SiticoneNetFrameworkUI.SiticoneButtonAdvanced btnSavePassword;
        private SiticoneNetFrameworkUI.SiticoneButtonAdvanced btnClose;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private SiticoneNetFrameworkUI.SiticoneTextBox txtConfirmPassword;
    }
}