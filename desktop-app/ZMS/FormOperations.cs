using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ZMS
{
  class FormOperations
  {
    MySqlConnection conn = new MySqlConnection();
    readonly DbConnections connect = new DbConnections();

    public void CloseCurrentForm(string formName)
    {

    }

    public string GetOrderID(ComboBox comboBox)
    {
      connect.OpenSuccessfulDBConnection(conn);
      string BLGquery = "Select COUNT(*) FROM tb_orders WHERE type_abr = 'blog Post'";
      string ARTquery = "Select COUNT(*) FROM tb_orders WHERE type_abr = 'Article'";

      MySqlCommand cmd2 = new MySqlCommand(BLGquery, conn);
      MySqlCommand cmd3 = new MySqlCommand(ARTquery, conn);


      int blg_rows_count = Convert.ToInt32(cmd2.ExecuteScalar());
      int art_rows_count = Convert.ToInt32(cmd3.ExecuteScalar());
      string id = null;
      string currentYear = DateTime.Now.Year.ToString();

      switch (comboBox.SelectedItem)
      {
        case "blog post":
          id = "BLG-" + currentYear + "-" + blg_rows_count++;
          return id;
        case "Article":
          id = "ART-" + currentYear + "-" + art_rows_count++;
          return id;
        default:
          MessageBox.Show("Invalid Order Type Selected.");
          return null;
      }
    }

    internal void CreateNewOrder(ComboBox orderType, TextBox orderTitle, DateTimePicker scheduleDate, DateTimePicker deadlineDate, TextBox editorURL, ComboBox wordCount, ComboBox clientName, ComboBox currency, TextBox orderValue, ComboBox orderSize, ComboBox assignee)
    {
      try
      {
        MySqlConnection mysqlConnection = new MySqlConnection();
        connect.OpenSuccessfulDBConnection(mysqlConnection);

        String query = "INSERT INTO tb_orders VALUES (" +
          "@order_id," +
          "@title," +
          "@description," +
          "@scheduled_date," +
          "@deadline_date," +
          "@editor_url," +
          "@status," +
          "@is_complete," +
          "@is_invoiced," +
          "@is_closed," +
          "@type_category," +
          "@type_abr," +
          "@type_wordcount," +
          "@ClientID," +
          "@InvoiceID," +
          "@is_inprogress," +
          "@client_name," +
          "@currency_id," +
          "@order_cost," +
          "@order_size," +
          "@order_dateCreated," +
          "@order_assignee," +
          "@created_by)";

        MySqlCommand cmd = new MySqlCommand(query, mysqlConnection);
        cmd.Parameters.AddWithValue("@order_id", GetOrderID(orderType));
        cmd.Parameters.AddWithValue("@title", orderTitle.Text);
        cmd.Parameters.AddWithValue("@description", "Basic Order");
        cmd.Parameters.AddWithValue("@scheduled_date", scheduleDate.Value.Date);
        cmd.Parameters.AddWithValue("@deadline_date", deadlineDate.Value.Date);
        cmd.Parameters.AddWithValue("@editor_url", editorURL.Text);
        cmd.Parameters.AddWithValue("@status", "In-progress");
        cmd.Parameters.AddWithValue("@is_complete", 0);
        cmd.Parameters.AddWithValue("@is_invoiced", 0);
        cmd.Parameters.AddWithValue("@is_closed", 0);
        cmd.Parameters.AddWithValue("@type_category", orderType.SelectedItem + " (" + wordCount.SelectedItem + ")");
        cmd.Parameters.AddWithValue("@type_abr", orderType.SelectedItem);
        cmd.Parameters.AddWithValue("@type_wordcount", Convert.ToInt32(wordCount.SelectedItem));
        cmd.Parameters.AddWithValue("@ClientID", 1);
        cmd.Parameters.AddWithValue("@InvoiceID", 1);
        cmd.Parameters.AddWithValue("@is_inprogress", 1);
        cmd.Parameters.AddWithValue("@client_name", clientName.SelectedItem);
        cmd.Parameters.AddWithValue("@currency_id", currency.SelectedItem);
        cmd.Parameters.AddWithValue("@order_cost", orderValue.Text);
        cmd.Parameters.AddWithValue("@order_size", Convert.ToInt32(orderSize.SelectedItem));
        cmd.Parameters.AddWithValue("@order_dateCreated", DateTime.Now);
        cmd.Parameters.AddWithValue("@order_assignee", assignee.SelectedItem);
        cmd.Parameters.AddWithValue("@created_by", "Fern Lahoud");

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

    internal void CompleteOrder(DataGridView orderGrid)
    {
      try
      {
        MySqlConnection mysqlConnection = new MySqlConnection();
        connect.OpenSuccessfulDBConnection(mysqlConnection);

        String query = "UPDATE tb_orders SET is_complete = 1 WHERE order_id = '" + orderGrid.SelectedCells[0].Value.ToString() + "'";

        MySqlCommand cmd = new MySqlCommand(query, mysqlConnection);
        cmd.ExecuteNonQuery();

        MessageBox.Show("Order marked as complete.");
      }
      catch (Exception ex)
      {
        MessageBox.Show(ex.Message);
      }
    }

  }
}
