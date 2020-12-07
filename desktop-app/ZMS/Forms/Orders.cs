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

        connect.GetOrderList(dataGridViewOrderList);
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

      //label1.ForeColor = ThemeColor.SecondaryColor;
      //label2.ForeColor = ThemeColor.PrimaryColor;
    }

    private void btnOpenEditor_Click(object sender, EventArgs e)
    {

    }

    private void btnNewOrder_Click(object sender, EventArgs e)
    {
      NewOrder newOrderForm = new NewOrder();
      newOrderForm.Show();
    }

    private void btnOrderHistory_Click(object sender, EventArgs e)
    {
      OrderHistory orderHistory = new OrderHistory();
      orderHistory.Show();
    }
  }
}
