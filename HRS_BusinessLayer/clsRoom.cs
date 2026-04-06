using HRS_DataAccessLayer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRS_BusinessLayer
{
    public class clsRoom
    {
        private enum enMode {AddNew = 1, Update = 2 }
        enMode _mode;
        public enum enRoomStatus { Available = 1, Occupied = 2, Cleaning = 3, OutOfService = 4 }
        public int RoomID {  get; set; }
        public clsRoomType.enRoomType RoomTypeID {  get; set; }
        public string RoomTypeText
        {
            get
            {

                switch (RoomTypeID)
                {
                    case clsRoomType.enRoomType.Single:
                        return "Single";

                    case clsRoomType.enRoomType.Double:
                        return "Double";

                    case clsRoomType.enRoomType.Suite:
                        return "Suite";

                }
                return "Unknown";
            }
        }
        public enRoomStatus RoomStatus { get; set; }
        public string RoomStatusText
        {
            get
            {
                switch (RoomStatus)
                {
                    case enRoomStatus.Available:
                        return "Available";
                    case enRoomStatus.Occupied:
                        return "Occupied";
                    case enRoomStatus.Cleaning:
                        return "Cleaning";
                    case enRoomStatus.OutOfService:
                        return "Out of service";
                }
                return "Unknown";
            }
        }
        public string RoomFeatures {  get; set; }
        public DataTable FeaturesDT { get; set; }
        public decimal RoomFee { get; set; }
        public clsRoom()
        {
            this.RoomID = -1;
            this.RoomStatus=enRoomStatus.Available;
            this.RoomTypeID=clsRoomType.enRoomType.Single;
            this.RoomFee=0;
            this.RoomFeatures = "";
            _mode = enMode.AddNew;
        }
        public clsRoom(int roomID, clsRoomType.enRoomType roomType, enRoomStatus roomStatus, string roomFeatures, decimal roomFee)
        {
            RoomID = roomID;
            RoomTypeID = roomType;
            RoomStatus = roomStatus;
            RoomFeatures = roomFeatures;
            RoomFee = roomFee;
            _mode= enMode.Update;
        }
        public static clsRoom Find(int RoomID)
        {
            byte RoomStatus = 1;
            int RoomTypeID = 1;
            decimal RoomFee = 0;
            string RoomFeatures = "";
           
            if (clsRoomData.GetRoomByID(RoomID, ref RoomStatus, ref RoomTypeID, ref RoomFee))
                return new clsRoom(RoomID, (clsRoomType.enRoomType)RoomTypeID, (enRoomStatus)RoomStatus, RoomFeatures, RoomFee);

            return null;
        }
        public static DataTable GetAllRooms()
        {
            return clsRoomData.GetAllRooms();
        }
        public bool _AddNewRoom()
        {
            RoomID = clsRoomData.AddNewRoom((int)RoomTypeID, (byte)RoomStatus, RoomFee, FeaturesDT);
            return (RoomID != -1);
        }
        public bool _UpdateRoom()
        {
            return clsRoomData.UpdateRoom(RoomID,(int)RoomTypeID,RoomFee, FeaturesDT);
        }
        public static bool Delete(int RoomID)
        {
            return clsRoomData.DeleteRoom(RoomID);
        }
        public DataTable GetRoomFeatures()
        {
            return clsFeatureData.GetRoomFeatures(this.RoomID);
        }
        public HashSet<int> GetRoomFeatureIDs()
        {
            return clsFeatureData.GetRoomFeatureIDs(this.RoomID);
        }
        public decimal GetTotalFeaturesCost()
        {
            return clsFeatureData.GetTotalFeaturePrice(this.RoomID);
        }
        public bool Save()
        {
            switch (_mode)
            {
                case enMode.AddNew:
                    {
                        if (_AddNewRoom())
                        {
                            _mode = enMode.Update;
                            return true;
                        }

                        return false;
                    }
                case enMode.Update:
                    {
                        return _UpdateRoom();
                    }
            }
            return false;
        }
        public static int GetRoomsCount()
        {
            return clsRoomData.GetRoomsCount();
        }
        public static int GetAvailableRoomsCount()
        {
            return clsRoomData.GetAvailableRoomsCount();
        }
        public static int GetOccupiedRoomsCount()
        {
            return clsRoomData.GetOccupiedRoomsCount();
        }
        public bool IsRoomReservedOrOccupied()
        {
            return clsRoomData.IsRoomReservedOrOccupied(RoomID);
        }

    }
}
