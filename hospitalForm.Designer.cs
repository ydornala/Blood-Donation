namespace Blood_Donation
{
    partial class hospitalForm
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
            Blood_Donation._blood_donation_dbDataSet _bd_dbDS;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(hospitalForm));
            this.hospitalFormName = new System.Windows.Forms.Label();
            this.lblHospitalName = new System.Windows.Forms.Label();
            this.txtHospitalName = new System.Windows.Forms.TextBox();
            this.lblHospitalRegistrationNumber = new System.Windows.Forms.Label();
            this.txtHospitalRegistrationNumber = new System.Windows.Forms.TextBox();
            this.lblHospitalAddress = new System.Windows.Forms.Label();
            this.txtHospitalAddress = new System.Windows.Forms.TextBox();
            this.lblZipCode = new System.Windows.Forms.Label();
            this.txtZipCode = new System.Windows.Forms.TextBox();
            this.txtPhoneNumber = new System.Windows.Forms.TextBox();
            this.lblPhoneNumber = new System.Windows.Forms.Label();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.hospitalsTA = new Blood_Donation._blood_donation_dbDataSetTableAdapters.HospitalsTableAdapter();
            this.btnClearAll = new System.Windows.Forms.Button();
            this.errorProviderHospital = new System.Windows.Forms.ErrorProvider(this.components);
            _bd_dbDS = new Blood_Donation._blood_donation_dbDataSet();
            ((System.ComponentModel.ISupportInitialize)(_bd_dbDS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderHospital)).BeginInit();
            this.SuspendLayout();
            // 
            // _bd_dbDS
            // 
            _bd_dbDS.DataSetName = "_blood_donation_dbDataSet";
            _bd_dbDS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // hospitalFormName
            // 
            this.hospitalFormName.AutoSize = true;
            this.hospitalFormName.BackColor = System.Drawing.Color.Transparent;
            this.hospitalFormName.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold);
            this.hospitalFormName.Location = new System.Drawing.Point(747, 301);
            this.hospitalFormName.Name = "hospitalFormName";
            this.hospitalFormName.Size = new System.Drawing.Size(226, 38);
            this.hospitalFormName.TabIndex = 0;
            this.hospitalFormName.Text = "Create  Hospital";
            this.hospitalFormName.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblHospitalName
            // 
            this.lblHospitalName.AutoSize = true;
            this.lblHospitalName.BackColor = System.Drawing.Color.Transparent;
            this.lblHospitalName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHospitalName.ForeColor = System.Drawing.Color.Black;
            this.lblHospitalName.Location = new System.Drawing.Point(583, 373);
            this.lblHospitalName.Name = "lblHospitalName";
            this.lblHospitalName.Size = new System.Drawing.Size(139, 25);
            this.lblHospitalName.TabIndex = 1;
            this.lblHospitalName.Text = "Hospital Name";
            // 
            // txtHospitalName
            // 
            this.txtHospitalName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtHospitalName.Location = new System.Drawing.Point(769, 373);
            this.txtHospitalName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtHospitalName.MaxLength = 50;
            this.txtHospitalName.Name = "txtHospitalName";
            this.txtHospitalName.Size = new System.Drawing.Size(268, 34);
            this.txtHospitalName.TabIndex = 2;
            this.txtHospitalName.Validating += new System.ComponentModel.CancelEventHandler(this.txtHospitalName_Validating);
            // 
            // lblHospitalRegistrationNumber
            // 
            this.lblHospitalRegistrationNumber.AutoSize = true;
            this.lblHospitalRegistrationNumber.BackColor = System.Drawing.Color.Transparent;
            this.lblHospitalRegistrationNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHospitalRegistrationNumber.ForeColor = System.Drawing.Color.Black;
            this.lblHospitalRegistrationNumber.Location = new System.Drawing.Point(459, 433);
            this.lblHospitalRegistrationNumber.Name = "lblHospitalRegistrationNumber";
            this.lblHospitalRegistrationNumber.Size = new System.Drawing.Size(263, 25);
            this.lblHospitalRegistrationNumber.TabIndex = 1;
            this.lblHospitalRegistrationNumber.Text = "Hospital Registration Number";
            this.lblHospitalRegistrationNumber.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // txtHospitalRegistrationNumber
            // 
            this.txtHospitalRegistrationNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtHospitalRegistrationNumber.Location = new System.Drawing.Point(769, 433);
            this.txtHospitalRegistrationNumber.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtHospitalRegistrationNumber.MaxLength = 10;
            this.txtHospitalRegistrationNumber.Name = "txtHospitalRegistrationNumber";
            this.txtHospitalRegistrationNumber.Size = new System.Drawing.Size(268, 34);
            this.txtHospitalRegistrationNumber.TabIndex = 2;
            this.txtHospitalRegistrationNumber.Validating += new System.ComponentModel.CancelEventHandler(this.txtHospitalRegistrationNumber_Validating);
            // 
            // lblHospitalAddress
            // 
            this.lblHospitalAddress.AutoSize = true;
            this.lblHospitalAddress.BackColor = System.Drawing.Color.Transparent;
            this.lblHospitalAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHospitalAddress.ForeColor = System.Drawing.Color.Black;
            this.lblHospitalAddress.Location = new System.Drawing.Point(562, 490);
            this.lblHospitalAddress.Name = "lblHospitalAddress";
            this.lblHospitalAddress.Size = new System.Drawing.Size(160, 25);
            this.lblHospitalAddress.TabIndex = 1;
            this.lblHospitalAddress.Text = "Hospital Address";
            // 
            // txtHospitalAddress
            // 
            this.txtHospitalAddress.Location = new System.Drawing.Point(769, 489);
            this.txtHospitalAddress.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtHospitalAddress.MaxLength = 140;
            this.txtHospitalAddress.Multiline = true;
            this.txtHospitalAddress.Name = "txtHospitalAddress";
            this.txtHospitalAddress.Size = new System.Drawing.Size(268, 52);
            this.txtHospitalAddress.TabIndex = 2;
            // 
            // lblZipCode
            // 
            this.lblZipCode.AutoSize = true;
            this.lblZipCode.BackColor = System.Drawing.Color.Transparent;
            this.lblZipCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblZipCode.ForeColor = System.Drawing.Color.Black;
            this.lblZipCode.Location = new System.Drawing.Point(630, 564);
            this.lblZipCode.Name = "lblZipCode";
            this.lblZipCode.Size = new System.Drawing.Size(92, 25);
            this.lblZipCode.TabIndex = 1;
            this.lblZipCode.Text = "Zip Code";
            this.lblZipCode.Click += new System.EventHandler(this.label1_Click_2);
            // 
            // txtZipCode
            // 
            this.txtZipCode.BackColor = System.Drawing.SystemColors.Window;
            this.txtZipCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtZipCode.Location = new System.Drawing.Point(769, 565);
            this.txtZipCode.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtZipCode.MaxLength = 5;
            this.txtZipCode.Name = "txtZipCode";
            this.txtZipCode.Size = new System.Drawing.Size(268, 34);
            this.txtZipCode.TabIndex = 2;
            this.txtZipCode.TextChanged += new System.EventHandler(this.txtZipCode_TextChanged);
            // 
            // txtPhoneNumber
            // 
            this.txtPhoneNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPhoneNumber.Location = new System.Drawing.Point(769, 623);
            this.txtPhoneNumber.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtPhoneNumber.MaxLength = 10;
            this.txtPhoneNumber.Name = "txtPhoneNumber";
            this.txtPhoneNumber.Size = new System.Drawing.Size(268, 34);
            this.txtPhoneNumber.TabIndex = 2;
            this.txtPhoneNumber.TextChanged += new System.EventHandler(this.txtPhoneNumber_TextChanged);
            this.txtPhoneNumber.Validating += new System.ComponentModel.CancelEventHandler(this.txtPhonenumber_Validating);
            // 
            // lblPhoneNumber
            // 
            this.lblPhoneNumber.AutoSize = true;
            this.lblPhoneNumber.BackColor = System.Drawing.Color.Transparent;
            this.lblPhoneNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPhoneNumber.ForeColor = System.Drawing.Color.Black;
            this.lblPhoneNumber.Location = new System.Drawing.Point(579, 632);
            this.lblPhoneNumber.Name = "lblPhoneNumber";
            this.lblPhoneNumber.Size = new System.Drawing.Size(143, 25);
            this.lblPhoneNumber.TabIndex = 1;
            this.lblPhoneNumber.Text = "Phone Number";
            this.lblPhoneNumber.Click += new System.EventHandler(this.label1_Click_2);
            // 
            // btnSubmit
            // 
            this.btnSubmit.BackColor = System.Drawing.Color.Maroon;
            this.btnSubmit.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSubmit.ForeColor = System.Drawing.Color.White;
            this.btnSubmit.Location = new System.Drawing.Point(682, 700);
            this.btnSubmit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(116, 47);
            this.btnSubmit.TabIndex = 3;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = false;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // hospitalsTA
            // 
            this.hospitalsTA.ClearBeforeFill = true;
            // 
            // btnClearAll
            // 
            this.btnClearAll.BackColor = System.Drawing.Color.Maroon;
            this.btnClearAll.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClearAll.ForeColor = System.Drawing.Color.White;
            this.btnClearAll.Location = new System.Drawing.Point(917, 700);
            this.btnClearAll.Name = "btnClearAll";
            this.btnClearAll.Size = new System.Drawing.Size(118, 47);
            this.btnClearAll.TabIndex = 4;
            this.btnClearAll.Text = "Clear All";
            this.btnClearAll.UseVisualStyleBackColor = false;
            this.btnClearAll.Click += new System.EventHandler(this.btnClearAll_Click);
            // 
            // errorProviderHospital
            // 
            this.errorProviderHospital.ContainerControl = this;
            // 
            // hospitalForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1068, 716);
            this.Controls.Add(this.btnClearAll);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.txtPhoneNumber);
            this.Controls.Add(this.txtZipCode);
            this.Controls.Add(this.lblPhoneNumber);
            this.Controls.Add(this.lblZipCode);
            this.Controls.Add(this.txtHospitalAddress);
            this.Controls.Add(this.lblHospitalAddress);
            this.Controls.Add(this.txtHospitalRegistrationNumber);
            this.Controls.Add(this.lblHospitalRegistrationNumber);
            this.Controls.Add(this.txtHospitalName);
            this.Controls.Add(this.lblHospitalName);
            this.Controls.Add(this.hospitalFormName);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "hospitalForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "hospitalForm";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.hospitalForm_Load);
            ((System.ComponentModel.ISupportInitialize)(_bd_dbDS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderHospital)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label hospitalFormName;
        private Label lblHospitalName;
        private TextBox txtHospitalName;
        private Label lblHospitalRegistrationNumber;
        private TextBox txtHospitalRegistrationNumber;
        private Label lblHospitalAddress;
        private TextBox txtHospitalAddress;
        private Label lblZipCode;
        private TextBox txtZipCode;
        private TextBox txtPhoneNumber;
        private Label lblPhoneNumber;
        private Button btnSubmit;
        private _blood_donation_dbDataSetTableAdapters.HospitalsTableAdapter hospitalsTA;
        private Button btnClearAll;
        private ErrorProvider errorProviderHospital;
    }
}