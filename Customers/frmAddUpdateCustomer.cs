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
    public partial class frmAddUpdateCustomer : Form
    {
        public delegate void DataBackEventHandler(object sender, int CustomerID);
        public event DataBackEventHandler DataBack;
        enum enMode { AddNew = 1, Update = 2 }
        enMode _mode;

        int _CustomerID = -1;
        clsCustomer _Customer;
        public frmAddUpdateCustomer()
        {
            InitializeComponent();
            _mode = enMode.AddNew;
        }

        public frmAddUpdateCustomer(int CustomerID)
        {
            InitializeComponent();

            _CustomerID = CustomerID;
            _mode = enMode.Update;

        }
        private void _LoadCustomerInfo()
        {
            lblCustomerID.Text = _Customer.CustomerID.ToString();
            txtFirstName.Text = _Customer.FirstName;
            txtLastName.Text = _Customer.LastName;
            txtEmail.Text = _Customer.Email;
            txtPhoneNumber.Text = _Customer.PhoneNumber;
            cmbCountries.Text = clsCountry.Find(_Customer.CountryID).CountryName;
            txtNotes.Text = _Customer.Notes;
        }
        private void _FillCountriesInComboBox()
        {
            DataTable dtCountries = clsCountry.GetAllCountries();
            foreach (DataRow row in dtCountries.Rows)
            {
                cmbCountries.Items.Add(row["CountryName"]);
            }
        }
        private void _ResetDefaultInfo()
        {
            _FillCountriesInComboBox();

            if (_mode == enMode.AddNew)
            {
                lblTitle.Text = "Add New Customer";
                AddUpdateCustomer.Text = "Add New Customer";
                _Customer = new clsCustomer();
            }
            else
            {
                this.lblTitle.Text = "Update Customer Info";
                this.AddUpdateCustomer.Text = "Update Customer Info";

                _Customer = clsCustomer.Find(_CustomerID);
                if (_Customer == null)
                {
                    MessageBox.Show("No customer with id = " + _CustomerID.ToString(), "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
        }
        private void frmAddUpdateCustomer_Load(object sender, EventArgs e)
        {
            _ResetDefaultInfo();

            if (_mode == enMode.Update)
            {
                _LoadCustomerInfo();
            }
        }
        private void txtFirstName_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtFirstName.Text.Trim()))
            {
                e.Cancel = true;
                errorProvider1.SetError(txtFirstName, "This field is required!");
                return;
            }
            else
            {
                errorProvider1.SetError(txtFirstName, null);
            }
        }
        private void txtLastName_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtLastName.Text.Trim()))
            {
                e.Cancel = true;
                errorProvider1.SetError(txtLastName, "This field is required!");
                return;
            }
            else
            {
                errorProvider1.SetError(txtLastName, null);
            }
        }
        private void txtEmail_Validating(object sender, CancelEventArgs e)
        {
            if (!clsValidation.ValidateEmail(txtEmail.Text.Trim()))
            {
                e.Cancel = true;
                errorProvider1.SetError(txtEmail, "This field is required!");
                return;
            }
            else
            {
                errorProvider1.SetError(txtEmail, null);
            }
            if (string.IsNullOrEmpty(txtEmail.Text.Trim()))
            {
                e.Cancel = true;
                errorProvider1.SetError(txtEmail, "This field is required!");
            }
            else
            {
                errorProvider1.SetError(txtEmail, null);
            }
        }
        private void cmbCountries_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(cmbCountries.Text.Trim()))
            {
                e.Cancel = true;
                errorProvider1.SetError(cmbCountries, "This field is required!");
                return;
            }
            else
            {
                errorProvider1.SetError(cmbCountries, null);
            }
        }
        private void _Save()
        {
            _Customer.FirstName = txtFirstName.Text;
            _Customer.LastName = txtLastName.Text;
            _Customer.Email = txtEmail.Text;
            _Customer.PhoneNumber = txtPhoneNumber.Text;
            _Customer.Notes = txtNotes.Text;
            _Customer.CountryID = clsCountry.Find(cmbCountries.Text).CountryID;
            _Customer.RegisteredByEmployeeID = clsGlobal.currentEmployee.EmployeeID;
            _Customer.RegisteredDate = DateTime.Now;

            if (!_Customer.Save())
            {
                MessageBox.Show("Something went wrong, try again!", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            MessageBox.Show("Data Saved Successfully","Done",MessageBoxButtons.OK,MessageBoxIcon.Information);
            lblCustomerID.Text = _Customer.CustomerID.ToString();
            _mode = enMode.Update;
            btnSave.Text = "Saved";
            this.Close();

            DataBack?.Invoke(this, _Customer.CustomerID);
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!ValidateChildren())
            {
                MessageBox.Show("Some fields are not valid!", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            _Save();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
