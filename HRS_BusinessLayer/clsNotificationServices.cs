using HRS_DataAccessLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static HRS_BusinessLayer.clsNotification;
using static HRS_BusinessLayer.clsReservation;

namespace HRS_BusinessLayer
{
    public class clsNotificationServices
    {
        public event Action<string, string,clsNotification.enNotificationType> OnNotificationReady;
        string title = "";
        string notificationContent = "";
        clsNotification.enNotificationType enNotificationType = clsNotification.enNotificationType.Information;                                                             
        public clsNotificationServices()
        {
        } 
        public void OnReservationCreated(object sender, clsReservationEvents.ReservationCreatedEventArgs e)
        {
            title = "New Reservation";
            notificationContent = $"New reservation created with ID = {e.ReservationID}   Guest Reserved Room{e.RoomID}";
            enNotificationType = clsNotification.enNotificationType.Information;
            clsNotification notifi = new clsNotification
            {
                NotificationType = enNotificationType,
                NotificationContent = notificationContent,
                ToRoleID = (int)clsRole.enRoles.Manager
            };

            notifi.AddNewNotification();

            clsNotification notifi2 = new clsNotification
            {
                NotificationType = enNotificationType,
                NotificationContent = notificationContent,
                ToRoleID = (int)clsRole.enRoles.Reception
            };

            notifi2.AddNewNotification();
            OnNotificationReady?.Invoke(title, notificationContent, enNotificationType);    
        }
        public void OnReservationComingUpToCheckIn(object sender, clsReservationEvents.ReservationUpComingEventArgs e)
        {
            title = "Reservation approaching check in.";
            notificationContent = $"Reservation with ID = {e.ReservationID} is approaching check_in.";
            enNotificationType = clsNotification.enNotificationType.Warning;

            clsNotification notifiReceptionToCheckInReservation = new clsNotification
            {
                NotificationType = enNotificationType,
                NotificationContent = notificationContent,
                ToRoleID = (int)clsRole.enRoles.Reception
            };
            notifiReceptionToCheckInReservation.AddNewNotification();

            clsNotification notifiManagerToCheckInReservation = new clsNotification
            {
                NotificationType = enNotificationType,
                NotificationContent = notificationContent,
                ToRoleID = (int)clsRole.enRoles.Manager
            };
            notifiManagerToCheckInReservation.AddNewNotification();
            OnNotificationReady?.Invoke(title, notificationContent, enNotificationType);

        }
        public void OnReservationComingUpToCheckOut(object sender, clsReservationEvents.ReservationUpComingEventArgs e)
        {
            title = "Reservation approaching check out.";
            notificationContent = $"Reservation with ID = {e.ReservationID} is approaching check_out.";
            enNotificationType= clsNotification.enNotificationType.Warning;

            clsNotification notifiReceptionToCheckInReservation = new clsNotification
            {
                NotificationType = enNotificationType,
                NotificationContent = notificationContent,
                ToRoleID = (int)clsRole.enRoles.Reception
            };
            notifiReceptionToCheckInReservation.AddNewNotification();

            clsNotification notifiManagerToCheckInReservation = new clsNotification
            {
                NotificationType = enNotificationType,
                NotificationContent = notificationContent,
                ToRoleID = (int)clsRole.enRoles.Manager
            };
            notifiManagerToCheckInReservation.AddNewNotification();
            OnNotificationReady?.Invoke(title, notificationContent,enNotificationType);

        }
        public void OnRoomOccupied(object sender, clsReservationEvents.RoomOccupiedEventArgs e)
        {
            title = "Room Occupied";
            notificationContent = $"Room {e.RoomID} is occupied on {e.CreatedAt.Date.ToShortDateString()} at {e.CreatedAt.ToShortTimeString()}.";
            enNotificationType = clsNotification.enNotificationType.Warning;

            clsNotification notifiReceptionAboutOccupiedRoom = new clsNotification
            {
                NotificationType = enNotificationType   ,
                NotificationContent = notificationContent,
                ToRoleID = (int)clsRole.enRoles.Reception
            };
            notifiReceptionAboutOccupiedRoom.AddNewNotification();

            clsNotification notifiManagerAboutOccupiedRoom = new clsNotification
            {
                NotificationType = enNotificationType,
                NotificationContent = notificationContent,
                ToRoleID = (int)clsRole.enRoles.Manager
            };
            notifiManagerAboutOccupiedRoom.AddNewNotification();
            OnNotificationReady?.Invoke(title, notificationContent, enNotificationType);
        }

    }
}
