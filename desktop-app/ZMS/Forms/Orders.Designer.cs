namespace ZMS.Forms
{
  partial class Orders
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
      this.btnCompleteOrder = new System.Windows.Forms.Button();
      this.btnOrderHistory = new System.Windows.Forms.Button();
      this.btnNewOrder = new System.Windows.Forms.Button();
      this.btnOpenEditor = new System.Windows.Forms.Button();
      this.panelDataContainer = new System.Windows.Forms.Panel();
      this.dataGridView1 = new System.Windows.Forms.DataGridView();
      this.dataGridViewOrderList = new System.Windows.Forms.DataGridView();
      this.btnEditOrder = new System.Windows.Forms.Button();
      this.btnRefreshOrderTable = new System.Windows.Forms.Button();
      this.panelDataContainer.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOrderList)).BeginInit();
      this.SuspendLayout();
      // 
      // btnCompleteOrder
      // 
      this.btnCompleteOrder.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
      this.btnCompleteOrder.FlatAppearance.BorderSize = 0;
      this.btnCompleteOrder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.btnCompleteOrder.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
      this.btnCompleteOrder.Location = new System.Drawing.Point(666, 383);
      this.btnCompleteOrder.Name = "btnCompleteOrder";
      this.btnCompleteOrder.Size = new System.Drawing.Size(122, 39);
      this.btnCompleteOrder.TabIndex = 1;
      this.btnCompleteOrder.Text = "Complete Order";
      this.btnCompleteOrder.UseVisualStyleBackColor = true;
      // 
      // btnOrderHistory
      // 
      this.btnOrderHistory.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
      this.btnOrderHistory.FlatAppearance.BorderSize = 0;
      this.btnOrderHistory.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.btnOrderHistory.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
      this.btnOrderHistory.Location = new System.Drawing.Point(144, 383);
      this.btnOrderHistory.Name = "btnOrderHistory";
      this.btnOrderHistory.Size = new System.Drawing.Size(122, 39);
      this.btnOrderHistory.TabIndex = 2;
      this.btnOrderHistory.Text = "Order History";
      this.btnOrderHistory.UseVisualStyleBackColor = true;
      this.btnOrderHistory.Click += new System.EventHandler(this.btnOrderHistory_Click);
      // 
      // btnNewOrder
      // 
      this.btnNewOrder.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
      this.btnNewOrder.FlatAppearance.BorderSize = 0;
      this.btnNewOrder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.btnNewOrder.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
      this.btnNewOrder.Location = new System.Drawing.Point(16, 383);
      this.btnNewOrder.Name = "btnNewOrder";
      this.btnNewOrder.Size = new System.Drawing.Size(122, 39);
      this.btnNewOrder.TabIndex = 3;
      this.btnNewOrder.Text = "New Order";
      this.btnNewOrder.UseVisualStyleBackColor = true;
      this.btnNewOrder.Click += new System.EventHandler(this.btnNewOrder_Click);
      // 
      // btnOpenEditor
      // 
      this.btnOpenEditor.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
      this.btnOpenEditor.FlatAppearance.BorderSize = 0;
      this.btnOpenEditor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.btnOpenEditor.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
      this.btnOpenEditor.Location = new System.Drawing.Point(538, 383);
      this.btnOpenEditor.Name = "btnOpenEditor";
      this.btnOpenEditor.Size = new System.Drawing.Size(122, 39);
      this.btnOpenEditor.TabIndex = 4;
      this.btnOpenEditor.Text = "Open Editor";
      this.btnOpenEditor.UseVisualStyleBackColor = true;
      this.btnOpenEditor.Click += new System.EventHandler(this.btnOpenEditor_Click);
      // 
      // panelDataContainer
      // 
      this.panelDataContainer.Anchor = System.Windows.Forms.AnchorStyles.None;
      this.panelDataContainer.AutoSize = true;
      this.panelDataContainer.Controls.Add(this.dataGridView1);
      this.panelDataContainer.Location = new System.Drawing.Point(13, 16);
      this.panelDataContainer.Name = "panelDataContainer";
      this.panelDataContainer.Size = new System.Drawing.Size(0, 349);
      this.panelDataContainer.TabIndex = 5;
      // 
      // dataGridView1
      // 
      this.dataGridView1.Anchor = System.Windows.Forms.AnchorStyles.None;
      this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
      this.dataGridView1.Location = new System.Drawing.Point(3, -9);
      this.dataGridView1.Name = "dataGridView1";
      this.dataGridView1.Size = new System.Drawing.Size(772, 355);
      this.dataGridView1.TabIndex = 0;
      // 
      // dataGridViewOrderList
      // 
      this.dataGridViewOrderList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.dataGridViewOrderList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
      this.dataGridViewOrderList.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
      this.dataGridViewOrderList.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleVertical;
      dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
      dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
      dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
      dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
      dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.HighlightText;
      dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
      dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
      this.dataGridViewOrderList.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
      this.dataGridViewOrderList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
      this.dataGridViewOrderList.Cursor = System.Windows.Forms.Cursors.Arrow;
      dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
      dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
      dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
      dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
      dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
      dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
      dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
      this.dataGridViewOrderList.DefaultCellStyle = dataGridViewCellStyle2;
      this.dataGridViewOrderList.Location = new System.Drawing.Point(12, 12);
      this.dataGridViewOrderList.Name = "dataGridViewOrderList";
      this.dataGridViewOrderList.RowTemplate.ReadOnly = true;
      this.dataGridViewOrderList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
      this.dataGridViewOrderList.Size = new System.Drawing.Size(776, 353);
      this.dataGridViewOrderList.TabIndex = 6;
      // 
      // btnEditOrder
      // 
      this.btnEditOrder.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
      this.btnEditOrder.FlatAppearance.BorderSize = 0;
      this.btnEditOrder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.btnEditOrder.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
      this.btnEditOrder.Location = new System.Drawing.Point(410, 383);
      this.btnEditOrder.Name = "btnEditOrder";
      this.btnEditOrder.Size = new System.Drawing.Size(122, 39);
      this.btnEditOrder.TabIndex = 7;
      this.btnEditOrder.Text = "Edit Order";
      this.btnEditOrder.UseVisualStyleBackColor = true;
      // 
      // btnRefreshOrderTable
      // 
      this.btnRefreshOrderTable.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
      this.btnRefreshOrderTable.FlatAppearance.BorderSize = 0;
      this.btnRefreshOrderTable.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.btnRefreshOrderTable.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
      this.btnRefreshOrderTable.Location = new System.Drawing.Point(272, 383);
      this.btnRefreshOrderTable.Name = "btnRefreshOrderTable";
      this.btnRefreshOrderTable.Size = new System.Drawing.Size(122, 39);
      this.btnRefreshOrderTable.TabIndex = 8;
      this.btnRefreshOrderTable.Text = "Refresh";
      this.btnRefreshOrderTable.UseVisualStyleBackColor = true;
      this.btnRefreshOrderTable.Click += new System.EventHandler(this.btnRefreshOrderTable_Click);
      // 
      // Orders
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(800, 436);
      this.Controls.Add(this.btnRefreshOrderTable);
      this.Controls.Add(this.btnEditOrder);
      this.Controls.Add(this.dataGridViewOrderList);
      this.Controls.Add(this.panelDataContainer);
      this.Controls.Add(this.btnCompleteOrder);
      this.Controls.Add(this.btnOpenEditor);
      this.Controls.Add(this.btnNewOrder);
      this.Controls.Add(this.btnOrderHistory);
      this.Name = "Orders";
      this.Text = "Orders";
      this.Load += new System.EventHandler(this.Orders_Load);
      this.panelDataContainer.ResumeLayout(false);
      ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOrderList)).EndInit();
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion
    private System.Windows.Forms.Button btnCompleteOrder;
    private System.Windows.Forms.Button btnOrderHistory;
    private System.Windows.Forms.Button btnNewOrder;
    private System.Windows.Forms.Button btnOpenEditor;
    private System.Windows.Forms.Panel panelDataContainer;
    private System.Windows.Forms.DataGridView dataGridView1;
    public System.Windows.Forms.DataGridView dataGridViewOrderList;
    private System.Windows.Forms.Button btnEditOrder;
    private System.Windows.Forms.Button btnRefreshOrderTable;
  }
}