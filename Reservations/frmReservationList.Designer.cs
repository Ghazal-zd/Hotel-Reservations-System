namespace Hotel_Reservations_System
{
    partial class frmReservationList
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.guna2HtmlLabel1 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.txtSearch = new Guna.UI2.WinForms.Guna2TextBox();
            this.cmbFilter = new Guna.UI2.WinForms.Guna2ComboBox();
            this.dgvReservations = new Guna.UI2.WinForms.Guna2DataGridView();
            this.cmsReservations = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.detailsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.returnRoomToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.checkInToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addNewReservationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.roomDetailsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnEditReservation = new SiticoneNetFrameworkUI.SiticoneButton();
            this.btnReturnRoom = new SiticoneNetFrameworkUI.SiticoneButton();
            this.btnDetails = new SiticoneNetFrameworkUI.SiticoneButton();
            this.btnCheckIn = new SiticoneNetFrameworkUI.SiticoneButton();
            this.cmbReservationStatus = new Guna.UI2.WinForms.Guna2ComboBox();
            this.btnCancel = new SiticoneNetFrameworkUI.SiticoneButton();
            this.siticoneGroupBox1 = new SiticoneNetFrameworkUI.SiticoneGroupBox();
            this.lblNoReservations = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.btnNext = new SiticoneNetFrameworkUI.SiticoneButton();
            this.btnPrevious = new SiticoneNetFrameworkUI.SiticoneButton();
            this.siticoneButton2 = new SiticoneNetFrameworkUI.SiticoneButton();
            this.cmbRoomType = new Guna.UI2.WinForms.Guna2ComboBox();
            this.siticoneButton1 = new SiticoneNetFrameworkUI.SiticoneButton();
            this.siticoneLabel1 = new SiticoneNetFrameworkUI.SiticoneLabel();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReservations)).BeginInit();
            this.cmsReservations.SuspendLayout();
            this.siticoneGroupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // guna2HtmlLabel1
            // 
            this.guna2HtmlLabel1.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel1.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel1.ForeColor = System.Drawing.Color.Maroon;
            this.guna2HtmlLabel1.Location = new System.Drawing.Point(24, 100);
            this.guna2HtmlLabel1.Name = "guna2HtmlLabel1";
            this.guna2HtmlLabel1.Padding = new System.Windows.Forms.Padding(0, 0, 35, 0);
            this.guna2HtmlLabel1.Size = new System.Drawing.Size(113, 27);
            this.guna2HtmlLabel1.TabIndex = 15;
            this.guna2HtmlLabel1.Text = "Filter By:";
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
            this.txtSearch.Location = new System.Drawing.Point(451, 244);
            this.txtSearch.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.PlaceholderText = "";
            this.txtSearch.SelectedText = "";
            this.txtSearch.Size = new System.Drawing.Size(326, 46);
            this.txtSearch.TabIndex = 14;
            this.txtSearch.Visible = false;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtCustomerSearch_TextChanged);
            this.txtSearch.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSearch_KeyPress);
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
            "Reservation ID",
            "Full Name",
            "Email",
            "Reserved Room ID",
            "Room Type",
            "Start Date",
            "Exit Date",
            "Reservation Status"});
            this.cmbFilter.Location = new System.Drawing.Point(24, 150);
            this.cmbFilter.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cmbFilter.Name = "cmbFilter";
            this.cmbFilter.Size = new System.Drawing.Size(280, 36);
            this.cmbFilter.TabIndex = 13;
            this.cmbFilter.SelectedIndexChanged += new System.EventHandler(this.cmbFilter_SelectedIndexChanged);
            // 
            // dgvReservations
            // 
            this.dgvReservations.AllowUserToAddRows = false;
            this.dgvReservations.AllowUserToDeleteRows = false;
            this.dgvReservations.AllowUserToResizeColumns = false;
            this.dgvReservations.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.dgvReservations.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Maroon;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Wheat;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Maroon;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvReservations.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvReservations.ColumnHeadersHeight = 40;
            this.dgvReservations.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgvReservations.ContextMenuStrip = this.cmsReservations;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvReservations.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvReservations.GridColor = System.Drawing.Color.Silver;
            this.dgvReservations.Location = new System.Drawing.Point(24, 213);
            this.dgvReservations.MultiSelect = false;
            this.dgvReservations.Name = "dgvReservations";
            this.dgvReservations.ReadOnly = true;
            this.dgvReservations.RowHeadersVisible = false;
            this.dgvReservations.RowHeadersWidth = 51;
            this.dgvReservations.RowTemplate.DividerHeight = 1;
            this.dgvReservations.RowTemplate.Height = 30;
            this.dgvReservations.Size = new System.Drawing.Size(1475, 539);
            this.dgvReservations.TabIndex = 11;
            this.dgvReservations.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvReservations.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgvReservations.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgvReservations.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgvReservations.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgvReservations.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dgvReservations.ThemeStyle.GridColor = System.Drawing.Color.Silver;
            this.dgvReservations.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dgvReservations.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvReservations.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvReservations.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgvReservations.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgvReservations.ThemeStyle.HeaderStyle.Height = 40;
            this.dgvReservations.ThemeStyle.ReadOnly = true;
            this.dgvReservations.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvReservations.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvReservations.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvReservations.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgvReservations.ThemeStyle.RowsStyle.Height = 30;
            this.dgvReservations.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvReservations.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgvReservations.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvReservations_CellClick);
            this.dgvReservations.CellMouseDown += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvReservations_CellMouseDown);
            // 
            // cmsReservations
            // 
            this.cmsReservations.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.cmsReservations.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.detailsToolStripMenuItem,
            this.editToolStripMenuItem,
            this.deleteToolStripMenuItem,
            this.returnRoomToolStripMenuItem,
            this.checkInToolStripMenuItem,
            this.addNewReservationToolStripMenuItem,
            this.roomDetailsToolStripMenuItem});
            this.cmsReservations.Name = "cmsReservations";
            this.cmsReservations.Size = new System.Drawing.Size(222, 172);
            this.cmsReservations.Opening += new System.ComponentModel.CancelEventHandler(this.cmsReservations_Opening);
            // 
            // detailsToolStripMenuItem
            // 
            this.detailsToolStripMenuItem.Name = "detailsToolStripMenuItem";
            this.detailsToolStripMenuItem.Size = new System.Drawing.Size(221, 24);
            this.detailsToolStripMenuItem.Text = "Details";
            this.detailsToolStripMenuItem.Click += new System.EventHandler(this.detailsToolStripMenuItem_Click);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(221, 24);
            this.editToolStripMenuItem.Text = "Edit";
            this.editToolStripMenuItem.Click += new System.EventHandler(this.editToolStripMenuItem_Click);
            // 
            // deleteToolStripMenuItem
            // 
            this.deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            this.deleteToolStripMenuItem.Size = new System.Drawing.Size(221, 24);
            this.deleteToolStripMenuItem.Text = "Delete";
            this.deleteToolStripMenuItem.Click += new System.EventHandler(this.CancelToolStripMenuItem_Click);
            // 
            // returnRoomToolStripMenuItem
            // 
            this.returnRoomToolStripMenuItem.Name = "returnRoomToolStripMenuItem";
            this.returnRoomToolStripMenuItem.Size = new System.Drawing.Size(221, 24);
            this.returnRoomToolStripMenuItem.Text = "Return Room";
            this.returnRoomToolStripMenuItem.Click += new System.EventHandler(this.returnRoomToolStripMenuItem_Click);
            // 
            // checkInToolStripMenuItem
            // 
            this.checkInToolStripMenuItem.Name = "checkInToolStripMenuItem";
            this.checkInToolStripMenuItem.Size = new System.Drawing.Size(221, 24);
            this.checkInToolStripMenuItem.Text = "Check In";
            this.checkInToolStripMenuItem.Click += new System.EventHandler(this.checkInToolStripMenuItem_Click);
            // 
            // addNewReservationToolStripMenuItem
            // 
            this.addNewReservationToolStripMenuItem.Name = "addNewReservationToolStripMenuItem";
            this.addNewReservationToolStripMenuItem.Size = new System.Drawing.Size(221, 24);
            this.addNewReservationToolStripMenuItem.Text = "Add New Reservation";
            this.addNewReservationToolStripMenuItem.Click += new System.EventHandler(this.addNewReservationToolStripMenuItem_Click);
            // 
            // roomDetailsToolStripMenuItem
            // 
            this.roomDetailsToolStripMenuItem.Name = "roomDetailsToolStripMenuItem";
            this.roomDetailsToolStripMenuItem.Size = new System.Drawing.Size(221, 24);
            this.roomDetailsToolStripMenuItem.Text = "Room Details";
            this.roomDetailsToolStripMenuItem.Click += new System.EventHandler(this.roomDetailsToolStripMenuItem_Click);
            // 
            // btnEditReservation
            // 
            this.btnEditReservation.AccessibleDescription = "The default button control that accept input though the mouse, touch and keyboard" +
    "";
            this.btnEditReservation.AccessibleName = "Edit";
            this.btnEditReservation.AutoSizeBasedOnText = false;
            this.btnEditReservation.BackColor = System.Drawing.Color.Transparent;
            this.btnEditReservation.BadgeBackColor = System.Drawing.Color.Gainsboro;
            this.btnEditReservation.BadgeFont = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditReservation.BadgeValue = 0;
            this.btnEditReservation.BadgeValueForeColor = System.Drawing.Color.Gainsboro;
            this.btnEditReservation.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(216)))), ((int)(((byte)(220)))));
            this.btnEditReservation.BorderWidth = 1;
            this.btnEditReservation.ButtonBackColor = System.Drawing.Color.Maroon;
            this.btnEditReservation.ButtonImage = null;
            this.btnEditReservation.ButtonTextLeftPadding = 0;
            this.btnEditReservation.CanBeep = true;
            this.btnEditReservation.CanGlow = false;
            this.btnEditReservation.CanShake = true;
            this.btnEditReservation.ContextMenuStripEx = null;
            this.btnEditReservation.CornerRadiusBottomLeft = 10;
            this.btnEditReservation.CornerRadiusBottomRight = 10;
            this.btnEditReservation.CornerRadiusTopLeft = 10;
            this.btnEditReservation.CornerRadiusTopRight = 10;
            this.btnEditReservation.CustomCursor = System.Windows.Forms.Cursors.Default;
            this.btnEditReservation.DisabledTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(150)))), ((int)(((byte)(150)))));
            this.btnEditReservation.EnableLongPress = false;
            this.btnEditReservation.EnableRippleEffect = true;
            this.btnEditReservation.EnableShadow = false;
            this.btnEditReservation.EnableTextWrapping = false;
            this.btnEditReservation.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F);
            this.btnEditReservation.GlowColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnEditReservation.GlowIntensity = 100;
            this.btnEditReservation.GlowRadius = 20F;
            this.btnEditReservation.GradientBackground = false;
            this.btnEditReservation.GradientColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(227)))), ((int)(((byte)(64)))));
            this.btnEditReservation.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.btnEditReservation.HintText = null;
            this.btnEditReservation.HoverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.btnEditReservation.HoverFontStyle = System.Drawing.FontStyle.Regular;
            this.btnEditReservation.HoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnEditReservation.HoverTransitionDuration = 250;
            this.btnEditReservation.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEditReservation.ImagePadding = 5;
            this.btnEditReservation.ImageSize = new System.Drawing.Size(16, 16);
            this.btnEditReservation.IsRadial = false;
            this.btnEditReservation.IsReadOnly = false;
            this.btnEditReservation.IsToggleButton = false;
            this.btnEditReservation.IsToggled = false;
            this.btnEditReservation.Location = new System.Drawing.Point(1520, 294);
            this.btnEditReservation.LongPressDurationMS = 1000;
            this.btnEditReservation.Name = "btnEditReservation";
            this.btnEditReservation.NormalFontStyle = System.Drawing.FontStyle.Regular;
            this.btnEditReservation.ParticleColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.btnEditReservation.ParticleCount = 15;
            this.btnEditReservation.PressAnimationScale = 0.97F;
            this.btnEditReservation.PressedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(227)))), ((int)(((byte)(230)))));
            this.btnEditReservation.PressedFontStyle = System.Drawing.FontStyle.Regular;
            this.btnEditReservation.PressTransitionDuration = 150;
            this.btnEditReservation.ReadOnlyTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.btnEditReservation.RippleColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnEditReservation.RippleRadiusMultiplier = 0.6F;
            this.btnEditReservation.ShadowBlur = 5;
            this.btnEditReservation.ShadowColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnEditReservation.ShadowOffset = new System.Drawing.Point(0, 2);
            this.btnEditReservation.ShakeDuration = 500;
            this.btnEditReservation.ShakeIntensity = 5;
            this.btnEditReservation.Size = new System.Drawing.Size(275, 52);
            this.btnEditReservation.TabIndex = 35;
            this.btnEditReservation.Text = "Edit";
            this.btnEditReservation.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnEditReservation.TextColor = System.Drawing.Color.WhiteSmoke;
            this.btnEditReservation.TooltipText = null;
            this.btnEditReservation.UseAdvancedRendering = true;
            this.btnEditReservation.UseParticles = false;
            this.btnEditReservation.Click += new System.EventHandler(this.btnEditReservation_Click);
            // 
            // btnReturnRoom
            // 
            this.btnReturnRoom.AccessibleDescription = "The default button control that accept input though the mouse, touch and keyboard" +
    "";
            this.btnReturnRoom.AccessibleName = "Return room";
            this.btnReturnRoom.AutoSizeBasedOnText = false;
            this.btnReturnRoom.BackColor = System.Drawing.Color.Transparent;
            this.btnReturnRoom.BadgeBackColor = System.Drawing.Color.Gainsboro;
            this.btnReturnRoom.BadgeFont = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReturnRoom.BadgeValue = 0;
            this.btnReturnRoom.BadgeValueForeColor = System.Drawing.Color.Gainsboro;
            this.btnReturnRoom.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(216)))), ((int)(((byte)(220)))));
            this.btnReturnRoom.BorderWidth = 1;
            this.btnReturnRoom.ButtonBackColor = System.Drawing.Color.Maroon;
            this.btnReturnRoom.ButtonImage = null;
            this.btnReturnRoom.ButtonTextLeftPadding = 0;
            this.btnReturnRoom.CanBeep = true;
            this.btnReturnRoom.CanGlow = false;
            this.btnReturnRoom.CanShake = true;
            this.btnReturnRoom.ContextMenuStripEx = null;
            this.btnReturnRoom.CornerRadiusBottomLeft = 10;
            this.btnReturnRoom.CornerRadiusBottomRight = 10;
            this.btnReturnRoom.CornerRadiusTopLeft = 10;
            this.btnReturnRoom.CornerRadiusTopRight = 10;
            this.btnReturnRoom.CustomCursor = System.Windows.Forms.Cursors.Default;
            this.btnReturnRoom.DisabledTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(150)))), ((int)(((byte)(150)))));
            this.btnReturnRoom.EnableLongPress = false;
            this.btnReturnRoom.EnableRippleEffect = true;
            this.btnReturnRoom.EnableShadow = false;
            this.btnReturnRoom.EnableTextWrapping = false;
            this.btnReturnRoom.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F);
            this.btnReturnRoom.GlowColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnReturnRoom.GlowIntensity = 100;
            this.btnReturnRoom.GlowRadius = 20F;
            this.btnReturnRoom.GradientBackground = false;
            this.btnReturnRoom.GradientColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(227)))), ((int)(((byte)(64)))));
            this.btnReturnRoom.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.btnReturnRoom.HintText = null;
            this.btnReturnRoom.HoverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.btnReturnRoom.HoverFontStyle = System.Drawing.FontStyle.Regular;
            this.btnReturnRoom.HoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnReturnRoom.HoverTransitionDuration = 250;
            this.btnReturnRoom.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnReturnRoom.ImagePadding = 5;
            this.btnReturnRoom.ImageSize = new System.Drawing.Size(16, 16);
            this.btnReturnRoom.IsRadial = false;
            this.btnReturnRoom.IsReadOnly = false;
            this.btnReturnRoom.IsToggleButton = false;
            this.btnReturnRoom.IsToggled = false;
            this.btnReturnRoom.Location = new System.Drawing.Point(1520, 458);
            this.btnReturnRoom.LongPressDurationMS = 1000;
            this.btnReturnRoom.Name = "btnReturnRoom";
            this.btnReturnRoom.NormalFontStyle = System.Drawing.FontStyle.Regular;
            this.btnReturnRoom.ParticleColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.btnReturnRoom.ParticleCount = 15;
            this.btnReturnRoom.PressAnimationScale = 0.97F;
            this.btnReturnRoom.PressedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(227)))), ((int)(((byte)(230)))));
            this.btnReturnRoom.PressedFontStyle = System.Drawing.FontStyle.Regular;
            this.btnReturnRoom.PressTransitionDuration = 150;
            this.btnReturnRoom.ReadOnlyTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.btnReturnRoom.RippleColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnReturnRoom.RippleRadiusMultiplier = 0.6F;
            this.btnReturnRoom.ShadowBlur = 5;
            this.btnReturnRoom.ShadowColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnReturnRoom.ShadowOffset = new System.Drawing.Point(0, 2);
            this.btnReturnRoom.ShakeDuration = 500;
            this.btnReturnRoom.ShakeIntensity = 5;
            this.btnReturnRoom.Size = new System.Drawing.Size(275, 52);
            this.btnReturnRoom.TabIndex = 36;
            this.btnReturnRoom.Text = "Return room";
            this.btnReturnRoom.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnReturnRoom.TextColor = System.Drawing.Color.WhiteSmoke;
            this.btnReturnRoom.TooltipText = null;
            this.btnReturnRoom.UseAdvancedRendering = true;
            this.btnReturnRoom.UseParticles = false;
            this.btnReturnRoom.Click += new System.EventHandler(this.btnReturnRoom_Click);
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
            this.btnDetails.Location = new System.Drawing.Point(1520, 213);
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
            this.btnDetails.TabIndex = 37;
            this.btnDetails.Text = "Details";
            this.btnDetails.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnDetails.TextColor = System.Drawing.Color.WhiteSmoke;
            this.btnDetails.TooltipText = null;
            this.btnDetails.UseAdvancedRendering = true;
            this.btnDetails.UseParticles = false;
            this.btnDetails.Click += new System.EventHandler(this.btnDetails_Click);
            // 
            // btnCheckIn
            // 
            this.btnCheckIn.AccessibleDescription = "The default button control that accept input though the mouse, touch and keyboard" +
    "";
            this.btnCheckIn.AccessibleName = "Check In";
            this.btnCheckIn.AutoSizeBasedOnText = false;
            this.btnCheckIn.BackColor = System.Drawing.Color.Transparent;
            this.btnCheckIn.BadgeBackColor = System.Drawing.Color.Gainsboro;
            this.btnCheckIn.BadgeFont = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCheckIn.BadgeValue = 0;
            this.btnCheckIn.BadgeValueForeColor = System.Drawing.Color.Gainsboro;
            this.btnCheckIn.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(216)))), ((int)(((byte)(220)))));
            this.btnCheckIn.BorderWidth = 1;
            this.btnCheckIn.ButtonBackColor = System.Drawing.Color.Maroon;
            this.btnCheckIn.ButtonImage = null;
            this.btnCheckIn.ButtonTextLeftPadding = 0;
            this.btnCheckIn.CanBeep = true;
            this.btnCheckIn.CanGlow = false;
            this.btnCheckIn.CanShake = true;
            this.btnCheckIn.ContextMenuStripEx = null;
            this.btnCheckIn.CornerRadiusBottomLeft = 10;
            this.btnCheckIn.CornerRadiusBottomRight = 10;
            this.btnCheckIn.CornerRadiusTopLeft = 10;
            this.btnCheckIn.CornerRadiusTopRight = 10;
            this.btnCheckIn.CustomCursor = System.Windows.Forms.Cursors.Default;
            this.btnCheckIn.DisabledTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(150)))), ((int)(((byte)(150)))));
            this.btnCheckIn.EnableLongPress = false;
            this.btnCheckIn.EnableRippleEffect = true;
            this.btnCheckIn.EnableShadow = false;
            this.btnCheckIn.EnableTextWrapping = false;
            this.btnCheckIn.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F);
            this.btnCheckIn.GlowColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnCheckIn.GlowIntensity = 100;
            this.btnCheckIn.GlowRadius = 20F;
            this.btnCheckIn.GradientBackground = false;
            this.btnCheckIn.GradientColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(227)))), ((int)(((byte)(64)))));
            this.btnCheckIn.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.btnCheckIn.HintText = null;
            this.btnCheckIn.HoverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.btnCheckIn.HoverFontStyle = System.Drawing.FontStyle.Regular;
            this.btnCheckIn.HoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnCheckIn.HoverTransitionDuration = 250;
            this.btnCheckIn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCheckIn.ImagePadding = 5;
            this.btnCheckIn.ImageSize = new System.Drawing.Size(16, 16);
            this.btnCheckIn.IsRadial = false;
            this.btnCheckIn.IsReadOnly = false;
            this.btnCheckIn.IsToggleButton = false;
            this.btnCheckIn.IsToggled = false;
            this.btnCheckIn.Location = new System.Drawing.Point(1520, 539);
            this.btnCheckIn.LongPressDurationMS = 1000;
            this.btnCheckIn.Name = "btnCheckIn";
            this.btnCheckIn.NormalFontStyle = System.Drawing.FontStyle.Regular;
            this.btnCheckIn.ParticleColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.btnCheckIn.ParticleCount = 15;
            this.btnCheckIn.PressAnimationScale = 0.97F;
            this.btnCheckIn.PressedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(227)))), ((int)(((byte)(230)))));
            this.btnCheckIn.PressedFontStyle = System.Drawing.FontStyle.Regular;
            this.btnCheckIn.PressTransitionDuration = 150;
            this.btnCheckIn.ReadOnlyTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.btnCheckIn.RippleColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnCheckIn.RippleRadiusMultiplier = 0.6F;
            this.btnCheckIn.ShadowBlur = 5;
            this.btnCheckIn.ShadowColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnCheckIn.ShadowOffset = new System.Drawing.Point(0, 2);
            this.btnCheckIn.ShakeDuration = 500;
            this.btnCheckIn.ShakeIntensity = 5;
            this.btnCheckIn.Size = new System.Drawing.Size(275, 52);
            this.btnCheckIn.TabIndex = 38;
            this.btnCheckIn.Text = "Check In";
            this.btnCheckIn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnCheckIn.TextColor = System.Drawing.Color.WhiteSmoke;
            this.btnCheckIn.TooltipText = null;
            this.btnCheckIn.UseAdvancedRendering = true;
            this.btnCheckIn.UseParticles = false;
            this.btnCheckIn.Click += new System.EventHandler(this.btnCheckIn_Click);
            // 
            // cmbReservationStatus
            // 
            this.cmbReservationStatus.BackColor = System.Drawing.Color.Transparent;
            this.cmbReservationStatus.BorderRadius = 10;
            this.cmbReservationStatus.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbReservationStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbReservationStatus.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmbReservationStatus.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmbReservationStatus.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cmbReservationStatus.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cmbReservationStatus.ItemHeight = 30;
            this.cmbReservationStatus.Items.AddRange(new object[] {
            "All",
            "Reserved",
            "Checked In",
            "No Show",
            "Cancelled",
            "Completed"});
            this.cmbReservationStatus.Location = new System.Drawing.Point(451, 243);
            this.cmbReservationStatus.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cmbReservationStatus.Name = "cmbReservationStatus";
            this.cmbReservationStatus.Size = new System.Drawing.Size(188, 36);
            this.cmbReservationStatus.TabIndex = 39;
            this.cmbReservationStatus.Visible = false;
            this.cmbReservationStatus.SelectedIndexChanged += new System.EventHandler(this.cmbReservationStatus_SelectedIndexChanged);
            // 
            // btnCancel
            // 
            this.btnCancel.AccessibleDescription = "The default button control that accept input though the mouse, touch and keyboard" +
    "";
            this.btnCancel.AccessibleName = "Cancel";
            this.btnCancel.AutoSizeBasedOnText = false;
            this.btnCancel.BackColor = System.Drawing.Color.Transparent;
            this.btnCancel.BadgeBackColor = System.Drawing.Color.Gainsboro;
            this.btnCancel.BadgeFont = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.BadgeValue = 0;
            this.btnCancel.BadgeValueForeColor = System.Drawing.Color.Gainsboro;
            this.btnCancel.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(216)))), ((int)(((byte)(220)))));
            this.btnCancel.BorderWidth = 1;
            this.btnCancel.ButtonBackColor = System.Drawing.Color.Maroon;
            this.btnCancel.ButtonImage = null;
            this.btnCancel.ButtonTextLeftPadding = 0;
            this.btnCancel.CanBeep = true;
            this.btnCancel.CanGlow = false;
            this.btnCancel.CanShake = true;
            this.btnCancel.ContextMenuStripEx = null;
            this.btnCancel.CornerRadiusBottomLeft = 10;
            this.btnCancel.CornerRadiusBottomRight = 10;
            this.btnCancel.CornerRadiusTopLeft = 10;
            this.btnCancel.CornerRadiusTopRight = 10;
            this.btnCancel.CustomCursor = System.Windows.Forms.Cursors.Default;
            this.btnCancel.DisabledTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(150)))), ((int)(((byte)(150)))));
            this.btnCancel.EnableLongPress = false;
            this.btnCancel.EnableRippleEffect = true;
            this.btnCancel.EnableShadow = false;
            this.btnCancel.EnableTextWrapping = false;
            this.btnCancel.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F);
            this.btnCancel.GlowColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnCancel.GlowIntensity = 100;
            this.btnCancel.GlowRadius = 20F;
            this.btnCancel.GradientBackground = false;
            this.btnCancel.GradientColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(227)))), ((int)(((byte)(64)))));
            this.btnCancel.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.btnCancel.HintText = null;
            this.btnCancel.HoverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.btnCancel.HoverFontStyle = System.Drawing.FontStyle.Regular;
            this.btnCancel.HoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnCancel.HoverTransitionDuration = 250;
            this.btnCancel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCancel.ImagePadding = 5;
            this.btnCancel.ImageSize = new System.Drawing.Size(16, 16);
            this.btnCancel.IsRadial = false;
            this.btnCancel.IsReadOnly = false;
            this.btnCancel.IsToggleButton = false;
            this.btnCancel.IsToggled = false;
            this.btnCancel.Location = new System.Drawing.Point(1520, 378);
            this.btnCancel.LongPressDurationMS = 1000;
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.NormalFontStyle = System.Drawing.FontStyle.Regular;
            this.btnCancel.ParticleColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.btnCancel.ParticleCount = 15;
            this.btnCancel.PressAnimationScale = 0.97F;
            this.btnCancel.PressedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(227)))), ((int)(((byte)(230)))));
            this.btnCancel.PressedFontStyle = System.Drawing.FontStyle.Regular;
            this.btnCancel.PressTransitionDuration = 150;
            this.btnCancel.ReadOnlyTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.btnCancel.RippleColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnCancel.RippleRadiusMultiplier = 0.6F;
            this.btnCancel.ShadowBlur = 5;
            this.btnCancel.ShadowColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnCancel.ShadowOffset = new System.Drawing.Point(0, 2);
            this.btnCancel.ShakeDuration = 500;
            this.btnCancel.ShakeIntensity = 5;
            this.btnCancel.Size = new System.Drawing.Size(275, 52);
            this.btnCancel.TabIndex = 40;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnCancel.TextColor = System.Drawing.Color.WhiteSmoke;
            this.btnCancel.TooltipText = null;
            this.btnCancel.UseAdvancedRendering = true;
            this.btnCancel.UseParticles = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
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
            this.siticoneGroupBox1.Controls.Add(this.lblNoReservations);
            this.siticoneGroupBox1.Controls.Add(this.btnNext);
            this.siticoneGroupBox1.Controls.Add(this.btnPrevious);
            this.siticoneGroupBox1.Controls.Add(this.siticoneButton2);
            this.siticoneGroupBox1.Controls.Add(this.dgvReservations);
            this.siticoneGroupBox1.Controls.Add(this.cmbRoomType);
            this.siticoneGroupBox1.Controls.Add(this.siticoneButton1);
            this.siticoneGroupBox1.Controls.Add(this.cmbFilter);
            this.siticoneGroupBox1.Controls.Add(this.btnCancel);
            this.siticoneGroupBox1.Controls.Add(this.guna2HtmlLabel1);
            this.siticoneGroupBox1.Controls.Add(this.btnDetails);
            this.siticoneGroupBox1.Controls.Add(this.btnCheckIn);
            this.siticoneGroupBox1.Controls.Add(this.btnEditReservation);
            this.siticoneGroupBox1.Controls.Add(this.btnReturnRoom);
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
            this.siticoneGroupBox1.Location = new System.Drawing.Point(97, 94);
            this.siticoneGroupBox1.MaxBlinkCount = 3;
            this.siticoneGroupBox1.Name = "siticoneGroupBox1";
            this.siticoneGroupBox1.PressedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(84)))), ((int)(((byte)(153)))));
            this.siticoneGroupBox1.ShadowColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.siticoneGroupBox1.ShadowDepth = 4;
            this.siticoneGroupBox1.ShowShadow = true;
            this.siticoneGroupBox1.Size = new System.Drawing.Size(1827, 884);
            this.siticoneGroupBox1.SolidFillColor = System.Drawing.Color.AntiqueWhite;
            this.siticoneGroupBox1.StatusIcon = null;
            this.siticoneGroupBox1.StatusText = "";
            this.siticoneGroupBox1.TabIndex = 41;
            this.siticoneGroupBox1.Text = "siticoneGroupBox1";
            this.siticoneGroupBox1.TitleBackColor = System.Drawing.Color.Transparent;
            this.siticoneGroupBox1.TitleColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.siticoneGroupBox1.TitlePadding = new System.Windows.Forms.Padding(10, 8, 10, 12);
            this.siticoneGroupBox1.TitlePos = SiticoneNetFrameworkUI.TitlePosition.TopLeft;
            this.siticoneGroupBox1.UseGradient = false;
            this.siticoneGroupBox1.Click += new System.EventHandler(this.siticoneGroupBox1_Click);
            // 
            // lblNoReservations
            // 
            this.lblNoReservations.BackColor = System.Drawing.Color.White;
            this.lblNoReservations.Font = new System.Drawing.Font("Segoe UI Semibold", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNoReservations.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblNoReservations.Location = new System.Drawing.Point(636, 405);
            this.lblNoReservations.Name = "lblNoReservations";
            this.lblNoReservations.Padding = new System.Windows.Forms.Padding(0, 0, 100, 70);
            this.lblNoReservations.Size = new System.Drawing.Size(377, 122);
            this.lblNoReservations.TabIndex = 45;
            this.lblNoReservations.Text = "No Reservations";
            this.lblNoReservations.Visible = false;
            // 
            // btnNext
            // 
            this.btnNext.AccessibleDescription = "The default button control that accept input though the mouse, touch and keyboard" +
    "";
            this.btnNext.AccessibleName = ">";
            this.btnNext.AutoSizeBasedOnText = false;
            this.btnNext.BackColor = System.Drawing.Color.Transparent;
            this.btnNext.BadgeBackColor = System.Drawing.Color.Gainsboro;
            this.btnNext.BadgeFont = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNext.BadgeValue = 0;
            this.btnNext.BadgeValueForeColor = System.Drawing.Color.Gainsboro;
            this.btnNext.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(216)))), ((int)(((byte)(220)))));
            this.btnNext.BorderWidth = 1;
            this.btnNext.ButtonBackColor = System.Drawing.Color.Maroon;
            this.btnNext.ButtonImage = null;
            this.btnNext.ButtonTextLeftPadding = 0;
            this.btnNext.CanBeep = true;
            this.btnNext.CanGlow = false;
            this.btnNext.CanShake = true;
            this.btnNext.ContextMenuStripEx = null;
            this.btnNext.CornerRadiusBottomLeft = 10;
            this.btnNext.CornerRadiusBottomRight = 10;
            this.btnNext.CornerRadiusTopLeft = 10;
            this.btnNext.CornerRadiusTopRight = 10;
            this.btnNext.CustomCursor = System.Windows.Forms.Cursors.Default;
            this.btnNext.DisabledTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(150)))), ((int)(((byte)(150)))));
            this.btnNext.EnableLongPress = false;
            this.btnNext.EnableRippleEffect = true;
            this.btnNext.EnableShadow = false;
            this.btnNext.EnableTextWrapping = false;
            this.btnNext.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F);
            this.btnNext.GlowColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnNext.GlowIntensity = 100;
            this.btnNext.GlowRadius = 20F;
            this.btnNext.GradientBackground = false;
            this.btnNext.GradientColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(227)))), ((int)(((byte)(64)))));
            this.btnNext.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.btnNext.HintText = null;
            this.btnNext.HoverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.btnNext.HoverFontStyle = System.Drawing.FontStyle.Regular;
            this.btnNext.HoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnNext.HoverTransitionDuration = 250;
            this.btnNext.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNext.ImagePadding = 5;
            this.btnNext.ImageSize = new System.Drawing.Size(16, 16);
            this.btnNext.IsRadial = false;
            this.btnNext.IsReadOnly = false;
            this.btnNext.IsToggleButton = false;
            this.btnNext.IsToggled = false;
            this.btnNext.Location = new System.Drawing.Point(111, 772);
            this.btnNext.LongPressDurationMS = 1000;
            this.btnNext.Name = "btnNext";
            this.btnNext.NormalFontStyle = System.Drawing.FontStyle.Regular;
            this.btnNext.ParticleColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.btnNext.ParticleCount = 15;
            this.btnNext.PressAnimationScale = 0.97F;
            this.btnNext.PressedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(227)))), ((int)(((byte)(230)))));
            this.btnNext.PressedFontStyle = System.Drawing.FontStyle.Regular;
            this.btnNext.PressTransitionDuration = 150;
            this.btnNext.ReadOnlyTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.btnNext.RippleColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnNext.RippleRadiusMultiplier = 0.6F;
            this.btnNext.ShadowBlur = 5;
            this.btnNext.ShadowColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnNext.ShadowOffset = new System.Drawing.Point(0, 2);
            this.btnNext.ShakeDuration = 500;
            this.btnNext.ShakeIntensity = 5;
            this.btnNext.Size = new System.Drawing.Size(71, 52);
            this.btnNext.TabIndex = 44;
            this.btnNext.Text = ">";
            this.btnNext.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnNext.TextColor = System.Drawing.Color.WhiteSmoke;
            this.btnNext.TooltipText = null;
            this.btnNext.UseAdvancedRendering = true;
            this.btnNext.UseParticles = false;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // btnPrevious
            // 
            this.btnPrevious.AccessibleDescription = "The default button control that accept input though the mouse, touch and keyboard" +
    "";
            this.btnPrevious.AccessibleName = "< ";
            this.btnPrevious.AutoSizeBasedOnText = false;
            this.btnPrevious.BackColor = System.Drawing.Color.Transparent;
            this.btnPrevious.BadgeBackColor = System.Drawing.Color.Gainsboro;
            this.btnPrevious.BadgeFont = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrevious.BadgeValue = 0;
            this.btnPrevious.BadgeValueForeColor = System.Drawing.Color.Gainsboro;
            this.btnPrevious.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(216)))), ((int)(((byte)(220)))));
            this.btnPrevious.BorderWidth = 1;
            this.btnPrevious.ButtonBackColor = System.Drawing.Color.Maroon;
            this.btnPrevious.ButtonImage = null;
            this.btnPrevious.ButtonTextLeftPadding = 0;
            this.btnPrevious.CanBeep = true;
            this.btnPrevious.CanGlow = false;
            this.btnPrevious.CanShake = true;
            this.btnPrevious.ContextMenuStripEx = null;
            this.btnPrevious.CornerRadiusBottomLeft = 10;
            this.btnPrevious.CornerRadiusBottomRight = 10;
            this.btnPrevious.CornerRadiusTopLeft = 10;
            this.btnPrevious.CornerRadiusTopRight = 10;
            this.btnPrevious.CustomCursor = System.Windows.Forms.Cursors.Default;
            this.btnPrevious.DisabledTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(150)))), ((int)(((byte)(150)))));
            this.btnPrevious.EnableLongPress = false;
            this.btnPrevious.EnableRippleEffect = true;
            this.btnPrevious.EnableShadow = false;
            this.btnPrevious.EnableTextWrapping = false;
            this.btnPrevious.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F);
            this.btnPrevious.GlowColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnPrevious.GlowIntensity = 100;
            this.btnPrevious.GlowRadius = 20F;
            this.btnPrevious.GradientBackground = false;
            this.btnPrevious.GradientColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(227)))), ((int)(((byte)(64)))));
            this.btnPrevious.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.btnPrevious.HintText = null;
            this.btnPrevious.HoverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.btnPrevious.HoverFontStyle = System.Drawing.FontStyle.Regular;
            this.btnPrevious.HoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnPrevious.HoverTransitionDuration = 250;
            this.btnPrevious.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPrevious.ImagePadding = 5;
            this.btnPrevious.ImageSize = new System.Drawing.Size(16, 16);
            this.btnPrevious.IsRadial = false;
            this.btnPrevious.IsReadOnly = false;
            this.btnPrevious.IsToggleButton = false;
            this.btnPrevious.IsToggled = false;
            this.btnPrevious.Location = new System.Drawing.Point(24, 772);
            this.btnPrevious.LongPressDurationMS = 1000;
            this.btnPrevious.Name = "btnPrevious";
            this.btnPrevious.NormalFontStyle = System.Drawing.FontStyle.Regular;
            this.btnPrevious.ParticleColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.btnPrevious.ParticleCount = 15;
            this.btnPrevious.PressAnimationScale = 0.97F;
            this.btnPrevious.PressedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(227)))), ((int)(((byte)(230)))));
            this.btnPrevious.PressedFontStyle = System.Drawing.FontStyle.Regular;
            this.btnPrevious.PressTransitionDuration = 150;
            this.btnPrevious.ReadOnlyTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.btnPrevious.RippleColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnPrevious.RippleRadiusMultiplier = 0.6F;
            this.btnPrevious.ShadowBlur = 5;
            this.btnPrevious.ShadowColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnPrevious.ShadowOffset = new System.Drawing.Point(0, 2);
            this.btnPrevious.ShakeDuration = 500;
            this.btnPrevious.ShakeIntensity = 5;
            this.btnPrevious.Size = new System.Drawing.Size(71, 52);
            this.btnPrevious.TabIndex = 43;
            this.btnPrevious.Text = "< ";
            this.btnPrevious.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnPrevious.TextColor = System.Drawing.Color.WhiteSmoke;
            this.btnPrevious.TooltipText = null;
            this.btnPrevious.UseAdvancedRendering = true;
            this.btnPrevious.UseParticles = false;
            this.btnPrevious.Click += new System.EventHandler(this.btnPrevious_Click);
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
            this.siticoneButton2.Location = new System.Drawing.Point(1520, 699);
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
            this.siticoneButton2.TabIndex = 42;
            this.siticoneButton2.Text = "Close";
            this.siticoneButton2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.siticoneButton2.TextColor = System.Drawing.Color.WhiteSmoke;
            this.siticoneButton2.TooltipText = null;
            this.siticoneButton2.UseAdvancedRendering = true;
            this.siticoneButton2.UseParticles = false;
            this.siticoneButton2.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // cmbRoomType
            // 
            this.cmbRoomType.BackColor = System.Drawing.Color.Transparent;
            this.cmbRoomType.BorderRadius = 10;
            this.cmbRoomType.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbRoomType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbRoomType.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmbRoomType.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmbRoomType.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cmbRoomType.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cmbRoomType.ItemHeight = 30;
            this.cmbRoomType.Items.AddRange(new object[] {
            "All",
            "Single",
            "Double",
            "Suite"});
            this.cmbRoomType.Location = new System.Drawing.Point(354, 149);
            this.cmbRoomType.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cmbRoomType.Name = "cmbRoomType";
            this.cmbRoomType.Size = new System.Drawing.Size(188, 36);
            this.cmbRoomType.TabIndex = 42;
            this.cmbRoomType.Visible = false;
            this.cmbRoomType.SelectedIndexChanged += new System.EventHandler(this.cmbRoomType_SelectedIndexChanged);
            // 
            // siticoneButton1
            // 
            this.siticoneButton1.AccessibleDescription = "The default button control that accept input though the mouse, touch and keyboard" +
    "";
            this.siticoneButton1.AccessibleName = "Add New Rerservation";
            this.siticoneButton1.AutoSizeBasedOnText = false;
            this.siticoneButton1.BackColor = System.Drawing.Color.Transparent;
            this.siticoneButton1.BadgeBackColor = System.Drawing.Color.Gainsboro;
            this.siticoneButton1.BadgeFont = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.siticoneButton1.BadgeValue = 0;
            this.siticoneButton1.BadgeValueForeColor = System.Drawing.Color.Gainsboro;
            this.siticoneButton1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(216)))), ((int)(((byte)(220)))));
            this.siticoneButton1.BorderWidth = 1;
            this.siticoneButton1.ButtonBackColor = System.Drawing.Color.Maroon;
            this.siticoneButton1.ButtonImage = null;
            this.siticoneButton1.ButtonTextLeftPadding = 0;
            this.siticoneButton1.CanBeep = true;
            this.siticoneButton1.CanGlow = false;
            this.siticoneButton1.CanShake = true;
            this.siticoneButton1.ContextMenuStripEx = null;
            this.siticoneButton1.CornerRadiusBottomLeft = 10;
            this.siticoneButton1.CornerRadiusBottomRight = 10;
            this.siticoneButton1.CornerRadiusTopLeft = 10;
            this.siticoneButton1.CornerRadiusTopRight = 10;
            this.siticoneButton1.CustomCursor = System.Windows.Forms.Cursors.Default;
            this.siticoneButton1.DisabledTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(150)))), ((int)(((byte)(150)))));
            this.siticoneButton1.EnableLongPress = false;
            this.siticoneButton1.EnableRippleEffect = true;
            this.siticoneButton1.EnableShadow = false;
            this.siticoneButton1.EnableTextWrapping = false;
            this.siticoneButton1.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F);
            this.siticoneButton1.GlowColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.siticoneButton1.GlowIntensity = 100;
            this.siticoneButton1.GlowRadius = 20F;
            this.siticoneButton1.GradientBackground = false;
            this.siticoneButton1.GradientColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(227)))), ((int)(((byte)(64)))));
            this.siticoneButton1.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.siticoneButton1.HintText = null;
            this.siticoneButton1.HoverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.siticoneButton1.HoverFontStyle = System.Drawing.FontStyle.Regular;
            this.siticoneButton1.HoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.siticoneButton1.HoverTransitionDuration = 250;
            this.siticoneButton1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.siticoneButton1.ImagePadding = 5;
            this.siticoneButton1.ImageSize = new System.Drawing.Size(16, 16);
            this.siticoneButton1.IsRadial = false;
            this.siticoneButton1.IsReadOnly = false;
            this.siticoneButton1.IsToggleButton = false;
            this.siticoneButton1.IsToggled = false;
            this.siticoneButton1.Location = new System.Drawing.Point(1520, 619);
            this.siticoneButton1.LongPressDurationMS = 1000;
            this.siticoneButton1.Name = "siticoneButton1";
            this.siticoneButton1.NormalFontStyle = System.Drawing.FontStyle.Regular;
            this.siticoneButton1.ParticleColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.siticoneButton1.ParticleCount = 15;
            this.siticoneButton1.PressAnimationScale = 0.97F;
            this.siticoneButton1.PressedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(227)))), ((int)(((byte)(230)))));
            this.siticoneButton1.PressedFontStyle = System.Drawing.FontStyle.Regular;
            this.siticoneButton1.PressTransitionDuration = 150;
            this.siticoneButton1.ReadOnlyTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.siticoneButton1.RippleColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.siticoneButton1.RippleRadiusMultiplier = 0.6F;
            this.siticoneButton1.ShadowBlur = 5;
            this.siticoneButton1.ShadowColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.siticoneButton1.ShadowOffset = new System.Drawing.Point(0, 2);
            this.siticoneButton1.ShakeDuration = 500;
            this.siticoneButton1.ShakeIntensity = 5;
            this.siticoneButton1.Size = new System.Drawing.Size(275, 52);
            this.siticoneButton1.TabIndex = 41;
            this.siticoneButton1.Text = "Add New Rerservation";
            this.siticoneButton1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.siticoneButton1.TextColor = System.Drawing.Color.WhiteSmoke;
            this.siticoneButton1.TooltipText = null;
            this.siticoneButton1.UseAdvancedRendering = true;
            this.siticoneButton1.UseParticles = false;
            this.siticoneButton1.Click += new System.EventHandler(this.btnAddNewReservation_Click);
            // 
            // siticoneLabel1
            // 
            this.siticoneLabel1.BackColor = System.Drawing.Color.Transparent;
            this.siticoneLabel1.Font = new System.Drawing.Font("Segoe UI", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.siticoneLabel1.ForeColor = System.Drawing.Color.Maroon;
            this.siticoneLabel1.Location = new System.Drawing.Point(820, 24);
            this.siticoneLabel1.Name = "siticoneLabel1";
            this.siticoneLabel1.Size = new System.Drawing.Size(387, 52);
            this.siticoneLabel1.TabIndex = 45;
            this.siticoneLabel1.Text = "Reservation List";
            // 
            // frmReservationList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AntiqueWhite;
            this.ClientSize = new System.Drawing.Size(1867, 1055);
            this.Controls.Add(this.siticoneLabel1);
            this.Controls.Add(this.cmbReservationStatus);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.siticoneGroupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmReservationList";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmReservationList";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmReservationList_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvReservations)).EndInit();
            this.cmsReservations.ResumeLayout(false);
            this.siticoneGroupBox1.ResumeLayout(false);
            this.siticoneGroupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel1;
        private Guna.UI2.WinForms.Guna2TextBox txtSearch;
        private Guna.UI2.WinForms.Guna2ComboBox cmbFilter;
        private Guna.UI2.WinForms.Guna2DataGridView dgvReservations;
        private System.Windows.Forms.ContextMenuStrip cmsReservations;
        private System.Windows.Forms.ToolStripMenuItem detailsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem;
        private SiticoneNetFrameworkUI.SiticoneButton btnEditReservation;
        private SiticoneNetFrameworkUI.SiticoneButton btnReturnRoom;
        private SiticoneNetFrameworkUI.SiticoneButton btnDetails;
        private System.Windows.Forms.ToolStripMenuItem returnRoomToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem checkInToolStripMenuItem;
        private SiticoneNetFrameworkUI.SiticoneButton btnCheckIn;
        private Guna.UI2.WinForms.Guna2ComboBox cmbReservationStatus;
        private SiticoneNetFrameworkUI.SiticoneButton btnCancel;
        private SiticoneNetFrameworkUI.SiticoneGroupBox siticoneGroupBox1;
        private SiticoneNetFrameworkUI.SiticoneButton siticoneButton1;
        private SiticoneNetFrameworkUI.SiticoneButton siticoneButton2;
        private Guna.UI2.WinForms.Guna2ComboBox cmbRoomType;
        private System.Windows.Forms.ToolStripMenuItem addNewReservationToolStripMenuItem;
        private SiticoneNetFrameworkUI.SiticoneButton btnNext;
        private SiticoneNetFrameworkUI.SiticoneButton btnPrevious;
        private SiticoneNetFrameworkUI.SiticoneLabel siticoneLabel1;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblNoReservations;
        private System.Windows.Forms.ToolStripMenuItem roomDetailsToolStripMenuItem;
    }
}