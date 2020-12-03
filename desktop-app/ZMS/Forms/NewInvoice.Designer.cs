
namespace ZMS.Forms
{
    partial class NewInvoice
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
      this.comboBoxNewInvoiceClientSelect = new System.Windows.Forms.ComboBox();
      this.panelNewInvoiceTop = new System.Windows.Forms.Panel();
      this.btnCancelNewInvoice = new System.Windows.Forms.Button();
      this.btnSubmitNewInvoice = new System.Windows.Forms.Button();
      this.lblNewInvoiceClient = new System.Windows.Forms.Label();
      this.dataGridClientCompletedOrders = new System.Windows.Forms.DataGridView();
      this.lblNewInvoiceBankingDetails = new System.Windows.Forms.Label();
      this.comboBoxNewInvoiceBankingDetails = new System.Windows.Forms.ComboBox();
      this.lblNewInvoiceCurrency = new System.Windows.Forms.Label();
      this.comboBoxNewInvoiceCurrency = new System.Windows.Forms.ComboBox();
      this.lblSelectedCurrencySymbol = new System.Windows.Forms.Label();
      this.lblInvoiceCurrency = new System.Windows.Forms.Label();
      this.lblInvoiceTotal = new System.Windows.Forms.Label();
      this.lblRandSymbol = new System.Windows.Forms.Label();
      this.lblInvoiceTotalRand = new System.Windows.Forms.Label();
      this.lblNewInvoiceTitle = new System.Windows.Forms.Label();
      this.lblNewInvoiceOrderCount = new System.Windows.Forms.Label();
      this.lblOrderCountNumber = new System.Windows.Forms.Label();
      this.panelNewInvoiceTop.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.dataGridClientCompletedOrders)).BeginInit();
      this.SuspendLayout();
      // 
      // comboBoxNewInvoiceClientSelect
      // 
      this.comboBoxNewInvoiceClientSelect.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
      this.comboBoxNewInvoiceClientSelect.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
      this.comboBoxNewInvoiceClientSelect.FormattingEnabled = true;
      this.comboBoxNewInvoiceClientSelect.Items.AddRange(new object[] {
            "Fiverr",
            "Smart Brand Labratory",
            "Upwork",
            "Bark"});
      this.comboBoxNewInvoiceClientSelect.Location = new System.Drawing.Point(324, 106);
      this.comboBoxNewInvoiceClientSelect.Name = "comboBoxNewInvoiceClientSelect";
      this.comboBoxNewInvoiceClientSelect.Size = new System.Drawing.Size(356, 24);
      this.comboBoxNewInvoiceClientSelect.TabIndex = 5;
      // 
      // panelNewInvoiceTop
      // 
      this.panelNewInvoiceTop.Controls.Add(this.lblNewInvoiceTitle);
      this.panelNewInvoiceTop.Dock = System.Windows.Forms.DockStyle.Top;
      this.panelNewInvoiceTop.Location = new System.Drawing.Point(0, 0);
      this.panelNewInvoiceTop.Name = "panelNewInvoiceTop";
      this.panelNewInvoiceTop.Size = new System.Drawing.Size(692, 78);
      this.panelNewInvoiceTop.TabIndex = 6;
      // 
      // btnCancelNewInvoice
      // 
      this.btnCancelNewInvoice.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
      this.btnCancelNewInvoice.FlatAppearance.BorderSize = 0;
      this.btnCancelNewInvoice.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.btnCancelNewInvoice.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
      this.btnCancelNewInvoice.Location = new System.Drawing.Point(428, 663);
      this.btnCancelNewInvoice.Name = "btnCancelNewInvoice";
      this.btnCancelNewInvoice.Size = new System.Drawing.Size(122, 39);
      this.btnCancelNewInvoice.TabIndex = 8;
      this.btnCancelNewInvoice.Text = "Cancel";
      this.btnCancelNewInvoice.UseVisualStyleBackColor = true;
      this.btnCancelNewInvoice.Click += new System.EventHandler(this.btnCancelNewInvoice_Click);
      // 
      // btnSubmitNewInvoice
      // 
      this.btnSubmitNewInvoice.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
      this.btnSubmitNewInvoice.FlatAppearance.BorderSize = 0;
      this.btnSubmitNewInvoice.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.btnSubmitNewInvoice.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
      this.btnSubmitNewInvoice.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
      this.btnSubmitNewInvoice.Location = new System.Drawing.Point(556, 663);
      this.btnSubmitNewInvoice.Name = "btnSubmitNewInvoice";
      this.btnSubmitNewInvoice.Size = new System.Drawing.Size(122, 39);
      this.btnSubmitNewInvoice.TabIndex = 7;
      this.btnSubmitNewInvoice.Text = "Submit";
      this.btnSubmitNewInvoice.UseVisualStyleBackColor = true;
      // 
      // lblNewInvoiceClient
      // 
      this.lblNewInvoiceClient.AutoSize = true;
      this.lblNewInvoiceClient.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
      this.lblNewInvoiceClient.Location = new System.Drawing.Point(12, 109);
      this.lblNewInvoiceClient.Name = "lblNewInvoiceClient";
      this.lblNewInvoiceClient.Size = new System.Drawing.Size(90, 17);
      this.lblNewInvoiceClient.TabIndex = 9;
      this.lblNewInvoiceClient.Text = "Select Client:";
      // 
      // dataGridClientCompletedOrders
      // 
      this.dataGridClientCompletedOrders.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.dataGridClientCompletedOrders.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
      this.dataGridClientCompletedOrders.Location = new System.Drawing.Point(15, 158);
      this.dataGridClientCompletedOrders.Name = "dataGridClientCompletedOrders";
      this.dataGridClientCompletedOrders.Size = new System.Drawing.Size(665, 244);
      this.dataGridClientCompletedOrders.TabIndex = 10;
      // 
      // lblNewInvoiceBankingDetails
      // 
      this.lblNewInvoiceBankingDetails.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
      this.lblNewInvoiceBankingDetails.AutoSize = true;
      this.lblNewInvoiceBankingDetails.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
      this.lblNewInvoiceBankingDetails.Location = new System.Drawing.Point(12, 447);
      this.lblNewInvoiceBankingDetails.Name = "lblNewInvoiceBankingDetails";
      this.lblNewInvoiceBankingDetails.Size = new System.Drawing.Size(153, 17);
      this.lblNewInvoiceBankingDetails.TabIndex = 12;
      this.lblNewInvoiceBankingDetails.Text = "Select Banking Details:";
      // 
      // comboBoxNewInvoiceBankingDetails
      // 
      this.comboBoxNewInvoiceBankingDetails.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
      this.comboBoxNewInvoiceBankingDetails.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
      this.comboBoxNewInvoiceBankingDetails.FormattingEnabled = true;
      this.comboBoxNewInvoiceBankingDetails.Items.AddRange(new object[] {
            "Fern Writes (Pty) Ltd",
            "Ms. Fern Lahoud"});
      this.comboBoxNewInvoiceBankingDetails.Location = new System.Drawing.Point(324, 444);
      this.comboBoxNewInvoiceBankingDetails.Name = "comboBoxNewInvoiceBankingDetails";
      this.comboBoxNewInvoiceBankingDetails.Size = new System.Drawing.Size(356, 24);
      this.comboBoxNewInvoiceBankingDetails.TabIndex = 11;
      // 
      // lblNewInvoiceCurrency
      // 
      this.lblNewInvoiceCurrency.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
      this.lblNewInvoiceCurrency.AutoSize = true;
      this.lblNewInvoiceCurrency.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
      this.lblNewInvoiceCurrency.Location = new System.Drawing.Point(12, 493);
      this.lblNewInvoiceCurrency.Name = "lblNewInvoiceCurrency";
      this.lblNewInvoiceCurrency.Size = new System.Drawing.Size(156, 17);
      this.lblNewInvoiceCurrency.TabIndex = 13;
      this.lblNewInvoiceCurrency.Text = "Select Invoice Currency";
      // 
      // comboBoxNewInvoiceCurrency
      // 
      this.comboBoxNewInvoiceCurrency.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
      this.comboBoxNewInvoiceCurrency.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
      this.comboBoxNewInvoiceCurrency.FormattingEnabled = true;
      this.comboBoxNewInvoiceCurrency.Items.AddRange(new object[] {
            "R (South African Rand)",
            "$ (United States Dollar)",
            "£ (British Pound)",
            "€ (European Euro)"});
      this.comboBoxNewInvoiceCurrency.Location = new System.Drawing.Point(446, 490);
      this.comboBoxNewInvoiceCurrency.Name = "comboBoxNewInvoiceCurrency";
      this.comboBoxNewInvoiceCurrency.Size = new System.Drawing.Size(234, 24);
      this.comboBoxNewInvoiceCurrency.TabIndex = 14;
      // 
      // lblSelectedCurrencySymbol
      // 
      this.lblSelectedCurrencySymbol.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
      this.lblSelectedCurrencySymbol.AutoSize = true;
      this.lblSelectedCurrencySymbol.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
      this.lblSelectedCurrencySymbol.Location = new System.Drawing.Point(336, 564);
      this.lblSelectedCurrencySymbol.Name = "lblSelectedCurrencySymbol";
      this.lblSelectedCurrencySymbol.Size = new System.Drawing.Size(0, 17);
      this.lblSelectedCurrencySymbol.TabIndex = 15;
      // 
      // lblInvoiceCurrency
      // 
      this.lblInvoiceCurrency.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
      this.lblInvoiceCurrency.AutoSize = true;
      this.lblInvoiceCurrency.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
      this.lblInvoiceCurrency.Location = new System.Drawing.Point(463, 564);
      this.lblInvoiceCurrency.Name = "lblInvoiceCurrency";
      this.lblInvoiceCurrency.Size = new System.Drawing.Size(0, 17);
      this.lblInvoiceCurrency.TabIndex = 16;
      // 
      // lblInvoiceTotal
      // 
      this.lblInvoiceTotal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
      this.lblInvoiceTotal.AutoSize = true;
      this.lblInvoiceTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
      this.lblInvoiceTotal.Location = new System.Drawing.Point(12, 534);
      this.lblInvoiceTotal.Name = "lblInvoiceTotal";
      this.lblInvoiceTotal.Size = new System.Drawing.Size(88, 17);
      this.lblInvoiceTotal.TabIndex = 17;
      this.lblInvoiceTotal.Text = "Invoice Total";
      // 
      // lblRandSymbol
      // 
      this.lblRandSymbol.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
      this.lblRandSymbol.AutoSize = true;
      this.lblRandSymbol.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
      this.lblRandSymbol.Location = new System.Drawing.Point(336, 603);
      this.lblRandSymbol.Name = "lblRandSymbol";
      this.lblRandSymbol.Size = new System.Drawing.Size(18, 17);
      this.lblRandSymbol.TabIndex = 18;
      this.lblRandSymbol.Text = "R";
      this.lblRandSymbol.Click += new System.EventHandler(this.lblRandSymbol_Click);
      // 
      // lblInvoiceTotalRand
      // 
      this.lblInvoiceTotalRand.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
      this.lblInvoiceTotalRand.AutoSize = true;
      this.lblInvoiceTotalRand.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
      this.lblInvoiceTotalRand.Location = new System.Drawing.Point(463, 603);
      this.lblInvoiceTotalRand.Name = "lblInvoiceTotalRand";
      this.lblInvoiceTotalRand.Size = new System.Drawing.Size(0, 17);
      this.lblInvoiceTotalRand.TabIndex = 19;
      // 
      // lblNewInvoiceTitle
      // 
      this.lblNewInvoiceTitle.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.lblNewInvoiceTitle.AutoSize = true;
      this.lblNewInvoiceTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.lblNewInvoiceTitle.ForeColor = System.Drawing.Color.White;
      this.lblNewInvoiceTitle.Location = new System.Drawing.Point(288, 26);
      this.lblNewInvoiceTitle.Name = "lblNewInvoiceTitle";
      this.lblNewInvoiceTitle.Size = new System.Drawing.Size(131, 26);
      this.lblNewInvoiceTitle.TabIndex = 2;
      this.lblNewInvoiceTitle.Text = "New Invoice";
      // 
      // lblNewInvoiceOrderCount
      // 
      this.lblNewInvoiceOrderCount.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
      this.lblNewInvoiceOrderCount.AutoSize = true;
      this.lblNewInvoiceOrderCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
      this.lblNewInvoiceOrderCount.Location = new System.Drawing.Point(532, 405);
      this.lblNewInvoiceOrderCount.Name = "lblNewInvoiceOrderCount";
      this.lblNewInvoiceOrderCount.Size = new System.Drawing.Size(118, 15);
      this.lblNewInvoiceOrderCount.TabIndex = 20;
      this.lblNewInvoiceOrderCount.Text = "Orders Selected: ";
      // 
      // lblOrderCountNumber
      // 
      this.lblOrderCountNumber.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
      this.lblOrderCountNumber.AutoSize = true;
      this.lblOrderCountNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
      this.lblOrderCountNumber.Location = new System.Drawing.Point(663, 405);
      this.lblOrderCountNumber.Name = "lblOrderCountNumber";
      this.lblOrderCountNumber.Size = new System.Drawing.Size(15, 15);
      this.lblOrderCountNumber.TabIndex = 21;
      this.lblOrderCountNumber.Text = "0";
      // 
      // NewInvoice
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(692, 714);
      this.Controls.Add(this.lblOrderCountNumber);
      this.Controls.Add(this.lblNewInvoiceOrderCount);
      this.Controls.Add(this.lblInvoiceTotalRand);
      this.Controls.Add(this.lblRandSymbol);
      this.Controls.Add(this.lblInvoiceTotal);
      this.Controls.Add(this.lblInvoiceCurrency);
      this.Controls.Add(this.lblSelectedCurrencySymbol);
      this.Controls.Add(this.comboBoxNewInvoiceCurrency);
      this.Controls.Add(this.lblNewInvoiceCurrency);
      this.Controls.Add(this.lblNewInvoiceBankingDetails);
      this.Controls.Add(this.comboBoxNewInvoiceBankingDetails);
      this.Controls.Add(this.dataGridClientCompletedOrders);
      this.Controls.Add(this.lblNewInvoiceClient);
      this.Controls.Add(this.btnCancelNewInvoice);
      this.Controls.Add(this.btnSubmitNewInvoice);
      this.Controls.Add(this.panelNewInvoiceTop);
      this.Controls.Add(this.comboBoxNewInvoiceClientSelect);
      this.MaximumSize = new System.Drawing.Size(708, 753);
      this.Name = "NewInvoice";
      this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
      this.Text = "NewInvoice";
      this.Load += new System.EventHandler(this.NewInvoice_Load);
      this.panelNewInvoiceTop.ResumeLayout(false);
      this.panelNewInvoiceTop.PerformLayout();
      ((System.ComponentModel.ISupportInitialize)(this.dataGridClientCompletedOrders)).EndInit();
      this.ResumeLayout(false);
      this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBoxNewInvoiceClientSelect;
        private System.Windows.Forms.Panel panelNewInvoiceTop;
        private System.Windows.Forms.Button btnCancelNewInvoice;
        private System.Windows.Forms.Button btnSubmitNewInvoice;
        private System.Windows.Forms.Label lblNewInvoiceClient;
    private System.Windows.Forms.DataGridView dataGridClientCompletedOrders;
    private System.Windows.Forms.Label lblNewInvoiceBankingDetails;
    private System.Windows.Forms.ComboBox comboBoxNewInvoiceBankingDetails;
    private System.Windows.Forms.Label lblNewInvoiceCurrency;
    private System.Windows.Forms.ComboBox comboBoxNewInvoiceCurrency;
    private System.Windows.Forms.Label lblSelectedCurrencySymbol;
    private System.Windows.Forms.Label lblInvoiceCurrency;
    private System.Windows.Forms.Label lblInvoiceTotal;
    private System.Windows.Forms.Label lblRandSymbol;
    private System.Windows.Forms.Label lblInvoiceTotalRand;
    private System.Windows.Forms.Label lblNewInvoiceTitle;
    private System.Windows.Forms.Label lblNewInvoiceOrderCount;
    private System.Windows.Forms.Label lblOrderCountNumber;
  }
}