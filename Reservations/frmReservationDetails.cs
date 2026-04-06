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
    public partial class frmReservationDetails : Form
    {
        int _ReservationID=-1;
        public frmReservationDetails(int reservationID)
        {
            InitializeComponent();
            _ReservationID = reservationID;
        }
        private void frmReservationDetails_Load(object sender, EventArgs e)
        {
            ctrlReservationDetails1.LoadReservationInformation(_ReservationID);
        }
    }
}
