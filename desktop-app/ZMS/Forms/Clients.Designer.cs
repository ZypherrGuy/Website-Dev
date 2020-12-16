namespace ZMS.Forms
{
  partial class Clients
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
      this.btnNewClient = new System.Windows.Forms.Button();
      this.btnEditClient = new System.Windows.Forms.Button();
      this.btnArchiveClient = new System.Windows.Forms.Button();
      this.dataGridClients = new System.Windows.Forms.DataGridView();
      this.lblInvoiceSearch = new System.Windows.Forms.Label();
      this.inputSearch = new System.Windows.Forms.TextBox();
      ((System.ComponentModel.ISupportInitialize)(this.dataGridClients)).BeginInit();
      this.SuspendLayout();
      // 
      // btnNewClient
      // 
      this.btnNewClient.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
      this.btnNewClient.FlatAppearance.BorderSize = 0;
      this.btnNewClient.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.btnNewClient.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
      this.btnNewClient.Location = new System.Drawing.Point(12, 470);
      this.btnNewClient.Name = "btnNewClient";
      this.btnNewClient.Size = new System.Drawing.Size(122, 39);
      this.btnNewClient.TabIndex = 3;
      this.btnNewClient.Text = "New Client";
      this.btnNewClient.UseVisualStyleBackColor = true;
      this.btnNewClient.Click += new System.EventHandler(this.btnNewClient_Click);
      // 
      // btnEditClient
      // 
      this.btnEditClient.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
      this.btnEditClient.FlatAppearance.BorderSize = 0;
      this.btnEditClient.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.btnEditClient.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
      this.btnEditClient.Location = new System.Drawing.Point(140, 470);
      this.btnEditClient.Name = "btnEditClient";
      this.btnEditClient.Size = new System.Drawing.Size(122, 39);
      this.btnEditClient.TabIndex = 4;
      this.btnEditClient.Text = "Edit Client";
      this.btnEditClient.UseVisualStyleBackColor = true;
      // 
      // btnArchiveClient
      // 
      this.btnArchiveClient.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
      this.btnArchiveClient.FlatAppearance.BorderSize = 0;
      this.btnArchiveClient.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.btnArchiveClient.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
      this.btnArchiveClient.Location = new System.Drawing.Point(591, 470);
      this.btnArchiveClient.Name = "btnArchiveClient";
      this.btnArchiveClient.Size = new System.Drawing.Size(122, 39);
      this.btnArchiveClient.TabIndex = 5;
      this.btnArchiveClient.Text = "Archive Client";
      this.btnArchiveClient.UseVisualStyleBackColor = true;
      // 
      // dataGridClients
      // 
      this.dataGridClients.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.dataGridClients.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
      this.dataGridClients.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
      this.dataGridClients.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleVertical;
      dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
      dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
      dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
      dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
      dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.HighlightText;
      dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
      dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
      this.dataGridClients.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
      this.dataGridClients.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
      this.dataGridClients.Cursor = System.Windows.Forms.Cursors.Arrow;
      dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
      dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
      dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
      dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
      dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
      dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
      dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
      this.dataGridClients.DefaultCellStyle = dataGridViewCellStyle4;
      this.dataGridClients.Location = new System.Drawing.Point(12, 54);
      this.dataGridClients.Name = "dataGridClients";
      this.dataGridClients.RowTemplate.ReadOnly = true;
      this.dataGridClients.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
      this.dataGridClients.Size = new System.Drawing.Size(701, 407);
      this.dataGridClients.TabIndex = 10;
      // 
      // lblInvoiceSearch
      // 
      this.lblInvoiceSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
      this.lblInvoiceSearch.AutoSize = true;
      this.lblInvoiceSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
      this.lblInvoiceSearch.Location = new System.Drawing.Point(357, 18);
      this.lblInvoiceSearch.Name = "lblInvoiceSearch";
      this.lblInvoiceSearch.Size = new System.Drawing.Size(61, 17);
      this.lblInvoiceSearch.TabIndex = 18;
      this.lblInvoiceSearch.Text = "Search: ";
      // 
      // inputSearch
      // 
      this.inputSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
      this.inputSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.inputSearch.Location = new System.Drawing.Point(424, 15);
      this.inputSearch.Name = "inputSearch";
      this.inputSearch.Size = new System.Drawing.Size(289, 23);
      this.inputSearch.TabIndex = 17;
      this.inputSearch.TextChanged += new System.EventHandler(this.inputSearch_TextChanged);
      // 
      // Clients
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(725, 521);
      this.Controls.Add(this.lblInvoiceSearch);
      this.Controls.Add(this.inputSearch);
      this.Controls.Add(this.dataGridClients);
      this.Controls.Add(this.btnArchiveClient);
      this.Controls.Add(this.btnEditClient);
      this.Controls.Add(this.btnNewClient);
      this.Name = "Clients";
      this.Text = "Clients";
      this.Load += new System.EventHandler(this.Clients_Load);
      ((System.ComponentModel.ISupportInitialize)(this.dataGridClients)).EndInit();
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion
    private System.Windows.Forms.Button btnNewClient;
    private System.Windows.Forms.Button btnEditClient;
    private System.Windows.Forms.Button btnArchiveClient;
    public System.Windows.Forms.DataGridView dataGridClients;
    private System.Windows.Forms.Label lblInvoiceSearch;
    private System.Windows.Forms.TextBox inputSearch;
  }
}