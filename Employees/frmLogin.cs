using DVLD.Classes;
using Guna.UI2.WinForms;
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
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }
        private void _LoadLoginInfo()
        {
            string username = "";
            string password = "";

            if (clsGlobal.GetStoredInfo(ref username, ref password))
            {
                txtUsername.Text = username;
                txtPassword.Text = password;
                chxRememberMe.Checked = true;
            }
            else
            {
                chxRememberMe.Checked = false;
            }
        }
       
        private void frmLogin_Load(object sender, EventArgs e)
        {
            this.Text = "Login";
            txtUsername.Focus();
            _LoadLoginInfo();
        }
        private async void btnLogin_Click(object sender, EventArgs e)
        {
            btnLogin.IsBusy = true;
            await Task.Delay(2000);

            string username = txtUsername.Text.Trim();
            string password = txtPassword.Text.Trim();

            clsEmployee employee = clsEmployee.GetUserByUsernameAndPassword(username, clsUtil.ComputeHash(password));

            if (employee == null)
            {
                btnLogin.IsBusy = false;
                MessageBox.Show("Sorry, username or password is not valid!", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }


            if (chxRememberMe.Checked)
            {
                clsGlobal.RememberUsernameAndPassword(username, password);
            }
            else
            {
                clsGlobal.RememberUsernameAndPassword("", "");
            }

            if (!employee.IsActive)
            {
                btnLogin.IsBusy = false;
                MessageBox.Show("Sorry,this account is non active!", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            btnLogin.IsBusy = false;
            clsGlobal.currentEmployee = employee;

            this.Hide();
            frmMain main = new frmMain(this);
            main.ShowDialog();
        }
    }
}
