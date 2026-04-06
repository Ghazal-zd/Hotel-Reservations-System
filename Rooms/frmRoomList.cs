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
using SiticoneNetFrameworkUI;
using System.Web.UI.WebControls;
//using Siticone.de

namespace Hotel_Reservations_System
{
    public partial class frmRoomList : Form
    {
        public delegate void DataBackEventHandler(object sender, int CustomerID);
        public event DataBackEventHandler DataBack;

        clsRoom _Room;
        DataTable _dtRoom;
        public static bool AllowChooseOption {  get; set; }
        public frmRoomList()
        {
            InitializeComponent();
        }
        public void UpdateActionButtonStates()
        {
            if (dgvRooms.SelectedRows.Count == 0) return;

            int roomID = (int)dgvRooms.CurrentRow.Cells["RoomID"].Value;
            _Room = clsRoom.Find(roomID);

            if (_Room == null)
            {
                MessageBox.Show("No Reservation with id = " + roomID, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            btnDetails.Enabled = true;
            btnDelete.Enabled = (_Room.RoomStatus == clsRoom.enRoomStatus.Available) ||
                             (_Room.RoomStatus == clsRoom.enRoomStatus.OutOfService);

            btnEditRoom.Enabled = (_Room.RoomStatus == clsRoom.enRoomStatus.Available) ||
                             (_Room.RoomStatus == clsRoom.enRoomStatus.OutOfService);

            btnChoose.Enabled = AllowChooseOption;
        }
        private void _UpdateButtons()
        {
            btnEditRoom.Enabled = false;
            btnChoose.Enabled = false;
            btnAddRoom.Enabled = true;
            btnDetails.Enabled = true;
            btnDelete.Enabled = false;
        }
        private void frmRoomList_Load(object sender, EventArgs e)
        { 
            _dtRoom = clsRoom.GetAllRooms(); 
            _UpdateButtons();
            dgvRooms.DataSource = _dtRoom;
            if (dgvRooms.Rows.Count > 0)
            {
                dgvRooms.Columns[0].HeaderText = "Room ID";
                dgvRooms.Columns[0].Width = 70;
                dgvRooms.Columns[1].HeaderText = "Room Type";
                dgvRooms.Columns[1].Width = 90;
                dgvRooms.Columns[2].HeaderText = "Room Status";
                dgvRooms.Columns[2].Width = 90;
                dgvRooms.Columns[3].HeaderText = "Room's Features Cost";
                dgvRooms.Columns[3].Width = 90;
                dgvRooms.Columns[4].HeaderText = "Basic Room Cost";
                dgvRooms.Columns[4].Width = 90;
                dgvRooms.Columns[5].HeaderText = "Total Cost";
                dgvRooms.Columns[5].Width = 100;

            }
            cmbFilter.Text = "None";
            cmbRoomStatus.Text = "All";
            cmbRoomType.Text = "All";
        }
        private void detailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmRoomDetails frmRoomDetails = new frmRoomDetails((int)dgvRooms.CurrentRow.Cells[0].Value);
            frmRoomDetails.ShowDialog();
        }
        private void chooseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DataBack?.Invoke(this, _Room.RoomID);
            this.Close();
        }
        private void cmsRooms_Opening(object sender, CancelEventArgs e)
        {
            int RoomID = (int)dgvRooms.CurrentRow.Cells["RoomID"].Value;
            _Room = clsRoom.Find(RoomID);
            if (_Room == null) 
            {
                MessageBox.Show("No room with id = " + RoomID, "Deactivated", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return; 
            }
            chooseToolStripMenuItem.Enabled = (_Room.RoomStatus == clsRoom.enRoomStatus.Available);
            chooseToolStripMenuItem.Visible = AllowChooseOption;
        }
        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAddUpdateRoom frmAddUpdateRoom = new frmAddUpdateRoom((int)dgvRooms.CurrentRow.Cells["RoomID"].Value); 
            frmAddUpdateRoom.ShowDialog();
            frmRoomList_Load(null, null);
        }
        private void _Delete()
        {
            if (MessageBox.Show("Are you sure you want to deactivate this room? ", "Delete?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes)
                return;

            if (clsRoom.Delete(_Room.RoomID))
            {
                MessageBox.Show("Room deactivated successfully", "Deactivated", MessageBoxButtons.OK, MessageBoxIcon.Information);
                frmRoomList_Load(null, null);
            }
        }
        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
           _Delete();
        }
        private void btnDetails_Click(object sender, EventArgs e)
        {
            frmRoomDetails frmRoomDetails = new frmRoomDetails((int)dgvRooms.CurrentRow.Cells["RoomID"].Value);
            frmRoomDetails.ShowDialog();
        }
        private void btnEditRoom_Click(object sender, EventArgs e)
        {
            frmAddUpdateRoom frmAddUpdateRoom = new frmAddUpdateRoom((int)dgvRooms.CurrentRow.Cells["RoomID"].Value);
            frmAddUpdateRoom.ShowDialog();
            frmRoomList_Load(null, null);
        }
        private void btnDelete_Click(object sender, EventArgs e)
        {
            _Room = clsRoom.Find((int)dgvRooms.CurrentRow.Cells["RoomID"].Value);
            if (_Room.IsRoomReservedOrOccupied())
            {
                MessageBox.Show("Sorry, you cannot deactivate this room now because it has reserved!","Failed",MessageBoxButtons.OK,MessageBoxIcon.Error);
                return;
            }
            _Delete();
            frmRoomList_Load(null, null);
        }
        private void btnAddRoom_Click(object sender, EventArgs e)
        {
            frmAddUpdateRoom frmAddUpdateRoom = new frmAddUpdateRoom();
            frmAddUpdateRoom.ShowDialog();
        }
        private void btnChoose_Click(object sender, EventArgs e)
        {
            DataBack?.Invoke(this, _Room.RoomID);
            this.Close();
        }
        private void siticoneButton2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void dgvRooms_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            UpdateActionButtonStates();
        }
        private void cmbFilter_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbFilter.Text == "Room Status")
            {
                txtSearch.Visible = false;
                cmbRoomType.Visible = false;
                cmbRoomStatus.Visible = true;
                cmbRoomStatus.Text = "All";
                cmbRoomStatus.Focus();
            }
            else if (cmbFilter.Text == "Room Type")
            {
                txtSearch.Visible = false;
                cmbRoomStatus.Visible = false;
                cmbRoomType.Visible = true;
                cmbRoomType.Text = "All";
                cmbRoomType.Focus();
            }
            else
            {
                txtSearch.Visible = (cmbFilter.Text != "None");
                cmbRoomStatus.Visible = false;
                cmbRoomType.Visible = false;
                if (cmbFilter.Text == "None")
                {
                    txtSearch.Enabled = false;
                    _dtRoom.DefaultView.RowFilter = "";
                }
                else
                    txtSearch.Enabled = true;

                txtSearch.Text = "";
                txtSearch.Focus();
            }
        }
        private void txtSearch_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (cmbFilter.Text == "Room ID")
                e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
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
                _dtRoom.DefaultView.RowFilter = "";
            else
                _dtRoom.DefaultView.RowFilter = string.Format("[{0}] = '{1}'", FilterColumn, FilterValue);

            _UpdateButtons();
            dgvRooms.ClearSelection();
        }
        private void cmbRoomStatus_SelectedIndexChanged(object sender, EventArgs e)
        {
            string FilterColumn = "RoomStatus";
            string FilterValue = cmbRoomStatus.Text;

            switch (FilterValue)
            {
                case "Available":
                    FilterValue = "Available";
                    break;
                case "Occupied":
                    FilterValue = "Occupied";
                    break;
                case "Out Of Service":
                    FilterValue = "Out Of Service";
                    break;

                default:
                    FilterValue = "All";
                    break;
            }

            if (FilterValue == "All")
                _dtRoom.DefaultView.RowFilter = "";
            else
                _dtRoom.DefaultView.RowFilter = string.Format("[{0}] = '{1}'", FilterColumn, FilterValue);

            _UpdateButtons();
            dgvRooms.ClearSelection();
        }
        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            string FilterColumn = "";

            switch (cmbFilter.Text)
            {
                case "Room ID":
                    FilterColumn = "RoomID";
                    break;

                default:
                    FilterColumn = "None";
                    break;

            }

            if (txtSearch.Text.Trim() == "" || FilterColumn == "None")
            {
                _dtRoom.DefaultView.RowFilter = "";
                return;
            }
            if (FilterColumn == "RoomID")
                _dtRoom.DefaultView.RowFilter = string.Format("[{0}] = {1}", FilterColumn, txtSearch.Text.Trim());
         
        }
    }
}
