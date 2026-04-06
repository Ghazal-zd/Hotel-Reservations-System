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
    public partial class frmAccountInfo : Form
    {
        public frmAccountInfo()
        {
            InitializeComponent();
        }

        private void btnChangePassword_Click(object sender, EventArgs e)
        {
            frmChangePassword frmChangePassword = new frmChangePassword();
            frmChangePassword.ShowDialog();
        }

        private void frmAccountInfo_Load(object sender, EventArgs e)
        {
            ctrlUserDetails1.LoadUserData(clsGlobal.currentEmployee.EmployeeID);
        }

        private void btnEditInformation_Click(object sender, EventArgs e)
        {
            frmAddUpdateUser frmAddUpdateUser=new frmAddUpdateUser(clsGlobal.currentEmployee.EmployeeID);
            frmAddUpdateUser.ShowDialog();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
