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
      this.comboBoxClientSort = new System.Windows.Forms.ComboBox();
      this.dataGridClients = new System.Windows.Forms.DataGridView();
      this.btnNewClient = new System.Windows.Forms.Button();
      this.btnEditClient = new System.Windows.Forms.Button();
      this.btnArchiveClient = new System.Windows.Forms.Button();
      this.lblClientSort = new System.Windows.Forms.Label();
      ((System.ComponentModel.ISupportInitialize)(this.dataGridClients)).BeginInit();
      this.SuspendLayout();
      // 
      // comboBoxClientSort
      // 
      this.comboBoxClientSort.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
      this.comboBoxClientSort.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
      this.comboBoxClientSort.FormattingEnabled = true;
      this.comboBoxClientSort.Items.AddRange(new object[] {
            "Name",
            "Client",
            "Region"});
      this.comboBoxClientSort.Location = new System.Drawing.Point(530, 12);
      this.comboBoxClientSort.Name = "comboBoxClientSort";
      this.comboBoxClientSort.Size = new System.Drawing.Size(183, 24);
      this.comboBoxClientSort.TabIndex = 0;
      // 
      // dataGridClients
      // 
      this.dataGridClients.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.dataGridClients.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
      this.dataGridClients.Location = new System.Drawing.Point(12, 42);
      this.dataGridClients.Name = "dataGridClients";
      this.dataGridClients.Size = new System.Drawing.Size(701, 419);
      this.dataGridClients.TabIndex = 1;
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
      // lblClientSort
      // 
      this.lblClientSort.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
      this.lblClientSort.AutoSize = true;
      this.lblClientSort.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
      this.lblClientSort.Location = new System.Drawing.Point(463, 15);
      this.lblClientSort.Name = "lblClientSort";
      this.lblClientSort.Size = new System.Drawing.Size(58, 17);
      this.lblClientSort.TabIndex = 6;
      this.lblClientSort.Text = "Sort By:";
      // 
      // Clients
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(725, 521);
      this.Controls.Add(this.lblClientSort);
      this.Controls.Add(this.btnArchiveClient);
      this.Controls.Add(this.btnEditClient);
      this.Controls.Add(this.btnNewClient);
      this.Controls.Add(this.dataGridClients);
      this.Controls.Add(this.comboBoxClientSort);
      this.Name = "Clients";
      this.Text = "Clients";
      this.Load += new System.EventHandler(this.Clients_Load);
      ((System.ComponentModel.ISupportInitialize)(this.dataGridClients)).EndInit();
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.ComboBox comboBoxClientSort;
    private System.Windows.Forms.DataGridView dataGridClients;
    private System.Windows.Forms.Button btnNewClient;
    private System.Windows.Forms.Button btnEditClient;
    private System.Windows.Forms.Button btnArchiveClient;
    private System.Windows.Forms.Label lblClientSort;
  }
}