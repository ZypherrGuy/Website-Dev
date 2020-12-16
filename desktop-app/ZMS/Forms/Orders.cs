using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace ZMS.Forms
{
  public partial class Orders : Form
  {
    readonly DbConnections connect = new DbConnections();
    readonly QueryStorage getQuery = new QueryStorage();
    FormOperations action = new FormOperations();

    public Orders()
    {
      InitializeComponent();
    }

    private void Orders_Load(object sender, EventArgs e)
    {
      LoadTheme();
      btnEditOrder.Visible = false;

      try
      {
        comboBoxOrderState.SelectedIndex = 0;
        connect.FillDataGridView(dataGridViewOrderList, getQuery.query_getInprogressOrderList);
      }
      catch (Exception ex)
      {
        MessageBox.Show(ex.Message);
      }
    }

    private void LoadTheme()
    {
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
      dataGridViewOrderList.DefaultCellStyle.SelectionBackColor = ThemeColor.PrimaryColor;
      dataGridViewOrderList.DefaultCellStyle.SelectionForeColor = Color.White;
    }

    private void btnOpenEditor_Click(object sender, EventArgs e)
    {
      action.GetOrderEditorURL(dataGridViewOrderList);
    }

    private void btnNewOrder_Click(object sender, EventArgs e)
    {
      NewOrder newOrderForm = new NewOrder();
      newOrderForm.Show();
    }

    private void btnGenerateReport_Click(object sender, EventArgs e)
    {
     // action.ExportToExel(dataGridViewOrderList);
    }

    private void btnRefreshOrderTable_Click(object sender, EventArgs e)
    {
      try
      {
        comboBoxOrderState.SelectedIndex = 0;
        connect.FillDataGridView(dataGridViewOrderList, getQuery.query_getInprogressOrderList);
      }
      catch (Exception ex)
      {
        MessageBox.Show(ex.Message);
      }
    }

    private void btnCompleteOrder_Click(object sender, EventArgs e)
    {
      action.CompleteOrder(dataGridViewOrderList);
    }

    private void comboBoxOrderState_SelectedIndexChanged(object sender, EventArgs e)
    {
      switch (comboBoxOrderState.SelectedIndex)
      {
        case 0:
          connect.FillDataGridView(dataGridViewOrderList, getQuery.query_getInprogressOrderList);
          btnCompleteOrder.Enabled = true;
          break;

        case 1:
          connect.FillDataGridView(dataGridViewOrderList, getQuery.query_getOrdersCompletedAndPendingInvoiceList);
          btnCompleteOrder.Enabled = false;
          break;

        case 2:
          connect.FillDataGridView(dataGridViewOrderList, getQuery.query_getOrdersInvoicedAndPendingPayment);
          btnCompleteOrder.Enabled = false;
          break;
        
        case 3:
          connect.FillDataGridView(dataGridViewOrderList, getQuery.query_getOrdersPaidAndClosedList);
          btnCompleteOrder.Enabled = false;
          break;

        default:
          break;
      }

      if (btnCompleteOrder.Enabled == false)
      {
        btnCompleteOrder.BackColor = Color.Gray;
      }
      else
      {
        btnCompleteOrder.BackColor = ThemeColor.PrimaryColor;
      }

    }

    private void inputSearch_TextChanged(object sender, EventArgs e)
    {
      comboBoxOrderState.Text = "";
      connect.FillDataGridView(dataGridViewOrderList, getQuery.query_getAllOrdersSearchbar + " WHERE title like '%" + inputSearch.Text + "%' OR order_id like '%" + inputSearch.Text + "%'");
    }
  }
}
