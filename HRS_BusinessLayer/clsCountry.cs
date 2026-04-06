using HRS_DataAccessLayer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRS_BusinessLayer
{
    public class clsCountry
    {
        public int CountryID {  get; set; }
        public string CountryName {  get; set; }

        public clsCountry(int countryID, string countryName)
        {
            CountryID = countryID;
            CountryName = countryName;
        }

        public static DataTable GetAllCountries()
        {
            return clsCountryData.GetAllCountries();
        }
        public static clsCountry Find(int CountryID)
        {
            string CountryName = "";
            if (clsCountryData.Find(CountryID, ref CountryName))
                return new clsCountry(CountryID, CountryName);

            return null;
        }
        public static clsCountry Find(string CountryName)
        {
            int CountryID = -1;
            if (clsCountryData.Find(CountryName, ref CountryID))
                return new clsCountry(CountryID, CountryName);

            return null;
        }


    }
}
