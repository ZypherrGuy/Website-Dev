using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ZMS
{
  class DbConnections
  {

    public string GetDBConnectionString()
    {
        string connectionString = "SERVER=197.242.144.16;port=3306;DATABASE=royalxyb_ZypeManagementSystem;username=royalxyb_user;password=doctorslater94;Convert Zero Datetime=True";
        return connectionString;  
    }

    public void OpenSuccessfulDBConnection(MySqlConnection mysqlConnection)
    {
      mysqlConnection.ConnectionString = GetDBConnectionString();
      mysqlConnection.Open();
    }

    public void AddDataToGrid(DataGridView dataGridView , string dbQuery , MySqlConnection mysqlConnection)
    {
      MySqlCommand command = new MySqlCommand(dbQuery, mysqlConnection);
      MySqlDataAdapter dataAdapter = new MySqlDataAdapter();
      dataAdapter.SelectCommand = command;
      DataSet DS = new DataSet();
      dataAdapter.Fill(DS);
      dataGridView.DataSource = DS.Tables[0];
    }


    public void GetOrderList(DataGridView orderGrid)
    {
      MySqlConnection mysqlConnection = new MySqlConnection(GetDBConnectionString());
      DataTable dt = new DataTable();
      MySqlDataAdapter da = new MySqlDataAdapter("SELECT order_id AS 'Order ID', title AS 'Title', type_category AS 'Category', client_name AS 'Client', deadline_date AS 'Deadline', status AS 'Status' , currency_id AS 'Currency', order_cost AS 'Value' , order_assignee AS 'Assignee'  FROM tb_orders WHERE is_inprogress = 1 AND is_complete = 0", mysqlConnection);

      if (mysqlConnection.State == ConnectionState.Closed)
        mysqlConnection.Open();

      da.SelectCommand.ExecuteNonQuery();
      da.Fill(dt);

      orderGrid.DataSource = dt;
    }
  }
}

