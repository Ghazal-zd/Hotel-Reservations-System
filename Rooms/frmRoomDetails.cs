using HRS_BusinessLayer;
using System;
using System.Windows.Forms;

namespace Hotel_Reservations_System
{
    public partial class frmRoomDetails : Form
    {
        int _RoomID = -1;
        public frmRoomDetails(int roomID)
        {
            InitializeComponent();
            _RoomID = roomID;
        }
        private void frmRoomDetails_Load(object sender, EventArgs e)
        {
            ctrlRoomDataWithFilter1.FilterEnabled = false;
            ctrlRoomDataWithFilter1.LoadRoomInfo(_RoomID);
        }
        private void siticoneButton2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
