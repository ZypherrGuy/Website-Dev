
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
      System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
      System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
      this.comboBoxNewInvoiceClientSelect = new System.Windows.Forms.ComboBox();
      this.panelNewInvoiceTop = new System.Windows.Forms.Panel();
      this.lblNewInvoiceTitle = new System.Windows.Forms.Label();
      this.btnCancelNewInvoice = new System.Windows.Forms.Button();
      this.btnSubmitNewInvoice = new System.Windows.Forms.Button();
      this.lblNewInvoiceClient = new System.Windows.Forms.Label();
      this.lblNewInvoiceBankingDetails = new System.Windows.Forms.Label();
      this.comboBoxNewInvoiceBankingDetails = new System.Windows.Forms.ComboBox();
      this.lblNewInvoiceCurrency = new System.Windows.Forms.Label();
      this.comboBoxNewInvoiceCurrency = new System.Windows.Forms.ComboBox();
      this.lblSelectedCurrencySymbol = new System.Windows.Forms.Label();
      this.lblInvoiceCurrency = new System.Windows.Forms.Label();
      this.lblInvoiceTotal = new System.Windows.Forms.Label();
      this.lblRandSymbol = new System.Windows.Forms.Label();
      this.lblInvoiceTotalRand = new System.Windows.Forms.Label();
      this.lblNewInvoiceOrderCount = new System.Windows.Forms.Label();
      this.lblOrderCountNumber = new System.Windows.Forms.Label();
      this.lblCurrencySymbol = new System.Windows.Forms.Label();
      this.lblCurrencyTotal = new System.Windows.Forms.Label();
      this.dataGridCompletedOrderList = new System.Windows.Forms.DataGridView();
      this.lblRandConversion = new System.Windows.Forms.Label();
      this.lblPaymentOption = new System.Windows.Forms.Label();
      this.comboBoxPaymentOption = new System.Windows.Forms.ComboBox();
      this.panelNewInvoiceTop.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.dataGridCompletedOrderList)).BeginInit();
      this.SuspendLayout();
      // 
      // comboBoxNewInvoiceClientSelect
      // 
      this.comboBoxNewInvoiceClientSelect.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
      this.comboBoxNewInvoiceClientSelect.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
      this.comboBoxNewInvoiceClientSelect.FormattingEnabled = true;
      this.comboBoxNewInvoiceClientSelect.Location = new System.Drawing.Point(579, 106);
      this.comboBoxNewInvoiceClientSelect.Name = "comboBoxNewInvoiceClientSelect";
      this.comboBoxNewInvoiceClientSelect.Size = new System.Drawing.Size(356, 24);
      this.comboBoxNewInvoiceClientSelect.TabIndex = 5;
      this.comboBoxNewInvoiceClientSelect.SelectedIndexChanged += new System.EventHandler(this.comboBoxNewInvoiceClientSelect_SelectedIndexChanged);
      // 
      // panelNewInvoiceTop
      // 
      this.panelNewInvoiceTop.Controls.Add(this.lblNewInvoiceTitle);
      this.panelNewInvoiceTop.Dock = System.Windows.Forms.DockStyle.Top;
      this.panelNewInvoiceTop.Location = new System.Drawing.Point(0, 0);
      this.panelNewInvoiceTop.Name = "panelNewInvoiceTop";
      this.panelNewInvoiceTop.Size = new System.Drawing.Size(947, 78);
      this.panelNewInvoiceTop.TabIndex = 6;
      // 
      // lblNewInvoiceTitle
      // 
      this.lblNewInvoiceTitle.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.lblNewInvoiceTitle.AutoSize = true;
      this.lblNewInvoiceTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.lblNewInvoiceTitle.ForeColor = System.Drawing.Color.White;
      this.lblNewInvoiceTitle.Location = new System.Drawing.Point(408, 26);
      this.lblNewInvoiceTitle.Name = "lblNewInvoiceTitle";
      this.lblNewInvoiceTitle.Size = new System.Drawing.Size(131, 26);
      this.lblNewInvoiceTitle.TabIndex = 2;
      this.lblNewInvoiceTitle.Text = "New Invoice";
      // 
      // btnCancelNewInvoice
      // 
      this.btnCancelNewInvoice.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
      this.btnCancelNewInvoice.FlatAppearance.BorderSize = 0;
      this.btnCancelNewInvoice.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.btnCancelNewInvoice.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
      this.btnCancelNewInvoice.Location = new System.Drawing.Point(683, 663);
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
      this.btnSubmitNewInvoice.Location = new System.Drawing.Point(811, 663);
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
      // lblNewInvoiceBankingDetails
      // 
      this.lblNewInvoiceBankingDetails.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
      this.lblNewInvoiceBankingDetails.AutoSize = true;
      this.lblNewInvoiceBankingDetails.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
      this.lblNewInvoiceBankingDetails.Location = new System.Drawing.Point(12, 441);
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
      this.comboBoxNewInvoiceBankingDetails.Location = new System.Drawing.Point(579, 438);
      this.comboBoxNewInvoiceBankingDetails.Name = "comboBoxNewInvoiceBankingDetails";
      this.comboBoxNewInvoiceBankingDetails.Size = new System.Drawing.Size(356, 24);
      this.comboBoxNewInvoiceBankingDetails.TabIndex = 11;
      // 
      // lblNewInvoiceCurrency
      // 
      this.lblNewInvoiceCurrency.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
      this.lblNewInvoiceCurrency.AutoSize = true;
      this.lblNewInvoiceCurrency.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
      this.lblNewInvoiceCurrency.Location = new System.Drawing.Point(12, 509);
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
      this.comboBoxNewInvoiceCurrency.Location = new System.Drawing.Point(701, 506);
      this.comboBoxNewInvoiceCurrency.Name = "comboBoxNewInvoiceCurrency";
      this.comboBoxNewInvoiceCurrency.Size = new System.Drawing.Size(234, 24);
      this.comboBoxNewInvoiceCurrency.TabIndex = 14;
      this.comboBoxNewInvoiceCurrency.SelectedIndexChanged += new System.EventHandler(this.comboBoxNewInvoiceCurrency_SelectedIndexChanged);
      // 
      // lblSelectedCurrencySymbol
      // 
      this.lblSelectedCurrencySymbol.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
      this.lblSelectedCurrencySymbol.AutoSize = true;
      this.lblSelectedCurrencySymbol.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
      this.lblSelectedCurrencySymbol.Location = new System.Drawing.Point(697, 573);
      this.lblSelectedCurrencySymbol.Name = "lblSelectedCurrencySymbol";
      this.lblSelectedCurrencySymbol.Size = new System.Drawing.Size(0, 20);
      this.lblSelectedCurrencySymbol.TabIndex = 15;
      // 
      // lblInvoiceCurrency
      // 
      this.lblInvoiceCurrency.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
      this.lblInvoiceCurrency.AutoSize = true;
      this.lblInvoiceCurrency.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
      this.lblInvoiceCurrency.Location = new System.Drawing.Point(718, 573);
      this.lblInvoiceCurrency.Name = "lblInvoiceCurrency";
      this.lblInvoiceCurrency.Size = new System.Drawing.Size(0, 17);
      this.lblInvoiceCurrency.TabIndex = 16;
      // 
      // lblInvoiceTotal
      // 
      this.lblInvoiceTotal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
      this.lblInvoiceTotal.AutoSize = true;
      this.lblInvoiceTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
      this.lblInvoiceTotal.Location = new System.Drawing.Point(12, 543);
      this.lblInvoiceTotal.Name = "lblInvoiceTotal";
      this.lblInvoiceTotal.Size = new System.Drawing.Size(88, 17);
      this.lblInvoiceTotal.TabIndex = 17;
      this.lblInvoiceTotal.Text = "Invoice Total";
      // 
      // lblRandSymbol
      // 
      this.lblRandSymbol.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
      this.lblRandSymbol.AutoSize = true;
      this.lblRandSymbol.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
      this.lblRandSymbol.Location = new System.Drawing.Point(697, 612);
      this.lblRandSymbol.Name = "lblRandSymbol";
      this.lblRandSymbol.Size = new System.Drawing.Size(21, 20);
      this.lblRandSymbol.TabIndex = 18;
      this.lblRandSymbol.Text = "R";
      // 
      // lblInvoiceTotalRand
      // 
      this.lblInvoiceTotalRand.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
      this.lblInvoiceTotalRand.AutoSize = true;
      this.lblInvoiceTotalRand.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
      this.lblInvoiceTotalRand.Location = new System.Drawing.Point(718, 612);
      this.lblInvoiceTotalRand.Name = "lblInvoiceTotalRand";
      this.lblInvoiceTotalRand.Size = new System.Drawing.Size(0, 17);
      this.lblInvoiceTotalRand.TabIndex = 19;
      // 
      // lblNewInvoiceOrderCount
      // 
      this.lblNewInvoiceOrderCount.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
      this.lblNewInvoiceOrderCount.AutoSize = true;
      this.lblNewInvoiceOrderCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
      this.lblNewInvoiceOrderCount.Location = new System.Drawing.Point(787, 405);
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
      this.lblOrderCountNumber.Location = new System.Drawing.Point(918, 405);
      this.lblOrderCountNumber.Name = "lblOrderCountNumber";
      this.lblOrderCountNumber.Size = new System.Drawing.Size(15, 15);
      this.lblOrderCountNumber.TabIndex = 21;
      this.lblOrderCountNumber.Text = "0";
      // 
      // lblCurrencySymbol
      // 
      this.lblCurrencySymbol.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
      this.lblCurrencySymbol.AutoSize = true;
      this.lblCurrencySymbol.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
      this.lblCurrencySymbol.Location = new System.Drawing.Point(697, 573);
      this.lblCurrencySymbol.Name = "lblCurrencySymbol";
      this.lblCurrencySymbol.Size = new System.Drawing.Size(0, 20);
      this.lblCurrencySymbol.TabIndex = 22;
      // 
      // lblCurrencyTotal
      // 
      this.lblCurrencyTotal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
      this.lblCurrencyTotal.AutoSize = true;
      this.lblCurrencyTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
      this.lblCurrencyTotal.Location = new System.Drawing.Point(807, 573);
      this.lblCurrencyTotal.Name = "lblCurrencyTotal";
      this.lblCurrencyTotal.Size = new System.Drawing.Size(0, 20);
      this.lblCurrencyTotal.TabIndex = 25;
      // 
      // dataGridCompletedOrderList
      // 
      this.dataGridCompletedOrderList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.dataGridCompletedOrderList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
      this.dataGridCompletedOrderList.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
      this.dataGridCompletedOrderList.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleVertical;
      dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
      dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
      dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
      dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
      dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.HighlightText;
      dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
      dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
      this.dataGridCompletedOrderList.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
      this.dataGridCompletedOrderList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
      this.dataGridCompletedOrderList.Cursor = System.Windows.Forms.Cursors.Arrow;
      dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
      dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
      dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
      dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
      dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
      dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
      dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
      this.dataGridCompletedOrderList.DefaultCellStyle = dataGridViewCellStyle2;
      this.dataGridCompletedOrderList.Location = new System.Drawing.Point(15, 141);
      this.dataGridCompletedOrderList.Name = "dataGridCompletedOrderList";
      this.dataGridCompletedOrderList.RowTemplate.ReadOnly = true;
      this.dataGridCompletedOrderList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
      this.dataGridCompletedOrderList.Size = new System.Drawing.Size(920, 261);
      this.dataGridCompletedOrderList.TabIndex = 26;
      this.dataGridCompletedOrderList.SelectionChanged += new System.EventHandler(this.dataGridCompletedOrderList_SelectionChanged);
      // 
      // lblRandConversion
      // 
      this.lblRandConversion.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
      this.lblRandConversion.AutoSize = true;
      this.lblRandConversion.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
      this.lblRandConversion.Location = new System.Drawing.Point(807, 609);
      this.lblRandConversion.Name = "lblRandConversion";
      this.lblRandConversion.Size = new System.Drawing.Size(0, 20);
      this.lblRandConversion.TabIndex = 24;
      // 
      // lblPaymentOption
      // 
      this.lblPaymentOption.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
      this.lblPaymentOption.AutoSize = true;
      this.lblPaymentOption.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
      this.lblPaymentOption.Location = new System.Drawing.Point(12, 474);
      this.lblPaymentOption.Name = "lblPaymentOption";
      this.lblPaymentOption.Size = new System.Drawing.Size(152, 17);
      this.lblPaymentOption.TabIndex = 28;
      this.lblPaymentOption.Text = "Select payment option:";
      // 
      // comboBoxPaymentOption
      // 
      this.comboBoxPaymentOption.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
      this.comboBoxPaymentOption.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
      this.comboBoxPaymentOption.FormattingEnabled = true;
      this.comboBoxPaymentOption.Items.AddRange(new object[] {
            "Bank Transfer",
            "Paypal"});
      this.comboBoxPaymentOption.Location = new System.Drawing.Point(701, 471);
      this.comboBoxPaymentOption.Name = "comboBoxPaymentOption";
      this.comboBoxPaymentOption.Size = new System.Drawing.Size(234, 24);
      this.comboBoxPaymentOption.TabIndex = 27;
      // 
      // NewInvoice
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(947, 714);
      this.Controls.Add(this.lblPaymentOption);
      this.Controls.Add(this.comboBoxPaymentOption);
      this.Controls.Add(this.dataGridCompletedOrderList);
      this.Controls.Add(this.lblCurrencyTotal);
      this.Controls.Add(this.lblRandConversion);
      this.Controls.Add(this.lblCurrencySymbol);
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
      this.Controls.Add(this.lblNewInvoiceClient);
      this.Controls.Add(this.btnCancelNewInvoice);
      this.Controls.Add(this.btnSubmitNewInvoice);
      this.Controls.Add(this.panelNewInvoiceTop);
      this.Controls.Add(this.comboBoxNewInvoiceClientSelect);
      this.MaximumSize = new System.Drawing.Size(963, 753);
      this.MinimumSize = new System.Drawing.Size(963, 753);
      this.Name = "NewInvoice";
      this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
      this.Text = "NewInvoice";
      this.Load += new System.EventHandler(this.NewInvoice_Load);
      this.panelNewInvoiceTop.ResumeLayout(false);
      this.panelNewInvoiceTop.PerformLayout();
      ((System.ComponentModel.ISupportInitialize)(this.dataGridCompletedOrderList)).EndInit();
      this.ResumeLayout(false);
      this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBoxNewInvoiceClientSelect;
        private System.Windows.Forms.Panel panelNewInvoiceTop;
        private System.Windows.Forms.Button btnCancelNewInvoice;
        private System.Windows.Forms.Button btnSubmitNewInvoice;
        private System.Windows.Forms.Label lblNewInvoiceClient;
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
    private System.Windows.Forms.Label lblCurrencySymbol;
    private System.Windows.Forms.Label lblRandConversion;
    private System.Windows.Forms.Label lblCurrencyTotal;
    public System.Windows.Forms.DataGridView dataGridCompletedOrderList;
    private System.Windows.Forms.Label lblPaymentOption;
    private System.Windows.Forms.ComboBox comboBoxPaymentOption;
  }
}