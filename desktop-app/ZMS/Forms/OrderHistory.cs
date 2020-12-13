using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.IO;
using Excel = Microsoft.Office.Interop.Excel;
using Microsoft.VisualBasic;
using MySql.Data.MySqlClient;

namespace ZMS.Forms
{
  public partial class OrderHistory : Form
  {
    readonly DbConnections connect = new DbConnections();
    FormOperations action = new FormOperations();

    public OrderHistory()
    {
      InitializeComponent();
    }

    private void OrderHistory_Load(object sender, EventArgs e)
    {
      LoadTheme();
      SetDateSortFieldVisibility();
      this.Text = string.Empty;
      this.ControlBox = false;

      try
      {

        connect.GetOrderHistoryList(dataGridHistoryOrderList);
      }
      catch (Exception ex)
      {
        MessageBox.Show(ex.Message);
      }

    }

    private void SetDateSortFieldVisibility()
    {
      lblOrderHistoryFrom.Visible = false;
      lblOrderHistoryTo.Visible = false;
      dateTimeOrderHistoryFrom.Visible = false;
      dateTimePickerdateTimeOrderHistoryTo.Visible = false;
    }

    private void LoadTheme()
    {
      //panelNewOrderTop.BackColor = ThemeColor.PrimaryColor;
      foreach (Control btns in this.Controls)
      {
        if (btns.GetType() == typeof(Button))
        {
          Button btn = (Button)btns;
          btn.BackColor = ThemeColor.PrimaryColor;
          btn.ForeColor = Color.White;
          btn.FlatAppearance.BorderColor = ThemeColor.SecondaryColor;
        }
      }

      //label1.ForeColor = ThemeColor.SecondaryColor;
      //label2.ForeColor = ThemeColor.PrimaryColor;
    }

    private void btnHistoryCancel_Click(object sender, EventArgs e)
    {
      Application.OpenForms
        .OfType<Form>()
        .Where(form => String.Equals(form.Name, "OrderHistory"))
        .ToList()
        .ForEach(form => form.Close());
    }

    private void comboBoxSortBy_SelectedIndexChanged(object sender, EventArgs e)
    {
      if (comboBoxSortBy.Text == "Date")
      {
        lblOrderHistoryFrom.Visible = true;
        lblOrderHistoryTo.Visible = true;
        dateTimeOrderHistoryFrom.Visible = true;
        dateTimePickerdateTimeOrderHistoryTo.Visible = true;
      }
      else
      {
        SetDateSortFieldVisibility();
      }
    }

    private void btnSaveReport_Click(object sender, EventArgs e)
    {
      action.CreateOrderHistoyExel(dataGridHistoryOrderList);
    }

    
  }
}
