using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Blood_Donation
{
    public partial class hospitalForm : Form
    {

        public hospitalForm()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void label1_Click_2(object sender, EventArgs e)
        {

        }

        private void txtZipCode_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtPhoneNumber_TextChanged(object sender, EventArgs e)
        {

        }

        private void hospitalForm_Load(object sender, EventArgs e)
        {

        }

        private void clearAllFields()
        {
            this.txtHospitalName.Clear();
            this.txtHospitalRegistrationNumber.Clear();
            this.txtHospitalAddress.Clear();
            this.txtZipCode.Clear();
            this.txtPhoneNumber.Clear();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            if (!ValidateChildren(ValidationConstraints.Enabled))
            {
                MessageBox.Show("Please enter the required data", "Add Hospital");

                return;
            }
            else
            {
                OleDbConnection connection = new OleDbConnection();
                connection.ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source= C:\Users\YeshwanthDornala\source\repos\Blood-Donation\blood-donation-db.accdb;Persist Security info=true";

                connection.Open();

                OleDbCommand command1 = new OleDbCommand();
                command1.Connection = connection;

                command1.CommandText = "INSERT INTO Hospitals(hospitalName, hospitalRegistrationNumber, address, zipCode, phoneNumber) Values ('" + txtHospitalName.Text + "', '" + txtHospitalRegistrationNumber.Text + "', '" + txtHospitalAddress.Text + "', '" + txtZipCode.Text + "', '" + txtPhoneNumber.Text + "' )";
                command1.ExecuteNonQuery();

                this.clearAllFields();
                MessageBox.Show("Your Data is Inserted Successfully");
            }
        }

        private void btnClearAll_Click(object sender, EventArgs e)
        {
            this.clearAllFields();
        }

        private void txtHospitalName_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtHospitalName.Text))
            {
                e.Cancel = true;
                txtHospitalName.Focus();
                errorProviderHospital.SetError(txtHospitalName, "Hospital Name should not be Empty");
            }
            else
            {
                e.Cancel = false;
                errorProviderHospital.SetError(txtHospitalName, "");
            }
        }

        private void txtHospitalRegistrationNumber_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtHospitalRegistrationNumber.Text))
            {
                e.Cancel = true;
                txtHospitalRegistrationNumber.Focus();
                errorProviderHospital.SetError(txtHospitalRegistrationNumber, "Hospital Registration Number should not be Empty");
            }
            else
            {
                e.Cancel = false;
                errorProviderHospital.SetError(txtHospitalRegistrationNumber, "");
            }
        }

       
        private void txtPhonenumber_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtPhoneNumber.Text))
            {
                e.Cancel = true;
                txtPhoneNumber.Focus();
                errorProviderHospital.SetError(txtPhoneNumber, "PhoneNumber should not be Empty");
            }
            else
            {
                e.Cancel = false;
                errorProviderHospital.SetError(txtPhoneNumber, "");
            }
        }
    }
}
