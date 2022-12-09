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
    public partial class addUserForm : Form
    {
        public addUserForm()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            this.bloodGroupsUsersTA.Fill(this.bd_db_users_DataSet.BloodGroups);

            OleDbConnection connection = new OleDbConnection();
            connection.ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source= C:\Users\YeshwanthDornala\source\repos\Blood-Donation\blood-donation-db.accdb;Persist Security info=true";

            connection.Open();

            OleDbCommand command1 = new OleDbCommand();
            command1.Connection = connection;

            command1.CommandText = "SELECT * FROM Users";
            command1.ExecuteNonQuery();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void lblFirstName_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void clearAllFields()
        {
            this.txtFirstName.Clear();
            this.txtLastName.Clear();
            this.txtPhoneNumber.Clear();
            this.txtAddress.Clear();
            this.txtZipCode.Clear();           
        }
       
        private void btnAddUserSubmit_Click(object sender, EventArgs e)
        {
            if (!ValidateChildren(ValidationConstraints.Enabled | ValidationConstraints.ImmediateChildren))
            {
                MessageBox.Show("Please enter the required data", "Add User");
            }
            else
            {

                OleDbConnection connection = new OleDbConnection();
                connection.ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source= C:\Users\YeshwanthDornala\source\repos\Blood-Donation\blood-donation-db.accdb;Persist Security info=true";

                connection.Open();

                OleDbCommand command1 = new OleDbCommand();
                command1.Connection = connection;

                command1.CommandText = "INSERT INTO Users(firstName, lastName, address, zipCode, phoneNumber, bloodGroupID) Values ('" + txtFirstName.Text + "', '" + txtLastName.Text + "', '" + txtAddress.Text + "',  '" + txtZipCode.Text + "', '" + txtPhoneNumber.Text + "', '" + cmbxBloodGroup.SelectedValue + "' )";
                command1.ExecuteNonQuery();

                this.clearAllFields();
                MessageBox.Show("Your Data is Inserted Successfully");
            }
        }

        private void btnClearAll_Click(object sender, EventArgs e)
        {
            this.clearAllFields();
        }

        private void comboBloodGroup_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void bloodGroupsBS_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void txtFirstName_Validating(object sender, CancelEventArgs e)
        {
            if(string.IsNullOrWhiteSpace(txtFirstName.Text))
            {
                e.Cancel = true;
                txtFirstName.Focus();
                errorProviderUser.SetError(txtFirstName, "First Name should not be Empty");
            } else
            {
                e.Cancel= false;
                errorProviderUser.SetError(txtFirstName, "");
            }
        }

        private void txtLastName_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtLastName.Text))
            {
                e.Cancel = true;
                txtLastName.Focus();
                errorProviderUser.SetError(txtLastName, "last Name should not be Empty");
            }
            else
            {
                e.Cancel = false;
                errorProviderUser.SetError(txtLastName, "");
            }
        }

        private void txtPhoneNumber_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtPhoneNumber.Text))
            {
                e.Cancel = true;
                txtPhoneNumber.Focus();
                errorProviderUser.SetError(txtPhoneNumber, "PhoneNumber should not be Empty");
            }
            else
            {
                e.Cancel = false;
                errorProviderUser.SetError(txtPhoneNumber, "");
            }
        }

        private void cmbxBloodGroup_Validating(object sender, CancelEventArgs e)
        {
            if (cmbxBloodGroup.Text == "Select Blood Group")
            {
                e.Cancel = true;
                cmbxBloodGroup.Focus();
                errorProviderUser.SetError(cmbxBloodGroup, "Blood Group should be valid");
            }
            else
            {
                e.Cancel = false;
                errorProviderUser.SetError(cmbxBloodGroup, "");
            }
        }

        private void txtFirstName_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnAddUserEdit_Click(object sender, EventArgs e)
        {

        }

        private void btnAddUserDelete_Click(object sender, EventArgs e)
        {

        }
    }
}
