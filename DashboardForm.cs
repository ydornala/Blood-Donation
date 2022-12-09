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
    public partial class DashboardForm : Form
    {
        public DashboardForm()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void DashboardForm_Load(object sender, EventArgs e)
        {
            OleDbConnection connection = new OleDbConnection();
            connection.ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source= C:\Users\YeshwanthDornala\source\repos\Blood-Donation\blood-donation-db.accdb;Persist Security info=true";

            connection.Open();

            OleDbCommand command1 = new OleDbCommand();
            command1.Connection = connection;

            command1.CommandText = "SELECT COUNT(*) FROM Users";
            int usersCount = (int)command1.ExecuteScalar();
            lblUsersCount.Text = usersCount.ToString();

            command1.CommandText = "SELECT COUNT(*) FROM Hospitals";
            int hospitalsCount = (int)command1.ExecuteScalar();
            lblHospitalsCount.Text = hospitalsCount.ToString();

            command1.CommandText = "SELECT COUNT(*) FROM BloodBanks";
            int bloodBanksCount = (int)command1.ExecuteScalar();
            lblBloodBanksCount.Text = bloodBanksCount.ToString();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
