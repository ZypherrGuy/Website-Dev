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
      //MySqlDataReader x = new MySqlDataReader();
      connect.OpenSuccessfulDBConnection(conn);
      string BLGquery = "Select COUNT(*) FROM tb_orders WHERE type = 'blog Post'";
      string ARTquery = "Select COUNT(*) FROM tb_orders WHERE type = 'Article'";
      
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

      /*if (comboBox.SelectedItem == "blog post")
      {
        id = "BLG-" + rows_count++;
        MessageBox.Show(id);
        return id;
      }
      else
      {
        return null;
      }*/
    }
  }
}
