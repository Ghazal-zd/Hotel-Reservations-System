using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRS_DataAccessLayer
{
    public class clsDataAccessSettings
    {
        public static string connectionString = ConfigurationManager.ConnectionStrings["stringConnection"].ConnectionString;

    }
}
