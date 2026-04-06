using HRS_DataAccessLayer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;

namespace HRS_BusinessLayer
{
    public class clsCustomer : clsPerson
    {
        enum enMode { AddNew  = 0, Update = 1 }
        enMode _mode;
        public int CustomerID { get; set; }
        public DateTime RegisteredDate { get; set; }
        public int RegisteredByEmployeeID {  get; set; }
        public string Notes {  get; set; }
        public clsCustomer()
        {
            this.CustomerID = -1;
            this.RegisteredDate = DateTime.Now;
            this.RegisteredByEmployeeID = -1;
            this.Notes = "";
            _mode=enMode.AddNew;
        }
        public clsCustomer(int customerID, int personID, string firstName, string lastName, string email, string phoneNumber, int countryID,
            DateTime registeredDate, int registeredByEmployeeID, string notes)
            :base (personID,firstName,lastName,email,phoneNumber,countryID)
        {
            
            this.CustomerID = customerID;
            this.RegisteredDate = registeredDate;
            this.RegisteredByEmployeeID = registeredByEmployeeID;
            this.Notes = notes;
            _mode = enMode.Update;
        }
        public static clsCustomer Find(int customerID)
        {
            DateTime RegisterDate = DateTime.Now;
            int PersonID = -1, RegisteredByEmployeeID = -1;
            string Notes = "";

            if (clsCustomerData.Find(customerID, ref PersonID, ref RegisterDate, ref RegisteredByEmployeeID, ref Notes))
            {
                clsPerson Person = clsPerson.Find(PersonID);
                return new clsCustomer(customerID, Person.PersonID, Person.FirstName, Person.LastName, Person.Email, Person.PhoneNumber, Person.CountryID,
                    RegisterDate, RegisteredByEmployeeID, Notes);
            }
            return null;
        }
        private bool _AddNewCustomer()
        {
            CustomerID = clsCustomerData.AddNewCustomer(PersonID,RegisteredDate, RegisteredByEmployeeID, Notes);
            return (CustomerID != -1);
        }
        private bool _UpdateCustomer()
        {
            return clsCustomerData.UpdateCustomer(CustomerID,Notes);
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
                        if (_AddNewCustomer())
                        {
                            _mode = enMode.Update;
                            return true;
                        }
                        return false;
                    }
                case enMode.Update:
                    return _UpdateCustomer();
            }
            return false;
        }
        public static DataTable GetAllCustomers()
        {
            return clsCustomerData.GetAllCustomers();
        }
        public static int GetCustomersCount()
        {
            return clsCustomerData.GetCustomerCount();
        }
    }
}
