namespace Hotel_Reservations_System
{
    partial class frmReports
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
            SiticoneNetFrameworkUI.SiticonePieChart.PieChartTheme pieChartTheme1 = new SiticoneNetFrameworkUI.SiticonePieChart.PieChartTheme();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmReports));
            this.siticoneGroupBox1 = new SiticoneNetFrameworkUI.SiticoneGroupBox();
            this.lblCompletedReserevationCount = new SiticoneNetFrameworkUI.SiticoneLabel();
            this.siticoneGroupBox2 = new SiticoneNetFrameworkUI.SiticoneGroupBox();
            this.lblCancelledReservationCount = new SiticoneNetFrameworkUI.SiticoneLabel();
            this.siticoneGroupBox3 = new SiticoneNetFrameworkUI.SiticoneGroupBox();
            this.lblNoShowReservationsCount = new SiticoneNetFrameworkUI.SiticoneLabel();
            this.dgvMonthlyReservations = new Guna.UI2.WinForms.Guna2DataGridView();
            this.chartStatus = new SiticoneNetFrameworkUI.SiticonePieChart();
            this.lblTitle = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2HtmlLabel1 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.lblCheckedInReservationCount = new SiticoneNetFrameworkUI.SiticoneLabel();
            this.siticoneGroupBox4 = new SiticoneNetFrameworkUI.SiticoneGroupBox();
            this.siticoneGroupBox1.SuspendLayout();
            this.siticoneGroupBox2.SuspendLayout();
            this.siticoneGroupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMonthlyReservations)).BeginInit();
            this.siticoneGroupBox4.SuspendLayout();
            this.SuspendLayout();
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
            this.siticoneGroupBox1.BorderColor = System.Drawing.Color.White;
            this.siticoneGroupBox1.BorderStyle = SiticoneNetFrameworkUI.SiticoneGroupBoxBorderStyle.None;
            this.siticoneGroupBox1.BorderWidth = 1F;
            this.siticoneGroupBox1.ChevronColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(90)))), ((int)(((byte)(90)))));
            this.siticoneGroupBox1.ChevronLeftSpacing = 4F;
            this.siticoneGroupBox1.ChevronSize = 10F;
            this.siticoneGroupBox1.ChevronThickness = 2F;
            this.siticoneGroupBox1.ContentPadding = 5;
            this.siticoneGroupBox1.Controls.Add(this.lblCompletedReserevationCount);
            this.siticoneGroupBox1.CornerRadius = 8;
            this.siticoneGroupBox1.EnableBlinking = false;
            this.siticoneGroupBox1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.siticoneGroupBox1.GradientEndColor = System.Drawing.Color.LightGray;
            this.siticoneGroupBox1.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.siticoneGroupBox1.GradientStartColor = System.Drawing.Color.White;
            this.siticoneGroupBox1.GroupTitle = "Completed Reservations";
            this.siticoneGroupBox1.HoveredBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(215)))));
            this.siticoneGroupBox1.HoveredTitleColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(215)))));
            this.siticoneGroupBox1.IsCollapsible = false;
            this.siticoneGroupBox1.Location = new System.Drawing.Point(21, 141);
            this.siticoneGroupBox1.MaxBlinkCount = 3;
            this.siticoneGroupBox1.Name = "siticoneGroupBox1";
            this.siticoneGroupBox1.PressedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(84)))), ((int)(((byte)(153)))));
            this.siticoneGroupBox1.ShadowColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.siticoneGroupBox1.ShadowDepth = 4;
            this.siticoneGroupBox1.ShowShadow = true;
            this.siticoneGroupBox1.Size = new System.Drawing.Size(210, 174);
            this.siticoneGroupBox1.SolidFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.siticoneGroupBox1.StatusIcon = null;
            this.siticoneGroupBox1.StatusText = "";
            this.siticoneGroupBox1.TabIndex = 0;
            this.siticoneGroupBox1.TitleBackColor = System.Drawing.Color.Transparent;
            this.siticoneGroupBox1.TitleColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.siticoneGroupBox1.TitlePadding = new System.Windows.Forms.Padding(10, 8, 10, 12);
            this.siticoneGroupBox1.TitlePos = SiticoneNetFrameworkUI.TitlePosition.TopCenter;
            this.siticoneGroupBox1.UseGradient = false;
            this.siticoneGroupBox1.Click += new System.EventHandler(this.siticoneGroupBox1_Click);
            // 
            // lblCompletedReserevationCount
            // 
            this.lblCompletedReserevationCount.BackColor = System.Drawing.Color.Transparent;
            this.lblCompletedReserevationCount.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCompletedReserevationCount.ForeColor = System.Drawing.Color.Wheat;
            this.lblCompletedReserevationCount.Location = new System.Drawing.Point(82, 81);
            this.lblCompletedReserevationCount.Name = "lblCompletedReserevationCount";
            this.lblCompletedReserevationCount.Size = new System.Drawing.Size(137, 52);
            this.lblCompletedReserevationCount.TabIndex = 0;
            this.lblCompletedReserevationCount.Text = "0";
            this.lblCompletedReserevationCount.Click += new System.EventHandler(this.lblCompletedReserevationCount_Click);
            // 
            // siticoneGroupBox2
            // 
            this.siticoneGroupBox2.BackColor = System.Drawing.Color.Transparent;
            this.siticoneGroupBox2.BadgeColor = System.Drawing.Color.Red;
            this.siticoneGroupBox2.BadgeFont = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold);
            this.siticoneGroupBox2.BadgeLeftPadding = 12;
            this.siticoneGroupBox2.BadgeValue = 0;
            this.siticoneGroupBox2.BadgeVisible = false;
            this.siticoneGroupBox2.BlinkInterval = 500;
            this.siticoneGroupBox2.BlinkMinOpacity = 0.3F;
            this.siticoneGroupBox2.BlinkOpacityStep = 0.05F;
            this.siticoneGroupBox2.BorderColor = System.Drawing.Color.White;
            this.siticoneGroupBox2.BorderStyle = SiticoneNetFrameworkUI.SiticoneGroupBoxBorderStyle.None;
            this.siticoneGroupBox2.BorderWidth = 1F;
            this.siticoneGroupBox2.ChevronColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(90)))), ((int)(((byte)(90)))));
            this.siticoneGroupBox2.ChevronLeftSpacing = 4F;
            this.siticoneGroupBox2.ChevronSize = 10F;
            this.siticoneGroupBox2.ChevronThickness = 2F;
            this.siticoneGroupBox2.ContentPadding = 5;
            this.siticoneGroupBox2.Controls.Add(this.lblCancelledReservationCount);
            this.siticoneGroupBox2.CornerRadius = 8;
            this.siticoneGroupBox2.EnableBlinking = false;
            this.siticoneGroupBox2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.siticoneGroupBox2.GradientEndColor = System.Drawing.Color.LightGray;
            this.siticoneGroupBox2.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.siticoneGroupBox2.GradientStartColor = System.Drawing.Color.White;
            this.siticoneGroupBox2.GroupTitle = "Cancelled Reservations";
            this.siticoneGroupBox2.HoveredBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(215)))));
            this.siticoneGroupBox2.HoveredTitleColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(215)))));
            this.siticoneGroupBox2.IsCollapsible = false;
            this.siticoneGroupBox2.Location = new System.Drawing.Point(277, 141);
            this.siticoneGroupBox2.MaxBlinkCount = 3;
            this.siticoneGroupBox2.Name = "siticoneGroupBox2";
            this.siticoneGroupBox2.PressedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(84)))), ((int)(((byte)(153)))));
            this.siticoneGroupBox2.ShadowColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.siticoneGroupBox2.ShadowDepth = 4;
            this.siticoneGroupBox2.ShowShadow = true;
            this.siticoneGroupBox2.Size = new System.Drawing.Size(210, 174);
            this.siticoneGroupBox2.SolidFillColor = System.Drawing.Color.RosyBrown;
            this.siticoneGroupBox2.StatusIcon = null;
            this.siticoneGroupBox2.StatusText = "";
            this.siticoneGroupBox2.TabIndex = 1;
            this.siticoneGroupBox2.TitleBackColor = System.Drawing.Color.Transparent;
            this.siticoneGroupBox2.TitleColor = System.Drawing.Color.RosyBrown;
            this.siticoneGroupBox2.TitlePadding = new System.Windows.Forms.Padding(10, 8, 10, 12);
            this.siticoneGroupBox2.TitlePos = SiticoneNetFrameworkUI.TitlePosition.TopCenter;
            this.siticoneGroupBox2.UseGradient = false;
            // 
            // lblCancelledReservationCount
            // 
            this.lblCancelledReservationCount.BackColor = System.Drawing.Color.Transparent;
            this.lblCancelledReservationCount.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCancelledReservationCount.ForeColor = System.Drawing.Color.Wheat;
            this.lblCancelledReservationCount.Location = new System.Drawing.Point(82, 81);
            this.lblCancelledReservationCount.Name = "lblCancelledReservationCount";
            this.lblCancelledReservationCount.Size = new System.Drawing.Size(137, 52);
            this.lblCancelledReservationCount.TabIndex = 0;
            this.lblCancelledReservationCount.Text = "0";
            // 
            // siticoneGroupBox3
            // 
            this.siticoneGroupBox3.BackColor = System.Drawing.Color.Transparent;
            this.siticoneGroupBox3.BadgeColor = System.Drawing.Color.Red;
            this.siticoneGroupBox3.BadgeFont = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold);
            this.siticoneGroupBox3.BadgeLeftPadding = 12;
            this.siticoneGroupBox3.BadgeValue = 0;
            this.siticoneGroupBox3.BadgeVisible = false;
            this.siticoneGroupBox3.BlinkInterval = 500;
            this.siticoneGroupBox3.BlinkMinOpacity = 0.3F;
            this.siticoneGroupBox3.BlinkOpacityStep = 0.05F;
            this.siticoneGroupBox3.BorderColor = System.Drawing.Color.White;
            this.siticoneGroupBox3.BorderStyle = SiticoneNetFrameworkUI.SiticoneGroupBoxBorderStyle.None;
            this.siticoneGroupBox3.BorderWidth = 1F;
            this.siticoneGroupBox3.ChevronColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(90)))), ((int)(((byte)(90)))));
            this.siticoneGroupBox3.ChevronLeftSpacing = 4F;
            this.siticoneGroupBox3.ChevronSize = 10F;
            this.siticoneGroupBox3.ChevronThickness = 2F;
            this.siticoneGroupBox3.ContentPadding = 5;
            this.siticoneGroupBox3.Controls.Add(this.lblNoShowReservationsCount);
            this.siticoneGroupBox3.CornerRadius = 8;
            this.siticoneGroupBox3.EnableBlinking = false;
            this.siticoneGroupBox3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.siticoneGroupBox3.GradientEndColor = System.Drawing.Color.LightGray;
            this.siticoneGroupBox3.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.siticoneGroupBox3.GradientStartColor = System.Drawing.Color.White;
            this.siticoneGroupBox3.GroupTitle = "No Show Reservations";
            this.siticoneGroupBox3.HoveredBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(215)))));
            this.siticoneGroupBox3.HoveredTitleColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(215)))));
            this.siticoneGroupBox3.IsCollapsible = false;
            this.siticoneGroupBox3.Location = new System.Drawing.Point(545, 141);
            this.siticoneGroupBox3.MaxBlinkCount = 3;
            this.siticoneGroupBox3.Name = "siticoneGroupBox3";
            this.siticoneGroupBox3.PressedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(84)))), ((int)(((byte)(153)))));
            this.siticoneGroupBox3.ShadowColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.siticoneGroupBox3.ShadowDepth = 4;
            this.siticoneGroupBox3.ShowShadow = true;
            this.siticoneGroupBox3.Size = new System.Drawing.Size(210, 174);
            this.siticoneGroupBox3.SolidFillColor = System.Drawing.Color.SaddleBrown;
            this.siticoneGroupBox3.StatusIcon = null;
            this.siticoneGroupBox3.StatusText = "";
            this.siticoneGroupBox3.TabIndex = 2;
            this.siticoneGroupBox3.TitleBackColor = System.Drawing.Color.Transparent;
            this.siticoneGroupBox3.TitleColor = System.Drawing.Color.SaddleBrown;
            this.siticoneGroupBox3.TitlePadding = new System.Windows.Forms.Padding(10, 8, 10, 12);
            this.siticoneGroupBox3.TitlePos = SiticoneNetFrameworkUI.TitlePosition.TopCenter;
            this.siticoneGroupBox3.UseGradient = false;
            // 
            // lblNoShowReservationsCount
            // 
            this.lblNoShowReservationsCount.BackColor = System.Drawing.Color.Transparent;
            this.lblNoShowReservationsCount.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold);
            this.lblNoShowReservationsCount.ForeColor = System.Drawing.Color.Wheat;
            this.lblNoShowReservationsCount.Location = new System.Drawing.Point(83, 81);
            this.lblNoShowReservationsCount.Name = "lblNoShowReservationsCount";
            this.lblNoShowReservationsCount.Size = new System.Drawing.Size(137, 52);
            this.lblNoShowReservationsCount.TabIndex = 0;
            this.lblNoShowReservationsCount.Text = "0";
            this.lblNoShowReservationsCount.Click += new System.EventHandler(this.lblNoShowReservationsCount_Click);
            // 
            // dgvMonthlyReservations
            // 
            this.dgvMonthlyReservations.AllowUserToAddRows = false;
            this.dgvMonthlyReservations.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.dgvMonthlyReservations.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvMonthlyReservations.BackgroundColor = System.Drawing.Color.AntiqueWhite;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Maroon;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Wheat;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Maroon;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvMonthlyReservations.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvMonthlyReservations.ColumnHeadersHeight = 40;
            this.dgvMonthlyReservations.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvMonthlyReservations.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvMonthlyReservations.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvMonthlyReservations.Location = new System.Drawing.Point(21, 399);
            this.dgvMonthlyReservations.Name = "dgvMonthlyReservations";
            this.dgvMonthlyReservations.ReadOnly = true;
            this.dgvMonthlyReservations.RowHeadersVisible = false;
            this.dgvMonthlyReservations.RowHeadersWidth = 51;
            this.dgvMonthlyReservations.RowTemplate.Height = 24;
            this.dgvMonthlyReservations.Size = new System.Drawing.Size(734, 317);
            this.dgvMonthlyReservations.TabIndex = 3;
            this.dgvMonthlyReservations.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvMonthlyReservations.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgvMonthlyReservations.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgvMonthlyReservations.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgvMonthlyReservations.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgvMonthlyReservations.ThemeStyle.BackColor = System.Drawing.Color.AntiqueWhite;
            this.dgvMonthlyReservations.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvMonthlyReservations.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dgvMonthlyReservations.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvMonthlyReservations.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvMonthlyReservations.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgvMonthlyReservations.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgvMonthlyReservations.ThemeStyle.HeaderStyle.Height = 40;
            this.dgvMonthlyReservations.ThemeStyle.ReadOnly = true;
            this.dgvMonthlyReservations.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvMonthlyReservations.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvMonthlyReservations.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvMonthlyReservations.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgvMonthlyReservations.ThemeStyle.RowsStyle.Height = 24;
            this.dgvMonthlyReservations.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvMonthlyReservations.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            // 
            // chartStatus
            // 
            this.chartStatus.BackColor = System.Drawing.Color.Transparent;
            this.chartStatus.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.chartStatus.LabelMember = "Category";
            this.chartStatus.Location = new System.Drawing.Point(750, 340);
            this.chartStatus.Name = "chartStatus";
            this.chartStatus.Size = new System.Drawing.Size(297, 376);
            this.chartStatus.TabIndex = 14;
            pieChartTheme1.BackColor = System.Drawing.SystemColors.Control;
            pieChartTheme1.BorderColor = System.Drawing.Color.White;
            pieChartTheme1.Name = "Autumn";
            pieChartTheme1.SliceColors = ((System.Collections.Generic.List<System.Drawing.Color>)(resources.GetObject("pieChartTheme1.SliceColors")));
            pieChartTheme1.TextColor = System.Drawing.Color.Black;
            this.chartStatus.Theme = pieChartTheme1;
            this.chartStatus.ValueMember = "Amount";
            // 
            // lblTitle
            // 
            this.lblTitle.BackColor = System.Drawing.Color.Transparent;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI Black", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.Maroon;
            this.lblTitle.Location = new System.Drawing.Point(420, 24);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Padding = new System.Windows.Forms.Padding(0, 0, 200, 20);
            this.lblTitle.Size = new System.Drawing.Size(345, 72);
            this.lblTitle.TabIndex = 13;
            this.lblTitle.Text = " Reports";
            // 
            // guna2HtmlLabel1
            // 
            this.guna2HtmlLabel1.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel1.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel1.ForeColor = System.Drawing.Color.Maroon;
            this.guna2HtmlLabel1.Location = new System.Drawing.Point(21, 336);
            this.guna2HtmlLabel1.Name = "guna2HtmlLabel1";
            this.guna2HtmlLabel1.Padding = new System.Windows.Forms.Padding(0, 0, 200, 10);
            this.guna2HtmlLabel1.Size = new System.Drawing.Size(443, 43);
            this.guna2HtmlLabel1.TabIndex = 15;
            this.guna2HtmlLabel1.Text = "Monthly Reservations:";
            // 
            // lblCheckedInReservationCount
            // 
            this.lblCheckedInReservationCount.BackColor = System.Drawing.Color.Transparent;
            this.lblCheckedInReservationCount.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCheckedInReservationCount.ForeColor = System.Drawing.Color.Wheat;
            this.lblCheckedInReservationCount.Location = new System.Drawing.Point(84, 81);
            this.lblCheckedInReservationCount.Name = "lblCheckedInReservationCount";
            this.lblCheckedInReservationCount.Size = new System.Drawing.Size(137, 52);
            this.lblCheckedInReservationCount.TabIndex = 0;
            this.lblCheckedInReservationCount.Text = "0";
            // 
            // siticoneGroupBox4
            // 
            this.siticoneGroupBox4.BackColor = System.Drawing.Color.Transparent;
            this.siticoneGroupBox4.BadgeColor = System.Drawing.Color.Red;
            this.siticoneGroupBox4.BadgeFont = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold);
            this.siticoneGroupBox4.BadgeLeftPadding = 12;
            this.siticoneGroupBox4.BadgeValue = 0;
            this.siticoneGroupBox4.BadgeVisible = false;
            this.siticoneGroupBox4.BlinkInterval = 500;
            this.siticoneGroupBox4.BlinkMinOpacity = 0.3F;
            this.siticoneGroupBox4.BlinkOpacityStep = 0.05F;
            this.siticoneGroupBox4.BorderColor = System.Drawing.Color.White;
            this.siticoneGroupBox4.BorderStyle = SiticoneNetFrameworkUI.SiticoneGroupBoxBorderStyle.None;
            this.siticoneGroupBox4.BorderWidth = 1F;
            this.siticoneGroupBox4.ChevronColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(90)))), ((int)(((byte)(90)))));
            this.siticoneGroupBox4.ChevronLeftSpacing = 4F;
            this.siticoneGroupBox4.ChevronSize = 10F;
            this.siticoneGroupBox4.ChevronThickness = 2F;
            this.siticoneGroupBox4.ContentPadding = 5;
            this.siticoneGroupBox4.Controls.Add(this.lblCheckedInReservationCount);
            this.siticoneGroupBox4.CornerRadius = 8;
            this.siticoneGroupBox4.EnableBlinking = false;
            this.siticoneGroupBox4.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.siticoneGroupBox4.GradientEndColor = System.Drawing.Color.LightGray;
            this.siticoneGroupBox4.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.siticoneGroupBox4.GradientStartColor = System.Drawing.Color.White;
            this.siticoneGroupBox4.GroupTitle = "Checked In Reservations";
            this.siticoneGroupBox4.HoveredBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(215)))));
            this.siticoneGroupBox4.HoveredTitleColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(215)))));
            this.siticoneGroupBox4.IsCollapsible = false;
            this.siticoneGroupBox4.Location = new System.Drawing.Point(810, 141);
            this.siticoneGroupBox4.MaxBlinkCount = 3;
            this.siticoneGroupBox4.Name = "siticoneGroupBox4";
            this.siticoneGroupBox4.PressedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(84)))), ((int)(((byte)(153)))));
            this.siticoneGroupBox4.ShadowColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.siticoneGroupBox4.ShadowDepth = 4;
            this.siticoneGroupBox4.ShowShadow = true;
            this.siticoneGroupBox4.Size = new System.Drawing.Size(210, 174);
            this.siticoneGroupBox4.SolidFillColor = System.Drawing.Color.Orange;
            this.siticoneGroupBox4.StatusIcon = null;
            this.siticoneGroupBox4.StatusText = "";
            this.siticoneGroupBox4.TabIndex = 3;
            this.siticoneGroupBox4.TitleBackColor = System.Drawing.Color.Transparent;
            this.siticoneGroupBox4.TitleColor = System.Drawing.Color.Orange;
            this.siticoneGroupBox4.TitlePadding = new System.Windows.Forms.Padding(10, 8, 10, 12);
            this.siticoneGroupBox4.TitlePos = SiticoneNetFrameworkUI.TitlePosition.TopCenter;
            this.siticoneGroupBox4.UseGradient = false;
            // 
            // frmReports
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AntiqueWhite;
            this.ClientSize = new System.Drawing.Size(1053, 728);
            this.Controls.Add(this.guna2HtmlLabel1);
            this.Controls.Add(this.siticoneGroupBox4);
            this.Controls.Add(this.chartStatus);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.dgvMonthlyReservations);
            this.Controls.Add(this.siticoneGroupBox3);
            this.Controls.Add(this.siticoneGroupBox2);
            this.Controls.Add(this.siticoneGroupBox1);
            this.Name = "frmReports";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmReports";
            this.Load += new System.EventHandler(this.frmReports_Load);
            this.siticoneGroupBox1.ResumeLayout(false);
            this.siticoneGroupBox2.ResumeLayout(false);
            this.siticoneGroupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMonthlyReservations)).EndInit();
            this.siticoneGroupBox4.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private SiticoneNetFrameworkUI.SiticoneGroupBox siticoneGroupBox1;
        private SiticoneNetFrameworkUI.SiticoneLabel lblCompletedReserevationCount;
        private SiticoneNetFrameworkUI.SiticoneGroupBox siticoneGroupBox2;
        private SiticoneNetFrameworkUI.SiticoneLabel lblCancelledReservationCount;
        private SiticoneNetFrameworkUI.SiticoneGroupBox siticoneGroupBox3;
        private SiticoneNetFrameworkUI.SiticoneLabel lblNoShowReservationsCount;
        private Guna.UI2.WinForms.Guna2DataGridView dgvMonthlyReservations;
        private SiticoneNetFrameworkUI.SiticonePieChart chartStatus;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblTitle;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel1;
        private SiticoneNetFrameworkUI.SiticoneLabel lblCheckedInReservationCount;
        private SiticoneNetFrameworkUI.SiticoneGroupBox siticoneGroupBox4;
    }
}