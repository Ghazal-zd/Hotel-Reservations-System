using HRS_BusinessLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using SiticoneNetFrameworkUI  ;

using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static HRS_BusinessLayer.clsNotification;

namespace Hotel_Reservations_System
{
    public partial class frmNotifications : Form
    {
        List<clsNotification> _notificationList;
        private int unreadCount = 0;
        public frmNotifications()
        {
            InitializeComponent();
        }

        private void frmNotifications_Load(object sender, EventArgs e)
        {
            listViewNotifications.View = View.Details;
            listViewNotifications.FullRowSelect = true;
            listViewNotifications.GridLines = true;

            listViewNotifications.Columns.Clear();
            listViewNotifications.Columns.Add("Icon", 70);
            listViewNotifications.Columns.Add("Content", 400);  
            listViewNotifications.Columns.Add("Date", 100);

            ImageList imgList = new ImageList();
            imgList.ImageSize = new Size(40, 35);
            imgList.ColorDepth = ColorDepth.Depth32Bit;

            imgList.Images.Add("Information", Properties.Resources.InformationIcon);
            imgList.Images.Add("Warning", Properties.Resources.warningIcon);
            imgList.Images.Add("Error", Properties.Resources.ErrorPic);
            listViewNotifications.SmallImageList = imgList;

            LoadNotifications();
        }
        private void LoadNotifications()
        {
            listViewNotifications.Items.Clear();
            unreadCount = 0;

            DataTable dt = GetNotificationByRoleID((byte)clsGlobal.currentEmployee.RoleID);
            if (dt.Rows.Count == 0)
            {
                MessageBox.Show("You have no notifications!","No notifications",MessageBoxButtons.OK,MessageBoxIcon.Warning);
                return;
            }
            DataView dv = dt.DefaultView;
            dv.Sort = "CreatedAt DESC";
            DataTable sortedDt = dv.ToTable();

            foreach (DataRow row in sortedDt.Rows)
            {
                string message = row["NotificationContent"].ToString();
                DateTime createdAt = Convert.ToDateTime(row["CreatedAt"]);
                bool isRead = Convert.ToBoolean(row["IsRead"]);
                enNotificationType type = (enNotificationType)Enum.Parse(typeof(enNotificationType), row["NotificationType"].ToString());

                ListViewItem item = new ListViewItem();
                switch (type)
                {
                    case enNotificationType.Information:
                        item.BackColor = Color.LightBlue;
                        break;

                    case enNotificationType.Warning:
                        item.BackColor = Color.AntiqueWhite;
                        break;

                    case enNotificationType.Error:
                        item.BackColor = Color.RosyBrown;
                        break;
                }
                item.ImageKey = type.ToString();
                item.SubItems.Add(message);
                item.SubItems.Add(createdAt.ToString("yyyy-MM-dd HH:mm"));

                //item.BackColor = isRead ? Color.White : Color.Wheat;
                if (!isRead) unreadCount++;

                listViewNotifications.Items.Add(item);
            }
            UpdateUnreadLabel();
        }
        private void UpdateUnreadLabel()
        {
            lblUnreadCount.Text = unreadCount.ToString();
        }

        private void listViewNotifications_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }

}
