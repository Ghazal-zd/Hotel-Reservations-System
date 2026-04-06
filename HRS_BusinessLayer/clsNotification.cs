using HRS_DataAccessLayer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;

namespace HRS_BusinessLayer
{
    public class clsNotification
    {
        public enum enNotificationType { Information = 1, Warning = 2, Error = 3 }
        public enNotificationType NotificationType {  get; set; }
        public int NotificationID {  get; set; }
        public string NotificationContent { get; set; }
        public byte ToRoleID { get; set; }
        public bool IsRead {  get; set; }
        public DateTime CreatedAt { get; set; }

        public clsNotification()
        {
            
            this.NotificationID = -1;
            this.NotificationType = enNotificationType.Information;
            this.NotificationContent = "";
            this.ToRoleID = 1;
            this.IsRead = false;
            this.CreatedAt = DateTime.Now;
        }
        public clsNotification( int notificationID, enNotificationType notificationType, 
            string notificationContent, byte toRoleID, bool isRead, DateTime createdAt)
        {
            NotificationID = notificationID;
            NotificationType = notificationType;
            NotificationContent = notificationContent;
            ToRoleID = toRoleID;
            IsRead = isRead;
            CreatedAt = createdAt;
        }
        public bool AddNewNotification()
        {
            NotificationID = clsNotificationData.AddNewNotification((byte)NotificationType, NotificationContent, ToRoleID, IsRead, CreatedAt);
            return (NotificationID!=-1);
        }
        public static DataTable GetNotificationByRoleID(byte roleID)
        {
            return clsNotificationData.GetNotificationByRoleID(roleID);
        }
    }
}
