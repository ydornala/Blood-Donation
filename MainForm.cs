namespace Blood_Donation
{
    public partial class mainApp : Form
    {
        public mainApp()
        {
            InitializeComponent();
        }

        public void loadForm(object Form)
        {
            if(this.mainPanel.Controls.Count > 0)
            {
                this.mainPanel.Controls.RemoveAt(0);
            }

            Form? f = Form as Form;
            f.TopLevel = false;
            f.Dock = DockStyle.Fill;

            this.mainPanel.Controls.Add(f);
            this.mainPanel.Tag = f;
            f.Show();
        }

        private void btnAddUser_Click(object sender, EventArgs e)
        {
            loadForm(new addUserForm());
        }

        private void button3_Click(object sender, EventArgs e)
        {
            loadForm(new hospitalForm());
        }

        private void button2_Click(object sender, EventArgs e)
        {
            loadForm(new bloodbankform());
        }

        private void btnTransactBlood_Click(object sender, EventArgs e)
        {
            loadForm(new TransactionForm());
        }

        private void button1_Click(object sender, EventArgs e)
        {
            loadForm(new DashboardForm());
        }

        private void mainPanel_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}