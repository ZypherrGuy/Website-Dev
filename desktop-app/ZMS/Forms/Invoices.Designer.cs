namespace ZMS.Forms
{
  partial class Invoices
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
      System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
      System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
      this.btnCreateInvoice = new System.Windows.Forms.Button();
      this.comboBoxInvoiceStatus = new System.Windows.Forms.ComboBox();
      this.btnOrderStatusPaidandClosed = new System.Windows.Forms.Button();
      this.btnReviseOrder = new System.Windows.Forms.Button();
      this.btnReissueInvoice = new System.Windows.Forms.Button();
      this.lblOrderState = new System.Windows.Forms.Label();
      this.dataGridInvoiceList = new System.Windows.Forms.DataGridView();
      this.inputSearch = new System.Windows.Forms.TextBox();
      this.lblInvoiceSearch = new System.Windows.Forms.Label();
      ((System.ComponentModel.ISupportInitialize)(this.dataGridInvoiceList)).BeginInit();
      this.SuspendLayout();
      // 
      // btnCreateInvoice
      // 
      this.btnCreateInvoice.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
      this.btnCreateInvoice.FlatAppearance.BorderSize = 0;
      this.btnCreateInvoice.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.btnCreateInvoice.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
      this.btnCreateInvoice.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
      this.btnCreateInvoice.Location = new System.Drawing.Point(13, 463);
      this.btnCreateInvoice.Name = "btnCreateInvoice";
      this.btnCreateInvoice.Size = new System.Drawing.Size(122, 39);
      this.btnCreateInvoice.TabIndex = 2;
      this.btnCreateInvoice.Text = "New Invoice";
      this.btnCreateInvoice.UseVisualStyleBackColor = true;
      this.btnCreateInvoice.Click += new System.EventHandler(this.btnCreateInvoice_Click);
      // 
      // comboBoxInvoiceStatus
      // 
      this.comboBoxInvoiceStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
      this.comboBoxInvoiceStatus.FormattingEnabled = true;
      this.comboBoxInvoiceStatus.Items.AddRange(new object[] {
            "Pending payment (Orders)",
            "Pending payment (Invoices)",
            "Closed: Payment recieved (Orders)",
            "Closed: Payment recieved (Invoices)"});
      this.comboBoxInvoiceStatus.Location = new System.Drawing.Point(115, 17);
      this.comboBoxInvoiceStatus.Name = "comboBoxInvoiceStatus";
      this.comboBoxInvoiceStatus.Size = new System.Drawing.Size(343, 24);
      this.comboBoxInvoiceStatus.TabIndex = 4;
      this.comboBoxInvoiceStatus.SelectedIndexChanged += new System.EventHandler(this.comboBoxInvoiceStatus_SelectedIndexChanged);
      // 
      // btnOrderStatusPaidandClosed
      // 
      this.btnOrderStatusPaidandClosed.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
      this.btnOrderStatusPaidandClosed.FlatAppearance.BorderSize = 0;
      this.btnOrderStatusPaidandClosed.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.btnOrderStatusPaidandClosed.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
      this.btnOrderStatusPaidandClosed.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
      this.btnOrderStatusPaidandClosed.Location = new System.Drawing.Point(879, 463);
      this.btnOrderStatusPaidandClosed.Name = "btnOrderStatusPaidandClosed";
      this.btnOrderStatusPaidandClosed.Size = new System.Drawing.Size(122, 39);
      this.btnOrderStatusPaidandClosed.TabIndex = 5;
      this.btnOrderStatusPaidandClosed.Text = "Close Order";
      this.btnOrderStatusPaidandClosed.UseVisualStyleBackColor = true;
      // 
      // btnReviseOrder
      // 
      this.btnReviseOrder.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
      this.btnReviseOrder.FlatAppearance.BorderSize = 0;
      this.btnReviseOrder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.btnReviseOrder.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
      this.btnReviseOrder.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
      this.btnReviseOrder.Location = new System.Drawing.Point(623, 463);
      this.btnReviseOrder.Name = "btnReviseOrder";
      this.btnReviseOrder.Size = new System.Drawing.Size(122, 39);
      this.btnReviseOrder.TabIndex = 6;
      this.btnReviseOrder.Text = "Revise Order";
      this.btnReviseOrder.UseVisualStyleBackColor = true;
      // 
      // btnReissueInvoice
      // 
      this.btnReissueInvoice.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
      this.btnReissueInvoice.FlatAppearance.BorderSize = 0;
      this.btnReissueInvoice.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.btnReissueInvoice.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
      this.btnReissueInvoice.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
      this.btnReissueInvoice.Location = new System.Drawing.Point(751, 463);
      this.btnReissueInvoice.Name = "btnReissueInvoice";
      this.btnReissueInvoice.Size = new System.Drawing.Size(122, 39);
      this.btnReissueInvoice.TabIndex = 7;
      this.btnReissueInvoice.Text = "Reissue Invoice";
      this.btnReissueInvoice.UseVisualStyleBackColor = true;
      // 
      // lblOrderState
      // 
      this.lblOrderState.AutoSize = true;
      this.lblOrderState.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
      this.lblOrderState.Location = new System.Drawing.Point(12, 20);
      this.lblOrderState.Name = "lblOrderState";
      this.lblOrderState.Size = new System.Drawing.Size(97, 17);
      this.lblOrderState.TabIndex = 8;
      this.lblOrderState.Text = "Invoice State: ";
      // 
      // dataGridInvoiceList
      // 
      this.dataGridInvoiceList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.dataGridInvoiceList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
      this.dataGridInvoiceList.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
      this.dataGridInvoiceList.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleVertical;
      dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
      dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
      dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
      dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
      dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.HighlightText;
      dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
      dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
      this.dataGridInvoiceList.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
      this.dataGridInvoiceList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
      this.dataGridInvoiceList.Cursor = System.Windows.Forms.Cursors.Arrow;
      dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
      dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
      dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
      dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
      dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
      dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
      dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
      this.dataGridInvoiceList.DefaultCellStyle = dataGridViewCellStyle4;
      this.dataGridInvoiceList.Location = new System.Drawing.Point(12, 56);
      this.dataGridInvoiceList.Name = "dataGridInvoiceList";
      this.dataGridInvoiceList.RowTemplate.ReadOnly = true;
      this.dataGridInvoiceList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
      this.dataGridInvoiceList.Size = new System.Drawing.Size(989, 398);
      this.dataGridInvoiceList.TabIndex = 9;
      // 
      // inputSearch
      // 
      this.inputSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
      this.inputSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.inputSearch.Location = new System.Drawing.Point(712, 17);
      this.inputSearch.Name = "inputSearch";
      this.inputSearch.Size = new System.Drawing.Size(289, 23);
      this.inputSearch.TabIndex = 15;
      this.inputSearch.TextChanged += new System.EventHandler(this.inputSearch_TextChanged);
      // 
      // lblInvoiceSearch
      // 
      this.lblInvoiceSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
      this.lblInvoiceSearch.AutoSize = true;
      this.lblInvoiceSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
      this.lblInvoiceSearch.Location = new System.Drawing.Point(645, 20);
      this.lblInvoiceSearch.Name = "lblInvoiceSearch";
      this.lblInvoiceSearch.Size = new System.Drawing.Size(61, 17);
      this.lblInvoiceSearch.TabIndex = 16;
      this.lblInvoiceSearch.Text = "Search: ";
      this.lblInvoiceSearch.TextChanged += new System.EventHandler(this.inputSearch_TextChanged);
      // 
      // Invoices
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(1013, 514);
      this.Controls.Add(this.lblInvoiceSearch);
      this.Controls.Add(this.inputSearch);
      this.Controls.Add(this.dataGridInvoiceList);
      this.Controls.Add(this.lblOrderState);
      this.Controls.Add(this.btnReissueInvoice);
      this.Controls.Add(this.btnReviseOrder);
      this.Controls.Add(this.btnOrderStatusPaidandClosed);
      this.Controls.Add(this.comboBoxInvoiceStatus);
      this.Controls.Add(this.btnCreateInvoice);
      this.Name = "Invoices";
      this.Text = "Invoices";
      this.Load += new System.EventHandler(this.Invoices_Load);
      ((System.ComponentModel.ISupportInitialize)(this.dataGridInvoiceList)).EndInit();
      this.ResumeLayout(false);
      this.PerformLayout();

    }

        #endregion

        private System.Windows.Forms.Button btnCreateInvoice;
        private System.Windows.Forms.ComboBox comboBoxInvoiceStatus;
        private System.Windows.Forms.Button btnOrderStatusPaidandClosed;
    private System.Windows.Forms.Button btnReviseOrder;
    private System.Windows.Forms.Button btnReissueInvoice;
    private System.Windows.Forms.Label lblOrderState;
    public System.Windows.Forms.DataGridView dataGridInvoiceList;
    private System.Windows.Forms.TextBox inputSearch;
    private System.Windows.Forms.Label lblInvoiceSearch;
  }
}