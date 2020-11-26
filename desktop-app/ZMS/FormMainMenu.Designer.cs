namespace ZMS
{
  partial class FormMainMenu
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
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMainMenu));
      this.panelMenu = new System.Windows.Forms.Panel();
      this.btnSettings = new System.Windows.Forms.Button();
      this.btnClients = new System.Windows.Forms.Button();
      this.btnInvoices = new System.Windows.Forms.Button();
      this.btnOrders = new System.Windows.Forms.Button();
      this.btnDashboard = new System.Windows.Forms.Button();
      this.panelLogo = new System.Windows.Forms.Panel();
      this.panelTitlebar = new System.Windows.Forms.Panel();
      this.lblTitle = new System.Windows.Forms.Label();
      this.pictureBox1 = new System.Windows.Forms.PictureBox();
      this.panelDesktopPanel = new System.Windows.Forms.Panel();
      this.btnCloseChildForm = new System.Windows.Forms.Button();
      this.pictureBox2 = new System.Windows.Forms.PictureBox();
      this.panelMenu.SuspendLayout();
      this.panelLogo.SuspendLayout();
      this.panelTitlebar.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
      this.panelDesktopPanel.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
      this.SuspendLayout();
      // 
      // panelMenu
      // 
      this.panelMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
      this.panelMenu.Controls.Add(this.btnSettings);
      this.panelMenu.Controls.Add(this.btnClients);
      this.panelMenu.Controls.Add(this.btnInvoices);
      this.panelMenu.Controls.Add(this.btnOrders);
      this.panelMenu.Controls.Add(this.btnDashboard);
      this.panelMenu.Controls.Add(this.panelLogo);
      this.panelMenu.Dock = System.Windows.Forms.DockStyle.Left;
      this.panelMenu.Location = new System.Drawing.Point(0, 0);
      this.panelMenu.Name = "panelMenu";
      this.panelMenu.Size = new System.Drawing.Size(220, 542);
      this.panelMenu.TabIndex = 0;
      // 
      // btnSettings
      // 
      this.btnSettings.Dock = System.Windows.Forms.DockStyle.Top;
      this.btnSettings.FlatAppearance.BorderSize = 0;
      this.btnSettings.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.btnSettings.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
      this.btnSettings.ForeColor = System.Drawing.SystemColors.ButtonFace;
      this.btnSettings.Image = ((System.Drawing.Image)(resources.GetObject("btnSettings.Image")));
      this.btnSettings.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
      this.btnSettings.Location = new System.Drawing.Point(0, 320);
      this.btnSettings.Name = "btnSettings";
      this.btnSettings.Padding = new System.Windows.Forms.Padding(16, 0, 0, 0);
      this.btnSettings.Size = new System.Drawing.Size(220, 60);
      this.btnSettings.TabIndex = 5;
      this.btnSettings.Text = "     Settings";
      this.btnSettings.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
      this.btnSettings.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
      this.btnSettings.UseVisualStyleBackColor = true;
      this.btnSettings.Click += new System.EventHandler(this.btnSettings_Click);
      // 
      // btnClients
      // 
      this.btnClients.Dock = System.Windows.Forms.DockStyle.Top;
      this.btnClients.FlatAppearance.BorderSize = 0;
      this.btnClients.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.btnClients.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
      this.btnClients.ForeColor = System.Drawing.SystemColors.ButtonFace;
      this.btnClients.Image = ((System.Drawing.Image)(resources.GetObject("btnClients.Image")));
      this.btnClients.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
      this.btnClients.Location = new System.Drawing.Point(0, 260);
      this.btnClients.Name = "btnClients";
      this.btnClients.Padding = new System.Windows.Forms.Padding(16, 0, 0, 0);
      this.btnClients.Size = new System.Drawing.Size(220, 60);
      this.btnClients.TabIndex = 4;
      this.btnClients.Text = "     Clients";
      this.btnClients.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
      this.btnClients.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
      this.btnClients.UseVisualStyleBackColor = true;
      this.btnClients.Click += new System.EventHandler(this.btnClients_Click);
      // 
      // btnInvoices
      // 
      this.btnInvoices.Dock = System.Windows.Forms.DockStyle.Top;
      this.btnInvoices.FlatAppearance.BorderSize = 0;
      this.btnInvoices.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.btnInvoices.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
      this.btnInvoices.ForeColor = System.Drawing.SystemColors.ButtonFace;
      this.btnInvoices.Image = ((System.Drawing.Image)(resources.GetObject("btnInvoices.Image")));
      this.btnInvoices.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
      this.btnInvoices.Location = new System.Drawing.Point(0, 200);
      this.btnInvoices.Name = "btnInvoices";
      this.btnInvoices.Padding = new System.Windows.Forms.Padding(16, 0, 0, 0);
      this.btnInvoices.Size = new System.Drawing.Size(220, 60);
      this.btnInvoices.TabIndex = 3;
      this.btnInvoices.Text = "     Invoices";
      this.btnInvoices.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
      this.btnInvoices.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
      this.btnInvoices.UseVisualStyleBackColor = true;
      this.btnInvoices.Click += new System.EventHandler(this.btnInvoices_Click);
      // 
      // btnOrders
      // 
      this.btnOrders.Dock = System.Windows.Forms.DockStyle.Top;
      this.btnOrders.FlatAppearance.BorderSize = 0;
      this.btnOrders.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.btnOrders.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
      this.btnOrders.ForeColor = System.Drawing.SystemColors.ButtonFace;
      this.btnOrders.Image = ((System.Drawing.Image)(resources.GetObject("btnOrders.Image")));
      this.btnOrders.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
      this.btnOrders.Location = new System.Drawing.Point(0, 140);
      this.btnOrders.Name = "btnOrders";
      this.btnOrders.Padding = new System.Windows.Forms.Padding(16, 0, 0, 0);
      this.btnOrders.Size = new System.Drawing.Size(220, 60);
      this.btnOrders.TabIndex = 2;
      this.btnOrders.Text = "      Orders";
      this.btnOrders.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
      this.btnOrders.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
      this.btnOrders.UseVisualStyleBackColor = true;
      this.btnOrders.Click += new System.EventHandler(this.btnOrders_Click);
      // 
      // btnDashboard
      // 
      this.btnDashboard.Dock = System.Windows.Forms.DockStyle.Top;
      this.btnDashboard.FlatAppearance.BorderSize = 0;
      this.btnDashboard.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.btnDashboard.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
      this.btnDashboard.ForeColor = System.Drawing.SystemColors.ButtonFace;
      this.btnDashboard.Image = ((System.Drawing.Image)(resources.GetObject("btnDashboard.Image")));
      this.btnDashboard.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
      this.btnDashboard.Location = new System.Drawing.Point(0, 80);
      this.btnDashboard.Name = "btnDashboard";
      this.btnDashboard.Padding = new System.Windows.Forms.Padding(16, 0, 0, 0);
      this.btnDashboard.Size = new System.Drawing.Size(220, 60);
      this.btnDashboard.TabIndex = 1;
      this.btnDashboard.Text = "     Dashboard";
      this.btnDashboard.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
      this.btnDashboard.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
      this.btnDashboard.UseVisualStyleBackColor = true;
      this.btnDashboard.Click += new System.EventHandler(this.btnDashboard_Click);
      // 
      // panelLogo
      // 
      this.panelLogo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(58)))));
      this.panelLogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
      this.panelLogo.Controls.Add(this.pictureBox1);
      this.panelLogo.Dock = System.Windows.Forms.DockStyle.Top;
      this.panelLogo.Location = new System.Drawing.Point(0, 0);
      this.panelLogo.Name = "panelLogo";
      this.panelLogo.Size = new System.Drawing.Size(220, 80);
      this.panelLogo.TabIndex = 0;
      // 
      // panelTitlebar
      // 
      this.panelTitlebar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(120)))));
      this.panelTitlebar.Controls.Add(this.btnCloseChildForm);
      this.panelTitlebar.Controls.Add(this.lblTitle);
      this.panelTitlebar.Dock = System.Windows.Forms.DockStyle.Top;
      this.panelTitlebar.Location = new System.Drawing.Point(220, 0);
      this.panelTitlebar.Name = "panelTitlebar";
      this.panelTitlebar.Size = new System.Drawing.Size(698, 80);
      this.panelTitlebar.TabIndex = 1;
      // 
      // lblTitle
      // 
      this.lblTitle.Anchor = System.Windows.Forms.AnchorStyles.None;
      this.lblTitle.AutoSize = true;
      this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.lblTitle.ForeColor = System.Drawing.Color.White;
      this.lblTitle.Location = new System.Drawing.Point(310, 26);
      this.lblTitle.Name = "lblTitle";
      this.lblTitle.Size = new System.Drawing.Size(78, 26);
      this.lblTitle.TabIndex = 0;
      this.lblTitle.Text = "HOME";
      // 
      // pictureBox1
      // 
      this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
      this.pictureBox1.Location = new System.Drawing.Point(3, 8);
      this.pictureBox1.Name = "pictureBox1";
      this.pictureBox1.Size = new System.Drawing.Size(210, 70);
      this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
      this.pictureBox1.TabIndex = 0;
      this.pictureBox1.TabStop = false;
      // 
      // panelDesktopPanel
      // 
      this.panelDesktopPanel.Controls.Add(this.pictureBox2);
      this.panelDesktopPanel.Dock = System.Windows.Forms.DockStyle.Fill;
      this.panelDesktopPanel.Location = new System.Drawing.Point(220, 80);
      this.panelDesktopPanel.Name = "panelDesktopPanel";
      this.panelDesktopPanel.Size = new System.Drawing.Size(698, 462);
      this.panelDesktopPanel.TabIndex = 2;
      // 
      // btnCloseChildForm
      // 
      this.btnCloseChildForm.Dock = System.Windows.Forms.DockStyle.Left;
      this.btnCloseChildForm.FlatAppearance.BorderSize = 0;
      this.btnCloseChildForm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.btnCloseChildForm.Image = ((System.Drawing.Image)(resources.GetObject("btnCloseChildForm.Image")));
      this.btnCloseChildForm.Location = new System.Drawing.Point(0, 0);
      this.btnCloseChildForm.Name = "btnCloseChildForm";
      this.btnCloseChildForm.Size = new System.Drawing.Size(75, 80);
      this.btnCloseChildForm.TabIndex = 1;
      this.btnCloseChildForm.UseVisualStyleBackColor = true;
      this.btnCloseChildForm.Click += new System.EventHandler(this.btnCloseChildForm_Click);
      // 
      // pictureBox2
      // 
      this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
      this.pictureBox2.Location = new System.Drawing.Point(253, 180);
      this.pictureBox2.Name = "pictureBox2";
      this.pictureBox2.Size = new System.Drawing.Size(381, 204);
      this.pictureBox2.TabIndex = 0;
      this.pictureBox2.TabStop = false;
      // 
      // FormMainMenu
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(918, 542);
      this.Controls.Add(this.panelDesktopPanel);
      this.Controls.Add(this.panelTitlebar);
      this.Controls.Add(this.panelMenu);
      this.Name = "FormMainMenu";
      this.Text = "FormMainMenu";
      this.panelMenu.ResumeLayout(false);
      this.panelLogo.ResumeLayout(false);
      this.panelLogo.PerformLayout();
      this.panelTitlebar.ResumeLayout(false);
      this.panelTitlebar.PerformLayout();
      ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
      this.panelDesktopPanel.ResumeLayout(false);
      ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
      this.ResumeLayout(false);

    }

    #endregion

    private System.Windows.Forms.Panel panelMenu;
    private System.Windows.Forms.Button btnDashboard;
    private System.Windows.Forms.Panel panelLogo;
    private System.Windows.Forms.Button btnOrders;
    private System.Windows.Forms.Button btnSettings;
    private System.Windows.Forms.Button btnClients;
    private System.Windows.Forms.Button btnInvoices;
    private System.Windows.Forms.Panel panelTitlebar;
    private System.Windows.Forms.Label lblTitle;
    private System.Windows.Forms.PictureBox pictureBox1;
    private System.Windows.Forms.Panel panelDesktopPanel;
    private System.Windows.Forms.Button btnCloseChildForm;
    private System.Windows.Forms.PictureBox pictureBox2;
  }
}

