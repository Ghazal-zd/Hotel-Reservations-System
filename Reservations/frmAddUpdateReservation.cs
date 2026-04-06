using HRS_BusinessLayer;
using SiticoneNetFrameworkUI;
using System;
using System.ComponentModel;
using System.Drawing;
using System.Runtime.Remoting.Channels;
using System.Windows.Forms;

namespace Hotel_Reservations_System
{
    public partial class frmAddUpdateReservation : Form
    {
        enum enMode { AddNew = 1, Update = 2 };
        enMode _mode;

        int _ReservationID = -1;
        clsReservation _Reservation;

        int _initialReservationDays = 0;
        
        clsNotificationServices notificationService = new clsNotificationServices();
        public frmAddUpdateReservation()
        {
            InitializeComponent();
            _mode = enMode.AddNew;
            notificationService.OnNotificationReady += ShowNotifyIcon;
            clsReservationEvents.ReservationCreated += notificationService.OnReservationCreated;
        }
        public frmAddUpdateReservation(int reservationID)
        {
            InitializeComponent();
            _ReservationID = reservationID;
            _mode = enMode.Update;
        }    
        private void _ResetDefaultValues()
        {
            tpReservationData.SelectedTab = tpGuest;
            ctrlRoomDataWithFilter2.FilterEnabled = false;
            btnSave.Enabled = false;

            ctrlRoomDataWithFilter2.EnableAddRoom = (clsGlobal.currentEmployee.RoleID == clsRole.enRoles.Admin
                || clsGlobal.currentEmployee.RoleID == clsRole.enRoles.Manager);

            lblInitialReservationDays.Text = "0 Days.";
            lblInitialTotalDueAmount.Text = "0 $";

            DateTime now = DateTime.Now;      

            if (_mode == enMode.AddNew)
            {
                lblTitle.Text = "Add New Reservation";
                Text = "Add Reservation";
                dtCheckInDate.MinDate = now.AddDays(-1);
                dtCheckOutDate.MinDate = now;
                ctrlCustomerDataWithFilter2.FilterFocus();
                _Reservation = new clsReservation();
            }
            else
            {
                lblTitle.Text = "Update Reservation";
                Text = "Update Reservation";
                tpReservationData.SelectedTab = tpReservation;
                ctrlCustomerDataWithFilter2.FilterEnabled = false;
                btnSave.Enabled = true;
            }
        }
        private void _LoadReservationInfo()
        {
            _Reservation = clsReservation.Find(_ReservationID);

            if (_Reservation == null)
            {
                MessageBox.Show("No reservation with ID = " + _ReservationID, "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
                return;
            }

            ctrlCustomerDataWithFilter2.LoadGuestInformation(_Reservation.CustomerID);
            ctrlRoomDataWithFilter2.LoadRoomInfo(_Reservation.RoomID);
            dtCheckInDate.Value = _Reservation.StartDate;
            dtCheckOutDate.Value = _Reservation.ExitDate;
            lblInitialReservationDays.Text = _Reservation.InitialReservationDays.ToString() + " Days.";
            lblInitialTotalDueAmount.Text = _Reservation.InitialTotalDueAmount.ToString() + " $";
            txtNotes.Text = _Reservation.InitialCheckNotes;
            lblReservationID.Text = _Reservation.ReservationID.ToString();
        }
        private void frmAddUpdateReservation_Load(object sender, EventArgs e)
        {
            _ResetDefaultValues();

            if (_mode == enMode.Update)
            {
                _LoadReservationInfo();
            }
        }
        private void _CalculateReservationDays()
        {
            if (dtCheckInDate.Value == null || dtCheckOutDate.Value == null) { return; }

            DateTime checkInDate = (DateTime)dtCheckInDate.Value;
            DateTime checkOutDate = (DateTime)dtCheckOutDate.Value;

            int ReservationDays = (checkOutDate.Date - checkInDate.Date).Days;
            if (ReservationDays < 0)
            {
                _initialReservationDays = 0;
                lblInitialReservationDays.Text = $"{_initialReservationDays} Days.";
                return;
            }
            _initialReservationDays = ReservationDays;
            lblInitialReservationDays.Text = $"{_initialReservationDays} Days.";

            _CalculateTotalDueAmount();
        }
        private decimal CalculateTotalCost(decimal basePrice, decimal featuresPrice, int days)
        {
            return (basePrice + featuresPrice) * days;
        }
        private clsRoom _GetSelectedRoom()
        {

            if (_mode == enMode.Update && _Reservation != null)
                return _Reservation.RoomInfo;
            if (ctrlRoomDataWithFilter2.RoomID != -1)
                return clsRoom.Find(ctrlRoomDataWithFilter2.RoomID);

            return null;
        }
        private void _CalculateTotalDueAmount()
        {
            decimal BasePrice = 0, FeaturesPrice = 0, TotalCost = 0;
            int initialReservationDays = _initialReservationDays;

            clsRoom _Room = _GetSelectedRoom();
            if (_Room != null)
            {
                BasePrice = _Room.RoomFee;
                FeaturesPrice = _Room.GetTotalFeaturesCost();
            }
            TotalCost = CalculateTotalCost(BasePrice, FeaturesPrice, initialReservationDays);
            lblInitialTotalDueAmount.Text = $"{TotalCost} $";
        }
        private void _Save()
        {
            _Reservation.CustomerID = ctrlCustomerDataWithFilter2.CustomerID;
            _Reservation.RoomID = ctrlRoomDataWithFilter2.RoomID;
            _Reservation.StartDate = (DateTime)dtCheckInDate.Value;
            _Reservation.ExitDate = (DateTime)dtCheckOutDate.Value;
            _Reservation.InitialReservationDays = int.Parse(lblInitialReservationDays.Text.Split(' ')[0].Trim());
            _Reservation.InitialTotalDueAmount = decimal.Parse(lblInitialTotalDueAmount.Text.Split(' ')[0].Trim());
            _Reservation.InitialCheckNotes = txtNotes.Text;
            _Reservation.ReservationStatus = clsReservation.enReservationStatus.Reserved;
            _Reservation.RoomPriceAtReservation = ctrlRoomDataWithFilter2.SelectedRoom.RoomFee +
                                                 ctrlRoomDataWithFilter2.SelectedRoom.GetTotalFeaturesCost();

            if (_Reservation.IsOverlappingReservation())
            {
                MessageBox.Show("Sorry, Room " + _Reservation.RoomID + " has Reserved during this period!", "Failed",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!_Reservation.Save())
            {
                MessageBox.Show("Sorry, Something went wrong!", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (_mode == enMode.AddNew)
            {
                lblReservationID.Text = _Reservation.ReservationID.ToString();
                _mode = enMode.Update;
                lblTitle.Text = "Update Reservation";
                ctrlRoomDataWithFilter2.FilterEnabled = false;
                ctrlCustomerDataWithFilter2.FilterEnabled = false;
                btnSave.Enabled = false;
                return;
            }
        }
        private void dtCheckInDate_ValueChanged(object sender, EventArgs e)
        {
            if (dtCheckInDate.Value == null) { dtCheckInDate.Value = DateTime.Now; return; }

            dtCheckOutDate.MinDate = ((DateTime)dtCheckInDate.Value).AddDays(1);
            _CalculateReservationDays();
        }
        private void dtCheckOutDate_ValueChanged(object sender, EventArgs e)
        {
            _CalculateReservationDays();
        }
        public void ShowNotifyIcon(string title, string message, clsNotification.enNotificationType enNotificationType)
        {
            frmToast toast = new frmToast(title, message, enNotificationType);
            toast.Show(this);
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!this.ValidateChildren())
            {
                MessageBox.Show("Some fields are not valid!", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            _Save();
        }
        private void btnBackToGuestPage_Click(object sender, EventArgs e)
        {
            tpReservationData.SelectedTab = tpGuest;
        }
        private void btnNextToReservationPage_Click(object sender, EventArgs e)
        {
            if (ctrlRoomDataWithFilter2.SelectedRoom == null)
            {
                MessageBox.Show("Please select a room!", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            tpReservationData.SelectedTab = tpReservation;
            btnSave.Enabled = true;
        }
        private void btnNextToRoomPage_Click(object sender, EventArgs e)
        {
            if (ctrlCustomerDataWithFilter2.SelectedCustomer == null)
            {
                MessageBox.Show("Please select a customer first!", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            tpReservationData.SelectedTab = tpRoom;
            ctrlRoomDataWithFilter2.FilterEnabled = (_mode == enMode.AddNew) ? true : false;
        }
        private void dtCheckInDate_Validating(object sender, CancelEventArgs e)
        {
            if(dtCheckInDate.Value == null)
            {
                e.Cancel = true;
                errorProvider1.SetError(dtCheckInDate, "Please select a date!");
            }
            else
            {
                e.Cancel= false;
                errorProvider1.SetError(dtCheckInDate, null);
            }
        }
        private void dtCheckOutDate_Validating(object sender, CancelEventArgs e)
        {
            if (dtCheckOutDate.Value == null)
            {
                e.Cancel = true;
                errorProvider1.SetError(dtCheckOutDate, "Please select a date!");
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(dtCheckOutDate, null);
            }
        }
        private void btnBackToRoomPage_Click(object sender, EventArgs e)
        {
            tpReservationData.SelectedTab = tpRoom;
        }
    }
}