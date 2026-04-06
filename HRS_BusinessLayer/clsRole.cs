using HRS_DataAccessLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static HRS_BusinessLayer.clsEmployee;

namespace HRS_BusinessLayer
{
    public class clsRole
    {
        public enum enRoles { Admin=1,Manager=2, Reception=3};
        public enum enPermissions
        {
            AddNewReservation = 1, ReservationList = 2, AddNewRoom = 4, RoomList = 8,
            AddNewEmployee = 32, EmployeeList = 64, History = 128, eFullAccess = -1
        };
        public enPermissions permissions;
        enum enMode { AddNew = 0, Update = 1 }
        enMode _mode;
        public enRoles RoleID {  get; set; }
        public string RoleName { get; set; }
        public enPermissions PermissionsValue { get; set; }
        public clsRole() 
        {
            RoleID = enRoles.Admin;
            RoleName = "";
            PermissionsValue = enPermissions.eFullAccess;
            _mode =enMode.AddNew;
        }
        public clsRole(enRoles RoleID, string RoleName,enPermissions PermissionsValue)
        {
            this.RoleID=RoleID;
            this.RoleName=RoleName;
            this.PermissionsValue = PermissionsValue;
            _mode =enMode.Update;
        }
        public static clsRole Find(byte RoleID)
        {
            string RoleName = "";
            int permissionsValue = -1;           
            if(clsRoleData.Find(RoleID,ref RoleName,ref permissionsValue))
                return new clsRole ((enRoles)RoleID,RoleName, (enPermissions)permissionsValue);
            return null;
        }
        public static clsRole Find(string RoleName)
        {
            byte RoleID = 1;
            int permissionsValue = -1;
            if (clsRoleData.FindByName(RoleName, ref RoleID, ref permissionsValue))
                return new clsRole((enRoles)RoleID, RoleName, (enPermissions)permissionsValue);
            return null;
        }
        public bool checkAccessPermission(enPermissions permission)
        { 
            if (this.permissions == enPermissions.eFullAccess)
                return true;

            if ((permission & PermissionsValue) == permission)
                return true;

            return false;
        }
    }
}
