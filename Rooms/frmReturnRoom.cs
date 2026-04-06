using HRS_BusinessLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hotel_Reservations_System
{
    public partial class frmReturnRoom : Form
    {
        int _ReservationID = -1;

        public frmReturnRoom(int ReservationID)
        {
            InitializeComponent();
            _ReservationID = ReservationID;
        }
        private void frmReturnRoom_Load(object sender, EventArgs e)
        {
            clsReservation _Reservation = clsReservation.Find(_ReservationID);
            if (_Reservation == null)
            {
                MessageBox.Show("Sorry, something went wrong cause no reservation with id = " + _ReservationID, "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            ctrlReservationDetails1.LoadReservationInformation(_ReservationID);

            dtCheckOutDate.Value = DateTime.Now;
            DateTime actualCheckInDate = (DateTime)_Reservation.ActualCheckInDate;
            lblActualStayDays.Text = (DateTime.Now.Date - actualCheckInDate.Date).Days.ToString();

            lblFinalCost.Text = (decimal.Parse(lblActualStayDays.Text) * _Reservation.RoomPriceAtReservation).ToString();

            decimal differenceAmount = _Reservation.InitialTotalDueAmount - decimal.Parse(lblFinalCost.Text);
            lblDifferenceAmount.Text = differenceAmount.ToString();

            lblRefudAmount.Text = (differenceAmount > 0) ? differenceAmount + " $" : "0 $";
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            clsRoomReturn roomReturn = new clsRoomReturn();

            roomReturn.ActualStayDays = int.Parse(lblActualStayDays.Text);
            roomReturn.ActualCheckOutDate = DateTime.Today;
            roomReturn.FinalRoomCheckNotes = txtNotes.Text;
            roomReturn.ExtraCharges = !string.IsNullOrEmpty(txtExtraCharges.Text.Trim()) ? decimal.Parse(txtExtraCharges.Text) : 0;
            roomReturn.ReturnedBy = clsGlobal.currentEmployee.EmployeeID;
            roomReturn.ReservationID = ctrlReservationDetails1.ReservationID;
            roomReturn.ReservationInfo = clsReservation.Find(roomReturn.ReservationID);
            roomReturn.TransactionDate = DateTime.Now;
            roomReturn.ActualFinalAmountDue = decimal.Parse(lblFinalCost.Text);
            roomReturn.RefundAmount = decimal.Parse(lblRefudAmount.Text.Split(' ')[0].Trim());
            roomReturn.RemainingAmount = 0;
            if (roomReturn.Save())
            {
                MessageBox.Show("Room returned successfully.", "Done", MessageBoxButtons.OK, MessageBoxIcon.Information);
                btnSave.Enabled = false;
                this.Close();
            }
        }
        private void btnClose_Click(object sender, EventArgs e)
        {
            
            this.Close();
        }
    }
}
