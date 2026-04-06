using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRS_DataAccessLayer
{
    public class clsPersonData
    {
        public static int AddNewPerson(string FirstName, string LastName, string Email, string PhoneNumber, int CountryID)
        {
            int PersonID = -1;

            using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.connectionString))
            using (SqlCommand command = new SqlCommand("SP_AddPerson", connection))
            {
                command.CommandType = CommandType.StoredProcedure;

                command.Parameters.AddWithValue("@FirstName", FirstName);
                command.Parameters.AddWithValue("@LastName", LastName);
                command.Parameters.AddWithValue("@Email", Email);
                command.Parameters.AddWithValue("@CountryID", CountryID);

                if (!string.IsNullOrEmpty(PhoneNumber))
                    command.Parameters.AddWithValue("@PhoneNumber", PhoneNumber);
                else
                    command.Parameters.AddWithValue("@PhoneNumber", DBNull.Value);

                SqlParameter pPersonID = new SqlParameter("@NewPersonID", SqlDbType.Int);
                pPersonID.Direction = ParameterDirection.Output;
                command.Parameters.Add(pPersonID);

                try
                {
                    connection.Open();
                    command.ExecuteNonQuery();
                    PersonID = (int)pPersonID.Value;
                }
                catch
                {
                    PersonID = -1;
                }
            }
            return PersonID;
        }
        public static bool Find(int PersonID, ref string FirstName, ref string LastName, ref string Email, ref string PhoneNumber, ref int CountryID)
        {
            bool isFound = false;
            using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.connectionString))
            {
                using (SqlCommand command = new SqlCommand("SP_FindPerson", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@PersonID", PersonID);
                    try
                    {
                        connection.Open();
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                isFound = true;
                                FirstName = (string)reader["FirstName"];
                                LastName = (string)reader["LastName"];
                                Email = (string)reader["Email"];
                                PhoneNumber = reader["PhoneNumber"] == DBNull.Value ? null : (string)reader["PhoneNumber"];
                                CountryID = (int)reader["CountryID"];
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
        public static bool UpdatePerson(int PersonID, string FirstName,  string LastName,  string Email,  string PhoneNumber,  int CountryID)
        {
            int rowsAffected = 0;
            using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.connectionString))
            using (SqlCommand command = new SqlCommand("SP_UpdatePerson", connection))
            {
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@PersonID", PersonID);
                command.Parameters.AddWithValue("@FirstName", FirstName);
                command.Parameters.AddWithValue("@LastName", LastName);
                command.Parameters.AddWithValue("@CountryID", CountryID);
                command.Parameters.AddWithValue("@Email", Email);
           
                if (PhoneNumber != "" && PhoneNumber != null)
                    command.Parameters.AddWithValue("@PhoneNumber", PhoneNumber);
                else
                    command.Parameters.AddWithValue("@PhoneNumber", System.DBNull.Value);
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
