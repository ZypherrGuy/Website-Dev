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
  public partial class Invoices : Form
  {
    readonly QueryStorage getQuery = new QueryStorage();
    readonly DbConnections connect = new DbConnections();
    NewInvoice controls = new NewInvoice();

    public Invoices()
    {
      InitializeComponent();
    }

    private void Invoices_Load(object sender, EventArgs e)
    {
      LoadTheme();
      comboBoxInvoiceStatus.SelectedIndex = 0;
     // connect.FillDataGridView(dataGridInvoiceList, getQuery.query_getOrdersCompletesAndPendingInvoiceList);
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
    }

    private void btnCreateInvoice_Click(object sender, EventArgs e)
    {
      NewInvoice newInvoiceForm = new NewInvoice();
      newInvoiceForm.Show();
      //controls.lblRandConversion.Text = action.GetLiveConversionToRand(Convert.ToInt32(lblCurrencyTotal.Text), comboBoxNewInvoiceCurrency.SelectedItem.ToString(), "ZAR");
    }

    private void comboBoxInvoiceStatus_SelectedIndexChanged(object sender, EventArgs e)
    {
      switch (comboBoxInvoiceStatus.SelectedIndex)
      {
        case 0:
          connect.FillDataGridView(dataGridInvoiceList, getQuery.query_getPaymentPendingOrderList);
          break;

        case 1:
          connect.FillDataGridView(dataGridInvoiceList, getQuery.query_getPaymentPendingInvoiceList);
          break; 
        
        case 2:
          connect.FillDataGridView(dataGridInvoiceList, getQuery.query_getPaymentReceivedAndClosedOrderList);
          break;
        
        case 3:
          connect.FillDataGridView(dataGridInvoiceList, getQuery.query_getPaymentReceivedAndClosedInvoiceList);
          break;

        default:
          break;
      }
    }

    private void inputSearch_TextChanged(object sender, EventArgs e)
    {
      if(comboBoxInvoiceStatus.SelectedIndex == 0 || comboBoxInvoiceStatus.SelectedIndex == 2)
      {
        connect.FillDataGridView(dataGridInvoiceList, getQuery.query_getAllOrdersInInvoicesSearchbar + " WHERE i.invoice_id LIKE '%" + inputSearch.Text + "%' OR i.invoice_paymentReference LIKE '%" + inputSearch.Text + "%' OR o.order_id LIKE '%" + inputSearch.Text + "%' OR o.title LIKE '%" + inputSearch.Text + "%'");
      }
      else if (comboBoxInvoiceStatus.SelectedIndex == 1 || comboBoxInvoiceStatus.SelectedIndex == 3)
      {
        connect.FillDataGridView(dataGridInvoiceList, getQuery.query_getAllInvoicesSearchbar + " WHERE i.invoice_id LIKE '%" + inputSearch.Text + "%' OR i.invoice_paymentReference LIKE '%" + inputSearch.Text + "%' OR c.client_name LIKE '%" + inputSearch.Text + "%'");
      }
      
    }
  }
}
