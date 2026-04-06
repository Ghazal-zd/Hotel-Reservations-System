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
    public partial class frmChangePassword : Form
    {
        public frmChangePassword()
        {
            InitializeComponent();
        }

        private void btnSavePassword_Click(object sender, EventArgs e)
        {
            if (!this.ValidateChildren())
            {
                MessageBox.Show("Some fields are not valid!", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            string hashPassword = clsUtil.ComputeHash(txtConfirmPassword.Text);
            if (clsGlobal.currentEmployee.ChangePassword(hashPassword))
            {
                MessageBox.Show("Password Updated Successfully", "Done", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
                return;
            }
        }
        private void txtNewPassword_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtNewPassword.Text.Trim()))
            {
                errorProvider1.SetError(txtConfirmPassword, "This field is required!");
            }
            else
            {
                errorProvider1.SetError(txtConfirmPassword, null);
            }
        }

        private void txtConfirmPassword_Validating(object sender, CancelEventArgs e)
        {
            if (txtConfirmPassword.Text.Trim() != txtNewPassword.Text.Trim())
            {
                e.Cancel = true;
                errorProvider1.SetError(txtConfirmPassword, "Password Confirmation does not match New Password!");
                return;
            }
            else
            {
                errorProvider1.SetError(txtConfirmPassword, null);
            }
            if (string.IsNullOrEmpty(txtConfirmPassword.Text.Trim())) 
            {
                e.Cancel = true;
                errorProvider1.SetError(txtConfirmPassword, "This field is required!");
            }
            else
            {
                errorProvider1.SetError(txtConfirmPassword, null);
            }
        }

        private void txtCurrentPassword_Validating(object sender, CancelEventArgs e)
        {
            if (clsUtil.ComputeHash(txtCurrentPassword.Text.Trim()) != clsGlobal.currentEmployee.Password.Trim())
            {
                e.Cancel = true;
                errorProvider1.SetError(txtCurrentPassword, "Not valid Password");
            }
            else
            {
                errorProvider1.SetError(txtCurrentPassword, null);

            }
        }
    }
}
