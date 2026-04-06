using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRS_DataAccessLayer
{
    public class clsPaymentData
    {
        public static DataTable GetAllPayments()
        {
            DataTable dt = new DataTable();
            using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.connectionString))
            {
                using (SqlCommand command = new SqlCommand("select * from Payments", connection))
                {
                    try
                    {
                        connection.Open();
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.HasRows) dt.Load(reader);
                        }
                    }
                    catch (Exception ex)
                    {
                        dt = null;
                    }
                }
            }
            return dt;
        }
        public static int AddNewPaymentRecord(int reservationID, int returnID, decimal actualAmountDue, decimal actualFinalAmountDue, decimal remainingAmount,
            decimal refundAmount, DateTime transactionDate, DateTime actualTransactionDate)
        {
            int paymentID = -1;

            using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.connectionString))
            {
                using (SqlCommand command = new SqlCommand("SP_AddPaymentRecord", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;

                    command.Parameters.AddWithValue("@reservationID", reservationID);
                    command.Parameters.AddWithValue("@returnID", returnID);
                    command.Parameters.AddWithValue("@actualAmountDue", actualAmountDue);
                    command.Parameters.AddWithValue("@actualFinalAmountDue", actualFinalAmountDue);
                    command.Parameters.AddWithValue("@remainingAmount", remainingAmount);
                    command.Parameters.AddWithValue("@refundAmount", refundAmount);
                    command.Parameters.AddWithValue("@transactionDate", transactionDate);
                    command.Parameters.AddWithValue("@actualTransactionDate", actualTransactionDate);

                    SqlParameter pPaymentID = new SqlParameter("@NewPaymentID", SqlDbType.Int);
                    pPaymentID.Direction = ParameterDirection.Output;
                    command.Parameters.Add(pPaymentID);

                    try
                    {
                        connection.Open();
                        command.ExecuteNonQuery();
                        paymentID = (int)pPaymentID.Value;

                    }
                    catch (Exception ex)
                    {
                        paymentID = -1;
                    }
                }
            }
            return paymentID;
        }
    }
}