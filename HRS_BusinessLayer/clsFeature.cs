using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HRS_DataAccessLayer;

namespace HRS_BusinessLayer
{
    public class clsFeature
    {
        enum enMode { AddNew = 1, Update = 2 }
        enMode _mode;
        public int FeatureID { get; set; }
        public string FeatureName { get; set; }
        public decimal Price { get; set; }
        public bool IsActive { get; set; }

        private clsFeature()
        {
            FeatureID = -1;
            FeatureName = "";
            Price = 0;
            IsActive = false;
            _mode = enMode.AddNew;
        }
        public clsFeature(int featureID, string featureName, decimal price, bool isActive)
        {
            FeatureID = featureID;
            FeatureName = featureName;
            Price = price;
            IsActive = isActive;
            _mode = enMode.Update;
        }

        private bool _AddNewFeature()
        {
            return false;
        }
        private bool _UpdateFeature()
        {
            return false;
        }

        public static DataTable GetAllFeatures()
        {
            return clsFeatureData.GetAllFeatures();
        }

        
    }
}
