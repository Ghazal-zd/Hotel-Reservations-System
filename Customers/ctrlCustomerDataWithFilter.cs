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
    public partial class ctrlCustomerDataWithFilter : UserControl
    {

        private bool _ShowAddCustomer = true;
        public bool ShowAddPerson
        {
            get
            {
                return _ShowAddCustomer;
            }
            set
            {
                _ShowAddCustomer = value;
                btnAddCustomer.Visible = _ShowAddCustomer;
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

        public int CustomerID
        {
            get { return ctrlCustomerData1.CustomerID; }
        }

        public clsCustomer SelectedCustomer
        {
            get { return ctrlCustomerData1.SelectedCustomerInfo; }
        }
       

        public ctrlCustomerDataWithFilter()
        {
            InitializeComponent();
        }

        public void LoadGuestInformation(int customerID)
        {
            txtCustomerID.Text = customerID.ToString();
            ctrlCustomerData1.LoadGuestInfo(customerID);

        }
        public void FindNow()
        {
            ctrlCustomerData1.LoadGuestInfo(int.Parse(txtCustomerID.Text));
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (!this.ValidateChildren())
            {
                MessageBox.Show("Some fields are not valid!, put the mouse over the red icon(s) to see the error", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            FindNow();
        }
        private void _GetCustomerID(object sender, int CustomerID)
        {
            txtCustomerID.Text = CustomerID.ToString();
            FindNow();
        }
        private void btnGetFromCustomerList_Click(object sender, EventArgs e)
        {
            frmCustomersList frmCustomersList= new frmCustomersList();
            frmCustomersList.DataBack += _GetCustomerID;
            frmCustomersList.AllowChooseOption = true;
            frmCustomersList.ShowDialog();
        }

        private void ctrlCustomerDataWithFilter_Load(object sender, EventArgs e)
        {

        }

        private void txtCustomerID_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtCustomerID.Text))
            {
                e.Cancel = true;
                errorProvider1.SetError(txtCustomerID, "This field is required!");
            }
            else
            {
                errorProvider1.SetError(txtCustomerID, null);
            }
        }

        private void btnAddCustomer_Click(object sender, EventArgs e)
        {
            frmAddUpdateCustomer frmAddUpdateCustomer= new frmAddUpdateCustomer();
            frmAddUpdateCustomer.DataBack += _GetCustomerID;
            frmAddUpdateCustomer.ShowDialog();
        }

        private void btnGetFromCustomerList_Click_1(object sender, EventArgs e)
        {
            frmCustomersList frmCustomersList = new frmCustomersList();
            frmCustomersList.DataBack += _GetCustomerID;
            frmCustomersList.AllowChooseOption = true;
            frmCustomersList.ShowDialog();
        }

        public void FilterFocus()
        {
            txtCustomerID.Focus();
        }
    }
}
