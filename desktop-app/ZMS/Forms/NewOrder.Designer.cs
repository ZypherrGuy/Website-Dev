namespace ZMS.Forms
{
  partial class NewOrder
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
      this.panelNewOrderTop = new System.Windows.Forms.Panel();
      this.lblTitle = new System.Windows.Forms.Label();
      this.btnSubmitCreateOrder = new System.Windows.Forms.Button();
      this.btnCancelCreateOrder = new System.Windows.Forms.Button();
      this.lblOrderTitle = new System.Windows.Forms.Label();
      this.lblOrderType = new System.Windows.Forms.Label();
      this.lblClient = new System.Windows.Forms.Label();
      this.lblOrderCost = new System.Windows.Forms.Label();
      this.lblOrderDeadline = new System.Windows.Forms.Label();
      this.dateTimeSubDate = new System.Windows.Forms.DateTimePicker();
      this.lblWordCount = new System.Windows.Forms.Label();
      this.lblScheduleOrder = new System.Windows.Forms.Label();
      this.inputOrderTitle = new System.Windows.Forms.TextBox();
      this.inputOrderCost = new System.Windows.Forms.TextBox();
      this.inputClient = new System.Windows.Forms.TextBox();
      this.inputWordCount = new System.Windows.Forms.TextBox();
      this.inputEditorURL = new System.Windows.Forms.TextBox();
      this.label1 = new System.Windows.Forms.Label();
      this.dateTimeSchedDate = new System.Windows.Forms.DateTimePicker();
      this.comboBoxOrderType = new System.Windows.Forms.ComboBox();
      this.panelNewOrderTop.SuspendLayout();
      this.SuspendLayout();
      // 
      // panelNewOrderTop
      // 
      this.panelNewOrderTop.Controls.Add(this.lblTitle);
      this.panelNewOrderTop.Dock = System.Windows.Forms.DockStyle.Top;
      this.panelNewOrderTop.Location = new System.Drawing.Point(0, 0);
      this.panelNewOrderTop.Name = "panelNewOrderTop";
      this.panelNewOrderTop.Size = new System.Drawing.Size(467, 73);
      this.panelNewOrderTop.TabIndex = 0;
      // 
      // lblTitle
      // 
      this.lblTitle.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.lblTitle.AutoSize = true;
      this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.lblTitle.ForeColor = System.Drawing.Color.White;
      this.lblTitle.Location = new System.Drawing.Point(178, 26);
      this.lblTitle.Name = "lblTitle";
      this.lblTitle.Size = new System.Drawing.Size(117, 26);
      this.lblTitle.TabIndex = 1;
      this.lblTitle.Text = "New Order";
      // 
      // btnSubmitCreateOrder
      // 
      this.btnSubmitCreateOrder.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
      this.btnSubmitCreateOrder.FlatAppearance.BorderSize = 0;
      this.btnSubmitCreateOrder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.btnSubmitCreateOrder.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.btnSubmitCreateOrder.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
      this.btnSubmitCreateOrder.Location = new System.Drawing.Point(333, 487);
      this.btnSubmitCreateOrder.Name = "btnSubmitCreateOrder";
      this.btnSubmitCreateOrder.Size = new System.Drawing.Size(122, 39);
      this.btnSubmitCreateOrder.TabIndex = 1;
      this.btnSubmitCreateOrder.Text = "Submit";
      this.btnSubmitCreateOrder.UseVisualStyleBackColor = true;
      this.btnSubmitCreateOrder.Click += new System.EventHandler(this.btnSubmitCreateOrder_Click);
      // 
      // btnCancelCreateOrder
      // 
      this.btnCancelCreateOrder.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
      this.btnCancelCreateOrder.FlatAppearance.BorderSize = 0;
      this.btnCancelCreateOrder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.btnCancelCreateOrder.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
      this.btnCancelCreateOrder.Location = new System.Drawing.Point(205, 487);
      this.btnCancelCreateOrder.Name = "btnCancelCreateOrder";
      this.btnCancelCreateOrder.Size = new System.Drawing.Size(122, 39);
      this.btnCancelCreateOrder.TabIndex = 2;
      this.btnCancelCreateOrder.Text = "Cancel";
      this.btnCancelCreateOrder.UseVisualStyleBackColor = true;
      this.btnCancelCreateOrder.Click += new System.EventHandler(this.btnCancelCreateOrder_Click);
      // 
      // lblOrderTitle
      // 
      this.lblOrderTitle.AutoSize = true;
      this.lblOrderTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.lblOrderTitle.Location = new System.Drawing.Point(13, 100);
      this.lblOrderTitle.Name = "lblOrderTitle";
      this.lblOrderTitle.Size = new System.Drawing.Size(76, 17);
      this.lblOrderTitle.TabIndex = 3;
      this.lblOrderTitle.Text = "Order Title";
      // 
      // lblOrderType
      // 
      this.lblOrderType.AutoSize = true;
      this.lblOrderType.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.lblOrderType.Location = new System.Drawing.Point(13, 137);
      this.lblOrderType.Name = "lblOrderType";
      this.lblOrderType.Size = new System.Drawing.Size(81, 17);
      this.lblOrderType.TabIndex = 4;
      this.lblOrderType.Text = "Order Type";
      // 
      // lblClient
      // 
      this.lblClient.AutoSize = true;
      this.lblClient.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.lblClient.Location = new System.Drawing.Point(13, 175);
      this.lblClient.Name = "lblClient";
      this.lblClient.Size = new System.Drawing.Size(43, 17);
      this.lblClient.TabIndex = 5;
      this.lblClient.Text = "Client";
      // 
      // lblOrderCost
      // 
      this.lblOrderCost.AutoSize = true;
      this.lblOrderCost.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.lblOrderCost.Location = new System.Drawing.Point(13, 212);
      this.lblOrderCost.Name = "lblOrderCost";
      this.lblOrderCost.Size = new System.Drawing.Size(36, 17);
      this.lblOrderCost.TabIndex = 6;
      this.lblOrderCost.Text = "Cost";
      // 
      // lblOrderDeadline
      // 
      this.lblOrderDeadline.AutoSize = true;
      this.lblOrderDeadline.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.lblOrderDeadline.Location = new System.Drawing.Point(13, 250);
      this.lblOrderDeadline.Name = "lblOrderDeadline";
      this.lblOrderDeadline.Size = new System.Drawing.Size(140, 17);
      this.lblOrderDeadline.TabIndex = 7;
      this.lblOrderDeadline.Text = "Submission Deadline";
      // 
      // dateTimeSubDate
      // 
      this.dateTimeSubDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.dateTimeSubDate.Location = new System.Drawing.Point(218, 250);
      this.dateTimeSubDate.Name = "dateTimeSubDate";
      this.dateTimeSubDate.Size = new System.Drawing.Size(237, 23);
      this.dateTimeSubDate.TabIndex = 8;
      // 
      // lblWordCount
      // 
      this.lblWordCount.AutoSize = true;
      this.lblWordCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.lblWordCount.Location = new System.Drawing.Point(13, 289);
      this.lblWordCount.Name = "lblWordCount";
      this.lblWordCount.Size = new System.Drawing.Size(83, 17);
      this.lblWordCount.TabIndex = 9;
      this.lblWordCount.Text = "Word Count";
      // 
      // lblScheduleOrder
      // 
      this.lblScheduleOrder.AutoSize = true;
      this.lblScheduleOrder.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.lblScheduleOrder.Location = new System.Drawing.Point(13, 326);
      this.lblScheduleOrder.Name = "lblScheduleOrder";
      this.lblScheduleOrder.Size = new System.Drawing.Size(108, 17);
      this.lblScheduleOrder.TabIndex = 10;
      this.lblScheduleOrder.Text = "Schedule Order";
      // 
      // inputOrderTitle
      // 
      this.inputOrderTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.inputOrderTitle.Location = new System.Drawing.Point(183, 100);
      this.inputOrderTitle.Name = "inputOrderTitle";
      this.inputOrderTitle.Size = new System.Drawing.Size(272, 23);
      this.inputOrderTitle.TabIndex = 11;
      // 
      // inputOrderCost
      // 
      this.inputOrderCost.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.inputOrderCost.Location = new System.Drawing.Point(355, 212);
      this.inputOrderCost.Name = "inputOrderCost";
      this.inputOrderCost.Size = new System.Drawing.Size(100, 23);
      this.inputOrderCost.TabIndex = 14;
      // 
      // inputClient
      // 
      this.inputClient.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.inputClient.Location = new System.Drawing.Point(355, 175);
      this.inputClient.Name = "inputClient";
      this.inputClient.Size = new System.Drawing.Size(100, 23);
      this.inputClient.TabIndex = 13;
      // 
      // inputWordCount
      // 
      this.inputWordCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.inputWordCount.Location = new System.Drawing.Point(355, 289);
      this.inputWordCount.Name = "inputWordCount";
      this.inputWordCount.Size = new System.Drawing.Size(100, 23);
      this.inputWordCount.TabIndex = 15;
      // 
      // inputEditorURL
      // 
      this.inputEditorURL.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
      this.inputEditorURL.Location = new System.Drawing.Point(183, 365);
      this.inputEditorURL.Multiline = true;
      this.inputEditorURL.Name = "inputEditorURL";
      this.inputEditorURL.Size = new System.Drawing.Size(272, 97);
      this.inputEditorURL.TabIndex = 18;
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label1.Location = new System.Drawing.Point(13, 365);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(77, 17);
      this.label1.TabIndex = 17;
      this.label1.Text = "Editor URL";
      // 
      // dateTimeSchedDate
      // 
      this.dateTimeSchedDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.dateTimeSchedDate.Location = new System.Drawing.Point(218, 327);
      this.dateTimeSchedDate.Name = "dateTimeSchedDate";
      this.dateTimeSchedDate.Size = new System.Drawing.Size(237, 23);
      this.dateTimeSchedDate.TabIndex = 19;
      // 
      // comboBoxOrderType
      // 
      this.comboBoxOrderType.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.comboBoxOrderType.FormattingEnabled = true;
      this.comboBoxOrderType.Items.AddRange(new object[] {
            "Article",
            "blog post"});
      this.comboBoxOrderType.Location = new System.Drawing.Point(334, 137);
      this.comboBoxOrderType.Name = "comboBoxOrderType";
      this.comboBoxOrderType.Size = new System.Drawing.Size(121, 24);
      this.comboBoxOrderType.TabIndex = 20;
      // 
      // NewOrder
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(467, 536);
      this.Controls.Add(this.comboBoxOrderType);
      this.Controls.Add(this.dateTimeSchedDate);
      this.Controls.Add(this.inputEditorURL);
      this.Controls.Add(this.label1);
      this.Controls.Add(this.inputWordCount);
      this.Controls.Add(this.inputOrderCost);
      this.Controls.Add(this.inputClient);
      this.Controls.Add(this.inputOrderTitle);
      this.Controls.Add(this.lblScheduleOrder);
      this.Controls.Add(this.lblWordCount);
      this.Controls.Add(this.dateTimeSubDate);
      this.Controls.Add(this.lblOrderDeadline);
      this.Controls.Add(this.lblOrderCost);
      this.Controls.Add(this.lblClient);
      this.Controls.Add(this.lblOrderType);
      this.Controls.Add(this.lblOrderTitle);
      this.Controls.Add(this.btnCancelCreateOrder);
      this.Controls.Add(this.btnSubmitCreateOrder);
      this.Controls.Add(this.panelNewOrderTop);
      this.Name = "NewOrder";
      this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
      this.Text = "NewOrder";
      this.Load += new System.EventHandler(this.NewOrder_Load);
      this.panelNewOrderTop.ResumeLayout(false);
      this.panelNewOrderTop.PerformLayout();
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.Panel panelNewOrderTop;
    private System.Windows.Forms.Button btnSubmitCreateOrder;
    private System.Windows.Forms.Button btnCancelCreateOrder;
    private System.Windows.Forms.Label lblTitle;
    private System.Windows.Forms.Label lblOrderTitle;
    private System.Windows.Forms.Label lblOrderType;
    private System.Windows.Forms.Label lblClient;
    private System.Windows.Forms.Label lblOrderCost;
    private System.Windows.Forms.Label lblOrderDeadline;
    private System.Windows.Forms.DateTimePicker dateTimeSubDate;
    private System.Windows.Forms.Label lblWordCount;
    private System.Windows.Forms.Label lblScheduleOrder;
    private System.Windows.Forms.TextBox inputOrderTitle;
    private System.Windows.Forms.TextBox inputOrderCost;
    private System.Windows.Forms.TextBox inputClient;
    private System.Windows.Forms.TextBox inputWordCount;
    private System.Windows.Forms.TextBox inputEditorURL;
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.DateTimePicker dateTimeSchedDate;
    private System.Windows.Forms.ComboBox comboBoxOrderType;
  }
}