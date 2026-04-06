using HRS_DataAccessLayer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Net.Http.Headers;
using System.Runtime.InteropServices.ComTypes;
using System.Text;
using System.Threading.Tasks;

namespace HRS_BusinessLayer
{
    public class clsRoomReturn
    {
        enum enMode { AddNew = 1, Update = 2 }
        enMode _mode;
        public int ReturnID {  get; set; }
        public DateTime ActualCheckOutDate { get; set; }
        public int ActualStayDays {  get; set; }
        public string FinalRoomCheckNotes {  get; set; }
        public decimal ExtraCharges {  get; set; }
        public DateTime TransactionDate { get; set; }
        public int ReturnedBy {  get; set; }
        public int ReservationID {  get; set; }
        public clsReservation ReservationInfo { get; set; }
        public decimal ActualFinalAmountDue { get; set; }
        public decimal RemainingAmount { get; set; }
        public decimal RefundAmount { get; set; }
        public clsRoomReturn()
        {
            ReturnID = -1;
            ActualCheckOutDate = DateTime.Now;
            ActualStayDays = 0;
            FinalRoomCheckNotes = "";
            ExtraCharges = 0;
            TransactionDate = DateTime.Now;
            ReturnedBy = -1;
            _mode = enMode.AddNew;
        }
        public clsRoomReturn(int returnID, DateTime actualCheckOutDate,int actualStayDays, string finalRoomCheckNotes,decimal extraChanges, DateTime extraCharges,int returnedBy)
        {
            ReturnID = returnID;
            ActualCheckOutDate = actualCheckOutDate;
            ActualStayDays = actualStayDays;
            FinalRoomCheckNotes = finalRoomCheckNotes;
            ExtraCharges = extraChanges;
            TransactionDate = DateTime.Now;
            ReturnedBy = returnedBy;
            _mode =enMode.Update; 
        }
        private bool _AddNewReturnRoomRecord()
        {
            ReturnID= clsRoomReturnData.AddNewRoomReturnRecord(ActualStayDays,FinalRoomCheckNotes,ExtraCharges,TransactionDate,ReturnedBy,ActualCheckOutDate,ReservationID, ((ActualStayDays*ReservationInfo.RoomPriceAtReservation) + ExtraCharges),RemainingAmount,RefundAmount,DateTime.Today);
            return (ReturnID != -1);
        }
        private bool _UpdateReturnRoomRecord()
        {
            return clsRoomReturnData.UpdateRoomReturnRecord(ReturnID, ActualStayDays, FinalRoomCheckNotes, ExtraCharges, TransactionDate, ReturnedBy, ActualCheckOutDate);
        }
        public bool Save()
        {
            switch (_mode)
            {
                case enMode.AddNew:
                    {
                        if (_AddNewReturnRoomRecord())
                        {
                            _mode = enMode.Update;
                            return true;
                        }
                        return false;
                    }
                case enMode.Update:
                    return _UpdateReturnRoomRecord();
            }
            return false;
        }
    }
}
