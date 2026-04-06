using HRS_DataAccessLayer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;

namespace HRS_BusinessLayer
{
    public class clsEmployee:clsPerson
    {    
        enum enMode { AddNew = 0, Update = 1 }
        enMode _mode;
        public int EmployeeID {  get; set; }
        public DateTime HireDate { get; set; }
        public clsRole.enRoles RoleID {  get; set; }
        public string RoleName
        {
            get
            {
                return clsRole.Find((byte)RoleID).RoleName;
            }
        }
        public clsRole RoleInfo { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public bool IsActive {  get; set; }
        public clsPerson PersonInfo { get; set; }
        public clsEmployee()
        {
            this.EmployeeID = -1;
            this.PersonID = -1;
            this.HireDate = DateTime.Now;
            this.RoleID = clsRole.enRoles.Admin;
            this.Username = "";
            this.Password = "";
            this.IsActive = false;
            _mode = enMode.AddNew;
        }
        public clsEmployee(int employeeID, DateTime hireDate, clsRole.enRoles roleID, string username, string password, bool isActive,
             int personID, string firstName, string lastName, string email, string phoneNumber, int countryID)
            : base (personID,firstName,lastName,email,phoneNumber,countryID)
        {
            this.EmployeeID = employeeID;
            this.HireDate = hireDate;
            this.RoleID = roleID;
            this.RoleInfo = clsRole.Find((byte)roleID);
            this.Username = username;
            this.Password = password;
            this.IsActive = isActive;
            _mode=enMode.Update;
        }
        public static clsEmployee Find(int EmployeeID)
        {
            string username = "", password = "";
            DateTime hireDate = DateTime.Now;
            int personID = -1;
            byte roleID = 1;
            bool isActive = false;

            if (clsEmployeeData.Find(EmployeeID, ref personID, ref roleID, ref hireDate,ref username, ref password, ref isActive))
            {
                clsPerson Person = clsPerson.Find(personID);
                return new clsEmployee(EmployeeID, hireDate, (clsRole.enRoles)roleID,username,password, isActive, Person.PersonID, Person.FirstName, Person.LastName,
                    Person.Email, Person.PhoneNumber, Person.CountryID);
            }
            return null;
        }
        private bool _AddNewEmployee()
        {
            this.EmployeeID = clsEmployeeData.AddNewEmployee(PersonID,(byte)RoleID,HireDate,Username,Password,IsActive);
            return this.EmployeeID != -1;
        }
        private bool _UpdateEmployee()
        {
            return clsEmployeeData.UpdateEmployee(EmployeeID, (byte)RoleID,Username,IsActive);
        }
        public bool ChangePassword(string Password)
        {
            return clsEmployeeData.ChangePassword(EmployeeID,Password);
        }
        public bool Save()
        {
            base.mode = (clsPerson.enMode)mode;
            if (!base.Save())
                return false;

            switch (_mode)
            {
                case enMode.AddNew:
                    {
                        if (_AddNewEmployee())
                        {
                            _mode = enMode.Update;
                            return true;
                        }
                        return false;
                    }
                case enMode.Update:
                    return _UpdateEmployee();
            }
            return false;
        }     
        public static DataTable GetAllUsers()
        {
            return clsEmployeeData.GetAllEmployees();
        }
        public static clsEmployee GetUserByUsernameAndPassword(string username, string password)
        {
            DateTime hireDate = DateTime.Now;
            int personID = -1, employeeID = -1;
            byte roleID = 1;
            bool isActive = false;

            if (clsEmployeeData.GetEmployeeByUsernameAndPassword(username,password, ref employeeID, ref personID, ref roleID, ref hireDate, ref isActive))
            {
                clsPerson Person = clsPerson.Find(personID);

                return new clsEmployee(employeeID, hireDate, (clsRole.enRoles)roleID, username,password, isActive, Person.PersonID, Person.FirstName, Person.LastName,
                    Person.Email, Person.PhoneNumber, Person.CountryID);

            }
            return null;
        }
        public static bool DeactivateUser(int employeeID)
        {
            return clsEmployeeData.Deactivate(employeeID);
        }

    }
}
