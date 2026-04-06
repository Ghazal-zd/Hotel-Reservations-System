namespace Hotel_Reservations_System
{
    partial class frmUsersList
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.cmsUsers = new Guna.UI2.WinForms.Guna2ContextMenuStrip();
            this.ediToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.detailsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deavtivateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addNewUserToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dgvUsers = new Guna.UI2.WinForms.Guna2DataGridView();
            this.siticoneGroupBox1 = new SiticoneNetFrameworkUI.SiticoneGroupBox();
            this.cmbRoles = new Guna.UI2.WinForms.Guna2ComboBox();
            this.cmbIsActive = new Guna.UI2.WinForms.Guna2ComboBox();
            this.siticoneButton2 = new SiticoneNetFrameworkUI.SiticoneButton();
            this.btnDelete = new SiticoneNetFrameworkUI.SiticoneButton();
            this.txtSearch = new Guna.UI2.WinForms.Guna2TextBox();
            this.btnDetails = new SiticoneNetFrameworkUI.SiticoneButton();
            this.btnEditRoom = new SiticoneNetFrameworkUI.SiticoneButton();
            this.cmbFilter = new Guna.UI2.WinForms.Guna2ComboBox();
            this.btnAddRoom = new SiticoneNetFrameworkUI.SiticoneButton();
            this.guna2HtmlLabel1 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.siticoneLabel1 = new SiticoneNetFrameworkUI.SiticoneLabel();
            this.cmsUsers.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsers)).BeginInit();
            this.siticoneGroupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // cmsUsers
            // 
            this.cmsUsers.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.cmsUsers.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ediToolStripMenuItem,
            this.detailsToolStripMenuItem,
            this.deavtivateToolStripMenuItem,
            this.addNewUserToolStripMenuItem});
            this.cmsUsers.Name = "guna2ContextMenuStrip1";
            this.cmsUsers.RenderStyle.ArrowColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.cmsUsers.RenderStyle.BorderColor = System.Drawing.Color.Gainsboro;
            this.cmsUsers.RenderStyle.ColorTable = null;
            this.cmsUsers.RenderStyle.RoundedEdges = true;
            this.cmsUsers.RenderStyle.SelectionArrowColor = System.Drawing.Color.White;
            this.cmsUsers.RenderStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.cmsUsers.RenderStyle.SelectionForeColor = System.Drawing.Color.White;
            this.cmsUsers.RenderStyle.SeparatorColor = System.Drawing.Color.Gainsboro;
            this.cmsUsers.RenderStyle.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault;
            this.cmsUsers.Size = new System.Drawing.Size(174, 100);
            // 
            // ediToolStripMenuItem
            // 
            this.ediToolStripMenuItem.Name = "ediToolStripMenuItem";
            this.ediToolStripMenuItem.Size = new System.Drawing.Size(173, 24);
            this.ediToolStripMenuItem.Text = "Edit";
            this.ediToolStripMenuItem.Click += new System.EventHandler(this.ediToolStripMenuItem_Click);
            // 
            // detailsToolStripMenuItem
            // 
            this.detailsToolStripMenuItem.Name = "detailsToolStripMenuItem";
            this.detailsToolStripMenuItem.Size = new System.Drawing.Size(173, 24);
            this.detailsToolStripMenuItem.Text = "Details";
            this.detailsToolStripMenuItem.Click += new System.EventHandler(this.detailsToolStripMenuItem_Click);
            // 
            // deavtivateToolStripMenuItem
            // 
            this.deavtivateToolStripMenuItem.Name = "deavtivateToolStripMenuItem";
            this.deavtivateToolStripMenuItem.Size = new System.Drawing.Size(173, 24);
            this.deavtivateToolStripMenuItem.Text = "Deactivate";
            this.deavtivateToolStripMenuItem.Click += new System.EventHandler(this.deactivateToolStripMenuItem_Click);
            // 
            // addNewUserToolStripMenuItem
            // 
            this.addNewUserToolStripMenuItem.Name = "addNewUserToolStripMenuItem";
            this.addNewUserToolStripMenuItem.Size = new System.Drawing.Size(173, 24);
            this.addNewUserToolStripMenuItem.Text = "Add New User";
            this.addNewUserToolStripMenuItem.Click += new System.EventHandler(this.addNewUserToolStripMenuItem_Click);
            // 
            // dgvUsers
            // 
            this.dgvUsers.AllowUserToAddRows = false;
            this.dgvUsers.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.dgvUsers.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Maroon;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Wheat;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Maroon;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvUsers.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvUsers.ColumnHeadersHeight = 40;
            this.dgvUsers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgvUsers.ContextMenuStrip = this.cmsUsers;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvUsers.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvUsers.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvUsers.Location = new System.Drawing.Point(48, 228);
            this.dgvUsers.Name = "dgvUsers";
            this.dgvUsers.ReadOnly = true;
            this.dgvUsers.RowHeadersVisible = false;
            this.dgvUsers.RowHeadersWidth = 51;
            this.dgvUsers.RowTemplate.Height = 24;
            this.dgvUsers.Size = new System.Drawing.Size(1344, 514);
            this.dgvUsers.TabIndex = 19;
            this.dgvUsers.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvUsers.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgvUsers.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgvUsers.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgvUsers.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgvUsers.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dgvUsers.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvUsers.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dgvUsers.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvUsers.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvUsers.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgvUsers.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgvUsers.ThemeStyle.HeaderStyle.Height = 40;
            this.dgvUsers.ThemeStyle.ReadOnly = true;
            this.dgvUsers.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvUsers.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvUsers.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvUsers.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgvUsers.ThemeStyle.RowsStyle.Height = 24;
            this.dgvUsers.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvUsers.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
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
            this.siticoneGroupBox1.Controls.Add(this.cmbRoles);
            this.siticoneGroupBox1.Controls.Add(this.cmbIsActive);
            this.siticoneGroupBox1.Controls.Add(this.siticoneButton2);
            this.siticoneGroupBox1.Controls.Add(this.dgvUsers);
            this.siticoneGroupBox1.Controls.Add(this.btnDelete);
            this.siticoneGroupBox1.Controls.Add(this.txtSearch);
            this.siticoneGroupBox1.Controls.Add(this.btnDetails);
            this.siticoneGroupBox1.Controls.Add(this.btnEditRoom);
            this.siticoneGroupBox1.Controls.Add(this.cmbFilter);
            this.siticoneGroupBox1.Controls.Add(this.btnAddRoom);
            this.siticoneGroupBox1.Controls.Add(this.guna2HtmlLabel1);
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
            this.siticoneGroupBox1.Location = new System.Drawing.Point(127, 141);
            this.siticoneGroupBox1.MaxBlinkCount = 3;
            this.siticoneGroupBox1.Name = "siticoneGroupBox1";
            this.siticoneGroupBox1.PressedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(84)))), ((int)(((byte)(153)))));
            this.siticoneGroupBox1.ShadowColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.siticoneGroupBox1.ShadowDepth = 4;
            this.siticoneGroupBox1.ShowShadow = true;
            this.siticoneGroupBox1.Size = new System.Drawing.Size(1751, 839);
            this.siticoneGroupBox1.SolidFillColor = System.Drawing.Color.AntiqueWhite;
            this.siticoneGroupBox1.StatusIcon = null;
            this.siticoneGroupBox1.StatusText = "";
            this.siticoneGroupBox1.TabIndex = 43;
            this.siticoneGroupBox1.Text = "siticoneGroupBox1";
            this.siticoneGroupBox1.TitleBackColor = System.Drawing.Color.Transparent;
            this.siticoneGroupBox1.TitleColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.siticoneGroupBox1.TitlePadding = new System.Windows.Forms.Padding(10, 8, 10, 12);
            this.siticoneGroupBox1.TitlePos = SiticoneNetFrameworkUI.TitlePosition.TopLeft;
            this.siticoneGroupBox1.UseGradient = false;
            // 
            // cmbRoles
            // 
            this.cmbRoles.BackColor = System.Drawing.Color.Transparent;
            this.cmbRoles.BorderRadius = 10;
            this.cmbRoles.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbRoles.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbRoles.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmbRoles.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmbRoles.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cmbRoles.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cmbRoles.ItemHeight = 30;
            this.cmbRoles.Items.AddRange(new object[] {
            "All",
            "Admin",
            "Manager",
            "Reception"});
            this.cmbRoles.Location = new System.Drawing.Point(370, 150);
            this.cmbRoles.Name = "cmbRoles";
            this.cmbRoles.Size = new System.Drawing.Size(218, 36);
            this.cmbRoles.TabIndex = 45;
            this.cmbRoles.SelectedIndexChanged += new System.EventHandler(this.cmbRoles_SelectedIndexChanged);
            // 
            // cmbIsActive
            // 
            this.cmbIsActive.BackColor = System.Drawing.Color.Transparent;
            this.cmbIsActive.BorderRadius = 10;
            this.cmbIsActive.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbIsActive.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbIsActive.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmbIsActive.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmbIsActive.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cmbIsActive.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cmbIsActive.ItemHeight = 30;
            this.cmbIsActive.Items.AddRange(new object[] {
            "All",
            "Yes",
            "No"});
            this.cmbIsActive.Location = new System.Drawing.Point(370, 150);
            this.cmbIsActive.Name = "cmbIsActive";
            this.cmbIsActive.Size = new System.Drawing.Size(218, 36);
            this.cmbIsActive.TabIndex = 44;
            this.cmbIsActive.SelectedIndexChanged += new System.EventHandler(this.cmbIsActive_SelectedIndexChanged);
            // 
            // siticoneButton2
            // 
            this.siticoneButton2.AccessibleDescription = "The default button control that accept input though the mouse, touch and keyboard" +
    "";
            this.siticoneButton2.AccessibleName = "Close";
            this.siticoneButton2.AutoSizeBasedOnText = false;
            this.siticoneButton2.BackColor = System.Drawing.Color.Transparent;
            this.siticoneButton2.BadgeBackColor = System.Drawing.Color.Gainsboro;
            this.siticoneButton2.BadgeFont = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.siticoneButton2.BadgeValue = 0;
            this.siticoneButton2.BadgeValueForeColor = System.Drawing.Color.Gainsboro;
            this.siticoneButton2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(216)))), ((int)(((byte)(220)))));
            this.siticoneButton2.BorderWidth = 1;
            this.siticoneButton2.ButtonBackColor = System.Drawing.Color.Maroon;
            this.siticoneButton2.ButtonImage = null;
            this.siticoneButton2.ButtonTextLeftPadding = 0;
            this.siticoneButton2.CanBeep = true;
            this.siticoneButton2.CanGlow = false;
            this.siticoneButton2.CanShake = true;
            this.siticoneButton2.ContextMenuStripEx = null;
            this.siticoneButton2.CornerRadiusBottomLeft = 10;
            this.siticoneButton2.CornerRadiusBottomRight = 10;
            this.siticoneButton2.CornerRadiusTopLeft = 10;
            this.siticoneButton2.CornerRadiusTopRight = 10;
            this.siticoneButton2.CustomCursor = System.Windows.Forms.Cursors.Default;
            this.siticoneButton2.DisabledTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(150)))), ((int)(((byte)(150)))));
            this.siticoneButton2.EnableLongPress = false;
            this.siticoneButton2.EnableRippleEffect = true;
            this.siticoneButton2.EnableShadow = false;
            this.siticoneButton2.EnableTextWrapping = false;
            this.siticoneButton2.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F);
            this.siticoneButton2.GlowColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.siticoneButton2.GlowIntensity = 100;
            this.siticoneButton2.GlowRadius = 20F;
            this.siticoneButton2.GradientBackground = false;
            this.siticoneButton2.GradientColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(227)))), ((int)(((byte)(64)))));
            this.siticoneButton2.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.siticoneButton2.HintText = null;
            this.siticoneButton2.HoverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.siticoneButton2.HoverFontStyle = System.Drawing.FontStyle.Regular;
            this.siticoneButton2.HoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.siticoneButton2.HoverTransitionDuration = 250;
            this.siticoneButton2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.siticoneButton2.ImagePadding = 5;
            this.siticoneButton2.ImageSize = new System.Drawing.Size(16, 16);
            this.siticoneButton2.IsRadial = false;
            this.siticoneButton2.IsReadOnly = false;
            this.siticoneButton2.IsToggleButton = false;
            this.siticoneButton2.IsToggled = false;
            this.siticoneButton2.Location = new System.Drawing.Point(1447, 602);
            this.siticoneButton2.LongPressDurationMS = 1000;
            this.siticoneButton2.Name = "siticoneButton2";
            this.siticoneButton2.NormalFontStyle = System.Drawing.FontStyle.Regular;
            this.siticoneButton2.ParticleColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.siticoneButton2.ParticleCount = 15;
            this.siticoneButton2.PressAnimationScale = 0.97F;
            this.siticoneButton2.PressedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(227)))), ((int)(((byte)(230)))));
            this.siticoneButton2.PressedFontStyle = System.Drawing.FontStyle.Regular;
            this.siticoneButton2.PressTransitionDuration = 150;
            this.siticoneButton2.ReadOnlyTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.siticoneButton2.RippleColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.siticoneButton2.RippleRadiusMultiplier = 0.6F;
            this.siticoneButton2.ShadowBlur = 5;
            this.siticoneButton2.ShadowColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.siticoneButton2.ShadowOffset = new System.Drawing.Point(0, 2);
            this.siticoneButton2.ShakeDuration = 500;
            this.siticoneButton2.ShakeIntensity = 5;
            this.siticoneButton2.Size = new System.Drawing.Size(275, 52);
            this.siticoneButton2.TabIndex = 49;
            this.siticoneButton2.Text = "Close";
            this.siticoneButton2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.siticoneButton2.TextColor = System.Drawing.Color.WhiteSmoke;
            this.siticoneButton2.TooltipText = null;
            this.siticoneButton2.UseAdvancedRendering = true;
            this.siticoneButton2.UseParticles = false;
            this.siticoneButton2.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.AccessibleDescription = "The default button control that accept input though the mouse, touch and keyboard" +
    "";
            this.btnDelete.AccessibleName = "Deactivate";
            this.btnDelete.AutoSizeBasedOnText = false;
            this.btnDelete.BackColor = System.Drawing.Color.Transparent;
            this.btnDelete.BadgeBackColor = System.Drawing.Color.Gainsboro;
            this.btnDelete.BadgeFont = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.BadgeValue = 0;
            this.btnDelete.BadgeValueForeColor = System.Drawing.Color.Gainsboro;
            this.btnDelete.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(216)))), ((int)(((byte)(220)))));
            this.btnDelete.BorderWidth = 1;
            this.btnDelete.ButtonBackColor = System.Drawing.Color.Maroon;
            this.btnDelete.ButtonImage = null;
            this.btnDelete.ButtonTextLeftPadding = 0;
            this.btnDelete.CanBeep = true;
            this.btnDelete.CanGlow = false;
            this.btnDelete.CanShake = true;
            this.btnDelete.ContextMenuStripEx = null;
            this.btnDelete.CornerRadiusBottomLeft = 10;
            this.btnDelete.CornerRadiusBottomRight = 10;
            this.btnDelete.CornerRadiusTopLeft = 10;
            this.btnDelete.CornerRadiusTopRight = 10;
            this.btnDelete.CustomCursor = System.Windows.Forms.Cursors.Default;
            this.btnDelete.DisabledTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(150)))), ((int)(((byte)(150)))));
            this.btnDelete.EnableLongPress = false;
            this.btnDelete.EnableRippleEffect = true;
            this.btnDelete.EnableShadow = false;
            this.btnDelete.EnableTextWrapping = false;
            this.btnDelete.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F);
            this.btnDelete.GlowColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnDelete.GlowIntensity = 100;
            this.btnDelete.GlowRadius = 20F;
            this.btnDelete.GradientBackground = false;
            this.btnDelete.GradientColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(227)))), ((int)(((byte)(64)))));
            this.btnDelete.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.btnDelete.HintText = null;
            this.btnDelete.HoverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.btnDelete.HoverFontStyle = System.Drawing.FontStyle.Regular;
            this.btnDelete.HoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnDelete.HoverTransitionDuration = 250;
            this.btnDelete.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDelete.ImagePadding = 5;
            this.btnDelete.ImageSize = new System.Drawing.Size(16, 16);
            this.btnDelete.IsRadial = false;
            this.btnDelete.IsReadOnly = false;
            this.btnDelete.IsToggleButton = false;
            this.btnDelete.IsToggled = false;
            this.btnDelete.Location = new System.Drawing.Point(1447, 412);
            this.btnDelete.LongPressDurationMS = 1000;
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.NormalFontStyle = System.Drawing.FontStyle.Regular;
            this.btnDelete.ParticleColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.btnDelete.ParticleCount = 15;
            this.btnDelete.PressAnimationScale = 0.97F;
            this.btnDelete.PressedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(227)))), ((int)(((byte)(230)))));
            this.btnDelete.PressedFontStyle = System.Drawing.FontStyle.Regular;
            this.btnDelete.PressTransitionDuration = 150;
            this.btnDelete.ReadOnlyTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.btnDelete.RippleColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnDelete.RippleRadiusMultiplier = 0.6F;
            this.btnDelete.ShadowBlur = 5;
            this.btnDelete.ShadowColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnDelete.ShadowOffset = new System.Drawing.Point(0, 2);
            this.btnDelete.ShakeDuration = 500;
            this.btnDelete.ShakeIntensity = 5;
            this.btnDelete.Size = new System.Drawing.Size(275, 52);
            this.btnDelete.TabIndex = 48;
            this.btnDelete.Text = "Deactivate";
            this.btnDelete.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnDelete.TextColor = System.Drawing.Color.WhiteSmoke;
            this.btnDelete.TooltipText = null;
            this.btnDelete.UseAdvancedRendering = true;
            this.btnDelete.UseParticles = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDeactivate_Click);
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
            this.txtSearch.Location = new System.Drawing.Point(370, 150);
            this.txtSearch.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.PlaceholderText = "";
            this.txtSearch.SelectedText = "";
            this.txtSearch.Size = new System.Drawing.Size(265, 36);
            this.txtSearch.TabIndex = 5;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            this.txtSearch.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSearch_KeyPress);
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
            this.btnDetails.Location = new System.Drawing.Point(1447, 228);
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
            this.btnDetails.TabIndex = 46;
            this.btnDetails.Text = "Details";
            this.btnDetails.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnDetails.TextColor = System.Drawing.Color.WhiteSmoke;
            this.btnDetails.TooltipText = null;
            this.btnDetails.UseAdvancedRendering = true;
            this.btnDetails.UseParticles = false;
            this.btnDetails.Click += new System.EventHandler(this.btnDetails_Click);
            // 
            // btnEditRoom
            // 
            this.btnEditRoom.AccessibleDescription = "The default button control that accept input though the mouse, touch and keyboard" +
    "";
            this.btnEditRoom.AccessibleName = "Edit";
            this.btnEditRoom.AutoSizeBasedOnText = false;
            this.btnEditRoom.BackColor = System.Drawing.Color.Transparent;
            this.btnEditRoom.BadgeBackColor = System.Drawing.Color.Gainsboro;
            this.btnEditRoom.BadgeFont = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditRoom.BadgeValue = 0;
            this.btnEditRoom.BadgeValueForeColor = System.Drawing.Color.Gainsboro;
            this.btnEditRoom.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(216)))), ((int)(((byte)(220)))));
            this.btnEditRoom.BorderWidth = 1;
            this.btnEditRoom.ButtonBackColor = System.Drawing.Color.Maroon;
            this.btnEditRoom.ButtonImage = null;
            this.btnEditRoom.ButtonTextLeftPadding = 0;
            this.btnEditRoom.CanBeep = true;
            this.btnEditRoom.CanGlow = false;
            this.btnEditRoom.CanShake = true;
            this.btnEditRoom.ContextMenuStripEx = null;
            this.btnEditRoom.CornerRadiusBottomLeft = 10;
            this.btnEditRoom.CornerRadiusBottomRight = 10;
            this.btnEditRoom.CornerRadiusTopLeft = 10;
            this.btnEditRoom.CornerRadiusTopRight = 10;
            this.btnEditRoom.CustomCursor = System.Windows.Forms.Cursors.Default;
            this.btnEditRoom.DisabledTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(150)))), ((int)(((byte)(150)))));
            this.btnEditRoom.EnableLongPress = false;
            this.btnEditRoom.EnableRippleEffect = true;
            this.btnEditRoom.EnableShadow = false;
            this.btnEditRoom.EnableTextWrapping = false;
            this.btnEditRoom.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F);
            this.btnEditRoom.GlowColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnEditRoom.GlowIntensity = 100;
            this.btnEditRoom.GlowRadius = 20F;
            this.btnEditRoom.GradientBackground = false;
            this.btnEditRoom.GradientColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(227)))), ((int)(((byte)(64)))));
            this.btnEditRoom.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.btnEditRoom.HintText = null;
            this.btnEditRoom.HoverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.btnEditRoom.HoverFontStyle = System.Drawing.FontStyle.Regular;
            this.btnEditRoom.HoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnEditRoom.HoverTransitionDuration = 250;
            this.btnEditRoom.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEditRoom.ImagePadding = 5;
            this.btnEditRoom.ImageSize = new System.Drawing.Size(16, 16);
            this.btnEditRoom.IsRadial = false;
            this.btnEditRoom.IsReadOnly = false;
            this.btnEditRoom.IsToggleButton = false;
            this.btnEditRoom.IsToggled = false;
            this.btnEditRoom.Location = new System.Drawing.Point(1447, 318);
            this.btnEditRoom.LongPressDurationMS = 1000;
            this.btnEditRoom.Name = "btnEditRoom";
            this.btnEditRoom.NormalFontStyle = System.Drawing.FontStyle.Regular;
            this.btnEditRoom.ParticleColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.btnEditRoom.ParticleCount = 15;
            this.btnEditRoom.PressAnimationScale = 0.97F;
            this.btnEditRoom.PressedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(227)))), ((int)(((byte)(230)))));
            this.btnEditRoom.PressedFontStyle = System.Drawing.FontStyle.Regular;
            this.btnEditRoom.PressTransitionDuration = 150;
            this.btnEditRoom.ReadOnlyTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.btnEditRoom.RippleColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnEditRoom.RippleRadiusMultiplier = 0.6F;
            this.btnEditRoom.ShadowBlur = 5;
            this.btnEditRoom.ShadowColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnEditRoom.ShadowOffset = new System.Drawing.Point(0, 2);
            this.btnEditRoom.ShakeDuration = 500;
            this.btnEditRoom.ShakeIntensity = 5;
            this.btnEditRoom.Size = new System.Drawing.Size(275, 52);
            this.btnEditRoom.TabIndex = 44;
            this.btnEditRoom.Text = "Edit";
            this.btnEditRoom.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnEditRoom.TextColor = System.Drawing.Color.WhiteSmoke;
            this.btnEditRoom.TooltipText = null;
            this.btnEditRoom.UseAdvancedRendering = true;
            this.btnEditRoom.UseParticles = false;
            this.btnEditRoom.Click += new System.EventHandler(this.btnEditUser_Click);
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
            "User ID",
            "Full Name",
            "Email",
            "Username",
            "Role",
            "Is Active"});
            this.cmbFilter.Location = new System.Drawing.Point(48, 150);
            this.cmbFilter.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cmbFilter.Name = "cmbFilter";
            this.cmbFilter.Size = new System.Drawing.Size(280, 36);
            this.cmbFilter.TabIndex = 13;
            this.cmbFilter.SelectedIndexChanged += new System.EventHandler(this.cmbFilter_SelectedIndexChanged);
            // 
            // btnAddRoom
            // 
            this.btnAddRoom.AccessibleDescription = "The default button control that accept input though the mouse, touch and keyboard" +
    "";
            this.btnAddRoom.AccessibleName = "Add new User";
            this.btnAddRoom.AutoSizeBasedOnText = false;
            this.btnAddRoom.BackColor = System.Drawing.Color.Transparent;
            this.btnAddRoom.BadgeBackColor = System.Drawing.Color.Gainsboro;
            this.btnAddRoom.BadgeFont = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddRoom.BadgeValue = 0;
            this.btnAddRoom.BadgeValueForeColor = System.Drawing.Color.Gainsboro;
            this.btnAddRoom.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(216)))), ((int)(((byte)(220)))));
            this.btnAddRoom.BorderWidth = 1;
            this.btnAddRoom.ButtonBackColor = System.Drawing.Color.Maroon;
            this.btnAddRoom.ButtonImage = null;
            this.btnAddRoom.ButtonTextLeftPadding = 0;
            this.btnAddRoom.CanBeep = true;
            this.btnAddRoom.CanGlow = false;
            this.btnAddRoom.CanShake = true;
            this.btnAddRoom.ContextMenuStripEx = null;
            this.btnAddRoom.CornerRadiusBottomLeft = 10;
            this.btnAddRoom.CornerRadiusBottomRight = 10;
            this.btnAddRoom.CornerRadiusTopLeft = 10;
            this.btnAddRoom.CornerRadiusTopRight = 10;
            this.btnAddRoom.CustomCursor = System.Windows.Forms.Cursors.Default;
            this.btnAddRoom.DisabledTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(150)))), ((int)(((byte)(150)))));
            this.btnAddRoom.EnableLongPress = false;
            this.btnAddRoom.EnableRippleEffect = true;
            this.btnAddRoom.EnableShadow = false;
            this.btnAddRoom.EnableTextWrapping = false;
            this.btnAddRoom.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F);
            this.btnAddRoom.GlowColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnAddRoom.GlowIntensity = 100;
            this.btnAddRoom.GlowRadius = 20F;
            this.btnAddRoom.GradientBackground = false;
            this.btnAddRoom.GradientColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(227)))), ((int)(((byte)(64)))));
            this.btnAddRoom.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.btnAddRoom.HintText = null;
            this.btnAddRoom.HoverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.btnAddRoom.HoverFontStyle = System.Drawing.FontStyle.Regular;
            this.btnAddRoom.HoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnAddRoom.HoverTransitionDuration = 250;
            this.btnAddRoom.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAddRoom.ImagePadding = 5;
            this.btnAddRoom.ImageSize = new System.Drawing.Size(16, 16);
            this.btnAddRoom.IsRadial = false;
            this.btnAddRoom.IsReadOnly = false;
            this.btnAddRoom.IsToggleButton = false;
            this.btnAddRoom.IsToggled = false;
            this.btnAddRoom.Location = new System.Drawing.Point(1447, 512);
            this.btnAddRoom.LongPressDurationMS = 1000;
            this.btnAddRoom.Name = "btnAddRoom";
            this.btnAddRoom.NormalFontStyle = System.Drawing.FontStyle.Regular;
            this.btnAddRoom.ParticleColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.btnAddRoom.ParticleCount = 15;
            this.btnAddRoom.PressAnimationScale = 0.97F;
            this.btnAddRoom.PressedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(227)))), ((int)(((byte)(230)))));
            this.btnAddRoom.PressedFontStyle = System.Drawing.FontStyle.Regular;
            this.btnAddRoom.PressTransitionDuration = 150;
            this.btnAddRoom.ReadOnlyTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.btnAddRoom.RippleColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnAddRoom.RippleRadiusMultiplier = 0.6F;
            this.btnAddRoom.ShadowBlur = 5;
            this.btnAddRoom.ShadowColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnAddRoom.ShadowOffset = new System.Drawing.Point(0, 2);
            this.btnAddRoom.ShakeDuration = 500;
            this.btnAddRoom.ShakeIntensity = 5;
            this.btnAddRoom.Size = new System.Drawing.Size(275, 52);
            this.btnAddRoom.TabIndex = 45;
            this.btnAddRoom.Text = "Add new User";
            this.btnAddRoom.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnAddRoom.TextColor = System.Drawing.Color.WhiteSmoke;
            this.btnAddRoom.TooltipText = null;
            this.btnAddRoom.UseAdvancedRendering = true;
            this.btnAddRoom.UseParticles = false;
            this.btnAddRoom.Click += new System.EventHandler(this.btnAddUser_Click);
            // 
            // guna2HtmlLabel1
            // 
            this.guna2HtmlLabel1.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel1.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel1.ForeColor = System.Drawing.Color.Maroon;
            this.guna2HtmlLabel1.Location = new System.Drawing.Point(48, 99);
            this.guna2HtmlLabel1.Name = "guna2HtmlLabel1";
            this.guna2HtmlLabel1.Padding = new System.Windows.Forms.Padding(0, 0, 35, 0);
            this.guna2HtmlLabel1.Size = new System.Drawing.Size(113, 27);
            this.guna2HtmlLabel1.TabIndex = 15;
            this.guna2HtmlLabel1.Text = "Filter By:";
            // 
            // siticoneLabel1
            // 
            this.siticoneLabel1.BackColor = System.Drawing.Color.Transparent;
            this.siticoneLabel1.Font = new System.Drawing.Font("Segoe UI Black", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.siticoneLabel1.ForeColor = System.Drawing.Color.Maroon;
            this.siticoneLabel1.Location = new System.Drawing.Point(899, 39);
            this.siticoneLabel1.Name = "siticoneLabel1";
            this.siticoneLabel1.Size = new System.Drawing.Size(428, 45);
            this.siticoneLabel1.TabIndex = 50;
            this.siticoneLabel1.Text = "Users List";
            // 
            // frmUsersList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AntiqueWhite;
            this.ClientSize = new System.Drawing.Size(1918, 1055);
            this.Controls.Add(this.siticoneLabel1);
            this.Controls.Add(this.siticoneGroupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmUsersList";
            this.Text = "frmUsersList";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmUsersList_Load);
            this.cmsUsers.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsers)).EndInit();
            this.siticoneGroupBox1.ResumeLayout(false);
            this.siticoneGroupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private Guna.UI2.WinForms.Guna2ContextMenuStrip cmsUsers;
        private System.Windows.Forms.ToolStripMenuItem ediToolStripMenuItem;
        private Guna.UI2.WinForms.Guna2DataGridView dgvUsers;
        private SiticoneNetFrameworkUI.SiticoneGroupBox siticoneGroupBox1;
        private Guna.UI2.WinForms.Guna2ComboBox cmbRoles;
        private Guna.UI2.WinForms.Guna2ComboBox cmbIsActive;
        private Guna.UI2.WinForms.Guna2TextBox txtSearch;
        private Guna.UI2.WinForms.Guna2ComboBox cmbFilter;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel1;
        private SiticoneNetFrameworkUI.SiticoneButton siticoneButton2;
        private SiticoneNetFrameworkUI.SiticoneButton btnDelete;
        private SiticoneNetFrameworkUI.SiticoneButton btnDetails;
        private SiticoneNetFrameworkUI.SiticoneButton btnEditRoom;
        private SiticoneNetFrameworkUI.SiticoneButton btnAddRoom;
        private System.Windows.Forms.ToolStripMenuItem detailsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deavtivateToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addNewUserToolStripMenuItem;
        private SiticoneNetFrameworkUI.SiticoneLabel siticoneLabel1;
    }
}