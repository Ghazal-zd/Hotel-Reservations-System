using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;
using System.Text;
using System.Threading.Tasks;

namespace HRS_DataAccessLayer
{
    public class clsRoomReturnData
    {
        public static int AddNewRoomReturnRecord(int actualStayDays, string finalRoomCheckNotes,
            decimal? extraCharges, DateTime transactionDate, int returnedBy,DateTime actualCheckOutDate,int reservationID,decimal finalAmountDue,
            decimal remainingAmount,decimal refundAmount,DateTime actualTransactionDate)
        {
            int ReturnID = -1;

            using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.connectionString))
            {
                using (SqlCommand command = new SqlCommand("SP_AddReturnRoomRecord", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;

                    command.Parameters.AddWithValue("@actualStayDays", actualStayDays);
                    command.Parameters.AddWithValue("@transactionDate", transactionDate);
                    command.Parameters.AddWithValue("@actualCheckOutDate", actualCheckOutDate);
                    command.Parameters.AddWithValue("@reservationID", reservationID);
                    command.Parameters.AddWithValue("@ActualFinalAmountDue", finalAmountDue);
                    command.Parameters.AddWithValue("@remainingAmount", remainingAmount);
                    command.Parameters.AddWithValue("@refundAmount", refundAmount);
                    command.Parameters.AddWithValue("@actualTransactionDate", DateTime.Today);
                    command.Parameters.AddWithValue("@returnedBy", returnedBy);

                    if (extraCharges != null)
                        command.Parameters.AddWithValue("@extraCharges", extraCharges);
                    else
                        command.Parameters.AddWithValue("@extraCharges", System.DBNull.Value);

                    if (finalRoomCheckNotes != "" && finalRoomCheckNotes != null)
                        command.Parameters.AddWithValue("@finalRoomCheckNotes", finalRoomCheckNotes);
                    else
                        command.Parameters.AddWithValue("@finalRoomCheckNotes", System.DBNull.Value);

                    SqlParameter pReturnID = new SqlParameter("@ReturnID", SqlDbType.Int);
                    pReturnID.Direction = ParameterDirection.Output;
                    command.Parameters.Add(pReturnID);

                    try
                    {
                        connection.Open();
                        command.ExecuteNonQuery();
                        ReturnID = (int)pReturnID.Value;
                    }
                    catch (Exception ex)
                    {
                        ReturnID = -1;
                    }
                }
            }
            return ReturnID;
        }
        public static bool UpdateRoomReturnRecord(int returnID, int actualStayDays, string finalRoomCheckNotes,
            decimal? extraCharges, DateTime transactionDate, int returnedBy,DateTime actualCheckOutDate)
        {
            int RowsAffected = 0;
            string query = @"UPDATE [dbo].[RoomReturn]
                                SET [ActualCheckOutDate] = @actualCheckOutDate
                                   ,[ActualStayDays] = @actualStayDays
                                   ,[FinalRoomCheckNotes] = @finalRoomCheckNotes
                                   ,[ExtraCharges] = @extraCharges
                                   ,[TransactionDate] = @transactionDate
                                   ,[ReturnedBy] = @returnedBy
                              WHERE ReturnID = @returnID";

            using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.connectionString))
            {
                using (SqlCommand command = new SqlCommand(query, connection))
                {

                    command.Parameters.AddWithValue("@returnID", returnID);
                    command.Parameters.AddWithValue("@actualStayDays", actualStayDays);
                    command.Parameters.AddWithValue("@extraCharges", extraCharges);
                    command.Parameters.AddWithValue("@transactionDate", transactionDate);
                    command.Parameters.AddWithValue("@actualCheckOutDate", actualCheckOutDate);

                    if (extraCharges != null)
                        command.Parameters.AddWithValue("@extraCharges", extraCharges);
                    else
                        command.Parameters.AddWithValue("@extraCharges", System.DBNull.Value);

                    if (finalRoomCheckNotes != "" && finalRoomCheckNotes != null)
                        command.Parameters.AddWithValue("@finalRoomCheckNotes", finalRoomCheckNotes);
                    else
                        command.Parameters.AddWithValue("@finalRoomCheckNotes", System.DBNull.Value);
                    try
                    {
                        connection.Open();
                       RowsAffected = command.ExecuteNonQuery();
                        
                    }
                    catch (Exception ex)
                    {
                        RowsAffected = -1;
                    }
                }
            }
            return (RowsAffected > 0);
        }
        public static DataTable GetAllRoomReturns()
        {
            DataTable dt = new DataTable();
            string query = "select * from RoomReturn";
            using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.connectionString))
            {
                using (SqlCommand command = new SqlCommand(query, connection))
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

       
    }
}
