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
    public partial class TransactionForm : Form
    {
        public TransactionForm()
        {
            InitializeComponent();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void TransactionForm_Load(object sender, EventArgs e)
        {
            this.bloodGroupsTableAdapter1.Fill(this._blood_donation_dbDataSet1.BloodGroups);
            this.usersTableAdapter1.Fill(this._blood_donation_dbDataSet1.Users);
            this.bloodBanksTableAdapter1.Fill(this._blood_donation_dbDataSet1.BloodBanks);
            this.hospitalsTableAdapter1.Fill(this._blood_donation_dbDataSet1.Hospitals);
            this.transactionTypesTableAdapter1.Fill(this._blood_donation_dbDataSet1.TransactionTypes);
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            if (!ValidateChildren(ValidationConstraints.Enabled))
            {
                MessageBox.Show("Please select the required data", "Transaction");

                return;
            }
            else
            {
                OleDbConnection connection = new OleDbConnection();
                connection.ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source= C:\Users\YeshwanthDornala\source\repos\Blood-Donation\blood-donation-db.accdb;Persist Security info=true";

                connection.Open();

                OleDbCommand command1 = new OleDbCommand();
                command1.Connection = connection;

                command1.CommandText = "INSERT INTO Transactions(UserID, hospitalID, bloodBankID, transactionTypeID, bloodGroupID, entryDate) Values ('" + comboUser.SelectedValue + "', '" + comboHospital.SelectedValue + "', '" + comboBloodBank.SelectedValue + "',  '" + comboTransactionType.SelectedValue + "', '" + comboBloodGroup.SelectedValue + "', '" + DateTime.UtcNow + "' )";
                command1.ExecuteNonQuery();

                MessageBox.Show("Your Data is Inserted Successfully");
            }
        }

        private void comboUser_SelectedIndexChanged(object sender, EventArgs e)
        {
            string userValue = comboUser.Text;
            int userID = (int)comboUser.SelectedValue;

            OleDbConnection connection = new OleDbConnection();
            connection.ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source= C:\Users\YeshwanthDornala\source\repos\Blood-Donation\blood-donation-db.accdb;Persist Security info=true";

            connection.Open();

            OleDbCommand command1 = new OleDbCommand();
            command1.Connection = connection;

            command1.CommandText = "SELECT bloodGroupID from Users WHERE userID = " + userID;
            int ID = (int)command1.ExecuteScalar();

            if (userValue != "Select User")
            {
                comboHospital.Enabled = false; 
                comboBloodBank.Enabled = false;

                comboBloodGroup.SelectedValue = ID;

                DataTable transactionTypesDT = this._blood_donation_dbDataSet1.TransactionTypes;
                for (int i = transactionTypesDT.Rows.Count - 1; i >= 0; i--)
                {
                    DataRow dr = transactionTypesDT.Rows[i];
                    string tTypeName = (string)dr["transactionTypeName"];
                    if (tTypeName == "Inventory")
                    {
                        dr.Delete();
                    }
                }
                transactionTypesDT.AcceptChanges();

                this.transactionTypesTableAdapter1.Fill((_blood_donation_dbDataSet.TransactionTypesDataTable)transactionTypesDT);
                this.transactionTypesTableAdapter1.Update((_blood_donation_dbDataSet.TransactionTypesDataTable)transactionTypesDT);
            } else
            {
                comboHospital.Enabled = true;
                comboBloodBank.Enabled = true;

                comboBloodGroup.Text = "Select Blood Group";
            }

        }

        private void lblBloodBank_Click(object sender, EventArgs e)
        {

        }
    }
}
