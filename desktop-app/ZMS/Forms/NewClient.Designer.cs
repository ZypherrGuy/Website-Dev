namespace ZMS.Forms
{
    partial class NewClient
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
      this.panelNewClientTop = new System.Windows.Forms.Panel();
      this.btnCancelNewClient = new System.Windows.Forms.Button();
      this.btnSubmitNewClient = new System.Windows.Forms.Button();
      this.lblCompanyName = new System.Windows.Forms.Label();
      this.groupBoxNewClientCompany = new System.Windows.Forms.GroupBox();
      this.groupBoxNewClientInvoiceRecipient = new System.Windows.Forms.GroupBox();
      this.lblIndustry = new System.Windows.Forms.Label();
      this.groupBoxCompanyAddress = new System.Windows.Forms.GroupBox();
      this.lblAddressStreet = new System.Windows.Forms.Label();
      this.inputAddressStreet = new System.Windows.Forms.TextBox();
      this.lblAddressTown = new System.Windows.Forms.Label();
      this.inputAddressTown = new System.Windows.Forms.TextBox();
      this.lblAddressState = new System.Windows.Forms.Label();
      this.inputAddressState = new System.Windows.Forms.TextBox();
      this.lblAddressCountry = new System.Windows.Forms.Label();
      this.inputAddressCountry = new System.Windows.Forms.TextBox();
      this.lblAddressPostCode = new System.Windows.Forms.Label();
      this.inputAddressPostCode = new System.Windows.Forms.TextBox();
      this.inputIndustry = new System.Windows.Forms.TextBox();
      this.inputCompanyName = new System.Windows.Forms.TextBox();
      this.inputCompanyTel = new System.Windows.Forms.TextBox();
      this.inputCompanySite = new System.Windows.Forms.TextBox();
      this.lblCompanySite = new System.Windows.Forms.Label();
      this.lblCompanyTel = new System.Windows.Forms.Label();
      this.inputInvoiceRecipientCell = new System.Windows.Forms.TextBox();
      this.inputInvoiceRecipientTel = new System.Windows.Forms.TextBox();
      this.lblInvoiceRecipientTel = new System.Windows.Forms.Label();
      this.lblInvoiceRecipientCell = new System.Windows.Forms.Label();
      this.inputInvoiceRecipientName = new System.Windows.Forms.TextBox();
      this.lblInvoiceRecipientName = new System.Windows.Forms.Label();
      this.lblInvoiceRecipientTitle = new System.Windows.Forms.Label();
      this.comboBoxInvoiceRecipientTitle = new System.Windows.Forms.ComboBox();
      this.inputInvoiceRecipientEmail = new System.Windows.Forms.TextBox();
      this.lblInvoiceRecipientEmail = new System.Windows.Forms.Label();
      this.lblNewClientTop = new System.Windows.Forms.Label();
      this.panelNewClientTop.SuspendLayout();
      this.groupBoxNewClientCompany.SuspendLayout();
      this.groupBoxNewClientInvoiceRecipient.SuspendLayout();
      this.groupBoxCompanyAddress.SuspendLayout();
      this.SuspendLayout();
      // 
      // panelNewClientTop
      // 
      this.panelNewClientTop.Controls.Add(this.lblNewClientTop);
      this.panelNewClientTop.Dock = System.Windows.Forms.DockStyle.Top;
      this.panelNewClientTop.Location = new System.Drawing.Point(0, 0);
      this.panelNewClientTop.Name = "panelNewClientTop";
      this.panelNewClientTop.Size = new System.Drawing.Size(790, 100);
      this.panelNewClientTop.TabIndex = 0;
      // 
      // btnCancelNewClient
      // 
      this.btnCancelNewClient.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
      this.btnCancelNewClient.FlatAppearance.BorderSize = 0;
      this.btnCancelNewClient.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.btnCancelNewClient.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
      this.btnCancelNewClient.Location = new System.Drawing.Point(528, 634);
      this.btnCancelNewClient.Name = "btnCancelNewClient";
      this.btnCancelNewClient.Size = new System.Drawing.Size(122, 39);
      this.btnCancelNewClient.TabIndex = 4;
      this.btnCancelNewClient.Text = "Cancel";
      this.btnCancelNewClient.UseVisualStyleBackColor = true;
      this.btnCancelNewClient.Click += new System.EventHandler(this.btnCancelNewClient_Click);
      // 
      // btnSubmitNewClient
      // 
      this.btnSubmitNewClient.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
      this.btnSubmitNewClient.FlatAppearance.BorderSize = 0;
      this.btnSubmitNewClient.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.btnSubmitNewClient.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.btnSubmitNewClient.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
      this.btnSubmitNewClient.Location = new System.Drawing.Point(655, 634);
      this.btnSubmitNewClient.Name = "btnSubmitNewClient";
      this.btnSubmitNewClient.Size = new System.Drawing.Size(122, 39);
      this.btnSubmitNewClient.TabIndex = 3;
      this.btnSubmitNewClient.Text = "Submit";
      this.btnSubmitNewClient.UseVisualStyleBackColor = true;
      this.btnSubmitNewClient.Click += new System.EventHandler(this.btnSubmitNewClient_Click);
      // 
      // lblCompanyName
      // 
      this.lblCompanyName.AutoSize = true;
      this.lblCompanyName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
      this.lblCompanyName.Location = new System.Drawing.Point(25, 38);
      this.lblCompanyName.Name = "lblCompanyName";
      this.lblCompanyName.Size = new System.Drawing.Size(112, 17);
      this.lblCompanyName.TabIndex = 13;
      this.lblCompanyName.Text = "Company Name:";
      // 
      // groupBoxNewClientCompany
      // 
      this.groupBoxNewClientCompany.Controls.Add(this.inputCompanyTel);
      this.groupBoxNewClientCompany.Controls.Add(this.inputCompanySite);
      this.groupBoxNewClientCompany.Controls.Add(this.lblCompanySite);
      this.groupBoxNewClientCompany.Controls.Add(this.lblCompanyTel);
      this.groupBoxNewClientCompany.Controls.Add(this.inputCompanyName);
      this.groupBoxNewClientCompany.Controls.Add(this.inputIndustry);
      this.groupBoxNewClientCompany.Controls.Add(this.groupBoxCompanyAddress);
      this.groupBoxNewClientCompany.Controls.Add(this.lblIndustry);
      this.groupBoxNewClientCompany.Controls.Add(this.lblCompanyName);
      this.groupBoxNewClientCompany.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
      this.groupBoxNewClientCompany.Location = new System.Drawing.Point(12, 119);
      this.groupBoxNewClientCompany.Name = "groupBoxNewClientCompany";
      this.groupBoxNewClientCompany.Size = new System.Drawing.Size(766, 334);
      this.groupBoxNewClientCompany.TabIndex = 14;
      this.groupBoxNewClientCompany.TabStop = false;
      this.groupBoxNewClientCompany.Text = "Client Details";
      // 
      // groupBoxNewClientInvoiceRecipient
      // 
      this.groupBoxNewClientInvoiceRecipient.Controls.Add(this.inputInvoiceRecipientEmail);
      this.groupBoxNewClientInvoiceRecipient.Controls.Add(this.lblInvoiceRecipientEmail);
      this.groupBoxNewClientInvoiceRecipient.Controls.Add(this.comboBoxInvoiceRecipientTitle);
      this.groupBoxNewClientInvoiceRecipient.Controls.Add(this.inputInvoiceRecipientCell);
      this.groupBoxNewClientInvoiceRecipient.Controls.Add(this.inputInvoiceRecipientTel);
      this.groupBoxNewClientInvoiceRecipient.Controls.Add(this.lblInvoiceRecipientTel);
      this.groupBoxNewClientInvoiceRecipient.Controls.Add(this.lblInvoiceRecipientCell);
      this.groupBoxNewClientInvoiceRecipient.Controls.Add(this.inputInvoiceRecipientName);
      this.groupBoxNewClientInvoiceRecipient.Controls.Add(this.lblInvoiceRecipientName);
      this.groupBoxNewClientInvoiceRecipient.Controls.Add(this.lblInvoiceRecipientTitle);
      this.groupBoxNewClientInvoiceRecipient.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
      this.groupBoxNewClientInvoiceRecipient.Location = new System.Drawing.Point(12, 459);
      this.groupBoxNewClientInvoiceRecipient.Name = "groupBoxNewClientInvoiceRecipient";
      this.groupBoxNewClientInvoiceRecipient.Size = new System.Drawing.Size(765, 162);
      this.groupBoxNewClientInvoiceRecipient.TabIndex = 15;
      this.groupBoxNewClientInvoiceRecipient.TabStop = false;
      this.groupBoxNewClientInvoiceRecipient.Text = "Client Invoice Recipient";
      // 
      // lblIndustry
      // 
      this.lblIndustry.AutoSize = true;
      this.lblIndustry.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
      this.lblIndustry.Location = new System.Drawing.Point(380, 41);
      this.lblIndustry.Name = "lblIndustry";
      this.lblIndustry.Size = new System.Drawing.Size(62, 17);
      this.lblIndustry.TabIndex = 15;
      this.lblIndustry.Text = "Industry:";
      // 
      // groupBoxCompanyAddress
      // 
      this.groupBoxCompanyAddress.Controls.Add(this.lblAddressPostCode);
      this.groupBoxCompanyAddress.Controls.Add(this.inputAddressPostCode);
      this.groupBoxCompanyAddress.Controls.Add(this.lblAddressCountry);
      this.groupBoxCompanyAddress.Controls.Add(this.inputAddressCountry);
      this.groupBoxCompanyAddress.Controls.Add(this.lblAddressState);
      this.groupBoxCompanyAddress.Controls.Add(this.inputAddressState);
      this.groupBoxCompanyAddress.Controls.Add(this.lblAddressTown);
      this.groupBoxCompanyAddress.Controls.Add(this.inputAddressTown);
      this.groupBoxCompanyAddress.Controls.Add(this.lblAddressStreet);
      this.groupBoxCompanyAddress.Controls.Add(this.inputAddressStreet);
      this.groupBoxCompanyAddress.Location = new System.Drawing.Point(28, 117);
      this.groupBoxCompanyAddress.Name = "groupBoxCompanyAddress";
      this.groupBoxCompanyAddress.Size = new System.Drawing.Size(711, 193);
      this.groupBoxCompanyAddress.TabIndex = 16;
      this.groupBoxCompanyAddress.TabStop = false;
      this.groupBoxCompanyAddress.Text = "Physical Address";
      // 
      // lblAddressStreet
      // 
      this.lblAddressStreet.AutoSize = true;
      this.lblAddressStreet.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
      this.lblAddressStreet.Location = new System.Drawing.Point(15, 29);
      this.lblAddressStreet.Name = "lblAddressStreet";
      this.lblAddressStreet.Size = new System.Drawing.Size(64, 17);
      this.lblAddressStreet.TabIndex = 15;
      this.lblAddressStreet.Text = "Address:";
      // 
      // inputAddressStreet
      // 
      this.inputAddressStreet.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.inputAddressStreet.Location = new System.Drawing.Point(120, 32);
      this.inputAddressStreet.Multiline = true;
      this.inputAddressStreet.Name = "inputAddressStreet";
      this.inputAddressStreet.Size = new System.Drawing.Size(203, 124);
      this.inputAddressStreet.TabIndex = 14;
      // 
      // lblAddressTown
      // 
      this.lblAddressTown.AutoSize = true;
      this.lblAddressTown.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
      this.lblAddressTown.Location = new System.Drawing.Point(352, 32);
      this.lblAddressTown.Name = "lblAddressTown";
      this.lblAddressTown.Size = new System.Drawing.Size(73, 17);
      this.lblAddressTown.TabIndex = 18;
      this.lblAddressTown.Text = "Town/City:";
      // 
      // inputAddressTown
      // 
      this.inputAddressTown.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.inputAddressTown.Location = new System.Drawing.Point(488, 29);
      this.inputAddressTown.Name = "inputAddressTown";
      this.inputAddressTown.Size = new System.Drawing.Size(203, 23);
      this.inputAddressTown.TabIndex = 17;
      // 
      // lblAddressState
      // 
      this.lblAddressState.AutoSize = true;
      this.lblAddressState.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
      this.lblAddressState.Location = new System.Drawing.Point(352, 67);
      this.lblAddressState.Name = "lblAddressState";
      this.lblAddressState.Size = new System.Drawing.Size(104, 17);
      this.lblAddressState.TabIndex = 20;
      this.lblAddressState.Text = "Province/State:";
      // 
      // inputAddressState
      // 
      this.inputAddressState.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.inputAddressState.Location = new System.Drawing.Point(488, 64);
      this.inputAddressState.Name = "inputAddressState";
      this.inputAddressState.Size = new System.Drawing.Size(203, 23);
      this.inputAddressState.TabIndex = 19;
      // 
      // lblAddressCountry
      // 
      this.lblAddressCountry.AutoSize = true;
      this.lblAddressCountry.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
      this.lblAddressCountry.Location = new System.Drawing.Point(352, 103);
      this.lblAddressCountry.Name = "lblAddressCountry";
      this.lblAddressCountry.Size = new System.Drawing.Size(61, 17);
      this.lblAddressCountry.TabIndex = 22;
      this.lblAddressCountry.Text = "Country:";
      // 
      // inputAddressCountry
      // 
      this.inputAddressCountry.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.inputAddressCountry.Location = new System.Drawing.Point(488, 100);
      this.inputAddressCountry.Name = "inputAddressCountry";
      this.inputAddressCountry.Size = new System.Drawing.Size(203, 23);
      this.inputAddressCountry.TabIndex = 21;
      // 
      // lblAddressPostCode
      // 
      this.lblAddressPostCode.AutoSize = true;
      this.lblAddressPostCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
      this.lblAddressPostCode.Location = new System.Drawing.Point(352, 139);
      this.lblAddressPostCode.Name = "lblAddressPostCode";
      this.lblAddressPostCode.Size = new System.Drawing.Size(92, 17);
      this.lblAddressPostCode.TabIndex = 24;
      this.lblAddressPostCode.Text = "Postal Code: ";
      // 
      // inputAddressPostCode
      // 
      this.inputAddressPostCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.inputAddressPostCode.Location = new System.Drawing.Point(608, 136);
      this.inputAddressPostCode.Name = "inputAddressPostCode";
      this.inputAddressPostCode.Size = new System.Drawing.Size(83, 23);
      this.inputAddressPostCode.TabIndex = 23;
      // 
      // inputIndustry
      // 
      this.inputIndustry.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.inputIndustry.Location = new System.Drawing.Point(515, 38);
      this.inputIndustry.Name = "inputIndustry";
      this.inputIndustry.Size = new System.Drawing.Size(204, 23);
      this.inputIndustry.TabIndex = 17;
      // 
      // inputCompanyName
      // 
      this.inputCompanyName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.inputCompanyName.Location = new System.Drawing.Point(148, 38);
      this.inputCompanyName.Name = "inputCompanyName";
      this.inputCompanyName.Size = new System.Drawing.Size(204, 23);
      this.inputCompanyName.TabIndex = 18;
      // 
      // inputCompanyTel
      // 
      this.inputCompanyTel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.inputCompanyTel.Location = new System.Drawing.Point(148, 74);
      this.inputCompanyTel.Name = "inputCompanyTel";
      this.inputCompanyTel.Size = new System.Drawing.Size(204, 23);
      this.inputCompanyTel.TabIndex = 22;
      // 
      // inputCompanySite
      // 
      this.inputCompanySite.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.inputCompanySite.Location = new System.Drawing.Point(515, 74);
      this.inputCompanySite.Name = "inputCompanySite";
      this.inputCompanySite.Size = new System.Drawing.Size(204, 23);
      this.inputCompanySite.TabIndex = 21;
      // 
      // lblCompanySite
      // 
      this.lblCompanySite.AutoSize = true;
      this.lblCompanySite.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
      this.lblCompanySite.Location = new System.Drawing.Point(380, 77);
      this.lblCompanySite.Name = "lblCompanySite";
      this.lblCompanySite.Size = new System.Drawing.Size(95, 17);
      this.lblCompanySite.TabIndex = 20;
      this.lblCompanySite.Text = "Website URL:";
      // 
      // lblCompanyTel
      // 
      this.lblCompanyTel.AutoSize = true;
      this.lblCompanyTel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
      this.lblCompanyTel.Location = new System.Drawing.Point(25, 74);
      this.lblCompanyTel.Name = "lblCompanyTel";
      this.lblCompanyTel.Size = new System.Drawing.Size(32, 17);
      this.lblCompanyTel.TabIndex = 19;
      this.lblCompanyTel.Text = "Tel:";
      // 
      // inputInvoiceRecipientCell
      // 
      this.inputInvoiceRecipientCell.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.inputInvoiceRecipientCell.Location = new System.Drawing.Point(148, 73);
      this.inputInvoiceRecipientCell.Name = "inputInvoiceRecipientCell";
      this.inputInvoiceRecipientCell.Size = new System.Drawing.Size(204, 23);
      this.inputInvoiceRecipientCell.TabIndex = 30;
      // 
      // inputInvoiceRecipientTel
      // 
      this.inputInvoiceRecipientTel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.inputInvoiceRecipientTel.Location = new System.Drawing.Point(515, 73);
      this.inputInvoiceRecipientTel.Name = "inputInvoiceRecipientTel";
      this.inputInvoiceRecipientTel.Size = new System.Drawing.Size(204, 23);
      this.inputInvoiceRecipientTel.TabIndex = 29;
      // 
      // lblInvoiceRecipientTel
      // 
      this.lblInvoiceRecipientTel.AutoSize = true;
      this.lblInvoiceRecipientTel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
      this.lblInvoiceRecipientTel.Location = new System.Drawing.Point(380, 76);
      this.lblInvoiceRecipientTel.Name = "lblInvoiceRecipientTel";
      this.lblInvoiceRecipientTel.Size = new System.Drawing.Size(32, 17);
      this.lblInvoiceRecipientTel.TabIndex = 28;
      this.lblInvoiceRecipientTel.Text = "Tel:";
      // 
      // lblInvoiceRecipientCell
      // 
      this.lblInvoiceRecipientCell.AutoSize = true;
      this.lblInvoiceRecipientCell.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
      this.lblInvoiceRecipientCell.Location = new System.Drawing.Point(25, 73);
      this.lblInvoiceRecipientCell.Name = "lblInvoiceRecipientCell";
      this.lblInvoiceRecipientCell.Size = new System.Drawing.Size(35, 17);
      this.lblInvoiceRecipientCell.TabIndex = 27;
      this.lblInvoiceRecipientCell.Text = "Cell:";
      // 
      // inputInvoiceRecipientName
      // 
      this.inputInvoiceRecipientName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.inputInvoiceRecipientName.Location = new System.Drawing.Point(383, 37);
      this.inputInvoiceRecipientName.Name = "inputInvoiceRecipientName";
      this.inputInvoiceRecipientName.Size = new System.Drawing.Size(336, 23);
      this.inputInvoiceRecipientName.TabIndex = 25;
      // 
      // lblInvoiceRecipientName
      // 
      this.lblInvoiceRecipientName.AutoSize = true;
      this.lblInvoiceRecipientName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
      this.lblInvoiceRecipientName.Location = new System.Drawing.Point(289, 40);
      this.lblInvoiceRecipientName.Name = "lblInvoiceRecipientName";
      this.lblInvoiceRecipientName.Size = new System.Drawing.Size(75, 17);
      this.lblInvoiceRecipientName.TabIndex = 24;
      this.lblInvoiceRecipientName.Text = "Full Name:";
      // 
      // lblInvoiceRecipientTitle
      // 
      this.lblInvoiceRecipientTitle.AutoSize = true;
      this.lblInvoiceRecipientTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
      this.lblInvoiceRecipientTitle.Location = new System.Drawing.Point(25, 37);
      this.lblInvoiceRecipientTitle.Name = "lblInvoiceRecipientTitle";
      this.lblInvoiceRecipientTitle.Size = new System.Drawing.Size(43, 17);
      this.lblInvoiceRecipientTitle.TabIndex = 23;
      this.lblInvoiceRecipientTitle.Text = "Title: ";
      // 
      // comboBoxInvoiceRecipientTitle
      // 
      this.comboBoxInvoiceRecipientTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
      this.comboBoxInvoiceRecipientTitle.FormattingEnabled = true;
      this.comboBoxInvoiceRecipientTitle.Items.AddRange(new object[] {
            "Mr. ",
            "Ms. ",
            "Miss.",
            "Mrs."});
      this.comboBoxInvoiceRecipientTitle.Location = new System.Drawing.Point(148, 37);
      this.comboBoxInvoiceRecipientTitle.Name = "comboBoxInvoiceRecipientTitle";
      this.comboBoxInvoiceRecipientTitle.Size = new System.Drawing.Size(105, 24);
      this.comboBoxInvoiceRecipientTitle.TabIndex = 31;
      // 
      // inputInvoiceRecipientEmail
      // 
      this.inputInvoiceRecipientEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.inputInvoiceRecipientEmail.Location = new System.Drawing.Point(148, 109);
      this.inputInvoiceRecipientEmail.Name = "inputInvoiceRecipientEmail";
      this.inputInvoiceRecipientEmail.Size = new System.Drawing.Size(571, 23);
      this.inputInvoiceRecipientEmail.TabIndex = 35;
      // 
      // lblInvoiceRecipientEmail
      // 
      this.lblInvoiceRecipientEmail.AutoSize = true;
      this.lblInvoiceRecipientEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
      this.lblInvoiceRecipientEmail.Location = new System.Drawing.Point(25, 109);
      this.lblInvoiceRecipientEmail.Name = "lblInvoiceRecipientEmail";
      this.lblInvoiceRecipientEmail.Size = new System.Drawing.Size(50, 17);
      this.lblInvoiceRecipientEmail.TabIndex = 32;
      this.lblInvoiceRecipientEmail.Text = "Email: ";
      // 
      // lblNewClientTop
      // 
      this.lblNewClientTop.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.lblNewClientTop.AutoSize = true;
      this.lblNewClientTop.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.lblNewClientTop.ForeColor = System.Drawing.Color.White;
      this.lblNewClientTop.Location = new System.Drawing.Point(337, 37);
      this.lblNewClientTop.Name = "lblNewClientTop";
      this.lblNewClientTop.Size = new System.Drawing.Size(118, 26);
      this.lblNewClientTop.TabIndex = 2;
      this.lblNewClientTop.Text = "New Client";
      // 
      // NewClient
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(790, 685);
      this.Controls.Add(this.groupBoxNewClientInvoiceRecipient);
      this.Controls.Add(this.groupBoxNewClientCompany);
      this.Controls.Add(this.btnCancelNewClient);
      this.Controls.Add(this.btnSubmitNewClient);
      this.Controls.Add(this.panelNewClientTop);
      this.MaximumSize = new System.Drawing.Size(806, 724);
      this.MinimumSize = new System.Drawing.Size(806, 724);
      this.Name = "NewClient";
      this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
      this.Text = "NewClient";
      this.Load += new System.EventHandler(this.NewClient_Load);
      this.panelNewClientTop.ResumeLayout(false);
      this.panelNewClientTop.PerformLayout();
      this.groupBoxNewClientCompany.ResumeLayout(false);
      this.groupBoxNewClientCompany.PerformLayout();
      this.groupBoxNewClientInvoiceRecipient.ResumeLayout(false);
      this.groupBoxNewClientInvoiceRecipient.PerformLayout();
      this.groupBoxCompanyAddress.ResumeLayout(false);
      this.groupBoxCompanyAddress.PerformLayout();
      this.ResumeLayout(false);

        }

    #endregion

    private System.Windows.Forms.Panel panelNewClientTop;
    private System.Windows.Forms.Button btnCancelNewClient;
    private System.Windows.Forms.Button btnSubmitNewClient;
    private System.Windows.Forms.Label lblCompanyName;
    private System.Windows.Forms.GroupBox groupBoxNewClientCompany;
    private System.Windows.Forms.GroupBox groupBoxCompanyAddress;
    private System.Windows.Forms.Label lblAddressPostCode;
    private System.Windows.Forms.TextBox inputAddressPostCode;
    private System.Windows.Forms.Label lblAddressCountry;
    private System.Windows.Forms.TextBox inputAddressCountry;
    private System.Windows.Forms.Label lblAddressState;
    private System.Windows.Forms.TextBox inputAddressState;
    private System.Windows.Forms.Label lblAddressTown;
    private System.Windows.Forms.TextBox inputAddressTown;
    private System.Windows.Forms.Label lblAddressStreet;
    private System.Windows.Forms.TextBox inputAddressStreet;
    private System.Windows.Forms.Label lblIndustry;
    private System.Windows.Forms.GroupBox groupBoxNewClientInvoiceRecipient;
    private System.Windows.Forms.TextBox inputCompanyTel;
    private System.Windows.Forms.TextBox inputCompanySite;
    private System.Windows.Forms.Label lblCompanySite;
    private System.Windows.Forms.Label lblCompanyTel;
    private System.Windows.Forms.TextBox inputCompanyName;
    private System.Windows.Forms.TextBox inputIndustry;
    private System.Windows.Forms.TextBox inputInvoiceRecipientEmail;
    private System.Windows.Forms.Label lblInvoiceRecipientEmail;
    private System.Windows.Forms.ComboBox comboBoxInvoiceRecipientTitle;
    private System.Windows.Forms.TextBox inputInvoiceRecipientCell;
    private System.Windows.Forms.TextBox inputInvoiceRecipientTel;
    private System.Windows.Forms.Label lblInvoiceRecipientTel;
    private System.Windows.Forms.Label lblInvoiceRecipientCell;
    private System.Windows.Forms.TextBox inputInvoiceRecipientName;
    private System.Windows.Forms.Label lblInvoiceRecipientName;
    private System.Windows.Forms.Label lblInvoiceRecipientTitle;
    private System.Windows.Forms.Label lblNewClientTop;
  }
}