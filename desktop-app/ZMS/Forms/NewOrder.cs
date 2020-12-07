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
    readonly DbConnections connect = new DbConnections();
    readonly Orders orders = new Orders();
    FormOperations action = new FormOperations();
    FormMainMenu mainMenu = new FormMainMenu();

    public NewOrder()
    {
      InitializeComponent();
    }

    private void NewOrder_Load(object sender, EventArgs e)
    {
      LoadTheme();
      this.Text = string.Empty;
      this.ControlBox = false;
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
      MySqlConnection conn = new MySqlConnection();
      conn.Close();
      var x = inputOrderTitle.Text;
      Random rnd = new Random();

      try
      {
        
        MySqlConnection mysqlConnection = new MySqlConnection();
        connect.OpenSuccessfulDBConnection(mysqlConnection);

        String query = "INSERT INTO tb_orders VALUES (@order_id, @title, @description, @scheduled_date, @deadline_date, @word_count, @editor_url, @status, @is_complete, @is_invoiced, @is_closed, @type, @ClientID, @InvoiceID, is_inprogress, @client_name, @order_cost)";

        MySqlCommand cmd = new MySqlCommand(query, mysqlConnection);
        cmd.Parameters.AddWithValue("@order_id", "BLG081233");
        cmd.Parameters.AddWithValue("@title", "abc");
        cmd.Parameters.AddWithValue("@description", "abc");
        cmd.Parameters.AddWithValue("@scheduled_date", dateTimeSchedDate.Value.Date);
        cmd.Parameters.AddWithValue("@deadline_date", dateTimeSubDate.Value.Date);
        cmd.Parameters.AddWithValue("@word_count", 123);
        cmd.Parameters.AddWithValue("@editor_url", "abc");
        cmd.Parameters.AddWithValue("@status", "abc");
        cmd.Parameters.AddWithValue("@is_complete", 0);
        cmd.Parameters.AddWithValue("@is_invoiced", 0);
        cmd.Parameters.AddWithValue("@is_closed", 0);
        cmd.Parameters.AddWithValue("@type", comboBoxOrderType.Text);
        cmd.Parameters.AddWithValue("@ClientID", 123);
        cmd.Parameters.AddWithValue("@InvoiceID", 432);
        cmd.Parameters.AddWithValue("@is_inprogress", 1);
        cmd.Parameters.AddWithValue("@client_name", "abc");
        cmd.Parameters.AddWithValue("@order_cost", 30.00);

       int result = cmd.ExecuteNonQuery();


        Application.OpenForms
       .OfType<Form>()
       .Where(form => String.Equals(form.Name, "NewOrder"))
       .ToList()
       .ForEach(form => form.Close());

        orders.dataGridViewOrderList.Rows.Clear();

        //MessageBox.Show("Order created successfully.");
        orders.dataGridViewOrderList.DataSource = null;
        orders.dataGridViewOrderList.Refresh();
        /*mainMenu.openChildForm(new Forms.Dashboard(), sender);
        mainMenu.openChildForm(new Forms.Orders(), sender);*/

        //connect.GetOrderList(orders.dataGridViewOrderList);


      }
      catch (Exception ex)
      {
        MessageBox.Show(ex.Message);
      }
    }

    private void LoadPatientRecords()
    {
      
    }
  }
}
