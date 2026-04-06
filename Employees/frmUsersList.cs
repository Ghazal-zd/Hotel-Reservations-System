using HRS_BusinessLayer;
using SiticoneNetFrameworkUI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hotel_Reservations_System
{
    public partial class frmUsersList : Form
    {
        DataTable _dtUsers;
        public frmUsersList()
        {
            InitializeComponent();
        }
        private void frmUsersList_Load(object sender, EventArgs e)
        {
            _dtUsers = clsEmployee.GetAllUsers();
            dgvUsers.DataSource = _dtUsers;
            cmbFilter.Text = "None";
        }
        private void _HandleEditUser()
        {
            if (dgvUsers.CurrentRow == null) return;

            frmAddUpdateUser frmAddUpdateUser = new frmAddUpdateUser((int)dgvUsers.CurrentRow.Cells["UserID"].Value);
            frmAddUpdateUser.ShowDialog();
            frmUsersList_Load(null, null);
        }
        private void ediToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _HandleEditUser();
        }
        private void btnEditUser_Click(object sender, EventArgs e)
        {
            _HandleEditUser();
        }

        private void _HandleUserDeactivate()
        {
            if (dgvUsers.CurrentRow == null) return;

            int userID = (int)dgvUsers.CurrentRow.Cells["UserID"].Value;
            clsEmployee user = clsEmployee.Find(userID);

            if (user == null)
            {
                MessageBox.Show("No user with id = " + userID, "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (!user.IsActive)
            {
                MessageBox.Show("This account already deactivated!", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (user.RoleID == clsRole.enRoles.Admin)
            {
                MessageBox.Show("You cannot deactivate admin account!", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!_ConfirmDeactivate())
                return;

            if (_DeactivateUser(user))
            {
                MessageBox.Show("User's account deactivated successfully", "Deactivated", MessageBoxButtons.OK, MessageBoxIcon.Information);
                frmUsersList_Load(null, null);
            }
            else
            {
                MessageBox.Show("Failed to deactivate this account", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private bool _ConfirmDeactivate()
        {
            return (MessageBox.Show("Are you sure you want to deactivate this user? ", "Deactivate?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes);
        }
        private bool _DeactivateUser(clsEmployee user)
        {
            return clsEmployee.DeactivateUser(user.EmployeeID);
        }
        private void btnDeactivate_Click(object sender, EventArgs e)
        {
            _HandleUserDeactivate();
        }
        private void deactivateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _HandleUserDeactivate();
        }
        private void _HandleAddNewUser()
        {
            frmAddUpdateUser frmAddUpdateUser = new frmAddUpdateUser();
            frmAddUpdateUser.ShowDialog();
            frmUsersList_Load(null, null);
        }
        private void btnAddUser_Click(object sender, EventArgs e)
        {
            _HandleAddNewUser();
        }
        private void addNewUserToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _HandleAddNewUser();
        }
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void _HandleShowUserDetails()
        {
            if (dgvUsers.CurrentRow == null) return;

            frmUserDetails frmUserDetails = new frmUserDetails((int)dgvUsers.CurrentRow.Cells["UserID"].Value);
            frmUserDetails.ShowDialog();
        }
        private void detailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _HandleShowUserDetails();
        }
        private void btnDetails_Click(object sender, EventArgs e)
        {
            _HandleShowUserDetails();
        }

        private void cmbFilter_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbFilter.Text.Trim() == "Role")
            {
                txtSearch.Visible = false;
                cmbIsActive.Visible = false;
                cmbRoles.Visible = true;
                cmbRoles.Text = "All";
                cmbRoles.Focus();
            }
            else if (cmbFilter.Text.Trim() == "Is Active")
            {
                txtSearch.Visible = false;
                cmbRoles.Visible = false;
                cmbIsActive.Visible = true;
                cmbIsActive.Text = "All";
                cmbIsActive.Focus();
            }
            else
            {

                txtSearch.Visible = (cmbFilter.Text.Trim() != "None");
                cmbIsActive.Visible = false;
                cmbRoles.Visible = false;

                if (cmbFilter.Text.Trim() == "None")
                {
                    txtSearch.Visible = false;
                    _dtUsers.DefaultView.RowFilter = "";
                }
                else
                    txtSearch.Enabled = true;

                txtSearch.Text = "";
                txtSearch.Focus();
            }
        }
        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
             string FilterColumn = "";

            switch (cmbFilter.Text)
            {
                case "User ID":
                    FilterColumn = "UserID";
                    break;

                case "Full Name":
                    FilterColumn = "FullName";
                    break;

                case "Email":
                    FilterColumn = "Email";
                    break;

                case "Username":
                    FilterColumn = "Username";
                    break;

                case "Is Active":
                    FilterColumn = "Is Active";
                    break;

                case "Role":
                    FilterColumn = "Role";
                    break;

                default:
                    FilterColumn = "None";
                    break;

            }

            if (txtSearch.Text.Trim() == "" || FilterColumn == "None")
            {
                _dtUsers.DefaultView.RowFilter = "";
                return;
            }

            if (FilterColumn == "UserID")
                _dtUsers.DefaultView.RowFilter = string.Format("[{0}] = {1}", FilterColumn, txtSearch.Text.Trim());
            else
                _dtUsers.DefaultView.RowFilter = string.Format("[{0}] LIKE '{1}%'", FilterColumn, txtSearch.Text.Trim());
        }
        private void cmbRoles_SelectedIndexChanged(object sender, EventArgs e)
        {
            string FilterColumn = "Role";
            string FilterValue = cmbRoles.Text.Trim();

            switch (FilterValue)
            {
                case "Admin":
                    FilterValue = "admin";
                    break;
                case "Manager":
                    FilterValue = "Manager";
                    break;
                case "Reception":
                    FilterValue = "Reception";
                    break;
                default:
                    FilterValue = "All";
                    break;
            }

            if (FilterValue == "All")
                _dtUsers.DefaultView.RowFilter = "";
            else
                _dtUsers.DefaultView.RowFilter = string.Format("[{0}] = '{1}'", FilterColumn, FilterValue);

            dgvUsers.ClearSelection();
        }
        private void cmbIsActive_SelectedIndexChanged(object sender, EventArgs e)
        {
            string FilterColumn = "IsActive";
            string FilterValue = cmbIsActive.Text.Trim();

            switch (FilterValue)
            {
                case "Yes":
                    FilterValue = "1";
                    break;
                case "No":
                    FilterValue = "0";
                    break;
                default:
                    FilterValue = "All";
                    break;
            }

            if (FilterValue == "All")
                _dtUsers.DefaultView.RowFilter = "";
            else
                _dtUsers.DefaultView.RowFilter = string.Format("[{0}] = {1}", FilterColumn, FilterValue);

            dgvUsers.ClearSelection();
        }
        private void txtSearch_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (cmbFilter.Text == "User ID")
                e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }
    }
}
