using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Net;
using System.Security.Cryptography.X509Certificates;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace HRS_DataAccessLayer
{
    public class clsCustomerData
    {
        public static bool Find(int CustomerID, ref int PersonID,
            ref DateTime RegisterDate, ref int RegisteredByEmployeeID, ref string Notes)
        {
            bool isFound = false;
            using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.connectionString))
            {

                using (SqlCommand command = new SqlCommand("SP_GetCustomerInfo", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;

                    command.Parameters.AddWithValue("@CustomerID", CustomerID);

                    try
                    {
                        connection.Open();
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                isFound = true;

                                PersonID = (int)reader["PersonID"];
                                RegisterDate = (DateTime)reader["DateRegistered"];
                                RegisteredByEmployeeID = (int)reader["RegisteredByEmployeeID"];
                                Notes = reader["Notes"] == DBNull.Value ? null : (string)reader["Notes"];
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
        public static int AddNewCustomer(int personID,
            DateTime RegisterDate, int RegisteredByEmployeeID, string Notes)
        {
            int CustomerID = -1;

            using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.connectionString))
            using (SqlCommand command = new SqlCommand("SP_AddCustomer", connection))
            {
                command.CommandType = CommandType.StoredProcedure;

                command.Parameters.AddWithValue("@PersonID", personID);
                command.Parameters.AddWithValue("@RegisteredByEmployeeID", RegisteredByEmployeeID);
                command.Parameters.AddWithValue("@DateRegistered", RegisterDate);
                command.Parameters.AddWithValue("@Notes", Notes);
                SqlParameter pCustomerID = new SqlParameter("@NewCustomerID", SqlDbType.Int);
                pCustomerID.Direction = ParameterDirection.Output;
                command.Parameters.Add(pCustomerID);

                try
                {
                    connection.Open();
                    command.ExecuteNonQuery();
                    CustomerID = (int)pCustomerID.Value;
                }
                catch
                {
                    CustomerID = -1;
                }
            }
            return CustomerID;
        }

        public static bool UpdateCustomer(int CustomerID, string Notes)
        {
            int rowsAffected = 0;
            using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.connectionString))
            using (SqlCommand command = new SqlCommand("SP_UpdateCustomer", connection))
            {
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@Notes", Notes);
                command.Parameters.AddWithValue("@CustomerID", CustomerID);

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
        public static DataTable GetAllCustomers()
        {
            DataTable dt = new DataTable();
            using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.connectionString))
            {
                using (SqlCommand command = new SqlCommand("select * from CustomerDetails_View", connection))
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
        public static int GetCustomerCount()
        {
            int count = 0;
            using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.connectionString))
            {
                using (SqlCommand command = new SqlCommand("SP_GetCustomerCount", connection))
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
    }
}
