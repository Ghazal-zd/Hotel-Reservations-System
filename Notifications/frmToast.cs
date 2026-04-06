using Hotel_Reservations_System.Properties;
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
using static HRS_BusinessLayer.clsNotification;

namespace Hotel_Reservations_System
{
    public partial class frmToast : Form
    {
        Timer timer = new Timer();
        private clsNotification.enNotificationType _NotificationType = clsNotification.enNotificationType.Information;
    
        public frmToast(string title, string message, clsNotification.enNotificationType enNotificationType)
        {
            InitializeComponent();

            _NotificationType = enNotificationType;

            ctrlNotificationData1.LoadNotificationData(title, message, _NotificationType);
          

            timer.Interval = 3000;
            timer.Tick += (s, e) =>
            {
                timer.Stop();
                this.Close();
            };
        }
        protected override void OnShown(EventArgs e)
        {
            base.OnShown(e);

            var screen = Screen.PrimaryScreen.WorkingArea;

            this.Location = new Point(
                screen.Width - this.Width - 10,
                screen.Height - this.Height - 10
            );

            timer.Start();
        }
        private void frmToast_Load(object sender, EventArgs e)
        {
            ctrlNotificationData1.NotificationType = _NotificationType;
            this.BackColor = ctrlNotificationData1.BackColor;
        }

    }
}
