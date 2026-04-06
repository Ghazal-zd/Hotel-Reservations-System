using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Resources;
using System.Text;
using System.Threading.Tasks;

namespace HRS_DataAccessLayer
{
    public class clsRoomTypeData
    {
        public static bool GetRoomTypeInfoByID(int RoomTypeID, ref string RoomTypeName, ref decimal RoomTypeCost)
        {
            bool isFound = false;
            using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.connectionString))
            {
                using (SqlCommand command = new SqlCommand("SP_GetRoomTypeInfoByID", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@RoomTypeID", RoomTypeID);
                    {
                        try
                        {
                            connection.Open();
                            SqlDataReader reader = command.ExecuteReader();
                            if (reader.Read())
                            {
                                isFound = true;
                                RoomTypeName = (string)reader["TypeName"];
                                RoomTypeCost = (decimal)reader["Price"];
                            }
                        }
                        catch (Exception ex)
                        {
                            isFound = false;
                        }
                    }
                }
            }
            return isFound;
        }
        public static int AddNewRoomType(string RoomTypeName, decimal Price)
        {
            int RoomTypeID = -1;
            using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.connectionString))
            using (SqlCommand command = new SqlCommand("SP_AddRoomType", connection))
            {
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@RoomTypeName", RoomTypeName);
                command.Parameters.AddWithValue("@Price", Price);
                try
                {
                    connection.Open();

                    object result = command.ExecuteScalar();
                    if (result != null && int.TryParse(result.ToString(), out int insertedID))
                        RoomTypeID = insertedID;

                }
                catch (Exception ex)
                {
                    RoomTypeID = -1;
                }
                return RoomTypeID;
            }
        }
        public static bool UpdateRoomTypeInfo(int RoomTypeID, string RoomTypeName, decimal Price)
        {
            int rowsAffected = 0;
            using(SqlConnection connection = new SqlConnection(clsDataAccessSettings.connectionString))
            using (SqlCommand command = new SqlCommand("SP_UpdateRoomTypeInfo", connection))
            {
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@RoomTypeName", RoomTypeName);
                command.Parameters.AddWithValue("@RoomTypeID", RoomTypeID);
                command.Parameters.AddWithValue("@Price", Price);

                try
                {
                    connection.Open();
                    rowsAffected = command.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    rowsAffected = 0;
                }
            }
            return (rowsAffected > 0);
        }
    }
}

