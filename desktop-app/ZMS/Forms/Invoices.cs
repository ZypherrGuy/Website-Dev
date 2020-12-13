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
    DbConnections connect = new DbConnections();
    FormOperations action = new FormOperations();

    public Invoices()
    {
      InitializeComponent();
    }

    private void Invoices_Load(object sender, EventArgs e)
    {
      LoadTheme();
      comboBoxInvoiceStatus.SelectedIndex = 0;
      connect.GetInvoiceList_PendingInvoice(dataGridInvoiceList);

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
      //label1.ForeColor = ThemeColor.SecondaryColor;
      //label2.ForeColor = ThemeColor.PrimaryColor;
    }

        private void btnCreateInvoice_Click(object sender, EventArgs e)
        {
            NewInvoice newInvoiceForm = new NewInvoice();
            newInvoiceForm.Show();
            //MessageBox.Show(action.GetLiveConversionToRand(1, "USD", "ZAR"));
        }

    private void comboBoxInvoiceStatus_SelectedIndexChanged(object sender, EventArgs e)
    {
      switch (comboBoxInvoiceStatus.SelectedIndex)
      {
        case 0:
          connect.GetInvoiceList_PendingInvoice(dataGridInvoiceList);
          break;

        case 1:
          connect.GetInvoiceList_PendingPayment(dataGridInvoiceList);
          break;

        case 2:
          connect.GetInvoiceList_ClosedOrders(dataGridInvoiceList);
          break;

        default:
          break;
      }
    }
  }
}
