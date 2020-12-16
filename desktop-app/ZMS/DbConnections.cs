using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;

namespace ZMS
{
  class DbConnections
  {
    public string GetDBConnectionString()
    {
      return ConfigurationManager.ConnectionStrings["connectionString"].ConnectionString; ;  
    }

    public void OpenSuccessfulDBConnection(MySqlConnection mysqlConnection)
    {
      mysqlConnection.ConnectionString = GetDBConnectionString();
      mysqlConnection.Open();
    }

    public void FillDataGridView(DataGridView orderGrid , string query)
    {
      MySqlConnection mysqlConnection = new MySqlConnection(GetDBConnectionString());
      DataTable dt = new DataTable();
      MySqlDataAdapter da = new MySqlDataAdapter(query, mysqlConnection);

      if (mysqlConnection.State == ConnectionState.Closed)
        mysqlConnection.Open();

      da.SelectCommand.ExecuteNonQuery();
      da.Fill(dt);

      orderGrid.DataSource = dt;
    }


    public void FillComboBox(ComboBox comboBox, string query, string dbColumnName)
    {
      using (MySqlConnection sqlConnection = new MySqlConnection(GetDBConnectionString()))
      {
        MySqlCommand sqlCmd = new MySqlCommand(query , sqlConnection);
        sqlConnection.Open();
        MySqlDataReader sqlReader = sqlCmd.ExecuteReader();

        while (sqlReader.Read())
        {
          comboBox.Items.Add(sqlReader[dbColumnName].ToString() );
        }

        sqlReader.Close();
      }
    }
  }
}

