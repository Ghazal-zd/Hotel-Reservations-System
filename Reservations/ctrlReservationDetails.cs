using DVLD.Classes;
using HRS_BusinessLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hotel_Reservations_System
{
    public partial class ctrlReservationDetails : UserControl
    {
        private clsReservation _Reservation;
        private int _ReservationID = -1;

        public int ReservationID
        {
            get { return _ReservationID; }
        }

        public clsReservation SelectedReservationInfo
        {
            get { return _Reservation; }
        }
        public ctrlReservationDetails()
        {
            InitializeComponent();
        }
        private void _FillReservationInfo()
        {
            ctrlCustomerData1.LoadGuestInfo(_Reservation.CustomerID);
            ctrlRoomData1.LoadRoomData(_Reservation.RoomID);
            lblReservationID.Text = _Reservation.ReservationID.ToString();
            lblCheckInDate.Text = clsFormat.DateToShort(_Reservation.StartDate);
            lblCheckOutDate.Text = clsFormat.DateToShort(_Reservation.ExitDate);
            lblReservationDays.Text = _Reservation.InitialReservationDays.ToString();
            lblTotalAmountDue.Text = _Reservation.InitialTotalDueAmount.ToString();
            lblNotes.Text = _Reservation.InitialCheckNotes;

            DateTime actualCheckInDate = _Reservation.ActualCheckInDate ?? DateTime.Now;
            string actualCheckInDateText = (actualCheckInDate != DateTime.Now ? clsFormat.DateToShort(actualCheckInDate) : "Not check in yet!");
            lblActualCheckInDate.Text = actualCheckInDateText;

            lblReservationStatus.Text = _Reservation.ReservationStatusText;
            lblRoomPriceAtReservation.Text = _Reservation.RoomPriceAtReservation.ToString();

        }
        public void LoadReservationInformation(int ReservationID)
        {
            _Reservation = clsReservation.Find(ReservationID);
            if (_Reservation == null)
            {
                MessageBox.Show("No reservation with id = " + ReservationID, "Failed", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                return;
            }
            _ReservationID = ReservationID;
            _FillReservationInfo();  
        }
    }
}
