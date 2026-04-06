using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Net;
using System.Net.NetworkInformation;
using System.Runtime.InteropServices.ComTypes;
using System.Text;
using System.Threading.Tasks;

namespace HRS_DataAccessLayer
{
    public class clsReservationData
    {
        public static async Task<DataTable> GetAllReservations(int pageNumber, int rowsPerPage)
        {
            DataTable dt = new DataTable();
            using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.connectionString))
            {
                using (SqlCommand command = new SqlCommand("SP_GetAllReservations", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@PageNumber", pageNumber);
                    command.Parameters.AddWithValue("@RowsPerPage", rowsPerPage);
                    try
                    {
                        connection.OpenAsync();
                        using (SqlDataReader reader = await command.ExecuteReaderAsync())
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
        public static bool GetReservationByID(int reservationID, ref int roomID, ref int customerID, ref DateTime startDate, ref DateTime exitDate,
            ref int initialReservationDays, ref decimal initialTotalDueAmount, ref string initialCheckNotes, ref byte reservationStatus,
            ref DateTime? actualCheckInDate, ref decimal roomPriceAtReservation)
        {
            bool isFound = false;
            using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.connectionString))
            {
                using (SqlCommand command = new SqlCommand("SP_GetReservationByID", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@reservationID", reservationID);
                    try
                    {
                        connection.Open();
                        using (SqlDataReader reader = command.ExecuteReader())
                            if (reader.Read())
                            {
                                isFound = true;
                                roomID = (int)reader["RoomID"];
                                customerID = (int)reader["CustomerID"];
                                startDate = (DateTime)reader["StartDate"];
                                exitDate = (DateTime)reader["ExitDate"];
                                initialReservationDays = (int)reader["InitialReservationDays"];
                                initialTotalDueAmount = (decimal)reader["InitialTotalDueAmount"];
                                initialCheckNotes = reader["InitialCheckNotes"] != DBNull.Value ? (string)reader["InitialCheckNotes"] : "No Notes";
                                roomPriceAtReservation = reader["RoomPriceAtReservation"] != DBNull.Value ? (decimal)reader["RoomPriceAtReservation"] : 0;
                                actualCheckInDate = reader["ActualCheckInDate"] != DBNull.Value ? (DateTime)reader["ActualCheckInDate"] : (DateTime?)null;
                                reservationStatus = (byte)reader["ReservationStatus"];
                            }
                    }
                    catch (Exception ex)
                    {
                        isFound = false;
                    }
                }
            }
            return isFound;
        }
        public static DataTable GetAllReservationsByGuestID(int CustomerID)
        {
            DataTable dt = new DataTable();
            string query = "select * from Reservations where CustomerID=@CustomerID";

            using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.connectionString))
            {
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@CustomerID", CustomerID);
                    try
                    {
                        connection.Open();
                        SqlDataReader reader = command.ExecuteReader();
                        if (reader.HasRows) dt.Load(reader);
                    }
                    catch (Exception ex)
                    {
                        dt = null;
                    }
                }
            }
            return dt;
        }
        public static int AddNewReservation(int customerID, int roomID, DateTime startDate, DateTime exitDate, int initialReservationDays,
            decimal initialTotalDueAmount, string initialCheckNotes, DateTime? actualCheckInDate, byte reservationStatus, decimal roomPriceAtReservation)
        {

            int ReservationID = -1;

            using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.connectionString))
            {
                using (SqlCommand command = new SqlCommand("SP_AddReservation", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;

                    command.Parameters.AddWithValue("@customerID", customerID);
                    command.Parameters.AddWithValue("@roomID", roomID);
                    command.Parameters.AddWithValue("@startDate", startDate);
                    command.Parameters.AddWithValue("@exitDate", exitDate);
                    command.Parameters.AddWithValue("@initialReservationDays", initialReservationDays);
                    command.Parameters.AddWithValue("@initialTotalDueAmount", initialTotalDueAmount);
                    command.Parameters.AddWithValue("@NotificationSent", 0);

                    if (initialCheckNotes != "" && initialCheckNotes != null)
                        command.Parameters.AddWithValue("@initialCheckNotes", initialCheckNotes);
                    else
                        command.Parameters.AddWithValue("@initialCheckNotes", System.DBNull.Value);

                    command.Parameters.AddWithValue("@reservationStatus", reservationStatus);

                    if (actualCheckInDate.HasValue)
                        command.Parameters.AddWithValue("@actualCheckInDate", actualCheckInDate);
                    else
                        command.Parameters.AddWithValue("@actualCheckInDate", System.DBNull.Value);


                    command.Parameters.AddWithValue("@RoomPriceAtReservation", roomPriceAtReservation);

                    SqlParameter pReservationID = new SqlParameter("@ReservationID", SqlDbType.Int);
                    pReservationID.Direction = ParameterDirection.Output;
                    command.Parameters.Add(pReservationID);

                    try
                    {
                        connection.Open();
                        command.ExecuteNonQuery();
                        ReservationID = (int)pReservationID.Value;
                    }
                    catch (Exception ex)
                    {
                        ReservationID = -1;
                    }
                }
            }
            return ReservationID;
        }
        public static bool UpdateReservation(int ReservationID, int customerID, int roomID, DateTime startDate, DateTime exitDate,
            int initialReservationDays, decimal initialTotalDueAmount, string initialCheckNotes, byte reservationStatus, DateTime? actualCheckInDate, decimal roomPriceAtReservation)
        {
            int rowsAffected = 0;
            using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.connectionString))
            {

                using (SqlCommand command = new SqlCommand("SP_UpdateReservation", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;

                    command.Parameters.AddWithValue("@customerID", customerID);
                    command.Parameters.AddWithValue("@roomID", roomID);
                    command.Parameters.AddWithValue("@startDate", startDate);
                    command.Parameters.AddWithValue("@exitDate", exitDate);
                    command.Parameters.AddWithValue("@initialReservationDays", initialReservationDays);
                    command.Parameters.AddWithValue("@initialTotalDueAmount", initialTotalDueAmount);
                    command.Parameters.AddWithValue("@initialCheckNotes", initialCheckNotes);
                    command.Parameters.AddWithValue("@reservationStatus", reservationStatus);
                    command.Parameters.AddWithValue("@ReservationID", ReservationID);
                    command.Parameters.AddWithValue("@roomPriceAtReservation", roomPriceAtReservation);

                    if (actualCheckInDate.HasValue)
                        command.Parameters.AddWithValue("@actualCheckInDate", actualCheckInDate);
                    else
                        command.Parameters.AddWithValue("@actualCheckInDate", System.DBNull.Value);

                    try
                    {
                        connection.Open();
                        rowsAffected = command.ExecuteNonQuery();
                    }
                    catch (Exception ex)
                    {
                        return false;
                    }
                }
            }
            return (rowsAffected > 0);
        }
        public static bool DeleteReservation(int ReservationID)
        {
            int RowsAffected = 0;
            using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.connectionString))
            {
                using (SqlCommand command = new SqlCommand(" SP_DeleteReservation", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@ReservationID", ReservationID);
                    try
                    {
                        connection.Open();
                        RowsAffected = command.ExecuteNonQuery();
                    }
                    catch (Exception ex)
                    {
                        RowsAffected = 0;
                    }
                }
            }
            return RowsAffected > 0;
        }
        public static int GetReservationsCount()
        {
            int count = 0;
            using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.connectionString))
            {
                using (SqlCommand command = new SqlCommand("SP_GetReservationCount", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;
                    try
                    {
                        connection.Open();
                        object result = command.ExecuteScalar();
                        if (result != null && int.TryParse(result.ToString(), out int Count))
                        {
                            count = Count;
                        }
                    }
                    catch (Exception ex)
                    {
                        count = 0;
                    }
                }
            }
            return count;
        }
        public static bool SetCheckIn(int reservationID, int roomID)
        {
            int rowsAffected = 0;
            using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.connectionString))
            {
                using (SqlCommand command = new SqlCommand("SP_SetCheckIn", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;

                    command.Parameters.AddWithValue("@roomID", roomID);
                    command.Parameters.AddWithValue("@reservationID", reservationID);
                    try
                    {
                        connection.Open();
                        rowsAffected = command.ExecuteNonQuery();

                    }
                    catch (Exception ex)
                    {
                        return false;
                    }
                }
            }

            return (rowsAffected > 0);
        }
        public static bool IsReservationExist(DateTime startDate, DateTime exiDate, int roomID, int reservationID)
        {
            bool isExist = false;

            using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.connectionString))
            {
                using (SqlCommand command = new SqlCommand("SP_CheckReservationExists", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@startDate", startDate);
                    command.Parameters.AddWithValue("@exitDate", exiDate);
                    command.Parameters.AddWithValue("@roomID", roomID);
                    command.Parameters.AddWithValue("@reservationID", reservationID);

                    try
                    {
                        connection.Open();
                        object result = command.ExecuteScalar();
                        if (result != null && int.TryParse(result.ToString(), out int Exist))
                        {
                            isExist = (Exist == 1);
                        }
                    }
                    catch (Exception ex)
                    {
                        isExist = false;
                    }
                }
            }
            return (isExist);
        }
        public static bool CheckNoShowReservations()
        {
            int RowsAffected = 0;
            using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.connectionString))
            {
                using (SqlCommand command = new SqlCommand("SP_CheckNoShowReservations", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;
                    try
                    {
                        connection.Open();
                        RowsAffected = (int)command.ExecuteScalar();
                    }
                    catch (Exception ex)
                    {
                        RowsAffected = 0;
                    }
                }
            }
            return RowsAffected > 0;
        }
        public static async Task<HashSet<int>> GetReservationApproachingCheckOut()
        {
            HashSet<int> FeatureIDs = new HashSet<int>();

            using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.connectionString))
            {
                using (SqlCommand command = new SqlCommand("SP_GetReservationApproachingCheckOut", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;
                    try
                    {
                        connection.Open();
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read()) FeatureIDs.Add(reader.GetInt32(0));
                        }
                    }
                    catch (Exception ex)
                    {
                        FeatureIDs = null;
                    }
                }
            }
            return FeatureIDs;
        }
        public async static Task<HashSet<int>> GetReservationApproachingCheckIn()
        {
            HashSet<int> FeatureIDs = new HashSet<int>();

            using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.connectionString))
            {
                using (SqlCommand command = new SqlCommand("SP_GetReservationApproachingCheckIn", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;
                    try
                    {
                        connection.Open();
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read()) FeatureIDs.Add(reader.GetInt32(0));
                        }
                    }
                    catch (Exception ex)
                    {
                        FeatureIDs = null;
                    }
                }
            }
            return FeatureIDs;
        }
        public static int GetTodayCheckoutCount()
        {
            int count = -1;

            using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.connectionString))
            {
                using (SqlCommand command = new SqlCommand("SP_GetTodayCheckoutCount", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;
                    {
                        try
                        {
                            connection.Open();
                            object result = command.ExecuteScalar();
                            if (result != null && int.TryParse(result.ToString(), out int Result))
                                count = Result;
                        }
                        catch (Exception ex)
                        {
                            count = 0;
                        }
                    }
                }
            }
            return count;
        }
        public static int GetTodayCheckInsCount()
        {
            int count = -1;

            using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.connectionString))
            {
                using (SqlCommand command = new SqlCommand("SP_GetTodayCheckInsCount", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;
                    {
                        try
                        {
                            connection.Open();
                            object result = command.ExecuteScalar();
                            if (result != null && int.TryParse(result.ToString(), out int Result))
                                count = Result;
                        }
                        catch (Exception ex)
                        {
                            count = 0;
                        }
                    }
                }
            }
            return count;
        }
        public static async Task MarkNotificationsSentAsync(IEnumerable<int> reservationIds)
        {
            DataTable dt = new DataTable();

            using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.connectionString))
            using (SqlCommand command = new SqlCommand("SP_MarkNotificationsSent", connection))
            {
                command.CommandType = CommandType.StoredProcedure;

                dt.Columns.Add("ID", typeof(int));

                foreach (var id in reservationIds) { dt.Rows.Add(id); }

                var param = command.Parameters.AddWithValue("@ReservationIDs", dt);
                param.SqlDbType = SqlDbType.Structured;

                try
                {
                    await connection.OpenAsync();
                    await command.ExecuteNonQueryAsync();
                }

                catch (Exception ex)
                {
                    
                }
            }
        }
        public static bool Cancel(int reservationID)
        {
            int rowsAffected = 0;
            using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.connectionString))
            {

                using (SqlCommand command = new SqlCommand("SP_CancelReservation", connection))

                {
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@ReservationID", reservationID);

                    try
                    {
                        connection.Open();
                        rowsAffected = command.ExecuteNonQuery();

                    }
                    catch (Exception ex)
                    {
                        return false;
                    }
                }
            }

            return (rowsAffected > 0);
        }
        public static DataTable GetMonthlyReservations()
        {
            DataTable dt = new DataTable();
            using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.connectionString))
            using (SqlCommand command = new SqlCommand("SP_GetMonthlyReservations", connection))
            {
                command.CommandType = CommandType.StoredProcedure;
                try
                {
                    connection.Open();
                    SqlDataReader reader = command.ExecuteReader();
                    if (reader.HasRows) dt.Load(reader);
                }
                catch (Exception ex)
                {
                    dt = null;
                }
            }
            return dt;
        }
        public static DataTable GetPaymentsForReservation(int ReservationID)
        {
            DataTable dt = new DataTable();
            string query = "select * from Payments where ReservationID=@ReservationID";

            using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.connectionString))
            {
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@ReservationID", ReservationID);
                    try
                    {
                        connection.Open();
                        SqlDataReader reader = command.ExecuteReader();
                        if (reader.HasRows) dt.Load(reader);
                    }
                    catch (Exception ex)
                    {
                        dt = null;
                    }
                }
            }
            return dt;
        }
        public static DataTable GetAllReservationByRoomID(int RoomID)
        {
            DataTable dt = new DataTable();
            string query = "select * from Reservations where RoomID=@roomID";

            using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.connectionString))
            {
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@roomID", RoomID);
                    try
                    {
                        connection.Open();
                        SqlDataReader reader = command.ExecuteReader();
                        if (reader.HasRows) dt.Load(reader);
                    }
                    catch (Exception ex)
                    {
                        dt = null;
                    }
                }
            }
            return dt;
        }
        public static DataTable GetReservationStatusDT()
        {
            DataTable dt = new DataTable();
            string query = "select ReservationStatus as Status,Count(*) as Count from ReservationDetails_View group by ReservationStatus";

            using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.connectionString))
            {
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    try
                    {
                        connection.Open();
                        SqlDataReader reader = command.ExecuteReader();
                        if (reader.HasRows) dt.Load(reader);
                    }
                    catch (Exception ex)
                    {
                        dt = null;
                    }
                }
            }
            return dt;
        }
        public static int GetCompletedReservationsCount()
        {
            int count = 0;
            using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.connectionString))
            {
                using (SqlCommand command = new SqlCommand("SP_GetCompletedReservationCount", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;
                    try
                    {
                        connection.Open();
                        object result = command.ExecuteScalar();
                        if (result != null && int.TryParse(result.ToString(), out int Count))
                        {
                            count = Count;
                        }
                    }
                    catch (Exception ex)
                    {
                        count = 0;
                    }
                }
            }
            return count;

        }
        public static int GetCanceledReservationsCount()
        {
            int count = 0;
            using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.connectionString))
            {
                using (SqlCommand command = new SqlCommand("SP_GetCanceledReservationCount", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;
                    try
                    {
                        connection.Open();
                        object result = command.ExecuteScalar();
                        if (result != null && int.TryParse(result.ToString(), out int Count))
                        {
                            count = Count;
                        }
                    }
                    catch (Exception ex)
                    {
                        count = 0;
                    }
                }
            }
            return count;

        }
        public static int GetNoShowReservationsCount()
        {
            int count = 0;
            using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.connectionString))
            {
                using (SqlCommand command = new SqlCommand("SP_GetNoShowReservationCount", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;
                    try
                    {
                        connection.Open();
                        object result = command.ExecuteScalar();
                        if (result != null && int.TryParse(result.ToString(), out int Count))
                        {
                            count = Count;
                        }
                    }
                    catch (Exception ex)
                    {
                        count = 0;
                    }
                }
            }
            return count;

        }
        public static int GetCheckedInReservationsCount()
        {
            int count = 0;
            using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.connectionString))
            {
                using (SqlCommand command = new SqlCommand("SP_GetCheckedInReservationCount", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;
                    try
                    {
                        connection.Open();
                        object result = command.ExecuteScalar();
                        if (result != null && int.TryParse(result.ToString(), out int Count))
                        {
                            count = Count;
                        }
                    }
                    catch (Exception ex)
                    {
                        count = 0;
                    }
                }
            }
            return count;

        }
        public static DataTable GetCheckInsReservation()
        {
            DataTable dt = new DataTable();
            string query = "select * from ReservationDetails_View where Cast (startDate as Date) = Cast(GEtDate() as Date) and ReservationStatus = 'Reserved'";

            using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.connectionString))
            {
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    try
                    {
                        connection.Open();
                        SqlDataReader reader = command.ExecuteReader();
                        if (reader.HasRows) dt.Load(reader);
                    }
                    catch (Exception ex)
                    {
                        dt = null;
                    }
                }
            }
            return dt;
        }
        public static DataTable GetCheckOutsReservation()
        {
            DataTable dt = new DataTable();
            string query = "select * from ReservationDetails_View where Cast (ExitDate as Date) = Cast(GEtDate() as Date) and ReservationStatus = 'Checked In'";

            using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.connectionString))
            {
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    try
                    {
                        connection.Open();
                        SqlDataReader reader = command.ExecuteReader();
                        if (reader.HasRows) dt.Load(reader);
                    }
                    catch (Exception ex)
                    {
                        dt = null;
                    }
                }
            }
            return dt;
        }

        public static double GetOccupancyRate()
        {
            double occupancyRate = 0;

            using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.connectionString))
            {
                using (SqlCommand command = new SqlCommand("SP_CalculateOccupancyRate", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;

                    try
                    {
                        connection.Open();

                        object result = command.ExecuteScalar();

                        if (result != null && double.TryParse(result.ToString(), out double value))
                        {
                            occupancyRate = value;
                        }
                    }
                    catch (Exception ex)
                    {
                        // حسب نظامك (log / throw)
                        throw;
                    }
                }
            }

            return occupancyRate;
        }
    }
}

/* //public static bool IsCheckedOut(int reservationID)
        //{
        //    bool isCheckedOut = false;
        //    using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.connectionString))
        //    {
        //        using (SqlCommand command = new SqlCommand("SP_GetIfReservationExists", connection))
        //        {
        //            command.CommandType = CommandType.StoredProcedure;
        //            command.Parameters.AddWithValue("@ReservationID", reservationID);
        //            try
        //            {
        //                connection.Open();
        //                object result = command.ExecuteScalar();
        //                if (result != null && int.TryParse(result.ToString(), out int Result))
        //                {
        //                    isCheckedOut = (Result == 1);
        //                }
        //            }
        //            catch (Exception ex)
        //            {
        //                isCheckedOut = false;
        //            }
        //        }
        //    }
        //    return isCheckedOut;
        //}
        /*ALTER procedure [dbo].[SP_GetIfReservationExists]
@ReservationID int
as begin
select dbo.IsReservationCheckedOut(@ReservationID) as IsCheckedOut
end
*/