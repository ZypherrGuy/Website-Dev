using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ZMS.Forms
{
  public partial class NewInvoice : Form
  {
    DbConnections connect = new DbConnections();
    FormOperations action = new FormOperations();
    QueryStorage getQuery = new QueryStorage();
    List<int> invoiceOrderValues = new List<int>();

    public NewInvoice()
    {
      InitializeComponent();
    }

    private void NewInvoice_Load(object sender, EventArgs e)
    {
      LoadTheme();
      this.Text = string.Empty;
      this.ControlBox = false;

      connect.FillComboBox(comboBoxNewInvoiceCurrency, getQuery.query_getAllCurrenciesList, "currency_code");
      connect.FillComboBox(comboBoxNewInvoiceClientSelect, getQuery.query_getAllClientsList, "client_name");
      connect.FillComboBox(comboBoxNewInvoiceBankingDetails, getQuery.query_getAllAssigneeList, "assignee_name");
      comboBoxNewInvoiceClientSelect.SelectedIndex = 0;
      comboBoxNewInvoiceCurrency.SelectedItem = "USD";
      lblRandConversion.Text = action.GetLiveConversionToRand(Convert.ToInt32(lblCurrencyTotal.Text), comboBoxNewInvoiceCurrency.SelectedItem.ToString(), "ZAR");
    }

    private void LoadTheme()
    {
      panelNewInvoiceTop.BackColor = ThemeColor.PrimaryColor;
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
    }

    private void btnCancelNewInvoice_Click(object sender, EventArgs e)
    {
      Application.OpenForms
        .OfType<Form>()
        .Where(form => string.Equals(form.Name, "NewInvoice"))
        .ToList()
        .ForEach(form => form.Close());
    }

    private void comboBoxNewInvoiceCurrency_SelectedIndexChanged(object sender, EventArgs e)
    {
      using (MySqlConnection sqlConnection = new MySqlConnection(connect.GetDBConnectionString()))
      {
        MySqlCommand sqlCmd = new MySqlCommand("SELECT currency_symbol FROM tb_currency WHERE currency_code = '" + comboBoxNewInvoiceCurrency.SelectedItem + "'", sqlConnection);
        sqlConnection.Open();
        MySqlDataReader sqlReader = sqlCmd.ExecuteReader();

        while (sqlReader.Read())
        {
          lblCurrencySymbol.Text = sqlReader["currency_symbol"].ToString();
          lblRandConversion.Text = action.GetLiveConversionToRand(Convert.ToInt32(lblCurrencyTotal.Text), comboBoxNewInvoiceCurrency.SelectedItem.ToString(), "ZAR");

        }
        sqlReader.Close();
      }
    }

    private void SetDefaultCurrency()
    {
      using (MySqlConnection sqlConnection = new MySqlConnection(connect.GetDBConnectionString()))
      {
        MySqlCommand sqlCmd = new MySqlCommand("SELECT * FROM tb_client WHERE client_name = '" + comboBoxNewInvoiceClientSelect.SelectedItem + "'", sqlConnection);
        sqlConnection.Open();
        MySqlDataReader sqlReader = sqlCmd.ExecuteReader();

        while (sqlReader.Read())
        {
          comboBoxNewInvoiceCurrency.Text = sqlReader["default_currency"].ToString();
        }
        sqlReader.Close();
      }
    }

    private void comboBoxNewInvoiceClientSelect_SelectedIndexChanged(object sender, EventArgs e)
    {
      //connect.FillDataGridView(dataGridCompletedOrderList, getQuery.query_getSelectedClientPendingInvoiceList + "'" + comboBoxNewInvoiceClientSelect.SelectedItem + "'");
      SetDefaultCurrency();
    }

    private void dataGridCompletedOrderList_SelectionChanged(object sender, EventArgs e)
    {
      lblOrderCountNumber.Text = dataGridCompletedOrderList.SelectedRows.Count.ToString();
      invoiceOrderValues.Clear();
      //string query = "SELECT value FROM tb_orders WHERE ";

      foreach (DataGridViewRow row in dataGridCompletedOrderList.SelectedRows)
      {
        invoiceOrderValues.Add(Convert.ToInt32(row.Cells["Value"].Value));  
      }
      lblCurrencyTotal.Text = invoiceOrderValues.Sum().ToString();

      try
      {
        if (comboBoxNewInvoiceCurrency.Text == "")
        {
          lblRandConversion.Text = action.GetLiveConversionToRand(Convert.ToInt32(lblCurrencyTotal.Text), "USD", "ZAR");
        }
        else
        {
          lblRandConversion.Text = action.GetLiveConversionToRand(Convert.ToInt32(lblCurrencyTotal.Text), comboBoxNewInvoiceCurrency.Text, "ZAR");
        }
      }
      catch (Exception error)
      {
        MessageBox.Show(error.Message);
      }
      

    }
  }
}
