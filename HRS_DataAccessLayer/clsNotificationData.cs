using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRS_DataAccessLayer
{
    public class clsNotificationData
    {
        public static int AddNewNotification(byte notificationType, string notificationContent, byte toRoleID, bool isRead, DateTime createdAt)
        {
            int NotificationID = -1;

            using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.connectionString))
            using (SqlCommand command = new SqlCommand("SP_AddNotification", connection))
            {
                command.CommandType = CommandType.StoredProcedure;

                command.Parameters.AddWithValue("@notificationType", notificationType);
                command.Parameters.AddWithValue("@notificationContent", notificationContent);
                command.Parameters.AddWithValue("@toRoleID", toRoleID);
                command.Parameters.AddWithValue("@isRead", isRead);
                command.Parameters.AddWithValue("@createdAt", createdAt);

                SqlParameter pNotificationID = new SqlParameter("@NewNotificationID", SqlDbType.Int);
                pNotificationID.Direction = ParameterDirection.Output;
                command.Parameters.Add(pNotificationID);

                try
                {
                    connection.Open();
                    command.ExecuteNonQuery();
                    NotificationID = (int)pNotificationID.Value;
                }
                catch
                {
                    NotificationID = -1;
                }
            }
            return NotificationID;
        }
        public static DataTable GetNotificationByRoleID(int toRoleID)
        {
            DataTable dt = new DataTable();
            using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.connectionString))
            {
                using (SqlCommand command = new SqlCommand("SP_GetNotificationByRoleID", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@toRoleID", toRoleID);
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
