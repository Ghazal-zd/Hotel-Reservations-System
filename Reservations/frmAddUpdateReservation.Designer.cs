namespace Hotel_Reservations_System
{
    partial class frmAddUpdateReservation
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAddUpdateReservation));
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.txtNotes = new SiticoneNetFrameworkUI.SiticoneTextBoxAdvanced();
            this.dtCheckInDate = new SiticoneNetFrameworkUI.SiticoneDateTimePicker();
            this.lblTitle = new SiticoneNetFrameworkUI.SiticoneLabel();
            this.siticoneLabel2 = new SiticoneNetFrameworkUI.SiticoneLabel();
            this.dtCheckOutDate = new SiticoneNetFrameworkUI.SiticoneDateTimePicker();
            this.lblInitialTotalDueAmount = new SiticoneNetFrameworkUI.SiticoneLabel();
            this.siticoneLabel1 = new SiticoneNetFrameworkUI.SiticoneLabel();
            this.tpReservationData = new Guna.UI2.WinForms.Guna2TabControl();
            this.tpGuest = new System.Windows.Forms.TabPage();
            this.btnNextToRoomPage = new SiticoneNetFrameworkUI.SiticoneButtonAdvanced();
            this.ctrlCustomerDataWithFilter2 = new Hotel_Reservations_System.ctrlCustomerDataWithFilter();
            this.tpRoom = new System.Windows.Forms.TabPage();
            this.btnBackToGuestPage = new SiticoneNetFrameworkUI.SiticoneButtonAdvanced();
            this.siticoneButtonAdvanced4 = new SiticoneNetFrameworkUI.SiticoneButtonAdvanced();
            this.ctrlRoomDataWithFilter2 = new Hotel_Reservations_System.ctrlRoomDataWithFilter();
            this.tpReservation = new System.Windows.Forms.TabPage();
            this.siticoneButtonAdvanced5 = new SiticoneNetFrameworkUI.SiticoneButtonAdvanced();
            this.btnSave = new SiticoneNetFrameworkUI.SiticoneButtonAdvanced();
            this.siticoneGroupBox1 = new SiticoneNetFrameworkUI.SiticoneGroupBox();
            this.lblInitialReservationDays = new SiticoneNetFrameworkUI.SiticoneLabel();
            this.siticoneLabel3 = new SiticoneNetFrameworkUI.SiticoneLabel();
            this.lblReservationID = new SiticoneNetFrameworkUI.SiticoneLabel();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.tpReservationData.SuspendLayout();
            this.tpGuest.SuspendLayout();
            this.tpRoom.SuspendLayout();
            this.tpReservation.SuspendLayout();
            this.siticoneGroupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // txtNotes
            // 
            this.txtNotes.BackColor = System.Drawing.Color.Transparent;
            this.txtNotes.BackgroundColor = System.Drawing.Color.White;
            this.txtNotes.BorderColor = System.Drawing.Color.Gainsboro;
            this.txtNotes.BottomLeftCornerRadius = 12;
            this.txtNotes.BottomRightCornerRadius = 12;
            this.txtNotes.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtNotes.FocusBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(150)))), ((int)(((byte)(243)))));
            this.txtNotes.FocusImage = null;
            this.txtNotes.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.txtNotes.HoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(150)))), ((int)(((byte)(150)))));
            this.txtNotes.HoverImage = null;
            this.txtNotes.IdleImage = null;
            this.txtNotes.Location = new System.Drawing.Point(23, 254);
            this.txtNotes.Name = "txtNotes";
            this.txtNotes.PlaceholderColor = System.Drawing.Color.FromArgb(((int)(((byte)(117)))), ((int)(((byte)(117)))), ((int)(((byte)(117)))));
            this.txtNotes.PlaceholderFont = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.txtNotes.PlaceholderText = "Check Notes";
            this.txtNotes.ReadOnlyColors.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(245)))), ((int)(((byte)(245)))));
            this.txtNotes.ReadOnlyColors.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.txtNotes.ReadOnlyColors.PlaceholderColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(150)))), ((int)(((byte)(150)))));
            this.txtNotes.ReadOnlyColors.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.txtNotes.Size = new System.Drawing.Size(328, 119);
            this.txtNotes.TabIndex = 12;
            this.txtNotes.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.txtNotes.TextContent = "";
            this.txtNotes.TopLeftCornerRadius = 12;
            this.txtNotes.TopRightCornerRadius = 12;
            this.txtNotes.ValidationPattern = "";
            // 
            // dtCheckInDate
            // 
            this.dtCheckInDate.AutoScaleFonts = true;
            this.dtCheckInDate.BackColor = System.Drawing.Color.Transparent;
            this.dtCheckInDate.BaseCalendarFormSize = new System.Drawing.Size(535, 460);
            this.dtCheckInDate.BorderColor = System.Drawing.Color.Silver;
            this.dtCheckInDate.BorderWidth = 2;
            this.dtCheckInDate.BottomLeftBorderRadius = 8;
            this.dtCheckInDate.BottomRightBorderRadius = 8;
            this.dtCheckInDate.CalendarBackgroundColor = System.Drawing.Color.White;
            this.dtCheckInDate.CalendarChevronColor = System.Drawing.Color.Gray;
            this.dtCheckInDate.CalendarChevronHoverColor = System.Drawing.Color.Blue;
            this.dtCheckInDate.CalendarDayButtonBackColor = System.Drawing.Color.White;
            this.dtCheckInDate.CalendarDayButtonForeColor = System.Drawing.Color.Black;
            this.dtCheckInDate.CalendarDayHeaderBackColor = System.Drawing.Color.White;
            this.dtCheckInDate.CalendarDayHeaderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.dtCheckInDate.CalendarDayLabelFont = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.dtCheckInDate.CalendarDisabledDateBackColor = System.Drawing.Color.LightGray;
            this.dtCheckInDate.CalendarDisabledDateForeColor = System.Drawing.Color.DarkGray;
            this.dtCheckInDate.CalendarFormAnimationSpeed = 15;
            this.dtCheckInDate.CalendarFormAnimationStep = 0.08D;
            this.dtCheckInDate.CalendarFormBackColor = System.Drawing.Color.White;
            this.dtCheckInDate.CalendarFormBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.dtCheckInDate.CalendarFormBorderWidth = 2;
            this.dtCheckInDate.CalendarFormCornerRadius = 2;
            this.dtCheckInDate.CalendarFormFadeOutStep = 0.1D;
            this.dtCheckInDate.CalendarFormHeight = 360;
            this.dtCheckInDate.CalendarFormShadowColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.dtCheckInDate.CalendarFormShadowDepth = 5;
            this.dtCheckInDate.CalendarFormWidth = 380;
            this.dtCheckInDate.CalendarGridMargin = new System.Windows.Forms.Padding(8);
            this.dtCheckInDate.CalendarGridPadding = new System.Windows.Forms.Padding(5);
            this.dtCheckInDate.CalendarLockedDateBackColor = System.Drawing.Color.LightGray;
            this.dtCheckInDate.CalendarLockedDateForeColor = System.Drawing.Color.DarkGray;
            this.dtCheckInDate.CalendarLockedDates = ((System.Collections.Generic.List<System.DateTime>)(resources.GetObject("dtCheckInDate.CalendarLockedDates")));
            this.dtCheckInDate.CalendarMargin = 5;
            this.dtCheckInDate.CalendarMaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dtCheckInDate.CalendarMaxYear = 2126;
            this.dtCheckInDate.CalendarMinDate = new System.DateTime(((long)(0)));
            this.dtCheckInDate.CalendarMinYear = 1926;
            this.dtCheckInDate.CalendarRangeDateBackColor = System.Drawing.Color.LightBlue;
            this.dtCheckInDate.CalendarRangeEndDateBackColor = System.Drawing.Color.DodgerBlue;
            this.dtCheckInDate.CalendarRangeSelectedForeColor = System.Drawing.Color.Black;
            this.dtCheckInDate.CalendarRangeStartDateBackColor = System.Drawing.Color.DodgerBlue;
            this.dtCheckInDate.CalendarSelectedDateBackColor = System.Drawing.Color.Black;
            this.dtCheckInDate.CalendarSelectedDateForeColor = System.Drawing.Color.White;
            this.dtCheckInDate.CalendarSelectionMode = SiticoneNetFrameworkUI.SelectionMode.Single;
            this.dtCheckInDate.CalendarTodayBackColor = System.Drawing.Color.White;
            this.dtCheckInDate.CalendarTodayForeColor = System.Drawing.Color.Black;
            this.dtCheckInDate.CalendarYearPickerHeight = 10;
            this.dtCheckInDate.CanBeep = false;
            this.dtCheckInDate.CanShake = false;
            this.dtCheckInDate.ChevronColor = System.Drawing.Color.Maroon;
            this.dtCheckInDate.ChevronHoverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(225)))), ((int)(((byte)(245)))));
            this.dtCheckInDate.ChevronHoverColor = System.Drawing.Color.Black;
            this.dtCheckInDate.ChevronPanelBorderRadius = 0;
            this.dtCheckInDate.ChevronPanelHeight = 32;
            this.dtCheckInDate.ChevronPenThickness = 1.8F;
            this.dtCheckInDate.ChevronRightMargin = 18;
            this.dtCheckInDate.ChevronSize = new System.Drawing.Size(9, 14);
            this.dtCheckInDate.ChevronStep = 15F;
            this.dtCheckInDate.ChevronTimerInterval = 15;
            this.dtCheckInDate.ClearIconColor = System.Drawing.Color.Gray;
            this.dtCheckInDate.ClearIconHoverColor = System.Drawing.Color.Red;
            this.dtCheckInDate.ClearIconRightMargin = 48;
            this.dtCheckInDate.ClearIconSize = 11;
            this.dtCheckInDate.ContainerPanelMargin = new System.Windows.Forms.Padding(5);
            this.dtCheckInDate.ContainerPanelPadding = new System.Windows.Forms.Padding(0);
            this.dtCheckInDate.CustomDateFormat = "d";
            this.dtCheckInDate.CustomDateFormatter = null;
            this.dtCheckInDate.DateFormat = SiticoneNetFrameworkUI.DateFormat.ShortDate;
            this.dtCheckInDate.DayButtonBorderRadius = 0;
            this.dtCheckInDate.DayButtonClickBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(230)))), ((int)(((byte)(250)))));
            this.dtCheckInDate.DayButtonFont = new System.Drawing.Font("Segoe UI", 10.5F);
            this.dtCheckInDate.DayButtonHoverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(240)))), ((int)(((byte)(255)))));
            this.dtCheckInDate.DayButtonHoverForeColor = System.Drawing.Color.Black;
            this.dtCheckInDate.DayButtonMargin = new System.Windows.Forms.Padding(3);
            this.dtCheckInDate.DayButtonRowHeight = 16.66F;
            this.dtCheckInDate.DayHeaderFont = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.dtCheckInDate.DayHeaderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.dtCheckInDate.DayHeaderMargin = new System.Windows.Forms.Padding(1, 1, 1, 8);
            this.dtCheckInDate.DayHeaderRowHeight = 30F;
            this.dtCheckInDate.DisabledDayFont = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Italic);
            this.dtCheckInDate.DropdownBackColor = System.Drawing.Color.White;
            this.dtCheckInDate.DropdownFont = new System.Drawing.Font("Segoe UI", 11F);
            this.dtCheckInDate.DropdownHeight = 250;
            this.dtCheckInDate.FillColor = System.Drawing.Color.White;
            this.dtCheckInDate.FirstDayOfWeek = System.DayOfWeek.Sunday;
            this.dtCheckInDate.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.dtCheckInDate.ForeColor = System.Drawing.Color.DimGray;
            this.dtCheckInDate.GradientEndColor = System.Drawing.Color.Gray;
            this.dtCheckInDate.GradientStartColor = System.Drawing.Color.White;
            this.dtCheckInDate.HighlightWeekends = true;
            this.dtCheckInDate.IconSize = 16;
            this.dtCheckInDate.IsReadonly = false;
            this.dtCheckInDate.Location = new System.Drawing.Point(23, 63);
            this.dtCheckInDate.LockedDates = ((System.Collections.Generic.List<System.DateTime>)(resources.GetObject("dtCheckInDate.LockedDates")));
            this.dtCheckInDate.MakeRadial = false;
            this.dtCheckInDate.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dtCheckInDate.MaxFontScale = 1.8F;
            this.dtCheckInDate.MinDate = new System.DateTime(((long)(0)));
            this.dtCheckInDate.MinFontScale = 0.4F;
            this.dtCheckInDate.MinimumFormSize = new System.Drawing.Size(150, 150);
            this.dtCheckInDate.MonthChevronPanelMargin = new System.Windows.Forms.Padding(4, 17, 4, 0);
            this.dtCheckInDate.MonthChevronSpacing = 5;
            this.dtCheckInDate.MonthComboBoxMargin = new System.Windows.Forms.Padding(0, 17, 5, 0);
            this.dtCheckInDate.MonthComboBoxSize = new System.Drawing.Size(130, 30);
            this.dtCheckInDate.Name = "dtCheckInDate";
            this.dtCheckInDate.NavigationFlowPadding = new System.Windows.Forms.Padding(12, 0, 12, 0);
            this.dtCheckInDate.NavigationPanelBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(245)))), ((int)(((byte)(250)))));
            this.dtCheckInDate.NavigationPanelHeight = 65;
            this.dtCheckInDate.NextMonthPanelWidth = 34;
            this.dtCheckInDate.NextYearPanelWidth = 40;
            this.dtCheckInDate.PlaceholderText = "Select initial start date...";
            this.dtCheckInDate.PrevMonthPanelWidth = 34;
            this.dtCheckInDate.PrevYearPanelWidth = 40;
            this.dtCheckInDate.RangeStartEndCornerRadius = 0;
            this.dtCheckInDate.ReadonlyBorderColor = System.Drawing.Color.Gray;
            this.dtCheckInDate.ReadonlyFillColor = System.Drawing.Color.LightGray;
            this.dtCheckInDate.ReadOnlyForeColor = System.Drawing.Color.DarkGray;
            this.dtCheckInDate.ReadonlyPlaceHolderColor = System.Drawing.Color.DarkGray;
            this.dtCheckInDate.SelectedDate = null;
            this.dtCheckInDate.SelectedDateBorderColor = System.Drawing.Color.Black;
            this.dtCheckInDate.SelectedDateBorderThickness = 1F;
            this.dtCheckInDate.SelectedDates = ((System.Collections.Generic.List<System.DateTime>)(resources.GetObject("dtCheckInDate.SelectedDates")));
            this.dtCheckInDate.SelectionMode = SiticoneNetFrameworkUI.SelectionMode.Single;
            this.dtCheckInDate.ShakeAmplitude = 4;
            this.dtCheckInDate.ShakeTimerInterval = 30;
            this.dtCheckInDate.ShakeTotalShakes = 8;
            this.dtCheckInDate.ShowClearButton = false;
            this.dtCheckInDate.ShowMonthYearNavigation = true;
            this.dtCheckInDate.ShowTodayButton = true;
            this.dtCheckInDate.Size = new System.Drawing.Size(328, 46);
            this.dtCheckInDate.TabIndex = 13;
            this.dtCheckInDate.Text = "dtCheckInDate";
            this.dtCheckInDate.TodayBorderColor = System.Drawing.Color.Black;
            this.dtCheckInDate.TodayBorderThickness = 2F;
            this.dtCheckInDate.TodayButtonBackColor = System.Drawing.Color.Black;
            this.dtCheckInDate.TodayButtonBorderRadius = 0;
            this.dtCheckInDate.TodayButtonClickBackColor = System.Drawing.Color.Black;
            this.dtCheckInDate.TodayButtonFont = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.dtCheckInDate.TodayButtonForeColor = System.Drawing.Color.White;
            this.dtCheckInDate.TodayButtonHoverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.dtCheckInDate.TodayButtonMargin = new System.Windows.Forms.Padding(0, 17, 15, 0);
            this.dtCheckInDate.TodayButtonSize = new System.Drawing.Size(70, 35);
            this.dtCheckInDate.TodayButtonText = "Today";
            this.dtCheckInDate.TodayTextColor = System.Drawing.Color.Black;
            this.dtCheckInDate.TodayTextFont = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.dtCheckInDate.TopLeftBorderRadius = 8;
            this.dtCheckInDate.TopRightBorderRadius = 8;
            this.dtCheckInDate.UseCalendarFormAnimation = true;
            this.dtCheckInDate.UseCalendarFormShadow = true;
            this.dtCheckInDate.UseChevronAnimation = true;
            this.dtCheckInDate.UseGradientFill = false;
            this.dtCheckInDate.Value = null;
            this.dtCheckInDate.WeekendDayBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.dtCheckInDate.WeekendDayForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.dtCheckInDate.YearChevronPanelMargin = new System.Windows.Forms.Padding(4, 17, 4, 0);
            this.dtCheckInDate.YearChevronSpacing = 1;
            this.dtCheckInDate.YearComboBoxMargin = new System.Windows.Forms.Padding(5, 17, 0, 0);
            this.dtCheckInDate.YearComboBoxSize = new System.Drawing.Size(90, 30);
            this.dtCheckInDate.ValueChanged += new System.EventHandler(this.dtCheckInDate_ValueChanged);
            this.dtCheckInDate.Validating += new System.ComponentModel.CancelEventHandler(this.dtCheckInDate_Validating);
            // 
            // lblTitle
            // 
            this.lblTitle.BackColor = System.Drawing.Color.Transparent;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI Black", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.Maroon;
            this.lblTitle.Location = new System.Drawing.Point(265, 9);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(428, 45);
            this.lblTitle.TabIndex = 23;
            this.lblTitle.Text = "Add New Reservation";
            // 
            // siticoneLabel2
            // 
            this.siticoneLabel2.BackColor = System.Drawing.Color.Transparent;
            this.siticoneLabel2.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.siticoneLabel2.ForeColor = System.Drawing.Color.Maroon;
            this.siticoneLabel2.Location = new System.Drawing.Point(25, 70);
            this.siticoneLabel2.Name = "siticoneLabel2";
            this.siticoneLabel2.Size = new System.Drawing.Size(159, 25);
            this.siticoneLabel2.TabIndex = 25;
            this.siticoneLabel2.Text = "Reservation ID:";
            // 
            // dtCheckOutDate
            // 
            this.dtCheckOutDate.AutoScaleFonts = true;
            this.dtCheckOutDate.BackColor = System.Drawing.Color.Transparent;
            this.dtCheckOutDate.BaseCalendarFormSize = new System.Drawing.Size(535, 460);
            this.dtCheckOutDate.BorderColor = System.Drawing.Color.Silver;
            this.dtCheckOutDate.BorderWidth = 2;
            this.dtCheckOutDate.BottomLeftBorderRadius = 8;
            this.dtCheckOutDate.BottomRightBorderRadius = 8;
            this.dtCheckOutDate.CalendarBackgroundColor = System.Drawing.Color.White;
            this.dtCheckOutDate.CalendarChevronColor = System.Drawing.Color.Gray;
            this.dtCheckOutDate.CalendarChevronHoverColor = System.Drawing.Color.Blue;
            this.dtCheckOutDate.CalendarDayButtonBackColor = System.Drawing.Color.White;
            this.dtCheckOutDate.CalendarDayButtonForeColor = System.Drawing.Color.Black;
            this.dtCheckOutDate.CalendarDayHeaderBackColor = System.Drawing.Color.White;
            this.dtCheckOutDate.CalendarDayHeaderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.dtCheckOutDate.CalendarDayLabelFont = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.dtCheckOutDate.CalendarDisabledDateBackColor = System.Drawing.Color.LightGray;
            this.dtCheckOutDate.CalendarDisabledDateForeColor = System.Drawing.Color.DarkGray;
            this.dtCheckOutDate.CalendarFormAnimationSpeed = 15;
            this.dtCheckOutDate.CalendarFormAnimationStep = 0.08D;
            this.dtCheckOutDate.CalendarFormBackColor = System.Drawing.Color.White;
            this.dtCheckOutDate.CalendarFormBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.dtCheckOutDate.CalendarFormBorderWidth = 2;
            this.dtCheckOutDate.CalendarFormCornerRadius = 2;
            this.dtCheckOutDate.CalendarFormFadeOutStep = 0.1D;
            this.dtCheckOutDate.CalendarFormHeight = 360;
            this.dtCheckOutDate.CalendarFormShadowColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.dtCheckOutDate.CalendarFormShadowDepth = 5;
            this.dtCheckOutDate.CalendarFormWidth = 380;
            this.dtCheckOutDate.CalendarGridMargin = new System.Windows.Forms.Padding(8);
            this.dtCheckOutDate.CalendarGridPadding = new System.Windows.Forms.Padding(5);
            this.dtCheckOutDate.CalendarLockedDateBackColor = System.Drawing.Color.LightGray;
            this.dtCheckOutDate.CalendarLockedDateForeColor = System.Drawing.Color.DarkGray;
            this.dtCheckOutDate.CalendarLockedDates = ((System.Collections.Generic.List<System.DateTime>)(resources.GetObject("dtCheckOutDate.CalendarLockedDates")));
            this.dtCheckOutDate.CalendarMargin = 5;
            this.dtCheckOutDate.CalendarMaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dtCheckOutDate.CalendarMaxYear = 2126;
            this.dtCheckOutDate.CalendarMinDate = new System.DateTime(((long)(0)));
            this.dtCheckOutDate.CalendarMinYear = 1926;
            this.dtCheckOutDate.CalendarRangeDateBackColor = System.Drawing.Color.LightBlue;
            this.dtCheckOutDate.CalendarRangeEndDateBackColor = System.Drawing.Color.DodgerBlue;
            this.dtCheckOutDate.CalendarRangeSelectedForeColor = System.Drawing.Color.Black;
            this.dtCheckOutDate.CalendarRangeStartDateBackColor = System.Drawing.Color.DodgerBlue;
            this.dtCheckOutDate.CalendarSelectedDateBackColor = System.Drawing.Color.Black;
            this.dtCheckOutDate.CalendarSelectedDateForeColor = System.Drawing.Color.White;
            this.dtCheckOutDate.CalendarSelectionMode = SiticoneNetFrameworkUI.SelectionMode.Single;
            this.dtCheckOutDate.CalendarTodayBackColor = System.Drawing.Color.White;
            this.dtCheckOutDate.CalendarTodayForeColor = System.Drawing.Color.Black;
            this.dtCheckOutDate.CalendarYearPickerHeight = 10;
            this.dtCheckOutDate.CanBeep = true;
            this.dtCheckOutDate.CanShake = true;
            this.dtCheckOutDate.ChevronColor = System.Drawing.Color.Maroon;
            this.dtCheckOutDate.ChevronHoverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(225)))), ((int)(((byte)(245)))));
            this.dtCheckOutDate.ChevronHoverColor = System.Drawing.Color.Black;
            this.dtCheckOutDate.ChevronPanelBorderRadius = 0;
            this.dtCheckOutDate.ChevronPanelHeight = 32;
            this.dtCheckOutDate.ChevronPenThickness = 1.8F;
            this.dtCheckOutDate.ChevronRightMargin = 18;
            this.dtCheckOutDate.ChevronSize = new System.Drawing.Size(9, 14);
            this.dtCheckOutDate.ChevronStep = 15F;
            this.dtCheckOutDate.ChevronTimerInterval = 15;
            this.dtCheckOutDate.ClearIconColor = System.Drawing.Color.Gray;
            this.dtCheckOutDate.ClearIconHoverColor = System.Drawing.Color.Red;
            this.dtCheckOutDate.ClearIconRightMargin = 48;
            this.dtCheckOutDate.ClearIconSize = 11;
            this.dtCheckOutDate.ContainerPanelMargin = new System.Windows.Forms.Padding(5);
            this.dtCheckOutDate.ContainerPanelPadding = new System.Windows.Forms.Padding(0);
            this.dtCheckOutDate.CustomDateFormat = "d";
            this.dtCheckOutDate.CustomDateFormatter = null;
            this.dtCheckOutDate.DateFormat = SiticoneNetFrameworkUI.DateFormat.ShortDate;
            this.dtCheckOutDate.DayButtonBorderRadius = 0;
            this.dtCheckOutDate.DayButtonClickBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(230)))), ((int)(((byte)(250)))));
            this.dtCheckOutDate.DayButtonFont = new System.Drawing.Font("Segoe UI", 10.5F);
            this.dtCheckOutDate.DayButtonHoverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(240)))), ((int)(((byte)(255)))));
            this.dtCheckOutDate.DayButtonHoverForeColor = System.Drawing.Color.Black;
            this.dtCheckOutDate.DayButtonMargin = new System.Windows.Forms.Padding(3);
            this.dtCheckOutDate.DayButtonRowHeight = 16.66F;
            this.dtCheckOutDate.DayHeaderFont = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.dtCheckOutDate.DayHeaderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.dtCheckOutDate.DayHeaderMargin = new System.Windows.Forms.Padding(1, 1, 1, 8);
            this.dtCheckOutDate.DayHeaderRowHeight = 30F;
            this.dtCheckOutDate.DisabledDayFont = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Italic);
            this.dtCheckOutDate.DropdownBackColor = System.Drawing.Color.White;
            this.dtCheckOutDate.DropdownFont = new System.Drawing.Font("Segoe UI", 11F);
            this.dtCheckOutDate.DropdownHeight = 250;
            this.dtCheckOutDate.FillColor = System.Drawing.Color.White;
            this.dtCheckOutDate.FirstDayOfWeek = System.DayOfWeek.Sunday;
            this.dtCheckOutDate.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.dtCheckOutDate.ForeColor = System.Drawing.Color.DimGray;
            this.dtCheckOutDate.GradientEndColor = System.Drawing.Color.Gray;
            this.dtCheckOutDate.GradientStartColor = System.Drawing.Color.White;
            this.dtCheckOutDate.HighlightWeekends = true;
            this.dtCheckOutDate.IconSize = 16;
            this.dtCheckOutDate.IsReadonly = false;
            this.dtCheckOutDate.Location = new System.Drawing.Point(23, 126);
            this.dtCheckOutDate.LockedDates = ((System.Collections.Generic.List<System.DateTime>)(resources.GetObject("dtCheckOutDate.LockedDates")));
            this.dtCheckOutDate.MakeRadial = false;
            this.dtCheckOutDate.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dtCheckOutDate.MaxFontScale = 1.8F;
            this.dtCheckOutDate.MinDate = new System.DateTime(((long)(0)));
            this.dtCheckOutDate.MinFontScale = 0.4F;
            this.dtCheckOutDate.MinimumFormSize = new System.Drawing.Size(150, 150);
            this.dtCheckOutDate.MonthChevronPanelMargin = new System.Windows.Forms.Padding(4, 17, 4, 0);
            this.dtCheckOutDate.MonthChevronSpacing = 5;
            this.dtCheckOutDate.MonthComboBoxMargin = new System.Windows.Forms.Padding(0, 17, 5, 0);
            this.dtCheckOutDate.MonthComboBoxSize = new System.Drawing.Size(130, 30);
            this.dtCheckOutDate.Name = "dtCheckOutDate";
            this.dtCheckOutDate.NavigationFlowPadding = new System.Windows.Forms.Padding(12, 0, 12, 0);
            this.dtCheckOutDate.NavigationPanelBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(245)))), ((int)(((byte)(250)))));
            this.dtCheckOutDate.NavigationPanelHeight = 65;
            this.dtCheckOutDate.NextMonthPanelWidth = 34;
            this.dtCheckOutDate.NextYearPanelWidth = 40;
            this.dtCheckOutDate.PlaceholderText = "Select planned exit date...";
            this.dtCheckOutDate.PrevMonthPanelWidth = 34;
            this.dtCheckOutDate.PrevYearPanelWidth = 40;
            this.dtCheckOutDate.RangeStartEndCornerRadius = 0;
            this.dtCheckOutDate.ReadonlyBorderColor = System.Drawing.Color.Gray;
            this.dtCheckOutDate.ReadonlyFillColor = System.Drawing.Color.LightGray;
            this.dtCheckOutDate.ReadOnlyForeColor = System.Drawing.Color.DarkGray;
            this.dtCheckOutDate.ReadonlyPlaceHolderColor = System.Drawing.Color.DarkGray;
            this.dtCheckOutDate.SelectedDate = null;
            this.dtCheckOutDate.SelectedDateBorderColor = System.Drawing.Color.Black;
            this.dtCheckOutDate.SelectedDateBorderThickness = 1F;
            this.dtCheckOutDate.SelectedDates = ((System.Collections.Generic.List<System.DateTime>)(resources.GetObject("dtCheckOutDate.SelectedDates")));
            this.dtCheckOutDate.SelectionMode = SiticoneNetFrameworkUI.SelectionMode.Single;
            this.dtCheckOutDate.ShakeAmplitude = 4;
            this.dtCheckOutDate.ShakeTimerInterval = 30;
            this.dtCheckOutDate.ShakeTotalShakes = 8;
            this.dtCheckOutDate.ShowClearButton = false;
            this.dtCheckOutDate.ShowMonthYearNavigation = true;
            this.dtCheckOutDate.ShowTodayButton = true;
            this.dtCheckOutDate.Size = new System.Drawing.Size(328, 46);
            this.dtCheckOutDate.TabIndex = 28;
            this.dtCheckOutDate.TodayBorderColor = System.Drawing.Color.Black;
            this.dtCheckOutDate.TodayBorderThickness = 2F;
            this.dtCheckOutDate.TodayButtonBackColor = System.Drawing.Color.Black;
            this.dtCheckOutDate.TodayButtonBorderRadius = 0;
            this.dtCheckOutDate.TodayButtonClickBackColor = System.Drawing.Color.Black;
            this.dtCheckOutDate.TodayButtonFont = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.dtCheckOutDate.TodayButtonForeColor = System.Drawing.Color.White;
            this.dtCheckOutDate.TodayButtonHoverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.dtCheckOutDate.TodayButtonMargin = new System.Windows.Forms.Padding(0, 17, 15, 0);
            this.dtCheckOutDate.TodayButtonSize = new System.Drawing.Size(70, 35);
            this.dtCheckOutDate.TodayButtonText = "Today";
            this.dtCheckOutDate.TodayTextColor = System.Drawing.Color.Black;
            this.dtCheckOutDate.TodayTextFont = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.dtCheckOutDate.TopLeftBorderRadius = 8;
            this.dtCheckOutDate.TopRightBorderRadius = 8;
            this.dtCheckOutDate.UseCalendarFormAnimation = true;
            this.dtCheckOutDate.UseCalendarFormShadow = true;
            this.dtCheckOutDate.UseChevronAnimation = true;
            this.dtCheckOutDate.UseGradientFill = false;
            this.dtCheckOutDate.Value = null;
            this.dtCheckOutDate.WeekendDayBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.dtCheckOutDate.WeekendDayForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.dtCheckOutDate.YearChevronPanelMargin = new System.Windows.Forms.Padding(4, 17, 4, 0);
            this.dtCheckOutDate.YearChevronSpacing = 1;
            this.dtCheckOutDate.YearComboBoxMargin = new System.Windows.Forms.Padding(5, 17, 0, 0);
            this.dtCheckOutDate.YearComboBoxSize = new System.Drawing.Size(90, 30);
            this.dtCheckOutDate.ValueChanged += new System.EventHandler(this.dtCheckOutDate_ValueChanged);
            this.dtCheckOutDate.Validating += new System.ComponentModel.CancelEventHandler(this.dtCheckOutDate_Validating);
            // 
            // lblInitialTotalDueAmount
            // 
            this.lblInitialTotalDueAmount.BackColor = System.Drawing.Color.Transparent;
            this.lblInitialTotalDueAmount.Font = new System.Drawing.Font("Segoe UI Black", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInitialTotalDueAmount.ForeColor = System.Drawing.Color.Maroon;
            this.lblInitialTotalDueAmount.Location = new System.Drawing.Point(424, 328);
            this.lblInitialTotalDueAmount.Name = "lblInitialTotalDueAmount";
            this.lblInitialTotalDueAmount.Size = new System.Drawing.Size(311, 45);
            this.lblInitialTotalDueAmount.TabIndex = 35;
            this.lblInitialTotalDueAmount.Text = "0.00$";
            // 
            // siticoneLabel1
            // 
            this.siticoneLabel1.BackColor = System.Drawing.Color.Transparent;
            this.siticoneLabel1.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.siticoneLabel1.ForeColor = System.Drawing.Color.Maroon;
            this.siticoneLabel1.Location = new System.Drawing.Point(397, 266);
            this.siticoneLabel1.Name = "siticoneLabel1";
            this.siticoneLabel1.Size = new System.Drawing.Size(195, 53);
            this.siticoneLabel1.TabIndex = 36;
            this.siticoneLabel1.Text = "Total Cost:";
            // 
            // tpReservationData
            // 
            this.tpReservationData.Controls.Add(this.tpGuest);
            this.tpReservationData.Controls.Add(this.tpRoom);
            this.tpReservationData.Controls.Add(this.tpReservation);
            this.tpReservationData.ItemSize = new System.Drawing.Size(160, 50);
            this.tpReservationData.Location = new System.Drawing.Point(25, 116);
            this.tpReservationData.Name = "tpReservationData";
            this.tpReservationData.SelectedIndex = 0;
            this.tpReservationData.Size = new System.Drawing.Size(864, 672);
            this.tpReservationData.TabButtonHoverState.BorderColor = System.Drawing.Color.Empty;
            this.tpReservationData.TabButtonHoverState.FillColor = System.Drawing.Color.Silver;
            this.tpReservationData.TabButtonHoverState.Font = new System.Drawing.Font("Segoe UI Semibold", 10F);
            this.tpReservationData.TabButtonHoverState.ForeColor = System.Drawing.Color.White;
            this.tpReservationData.TabButtonHoverState.InnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(52)))), ((int)(((byte)(70)))));
            this.tpReservationData.TabButtonIdleState.BorderColor = System.Drawing.Color.Empty;
            this.tpReservationData.TabButtonIdleState.FillColor = System.Drawing.Color.Maroon;
            this.tpReservationData.TabButtonIdleState.Font = new System.Drawing.Font("Segoe UI Semibold", 10F);
            this.tpReservationData.TabButtonIdleState.ForeColor = System.Drawing.Color.Wheat;
            this.tpReservationData.TabButtonIdleState.InnerColor = System.Drawing.Color.Wheat;
            this.tpReservationData.TabButtonSelectedState.BorderColor = System.Drawing.Color.Empty;
            this.tpReservationData.TabButtonSelectedState.FillColor = System.Drawing.Color.Wheat;
            this.tpReservationData.TabButtonSelectedState.Font = new System.Drawing.Font("Segoe UI Semibold", 10F);
            this.tpReservationData.TabButtonSelectedState.ForeColor = System.Drawing.Color.Maroon;
            this.tpReservationData.TabButtonSelectedState.InnerColor = System.Drawing.Color.Wheat;
            this.tpReservationData.TabButtonSize = new System.Drawing.Size(160, 50);
            this.tpReservationData.TabIndex = 37;
            this.tpReservationData.TabMenuBackColor = System.Drawing.Color.Maroon;
            this.tpReservationData.TabMenuOrientation = Guna.UI2.WinForms.TabMenuOrientation.HorizontalTop;
            // 
            // tpGuest
            // 
            this.tpGuest.BackColor = System.Drawing.Color.AntiqueWhite;
            this.tpGuest.Controls.Add(this.btnNextToRoomPage);
            this.tpGuest.Controls.Add(this.ctrlCustomerDataWithFilter2);
            this.tpGuest.ForeColor = System.Drawing.SystemColors.ControlText;
            this.tpGuest.Location = new System.Drawing.Point(4, 54);
            this.tpGuest.Name = "tpGuest";
            this.tpGuest.Padding = new System.Windows.Forms.Padding(3);
            this.tpGuest.Size = new System.Drawing.Size(856, 614);
            this.tpGuest.TabIndex = 0;
            this.tpGuest.Text = "Guest Data";
            // 
            // btnNextToRoomPage
            // 
            this.btnNextToRoomPage.BackColor = System.Drawing.Color.Transparent;
            this.btnNextToRoomPage.BadgeBackColor = System.Drawing.Color.Red;
            this.btnNextToRoomPage.BadgeForeColor = System.Drawing.Color.White;
            this.btnNextToRoomPage.BadgeRadius = 8;
            this.btnNextToRoomPage.BadgeRightMargin = 10;
            this.btnNextToRoomPage.BadgeValue = 0;
            this.btnNextToRoomPage.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnNextToRoomPage.BorderColorEnd = System.Drawing.Color.Gray;
            this.btnNextToRoomPage.BorderColorStart = System.Drawing.Color.White;
            this.btnNextToRoomPage.BorderRadiusBottomLeft = 10;
            this.btnNextToRoomPage.BorderRadiusBottomRight = 10;
            this.btnNextToRoomPage.BorderRadiusTopLeft = 10;
            this.btnNextToRoomPage.BorderRadiusTopRight = 10;
            this.btnNextToRoomPage.BorderThickness = 1;
            this.btnNextToRoomPage.ButtonColorEnd = System.Drawing.Color.Brown;
            this.btnNextToRoomPage.ButtonColorStart = System.Drawing.Color.Maroon;
            this.btnNextToRoomPage.ButtonImage = null;
            this.btnNextToRoomPage.CanBeep = false;
            this.btnNextToRoomPage.CanShake = false;
            this.btnNextToRoomPage.ClickSoundPath = null;
            this.btnNextToRoomPage.DisabledOverlayOpacity = 0.5F;
            this.btnNextToRoomPage.EnableBorderGradient = false;
            this.btnNextToRoomPage.EnableClickSound = false;
            this.btnNextToRoomPage.EnableFocusBorder = false;
            this.btnNextToRoomPage.EnableHoverSound = false;
            this.btnNextToRoomPage.EnablePressScale = false;
            this.btnNextToRoomPage.EnableTextShadow = false;
            this.btnNextToRoomPage.FocusBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(150)))), ((int)(((byte)(255)))));
            this.btnNextToRoomPage.FocusBorderThickness = 2;
            this.btnNextToRoomPage.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNextToRoomPage.ForeColor = System.Drawing.Color.Wheat;
            this.btnNextToRoomPage.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnNextToRoomPage.HoverSoundPath = null;
            this.btnNextToRoomPage.HoverTransitionSpeed = 0.08F;
            this.btnNextToRoomPage.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNextToRoomPage.ImageLeftMargin = 5;
            this.btnNextToRoomPage.ImageRightMargin = 8;
            this.btnNextToRoomPage.ImageSize = 24;
            this.btnNextToRoomPage.IsReadOnly = false;
            this.btnNextToRoomPage.Location = new System.Drawing.Point(493, 554);
            this.btnNextToRoomPage.MakeRadial = false;
            this.btnNextToRoomPage.Name = "btnNextToRoomPage";
            this.btnNextToRoomPage.PressAnimationSpeed = 0.2F;
            this.btnNextToRoomPage.PressDepth = 1;
            this.btnNextToRoomPage.RippleColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnNextToRoomPage.RippleExpandSpeedFactor = 0.05F;
            this.btnNextToRoomPage.RippleFadeSpeedFactor = 0.03F;
            this.btnNextToRoomPage.ShadowBlurFactor = 0.85F;
            this.btnNextToRoomPage.ShadowColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnNextToRoomPage.ShadowOffsetX = 3;
            this.btnNextToRoomPage.ShadowOffsetY = 3;
            this.btnNextToRoomPage.Size = new System.Drawing.Size(199, 44);
            this.btnNextToRoomPage.TabIndex = 35;
            this.btnNextToRoomPage.Text = "Next >";
            this.btnNextToRoomPage.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnNextToRoomPage.TextPaddingBottom = 0;
            this.btnNextToRoomPage.TextPaddingLeft = 0;
            this.btnNextToRoomPage.TextPaddingRight = 0;
            this.btnNextToRoomPage.TextPaddingTop = 0;
            this.btnNextToRoomPage.TextShadowColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnNextToRoomPage.TextShadowOffsetX = 1;
            this.btnNextToRoomPage.TextShadowOffsetY = 1;
            this.btnNextToRoomPage.UltraPerformanceMode = true;
            this.btnNextToRoomPage.Click += new System.EventHandler(this.btnNextToRoomPage_Click);
            // 
            // ctrlCustomerDataWithFilter2
            // 
            this.ctrlCustomerDataWithFilter2.FilterEnabled = true;
            this.ctrlCustomerDataWithFilter2.Location = new System.Drawing.Point(133, 6);
            this.ctrlCustomerDataWithFilter2.Name = "ctrlCustomerDataWithFilter2";
            this.ctrlCustomerDataWithFilter2.ShowAddPerson = true;
            this.ctrlCustomerDataWithFilter2.Size = new System.Drawing.Size(595, 551);
            this.ctrlCustomerDataWithFilter2.TabIndex = 36;
            // 
            // tpRoom
            // 
            this.tpRoom.BackColor = System.Drawing.Color.AntiqueWhite;
            this.tpRoom.Controls.Add(this.btnBackToGuestPage);
            this.tpRoom.Controls.Add(this.siticoneButtonAdvanced4);
            this.tpRoom.Controls.Add(this.ctrlRoomDataWithFilter2);
            this.tpRoom.Location = new System.Drawing.Point(4, 54);
            this.tpRoom.Name = "tpRoom";
            this.tpRoom.Padding = new System.Windows.Forms.Padding(3);
            this.tpRoom.Size = new System.Drawing.Size(856, 614);
            this.tpRoom.TabIndex = 1;
            this.tpRoom.Text = "Room Data";
            // 
            // btnBackToGuestPage
            // 
            this.btnBackToGuestPage.BackColor = System.Drawing.Color.Transparent;
            this.btnBackToGuestPage.BadgeBackColor = System.Drawing.Color.Red;
            this.btnBackToGuestPage.BadgeForeColor = System.Drawing.Color.White;
            this.btnBackToGuestPage.BadgeRadius = 8;
            this.btnBackToGuestPage.BadgeRightMargin = 10;
            this.btnBackToGuestPage.BadgeValue = 0;
            this.btnBackToGuestPage.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnBackToGuestPage.BorderColorEnd = System.Drawing.Color.Gray;
            this.btnBackToGuestPage.BorderColorStart = System.Drawing.Color.White;
            this.btnBackToGuestPage.BorderRadiusBottomLeft = 10;
            this.btnBackToGuestPage.BorderRadiusBottomRight = 10;
            this.btnBackToGuestPage.BorderRadiusTopLeft = 10;
            this.btnBackToGuestPage.BorderRadiusTopRight = 10;
            this.btnBackToGuestPage.BorderThickness = 1;
            this.btnBackToGuestPage.ButtonColorEnd = System.Drawing.Color.Brown;
            this.btnBackToGuestPage.ButtonColorStart = System.Drawing.Color.Maroon;
            this.btnBackToGuestPage.ButtonImage = null;
            this.btnBackToGuestPage.CanBeep = false;
            this.btnBackToGuestPage.CanShake = false;
            this.btnBackToGuestPage.ClickSoundPath = null;
            this.btnBackToGuestPage.DisabledOverlayOpacity = 0.5F;
            this.btnBackToGuestPage.EnableBorderGradient = false;
            this.btnBackToGuestPage.EnableClickSound = false;
            this.btnBackToGuestPage.EnableFocusBorder = false;
            this.btnBackToGuestPage.EnableHoverSound = false;
            this.btnBackToGuestPage.EnablePressScale = false;
            this.btnBackToGuestPage.EnableTextShadow = false;
            this.btnBackToGuestPage.FocusBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(150)))), ((int)(((byte)(255)))));
            this.btnBackToGuestPage.FocusBorderThickness = 2;
            this.btnBackToGuestPage.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBackToGuestPage.ForeColor = System.Drawing.Color.Wheat;
            this.btnBackToGuestPage.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnBackToGuestPage.HoverSoundPath = null;
            this.btnBackToGuestPage.HoverTransitionSpeed = 0.08F;
            this.btnBackToGuestPage.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBackToGuestPage.ImageLeftMargin = 5;
            this.btnBackToGuestPage.ImageRightMargin = 8;
            this.btnBackToGuestPage.ImageSize = 24;
            this.btnBackToGuestPage.IsReadOnly = false;
            this.btnBackToGuestPage.Location = new System.Drawing.Point(99, 475);
            this.btnBackToGuestPage.MakeRadial = false;
            this.btnBackToGuestPage.Name = "btnBackToGuestPage";
            this.btnBackToGuestPage.PressAnimationSpeed = 0.2F;
            this.btnBackToGuestPage.PressDepth = 1;
            this.btnBackToGuestPage.RippleColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnBackToGuestPage.RippleExpandSpeedFactor = 0.05F;
            this.btnBackToGuestPage.RippleFadeSpeedFactor = 0.03F;
            this.btnBackToGuestPage.ShadowBlurFactor = 0.85F;
            this.btnBackToGuestPage.ShadowColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnBackToGuestPage.ShadowOffsetX = 3;
            this.btnBackToGuestPage.ShadowOffsetY = 3;
            this.btnBackToGuestPage.Size = new System.Drawing.Size(164, 47);
            this.btnBackToGuestPage.TabIndex = 38;
            this.btnBackToGuestPage.Text = "< Previous";
            this.btnBackToGuestPage.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnBackToGuestPage.TextPaddingBottom = 0;
            this.btnBackToGuestPage.TextPaddingLeft = 0;
            this.btnBackToGuestPage.TextPaddingRight = 0;
            this.btnBackToGuestPage.TextPaddingTop = 0;
            this.btnBackToGuestPage.TextShadowColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnBackToGuestPage.TextShadowOffsetX = 1;
            this.btnBackToGuestPage.TextShadowOffsetY = 1;
            this.btnBackToGuestPage.UltraPerformanceMode = true;
            this.btnBackToGuestPage.Click += new System.EventHandler(this.btnBackToGuestPage_Click);
            // 
            // siticoneButtonAdvanced4
            // 
            this.siticoneButtonAdvanced4.BackColor = System.Drawing.Color.Transparent;
            this.siticoneButtonAdvanced4.BadgeBackColor = System.Drawing.Color.Red;
            this.siticoneButtonAdvanced4.BadgeForeColor = System.Drawing.Color.White;
            this.siticoneButtonAdvanced4.BadgeRadius = 8;
            this.siticoneButtonAdvanced4.BadgeRightMargin = 10;
            this.siticoneButtonAdvanced4.BadgeValue = 0;
            this.siticoneButtonAdvanced4.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.siticoneButtonAdvanced4.BorderColorEnd = System.Drawing.Color.Gray;
            this.siticoneButtonAdvanced4.BorderColorStart = System.Drawing.Color.White;
            this.siticoneButtonAdvanced4.BorderRadiusBottomLeft = 10;
            this.siticoneButtonAdvanced4.BorderRadiusBottomRight = 10;
            this.siticoneButtonAdvanced4.BorderRadiusTopLeft = 10;
            this.siticoneButtonAdvanced4.BorderRadiusTopRight = 10;
            this.siticoneButtonAdvanced4.BorderThickness = 1;
            this.siticoneButtonAdvanced4.ButtonColorEnd = System.Drawing.Color.Brown;
            this.siticoneButtonAdvanced4.ButtonColorStart = System.Drawing.Color.Maroon;
            this.siticoneButtonAdvanced4.ButtonImage = null;
            this.siticoneButtonAdvanced4.CanBeep = false;
            this.siticoneButtonAdvanced4.CanShake = false;
            this.siticoneButtonAdvanced4.ClickSoundPath = null;
            this.siticoneButtonAdvanced4.DisabledOverlayOpacity = 0.5F;
            this.siticoneButtonAdvanced4.EnableBorderGradient = false;
            this.siticoneButtonAdvanced4.EnableClickSound = false;
            this.siticoneButtonAdvanced4.EnableFocusBorder = false;
            this.siticoneButtonAdvanced4.EnableHoverSound = false;
            this.siticoneButtonAdvanced4.EnablePressScale = false;
            this.siticoneButtonAdvanced4.EnableTextShadow = false;
            this.siticoneButtonAdvanced4.FocusBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(150)))), ((int)(((byte)(255)))));
            this.siticoneButtonAdvanced4.FocusBorderThickness = 2;
            this.siticoneButtonAdvanced4.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.siticoneButtonAdvanced4.ForeColor = System.Drawing.Color.Wheat;
            this.siticoneButtonAdvanced4.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.siticoneButtonAdvanced4.HoverSoundPath = null;
            this.siticoneButtonAdvanced4.HoverTransitionSpeed = 0.08F;
            this.siticoneButtonAdvanced4.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.siticoneButtonAdvanced4.ImageLeftMargin = 5;
            this.siticoneButtonAdvanced4.ImageRightMargin = 8;
            this.siticoneButtonAdvanced4.ImageSize = 24;
            this.siticoneButtonAdvanced4.IsReadOnly = false;
            this.siticoneButtonAdvanced4.Location = new System.Drawing.Point(595, 475);
            this.siticoneButtonAdvanced4.MakeRadial = false;
            this.siticoneButtonAdvanced4.Name = "siticoneButtonAdvanced4";
            this.siticoneButtonAdvanced4.PressAnimationSpeed = 0.2F;
            this.siticoneButtonAdvanced4.PressDepth = 1;
            this.siticoneButtonAdvanced4.RippleColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.siticoneButtonAdvanced4.RippleExpandSpeedFactor = 0.05F;
            this.siticoneButtonAdvanced4.RippleFadeSpeedFactor = 0.03F;
            this.siticoneButtonAdvanced4.ShadowBlurFactor = 0.85F;
            this.siticoneButtonAdvanced4.ShadowColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.siticoneButtonAdvanced4.ShadowOffsetX = 3;
            this.siticoneButtonAdvanced4.ShadowOffsetY = 3;
            this.siticoneButtonAdvanced4.Size = new System.Drawing.Size(164, 47);
            this.siticoneButtonAdvanced4.TabIndex = 37;
            this.siticoneButtonAdvanced4.Text = "Next >";
            this.siticoneButtonAdvanced4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.siticoneButtonAdvanced4.TextPaddingBottom = 0;
            this.siticoneButtonAdvanced4.TextPaddingLeft = 0;
            this.siticoneButtonAdvanced4.TextPaddingRight = 0;
            this.siticoneButtonAdvanced4.TextPaddingTop = 0;
            this.siticoneButtonAdvanced4.TextShadowColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.siticoneButtonAdvanced4.TextShadowOffsetX = 1;
            this.siticoneButtonAdvanced4.TextShadowOffsetY = 1;
            this.siticoneButtonAdvanced4.UltraPerformanceMode = true;
            this.siticoneButtonAdvanced4.Click += new System.EventHandler(this.btnNextToReservationPage_Click);
            // 
            // ctrlRoomDataWithFilter2
            // 
            this.ctrlRoomDataWithFilter2.EnableAddRoom = true;
            this.ctrlRoomDataWithFilter2.FilterEnabled = true;
            this.ctrlRoomDataWithFilter2.Location = new System.Drawing.Point(81, 112);
            this.ctrlRoomDataWithFilter2.Name = "ctrlRoomDataWithFilter2";
            this.ctrlRoomDataWithFilter2.Size = new System.Drawing.Size(695, 343);
            this.ctrlRoomDataWithFilter2.TabIndex = 35;
            // 
            // tpReservation
            // 
            this.tpReservation.BackColor = System.Drawing.Color.AntiqueWhite;
            this.tpReservation.Controls.Add(this.siticoneButtonAdvanced5);
            this.tpReservation.Controls.Add(this.btnSave);
            this.tpReservation.Controls.Add(this.siticoneGroupBox1);
            this.tpReservation.Location = new System.Drawing.Point(4, 54);
            this.tpReservation.Name = "tpReservation";
            this.tpReservation.Size = new System.Drawing.Size(856, 614);
            this.tpReservation.TabIndex = 2;
            this.tpReservation.Text = "Reservation Data";
            // 
            // siticoneButtonAdvanced5
            // 
            this.siticoneButtonAdvanced5.BackColor = System.Drawing.Color.Transparent;
            this.siticoneButtonAdvanced5.BadgeBackColor = System.Drawing.Color.Red;
            this.siticoneButtonAdvanced5.BadgeForeColor = System.Drawing.Color.White;
            this.siticoneButtonAdvanced5.BadgeRadius = 8;
            this.siticoneButtonAdvanced5.BadgeRightMargin = 10;
            this.siticoneButtonAdvanced5.BadgeValue = 0;
            this.siticoneButtonAdvanced5.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.siticoneButtonAdvanced5.BorderColorEnd = System.Drawing.Color.Gray;
            this.siticoneButtonAdvanced5.BorderColorStart = System.Drawing.Color.White;
            this.siticoneButtonAdvanced5.BorderRadiusBottomLeft = 10;
            this.siticoneButtonAdvanced5.BorderRadiusBottomRight = 10;
            this.siticoneButtonAdvanced5.BorderRadiusTopLeft = 10;
            this.siticoneButtonAdvanced5.BorderRadiusTopRight = 10;
            this.siticoneButtonAdvanced5.BorderThickness = 1;
            this.siticoneButtonAdvanced5.ButtonColorEnd = System.Drawing.Color.Brown;
            this.siticoneButtonAdvanced5.ButtonColorStart = System.Drawing.Color.Maroon;
            this.siticoneButtonAdvanced5.ButtonImage = null;
            this.siticoneButtonAdvanced5.CanBeep = false;
            this.siticoneButtonAdvanced5.CanShake = false;
            this.siticoneButtonAdvanced5.ClickSoundPath = null;
            this.siticoneButtonAdvanced5.DisabledOverlayOpacity = 0.5F;
            this.siticoneButtonAdvanced5.EnableBorderGradient = false;
            this.siticoneButtonAdvanced5.EnableClickSound = false;
            this.siticoneButtonAdvanced5.EnableFocusBorder = false;
            this.siticoneButtonAdvanced5.EnableHoverSound = false;
            this.siticoneButtonAdvanced5.EnablePressScale = false;
            this.siticoneButtonAdvanced5.EnableTextShadow = false;
            this.siticoneButtonAdvanced5.FocusBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(150)))), ((int)(((byte)(255)))));
            this.siticoneButtonAdvanced5.FocusBorderThickness = 2;
            this.siticoneButtonAdvanced5.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.siticoneButtonAdvanced5.ForeColor = System.Drawing.Color.Wheat;
            this.siticoneButtonAdvanced5.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.siticoneButtonAdvanced5.HoverSoundPath = null;
            this.siticoneButtonAdvanced5.HoverTransitionSpeed = 0.08F;
            this.siticoneButtonAdvanced5.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.siticoneButtonAdvanced5.ImageLeftMargin = 5;
            this.siticoneButtonAdvanced5.ImageRightMargin = 8;
            this.siticoneButtonAdvanced5.ImageSize = 24;
            this.siticoneButtonAdvanced5.IsReadOnly = false;
            this.siticoneButtonAdvanced5.Location = new System.Drawing.Point(75, 487);
            this.siticoneButtonAdvanced5.MakeRadial = false;
            this.siticoneButtonAdvanced5.Name = "siticoneButtonAdvanced5";
            this.siticoneButtonAdvanced5.PressAnimationSpeed = 0.2F;
            this.siticoneButtonAdvanced5.PressDepth = 1;
            this.siticoneButtonAdvanced5.RippleColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.siticoneButtonAdvanced5.RippleExpandSpeedFactor = 0.05F;
            this.siticoneButtonAdvanced5.RippleFadeSpeedFactor = 0.03F;
            this.siticoneButtonAdvanced5.ShadowBlurFactor = 0.85F;
            this.siticoneButtonAdvanced5.ShadowColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.siticoneButtonAdvanced5.ShadowOffsetX = 3;
            this.siticoneButtonAdvanced5.ShadowOffsetY = 3;
            this.siticoneButtonAdvanced5.Size = new System.Drawing.Size(164, 47);
            this.siticoneButtonAdvanced5.TabIndex = 40;
            this.siticoneButtonAdvanced5.Text = "< Previous";
            this.siticoneButtonAdvanced5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.siticoneButtonAdvanced5.TextPaddingBottom = 0;
            this.siticoneButtonAdvanced5.TextPaddingLeft = 0;
            this.siticoneButtonAdvanced5.TextPaddingRight = 0;
            this.siticoneButtonAdvanced5.TextPaddingTop = 0;
            this.siticoneButtonAdvanced5.TextShadowColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.siticoneButtonAdvanced5.TextShadowOffsetX = 1;
            this.siticoneButtonAdvanced5.TextShadowOffsetY = 1;
            this.siticoneButtonAdvanced5.UltraPerformanceMode = true;
            this.siticoneButtonAdvanced5.Click += new System.EventHandler(this.btnBackToRoomPage_Click);
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
            this.btnSave.Location = new System.Drawing.Point(629, 487);
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
            this.btnSave.Size = new System.Drawing.Size(164, 47);
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
            this.siticoneGroupBox1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(222)))), ((int)(((byte)(224)))));
            this.siticoneGroupBox1.BorderWidth = 1F;
            this.siticoneGroupBox1.ChevronColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(90)))), ((int)(((byte)(90)))));
            this.siticoneGroupBox1.ChevronLeftSpacing = 4F;
            this.siticoneGroupBox1.ChevronSize = 10F;
            this.siticoneGroupBox1.ChevronThickness = 2F;
            this.siticoneGroupBox1.ContentPadding = 5;
            this.siticoneGroupBox1.Controls.Add(this.siticoneLabel1);
            this.siticoneGroupBox1.Controls.Add(this.lblInitialReservationDays);
            this.siticoneGroupBox1.Controls.Add(this.dtCheckOutDate);
            this.siticoneGroupBox1.Controls.Add(this.dtCheckInDate);
            this.siticoneGroupBox1.Controls.Add(this.siticoneLabel3);
            this.siticoneGroupBox1.Controls.Add(this.txtNotes);
            this.siticoneGroupBox1.Controls.Add(this.lblInitialTotalDueAmount);
            this.siticoneGroupBox1.CornerRadius = 8;
            this.siticoneGroupBox1.EnableBlinking = false;
            this.siticoneGroupBox1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.siticoneGroupBox1.GradientEndColor = System.Drawing.Color.LightGray;
            this.siticoneGroupBox1.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.siticoneGroupBox1.GradientStartColor = System.Drawing.Color.White;
            this.siticoneGroupBox1.GroupTitle = "Reservation Data";
            this.siticoneGroupBox1.HoveredBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(215)))));
            this.siticoneGroupBox1.HoveredTitleColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(215)))));
            this.siticoneGroupBox1.Location = new System.Drawing.Point(75, 79);
            this.siticoneGroupBox1.MaxBlinkCount = 3;
            this.siticoneGroupBox1.Name = "siticoneGroupBox1";
            this.siticoneGroupBox1.PressedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(84)))), ((int)(((byte)(153)))));
            this.siticoneGroupBox1.ShadowColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.siticoneGroupBox1.ShadowDepth = 4;
            this.siticoneGroupBox1.ShowShadow = true;
            this.siticoneGroupBox1.Size = new System.Drawing.Size(718, 402);
            this.siticoneGroupBox1.SolidFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(249)))), ((int)(((byte)(249)))));
            this.siticoneGroupBox1.StatusIcon = null;
            this.siticoneGroupBox1.StatusText = "";
            this.siticoneGroupBox1.TabIndex = 37;
            this.siticoneGroupBox1.Text = "siticoneGroupBox1";
            this.siticoneGroupBox1.TitleBackColor = System.Drawing.Color.Transparent;
            this.siticoneGroupBox1.TitleColor = System.Drawing.Color.Maroon;
            this.siticoneGroupBox1.TitlePadding = new System.Windows.Forms.Padding(10, 8, 10, 12);
            this.siticoneGroupBox1.TitlePos = SiticoneNetFrameworkUI.TitlePosition.TopLeft;
            this.siticoneGroupBox1.UseGradient = true;
            // 
            // lblInitialReservationDays
            // 
            this.lblInitialReservationDays.BackColor = System.Drawing.Color.Transparent;
            this.lblInitialReservationDays.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInitialReservationDays.ForeColor = System.Drawing.Color.Black;
            this.lblInitialReservationDays.Location = new System.Drawing.Point(264, 206);
            this.lblInitialReservationDays.Name = "lblInitialReservationDays";
            this.lblInitialReservationDays.Size = new System.Drawing.Size(311, 45);
            this.lblInitialReservationDays.TabIndex = 38;
            this.lblInitialReservationDays.Text = "0 Days.";
            // 
            // siticoneLabel3
            // 
            this.siticoneLabel3.BackColor = System.Drawing.Color.Transparent;
            this.siticoneLabel3.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.siticoneLabel3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.siticoneLabel3.Location = new System.Drawing.Point(23, 206);
            this.siticoneLabel3.Name = "siticoneLabel3";
            this.siticoneLabel3.Size = new System.Drawing.Size(240, 31);
            this.siticoneLabel3.TabIndex = 37;
            this.siticoneLabel3.Text = "Initial Reservation Days:";
            // 
            // lblReservationID
            // 
            this.lblReservationID.BackColor = System.Drawing.Color.Transparent;
            this.lblReservationID.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblReservationID.ForeColor = System.Drawing.Color.Maroon;
            this.lblReservationID.Location = new System.Drawing.Point(190, 70);
            this.lblReservationID.Name = "lblReservationID";
            this.lblReservationID.Size = new System.Drawing.Size(88, 31);
            this.lblReservationID.TabIndex = 39;
            this.lblReservationID.Text = "-1";
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.Text = "notifyIcon1";
            this.notifyIcon1.Visible = true;
            // 
            // frmAddUpdateReservation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AntiqueWhite;
            this.ClientSize = new System.Drawing.Size(945, 790);
            this.Controls.Add(this.lblReservationID);
            this.Controls.Add(this.tpReservationData);
            this.Controls.Add(this.siticoneLabel2);
            this.Controls.Add(this.lblTitle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmAddUpdateReservation";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AddUpdateReservation";
            this.Load += new System.EventHandler(this.frmAddUpdateReservation_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.tpReservationData.ResumeLayout(false);
            this.tpGuest.ResumeLayout(false);
            this.tpRoom.ResumeLayout(false);
            this.tpReservation.ResumeLayout(false);
            this.siticoneGroupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private SiticoneNetFrameworkUI.SiticoneTextBoxAdvanced txtNotes;
        private SiticoneNetFrameworkUI.SiticoneDateTimePicker dtCheckInDate;
        private SiticoneNetFrameworkUI.SiticoneLabel lblTitle;
        private SiticoneNetFrameworkUI.SiticoneLabel siticoneLabel2;
        private SiticoneNetFrameworkUI.SiticoneDateTimePicker dtCheckOutDate;
        private SiticoneNetFrameworkUI.SiticoneLabel lblInitialTotalDueAmount;
        private SiticoneNetFrameworkUI.SiticoneLabel siticoneLabel1;
        private Guna.UI2.WinForms.Guna2TabControl tpReservationData;
        private System.Windows.Forms.TabPage tpGuest;
        private SiticoneNetFrameworkUI.SiticoneButtonAdvanced btnNextToRoomPage;
        private System.Windows.Forms.TabPage tpRoom;
        private System.Windows.Forms.TabPage tpReservation;
        private SiticoneNetFrameworkUI.SiticoneButtonAdvanced btnBackToGuestPage;
        private SiticoneNetFrameworkUI.SiticoneButtonAdvanced siticoneButtonAdvanced4;
        private ctrlRoomDataWithFilter ctrlRoomDataWithFilter2;
        private SiticoneNetFrameworkUI.SiticoneGroupBox siticoneGroupBox1;
        private SiticoneNetFrameworkUI.SiticoneButtonAdvanced siticoneButtonAdvanced5;
        private SiticoneNetFrameworkUI.SiticoneButtonAdvanced btnSave;
        private ctrlCustomerDataWithFilter ctrlCustomerDataWithFilter2;
        private SiticoneNetFrameworkUI.SiticoneLabel lblInitialReservationDays;
        private SiticoneNetFrameworkUI.SiticoneLabel siticoneLabel3;
        private SiticoneNetFrameworkUI.SiticoneLabel lblReservationID;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
    }
}