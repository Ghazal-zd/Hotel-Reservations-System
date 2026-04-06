using HRS_BusinessLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Web.Management;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Xml.Linq;

namespace Hotel_Reservations_System
{
    public partial class frmReservationList : Form
    {
        clsReservation _Reservation;
        clsNotificationServices notificationServices = new clsNotificationServices();
        DataTable _dtReservations;

        int _rowsPerPage = 20;
        int _pageNumber = 0;
        int _totalReservationCount = 0;
        int _totalPagesNumber = 0;

        public bool checkInsMode = false;
        public bool checkOutsMode = false;
        public frmReservationList()
        {
            InitializeComponent();
        }

        private void _ResetDefaultButtonsState()
        {
            btnEditReservation.Enabled = false;
            btnCheckIn.Enabled = false;
            btnReturnRoom.Enabled = false;
            btnCancel.Enabled = false;

            btnPrevious.Enabled = _pageNumber != 1;

            btnNext.Enabled = _pageNumber != _totalPagesNumber;
        }
        private async Task loadReservationList()
        {
            _ResetDefaultButtonsState();

            if (checkInsMode)
            {
                _dtReservations = clsReservation.GetCheckInsReservation();
                dgvReservations.DataSource = _dtReservations;
                if (dgvReservations.Rows.Count == 0) { lblNoReservations.Visible=true; }
            }

            else if (checkOutsMode)
            {
                _dtReservations = clsReservation.GetCheckOutsReservation();
                dgvReservations.DataSource = _dtReservations;
                if (dgvReservations.Rows.Count == 0) { lblNoReservations.Visible = true; }
            }

            else
            {
                clsReservation.CheckNoShowReservations();

                _dtReservations = await clsReservation.GetAllReservations(_pageNumber, _rowsPerPage);
                dgvReservations.DataSource = _dtReservations;

                if (dgvReservations.Rows.Count > 0)
                {
                    dgvReservations.Columns[0].HeaderText = "ID";
                    dgvReservations.Columns[0].Width = 70;

                    dgvReservations.Columns[3].HeaderText = "Reserved Room ID";
                    dgvReservations.Columns[3].Width = 120;

                    dgvReservations.Columns[4].HeaderText = "Room Type";
                    dgvReservations.Columns[4].Width = 90;

                    dgvReservations.Columns[5].HeaderText = "Start Date";
                    dgvReservations.Columns[5].Width = 90;

                    dgvReservations.Columns[8].HeaderText = "Paid Amount";
                    dgvReservations.Columns[8].Width = 100;
                }
                else { lblNoReservations.Visible = true; }

            }
            cmbFilter.Text = "None";
        }
        private async void frmReservationList_Load(object sender, EventArgs e)
        {
            _pageNumber = 1;
            _totalReservationCount = clsReservation.GetReservationsCount();
            _totalPagesNumber = (int)Math.Ceiling((double)_totalReservationCount / _rowsPerPage);
            await loadReservationList();
        }
      
        private void cmsReservations_Opening(object sender, CancelEventArgs e)
        {
            int ReservationID = (int)dgvReservations.CurrentRow.Cells[0].Value;
            _Reservation = clsReservation.Find(ReservationID);

            if (_Reservation == null)
            {
                MessageBox.Show("No Reservation with ID = " + ReservationID, "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            checkInToolStripMenuItem.Enabled = (_Reservation.ReservationStatus == clsReservation.enReservationStatus.Reserved)
                                            && (_Reservation.RoomInfo.RoomStatus == clsRoom.enRoomStatus.Available)
                                            && (_Reservation.StartDate.Date <= DateTime.Today.Date && _Reservation.ExitDate.Date >= DateTime.Today.Date);

            returnRoomToolStripMenuItem.Enabled = (_Reservation.ReservationStatus == clsReservation.enReservationStatus.CheckIn);

            editToolStripMenuItem.Enabled = (_Reservation.ReservationStatus == clsReservation.enReservationStatus.Reserved);

            deleteToolStripMenuItem.Enabled = (_Reservation.ReservationStatus == clsReservation.enReservationStatus.Reserved
                || _Reservation.ReservationStatus == clsReservation.enReservationStatus.NoShow
                || _Reservation.ReservationStatus == clsReservation.enReservationStatus.Cancel);
        }
        public void UpdateActionButtonStates()
        {
            if (dgvReservations.CurrentRow == null) return;

            int reservationID = (int)dgvReservations.CurrentRow.Cells["ReservationID"].Value;
            _Reservation = clsReservation.Find(reservationID);

            if (_Reservation == null)
            {
                MessageBox.Show("No Reservation with id = " + reservationID, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            btnDetails.Enabled = true;

            btnEditReservation.Enabled = (_Reservation.ReservationStatus == clsReservation.enReservationStatus.Reserved);
            btnReturnRoom.Enabled = (_Reservation.ReservationStatus == clsReservation.enReservationStatus.CheckIn);
            btnCheckIn.Enabled = (_Reservation.ReservationStatus == clsReservation.enReservationStatus.Reserved)
                                            && (_Reservation.RoomInfo.RoomStatus == clsRoom.enRoomStatus.Available)
                                            && (_Reservation.StartDate.Date <= DateTime.Today.Date && _Reservation.ExitDate.Date >= DateTime.Today.Date);
            
            btnCancel.Enabled = (_Reservation.ReservationStatus == clsReservation.enReservationStatus.Reserved);
        }
        private void dgvReservations_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            UpdateActionButtonStates();
        }
        private void dgvReservations_CellMouseDown(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right && e.RowIndex >= 0)
            {
                dgvReservations.ClearSelection();
                dgvReservations.Rows[e.RowIndex].Selected = true;
                dgvReservations.CurrentCell = dgvReservations.Rows[e.RowIndex].Cells[0];
            }
        }

        private void _HandleEditReservation()
        {
            if (dgvReservations.CurrentRow == null) return;

            if (_Reservation.ReservationStatus != clsReservation.enReservationStatus.Reserved)
            {
                MessageBox.Show("Sorry!, you cannot edit this reservation!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            frmAddUpdateReservation frmAddUpdateReservation = new frmAddUpdateReservation((_Reservation.ReservationID));
            frmAddUpdateReservation.ShowDialog();
            frmReservationList_Load(null, null);
        }     
        private void btnEditReservation_Click(object sender, EventArgs e)
        {
            _HandleEditReservation();
        }      
        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _HandleEditReservation();
        }

        private void _HandleReturnRoom()
        {
            if (dgvReservations.CurrentRow == null) return;

            if (_Reservation.ReservationStatus != clsReservation.enReservationStatus.CheckIn)
            {
                Console.WriteLine("Sorry!, you cannot return this room yet!","Error",MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            frmReturnRoom frmReturnRoom = new frmReturnRoom(_Reservation.ReservationID);
            frmReturnRoom.ShowDialog();

            frmReservationList_Load(null, null);
        }
        private void btnReturnRoom_Click(object sender, EventArgs e)
        {
            _HandleReturnRoom();
        }
        private void returnRoomToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _HandleReturnRoom();
        }
       
        private void _HandleShowReservationDetails()
        {
            if (dgvReservations.CurrentRow == null) return;
            frmReservationDetails frmReservationDetails = new frmReservationDetails((int)dgvReservations.CurrentRow.Cells["ReservationID"].Value);
            frmReservationDetails.ShowDialog();
        }
        private void btnDetails_Click(object sender, EventArgs e)
        {
            _HandleShowReservationDetails();
        }
        private void detailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _HandleShowReservationDetails();
        }
        
        private void _HandleCheckInReservation()
        {
            if (dgvReservations.CurrentRow == null) return;

            if (_Reservation.ReservationStatus != clsReservation.enReservationStatus.Reserved) return;

            clsReservationEvents.RoomOccupied += notificationServices.OnRoomOccupied;

            if (!_Reservation.CheckIn())
            {
                MessageBox.Show("Failed to check_in this reservation!", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            MessageBox.Show("Reservation checked in successfully", "Done", MessageBoxButtons.OK, MessageBoxIcon.Information);
            frmReservationList_Load(null, null);
        }
        private void btnCheckIn_Click(object sender, EventArgs e)
        {
            _HandleCheckInReservation();
        } 
        private void checkInToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _HandleCheckInReservation();
        }
   
        private bool _ConfirmCancel()
        {
            return MessageBox.Show("Are you sure you want to cancel this reservation?", "Yes/No", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes;
        }
        private void _HandleCancelReservation()
        {
            if(dgvReservations.CurrentRow==null) return;

            if (_Reservation.ReservationStatus == clsReservation.enReservationStatus.Completed
              || _Reservation.ReservationStatus == clsReservation.enReservationStatus.CheckIn
              || _Reservation.ReservationStatus == clsReservation.enReservationStatus.NoShow)
            {
                MessageBox.Show("Sorry!, you cannot cancel this reservation!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!_ConfirmCancel())
                return;

            if (!_Reservation.Cancel())
            {
                MessageBox.Show("Failed to cancel this reservation!", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            MessageBox.Show("Reservation cancelled successfully.", "Done", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }
        private void btnCancel_Click(object sender, EventArgs e)
        {
            _HandleCancelReservation();
        } 
        private void CancelToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _HandleCancelReservation();
        }
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void _HandleAddNewReservation()
        {
            frmAddUpdateReservation frmAddUpdateReservation = new frmAddUpdateReservation();
            frmAddUpdateReservation.ShowDialog();
            frmReservationList_Load(null, null);
        }
        private void btnAddNewReservation_Click(object sender, EventArgs e)
        {
            _HandleAddNewReservation();
        }
        private void addNewReservationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _HandleAddNewReservation();
        }
        private void cmbRoomType_SelectedIndexChanged(object sender, EventArgs e)
        {
            string FilterColumn = "RoomType";
            string FilterValue = cmbRoomType.Text;

            switch (FilterValue)
            {
                case "Single":
                    FilterValue = "Single";
                    break;
                case "Double":
                    FilterValue = "Double";
                    break;
                case "Suite":
                    FilterValue = "Suite";
                    break;
              
                default:
                    FilterValue = "All";
                    break;
            }

            if (FilterValue == "All")
                _dtReservations.DefaultView.RowFilter = "";
            else
                _dtReservations.DefaultView.RowFilter = string.Format("[{0}] = '{1}'", FilterColumn, FilterValue);

            _ResetDefaultButtonsState();
            dgvReservations.ClearSelection();
        }  
        private void txtCustomerSearch_TextChanged(object sender, EventArgs e)
        {
            string FilterColumn = "";

            switch (cmbFilter.Text)
            {
                case "Reservation ID":
                    FilterColumn = "ReservationID";
                    break;

                case "Full Name":
                    FilterColumn = "FullName";
                    break;

                case "Email":
                    FilterColumn = "Email";
                    break;

                case "Reserved Room ID":
                    FilterColumn = "ReservedRoomNumber";
                    break;

                case "Room Type":
                    FilterColumn = "RoomType";
                    break;
        
                case "Reservation Status":
                    FilterColumn = "ReservationStatus";
                    break;

                default:
                    FilterColumn = "None";
                    break;

            }

            if (txtSearch.Text.Trim() == "" || FilterColumn == "None")
            {
                _dtReservations.DefaultView.RowFilter = "";
                return;
            }

            if (FilterColumn == "ReservationID" || FilterColumn == "ReservedRoomNumber")
                _dtReservations.DefaultView.RowFilter = string.Format("[{0}] = {1}", FilterColumn, txtSearch.Text.Trim());
            else
                _dtReservations.DefaultView.RowFilter = string.Format("[{0}] LIKE '{1}%'", FilterColumn, txtSearch.Text.Trim());

        }
        private void cmbFilter_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbFilter.Text == "Reservation Status")
            {
                txtSearch.Visible = false;
                cmbRoomType.Visible = false;
                cmbReservationStatus.Visible = true;
                cmbReservationStatus.Text = "All";
                cmbReservationStatus.Focus();
            }
            else if (cmbFilter.Text == "Room Type")
            {
                txtSearch.Visible = false;
                cmbReservationStatus.Visible = false;
                cmbRoomType.Visible = true;
                cmbRoomType.Text = "All";
                cmbRoomType.Focus();
            }
            else
            {

                txtSearch.Visible = (cmbFilter.Text != "None");
                cmbReservationStatus.Visible = false;

                if (cmbFilter.Text == "None")
                {
                    txtSearch.Enabled = false;
                    _dtReservations.DefaultView.RowFilter = "";
                }
                else
                    txtSearch.Enabled = true;

                txtSearch.Text = "";
                txtSearch.Focus();
            }
        }
        private void cmbReservationStatus_SelectedIndexChanged(object sender, EventArgs e)
        {
            string FilterColumn = "ReservationStatus";
            string FilterValue = cmbReservationStatus.Text;

            switch (FilterValue)
            {
                case "Reserved":
                    FilterValue = "Reserved";
                    break;
                case "Completed":
                    FilterValue = "Completed";
                    break;
                case "No Show":
                    FilterValue = "No Show";
                    break;
                case "Checked In":
                    FilterValue = "Checked In";
                    break;
                case "Cancelled":
                    FilterValue = "Cancelled";
                    break;

                default:
                    FilterValue = "All";
                    break;
            }

            if (FilterValue == "All")
                _dtReservations.DefaultView.RowFilter = "";
            else
                _dtReservations.DefaultView.RowFilter = string.Format("[{0}] = '{1}'", FilterColumn, FilterValue);

            _ResetDefaultButtonsState();
            dgvReservations.ClearSelection();
        }
        private void txtSearch_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (cmbFilter.Text == "Reservation ID" || cmbFilter.Text == "Reserved Room ID")
                e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private async void btnNext_Click(object sender, EventArgs e)
        {
            if (_pageNumber >= _totalPagesNumber) return;
            _pageNumber++;
            await loadReservationList();
        }
        private async void btnPrevious_Click(object sender, EventArgs e)
        {
            if (_pageNumber > 1)
            {
                _pageNumber--;
                await loadReservationList();
            }
        }

        private void roomDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmRoomDetails frmRoomDetails = new frmRoomDetails((int)dgvReservations.CurrentRow.Cells["ReservedRoomNumber"].Value);
            frmRoomDetails.ShowDialog();
        }

        private void siticoneGroupBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
