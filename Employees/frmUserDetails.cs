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
    public partial class frmUserDetails : Form
    {
        int _UserID = -1;
        public frmUserDetails(int userID)
        {
            InitializeComponent();
            _UserID = userID;
        }

        private void frmUserDetails_Load(object sender, EventArgs e)
        {
            ctrlUserDetails1.LoadUserData(_UserID);
        }
    }
}
