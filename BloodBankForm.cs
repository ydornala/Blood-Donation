using System.Data.OleDb;

namespace Blood_Donation
{
    public partial class bloodbankform : Form
    {
        public bloodbankform()
        {
            InitializeComponent();
        }

        

        private void clearAllFields()
        {
            this.txtBloodBankName.Clear();
            this.txtBloodBankRegistrationNumber.Clear();
            this.txtBloodBankAddress.Clear();
            this.txtPhoneNumber.Clear();
            this.txtZipCode.Clear();

        }

        private void btnBBSubmit_Click(object sender, EventArgs e)
        {
            if (!ValidateChildren(ValidationConstraints.Enabled))
            {
                MessageBox.Show("Please enter the required data", "Add Blood Bank");

                return;
            }
            else
            { 
                OleDbConnection connection = new OleDbConnection();
            connection.ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source= C:\Users\YeshwanthDornala\source\repos\Blood-Donation\blood-donation-db.accdb;Persist Security info=true";

            connection.Open();

            OleDbCommand command1 = new OleDbCommand();
            command1.Connection = connection;

            command1.CommandText = "INSERT INTO BloodBanks(bloodBankName, bloodBankRegistrationNumber, address, phoneNumber,  zipCode) Values ('" + txtBloodBankName.Text + "', '" + txtBloodBankRegistrationNumber.Text + "', '" + txtBloodBankAddress + "','" + txtPhoneNumber.Text + "', '" + txtZipCode.Text + "' )";
            command1.ExecuteNonQuery();

            this.clearAllFields();
            MessageBox.Show("Your Data is Inserted Successfully");
            }
        }

        private void btnClearAll_Click(object sender, EventArgs e)
        {
            this.clearAllFields();
        }

        private void txtBloodBankName_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtBloodBankName.Text))
            {
                e.Cancel = true;
                txtBloodBankName.Focus();
                errorProviderBloodBank.SetError(txtBloodBankName, "Blood Bank Name should not be Empty");
            }
            else
            {
                e.Cancel = false;
                errorProviderBloodBank.SetError(txtBloodBankName, "");
            }
        }

        private void txtBloodBankRegistrationNumber_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtBloodBankRegistrationNumber.Text))
            {
                e.Cancel = true;
                txtBloodBankRegistrationNumber.Focus();
                errorProviderBloodBank.SetError(txtBloodBankRegistrationNumber, "Blood Bank Registration Number should not be Empty");
            }
            else
            {
                e.Cancel = false;
                errorProviderBloodBank.SetError(txtBloodBankRegistrationNumber, "");
            }
        }

        private void txtPhoneNumber_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtPhoneNumber.Text))
            {
                e.Cancel = true;
                txtPhoneNumber.Focus();
                errorProviderBloodBank.SetError(txtPhoneNumber, "PhoneNumber should not be Empty");
            }
            else
            {
                e.Cancel = false;
                errorProviderBloodBank.SetError(txtPhoneNumber, "");
            }
        }
    }
}
