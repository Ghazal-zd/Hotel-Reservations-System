using DVLD.Classes;
using HRS_BusinessLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Resources;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace Hotel_Reservations_System
{
    public partial class frmCustomersList : Form
    {
        public delegate void DataBackEventHandler(object sender, int CustomerID);
        public event DataBackEventHandler DataBack;

        DataTable _dtCustomers;
        public static bool AllowChooseOption { get; set; }

        clsCustomer _Customer;
        public frmCustomersList()
        {
            InitializeComponent();
        }
        private void frmCustomersList_Load(object sender, EventArgs e)
        {
            _dtCustomers = clsCustomer.GetAllCustomers();
            dgvCustomers.DataSource = _dtCustomers;

            btnChoose.Enabled = AllowChooseOption;
            cmbFilter.Text = "None";
        }

        private void _HandleChooseGuest()
        {
            if (dgvCustomers.CurrentRow == null) return;

            this.Close();
            DataBack?.Invoke(this, (int)dgvCustomers.CurrentRow.Cells["CustomerID"].Value);
        }
        private void chooseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _HandleChooseGuest();
        }
        private void btnChoose_Click(object sender, EventArgs e)
        {
            _HandleChooseGuest();
        }

        private void _HandleShowGuestDetails()
        {
            if (dgvCustomers.CurrentRow == null) return;

            frmCustomerDetails frmCustomerDetails = new frmCustomerDetails((int)dgvCustomers.CurrentRow.Cells["CustomerID"].Value);
            frmCustomerDetails.ShowDialog();
        }
        private void btnDetails_Click(object sender, EventArgs e)
        {
            _HandleShowGuestDetails();
        } 
        private void detailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _HandleShowGuestDetails();
        }

        private void _HandleEditGuestInfo()
        {
            if (dgvCustomers.CurrentRow == null) return;

            frmAddUpdateCustomer frmAddUpdateCustomer = new frmAddUpdateCustomer((int)dgvCustomers.CurrentRow.Cells["CustomerID"].Value);
            frmAddUpdateCustomer.ShowDialog();
            frmCustomersList_Load(null, null);

        }
        private void btnEditCustomer_Click(object sender, EventArgs e)
        {
            _HandleEditGuestInfo();
        }  
        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _HandleEditGuestInfo();
        }

        private void _HandleAddNewGuest()
        {
            frmAddUpdateCustomer frmAddUpdateCustomer = new frmAddUpdateCustomer();
            frmAddUpdateCustomer.ShowDialog();
            frmCustomersList_Load(null, null);
        }
        private void btnAddCustomer_Click(object sender, EventArgs e)
        {
            _HandleAddNewGuest();
        }
        private void addNewCustomerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _HandleAddNewGuest();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
      
        private void txtSearch_TextChanged_1(object sender, EventArgs e)
        {
            string FilterColumn = "";

            switch (cmbFilter.Text)
            {
                case "Customer ID":
                    FilterColumn = "CustomerID";
                    break;

                case "Customer Name":
                    FilterColumn = "FullName";
                    break;

                case "Full Name":
                    FilterColumn = "FullName";
                    break;

                case "Phone Number":
                    FilterColumn = "PhoneNumber";
                    break;

                case "Email":
                    FilterColumn = "Email";
                    break;

                case "Country":
                    FilterColumn = "CountryName";
                    break;

                default:
                    FilterColumn = "None";
                    break;

            }

            if (txtSearch.Text.Trim() == "" || FilterColumn == "None")
            {
                _dtCustomers.DefaultView.RowFilter = "";
                return;
            }

            if (FilterColumn == "CustomerID")
                _dtCustomers.DefaultView.RowFilter = string.Format("[{0}] = {1}", FilterColumn, txtSearch.Text.Trim());
            else
                _dtCustomers.DefaultView.RowFilter = string.Format("[{0}] LIKE '{1}%'", FilterColumn, txtSearch.Text.Trim());

        }
        private void txtSearch_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (cmbFilter.Text == "Customer ID")
                e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }
        private void cmbFilter_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtSearch.Visible = (cmbFilter.Text != "None");
            txtSearch.Focus();
        }
        private void cmsCustomers_Opening(object sender, CancelEventArgs e)
        {
            chooseToolStripMenuItem.Enabled = AllowChooseOption;
        }

    }
    
}
