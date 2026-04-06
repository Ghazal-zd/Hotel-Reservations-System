namespace Hotel_Reservations_System
{
    partial class frmCustomersList
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.cmbFilter = new Guna.UI2.WinForms.Guna2ComboBox();
            this.lblTitle = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.cmsCustomers = new Guna.UI2.WinForms.Guna2ContextMenuStrip();
            this.chooseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.detailsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addNewCustomerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.btnClose = new SiticoneNetFrameworkUI.SiticoneButton();
            this.btnDetails = new SiticoneNetFrameworkUI.SiticoneButton();
            this.btnChoose = new SiticoneNetFrameworkUI.SiticoneButton();
            this.btnEdit = new SiticoneNetFrameworkUI.SiticoneButton();
            this.siticoneGroupBox1 = new SiticoneNetFrameworkUI.SiticoneGroupBox();
            this.txtSearch = new Guna.UI2.WinForms.Guna2TextBox();
            this.dgvCustomers = new Guna.UI2.WinForms.Guna2DataGridView();
            this.btnAddCustomer = new SiticoneNetFrameworkUI.SiticoneButton();
            this.guna2HtmlLabel1 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2HtmlLabel2 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.cmsCustomers.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.siticoneGroupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCustomers)).BeginInit();
            this.SuspendLayout();
            // 
            // cmbFilter
            // 
            this.cmbFilter.BackColor = System.Drawing.Color.Transparent;
            this.cmbFilter.BorderRadius = 10;
            this.cmbFilter.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbFilter.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbFilter.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmbFilter.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmbFilter.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cmbFilter.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cmbFilter.ItemHeight = 30;
            this.cmbFilter.Items.AddRange(new object[] {
            "None",
            "Customer ID",
            "Customer Name",
            "Phone Number",
            "Email"});
            this.cmbFilter.Location = new System.Drawing.Point(38, 136);
            this.cmbFilter.Name = "cmbFilter";
            this.cmbFilter.Size = new System.Drawing.Size(239, 36);
            this.cmbFilter.TabIndex = 8;
            this.cmbFilter.SelectedIndexChanged += new System.EventHandler(this.cmbFilter_SelectedIndexChanged);
            // 
            // lblTitle
            // 
            this.lblTitle.BackColor = System.Drawing.Color.Transparent;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 22.2F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.Maroon;
            this.lblTitle.Location = new System.Drawing.Point(812, 46);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Padding = new System.Windows.Forms.Padding(0, 0, 200, 0);
            this.lblTitle.Size = new System.Drawing.Size(440, 52);
            this.lblTitle.TabIndex = 7;
            this.lblTitle.Text = "Customer List";
            // 
            // cmsCustomers
            // 
            this.cmsCustomers.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.cmsCustomers.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.chooseToolStripMenuItem,
            this.detailsToolStripMenuItem,
            this.editToolStripMenuItem,
            this.addNewCustomerToolStripMenuItem});
            this.cmsCustomers.Name = "cmCustomers";
            this.cmsCustomers.RenderStyle.ArrowColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.cmsCustomers.RenderStyle.BorderColor = System.Drawing.Color.Gainsboro;
            this.cmsCustomers.RenderStyle.ColorTable = null;
            this.cmsCustomers.RenderStyle.RoundedEdges = true;
            this.cmsCustomers.RenderStyle.SelectionArrowColor = System.Drawing.Color.White;
            this.cmsCustomers.RenderStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.cmsCustomers.RenderStyle.SelectionForeColor = System.Drawing.Color.White;
            this.cmsCustomers.RenderStyle.SeparatorColor = System.Drawing.Color.Gainsboro;
            this.cmsCustomers.RenderStyle.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault;
            this.cmsCustomers.Size = new System.Drawing.Size(208, 100);
            this.cmsCustomers.Opening += new System.ComponentModel.CancelEventHandler(this.cmsCustomers_Opening);
            // 
            // chooseToolStripMenuItem
            // 
            this.chooseToolStripMenuItem.Name = "chooseToolStripMenuItem";
            this.chooseToolStripMenuItem.Size = new System.Drawing.Size(207, 24);
            this.chooseToolStripMenuItem.Text = "Choose";
            this.chooseToolStripMenuItem.Click += new System.EventHandler(this.chooseToolStripMenuItem_Click);
            // 
            // detailsToolStripMenuItem
            // 
            this.detailsToolStripMenuItem.Name = "detailsToolStripMenuItem";
            this.detailsToolStripMenuItem.Size = new System.Drawing.Size(207, 24);
            this.detailsToolStripMenuItem.Text = "Details";
            this.detailsToolStripMenuItem.Click += new System.EventHandler(this.detailsToolStripMenuItem_Click);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(207, 24);
            this.editToolStripMenuItem.Text = "Edit";
            this.editToolStripMenuItem.Click += new System.EventHandler(this.editToolStripMenuItem_Click);
            // 
            // addNewCustomerToolStripMenuItem
            // 
            this.addNewCustomerToolStripMenuItem.Name = "addNewCustomerToolStripMenuItem";
            this.addNewCustomerToolStripMenuItem.Size = new System.Drawing.Size(207, 24);
            this.addNewCustomerToolStripMenuItem.Text = "Add New Customer";
            this.addNewCustomerToolStripMenuItem.Click += new System.EventHandler(this.addNewCustomerToolStripMenuItem_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // btnClose
            // 
            this.btnClose.AccessibleDescription = "The default button control that accept input though the mouse, touch and keyboard" +
    "";
            this.btnClose.AccessibleName = "Close";
            this.btnClose.AutoSizeBasedOnText = false;
            this.btnClose.BackColor = System.Drawing.Color.Transparent;
            this.btnClose.BadgeBackColor = System.Drawing.Color.Gainsboro;
            this.btnClose.BadgeFont = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.BadgeValue = 0;
            this.btnClose.BadgeValueForeColor = System.Drawing.Color.Gainsboro;
            this.btnClose.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(216)))), ((int)(((byte)(220)))));
            this.btnClose.BorderWidth = 1;
            this.btnClose.ButtonBackColor = System.Drawing.Color.Maroon;
            this.btnClose.ButtonImage = null;
            this.btnClose.ButtonTextLeftPadding = 0;
            this.btnClose.CanBeep = true;
            this.btnClose.CanGlow = false;
            this.btnClose.CanShake = true;
            this.btnClose.ContextMenuStripEx = null;
            this.btnClose.CornerRadiusBottomLeft = 10;
            this.btnClose.CornerRadiusBottomRight = 10;
            this.btnClose.CornerRadiusTopLeft = 10;
            this.btnClose.CornerRadiusTopRight = 10;
            this.btnClose.CustomCursor = System.Windows.Forms.Cursors.Default;
            this.btnClose.DisabledTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(150)))), ((int)(((byte)(150)))));
            this.btnClose.EnableLongPress = false;
            this.btnClose.EnableRippleEffect = true;
            this.btnClose.EnableShadow = false;
            this.btnClose.EnableTextWrapping = false;
            this.btnClose.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F);
            this.btnClose.GlowColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnClose.GlowIntensity = 100;
            this.btnClose.GlowRadius = 20F;
            this.btnClose.GradientBackground = false;
            this.btnClose.GradientColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(227)))), ((int)(((byte)(64)))));
            this.btnClose.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.btnClose.HintText = null;
            this.btnClose.HoverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.btnClose.HoverFontStyle = System.Drawing.FontStyle.Regular;
            this.btnClose.HoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnClose.HoverTransitionDuration = 250;
            this.btnClose.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnClose.ImagePadding = 5;
            this.btnClose.ImageSize = new System.Drawing.Size(16, 16);
            this.btnClose.IsRadial = false;
            this.btnClose.IsReadOnly = false;
            this.btnClose.IsToggleButton = false;
            this.btnClose.IsToggled = false;
            this.btnClose.Location = new System.Drawing.Point(1393, 557);
            this.btnClose.LongPressDurationMS = 1000;
            this.btnClose.Name = "btnClose";
            this.btnClose.NormalFontStyle = System.Drawing.FontStyle.Regular;
            this.btnClose.ParticleColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.btnClose.ParticleCount = 15;
            this.btnClose.PressAnimationScale = 0.97F;
            this.btnClose.PressedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(227)))), ((int)(((byte)(230)))));
            this.btnClose.PressedFontStyle = System.Drawing.FontStyle.Regular;
            this.btnClose.PressTransitionDuration = 150;
            this.btnClose.ReadOnlyTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.btnClose.RippleColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnClose.RippleRadiusMultiplier = 0.6F;
            this.btnClose.ShadowBlur = 5;
            this.btnClose.ShadowColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnClose.ShadowOffset = new System.Drawing.Point(0, 2);
            this.btnClose.ShakeDuration = 500;
            this.btnClose.ShakeIntensity = 5;
            this.btnClose.Size = new System.Drawing.Size(275, 52);
            this.btnClose.TabIndex = 49;
            this.btnClose.Text = "Close";
            this.btnClose.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnClose.TextColor = System.Drawing.Color.WhiteSmoke;
            this.btnClose.TooltipText = null;
            this.btnClose.UseAdvancedRendering = true;
            this.btnClose.UseParticles = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnDetails
            // 
            this.btnDetails.AccessibleDescription = "The default button control that accept input though the mouse, touch and keyboard" +
    "";
            this.btnDetails.AccessibleName = "Details";
            this.btnDetails.AutoSizeBasedOnText = false;
            this.btnDetails.BackColor = System.Drawing.Color.Transparent;
            this.btnDetails.BadgeBackColor = System.Drawing.Color.Gainsboro;
            this.btnDetails.BadgeFont = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDetails.BadgeValue = 0;
            this.btnDetails.BadgeValueForeColor = System.Drawing.Color.Gainsboro;
            this.btnDetails.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(216)))), ((int)(((byte)(220)))));
            this.btnDetails.BorderWidth = 1;
            this.btnDetails.ButtonBackColor = System.Drawing.Color.Maroon;
            this.btnDetails.ButtonImage = null;
            this.btnDetails.ButtonTextLeftPadding = 0;
            this.btnDetails.CanBeep = true;
            this.btnDetails.CanGlow = false;
            this.btnDetails.CanShake = true;
            this.btnDetails.ContextMenuStripEx = null;
            this.btnDetails.CornerRadiusBottomLeft = 10;
            this.btnDetails.CornerRadiusBottomRight = 10;
            this.btnDetails.CornerRadiusTopLeft = 10;
            this.btnDetails.CornerRadiusTopRight = 10;
            this.btnDetails.CustomCursor = System.Windows.Forms.Cursors.Default;
            this.btnDetails.DisabledTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(150)))), ((int)(((byte)(150)))));
            this.btnDetails.EnableLongPress = false;
            this.btnDetails.EnableRippleEffect = true;
            this.btnDetails.EnableShadow = false;
            this.btnDetails.EnableTextWrapping = false;
            this.btnDetails.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F);
            this.btnDetails.GlowColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnDetails.GlowIntensity = 100;
            this.btnDetails.GlowRadius = 20F;
            this.btnDetails.GradientBackground = false;
            this.btnDetails.GradientColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(227)))), ((int)(((byte)(64)))));
            this.btnDetails.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.btnDetails.HintText = null;
            this.btnDetails.HoverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.btnDetails.HoverFontStyle = System.Drawing.FontStyle.Regular;
            this.btnDetails.HoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnDetails.HoverTransitionDuration = 250;
            this.btnDetails.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDetails.ImagePadding = 5;
            this.btnDetails.ImageSize = new System.Drawing.Size(16, 16);
            this.btnDetails.IsRadial = false;
            this.btnDetails.IsReadOnly = false;
            this.btnDetails.IsToggleButton = false;
            this.btnDetails.IsToggled = false;
            this.btnDetails.Location = new System.Drawing.Point(1393, 192);
            this.btnDetails.LongPressDurationMS = 1000;
            this.btnDetails.Name = "btnDetails";
            this.btnDetails.NormalFontStyle = System.Drawing.FontStyle.Regular;
            this.btnDetails.ParticleColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.btnDetails.ParticleCount = 15;
            this.btnDetails.PressAnimationScale = 0.97F;
            this.btnDetails.PressedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(227)))), ((int)(((byte)(230)))));
            this.btnDetails.PressedFontStyle = System.Drawing.FontStyle.Regular;
            this.btnDetails.PressTransitionDuration = 150;
            this.btnDetails.ReadOnlyTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.btnDetails.RippleColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnDetails.RippleRadiusMultiplier = 0.6F;
            this.btnDetails.ShadowBlur = 5;
            this.btnDetails.ShadowColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnDetails.ShadowOffset = new System.Drawing.Point(0, 2);
            this.btnDetails.ShakeDuration = 500;
            this.btnDetails.ShakeIntensity = 5;
            this.btnDetails.Size = new System.Drawing.Size(275, 52);
            this.btnDetails.TabIndex = 45;
            this.btnDetails.Text = "Details";
            this.btnDetails.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnDetails.TextColor = System.Drawing.Color.WhiteSmoke;
            this.btnDetails.TooltipText = null;
            this.btnDetails.UseAdvancedRendering = true;
            this.btnDetails.UseParticles = false;
            this.btnDetails.Click += new System.EventHandler(this.btnDetails_Click);
            // 
            // btnChoose
            // 
            this.btnChoose.AccessibleDescription = "The default button control that accept input though the mouse, touch and keyboard" +
    "";
            this.btnChoose.AccessibleName = "Choose";
            this.btnChoose.AutoSizeBasedOnText = false;
            this.btnChoose.BackColor = System.Drawing.Color.Transparent;
            this.btnChoose.BadgeBackColor = System.Drawing.Color.Gainsboro;
            this.btnChoose.BadgeFont = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChoose.BadgeValue = 0;
            this.btnChoose.BadgeValueForeColor = System.Drawing.Color.Gainsboro;
            this.btnChoose.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(216)))), ((int)(((byte)(220)))));
            this.btnChoose.BorderWidth = 1;
            this.btnChoose.ButtonBackColor = System.Drawing.Color.Maroon;
            this.btnChoose.ButtonImage = null;
            this.btnChoose.ButtonTextLeftPadding = 0;
            this.btnChoose.CanBeep = true;
            this.btnChoose.CanGlow = false;
            this.btnChoose.CanShake = true;
            this.btnChoose.ContextMenuStripEx = null;
            this.btnChoose.CornerRadiusBottomLeft = 10;
            this.btnChoose.CornerRadiusBottomRight = 10;
            this.btnChoose.CornerRadiusTopLeft = 10;
            this.btnChoose.CornerRadiusTopRight = 10;
            this.btnChoose.CustomCursor = System.Windows.Forms.Cursors.Default;
            this.btnChoose.DisabledTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(150)))), ((int)(((byte)(150)))));
            this.btnChoose.EnableLongPress = false;
            this.btnChoose.EnableRippleEffect = true;
            this.btnChoose.EnableShadow = false;
            this.btnChoose.EnableTextWrapping = false;
            this.btnChoose.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F);
            this.btnChoose.GlowColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnChoose.GlowIntensity = 100;
            this.btnChoose.GlowRadius = 20F;
            this.btnChoose.GradientBackground = false;
            this.btnChoose.GradientColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(227)))), ((int)(((byte)(64)))));
            this.btnChoose.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.btnChoose.HintText = null;
            this.btnChoose.HoverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.btnChoose.HoverFontStyle = System.Drawing.FontStyle.Regular;
            this.btnChoose.HoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnChoose.HoverTransitionDuration = 250;
            this.btnChoose.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnChoose.ImagePadding = 5;
            this.btnChoose.ImageSize = new System.Drawing.Size(16, 16);
            this.btnChoose.IsRadial = false;
            this.btnChoose.IsReadOnly = false;
            this.btnChoose.IsToggleButton = false;
            this.btnChoose.IsToggled = false;
            this.btnChoose.Location = new System.Drawing.Point(1393, 368);
            this.btnChoose.LongPressDurationMS = 1000;
            this.btnChoose.Name = "btnChoose";
            this.btnChoose.NormalFontStyle = System.Drawing.FontStyle.Regular;
            this.btnChoose.ParticleColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.btnChoose.ParticleCount = 15;
            this.btnChoose.PressAnimationScale = 0.97F;
            this.btnChoose.PressedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(227)))), ((int)(((byte)(230)))));
            this.btnChoose.PressedFontStyle = System.Drawing.FontStyle.Regular;
            this.btnChoose.PressTransitionDuration = 150;
            this.btnChoose.ReadOnlyTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.btnChoose.RippleColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnChoose.RippleRadiusMultiplier = 0.6F;
            this.btnChoose.ShadowBlur = 5;
            this.btnChoose.ShadowColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnChoose.ShadowOffset = new System.Drawing.Point(0, 2);
            this.btnChoose.ShakeDuration = 500;
            this.btnChoose.ShakeIntensity = 5;
            this.btnChoose.Size = new System.Drawing.Size(275, 52);
            this.btnChoose.TabIndex = 46;
            this.btnChoose.Text = "Choose";
            this.btnChoose.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnChoose.TextColor = System.Drawing.Color.WhiteSmoke;
            this.btnChoose.TooltipText = null;
            this.btnChoose.UseAdvancedRendering = true;
            this.btnChoose.UseParticles = false;
            this.btnChoose.Click += new System.EventHandler(this.btnChoose_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.AccessibleDescription = "The default button control that accept input though the mouse, touch and keyboard" +
    "";
            this.btnEdit.AccessibleName = "Edit";
            this.btnEdit.AutoSizeBasedOnText = false;
            this.btnEdit.BackColor = System.Drawing.Color.Transparent;
            this.btnEdit.BadgeBackColor = System.Drawing.Color.Gainsboro;
            this.btnEdit.BadgeFont = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEdit.BadgeValue = 0;
            this.btnEdit.BadgeValueForeColor = System.Drawing.Color.Gainsboro;
            this.btnEdit.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(216)))), ((int)(((byte)(220)))));
            this.btnEdit.BorderWidth = 1;
            this.btnEdit.ButtonBackColor = System.Drawing.Color.Maroon;
            this.btnEdit.ButtonImage = null;
            this.btnEdit.ButtonTextLeftPadding = 0;
            this.btnEdit.CanBeep = true;
            this.btnEdit.CanGlow = false;
            this.btnEdit.CanShake = true;
            this.btnEdit.ContextMenuStripEx = null;
            this.btnEdit.CornerRadiusBottomLeft = 10;
            this.btnEdit.CornerRadiusBottomRight = 10;
            this.btnEdit.CornerRadiusTopLeft = 10;
            this.btnEdit.CornerRadiusTopRight = 10;
            this.btnEdit.CustomCursor = System.Windows.Forms.Cursors.Default;
            this.btnEdit.DisabledTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(150)))), ((int)(((byte)(150)))));
            this.btnEdit.EnableLongPress = false;
            this.btnEdit.EnableRippleEffect = true;
            this.btnEdit.EnableShadow = false;
            this.btnEdit.EnableTextWrapping = false;
            this.btnEdit.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F);
            this.btnEdit.GlowColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnEdit.GlowIntensity = 100;
            this.btnEdit.GlowRadius = 20F;
            this.btnEdit.GradientBackground = false;
            this.btnEdit.GradientColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(227)))), ((int)(((byte)(64)))));
            this.btnEdit.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.btnEdit.HintText = null;
            this.btnEdit.HoverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.btnEdit.HoverFontStyle = System.Drawing.FontStyle.Regular;
            this.btnEdit.HoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnEdit.HoverTransitionDuration = 250;
            this.btnEdit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEdit.ImagePadding = 5;
            this.btnEdit.ImageSize = new System.Drawing.Size(16, 16);
            this.btnEdit.IsRadial = false;
            this.btnEdit.IsReadOnly = false;
            this.btnEdit.IsToggleButton = false;
            this.btnEdit.IsToggled = false;
            this.btnEdit.Location = new System.Drawing.Point(1393, 278);
            this.btnEdit.LongPressDurationMS = 1000;
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.NormalFontStyle = System.Drawing.FontStyle.Regular;
            this.btnEdit.ParticleColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.btnEdit.ParticleCount = 15;
            this.btnEdit.PressAnimationScale = 0.97F;
            this.btnEdit.PressedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(227)))), ((int)(((byte)(230)))));
            this.btnEdit.PressedFontStyle = System.Drawing.FontStyle.Regular;
            this.btnEdit.PressTransitionDuration = 150;
            this.btnEdit.ReadOnlyTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.btnEdit.RippleColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnEdit.RippleRadiusMultiplier = 0.6F;
            this.btnEdit.ShadowBlur = 5;
            this.btnEdit.ShadowColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnEdit.ShadowOffset = new System.Drawing.Point(0, 2);
            this.btnEdit.ShakeDuration = 500;
            this.btnEdit.ShakeIntensity = 5;
            this.btnEdit.Size = new System.Drawing.Size(275, 52);
            this.btnEdit.TabIndex = 43;
            this.btnEdit.Text = "Edit";
            this.btnEdit.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnEdit.TextColor = System.Drawing.Color.WhiteSmoke;
            this.btnEdit.TooltipText = null;
            this.btnEdit.UseAdvancedRendering = true;
            this.btnEdit.UseParticles = false;
            this.btnEdit.Click += new System.EventHandler(this.btnEditCustomer_Click);
            // 
            // siticoneGroupBox1
            // 
            this.siticoneGroupBox1.BackColor = System.Drawing.Color.Transparent;
            this.siticoneGroupBox1.BadgeColor = System.Drawing.Color.Red;
            this.siticoneGroupBox1.BadgeFont = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold);
            this.siticoneGroupBox1.BadgeLeftPadding = 12;
            this.siticoneGroupBox1.BadgeValue = 0;
            this.siticoneGroupBox1.BadgeVisible = false;
            this.siticoneGroupBox1.BlinkInterval = 500;
            this.siticoneGroupBox1.BlinkMinOpacity = 0.3F;
            this.siticoneGroupBox1.BlinkOpacityStep = 0.05F;
            this.siticoneGroupBox1.BorderColor = System.Drawing.Color.Maroon;
            this.siticoneGroupBox1.BorderWidth = 2F;
            this.siticoneGroupBox1.ChevronColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(90)))), ((int)(((byte)(90)))));
            this.siticoneGroupBox1.ChevronLeftSpacing = 4F;
            this.siticoneGroupBox1.ChevronSize = 10F;
            this.siticoneGroupBox1.ChevronThickness = 2F;
            this.siticoneGroupBox1.ContentPadding = 5;
            this.siticoneGroupBox1.Controls.Add(this.txtSearch);
            this.siticoneGroupBox1.Controls.Add(this.dgvCustomers);
            this.siticoneGroupBox1.Controls.Add(this.btnDetails);
            this.siticoneGroupBox1.Controls.Add(this.btnClose);
            this.siticoneGroupBox1.Controls.Add(this.cmbFilter);
            this.siticoneGroupBox1.Controls.Add(this.btnAddCustomer);
            this.siticoneGroupBox1.Controls.Add(this.guna2HtmlLabel1);
            this.siticoneGroupBox1.Controls.Add(this.btnChoose);
            this.siticoneGroupBox1.Controls.Add(this.btnEdit);
            this.siticoneGroupBox1.CornerRadius = 8;
            this.siticoneGroupBox1.EnableBlinking = false;
            this.siticoneGroupBox1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.siticoneGroupBox1.GradientEndColor = System.Drawing.Color.LightGray;
            this.siticoneGroupBox1.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.siticoneGroupBox1.GradientStartColor = System.Drawing.Color.White;
            this.siticoneGroupBox1.GroupTitle = "";
            this.siticoneGroupBox1.HoveredBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(215)))));
            this.siticoneGroupBox1.HoveredTitleColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(215)))));
            this.siticoneGroupBox1.IsCollapsible = false;
            this.siticoneGroupBox1.Location = new System.Drawing.Point(155, 141);
            this.siticoneGroupBox1.MaxBlinkCount = 3;
            this.siticoneGroupBox1.Name = "siticoneGroupBox1";
            this.siticoneGroupBox1.PressedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(84)))), ((int)(((byte)(153)))));
            this.siticoneGroupBox1.ShadowColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.siticoneGroupBox1.ShadowDepth = 4;
            this.siticoneGroupBox1.ShowShadow = true;
            this.siticoneGroupBox1.Size = new System.Drawing.Size(1712, 810);
            this.siticoneGroupBox1.SolidFillColor = System.Drawing.Color.AntiqueWhite;
            this.siticoneGroupBox1.StatusIcon = null;
            this.siticoneGroupBox1.StatusText = "";
            this.siticoneGroupBox1.TabIndex = 50;
            this.siticoneGroupBox1.Text = "siticoneGroupBox1";
            this.siticoneGroupBox1.TitleBackColor = System.Drawing.Color.Transparent;
            this.siticoneGroupBox1.TitleColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.siticoneGroupBox1.TitlePadding = new System.Windows.Forms.Padding(10, 8, 10, 12);
            this.siticoneGroupBox1.TitlePos = SiticoneNetFrameworkUI.TitlePosition.TopLeft;
            this.siticoneGroupBox1.UseGradient = false;
            // 
            // txtSearch
            // 
            this.txtSearch.BorderRadius = 10;
            this.txtSearch.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtSearch.DefaultText = "";
            this.txtSearch.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtSearch.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtSearch.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtSearch.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtSearch.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtSearch.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtSearch.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtSearch.Location = new System.Drawing.Point(298, 136);
            this.txtSearch.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.PlaceholderText = "";
            this.txtSearch.SelectedText = "";
            this.txtSearch.Size = new System.Drawing.Size(326, 46);
            this.txtSearch.TabIndex = 52;
            this.txtSearch.Visible = false;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged_1);
            this.txtSearch.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSearch_KeyPress);
            // 
            // dgvCustomers
            // 
            this.dgvCustomers.AllowUserToAddRows = false;
            this.dgvCustomers.AllowUserToDeleteRows = false;
            this.dgvCustomers.AllowUserToResizeColumns = false;
            this.dgvCustomers.AllowUserToResizeRows = false;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            this.dgvCustomers.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.Maroon;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.Wheat;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.Maroon;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvCustomers.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvCustomers.ColumnHeadersHeight = 40;
            this.dgvCustomers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgvCustomers.ContextMenuStrip = this.cmsCustomers;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvCustomers.DefaultCellStyle = dataGridViewCellStyle6;
            this.dgvCustomers.GridColor = System.Drawing.Color.Silver;
            this.dgvCustomers.Location = new System.Drawing.Point(38, 192);
            this.dgvCustomers.MultiSelect = false;
            this.dgvCustomers.Name = "dgvCustomers";
            this.dgvCustomers.ReadOnly = true;
            this.dgvCustomers.RowHeadersVisible = false;
            this.dgvCustomers.RowHeadersWidth = 51;
            this.dgvCustomers.RowTemplate.DividerHeight = 1;
            this.dgvCustomers.RowTemplate.Height = 30;
            this.dgvCustomers.Size = new System.Drawing.Size(1316, 556);
            this.dgvCustomers.TabIndex = 43;
            this.dgvCustomers.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvCustomers.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgvCustomers.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgvCustomers.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgvCustomers.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgvCustomers.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dgvCustomers.ThemeStyle.GridColor = System.Drawing.Color.Silver;
            this.dgvCustomers.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dgvCustomers.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvCustomers.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvCustomers.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgvCustomers.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgvCustomers.ThemeStyle.HeaderStyle.Height = 40;
            this.dgvCustomers.ThemeStyle.ReadOnly = true;
            this.dgvCustomers.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvCustomers.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvCustomers.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvCustomers.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgvCustomers.ThemeStyle.RowsStyle.Height = 30;
            this.dgvCustomers.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvCustomers.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            // 
            // btnAddCustomer
            // 
            this.btnAddCustomer.AccessibleDescription = "The default button control that accept input though the mouse, touch and keyboard" +
    "";
            this.btnAddCustomer.AccessibleName = "Add New Customer";
            this.btnAddCustomer.AutoSizeBasedOnText = false;
            this.btnAddCustomer.BackColor = System.Drawing.Color.Transparent;
            this.btnAddCustomer.BadgeBackColor = System.Drawing.Color.Gainsboro;
            this.btnAddCustomer.BadgeFont = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddCustomer.BadgeValue = 0;
            this.btnAddCustomer.BadgeValueForeColor = System.Drawing.Color.Gainsboro;
            this.btnAddCustomer.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(216)))), ((int)(((byte)(220)))));
            this.btnAddCustomer.BorderWidth = 1;
            this.btnAddCustomer.ButtonBackColor = System.Drawing.Color.Maroon;
            this.btnAddCustomer.ButtonImage = null;
            this.btnAddCustomer.ButtonTextLeftPadding = 0;
            this.btnAddCustomer.CanBeep = true;
            this.btnAddCustomer.CanGlow = false;
            this.btnAddCustomer.CanShake = true;
            this.btnAddCustomer.ContextMenuStripEx = null;
            this.btnAddCustomer.CornerRadiusBottomLeft = 10;
            this.btnAddCustomer.CornerRadiusBottomRight = 10;
            this.btnAddCustomer.CornerRadiusTopLeft = 10;
            this.btnAddCustomer.CornerRadiusTopRight = 10;
            this.btnAddCustomer.CustomCursor = System.Windows.Forms.Cursors.Default;
            this.btnAddCustomer.DisabledTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(150)))), ((int)(((byte)(150)))));
            this.btnAddCustomer.EnableLongPress = false;
            this.btnAddCustomer.EnableRippleEffect = true;
            this.btnAddCustomer.EnableShadow = false;
            this.btnAddCustomer.EnableTextWrapping = false;
            this.btnAddCustomer.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F);
            this.btnAddCustomer.GlowColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnAddCustomer.GlowIntensity = 100;
            this.btnAddCustomer.GlowRadius = 20F;
            this.btnAddCustomer.GradientBackground = false;
            this.btnAddCustomer.GradientColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(227)))), ((int)(((byte)(64)))));
            this.btnAddCustomer.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.btnAddCustomer.HintText = null;
            this.btnAddCustomer.HoverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.btnAddCustomer.HoverFontStyle = System.Drawing.FontStyle.Regular;
            this.btnAddCustomer.HoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnAddCustomer.HoverTransitionDuration = 250;
            this.btnAddCustomer.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAddCustomer.ImagePadding = 5;
            this.btnAddCustomer.ImageSize = new System.Drawing.Size(16, 16);
            this.btnAddCustomer.IsRadial = false;
            this.btnAddCustomer.IsReadOnly = false;
            this.btnAddCustomer.IsToggleButton = false;
            this.btnAddCustomer.IsToggled = false;
            this.btnAddCustomer.Location = new System.Drawing.Point(1393, 462);
            this.btnAddCustomer.LongPressDurationMS = 1000;
            this.btnAddCustomer.Name = "btnAddCustomer";
            this.btnAddCustomer.NormalFontStyle = System.Drawing.FontStyle.Regular;
            this.btnAddCustomer.ParticleColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.btnAddCustomer.ParticleCount = 15;
            this.btnAddCustomer.PressAnimationScale = 0.97F;
            this.btnAddCustomer.PressedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(227)))), ((int)(((byte)(230)))));
            this.btnAddCustomer.PressedFontStyle = System.Drawing.FontStyle.Regular;
            this.btnAddCustomer.PressTransitionDuration = 150;
            this.btnAddCustomer.ReadOnlyTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.btnAddCustomer.RippleColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnAddCustomer.RippleRadiusMultiplier = 0.6F;
            this.btnAddCustomer.ShadowBlur = 5;
            this.btnAddCustomer.ShadowColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnAddCustomer.ShadowOffset = new System.Drawing.Point(0, 2);
            this.btnAddCustomer.ShakeDuration = 500;
            this.btnAddCustomer.ShakeIntensity = 5;
            this.btnAddCustomer.Size = new System.Drawing.Size(275, 52);
            this.btnAddCustomer.TabIndex = 48;
            this.btnAddCustomer.Text = "Add New Customer";
            this.btnAddCustomer.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnAddCustomer.TextColor = System.Drawing.Color.WhiteSmoke;
            this.btnAddCustomer.TooltipText = null;
            this.btnAddCustomer.UseAdvancedRendering = true;
            this.btnAddCustomer.UseParticles = false;
            this.btnAddCustomer.Click += new System.EventHandler(this.btnAddCustomer_Click);
            // 
            // guna2HtmlLabel1
            // 
            this.guna2HtmlLabel1.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel1.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel1.ForeColor = System.Drawing.Color.Maroon;
            this.guna2HtmlLabel1.Location = new System.Drawing.Point(38, 103);
            this.guna2HtmlLabel1.Name = "guna2HtmlLabel1";
            this.guna2HtmlLabel1.Padding = new System.Windows.Forms.Padding(0, 0, 200, 0);
            this.guna2HtmlLabel1.Size = new System.Drawing.Size(275, 27);
            this.guna2HtmlLabel1.TabIndex = 51;
            this.guna2HtmlLabel1.Text = "Filter by:";
            // 
            // guna2HtmlLabel2
            // 
            this.guna2HtmlLabel2.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel2.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel2.ForeColor = System.Drawing.Color.Maroon;
            this.guna2HtmlLabel2.Location = new System.Drawing.Point(24, 100);
            this.guna2HtmlLabel2.Name = "guna2HtmlLabel2";
            this.guna2HtmlLabel2.Padding = new System.Windows.Forms.Padding(0, 0, 35, 0);
            this.guna2HtmlLabel2.Size = new System.Drawing.Size(113, 27);
            this.guna2HtmlLabel2.TabIndex = 15;
            this.guna2HtmlLabel2.Text = "Filter By:";
            // 
            // frmCustomersList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AntiqueWhite;
            this.ClientSize = new System.Drawing.Size(1919, 1055);
            this.ContextMenuStrip = this.cmsCustomers;
            this.Controls.Add(this.siticoneGroupBox1);
            this.Controls.Add(this.lblTitle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmCustomersList";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmCustomersList";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmCustomersList_Load);
            this.cmsCustomers.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.siticoneGroupBox1.ResumeLayout(false);
            this.siticoneGroupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCustomers)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Guna.UI2.WinForms.Guna2ComboBox cmbFilter;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblTitle;
        private Guna.UI2.WinForms.Guna2ContextMenuStrip cmsCustomers;
        private System.Windows.Forms.ToolStripMenuItem chooseToolStripMenuItem;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private SiticoneNetFrameworkUI.SiticoneButton btnClose;
        private SiticoneNetFrameworkUI.SiticoneButton btnDetails;
        private SiticoneNetFrameworkUI.SiticoneButton btnChoose;
        private SiticoneNetFrameworkUI.SiticoneButton btnEdit;
        private SiticoneNetFrameworkUI.SiticoneGroupBox siticoneGroupBox1;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel2;
        private Guna.UI2.WinForms.Guna2DataGridView dgvCustomers;
        private SiticoneNetFrameworkUI.SiticoneButton btnAddCustomer;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel1;
        private Guna.UI2.WinForms.Guna2TextBox txtSearch;
        private System.Windows.Forms.ToolStripMenuItem detailsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addNewCustomerToolStripMenuItem;
    }
}