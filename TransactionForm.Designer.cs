namespace Blood_Donation
{
    partial class TransactionForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.lblheadTransaction = new System.Windows.Forms.Label();
            this.lblUser = new System.Windows.Forms.Label();
            this.lblHospital = new System.Windows.Forms.Label();
            this.lblBloodBank = new System.Windows.Forms.Label();
            this.lblTransactionType = new System.Windows.Forms.Label();
            this.lblBloodGroup = new System.Windows.Forms.Label();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.comboUser = new System.Windows.Forms.ComboBox();
            this._blood_donation_dbDataSet1 = new Blood_Donation._blood_donation_dbDataSet();
            this.comboHospital = new System.Windows.Forms.ComboBox();
            this.comboBloodBank = new System.Windows.Forms.ComboBox();
            this.comboTransactionType = new System.Windows.Forms.ComboBox();
            this.comboBloodGroup = new System.Windows.Forms.ComboBox();
            this.bloodGroupsTableAdapter1 = new Blood_Donation._blood_donation_dbDataSetTableAdapters.BloodGroupsTableAdapter();
            this.bloodBanksTableAdapter1 = new Blood_Donation._blood_donation_dbDataSetTableAdapters.BloodBanksTableAdapter();
            this.hospitalsTableAdapter1 = new Blood_Donation._blood_donation_dbDataSetTableAdapters.HospitalsTableAdapter();
            this.transactionTypesTableAdapter1 = new Blood_Donation._blood_donation_dbDataSetTableAdapters.TransactionTypesTableAdapter();
            this.usersTableAdapter1 = new Blood_Donation._blood_donation_dbDataSetTableAdapters.UsersTableAdapter();
            this.transactionsTableAdapter1 = new Blood_Donation._blood_donation_dbDataSetTableAdapters.TransactionsTableAdapter();
            this.errorProviderTransaction = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this._blood_donation_dbDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderTransaction)).BeginInit();
            this.SuspendLayout();
            // 
            // lblheadTransaction
            // 
            this.lblheadTransaction.AutoSize = true;
            this.lblheadTransaction.BackColor = System.Drawing.Color.Transparent;
            this.lblheadTransaction.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold);
            this.lblheadTransaction.Location = new System.Drawing.Point(774, 261);
            this.lblheadTransaction.Name = "lblheadTransaction";
            this.lblheadTransaction.Size = new System.Drawing.Size(167, 38);
            this.lblheadTransaction.TabIndex = 0;
            this.lblheadTransaction.Text = "Transaction";
            // 
            // lblUser
            // 
            this.lblUser.AutoSize = true;
            this.lblUser.BackColor = System.Drawing.Color.Transparent;
            this.lblUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUser.Location = new System.Drawing.Point(629, 322);
            this.lblUser.Name = "lblUser";
            this.lblUser.Size = new System.Drawing.Size(53, 25);
            this.lblUser.TabIndex = 1;
            this.lblUser.Text = "User";
            // 
            // lblHospital
            // 
            this.lblHospital.AutoSize = true;
            this.lblHospital.BackColor = System.Drawing.Color.Transparent;
            this.lblHospital.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHospital.Location = new System.Drawing.Point(600, 379);
            this.lblHospital.Name = "lblHospital";
            this.lblHospital.Size = new System.Drawing.Size(82, 25);
            this.lblHospital.TabIndex = 1;
            this.lblHospital.Text = "Hospital";
            // 
            // lblBloodBank
            // 
            this.lblBloodBank.AutoSize = true;
            this.lblBloodBank.BackColor = System.Drawing.Color.Transparent;
            this.lblBloodBank.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBloodBank.Location = new System.Drawing.Point(570, 442);
            this.lblBloodBank.Name = "lblBloodBank";
            this.lblBloodBank.Size = new System.Drawing.Size(112, 25);
            this.lblBloodBank.TabIndex = 1;
            this.lblBloodBank.Text = "Blood Bank";
            this.lblBloodBank.Click += new System.EventHandler(this.lblBloodBank_Click);
            // 
            // lblTransactionType
            // 
            this.lblTransactionType.AutoSize = true;
            this.lblTransactionType.BackColor = System.Drawing.Color.Transparent;
            this.lblTransactionType.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTransactionType.Location = new System.Drawing.Point(517, 508);
            this.lblTransactionType.Name = "lblTransactionType";
            this.lblTransactionType.Size = new System.Drawing.Size(165, 25);
            this.lblTransactionType.TabIndex = 1;
            this.lblTransactionType.Text = "Transaction Type";
            this.lblTransactionType.Click += new System.EventHandler(this.label6_Click);
            // 
            // lblBloodGroup
            // 
            this.lblBloodGroup.AutoSize = true;
            this.lblBloodGroup.BackColor = System.Drawing.Color.Transparent;
            this.lblBloodGroup.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBloodGroup.Location = new System.Drawing.Point(561, 577);
            this.lblBloodGroup.Name = "lblBloodGroup";
            this.lblBloodGroup.Size = new System.Drawing.Size(121, 25);
            this.lblBloodGroup.TabIndex = 1;
            this.lblBloodGroup.Text = "Blood Group";
            this.lblBloodGroup.Click += new System.EventHandler(this.label6_Click);
            // 
            // btnSubmit
            // 
            this.btnSubmit.BackColor = System.Drawing.Color.Maroon;
            this.btnSubmit.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSubmit.ForeColor = System.Drawing.Color.White;
            this.btnSubmit.Location = new System.Drawing.Point(800, 643);
            this.btnSubmit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(132, 48);
            this.btnSubmit.TabIndex = 3;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = false;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // comboUser
            // 
            this.comboUser.DataSource = this._blood_donation_dbDataSet1;
            this.comboUser.DisplayMember = "Users.firstName";
            this.comboUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboUser.FormattingEnabled = true;
            this.comboUser.Location = new System.Drawing.Point(719, 316);
            this.comboUser.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comboUser.Name = "comboUser";
            this.comboUser.Size = new System.Drawing.Size(344, 37);
            this.comboUser.TabIndex = 4;
            this.comboUser.ValueMember = "Users.userID";
            this.comboUser.SelectedIndexChanged += new System.EventHandler(this.comboUser_SelectedIndexChanged);
            // 
            // _blood_donation_dbDataSet1
            // 
            this._blood_donation_dbDataSet1.DataSetName = "_bd_dbTransactionsDataSet";
            this._blood_donation_dbDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // comboHospital
            // 
            this.comboHospital.DataSource = this._blood_donation_dbDataSet1;
            this.comboHospital.DisplayMember = "Hospitals.hospitalName";
            this.comboHospital.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboHospital.FormattingEnabled = true;
            this.comboHospital.Location = new System.Drawing.Point(719, 379);
            this.comboHospital.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comboHospital.Name = "comboHospital";
            this.comboHospital.Size = new System.Drawing.Size(344, 37);
            this.comboHospital.TabIndex = 4;
            this.comboHospital.ValueMember = "Hospitals.hospitalID";
            // 
            // comboBloodBank
            // 
            this.comboBloodBank.DataSource = this._blood_donation_dbDataSet1;
            this.comboBloodBank.DisplayMember = "BloodBanks.bloodBankName";
            this.comboBloodBank.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBloodBank.FormattingEnabled = true;
            this.comboBloodBank.Location = new System.Drawing.Point(719, 442);
            this.comboBloodBank.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comboBloodBank.Name = "comboBloodBank";
            this.comboBloodBank.Size = new System.Drawing.Size(344, 37);
            this.comboBloodBank.TabIndex = 4;
            this.comboBloodBank.ValueMember = "BloodBanks.bloodBankID";
            // 
            // comboTransactionType
            // 
            this.comboTransactionType.DataSource = this._blood_donation_dbDataSet1;
            this.comboTransactionType.DisplayMember = "TransactionTypes.transactionTypeName";
            this.comboTransactionType.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboTransactionType.FormattingEnabled = true;
            this.comboTransactionType.Location = new System.Drawing.Point(719, 508);
            this.comboTransactionType.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comboTransactionType.Name = "comboTransactionType";
            this.comboTransactionType.Size = new System.Drawing.Size(344, 37);
            this.comboTransactionType.TabIndex = 4;
            this.comboTransactionType.ValueMember = "TransactionTypes.transactionTypeID";
            // 
            // comboBloodGroup
            // 
            this.comboBloodGroup.DataSource = this._blood_donation_dbDataSet1;
            this.comboBloodGroup.DisplayMember = "BloodGroups.BloodGroupName";
            this.comboBloodGroup.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBloodGroup.FormattingEnabled = true;
            this.comboBloodGroup.Location = new System.Drawing.Point(719, 577);
            this.comboBloodGroup.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comboBloodGroup.Name = "comboBloodGroup";
            this.comboBloodGroup.Size = new System.Drawing.Size(344, 37);
            this.comboBloodGroup.TabIndex = 4;
            this.comboBloodGroup.ValueMember = "BloodGroups.BloodGroupID";
            // 
            // bloodGroupsTableAdapter1
            // 
            this.bloodGroupsTableAdapter1.ClearBeforeFill = true;
            // 
            // bloodBanksTableAdapter1
            // 
            this.bloodBanksTableAdapter1.ClearBeforeFill = true;
            // 
            // hospitalsTableAdapter1
            // 
            this.hospitalsTableAdapter1.ClearBeforeFill = true;
            // 
            // transactionTypesTableAdapter1
            // 
            this.transactionTypesTableAdapter1.ClearBeforeFill = true;
            // 
            // usersTableAdapter1
            // 
            this.usersTableAdapter1.ClearBeforeFill = true;
            // 
            // transactionsTableAdapter1
            // 
            this.transactionsTableAdapter1.ClearBeforeFill = true;
            // 
            // errorProviderTransaction
            // 
            this.errorProviderTransaction.ContainerControl = this;
            // 
            // TransactionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Blood_Donation.Properties.Resources.bg2;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1100, 717);
            this.Controls.Add(this.comboBloodGroup);
            this.Controls.Add(this.comboTransactionType);
            this.Controls.Add(this.comboBloodBank);
            this.Controls.Add(this.comboHospital);
            this.Controls.Add(this.comboUser);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.lblBloodGroup);
            this.Controls.Add(this.lblTransactionType);
            this.Controls.Add(this.lblBloodBank);
            this.Controls.Add(this.lblHospital);
            this.Controls.Add(this.lblUser);
            this.Controls.Add(this.lblheadTransaction);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "TransactionForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TransactionForm";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.TransactionForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this._blood_donation_dbDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderTransaction)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lblheadTransaction;
        private Label lblUser;
        private Label lblHospital;
        private Label lblBloodBank;
        private Label lblTransactionType;
        private Label lblBloodGroup;
        private Button btnSubmit;
        private ComboBox comboUser;
        private ComboBox comboHospital;
        private ComboBox comboBloodBank;
        private ComboBox comboTransactionType;
        private ComboBox comboBloodGroup;
        private _blood_donation_dbDataSet _blood_donation_dbDataSet1;
        private _blood_donation_dbDataSetTableAdapters.BloodGroupsTableAdapter bloodGroupsTableAdapter1;
        private _blood_donation_dbDataSetTableAdapters.BloodBanksTableAdapter bloodBanksTableAdapter1;
        private _blood_donation_dbDataSetTableAdapters.HospitalsTableAdapter hospitalsTableAdapter1;
        private _blood_donation_dbDataSetTableAdapters.TransactionTypesTableAdapter transactionTypesTableAdapter1;
        private _blood_donation_dbDataSetTableAdapters.UsersTableAdapter usersTableAdapter1;
        private _blood_donation_dbDataSetTableAdapters.TransactionsTableAdapter transactionsTableAdapter1;
        private ErrorProvider errorProviderTransaction;
    }
}