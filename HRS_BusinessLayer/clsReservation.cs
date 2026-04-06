using HRS_DataAccessLayer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRS_BusinessLayer
{
    public class clsReservation
    {
        public enum enReservationStatus { Reserved = 1, CheckIn = 2, NoShow = 3, Cancel = 4, Completed = 5 }
        public enReservationStatus ReservationStatus { get; set; }
        public string ReservationStatusText
        {
            get
            {
                switch (ReservationStatus)
                {
                    case enReservationStatus.Reserved:
                        return "Reserved";
                    case enReservationStatus.CheckIn:
                        return "Checked in";
                    case enReservationStatus.NoShow:
                        return "No Show";
                    case enReservationStatus.Cancel:
                        return "Cancelled";
                    case enReservationStatus.Completed:
                        return "Completed";
                }
                return "Un Known";
            }
        }
        enum enMode { AddNew = 1, Update = 2 }
        enMode _mode;
        public int ReservationID { get; set; }
        public int RoomID { get; set; }
        public clsRoom RoomInfo { get; set; }
        public int CustomerID { get; set; }
        public clsCustomer CustomerInfo { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime ExitDate { get; set; }
        public int InitialReservationDays { get; set; }
        public decimal InitialTotalDueAmount { get; set; }
        public string InitialCheckNotes { get; set; }
        public DateTime ? ActualCheckInDate {  get; set; }
        public decimal RoomPriceAtReservation {  get; set; }
        public clsReservation()
        {
            this.ReservationID = -1;
            this.RoomID = -1;
            this.CustomerID = -1;
            this.StartDate = DateTime.Now;
            this.ExitDate = DateTime.Now;
            this.InitialReservationDays = 0;
            this.InitialTotalDueAmount = 0;
            this.InitialCheckNotes = "";
            this.ActualCheckInDate = null;
            this.RoomPriceAtReservation = 0;
            _mode = enMode.AddNew;
        }
        public clsReservation(int reservationID, int roomID, int customerID, DateTime startDate, DateTime exitDate,
            int initialReservationDays, decimal initialTotalDueAmount, string initialCheckNotes, enReservationStatus reservationStatus,
            DateTime? actualCheckInDate, decimal roomPriceAtReservation)
        {
            ReservationID = reservationID;
            RoomID = roomID;
            RoomInfo = clsRoom.Find(roomID);
            CustomerID = customerID;
            CustomerInfo = clsCustomer.Find(customerID);
            StartDate = startDate;
            ExitDate = exitDate;
            InitialReservationDays = initialReservationDays;
            InitialTotalDueAmount = initialTotalDueAmount;
            InitialCheckNotes = initialCheckNotes;
            ReservationStatus = reservationStatus;
            ActualCheckInDate = actualCheckInDate;
            RoomPriceAtReservation = roomPriceAtReservation;
            _mode = enMode.Update;
        }
        public static Task<DataTable> GetAllReservations(int pageNumber, int rowsPerPage)
        {
            return clsReservationData.GetAllReservations(pageNumber,rowsPerPage);
        }
        public static DataTable GetAllReservationByRoomID(int roomID)
        {
            return clsReservationData.GetAllReservationByRoomID(roomID);
        }
        public DataTable GetRoomReservation()
        {
            return GetAllReservationByRoomID(this.RoomID);
        }
        public static DataTable GetAllReservationByCustomerID(int customerID)
        {
            return clsReservationData.GetAllReservationsByGuestID(customerID);
        }
        public static clsReservation Find(int ReservationID)
        {
            int customerID = -1, roomID = -1, initialReservationDays = -1;
            string initialCheckNotes = "";
            decimal initialTotalDueAmount = 0, roomPriceAtReservation = 0;
            byte reservationStatus = 1;
            DateTime startDate = DateTime.Now, exitDate = DateTime.Now;
            Nullable<DateTime>actualCheckInDate = DateTime.Now;

            if (clsReservationData.GetReservationByID(ReservationID, ref roomID, ref customerID, ref startDate, ref exitDate,
                ref initialReservationDays, ref initialTotalDueAmount, ref initialCheckNotes,ref reservationStatus,ref actualCheckInDate,ref roomPriceAtReservation))
                return new clsReservation(ReservationID, roomID, customerID, startDate, exitDate, initialReservationDays, initialTotalDueAmount,
                    initialCheckNotes, (enReservationStatus)reservationStatus, actualCheckInDate,roomPriceAtReservation);

            return null;
        }
        public bool _AddNewReservation()
        {
            ReservationID = clsReservationData.AddNewReservation(CustomerID, RoomID, StartDate, ExitDate, InitialReservationDays, InitialTotalDueAmount, InitialCheckNotes,ActualCheckInDate,(byte)ReservationStatus,RoomPriceAtReservation);
            if (ReservationID != -1)
            {
                clsReservationEvents.OnReservationCreated(ReservationID,RoomID);
                return true;
            }
            return false;
        }
        public static async Task ProcessReservationNotificationsAsync()
        {
            var checkInIds = await clsReservationData.GetReservationApproachingCheckIn();
            var checkOutIds = await clsReservationData.GetReservationApproachingCheckOut();

            if (!checkInIds.Any() && !checkOutIds.Any()) return;
            await clsReservationData.MarkNotificationsSentAsync(checkInIds.Concat(checkOutIds));

            foreach (int id in checkOutIds)
            {
                clsReservationEvents.OnReservationApproachingCheckOut(id);
            }
            
            foreach (int id in checkInIds)
            {
                clsReservationEvents.OnReservationApproachingCheckIn(id);
            }

        }
        public static int GetTodayCheckoutCount()
        {
            return clsReservationData.GetTodayCheckoutCount();
        }
        public static int GetTodayCheckInsCount()
        {
            return clsReservationData.GetTodayCheckInsCount();
        }
        public bool _UpdateReservation()
        {
            return clsReservationData.UpdateReservation(ReservationID,CustomerID,RoomID,StartDate,ExitDate,InitialReservationDays,InitialTotalDueAmount,InitialCheckNotes,(byte)ReservationStatus,ActualCheckInDate, RoomPriceAtReservation);
        }
        public bool Save()
        {
            switch (_mode)
            {
                case enMode.AddNew:
                    if (_AddNewReservation())
                    {
                        _mode = enMode.Update;
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                case enMode.Update:
                    {
                        return _UpdateReservation();
                    }
            }
            return false;
        }
        public static bool Delete(int reservationID)
        {
            return clsReservationData.DeleteReservation(reservationID);
        }
        public static int GetReservationsCount()
        {
            return clsReservationData.GetReservationsCount();
        }    
        public bool CheckIn()
        {
            clsReservationEvents.OnRoomOccupied(RoomID);
            return clsReservationData.SetCheckIn(this.ReservationID,this.RoomID);
        }
        public bool IsOverlappingReservation()
        {
            return clsReservationData.IsReservationExist(StartDate, ExitDate, RoomID, ReservationID);
        }
        public static bool CheckNoShowReservations()
        {
            return clsReservationData.CheckNoShowReservations();
        }
        public bool Cancel()
        {
            return clsReservationData.Cancel(ReservationID);
        } 
        public static DataTable GetMonthlyReservations()
        {
            return clsReservationData.GetMonthlyReservations();
        }
        public static DataTable GetReservationStatusDT()
        {
            return clsReservationData.GetReservationStatusDT();
        }
        public static int GetCompletedReservationCount()
        {
            return clsReservationData.GetCompletedReservationsCount();
        }
        public static int GetCanceledReservationCount()
        {
            return clsReservationData.GetCanceledReservationsCount();
        }
        public static int GetNoShowReservationCount()
        {
            return clsReservationData.GetNoShowReservationsCount();
        }
        public static int GetCheckedInReservationCount()
        {
            return clsReservationData.GetCheckedInReservationsCount();
        }
        public static DataTable GetCheckInsReservation()
        {
            return clsReservationData.GetCheckInsReservation();
        }
        public static DataTable GetCheckOutsReservation()
        {
            return clsReservationData.GetCheckOutsReservation();
        }
        public static double GetOccupancyRate()
        {
            return Math.Ceiling(clsReservationData.GetOccupancyRate());
        }
    }
}
