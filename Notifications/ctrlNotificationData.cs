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

namespace Hotel_Reservations_System
{
    public partial class ctrlNotificationData : UserControl
    {
        clsNotification _notification;
        private clsNotification.enNotificationType _NotificationType = clsNotification.enNotificationType.Information;
        public clsNotification.enNotificationType NotificationType
        {
            get
            {
                return _NotificationType;
            }
            set
            {
                _NotificationType = value;

                switch (_NotificationType)
                {

                    case clsNotification.enNotificationType.Information:
                        {
                           
                            picIcon.Image = Resources.BlueInfoPic;
                            pnlStyle.FillColor = Color.CornflowerBlue;
                            this.BackColor = Color.AliceBlue;
                            break;
                        }
                    case clsNotification.enNotificationType.Warning:
                        {
                           
                            picIcon.Image = Resources.warningIcon;
                            pnlStyle.FillColor = Color.Beige;
                            this.BackColor = Color.Wheat;
                            this.ForeColor = Color.Maroon;
                            break;
                        }
                    case clsNotification.enNotificationType.Error:
                        {
                           
                            picIcon.Image = Resources.ErrorPic;
                            pnlStyle.FillColor = Color.Maroon;
                            this.BackColor = Color.MistyRose;
                            break;
                        }
                }
            }
        }
        public ctrlNotificationData()
        {
            InitializeComponent();
        }

        private void ctrlNotificationData_Load(object sender, EventArgs e)
        {

        }

        public void LoadNotificationData(string title , string message, clsNotification.enNotificationType enType)
        {
            _NotificationType = enType;

            lblContent.Text = message;
            lblCreatedAt.Text = $"{DateTime.Now:yyyy-MM-dd HH:MM:ss}";
        }



        private void lblContent_Click(object sender, EventArgs e)
        {

        }

        private void lblCreatedAt_Click(object sender, EventArgs e)
        {
        }

        private void lblCreatedAt_Click_1(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void notifyIcon2_MouseDoubleClick(object sender, MouseEventArgs e)
        {

        }
    }
}
