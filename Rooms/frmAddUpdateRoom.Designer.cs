namespace Hotel_Reservations_System
{
    partial class frmAddUpdateRoom
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
            this.guna2HtmlLabel1 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.lblRoomID = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.siticoneLabel1 = new SiticoneNetFrameworkUI.SiticoneLabel();
            this.rbSingle = new SiticoneNetFrameworkUI.SiticoneMaterialRadioButton();
            this.rbDouble = new SiticoneNetFrameworkUI.SiticoneMaterialRadioButton();
            this.rbSuite = new SiticoneNetFrameworkUI.SiticoneMaterialRadioButton();
            this.siticoneLabel2 = new SiticoneNetFrameworkUI.SiticoneLabel();
            this.siticoneLabel3 = new SiticoneNetFrameworkUI.SiticoneLabel();
            this.txtCost = new SiticoneNetFrameworkUI.SiticoneCurrencyTextBox();
            this.FeaturesPanel = new SiticoneNetFrameworkUI.SiticoneFlowPanel();
            this.lblTitle = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.btnSave = new SiticoneNetFrameworkUI.SiticoneButtonAdvanced();
            this.AddUpdateCustomer = new System.Windows.Forms.GroupBox();
            this.AddUpdateCustomer.SuspendLayout();
            this.SuspendLayout();
            // 
            // guna2HtmlLabel1
            // 
            this.guna2HtmlLabel1.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel1.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel1.ForeColor = System.Drawing.Color.Maroon;
            this.guna2HtmlLabel1.Location = new System.Drawing.Point(84, 75);
            this.guna2HtmlLabel1.Name = "guna2HtmlLabel1";
            this.guna2HtmlLabel1.Padding = new System.Windows.Forms.Padding(0, 0, 200, 0);
            this.guna2HtmlLabel1.Size = new System.Drawing.Size(282, 27);
            this.guna2HtmlLabel1.TabIndex = 14;
            this.guna2HtmlLabel1.Text = "Room ID: ";
            // 
            // lblRoomID
            // 
            this.lblRoomID.BackColor = System.Drawing.Color.Transparent;
            this.lblRoomID.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRoomID.ForeColor = System.Drawing.Color.Maroon;
            this.lblRoomID.Location = new System.Drawing.Point(203, 75);
            this.lblRoomID.Name = "lblRoomID";
            this.lblRoomID.Padding = new System.Windows.Forms.Padding(0, 0, 200, 0);
            this.lblRoomID.Size = new System.Drawing.Size(220, 27);
            this.lblRoomID.TabIndex = 15;
            this.lblRoomID.Text = "-1";
            // 
            // siticoneLabel1
            // 
            this.siticoneLabel1.BackColor = System.Drawing.Color.Transparent;
            this.siticoneLabel1.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.siticoneLabel1.Location = new System.Drawing.Point(17, 41);
            this.siticoneLabel1.Name = "siticoneLabel1";
            this.siticoneLabel1.Size = new System.Drawing.Size(222, 40);
            this.siticoneLabel1.TabIndex = 17;
            this.siticoneLabel1.Text = "Room Type:";
            // 
            // rbSingle
            // 
            this.rbSingle.ActiveRadioColor = System.Drawing.Color.Maroon;
            this.rbSingle.AlreadyCheckedRippleColor = System.Drawing.Color.FromArgb(((int)(((byte)(97)))), ((int)(((byte)(97)))), ((int)(((byte)(97)))));
            this.rbSingle.AnimationDuration = 250;
            this.rbSingle.BackColor = System.Drawing.Color.Transparent;
            this.rbSingle.BorderSize = 2;
            this.rbSingle.CanBeep = true;
            this.rbSingle.CanShake = true;
            this.rbSingle.CheckingRippleColor = System.Drawing.Color.Maroon;
            this.rbSingle.CheckMarkColor = System.Drawing.Color.White;
            this.rbSingle.CheckMarkThickness = 2F;
            this.rbSingle.CustomFont = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbSingle.DisabledColor = System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(176)))), ((int)(((byte)(176)))));
            this.rbSingle.DotSizeRatio = 0.5F;
            this.rbSingle.EnableKeyboardSupport = true;
            this.rbSingle.EnableRippleEffect = true;
            this.rbSingle.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbSingle.GroupName = "Room type";
            this.rbSingle.IdleRadioBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(97)))), ((int)(((byte)(97)))), ((int)(((byte)(97)))));
            this.rbSingle.LeftPadding = 10;
            this.rbSingle.Location = new System.Drawing.Point(138, 30);
            this.rbSingle.Name = "rbSingle";
            this.rbSingle.RadioButtonSize = 18;
            this.rbSingle.ReadOnly = false;
            this.rbSingle.ReadOnlyColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.rbSingle.RippleOpacity = ((byte)(80));
            this.rbSingle.RippleSizeMultiplier = 2;
            this.rbSingle.ShakeDuration = 400;
            this.rbSingle.ShakeIntensity = 5;
            this.rbSingle.Size = new System.Drawing.Size(127, 56);
            this.rbSingle.Style = SiticoneNetFrameworkUI.RadioButtonStyle.Outlined;
            this.rbSingle.TabIndex = 19;
            this.rbSingle.Text = "Single";
            this.rbSingle.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.rbSingle.RadioButtonSelected += new System.EventHandler<SiticoneNetFrameworkUI.SiticoneMaterialRadioButton.RadioButtonEventArgs>(this.rbSingle_RadioButtonSelected);
            // 
            // rbDouble
            // 
            this.rbDouble.ActiveRadioColor = System.Drawing.Color.Maroon;
            this.rbDouble.AlreadyCheckedRippleColor = System.Drawing.Color.FromArgb(((int)(((byte)(97)))), ((int)(((byte)(97)))), ((int)(((byte)(97)))));
            this.rbDouble.AnimationDuration = 250;
            this.rbDouble.BackColor = System.Drawing.Color.Transparent;
            this.rbDouble.BorderSize = 2;
            this.rbDouble.CanBeep = true;
            this.rbDouble.CanShake = true;
            this.rbDouble.CheckingRippleColor = System.Drawing.Color.Maroon;
            this.rbDouble.CheckMarkColor = System.Drawing.Color.White;
            this.rbDouble.CheckMarkThickness = 2F;
            this.rbDouble.CustomFont = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbDouble.DisabledColor = System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(176)))), ((int)(((byte)(176)))));
            this.rbDouble.DotSizeRatio = 0.5F;
            this.rbDouble.EnableKeyboardSupport = true;
            this.rbDouble.EnableRippleEffect = true;
            this.rbDouble.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbDouble.GroupName = "Room type";
            this.rbDouble.IdleRadioBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(97)))), ((int)(((byte)(97)))), ((int)(((byte)(97)))));
            this.rbDouble.LeftPadding = 10;
            this.rbDouble.Location = new System.Drawing.Point(281, 27);
            this.rbDouble.Name = "rbDouble";
            this.rbDouble.RadioButtonSize = 18;
            this.rbDouble.ReadOnly = false;
            this.rbDouble.ReadOnlyColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.rbDouble.RippleOpacity = ((byte)(80));
            this.rbDouble.RippleSizeMultiplier = 2;
            this.rbDouble.ShakeDuration = 400;
            this.rbDouble.ShakeIntensity = 5;
            this.rbDouble.Size = new System.Drawing.Size(127, 56);
            this.rbDouble.Style = SiticoneNetFrameworkUI.RadioButtonStyle.Outlined;
            this.rbDouble.TabIndex = 20;
            this.rbDouble.Text = "Double";
            this.rbDouble.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.rbDouble.RadioButtonSelected += new System.EventHandler<SiticoneNetFrameworkUI.SiticoneMaterialRadioButton.RadioButtonEventArgs>(this.rbDouble_RadioButtonSelected);
            // 
            // rbSuite
            // 
            this.rbSuite.ActiveRadioColor = System.Drawing.Color.Maroon;
            this.rbSuite.AlreadyCheckedRippleColor = System.Drawing.Color.FromArgb(((int)(((byte)(97)))), ((int)(((byte)(97)))), ((int)(((byte)(97)))));
            this.rbSuite.AnimationDuration = 250;
            this.rbSuite.BackColor = System.Drawing.Color.Transparent;
            this.rbSuite.BorderSize = 2;
            this.rbSuite.CanBeep = true;
            this.rbSuite.CanShake = true;
            this.rbSuite.CheckingRippleColor = System.Drawing.Color.LightGray;
            this.rbSuite.CheckMarkColor = System.Drawing.Color.White;
            this.rbSuite.CheckMarkThickness = 2F;
            this.rbSuite.CustomFont = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbSuite.DisabledColor = System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(176)))), ((int)(((byte)(176)))));
            this.rbSuite.DotSizeRatio = 0.5F;
            this.rbSuite.EnableKeyboardSupport = true;
            this.rbSuite.EnableRippleEffect = true;
            this.rbSuite.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbSuite.GroupName = "Room type";
            this.rbSuite.IdleRadioBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(97)))), ((int)(((byte)(97)))), ((int)(((byte)(97)))));
            this.rbSuite.LeftPadding = 10;
            this.rbSuite.Location = new System.Drawing.Point(414, 30);
            this.rbSuite.Name = "rbSuite";
            this.rbSuite.RadioButtonSize = 18;
            this.rbSuite.ReadOnly = false;
            this.rbSuite.ReadOnlyColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.rbSuite.RippleOpacity = ((byte)(80));
            this.rbSuite.RippleSizeMultiplier = 2;
            this.rbSuite.ShakeDuration = 400;
            this.rbSuite.ShakeIntensity = 5;
            this.rbSuite.Size = new System.Drawing.Size(144, 56);
            this.rbSuite.Style = SiticoneNetFrameworkUI.RadioButtonStyle.Outlined;
            this.rbSuite.TabIndex = 21;
            this.rbSuite.Text = "Suite";
            this.rbSuite.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.rbSuite.RadioButtonSelected += new System.EventHandler<SiticoneNetFrameworkUI.SiticoneMaterialRadioButton.RadioButtonEventArgs>(this.rbSuite_RadioButtonSelected);
            // 
            // siticoneLabel2
            // 
            this.siticoneLabel2.BackColor = System.Drawing.Color.Transparent;
            this.siticoneLabel2.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.siticoneLabel2.Location = new System.Drawing.Point(17, 92);
            this.siticoneLabel2.Name = "siticoneLabel2";
            this.siticoneLabel2.Size = new System.Drawing.Size(222, 40);
            this.siticoneLabel2.TabIndex = 22;
            this.siticoneLabel2.Text = "Features:";
            // 
            // siticoneLabel3
            // 
            this.siticoneLabel3.BackColor = System.Drawing.Color.Transparent;
            this.siticoneLabel3.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.siticoneLabel3.Location = new System.Drawing.Point(43, 425);
            this.siticoneLabel3.Name = "siticoneLabel3";
            this.siticoneLabel3.Size = new System.Drawing.Size(222, 40);
            this.siticoneLabel3.TabIndex = 24;
            this.siticoneLabel3.Text = "Cost:";
            // 
            // txtCost
            // 
            this.txtCost.BackColor = System.Drawing.Color.Transparent;
            this.txtCost.CurrencyInputBackgroundColor = System.Drawing.Color.White;
            this.txtCost.CurrencyInputBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(210)))), ((int)(((byte)(210)))));
            this.txtCost.CurrencyInputPlaceholderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.txtCost.CurrencyInputReadOnlyColors.CurrencyInputBackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(245)))), ((int)(((byte)(245)))));
            this.txtCost.CurrencyInputReadOnlyColors.CurrencyInputBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.txtCost.CurrencyInputReadOnlyColors.CurrencyInputPlaceholderColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(150)))), ((int)(((byte)(150)))));
            this.txtCost.CurrencyInputReadOnlyColors.CurrencyInputTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.txtCost.CurrencyInputTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.txtCost.CurrencySymbolPosition = SiticoneNetFrameworkUI.CurrencySymbolPosition.Right;
            this.txtCost.Cursor = System.Windows.Forms.Cursors.No;
            this.txtCost.FocusCurrencyInputBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(215)))));
            this.txtCost.FocusImage = null;
            this.txtCost.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtCost.HoverCurrencyInputBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(165)))), ((int)(((byte)(212)))));
            this.txtCost.HoverImage = null;
            this.txtCost.IdleImage = null;
            this.txtCost.IsReadOnly = true;
            this.txtCost.Location = new System.Drawing.Point(137, 418);
            this.txtCost.MinValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.txtCost.Name = "txtCost";
            this.txtCost.PlaceholderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(215)))));
            this.txtCost.PlaceholderFont = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.txtCost.PlaceholderText = "Enter amount";
            this.txtCost.Size = new System.Drawing.Size(355, 47);
            this.txtCost.TabIndex = 25;
            this.txtCost.TabStop = false;
            this.txtCost.TextContent = "0.00$";
            this.txtCost.Value = new decimal(new int[] {
            0,
            0,
            0,
            131072});
            // 
            // FeaturesPanel
            // 
            this.FeaturesPanel.AutoScroll = true;
            this.FeaturesPanel.EnableAnimations = true;
            this.FeaturesPanel.EnableAutoScale = true;
            this.FeaturesPanel.EnableDragDrop = true;
            this.FeaturesPanel.EnableLayoutCaching = false;
            this.FeaturesPanel.EnableSmoothScrolling = true;
            this.FeaturesPanel.EnableSnapToGrid = false;
            this.FeaturesPanel.EnableTransparency = false;
            this.FeaturesPanel.EnableVirtualization = false;
            this.FeaturesPanel.EnableWrapping = true;
            this.FeaturesPanel.GridSize = 8;
            this.FeaturesPanel.IsTrackingTheme = false;
            this.FeaturesPanel.ItemSpacing = 5;
            this.FeaturesPanel.Location = new System.Drawing.Point(138, 92);
            this.FeaturesPanel.Name = "FeaturesPanel";
            this.FeaturesPanel.Size = new System.Drawing.Size(354, 313);
            this.FeaturesPanel.TabIndex = 36;
            this.FeaturesPanel.VirtualizationThreshold = 100;
            // 
            // lblTitle
            // 
            this.lblTitle.BackColor = System.Drawing.Color.Transparent;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI Black", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.Maroon;
            this.lblTitle.Location = new System.Drawing.Point(249, 12);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Padding = new System.Windows.Forms.Padding(0, 0, 70, 10);
            this.lblTitle.Size = new System.Drawing.Size(327, 57);
            this.lblTitle.TabIndex = 38;
            this.lblTitle.Text = "Add New Room";
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.Transparent;
            this.btnSave.BadgeBackColor = System.Drawing.Color.Red;
            this.btnSave.BadgeForeColor = System.Drawing.Color.White;
            this.btnSave.BadgeRadius = 8;
            this.btnSave.BadgeRightMargin = 10;
            this.btnSave.BadgeValue = 0;
            this.btnSave.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnSave.BorderColorEnd = System.Drawing.Color.Gray;
            this.btnSave.BorderColorStart = System.Drawing.Color.White;
            this.btnSave.BorderRadiusBottomLeft = 10;
            this.btnSave.BorderRadiusBottomRight = 10;
            this.btnSave.BorderRadiusTopLeft = 10;
            this.btnSave.BorderRadiusTopRight = 10;
            this.btnSave.BorderThickness = 1;
            this.btnSave.ButtonColorEnd = System.Drawing.Color.Brown;
            this.btnSave.ButtonColorStart = System.Drawing.Color.Maroon;
            this.btnSave.ButtonImage = null;
            this.btnSave.CanBeep = false;
            this.btnSave.CanShake = false;
            this.btnSave.ClickSoundPath = null;
            this.btnSave.DisabledOverlayOpacity = 0.5F;
            this.btnSave.EnableBorderGradient = false;
            this.btnSave.EnableClickSound = false;
            this.btnSave.EnableFocusBorder = false;
            this.btnSave.EnableHoverSound = false;
            this.btnSave.EnablePressScale = false;
            this.btnSave.EnableTextShadow = false;
            this.btnSave.FocusBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(150)))), ((int)(((byte)(255)))));
            this.btnSave.FocusBorderThickness = 2;
            this.btnSave.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.ForeColor = System.Drawing.Color.Wheat;
            this.btnSave.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnSave.HoverSoundPath = null;
            this.btnSave.HoverTransitionSpeed = 0.08F;
            this.btnSave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSave.ImageLeftMargin = 5;
            this.btnSave.ImageRightMargin = 8;
            this.btnSave.ImageSize = 24;
            this.btnSave.IsReadOnly = false;
            this.btnSave.Location = new System.Drawing.Point(152, 642);
            this.btnSave.MakeRadial = false;
            this.btnSave.Name = "btnSave";
            this.btnSave.PressAnimationSpeed = 0.2F;
            this.btnSave.PressDepth = 1;
            this.btnSave.RippleColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnSave.RippleExpandSpeedFactor = 0.05F;
            this.btnSave.RippleFadeSpeedFactor = 0.03F;
            this.btnSave.ShadowBlurFactor = 0.85F;
            this.btnSave.ShadowColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnSave.ShadowOffsetX = 3;
            this.btnSave.ShadowOffsetY = 3;
            this.btnSave.Size = new System.Drawing.Size(440, 44);
            this.btnSave.TabIndex = 39;
            this.btnSave.Text = "Save";
            this.btnSave.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnSave.TextPaddingBottom = 0;
            this.btnSave.TextPaddingLeft = 0;
            this.btnSave.TextPaddingRight = 0;
            this.btnSave.TextPaddingTop = 0;
            this.btnSave.TextShadowColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnSave.TextShadowOffsetX = 1;
            this.btnSave.TextShadowOffsetY = 1;
            this.btnSave.UltraPerformanceMode = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // AddUpdateCustomer
            // 
            this.AddUpdateCustomer.Controls.Add(this.rbDouble);
            this.AddUpdateCustomer.Controls.Add(this.rbSingle);
            this.AddUpdateCustomer.Controls.Add(this.rbSuite);
            this.AddUpdateCustomer.Controls.Add(this.FeaturesPanel);
            this.AddUpdateCustomer.Controls.Add(this.siticoneLabel2);
            this.AddUpdateCustomer.Controls.Add(this.txtCost);
            this.AddUpdateCustomer.Controls.Add(this.siticoneLabel3);
            this.AddUpdateCustomer.Controls.Add(this.siticoneLabel1);
            this.AddUpdateCustomer.Location = new System.Drawing.Point(84, 120);
            this.AddUpdateCustomer.Name = "AddUpdateCustomer";
            this.AddUpdateCustomer.Size = new System.Drawing.Size(612, 493);
            this.AddUpdateCustomer.TabIndex = 40;
            this.AddUpdateCustomer.TabStop = false;
            this.AddUpdateCustomer.Text = "Add New Room";
            // 
            // frmAddUpdateRoom
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AntiqueWhite;
            this.ClientSize = new System.Drawing.Size(797, 707);
            this.Controls.Add(this.AddUpdateCustomer);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.lblRoomID);
            this.Controls.Add(this.guna2HtmlLabel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmAddUpdateRoom";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.frmAddNewRoom_Load);
            this.AddUpdateCustomer.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel1;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblRoomID;
        private SiticoneNetFrameworkUI.SiticoneLabel siticoneLabel1;
        private SiticoneNetFrameworkUI.SiticoneMaterialRadioButton rbSingle;
        private SiticoneNetFrameworkUI.SiticoneMaterialRadioButton rbDouble;
        private SiticoneNetFrameworkUI.SiticoneMaterialRadioButton rbSuite;
        private SiticoneNetFrameworkUI.SiticoneLabel siticoneLabel2;
        private SiticoneNetFrameworkUI.SiticoneLabel siticoneLabel3;
        private SiticoneNetFrameworkUI.SiticoneCurrencyTextBox txtCost;
        private SiticoneNetFrameworkUI.SiticoneFlowPanel FeaturesPanel;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblTitle;
        private SiticoneNetFrameworkUI.SiticoneButtonAdvanced btnSave;
        private System.Windows.Forms.GroupBox AddUpdateCustomer;
    }
}