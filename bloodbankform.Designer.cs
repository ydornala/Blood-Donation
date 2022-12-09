namespace Blood_Donation
{
    partial class bloodbankform
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
            this.lblCreateBloodBank = new System.Windows.Forms.Label();
            this.lblBloodBankName = new System.Windows.Forms.Label();
            this.txtBloodBankName = new System.Windows.Forms.TextBox();
            this.lblBloodBankRegistrationNumber = new System.Windows.Forms.Label();
            this.txtBloodBankRegistrationNumber = new System.Windows.Forms.TextBox();
            this.lblBloodBankAddress = new System.Windows.Forms.Label();
            this.txtBloodBankAddress = new System.Windows.Forms.TextBox();
            this.lblPhoneNumber = new System.Windows.Forms.Label();
            this.txtPhoneNumber = new System.Windows.Forms.TextBox();
            this.lblZipCode = new System.Windows.Forms.Label();
            this.txtZipCode = new System.Windows.Forms.TextBox();
            this.btnBBSubmit = new System.Windows.Forms.Button();
            this.btnClearAll = new System.Windows.Forms.Button();
            this.errorProviderBloodBank = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderBloodBank)).BeginInit();
            this.SuspendLayout();
            // 
            // lblCreateBloodBank
            // 
            this.lblCreateBloodBank.AutoSize = true;
            this.lblCreateBloodBank.BackColor = System.Drawing.Color.Transparent;
            this.lblCreateBloodBank.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold);
            this.lblCreateBloodBank.Location = new System.Drawing.Point(766, 320);
            this.lblCreateBloodBank.Name = "lblCreateBloodBank";
            this.lblCreateBloodBank.Size = new System.Drawing.Size(260, 38);
            this.lblCreateBloodBank.TabIndex = 0;
            this.lblCreateBloodBank.Text = "Create Blood Bank";
            // 
            // lblBloodBankName
            // 
            this.lblBloodBankName.AutoSize = true;
            this.lblBloodBankName.BackColor = System.Drawing.Color.Transparent;
            this.lblBloodBankName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBloodBankName.Location = new System.Drawing.Point(647, 385);
            this.lblBloodBankName.Name = "lblBloodBankName";
            this.lblBloodBankName.Size = new System.Drawing.Size(169, 25);
            this.lblBloodBankName.TabIndex = 1;
            this.lblBloodBankName.Text = "Blood Bank Name";
            // 
            // txtBloodBankName
            // 
            this.txtBloodBankName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBloodBankName.Location = new System.Drawing.Point(868, 376);
            this.txtBloodBankName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtBloodBankName.MaxLength = 50;
            this.txtBloodBankName.Name = "txtBloodBankName";
            this.txtBloodBankName.Size = new System.Drawing.Size(270, 34);
            this.txtBloodBankName.TabIndex = 2;
            this.txtBloodBankName.Validating += new System.ComponentModel.CancelEventHandler(this.txtBloodBankName_Validating);
            // 
            // lblBloodBankRegistrationNumber
            // 
            this.lblBloodBankRegistrationNumber.AutoSize = true;
            this.lblBloodBankRegistrationNumber.BackColor = System.Drawing.Color.Transparent;
            this.lblBloodBankRegistrationNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBloodBankRegistrationNumber.Location = new System.Drawing.Point(529, 446);
            this.lblBloodBankRegistrationNumber.Name = "lblBloodBankRegistrationNumber";
            this.lblBloodBankRegistrationNumber.Size = new System.Drawing.Size(287, 25);
            this.lblBloodBankRegistrationNumber.TabIndex = 1;
            this.lblBloodBankRegistrationNumber.Text = "Blood Bank Registation Number";
            // 
            // txtBloodBankRegistrationNumber
            // 
            this.txtBloodBankRegistrationNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBloodBankRegistrationNumber.Location = new System.Drawing.Point(868, 437);
            this.txtBloodBankRegistrationNumber.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtBloodBankRegistrationNumber.MaxLength = 10;
            this.txtBloodBankRegistrationNumber.Name = "txtBloodBankRegistrationNumber";
            this.txtBloodBankRegistrationNumber.Size = new System.Drawing.Size(270, 34);
            this.txtBloodBankRegistrationNumber.TabIndex = 2;
            this.txtBloodBankRegistrationNumber.Validating += new System.ComponentModel.CancelEventHandler(this.txtBloodBankRegistrationNumber_Validating);
            // 
            // lblBloodBankAddress
            // 
            this.lblBloodBankAddress.AutoSize = true;
            this.lblBloodBankAddress.BackColor = System.Drawing.Color.Transparent;
            this.lblBloodBankAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBloodBankAddress.Location = new System.Drawing.Point(626, 503);
            this.lblBloodBankAddress.Name = "lblBloodBankAddress";
            this.lblBloodBankAddress.Size = new System.Drawing.Size(190, 25);
            this.lblBloodBankAddress.TabIndex = 1;
            this.lblBloodBankAddress.Text = "Blood Bank Address";
            // 
            // txtBloodBankAddress
            // 
            this.txtBloodBankAddress.Location = new System.Drawing.Point(868, 498);
            this.txtBloodBankAddress.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtBloodBankAddress.MaxLength = 140;
            this.txtBloodBankAddress.Multiline = true;
            this.txtBloodBankAddress.Name = "txtBloodBankAddress";
            this.txtBloodBankAddress.Size = new System.Drawing.Size(270, 65);
            this.txtBloodBankAddress.TabIndex = 2;
            // 
            // lblPhoneNumber
            // 
            this.lblPhoneNumber.AutoSize = true;
            this.lblPhoneNumber.BackColor = System.Drawing.Color.Transparent;
            this.lblPhoneNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPhoneNumber.Location = new System.Drawing.Point(673, 595);
            this.lblPhoneNumber.Name = "lblPhoneNumber";
            this.lblPhoneNumber.Size = new System.Drawing.Size(143, 25);
            this.lblPhoneNumber.TabIndex = 1;
            this.lblPhoneNumber.Text = "Phone Number";
            // 
            // txtPhoneNumber
            // 
            this.txtPhoneNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPhoneNumber.Location = new System.Drawing.Point(868, 586);
            this.txtPhoneNumber.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtPhoneNumber.MaxLength = 10;
            this.txtPhoneNumber.Name = "txtPhoneNumber";
            this.txtPhoneNumber.Size = new System.Drawing.Size(270, 34);
            this.txtPhoneNumber.TabIndex = 2;
            this.txtPhoneNumber.Validating += new System.ComponentModel.CancelEventHandler(this.txtPhoneNumber_Validating);
            // 
            // lblZipCode
            // 
            this.lblZipCode.AutoSize = true;
            this.lblZipCode.BackColor = System.Drawing.Color.Transparent;
            this.lblZipCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblZipCode.Location = new System.Drawing.Point(724, 650);
            this.lblZipCode.Name = "lblZipCode";
            this.lblZipCode.Size = new System.Drawing.Size(92, 25);
            this.lblZipCode.TabIndex = 1;
            this.lblZipCode.Text = "Zip Code";
            // 
            // txtZipCode
            // 
            this.txtZipCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtZipCode.Location = new System.Drawing.Point(868, 641);
            this.txtZipCode.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtZipCode.MaxLength = 5;
            this.txtZipCode.Name = "txtZipCode";
            this.txtZipCode.Size = new System.Drawing.Size(270, 34);
            this.txtZipCode.TabIndex = 2;
            // 
            // btnBBSubmit
            // 
            this.btnBBSubmit.BackColor = System.Drawing.Color.Maroon;
            this.btnBBSubmit.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBBSubmit.ForeColor = System.Drawing.Color.White;
            this.btnBBSubmit.Location = new System.Drawing.Point(678, 731);
            this.btnBBSubmit.Margin = new System.Windows.Forms.Padding(0);
            this.btnBBSubmit.Name = "btnBBSubmit";
            this.btnBBSubmit.Size = new System.Drawing.Size(150, 50);
            this.btnBBSubmit.TabIndex = 3;
            this.btnBBSubmit.Text = "Submit";
            this.btnBBSubmit.UseVisualStyleBackColor = false;
            this.btnBBSubmit.Click += new System.EventHandler(this.btnBBSubmit_Click);
            // 
            // btnClearAll
            // 
            this.btnClearAll.BackColor = System.Drawing.Color.Maroon;
            this.btnClearAll.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClearAll.ForeColor = System.Drawing.Color.White;
            this.btnClearAll.Location = new System.Drawing.Point(988, 731);
            this.btnClearAll.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnClearAll.Name = "btnClearAll";
            this.btnClearAll.Size = new System.Drawing.Size(150, 50);
            this.btnClearAll.TabIndex = 3;
            this.btnClearAll.Text = "Clear All";
            this.btnClearAll.UseVisualStyleBackColor = false;
            this.btnClearAll.Click += new System.EventHandler(this.btnClearAll_Click);
            // 
            // errorProviderBloodBank
            // 
            this.errorProviderBloodBank.ContainerControl = this;
            // 
            // bloodbankform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = global::Blood_Donation.Properties.Resources.bg2;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(972, 667);
            this.Controls.Add(this.btnClearAll);
            this.Controls.Add(this.btnBBSubmit);
            this.Controls.Add(this.txtZipCode);
            this.Controls.Add(this.lblZipCode);
            this.Controls.Add(this.txtPhoneNumber);
            this.Controls.Add(this.lblPhoneNumber);
            this.Controls.Add(this.txtBloodBankAddress);
            this.Controls.Add(this.lblBloodBankAddress);
            this.Controls.Add(this.txtBloodBankRegistrationNumber);
            this.Controls.Add(this.lblBloodBankRegistrationNumber);
            this.Controls.Add(this.txtBloodBankName);
            this.Controls.Add(this.lblBloodBankName);
            this.Controls.Add(this.lblCreateBloodBank);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "bloodbankform";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "bloodbankform";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderBloodBank)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lblCreateBloodBank;
        private Label lblBloodBankName;
        private TextBox txtBloodBankName;
        private Label lblBloodBankRegistrationNumber;
        private TextBox txtBloodBankRegistrationNumber;
        private Label lblBloodBankAddress;
        private TextBox txtBloodBankAddress;
        private Label lblPhoneNumber;
        private TextBox txtPhoneNumber;
        private Label lblZipCode;
        private TextBox txtZipCode;
        private Button btnBBSubmit;
        private Button btnClearAll;
        private ErrorProvider errorProviderBloodBank;
    }
}