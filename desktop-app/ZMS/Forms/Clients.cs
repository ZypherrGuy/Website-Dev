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
  public partial class Clients : Form
  {
    DbConnections connect = new DbConnections();
    FormOperations action = new FormOperations();
    QueryStorage getQuery = new QueryStorage();

    public Clients()
    {
      InitializeComponent();
    }

    private void Clients_Load(object sender, EventArgs e)
    {
      LoadTheme();
      btnEditClient.Visible = false;
      connect.FillDataGridView(dataGridClients, getQuery.query_getClientList);
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

    private void btnNewClient_Click(object sender, EventArgs e)
    {
      NewClient newClientForm = new NewClient();
      newClientForm.Show();
    }

    private void inputSearch_TextChanged(object sender, EventArgs e)
    {
      
        connect.FillDataGridView(dataGridClients, getQuery.query_getClientList + " WHERE client_id like '%" + inputSearch.Text + "%' OR client_name like '%" + inputSearch.Text + "%' OR clientRep_name like '%" + inputSearch.Text + "%'");
    }
  }
}
