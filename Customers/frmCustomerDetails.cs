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
    public partial class frmCustomerDetails : Form
    {
        int _guestID = -1;
        public frmCustomerDetails(int guestID)
        {
            InitializeComponent();
            _guestID = guestID;
        }

        private void frmCustomerDetails_Load(object sender, EventArgs e)
        {
            ctrlCustomerDataWithFilter1.LoadGuestInformation(_guestID);
            ctrlCustomerDataWithFilter1.FilterEnabled = false;
        }
    }
}
