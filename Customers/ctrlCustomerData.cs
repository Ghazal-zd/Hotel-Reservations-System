using DVLD.Classes;
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
    public partial class ctrlCustomerData : UserControl
    {
        private clsCustomer _Customer;
        private int _CustomerID = -1;

        public int CustomerID
        {
            get { return _CustomerID; }
        }

        public clsCustomer SelectedCustomerInfo
        {
            get { return _Customer; }
        }

        public void ResetCustomerInfo()
        {
            lblCustomerID.Text = "[???]";
            lblDateRegistered.Text = "[???]";
            lblRegisteredByEmployee.Text = "[???]";
            lblNotes.Text = "[???]";
        }
        private void _FillGuestInfo()
        {
            ctrlPersonData1.LoadBasicInfo(_Customer.PersonID);
            lblCustomerID.Text = _Customer.CustomerID.ToString();
            lblDateRegistered.Text = clsFormat.DateToShort(_Customer.RegisteredDate);
            lblRegisteredByEmployee.Text = clsEmployee.Find(_Customer.RegisteredByEmployeeID).FullName;
            lblNotes.Text = _Customer.Notes;
        }
        public void LoadGuestInfo(int CustomerID)
        {
            _Customer = clsCustomer.Find(CustomerID);
            if (_Customer == null)
            {
                ResetCustomerInfo();
                ctrlPersonData1.ResetPersonInfo();
                MessageBox.Show("No Customer with CustomerID = " + CustomerID.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            _CustomerID = CustomerID;
            _FillGuestInfo();
        }
        public ctrlCustomerData()
        {
            InitializeComponent();
        }

        private void siticoneGroupBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
