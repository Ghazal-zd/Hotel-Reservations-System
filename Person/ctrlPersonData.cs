using HRS_BusinessLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hotel_Reservations_System
{
    public partial class ctrlPersonData : UserControl
    {
        private clsPerson _Person;
        private int _PersonID = -1;

        public int PersonID
        {
            get { return _PersonID; }
        }

        public clsPerson SelectedPersonInfo
        {
            get { return _Person; }
        }

    
        public ctrlPersonData()
        {
            InitializeComponent();
        }
        public void ResetPersonInfo()
        {
            lblName.Text = "???";
            lblPhone.Text = "???";
            lblEmail.Text = "???";
            lblPhone.Text = "???";
            lblCountry.Text = "???";
        }

        private void _FillBasicInfo()
        {
            lblName.Text = _Person.FullName;
            lblPhone.Text = (_Person.PhoneNumber ?? "No Phone");
            lblEmail.Text = _Person.Email;
            lblCountry.Text = _Person.CountryInfo.CountryName;
        }
        public void LoadBasicInfo(int PersonID)
        {
            _Person = clsPerson.Find(PersonID);
            if (_Person == null)
            {
                ResetPersonInfo();
                MessageBox.Show("No Person with PersonID = " + PersonID.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            _PersonID = PersonID;
            _FillBasicInfo();
        }

        private void lnkEditPersonInfo_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            MessageBox.Show("Want to implement!", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}
