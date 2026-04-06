using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace HRS_BusinessLayer
{
    public class clsGlobal
    {
        public static clsEmployee currentEmployee;

        static string keyPath = @"HKEY_CURRENT_USER\SOFTWARE\HRS";
        static string Username = "UserName";
        static string Password = "Password";
        public static bool RememberUsernameAndPassword(string username, string password)
        {
            try
            {
                if (string.IsNullOrEmpty(username))
                {
                    using (RegistryKey baseKey = RegistryKey.OpenBaseKey(RegistryHive.CurrentUser, RegistryView.Registry64))
                    {
                        using (RegistryKey key = baseKey.OpenSubKey(@"SOFTWARE\HRS", true))
                        {
                            if (key != null)
                            {
                                key.DeleteValue(Username, false);
                                key.DeleteValue(Password, false);
                                return true;
                            }
                            else
                            {
                                return false;
                            }
                        }
                    }
                }
                else
                {
                    byte[] encrypted = ProtectedData.Protect(Encoding.UTF8.GetBytes(password), null, DataProtectionScope.CurrentUser);
                    password = Convert.ToBase64String(encrypted);
                    Registry.SetValue(keyPath, Username, username, RegistryValueKind.String);
                    Registry.SetValue(keyPath, Password, password, RegistryValueKind.String);
                    return true;
                }
            }

            catch (Exception ex)
            {
                //MessageBox.Show($"An error occurred: {ex.Message}");
                return false;
            }
        }
        public static bool GetStoredInfo(ref string username, ref string password)
        {
            try
            {
                username = Registry.GetValue(keyPath, Username, null) as string;
                string encryptedFromRegistry =  Registry.GetValue(keyPath, Password, null) as string;

                if (username != null && encryptedFromRegistry != null)
                {
                    byte[] encrypted = Convert.FromBase64String(encryptedFromRegistry);
                    password = Encoding.UTF8.GetString(ProtectedData.Unprotect(encrypted,null,DataProtectionScope.CurrentUser));
                    return true;
                }
                return false;
            }
            catch (Exception ex)
            {
                return false;
            }
        }
        public static bool CheckRightPermissions(clsRole.enPermissions permission)
        {
            return (currentEmployee.RoleInfo.checkAccessPermission(permission));
        }
    }
}
