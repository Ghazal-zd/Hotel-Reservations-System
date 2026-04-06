using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace HRS_DataAccessLayer
{
    public class clsEmployeeData
    {
        public static bool Find(int EmployeeID, ref int PersonID, ref byte RoleID, ref DateTime HireDate, ref string Username, ref string Password,ref bool IsActive)
        {
            bool isFound = false;
            using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.connectionString))
            {
                using (SqlCommand command = new SqlCommand("SP_GetEmployeeInfo", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@EmployeeID", EmployeeID);
                    try
                    {
                        connection.Open();
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                isFound = true;
                                PersonID = (int)reader["PersonID"];
                                HireDate = (DateTime)reader["HireDate"];
                                RoleID = (byte)reader["RoleID"];
                                Username = (string)reader["Username"];
                                Password = (string)reader["Password"];
                                IsActive = (bool)reader["IsActive"];
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
         public static bool GetEmployeeByUsernameAndPassword( string Username, string Password, ref int EmployeeID, ref int PersonID,
           ref byte RoleID, ref DateTime HireDate,ref bool IsActive)
         {
            bool isFound = false;
            using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.connectionString))
            {
                using (SqlCommand command = new SqlCommand("SP_GetEmployeeByUsernameAndPassword", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;

                    command.Parameters.AddWithValue("@Username", Username);
                    command.Parameters.AddWithValue("@Password", Password);
                    try
                    {
                        connection.Open();
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                isFound = true;
                                EmployeeID = (int)reader["EmployeeID"];
                                PersonID = (int)reader["PersonID"];
                                HireDate = (DateTime)reader["HireDate"];
                                RoleID = (byte)reader["RoleID"];
                                IsActive = (bool)reader["IsActive"];
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
        public static int AddNewEmployee(int PersonID, byte RoleID, DateTime HireDate, string Username, string Password, bool IsActive)
        {
            int EmployeeID = -1;

            using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.connectionString))
            using (SqlCommand command = new SqlCommand("SP_AddEmployee", connection))
            {
                command.CommandType = CommandType.StoredProcedure;

                command.Parameters.AddWithValue("@PersonID", PersonID);
                command.Parameters.AddWithValue("@HireDate", HireDate);
                command.Parameters.AddWithValue("@RoleID", RoleID);
                command.Parameters.AddWithValue("@Username", Username);
                command.Parameters.AddWithValue("@Password", Password);
                command.Parameters.AddWithValue("@IsActive", IsActive);

                SqlParameter pEmployeeID = new SqlParameter("@NewEmployeeID", SqlDbType.Int);
                pEmployeeID.Direction = ParameterDirection.Output;
                command.Parameters.Add(pEmployeeID);

                try
                {
                    connection.Open();
                    command.ExecuteNonQuery();
                    EmployeeID = Convert.ToInt32(command.Parameters["@NewEmployeeID"].Value);
                }
                catch
                {
                    EmployeeID = -1;
                }
            }
            return EmployeeID;
        } 
        public static bool UpdateEmployee(int EmployeeID, byte RoleID, string Username, bool IsActive)
        {
            int rowsAffected = 0;
            using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.connectionString))
            using (SqlCommand command = new SqlCommand("SP_UpdateEmployee", connection))
            {
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@EmployeeID", EmployeeID);
                command.Parameters.AddWithValue("@RoleID", RoleID);
                command.Parameters.AddWithValue("@Username", Username);
                command.Parameters.AddWithValue("@IsActive", IsActive);

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
        public static DataTable GetAllEmployees()
        {
            DataTable dt = new DataTable();

            using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.connectionString))
            {
                using (SqlCommand command = new SqlCommand("select * from EmployeesDetails_view", connection))
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
        public static bool Deactivate(int EmployeeID)
        {
            int rowsAffected = 0;
            using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.connectionString))
            using (SqlCommand command = new SqlCommand("SP_DeactivateEmployee", connection))
            {
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@EmployeeID", EmployeeID);
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
        public static bool ChangePassword(int EmployeeID, string Password)
        {
            int rowsAffected = 0;
            using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.connectionString))
            using (SqlCommand command = new SqlCommand("SP_ChangePassword", connection))
            {
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@Password", Password);
                command.Parameters.AddWithValue("@EmployeeID", EmployeeID);

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
