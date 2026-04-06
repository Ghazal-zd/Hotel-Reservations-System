using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace HRS_DataAccessLayer
{
    public class clsFeatureData
    {
        public static DataTable GetAllFeatures()
        {
            DataTable dt = new DataTable();

            using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.connectionString))
            {
                using (SqlCommand command = new SqlCommand("select * from Features", connection))
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
        public static DataTable GetRoomFeatures(int RoomID)
        {
            DataTable dt = new DataTable();

            using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.connectionString))
            {
                using (SqlCommand command = new SqlCommand("SP_GetRoomFeatures", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@RoomID", RoomID);
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
        public static HashSet<int> GetRoomFeatureIDs(int RoomID)
        {
            HashSet<int> FeatureIDs = new HashSet<int>();

            using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.connectionString))
            {
                using (SqlCommand command = new SqlCommand("SP_GetRoomFeatureIDs", connection))
                {
                    command.CommandType=CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@RoomID", RoomID);
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
        public static decimal GetTotalFeaturePrice(int roomID)
        {
            decimal price = -1;

            using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.connectionString))
            {
                using (SqlCommand command = new SqlCommand("SP_GetFeaturesPrice", connection))

                {
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@roomID", roomID);
                    try
                    {
                        connection.Open();

                        object result = command.ExecuteScalar();

                        if (result != null && int.TryParse(result.ToString(), out int TotalPrice))
                        {
                            price = Convert.ToDecimal(TotalPrice);
                        }
                    }

                    catch (Exception ex)
                    {
                        price = -1;
                    }
                }
            }
            return price;
        }
    }
}
