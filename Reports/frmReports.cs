using SiticoneNetFrameworkUI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using HRS_BusinessLayer;

namespace Hotel_Reservations_System
{
    public partial class frmReports : Form
    {
        DataTable dt;
        public frmReports()
        {
            InitializeComponent();
        }

        private void frmReports_Load(object sender, EventArgs e)
        {
            lblCompletedReserevationCount.Text = clsReservation.GetCompletedReservationCount().ToString();
            lblCancelledReservationCount.Text = clsReservation.GetCanceledReservationCount().ToString();
            lblNoShowReservationsCount.Text = clsReservation.GetNoShowReservationCount().ToString();
            lblCheckedInReservationCount.Text = clsReservation.GetCheckedInReservationCount().ToString();

            dgvMonthlyReservations.DataSource = clsReservation.GetMonthlyReservations();

            dt = clsReservation.GetReservationStatusDT();
            chartStatus.DataSource = dt;
            chartStatus.BackColor = Color.Transparent;
            dt.Columns.Add("Label", typeof(string));
         
            foreach (DataRow row in dt.Rows)
            {
                string status = row["Status"].ToString();
                float count = Convert.ToInt32(row["Count"]);
                row["Label"] = $"{row["Status"]} - {count}";
            }

            chartStatus.LabelMember = "Label";  
            chartStatus.ValueMember = "Count";   
            chartStatus.Refresh();
        }


        private void lblNoShowReservationsCount_Click(object sender, EventArgs e)
        {

        }

        private void lblCompletedReserevationCount_Click(object sender, EventArgs e)
        {

        }

        private void siticoneGroupBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
