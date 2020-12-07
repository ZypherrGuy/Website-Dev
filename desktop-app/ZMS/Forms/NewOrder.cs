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
    readonly FormOperations action = new FormOperations();
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

      try
      {
        
        MySqlConnection mysqlConnection = new MySqlConnection();
        connect.OpenSuccessfulDBConnection(mysqlConnection);

        String query = "INSERT INTO tb_orders VALUES (@order_id , @title, @description, @scheduled_date, @deadline_date, @word_count, @editor_url, @status, @is_complete, @is_invoiced, @is_closed, @type, @ClientID, @InvoiceID, @is_inprogress, @client_name, @order_cost, @order_dateCreated)";

        MySqlCommand cmd = new MySqlCommand(query, mysqlConnection);
        cmd.Parameters.AddWithValue("@order_id", action.GetOrderID(comboBoxOrderType));
        cmd.Parameters.AddWithValue("@title", inputOrderTitle.Text);
        cmd.Parameters.AddWithValue("@description", "Basic Order");
        cmd.Parameters.AddWithValue("@scheduled_date", dateTimeSchedDate.Value.Date);
        cmd.Parameters.AddWithValue("@deadline_date", dateTimeSubDate.Value.Date);
        cmd.Parameters.AddWithValue("@word_count", inputWordCount.Text);
        cmd.Parameters.AddWithValue("@editor_url", inputEditorURL.Text);
        cmd.Parameters.AddWithValue("@status", "In-progress");
        cmd.Parameters.AddWithValue("@is_complete", 0);
        cmd.Parameters.AddWithValue("@is_invoiced", 0);
        cmd.Parameters.AddWithValue("@is_closed", 0);
        cmd.Parameters.AddWithValue("@type", comboBoxOrderType.Text);
        cmd.Parameters.AddWithValue("@ClientID", 123);//Change to ComboBox
        cmd.Parameters.AddWithValue("@InvoiceID", 432);
        cmd.Parameters.AddWithValue("@is_inprogress", 1);
        cmd.Parameters.AddWithValue("@client_name", inputClient.Text); //Linked to Client ID
        cmd.Parameters.AddWithValue("@order_cost", inputOrderCost.Text);
        cmd.Parameters.AddWithValue("@order_dateCreated", DateTime.Now);
       // cmd.Parameters.AddWithValue("@Assignee", DateTime.Now);  //TODO 

       int result = cmd.ExecuteNonQuery();


        Application.OpenForms
       .OfType<Form>()
       .Where(form => String.Equals(form.Name, "NewOrder"))
       .ToList()
       .ForEach(form => form.Close());

        
      
        
        MessageBox.Show("Order created successfully.");
        mysqlConnection.Close();


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
