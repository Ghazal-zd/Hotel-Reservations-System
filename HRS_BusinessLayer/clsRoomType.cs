using HRS_DataAccessLayer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRS_BusinessLayer
{
    public class clsRoomType
    {
        public enum enMode { AddNew = 0, Update = 1 };
        public enMode Mode = enMode.AddNew;
        public enum enRoomType { Single = 1, Double = 2, Suite = 3 };
        public enRoomType RoomTypeID { set; get; }
        public string RoomTypeName { set; get; }
        public decimal Price { set; get; }
        private clsRoomType()
        {
            this.RoomTypeID = clsRoomType.enRoomType.Single;
            this.RoomTypeName = "";
            this.Price = 0;
            Mode = enMode.AddNew;
        }
        public clsRoomType(clsRoomType.enRoomType ID, string TypeName, decimal BasePrice)
        {
            this.RoomTypeID = ID;
            this.RoomTypeName = TypeName;
            this.Price = BasePrice;
            Mode = enMode.Update;
        }
        private bool _AddNewTestType()
        {
            RoomTypeID =  (enRoomType)clsRoomTypeData.AddNewRoomType(this.RoomTypeName, this.Price);
            return (byte)RoomTypeID != -1;
        }
        private bool _UpdateTestType()
        {
            return clsRoomTypeData.UpdateRoomTypeInfo((byte)RoomTypeID,RoomTypeName,Price);
        }
        public static clsRoomType Find(clsRoomType.enRoomType RoomTypeID)
        {
            string RoomTypeName = "";
            decimal RoomTypePrice = 0;

            if (clsRoomTypeData.GetRoomTypeInfoByID((int)RoomTypeID, ref RoomTypeName, ref RoomTypePrice))
                return new clsRoomType(RoomTypeID,RoomTypeName, RoomTypePrice);
            else
                return null;

        }
        public bool Save()
        {
            switch (Mode)
            {
                case enMode.AddNew:
                    {
                        if (_AddNewTestType())
                        {

                            Mode = enMode.Update;
                            return true;
                        }

                        return false;
                    }
                case enMode.Update:
                    return _UpdateTestType();
            }

            return false;
        }
    }
}
