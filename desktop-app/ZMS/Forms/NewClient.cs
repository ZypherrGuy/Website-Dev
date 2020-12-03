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
  public partial class NewClient : Form
  {
    public NewClient()
    {
      InitializeComponent();
    }

    private void NewClient_Load(object sender, EventArgs e)
    {
      LoadTheme();
      this.Text = string.Empty;
      this.ControlBox = false;
    }
    private void LoadTheme()
    {
      panelNewClientTop.BackColor = ThemeColor.PrimaryColor;
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
      //label2.ForeColor = ThemeColor.PrimaryColor;
    }

    private void btnSubmitNewClient_Click(object sender, EventArgs e)
    {
     
    }

    private void btnCancelNewClient_Click(object sender, EventArgs e)
    {
      Application.OpenForms
        .OfType<Form>()
        .Where(form => String.Equals(form.Name, "NewClient"))
        .ToList()
        .ForEach(form => form.Close());
    }
  }
}
