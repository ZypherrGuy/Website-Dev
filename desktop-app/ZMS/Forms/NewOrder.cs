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
  public partial class NewOrder : Form 
  {
    readonly FormOperations action = new FormOperations();
    readonly DbConnections connect = new DbConnections();
    readonly QueryStorage getQuery = new QueryStorage();

    public NewOrder()
    {
      InitializeComponent();
    }

    private void NewOrder_Load(object sender, EventArgs e)
    {
      LoadTheme();
      this.Text = string.Empty;
      this.ControlBox = false;

      connect.FillComboBox(comboBoxOrderType, getQuery.query_getAllCategoryList, "category_description");
      connect.FillComboBox(comboBoxClient, getQuery.query_getAllClientsList, "client_name");
      connect.FillComboBox(comboBoxAssignee, getQuery.query_getAllAssigneeList, "assignee_name");
      connect.FillComboBox(comboBoxCurrency, getQuery.query_getAllCurrenciesList, "currency_code");

    }

    private void LoadTheme()
    {
      panelNewOrderTop.BackColor = ThemeColor.PrimaryColor;
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

    private void btnCancelCreateOrder_Click(object sender, EventArgs e)
    {
      Application.OpenForms
       .OfType<Form>()
       .Where(form => String.Equals(form.Name, "NewOrder"))
       .ToList()
       .ForEach(form => form.Close());
    }

    private void btnSubmitCreateOrder_Click(object sender, EventArgs e)
    {
      action.CreateNewOrder(comboBoxOrderType, inputOrderTitle, dateTimeSchedDate, dateTimeSubDate , inputEditorURL, comboBoxOrderType, comboBoxClient, comboBoxCurrency, inputOrderCost, comboBoxOrderSize, comboBoxAssignee );
    }

    private void comboBoxClient_SelectedIndexChanged(object sender, EventArgs e)
    {
      comboBoxCurrency.SelectedItem = action.GetCurrencyCodeFromClientName(comboBoxClient);
    }

    private void comboBoxOrderType_SelectedIndexChanged(object sender, EventArgs e)
    {
      inputOrderCost.Text = action.GetDefaultOrderValueFromCategory(comboBoxOrderType);
    }
  }
}
