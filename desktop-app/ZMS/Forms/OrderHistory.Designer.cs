namespace ZMS.Forms
{
  partial class OrderHistory
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
      System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
      System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
      this.dateTimeOrderHistoryFrom = new System.Windows.Forms.DateTimePicker();
      this.dateTimePickerdateTimeOrderHistoryTo = new System.Windows.Forms.DateTimePicker();
      this.lblOrderHistoryFrom = new System.Windows.Forms.Label();
      this.lblOrderHistoryTo = new System.Windows.Forms.Label();
      this.comboBoxSortBy = new System.Windows.Forms.ComboBox();
      this.lblSortBy = new System.Windows.Forms.Label();
      this.btnSaveReport = new System.Windows.Forms.Button();
      this.btnHistoryCancel = new System.Windows.Forms.Button();
      this.dataGridHistoryOrderList = new System.Windows.Forms.DataGridView();
      ((System.ComponentModel.ISupportInitialize)(this.dataGridHistoryOrderList)).BeginInit();
      this.SuspendLayout();
      // 
      // dateTimeOrderHistoryFrom
      // 
      this.dateTimeOrderHistoryFrom.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
      this.dateTimeOrderHistoryFrom.Location = new System.Drawing.Point(62, 21);
      this.dateTimeOrderHistoryFrom.Name = "dateTimeOrderHistoryFrom";
      this.dateTimeOrderHistoryFrom.Size = new System.Drawing.Size(220, 23);
      this.dateTimeOrderHistoryFrom.TabIndex = 0;
      // 
      // dateTimePickerdateTimeOrderHistoryTo
      // 
      this.dateTimePickerdateTimeOrderHistoryTo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
      this.dateTimePickerdateTimeOrderHistoryTo.Location = new System.Drawing.Point(331, 21);
      this.dateTimePickerdateTimeOrderHistoryTo.Name = "dateTimePickerdateTimeOrderHistoryTo";
      this.dateTimePickerdateTimeOrderHistoryTo.Size = new System.Drawing.Size(219, 23);
      this.dateTimePickerdateTimeOrderHistoryTo.TabIndex = 1;
      // 
      // lblOrderHistoryFrom
      // 
      this.lblOrderHistoryFrom.AutoSize = true;
      this.lblOrderHistoryFrom.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
      this.lblOrderHistoryFrom.Location = new System.Drawing.Point(12, 24);
      this.lblOrderHistoryFrom.Name = "lblOrderHistoryFrom";
      this.lblOrderHistoryFrom.Size = new System.Drawing.Size(44, 17);
      this.lblOrderHistoryFrom.TabIndex = 2;
      this.lblOrderHistoryFrom.Text = "From:";
      // 
      // lblOrderHistoryTo
      // 
      this.lblOrderHistoryTo.AutoSize = true;
      this.lblOrderHistoryTo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
      this.lblOrderHistoryTo.Location = new System.Drawing.Point(295, 24);
      this.lblOrderHistoryTo.Name = "lblOrderHistoryTo";
      this.lblOrderHistoryTo.Size = new System.Drawing.Size(29, 17);
      this.lblOrderHistoryTo.TabIndex = 3;
      this.lblOrderHistoryTo.Text = "To:";
      // 
      // comboBoxSortBy
      // 
      this.comboBoxSortBy.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
      this.comboBoxSortBy.FormattingEnabled = true;
      this.comboBoxSortBy.Items.AddRange(new object[] {
            "Date",
            "Title"});
      this.comboBoxSortBy.Location = new System.Drawing.Point(1191, 22);
      this.comboBoxSortBy.Name = "comboBoxSortBy";
      this.comboBoxSortBy.Size = new System.Drawing.Size(121, 24);
      this.comboBoxSortBy.TabIndex = 4;
      this.comboBoxSortBy.SelectedIndexChanged += new System.EventHandler(this.comboBoxSortBy_SelectedIndexChanged);
      // 
      // lblSortBy
      // 
      this.lblSortBy.AutoSize = true;
      this.lblSortBy.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
      this.lblSortBy.Location = new System.Drawing.Point(1125, 26);
      this.lblSortBy.Name = "lblSortBy";
      this.lblSortBy.Size = new System.Drawing.Size(58, 17);
      this.lblSortBy.TabIndex = 5;
      this.lblSortBy.Text = "Sort By:";
      // 
      // btnSaveReport
      // 
      this.btnSaveReport.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
      this.btnSaveReport.FlatAppearance.BorderSize = 0;
      this.btnSaveReport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.btnSaveReport.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
      this.btnSaveReport.Location = new System.Drawing.Point(1189, 639);
      this.btnSaveReport.Name = "btnSaveReport";
      this.btnSaveReport.Size = new System.Drawing.Size(122, 39);
      this.btnSaveReport.TabIndex = 8;
      this.btnSaveReport.Text = "Export to Excel";
      this.btnSaveReport.UseVisualStyleBackColor = true;
      this.btnSaveReport.Click += new System.EventHandler(this.btnSaveReport_Click);
      // 
      // btnHistoryCancel
      // 
      this.btnHistoryCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
      this.btnHistoryCancel.FlatAppearance.BorderSize = 0;
      this.btnHistoryCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.btnHistoryCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
      this.btnHistoryCancel.Location = new System.Drawing.Point(1061, 639);
      this.btnHistoryCancel.Name = "btnHistoryCancel";
      this.btnHistoryCancel.Size = new System.Drawing.Size(122, 39);
      this.btnHistoryCancel.TabIndex = 7;
      this.btnHistoryCancel.Text = "Cancel";
      this.btnHistoryCancel.UseVisualStyleBackColor = true;
      this.btnHistoryCancel.Click += new System.EventHandler(this.btnHistoryCancel_Click);
      // 
      // dataGridHistoryOrderList
      // 
      this.dataGridHistoryOrderList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.dataGridHistoryOrderList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
      this.dataGridHistoryOrderList.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
      this.dataGridHistoryOrderList.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleVertical;
      dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
      dataGridViewCellStyle9.BackColor = System.Drawing.SystemColors.Control;
      dataGridViewCellStyle9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
      dataGridViewCellStyle9.ForeColor = System.Drawing.SystemColors.WindowText;
      dataGridViewCellStyle9.SelectionBackColor = System.Drawing.SystemColors.HighlightText;
      dataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
      dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
      this.dataGridHistoryOrderList.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle9;
      this.dataGridHistoryOrderList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
      this.dataGridHistoryOrderList.Cursor = System.Windows.Forms.Cursors.Arrow;
      dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
      dataGridViewCellStyle10.BackColor = System.Drawing.SystemColors.Window;
      dataGridViewCellStyle10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
      dataGridViewCellStyle10.ForeColor = System.Drawing.SystemColors.ControlText;
      dataGridViewCellStyle10.SelectionBackColor = System.Drawing.SystemColors.Highlight;
      dataGridViewCellStyle10.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
      dataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
      this.dataGridHistoryOrderList.DefaultCellStyle = dataGridViewCellStyle10;
      this.dataGridHistoryOrderList.Location = new System.Drawing.Point(15, 61);
      this.dataGridHistoryOrderList.Name = "dataGridHistoryOrderList";
      this.dataGridHistoryOrderList.RowTemplate.ReadOnly = true;
      this.dataGridHistoryOrderList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
      this.dataGridHistoryOrderList.Size = new System.Drawing.Size(1296, 572);
      this.dataGridHistoryOrderList.TabIndex = 9;
      // 
      // OrderHistory
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(1323, 687);
      this.Controls.Add(this.dataGridHistoryOrderList);
      this.Controls.Add(this.btnSaveReport);
      this.Controls.Add(this.btnHistoryCancel);
      this.Controls.Add(this.lblSortBy);
      this.Controls.Add(this.comboBoxSortBy);
      this.Controls.Add(this.lblOrderHistoryTo);
      this.Controls.Add(this.lblOrderHistoryFrom);
      this.Controls.Add(this.dateTimePickerdateTimeOrderHistoryTo);
      this.Controls.Add(this.dateTimeOrderHistoryFrom);
      this.Name = "OrderHistory";
      this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
      this.Text = "OrderHistory";
      this.Load += new System.EventHandler(this.OrderHistory_Load);
      ((System.ComponentModel.ISupportInitialize)(this.dataGridHistoryOrderList)).EndInit();
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.DateTimePicker dateTimeOrderHistoryFrom;
    private System.Windows.Forms.DateTimePicker dateTimePickerdateTimeOrderHistoryTo;
    private System.Windows.Forms.Label lblOrderHistoryFrom;
    private System.Windows.Forms.Label lblOrderHistoryTo;
    private System.Windows.Forms.ComboBox comboBoxSortBy;
    private System.Windows.Forms.Label lblSortBy;
    private System.Windows.Forms.Button btnSaveReport;
    private System.Windows.Forms.Button btnHistoryCancel;
    public System.Windows.Forms.DataGridView dataGridHistoryOrderList;
  }
}