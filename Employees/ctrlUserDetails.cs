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
    public partial class ctrlUserDetails : UserControl
    {

        public ctrlUserDetails()
        {
            InitializeComponent();
        }
        public void LoadUserData(int userID)
        {
            clsEmployee user = clsEmployee.Find(userID);
            if (user == null)
            {
                MessageBox.Show("No user with id = " +  userID,"Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
                return;
            }
            lblUserID.Text = user.EmployeeID.ToString();
            ctrlPersonData1.LoadBasicInfo(user.PersonID);
            lblRole.Text = user.RoleName;
            lblHireDate.Text = clsFormat.DateToShort(user.HireDate);
            lblUsername.Text = user.Username;
            chxIsActive.Checked =user.IsActive;
        }

       
        private void siticoneGroupBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
