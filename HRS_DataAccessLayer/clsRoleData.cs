using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace HRS_DataAccessLayer
{
    public class clsRoleData
    {
        public static bool Find(byte RoleID, ref string RoleName,ref int PermissionsValue)
        {
            bool isFound = false;

            using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.connectionString))
            {
                using (SqlCommand command = new SqlCommand("SP_GetRoleByID", connection))
                {

                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@RoleID", RoleID);

                    try
                    {
                        connection.Open();
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                isFound = true;
                                RoleName = (string)reader["RoleName"];
                                PermissionsValue = (int)reader["PermissionsValue"];
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
        public static bool FindByName(string RoleName, ref byte RoleID,ref int PermissionsValue)
        {
            bool isFound = false;

            using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.connectionString))
            {
                using (SqlCommand command = new SqlCommand("SP_GetRoleByName", connection))
                {
                    command.CommandType= CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@RoleName", RoleName);

                    try
                    {
                        connection.Open();
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                isFound = true;
                                RoleID = (byte)reader["RoleID"];
                                PermissionsValue = (int)reader["PermissionsValue"];
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
    }
}
