using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Data.SqlClient;
using System.IO;
using Excel = Microsoft.Office.Interop.Excel;
using Microsoft.VisualBasic;

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
          "@date_orderCompleted," +
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
        cmd.Parameters.AddWithValue("@date_orderCompleted", DateTime.MinValue);
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

        String completeOrderQuery = "UPDATE tb_orders SET is_complete = 1, status = 'Pending Invoice', date_orderCompleted  = @date_orderCompleted WHERE order_id = '" + orderGrid.SelectedCells[0].Value.ToString() + "'";

        MySqlCommand cmd = new MySqlCommand(completeOrderQuery, mysqlConnection);

        cmd.Parameters.AddWithValue("@date_orderCompleted", DateTime.Now);
        cmd.ExecuteNonQuery();

        mysqlConnection.Close();
  
      MessageBox.Show("Order marked as complete.");
      }
      catch (Exception ex)
      {
        MessageBox.Show(ex.Message);
      }
    }

    internal void GetOrderEditorURL(DataGridView orderGrid)
    {
      using (MySqlConnection connection = new MySqlConnection(connect.GetDBConnectionString()))
      using (MySqlCommand command = new MySqlCommand("SELECT  editor_url FROM tb_orders WHERE order_id = '" + orderGrid.SelectedCells[0].Value.ToString() + "'", connection))
      {
        connection.Open();
        using (MySqlDataReader reader = command.ExecuteReader())
        {
          while (reader.Read())
          {
            var x = reader["editor_url"].ToString();
            System.Diagnostics.Process.Start(reader["editor_url"].ToString());
          }
        }
      }
    }

    internal void CreateOrderHistoyExel(DataGridView orderHistoryGrid)
    {
      MySqlConnection mysqlConnection = new MySqlConnection();
      connect.OpenSuccessfulDBConnection(mysqlConnection);

      int colIndex = 1;
      int rowIndex = 1;
      Excel.Application xlApp;
      Excel.Workbook xlWorkBook;
      Excel.Worksheet xlWorkSheet;
      object misValue = System.Reflection.Missing.Value;
      xlApp = new Excel.Application();
      Excel.Range ExelRange;
      MySqlDataAdapter sqlADP = new MySqlDataAdapter("SELECT order_id AS 'Order ID', title AS 'Title', type_category AS 'Category', client_name AS 'Client',  status AS 'Status' , date_orderCompleted AS 'Date Completed', currency_id AS 'Currency', order_cost AS 'Value' , order_assignee AS 'Assignee'  FROM tb_orders WHERE is_complete = 1 ", mysqlConnection);
      //Create and fill a  Datatable.
      DataTable DTtable = new DataTable();
      sqlADP.Fill(DTtable);
      orderHistoryGrid.DataSource = DTtable;

      orderHistoryGrid.AutoGenerateColumns = false;
      orderHistoryGrid.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);

      xlApp = new Excel.Application();
      xlWorkBook = xlApp.Workbooks.Add(misValue);
      xlWorkSheet = (Excel.Worksheet)xlWorkBook.Worksheets.get_Item(1);

      foreach (DataRow theRow in DTtable.Rows)
      {
        rowIndex = rowIndex + 1;
        colIndex = 0;
        foreach (DataColumn dc in DTtable.Columns)
        {
          colIndex = colIndex + 1;
          xlWorkSheet.Cells[rowIndex + 1, colIndex] = theRow[dc.ColumnName];
          xlWorkSheet.Rows.AutoFit();
          xlWorkSheet.Columns.AutoFit();
        }
      }

      xlWorkSheet.get_Range("b2", "e2").Merge(false);

      ExelRange = xlWorkSheet.get_Range("b2", "e2");
      ExelRange.FormulaR1C1 = "Exel Title or Table Name ";

      ExelRange.HorizontalAlignment = 3;
      ExelRange.VerticalAlignment = 3;

      xlApp.Visible = true;
      ObjectRelease(xlWorkSheet);
      ObjectRelease(xlWorkBook);
      ObjectRelease(xlApp);

    }
    private void ObjectRelease(object objRealease)
    {
      try
      {
        System.Runtime.InteropServices.Marshal.ReleaseComObject(objRealease);
        objRealease = null;
      }
      catch (Exception ex)
      {
        objRealease = null;
        MessageBox.Show("Error_" + ex.ToString());
      }
      finally
      {
        GC.Collect();
      }
    }

  }
}
