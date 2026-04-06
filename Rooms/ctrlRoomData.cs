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
    public partial class ctrlRoomData : UserControl
    {
        clsRoom _Room;
        int _RoomID = -1;

        public int RoomID
        {
            get { return _RoomID; }
        }

        public clsRoom SelectedRoomInfo
        {
            get { return _Room; }
        }

        public ctrlRoomData()
        {
            InitializeComponent();
        }
        private void _FillFeaturesList()
        {
            DataTable dtRoomFeatures = _Room.GetRoomFeatures();

            foreach (DataRow row in dtRoomFeatures.Rows)
            {
                decimal price = Convert.ToDecimal(row["Price"]);
                string priceText = (price == 0) ? "Free" : $"+ {price} $";

                lvFeatures.Items.Add(row["FeatureName"] + " => " + priceText);
            }

        }
        private void _loadRoomInfo()
        {
            lblRoomID.Text = _Room.RoomID.ToString();
            lblRoomType.Text = _Room.RoomTypeText;
            lblRoomStatus.Text = _Room.RoomStatusText;
            _FillFeaturesList();
            lblBaseCost.Text = _Room.RoomFee.ToString();
            lblTotalCost.Text = (_Room.RoomFee + _Room.GetTotalFeaturesCost()).ToString();
        }
        private void _ResetDefaultInfo()
        {
            lblRoomID.Text = "???";
            lblRoomType.Text = "???";
            lblRoomStatus.Text = "???";
            lvFeatures.Items.Clear();
            lblBaseCost.Text = "???";
            lblTotalCost.Text = "???";
        }
        public void LoadRoomData(int RoomID)
        {
            _Room = clsRoom.Find(RoomID);
            if (_Room == null)
            {
                _ResetDefaultInfo();
                MessageBox.Show("No Room with ID = " + RoomID, "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            _RoomID = RoomID;
            _loadRoomInfo();
        }

        private void ctrlRoomData_Load(object sender, EventArgs e)
        {

        }
    }
}
