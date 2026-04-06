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
using static HRS_BusinessLayer.clsRoomType;

namespace Hotel_Reservations_System
{
    public partial class frmAddUpdateUser : Form
    {
        enum enMode { AddNew = 1, Update = 2 };
        enMode _mode;
        clsEmployee _user;
        int _userID = -1;

        public frmAddUpdateUser()
        {
            InitializeComponent();
            _mode = enMode.AddNew;
        }
        public frmAddUpdateUser(int userID)
        {
            InitializeComponent();
            _userID = userID;
            _mode = enMode.Update;
        }
        private void _FillCountriesInComboBox()
        {
            DataTable dtCountries = clsCountry.GetAllCountries();
            foreach (DataRow row in dtCountries.Rows)
            {
                cmbCountries.Items.Add(row["CountryName"]);
            }
        }
        private void _LoadUserInfo()
        {
            _user = clsEmployee.Find(_userID);
            if (_user == null)
            {
                MessageBox.Show("No user with id = " + _userID.ToString(), "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            lblUserID.Text = _user.EmployeeID.ToString();
            txtFirstName.Text = _user.FirstName;
            txtLastName.Text = _user.LastName;
            txtEmail.Text = _user.Email;
            txtPhoneNumber.Text = _user.PhoneNumber;
            cmbCountries.Text = clsCountry.Find(_user.CountryID).CountryName;
            txtUsername.Text = _user.Username;
            chxIsActive.Checked = _user.IsActive;
            cmbRoles.Text = _user.RoleName;
            if (clsGlobal.currentEmployee.RoleID != clsRole.enRoles.Admin) { chxIsActive.Enabled = false; cmbRoles.Enabled = false; }
            txtPassword.PlaceholderText = "Unknown";
            txtPassword.Enabled = false;

        }
        private void _ResetDefaultInfo()
        {
            _FillCountriesInComboBox();
            cmbCountries.Text = "Syria";
            cmbRoles.Text = "Admin";
            if (_mode == enMode.AddNew)
            {
                lblTitle.Text = "Add New User";
                this.Text = "Add New Customer";
                _user = new clsEmployee();
            }
            else
            {
                this.lblTitle.Text = "Update User Info";
                this.Text = "Update User Info";
                gpAddUpdateUser.Text = "Update User Info";
            }
        }
        private void frmAddUpdateUser_Load(object sender, EventArgs e)
        {
            _ResetDefaultInfo();
            if (_mode == enMode.Update)
            {
                _LoadUserInfo();
            }
        }
        private void _Save()
        {
            _user.FirstName = txtFirstName.Text;
            _user.LastName = txtLastName.Text;
            _user.Email = txtEmail.Text;
            _user.PhoneNumber = txtPhoneNumber.Text;
            _user.Username = txtUsername.Text;
            _user.CountryID = clsCountry.Find(cmbCountries.Text).CountryID;
            _user.RoleID = clsRole.Find(cmbRoles.Text).RoleID;
            _user.IsActive = chxIsActive.Checked;
            _user.HireDate = DateTime.Now.Date;

            if (!_user.Save())
            {
                MessageBox.Show("Something went wrong!", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            MessageBox.Show("Data Saved Successfully", "Done", MessageBoxButtons.OK, MessageBoxIcon.Information);
            lblUserID.Text = _user.EmployeeID.ToString();
            btnSave.Text = "Saved";
            btnSave.Enabled = false;

            this.Close();
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!this.ValidateChildren())
            {
                MessageBox.Show("Some fields are not valid!", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            _Save();
        }
        private void txtFirstName_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtFirstName.Text.Trim()))
            {
                e.Cancel = true;
                errorProvider1.SetError(txtFirstName, "This field is required!");
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
                errorProvider1.SetError(txtEmail, "Not valid email!");
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
        private void txtUsername_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtUsername.Text.Trim()))
            {
                e.Cancel = true;
                errorProvider1.SetError(txtUsername, "This field is required!");
                return;
            }
            else
            {
                errorProvider1.SetError(txtUsername, null);
            }
        }
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void siticoneButtonAdvanced1_Click(object sender, EventArgs e)
        {

        }

        private void txtPassword_TextContentChanged(object sender, EventArgs e)
        {

        }
    }
}
