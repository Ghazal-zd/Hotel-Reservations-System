using HRS_DataAccessLayer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRS_BusinessLayer
{
    public class clsPayment
    {
        enum enMode { AddNew = 1, Update = 2 }
        enMode _mode;
        public int PaymentID {  get; set; }
        public int ReservationID {  get; set; }
        public clsReservation ReservationInfo { get; set; }
        public int ReturnID {  get; set; }
        public clsRoomReturn RoomReturnInfo {  get; set; }
        public decimal ActualAmountDue {  get; set; }
        public decimal ActualFinalAmountDue {  get; set; }
        public decimal RemainingAmount { get; set; }
        public decimal RefundAmount { get; set; }
        public DateTime TransactionDate { get; set; }
        public DateTime ActualTransactionDate { get; set; }
        public clsPayment()
        {
            this.PaymentID = -1;
            this.ReservationID = -1;
            this.ReturnID = -1;
            this.ActualAmountDue = 0;
            this.ActualFinalAmountDue = 0;
            this.RemainingAmount = 0;
            this.RefundAmount = 0;
            this.TransactionDate=DateTime.Now;
            this.ActualTransactionDate = DateTime.Now;
            _mode = enMode.AddNew;
        }
        public clsPayment(int paymentID, int reservationID, int returnID, decimal actualAmountDue, decimal actualFinalAmountDue,
            decimal remainingAmount, decimal refundAmount, DateTime transactionDate, DateTime actualTransactionDate)
        {
            PaymentID = paymentID;
            ReservationID = reservationID;
            ReservationInfo = clsReservation.Find(reservationID);
            ReturnID = returnID;
            ActualAmountDue = actualAmountDue;
            ActualFinalAmountDue = actualFinalAmountDue;
            RemainingAmount = remainingAmount;
            RefundAmount = refundAmount;
            TransactionDate = transactionDate;
            ActualTransactionDate = actualTransactionDate;
            _mode = enMode.Update
                ;
        }
        public static DataTable GetAllPayments()
        {
            return clsPaymentData.GetAllPayments();
        }
        public bool _AddNewPayment()
        {
            this.PaymentID = clsPaymentData.AddNewPaymentRecord(ReservationID, ReturnID, ActualAmountDue, ActualFinalAmountDue, RemainingAmount, RefundAmount, TransactionDate, ActualTransactionDate);
            return (this.PaymentID != -1);
        }
        public bool _UpdatePayment()
        {
            return false;
        }
        public bool Save()
        {
            switch (_mode)
            {
                case enMode.AddNew:
                    {
                        if (_AddNewPayment())
                            _mode = enMode.Update;
                        return true;
                    }
                case enMode.Update:
                    return _UpdatePayment();
            }
            return false;
        }
    }
}
