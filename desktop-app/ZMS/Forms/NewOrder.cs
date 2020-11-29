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
      //label1.ForeColor = ThemeColor.SecondaryColor;
      //label2.ForeColor = ThemeColor.PrimaryColor;
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
      //inputOrderTitle.Text;
    }
  }
}
