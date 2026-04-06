using HRS_BusinessLayer;
using SiticoneNetFrameworkUI;
using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;
using static HRS_BusinessLayer.clsRoomType;

namespace Hotel_Reservations_System
{
    public partial class frmAddUpdateRoom : Form
    {
        public delegate void DataBackEventHandler(object sender, int RoomID);
        public event DataBackEventHandler DataBack;
        enum enMode { AddNew = 1, Update = 2 }
        enMode _mode;
        clsRoom _Room;
        int _RoomID = -1;
        clsRoomType.enRoomType _RoomTypeID = clsRoomType.enRoomType.Single;
        decimal FeaturesPrice = 0;
        public frmAddUpdateRoom()
        {
            InitializeComponent();
            _mode = enMode.AddNew;
        }
        public frmAddUpdateRoom(int roomID)
        {
            InitializeComponent();
            _RoomID = roomID;
            _mode = enMode.Update;
        }
        private void _UpdateTotalPrice()
        {
            decimal basePrice = clsRoomType.Find(_RoomTypeID)?.Price ?? 0;
            FeaturesPrice = _CalculateFeaturePrice();
            txtCost.Value = basePrice + FeaturesPrice;
        }
        private decimal _CalculateFeaturePrice()
        {
            decimal total = 0;

            foreach (SiticoneCheckBoxAdvanced chx in FeaturesPanel.Controls)
            {
                if (chx.Checked && chx.Tag != null)
                {
                    dynamic data = chx.Tag;
                    total += data.Price;
                }
            }

            return total;
        }
        private void _CheckRoomFeatures()
        {
            HashSet<int> featureIDs = _Room.GetRoomFeatureIDs();
            if (featureIDs.Count == 0) return;

            foreach (SiticoneCheckBoxAdvanced chx in FeaturesPanel.Controls)
            {
                if (featureIDs.Contains((int)chx.Tag))
                {
                    chx.Checked = true;
                }
            }
        }
        private void _LoadRoomInfo()
        {
            Text = "Update Room";
            lblTitle.Text = "Update Room";
            _Room = clsRoom.Find(_RoomID);
            if (_Room == null)
            {
                MessageBox.Show("No Room with id =" + _RoomID, "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            lblRoomID.Text = _Room.RoomID.ToString();
            switch (_Room.RoomTypeID)
            {
                case clsRoomType.enRoomType.Single:
                    {
                        rbSingle.Checked = true;
                        break;
                    }

                case clsRoomType.enRoomType.Double:
                    {
                        rbDouble.Checked = true;
                        break;
                    }

                case clsRoomType.enRoomType.Suite:
                    {
                        rbSuite.Checked = true;
                        break;
                    }
            }
            _CheckRoomFeatures();
            txtCost.Value = (_Room.RoomFee + _Room.GetTotalFeaturesCost());
        }     
        private void _ResetDefaultInfo()
        {
            Text = "Add New Room";
            rbSingle.Checked = true;
            
            DataTable dtFeatures = clsFeature.GetAllFeatures();
            FeaturesPanel.Controls.Clear();

            foreach (DataRow feature in dtFeatures.Rows)
            {
                decimal price = Convert.ToDecimal(feature["Price"]);
                string priceText = (price == 0) ? "Free" : $"+ {price} $";

                var chx = new SiticoneCheckBoxAdvanced
                {
                    Text = $"{feature["FeatureName"]} => {priceText}",
                    Tag = new { Id = (int)feature["FeatureID"], Price = price },
                    AutoSize = true
                };

                FeaturesPanel.Controls.Add(chx);

                chx.CheckStateChanged += (s, e) =>
                {
                        _UpdateTotalPrice();
                };
            }
        }
        private void frmAddNewRoom_Load(object sender, EventArgs e)
        {
            if (_mode == enMode.AddNew)
            {
                _Room = new clsRoom();
                _ResetDefaultInfo();
            }
            if (_mode == enMode.Update)
            {
                _LoadRoomInfo();
            }
        }
        private DataTable _GetRoomFeatures()
        {
            DataTable tvp = new DataTable();
            tvp.Columns.Add("FeatureID", typeof(int));

            foreach (SiticoneCheckBoxAdvanced chx in FeaturesPanel.Controls)
            {
                if (chx.Checked)
                    tvp.Rows.Add((int)chx.Tag);
            }
            return tvp;
        }
        private void _Save()
        {
            _Room.RoomTypeID = (rbSingle.Checked) ? clsRoomType.enRoomType.Single :
               ((rbDouble.Checked) ? clsRoomType.enRoomType.Double : clsRoomType.enRoomType.Suite);

            _Room.RoomFee = clsRoomType.Find(_Room.RoomTypeID).Price;

            _Room.FeaturesDT = _GetRoomFeatures();

            if (_mode == enMode.AddNew)
                _Room.RoomStatus = clsRoom.enRoomStatus.Available;

            if (!_Room.Save())
            {
                MessageBox.Show("Failed to add this room","Failed",MessageBoxButtons.OK,MessageBoxIcon.Error);
                return;
            }

            if (_mode == enMode.AddNew)
            {
                MessageBox.Show("Room Added Successfully","Done",MessageBoxButtons.OK,MessageBoxIcon.Information);
                lblRoomID.Text = _Room.RoomID.ToString();
                _mode = enMode.Update;
                lblTitle.Text = "Update Room";
                Text = "Update";
                DataBack?.Invoke(this, _Room.RoomID);
                return;
            }
            MessageBox.Show("Room Data Updated Successfully", "Done", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();
        }
        private void rbSingle_RadioButtonSelected(object sender, SiticoneNetFrameworkUI.SiticoneMaterialRadioButton.RadioButtonEventArgs e)
        {
            _RoomTypeID = clsRoomType.enRoomType.Single;
            _UpdateTotalPrice();
        }
        private void rbDouble_RadioButtonSelected(object sender, SiticoneNetFrameworkUI.SiticoneMaterialRadioButton.RadioButtonEventArgs e)
        {
            _RoomTypeID = clsRoomType.enRoomType.Double;
            _UpdateTotalPrice();
        }
        private void rbSuite_RadioButtonSelected(object sender, SiticoneNetFrameworkUI.SiticoneMaterialRadioButton.RadioButtonEventArgs e)
        {
            _RoomTypeID = clsRoomType.enRoomType.Suite;
            _UpdateTotalPrice();
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            _Save();
        }
    }
}

/*      //private void rbSuite_CheckedChanged(object sender, EventArgs e)
        //{
        //    //if (!rbSuite.Checked)
        //    //{
        //    //    _SubRoomTypePrice(clsRoomType.enRoomType.Suite);
        //    //}
        //    //_Room.RoomTypeID = clsRoomType.enRoomType.Suite;
        //    //_UpdateTotalPrice();
        //}

        //private void rbDouble_CheckedChanged(object sender, EventArgs e)
        //{
        //    //if (!rbDouble.Checked)
        //    //{
        //    //    _SubRoomTypePrice(clsRoomType.enRoomType.Double);
        //    //}
        //}

        //private void rbSingle_CheckedChanged(object sender, EventArgs e)
        //{
        //    //if (!rbSingle.Checked)
        //    //{
        //    //    _SubRoomTypePrice(clsRoomType.enRoomType.Single);
        //    //}
        //}
//private void _GetRoomTypePrice(clsRoomType.enRoomType RoomType)
        //{
        //    if (_Room == null) return;

        //    decimal basePrice = clsRoomType.Find(RoomType)?.Price ?? 0;

        //    txtCost.Value = basePrice + FeaturesPrice;
        //}
        //private void _SubRoomTypePrice(clsRoomType.enRoomType RoomType)
        //{
        //    txtCost.Value -= clsRoomType.Find(RoomType).Price;
        //}
*/