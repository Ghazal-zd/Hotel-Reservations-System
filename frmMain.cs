using HRS_BusinessLayer;
using SiticoneNetFrameworkUI;
using System;
using System.CodeDom;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static HRS_BusinessLayer.clsNotification;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Hotel_Reservations_System
{
    public partial class frmMain : Form
    {
        private frmLogin _frmLogin;
        clsNotificationServices notificationService = new clsNotificationServices();
        public frmMain(frmLogin frm)
        {
            InitializeComponent();
            _frmLogin = frm;
            notificationService.OnNotificationReady += ShowNotifyIcon;
            clsReservationEvents.ReservationApproachingCheckIn += notificationService.OnReservationComingUpToCheckIn;
            clsReservationEvents.ReservationApproachingCheckOut += notificationService.OnReservationComingUpToCheckOut;
        }
        protected override void OnFormClosed(FormClosedEventArgs e)
        {
            notificationService.OnNotificationReady -= ShowNotifyIcon;
            clsReservationEvents.ReservationCreated -= notificationService.OnReservationCreated;
            base.OnFormClosed(e);
        }
        public frmMain()
        {
            InitializeComponent();
        }
        private void btnAddNewReservation_Click(object sender, EventArgs e)
        {
            if (!clsGlobal.CheckRightPermissions(clsRole.enPermissions.AddNewReservation))
            {
                throw new UnauthorizedAccessException("Access Denied, You do not have permission!");
            }
            frmAddUpdateReservation frmAddUpdateReservation=new frmAddUpdateReservation();
            frmAddUpdateReservation.Show();
        }
        void _CheckPermissions()
        {
            var PermissionsDictionary = new Dictionary<clsRole.enPermissions, Control> 
            {
                {clsRole.enPermissions.AddNewReservation,btnAddNewReservation },
                {clsRole.enPermissions.ReservationList,btnReservationList },
                {clsRole.enPermissions.AddNewRoom,btnAddNewRoom},
                {clsRole.enPermissions.RoomList,btnRoomLIst},
                {clsRole.enPermissions.AddNewEmployee,btnAddNewUser },
                {clsRole.enPermissions.EmployeeList,btnUsersList },
                {clsRole.enPermissions.History,btnReports },
            };
            foreach(var item in PermissionsDictionary)
            {
                item.Value.Enabled = clsGlobal.CheckRightPermissions(item.Key);
            }
        }
        public async void _CheckNotifications()
        {
            await clsReservation.ProcessReservationNotificationsAsync();
        }
        private void _ResetDefaultInfo()
        {
            btnCheckOutGuest.Enabled = true;
            btnCheckInGuest.Enabled = true;

            lblCheckOutToday.Text = clsReservation.GetTodayCheckoutCount().ToString();
            lblCheckInsCount.Text = clsReservation.GetTodayCheckInsCount().ToString();

            btnCheckOutGuest.Enabled = !(lblCheckOutToday.Text.Trim() == "0");
            btnCheckInGuest.Enabled = !(lblCheckInsCount.Text.Trim() == "0");

            lblAvailableRooms.Text=clsRoom.GetAvailableRoomsCount().ToString();  
            lblOccupiedRooms.Text=clsRoom.GetOccupiedRoomsCount().ToString();
            lblLoggedAs.Text = clsGlobal.currentEmployee.Username;
            lblDate.Text = $"{DateTime.Now:D}";
            lblTime.Text = $"{DateTime.Now:T}";
            lblOccupencyRate.Text = clsReservation.GetOccupancyRate().ToString() + "%";
        }
        public void ShowNotifyIcon(string title, string message, clsNotification.enNotificationType enNotificationType)
        {
            frmToast toast = new frmToast(title,message,enNotificationType);
            toast.Show();
        }
        private void frmMain_Load(object sender, EventArgs e)
        {
            _ResetDefaultInfo();
            _CheckPermissions();
            _CheckNotifications();
        }
        private void btnEditReservation_Click(object sender, EventArgs e)
        {
            if (!clsGlobal.CheckRightPermissions(clsRole.enPermissions.ReservationList))
            {
                throw new UnauthorizedAccessException("Access Denied, You do not have permission!");
            }

            frmReservationList frmReservationList= new frmReservationList();   
            frmReservationList.ShowDialog();
        }
        private void btnAddNewRoom_Click(object sender, EventArgs e)
        {
            if (!clsGlobal.CheckRightPermissions(clsRole.enPermissions.AddNewRoom))
            {
                throw new UnauthorizedAccessException("Access Denied, You do not have permission!");
            }
            frmAddUpdateRoom frmAddUpdateRoom = new frmAddUpdateRoom();
            frmAddUpdateRoom.Show();
        }
        private void btnUsersList_Click(object sender, EventArgs e)
        {
            if (!clsGlobal.CheckRightPermissions(clsRole.enPermissions.EmployeeList))
            {
                throw new UnauthorizedAccessException("Access Denied, You do not have permission!");
            }
            frmUsersList frmUsersList= new frmUsersList();
            frmUsersList.Show();
        }
        private void btnShowHistory_Click(object sender, EventArgs e)
        {
            if (!clsGlobal.CheckRightPermissions(clsRole.enPermissions.History))
            {
                throw new UnauthorizedAccessException("Access Denied, You do not have permission!");
            }
            frmReports frmReports = new frmReports();
            frmReports.ShowDialog();
        }
        private void btnAddNewEmployee_Click(object sender, EventArgs e)
        {
            if (!clsGlobal.CheckRightPermissions(clsRole.enPermissions.AddNewEmployee))
            {
                throw new UnauthorizedAccessException("Access Denied, You do not have permission!");
            }
            frmAddUpdateUser frmAddUpdateUser=new frmAddUpdateUser();
            frmAddUpdateUser.Show();
        }
        private void guna2Button1_Click(object sender, EventArgs e)
        {
            frmCustomersList frmCustomersList=  new frmCustomersList();
            frmCustomersList.AllowChooseOption = false;
            frmCustomersList.ShowDialog();
        }
        private void guna2Button2_Click_1(object sender, EventArgs e)
        {
            frmRoomList frmRoomList= new frmRoomList();
            frmRoomList.AllowChooseOption = false;
            frmRoomList.ShowDialog();
        }
        private async Task _RefreshScreen()
        {
            _ResetDefaultInfo();
            _CheckPermissions();
            await clsReservation.ProcessReservationNotificationsAsync();
        }
        private async void btnRefresh_Click(object sender, EventArgs e)
        {
            btnRefreshScreen.IsRefreshing = true;
            await Task.Delay(2000);
            await _RefreshScreen();
            btnRefreshScreen.IsRefreshing = false;
        }
        public bool CheckNotifications()
        {
            if (clsNotification.GetNotificationByRoleID((byte)clsGlobal.currentEmployee.RoleID).Rows.Count == 0) 
            {
                MessageBox.Show("You have no notifications!", "No notifications", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            return true;
        }
        private void guna2Button3_Click(object sender, EventArgs e)
        {
            frmAddUpdateCustomer frmAddUpdateCustomer = new frmAddUpdateCustomer();
            frmAddUpdateCustomer.Show();
        }
        private void btnLogout_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to logout?", "Log out", MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes)
                return;

            clsGlobal.currentEmployee = null;
            this.Close();

            _frmLogin.Show();

        }
        private void btnReservation_Click(object sender, EventArgs e)
        {
            pnlReservationSubMenu.Visible = !pnlReservationSubMenu.Visible;
        }
        private void btnGuests_Click(object sender, EventArgs e)
        {
            pnlGuestContent.Visible = !pnlGuestContent.Visible;
        }
        private void btnRooms_Click(object sender, EventArgs e)
        {
            pnlRoomsContent.Visible=!pnlRoomsContent.Visible;
        }
        private void btnUsers_Click(object sender, EventArgs e)
        {
            pnlUsersContent.Visible=!pnlUsersContent.Visible;
        }
        private void guna2Button1_Click_1(object sender, EventArgs e)
        {
            frmAccountInfo frmAccountInfo = new frmAccountInfo();
            frmAccountInfo.ShowDialog();
        }
        private void btnShowAll_Click(object sender, EventArgs e)
        {
            if (!CheckNotifications()) return;
            frmNotifications frmNotifications = new frmNotifications();
            frmNotifications.ShowDialog();
        }
        private void btnNotifications_Click(object sender, EventArgs e)
        {
            if (!CheckNotifications()) return;
            frmNotifications frmNotifications = new frmNotifications();
            frmNotifications.ShowDialog();
        }
        private void btnCheckInGuest_Click(object sender, EventArgs e)
        {
            if (clsReservation.GetTodayCheckInsCount() == 0)
            {
                MessageBox.Show("No Reservation to check_in today", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            frmReservationList frmReservationList = new frmReservationList();
            frmReservationList.checkInsMode = true;
            frmReservationList.ShowDialog();

            //frmMain_Load(null, null);
        }
        private void btnCheckOutGuest_Click(object sender, EventArgs e)
        {
            if (clsReservation.GetTodayCheckoutCount() == 0)
            {
                MessageBox.Show("No Reservation to check_out today", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            frmReservationList frmReservationList = new frmReservationList();
            frmReservationList.checkOutsMode = true;
            frmReservationList.ShowDialog();

            //frmMain_Load(null, null);
        }
        private void btnAddGuest_Click(object sender, EventArgs e)
        {
            frmAddUpdateCustomer frmAddUpdateCustomer = new frmAddUpdateCustomer();
            frmAddUpdateCustomer.ShowDialog();
        }
        private void btnAddReservation_Click(object sender, EventArgs e)
        {
            frmAddUpdateReservation frmAddUpdateReservation = new frmAddUpdateReservation();
            frmAddUpdateReservation.ShowDialog();
        }
    }
}
