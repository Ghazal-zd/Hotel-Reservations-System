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
    public partial class ctrlRoomDataWithFilter : UserControl
    {

        private bool _EnableAddRoom = false;
        public bool EnableAddRoom
        {
            set
            {
                _EnableAddRoom = value;
                btnAddRoom.Enabled = _EnableAddRoom;
            }
            get
            {
                return _EnableAddRoom;
            }
        }

        private bool _FilterEnabled = true;
        public bool FilterEnabled
        {
            get
            {
                return _FilterEnabled;
            }
            set
            {
                _FilterEnabled = value;
                gbFilters.Enabled = _FilterEnabled;
            }
        }

        public int RoomID
        {
            get { return ctrlRoomData1.RoomID; }
        }

        public clsRoom SelectedRoom
        {
            get { return ctrlRoomData1.SelectedRoomInfo; }
        }
        public ctrlRoomDataWithFilter()
        {
            InitializeComponent();
        }
        private void ctrlRoomDataWithFilter_Load(object sender, EventArgs e)
        {
           
        }

        public class ReservedRoomInfoEventArgs :EventArgs
        {
            public int RoomID { get; }
            public string RoomStatus { get; }

            public ReservedRoomInfoEventArgs(int roomID, string roomStatus)
            {
                RoomID = roomID;
                RoomStatus = roomStatus;
            }
        }
        //public event EventHandler<ReservedRoomInfoEventArgs> OnRoomSelected;
        //public void RaiseOnRoomSelected(int roomID, string roomStatus)
        //{
        //    RaiseOnRoomSelected(new ReservedRoomInfoEventArgs(roomID, roomStatus));
        //}
        //public void RaiseOnRoomSelected(ReservedRoomInfoEventArgs e)
        //{
        //    OnRoomSelected?.Invoke(this, e);
        //}
        public void LoadRoomInfo(int roomID)
        {
            txtRoomID.Text = roomID.ToString();
            ctrlRoomData1.LoadRoomData(roomID);
        }
        public void FindNow()
        {
            ctrlRoomData1.LoadRoomData(int.Parse(txtRoomID.Text));
        }

        private void siticoneExpressiveImageButton2_Click(object sender, EventArgs e)
        {

            if (!this.ValidateChildren())
            {
                MessageBox.Show("Some fields are not valid!, put the mouse over the red icon(s) to see the error", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            clsRoom _Room = clsRoom.Find(int.Parse(txtRoomID.Text));
            if (_Room != null)
            {
                //    if (_Room.RoomStatus == clsRoom.enRoomStatus.Occupied)
                //    {
                //        RaiseOnRoomSelected(_Room.RoomID, _Room.RoomStatus.ToString());
                //        return;
                //    }
                //}
                FindNow();
            }
        }

        private void txtRoomID_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtRoomID.Text))
            {
                e.Cancel = true;
                errorProvider1.SetError(txtRoomID, "This field is required");
            }
            else
            {
                errorProvider1.SetError(txtRoomID, null);
            }
        }
        public void GetRoomID(object sender, int RoomID)
        {
            txtRoomID.Text= RoomID.ToString();
            FindNow();
        }

        private void btnAddRoom_Click(object sender, EventArgs e)
        {
            frmAddUpdateRoom frmAddUpdateRoom = new frmAddUpdateRoom();
            frmAddUpdateRoom.DataBack += GetRoomID;
            frmAddUpdateRoom.ShowDialog();
        }
     
        private void btnGetFromCustomerList_Click(object sender, EventArgs e)
        {
            frmRoomList frmRoomList = new frmRoomList();
            frmRoomList.AllowChooseOption = true;
            frmRoomList.DataBack += GetRoomID;
            frmRoomList.ShowDialog();
        }

    }
}
