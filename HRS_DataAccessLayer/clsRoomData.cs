using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRS_DataAccessLayer
{
    public class clsRoomData
    {
        public static bool GetRoomByID(int roomID, ref byte roomStatus, ref int roomType, ref decimal roomFee)
        {
            bool isFound = false;
            using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.connectionString))
            {
                using (SqlCommand command = new SqlCommand("SP_GetRoomByID", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@roomID", roomID);
                    try
                    {
                        connection.Open();
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                isFound = true;
                                roomStatus = (byte)reader["RoomStatus"];
                                roomType = (int)reader["RoomTypeID"];
                                roomFee = (decimal)reader["CostPerNight"];

                            }
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
        public static DataTable GetAllRooms()
        {
            DataTable dt = new DataTable();
            using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.connectionString))
            {
                using (SqlCommand command = new SqlCommand("select * from RoomDetails_view", connection))
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
        public static int AddNewRoom(int roomTypeID, byte roomStatus, decimal costPerNight, DataTable featureIDs)
        {
            int roomID = -1;

            using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.connectionString))
            using (SqlCommand command = new SqlCommand("SP_AddRoom", connection))
            {
                command.CommandType = CommandType.StoredProcedure;

                command.Parameters.AddWithValue("@RoomTypeID", roomTypeID);
                command.Parameters.AddWithValue("@RoomStatus", roomStatus);
                command.Parameters.AddWithValue("@CostPerNight", costPerNight);

                SqlParameter tvpParam = command.Parameters.AddWithValue("@FeatureIDs", featureIDs);
                tvpParam.SqlDbType = SqlDbType.Structured;
                tvpParam.TypeName = "dbo.FeatureIDsTable";

                SqlParameter pRoomID = new SqlParameter("@RoomID", SqlDbType.Int);
                pRoomID.Direction = ParameterDirection.Output;
                command.Parameters.Add(pRoomID);

                try
                {
                    connection.Open();
                    command.ExecuteNonQuery();
                    roomID = (int)pRoomID.Value;
                }
                catch
                {
                    roomID = -1;
                }
            }

            return roomID;
        }
        public static bool DeleteRoom(int RoomID)
        {
            int rowsAffected = 0;
            using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.connectionString))
            {
                using (SqlCommand command = new SqlCommand("SP_DeactivateRoom", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@RoomID", RoomID);
                    try
                    {
                        connection.Open();
                        rowsAffected = command.ExecuteNonQuery();
                    }
                    catch (Exception ex)
                    {
                        rowsAffected = -1;
                    }
                }
            }
            return (rowsAffected > 0);
        }
        public static bool UpdateRoom(int RoomID, int roomTypeID, decimal costPerNight, DataTable featureIDs)
        {
            using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.connectionString))
            using (SqlCommand command = new SqlCommand("SP_UpdateRoom", connection))
            {
                command.CommandType = CommandType.StoredProcedure;

                command.Parameters.AddWithValue("@RoomID", RoomID);
                command.Parameters.AddWithValue("@RoomTypeID", roomTypeID);
                command.Parameters.AddWithValue("@CostPerNight", costPerNight);

                SqlParameter tvp = command.Parameters.AddWithValue("@FeatureIDs", featureIDs);
                tvp.SqlDbType = SqlDbType.Structured;
                tvp.TypeName = "dbo.FeatureIDsTable";

                SqlParameter affected = new SqlParameter("@AffectedRooms", SqlDbType.Int);
                affected.Direction = ParameterDirection.Output;
                command.Parameters.Add(affected);

                try
                {
                    connection.Open();
                    command.ExecuteNonQuery();
                    return (int)affected.Value > 0;
                }
                catch
                {
                    return false;
                }
            }
        }
        public static int GetRoomsCount()
        {
            int count = 0;
            using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.connectionString))
            {
                using (SqlCommand command = new SqlCommand("SP_GetRoomsCount", connection))
                {
                    command.CommandType= CommandType.StoredProcedure;

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
        public static int GetAvailableRoomsCount()
        {
            int count = 0;
            using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.connectionString))
            {
                using (SqlCommand command = new SqlCommand("SP_GetAvailableRoomsCount", connection))
                {
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
        public static int GetOccupiedRoomsCount()
        {
            int count = 0;
            using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.connectionString))
            {
                using (SqlCommand command = new SqlCommand("SP_GetOcuppiedRoomsCount", connection))
                {
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
        public static bool IsRoomReservedOrOccupied(int roomID)
        {
            bool isExist = false;
            using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.connectionString))
            using (SqlCommand command = new SqlCommand("SP_CheckIfRoomReservedOrOccupied", connection))
            {
                command.CommandType= CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@RoomID", roomID);

                try
                {
                    connection.Open();
                    SqlDataReader reader = command.ExecuteReader();

                    isExist = reader.HasRows;
                    reader.Close();
                }
                catch (Exception ex)
                {
                    isExist = false;
              
                }
            }
            return isExist;
        }
    }
}
