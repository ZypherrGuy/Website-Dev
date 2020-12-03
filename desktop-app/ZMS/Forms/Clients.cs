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
    public Clients()
    {
      InitializeComponent();
    }

    private void Clients_Load(object sender, EventArgs e)
    {
      LoadTheme();
      btnEditClient.Visible = false;
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

    private void btnNewClient_Click(object sender, EventArgs e)
    {
      NewClient newClientForm = new NewClient();
      newClientForm.Show();
    }

    private void comboBoxClientSort_SelectedIndexChanged(object sender, EventArgs e)
    {
      
    }
  }
}
