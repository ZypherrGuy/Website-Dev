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
      this.btnCreateInvoice = new System.Windows.Forms.Button();
      this.dataGridView1 = new System.Windows.Forms.DataGridView();
      this.comboBoxInvoiceStatus = new System.Windows.Forms.ComboBox();
      this.btnOrderStatusPaidandClosed = new System.Windows.Forms.Button();
      this.btnReviseOrder = new System.Windows.Forms.Button();
      this.btnReissueInvoice = new System.Windows.Forms.Button();
      this.lblOrderState = new System.Windows.Forms.Label();
      ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
      this.SuspendLayout();
      // 
      // btnCreateInvoice
      // 
      this.btnCreateInvoice.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
      this.btnCreateInvoice.FlatAppearance.BorderSize = 0;
      this.btnCreateInvoice.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.btnCreateInvoice.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
      this.btnCreateInvoice.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
      this.btnCreateInvoice.Location = new System.Drawing.Point(13, 399);
      this.btnCreateInvoice.Name = "btnCreateInvoice";
      this.btnCreateInvoice.Size = new System.Drawing.Size(122, 39);
      this.btnCreateInvoice.TabIndex = 2;
      this.btnCreateInvoice.Text = "New Invoice";
      this.btnCreateInvoice.UseVisualStyleBackColor = true;
      this.btnCreateInvoice.Click += new System.EventHandler(this.btnCreateInvoice_Click);
      // 
      // dataGridView1
      // 
      this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
      this.dataGridView1.Location = new System.Drawing.Point(13, 43);
      this.dataGridView1.Name = "dataGridView1";
      this.dataGridView1.Size = new System.Drawing.Size(775, 343);
      this.dataGridView1.TabIndex = 3;
      // 
      // comboBoxInvoiceStatus
      // 
      this.comboBoxInvoiceStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
      this.comboBoxInvoiceStatus.FormattingEnabled = true;
      this.comboBoxInvoiceStatus.Items.AddRange(new object[] {
            "Orders pending invoice",
            "Orders pending payment",
            "Closed orders"});
      this.comboBoxInvoiceStatus.Location = new System.Drawing.Point(108, 12);
      this.comboBoxInvoiceStatus.Name = "comboBoxInvoiceStatus";
      this.comboBoxInvoiceStatus.Size = new System.Drawing.Size(343, 24);
      this.comboBoxInvoiceStatus.TabIndex = 4;
      // 
      // btnOrderStatusPaidandClosed
      // 
      this.btnOrderStatusPaidandClosed.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
      this.btnOrderStatusPaidandClosed.FlatAppearance.BorderSize = 0;
      this.btnOrderStatusPaidandClosed.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.btnOrderStatusPaidandClosed.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
      this.btnOrderStatusPaidandClosed.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
      this.btnOrderStatusPaidandClosed.Location = new System.Drawing.Point(666, 399);
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
      this.btnReviseOrder.Location = new System.Drawing.Point(410, 399);
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
      this.btnReissueInvoice.Location = new System.Drawing.Point(538, 399);
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
      this.lblOrderState.Location = new System.Drawing.Point(12, 15);
      this.lblOrderState.Name = "lblOrderState";
      this.lblOrderState.Size = new System.Drawing.Size(90, 17);
      this.lblOrderState.TabIndex = 8;
      this.lblOrderState.Text = "Order State: ";
      // 
      // Invoices
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(800, 450);
      this.Controls.Add(this.lblOrderState);
      this.Controls.Add(this.btnReissueInvoice);
      this.Controls.Add(this.btnReviseOrder);
      this.Controls.Add(this.btnOrderStatusPaidandClosed);
      this.Controls.Add(this.comboBoxInvoiceStatus);
      this.Controls.Add(this.dataGridView1);
      this.Controls.Add(this.btnCreateInvoice);
      this.Name = "Invoices";
      this.Text = "Invoices";
      this.Load += new System.EventHandler(this.Invoices_Load);
      ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
      this.ResumeLayout(false);
      this.PerformLayout();

    }

        #endregion

        private System.Windows.Forms.Button btnCreateInvoice;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ComboBox comboBoxInvoiceStatus;
        private System.Windows.Forms.Button btnOrderStatusPaidandClosed;
    private System.Windows.Forms.Button btnReviseOrder;
    private System.Windows.Forms.Button btnReissueInvoice;
    private System.Windows.Forms.Label lblOrderState;
  }
}