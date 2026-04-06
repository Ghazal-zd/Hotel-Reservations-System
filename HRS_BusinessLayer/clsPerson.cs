using HRS_DataAccessLayer;
using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRS_BusinessLayer
{
    public class clsPerson
    {
        public enum enMode { AddNew = 0, Update = 1 };
        public enMode mode;
        public int PersonID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public int CountryID { get; set; }
        public clsCountry CountryInfo { get; set; }
        public string FullName { get { return FirstName + " " + LastName; } }
        protected clsPerson()
        {
            this.PersonID = -1;
            this.FirstName = "";
            this.LastName = "";
            this.Email = "";
            this.PhoneNumber = "";
            this.CountryID = -1;
            mode = enMode.AddNew;
        }
        public clsPerson(int personID, string firstName, string lastName, string email, string phoneNumber, int nationalID)
        {
            PersonID = personID;
            FirstName = firstName;
            LastName = lastName;
            Email = email;
            PhoneNumber = phoneNumber;
            CountryID = nationalID;
            CountryInfo = clsCountry.Find(nationalID);
            mode = enMode.Update;
        }
        private bool _AddNewPerson()
        {
            PersonID = clsPersonData.AddNewPerson(FirstName, LastName, Email, PhoneNumber, CountryID);
            return (PersonID!=-1);
        }
        private bool _UpdatePerson()
        {
            return clsPersonData.UpdatePerson(PersonID, FirstName, LastName, Email, PhoneNumber, CountryID);
        }
        public bool Save()
        {
            switch (mode)
            {
                case enMode.AddNew:
                    if (_AddNewPerson())
                    {

                        mode = enMode.Update;
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                case enMode.Update:
                    return _UpdatePerson();
            }
            return false;
        }
        public static clsPerson Find(int PersonID)
        {
            string FirstName = "", LastName = "", Email = "", phoneNumber = "";
            int NationalID = -1;
            if (clsPersonData.Find(PersonID, ref FirstName, ref LastName, ref Email, ref phoneNumber, ref NationalID))
                return new clsPerson(PersonID, FirstName, LastName, Email, phoneNumber, NationalID);
            return null;
        }
    }
}
