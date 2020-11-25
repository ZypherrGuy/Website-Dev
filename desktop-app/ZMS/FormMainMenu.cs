using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ZMS
{
  public partial class FormMainMenu : Form
  {
    //Fields
    private Button currentButton;
    private Random random;
    private int tempIndex;


    public FormMainMenu()
    {
      InitializeComponent();
      random = new Random();
    }

    //Methods
    private Color SelectThemeColor()
    {
      int index = random.Next(ThemeColor.ColorList.Count);
      while (tempIndex == index)
      {
        index = random.Next(ThemeColor.ColorList.Count);
      }

      tempIndex = index;
      string color = ThemeColor.ColorList[index];
      return ColorTranslator.FromHtml(color);
    }

    private void ActivateButton(object btnSender)
    {
      if (btnSender != null)
      {
        if (currentButton != (Button)btnSender)
        {
          DisableButtons();
          Color color = SelectThemeColor();
          currentButton = (Button)btnSender;
          currentButton.BackColor = color;
          currentButton.ForeColor = Color.White;
          currentButton.Font = new System.Drawing.Font(
            "Microsoft Sans Serif",
            12.5F,
            System.Drawing.FontStyle.Regular,
            System.Drawing.GraphicsUnit.Point,
            ((byte)(0)));
          panelTitlebar.BackColor = color;
          panelLogo.BackColor = ThemeColor.ChangeColorBrightness(color , -0.3);
        }
      }
    }

    private void DisableButtons()
    {
      foreach (Control previousBtn in panelMenu.Controls)
      {
        if (previousBtn.GetType() == typeof(Button))
        {
          previousBtn.BackColor = Color.FromArgb(51, 51, 76);
          previousBtn.ForeColor = Color.White;
          previousBtn.Font = new System.Drawing.Font(
            "Microsoft Sans Serif",
            10F,
            System.Drawing.FontStyle.Regular,
            System.Drawing.GraphicsUnit.Point,
            ((byte)(0)));
        }
      }
    }

    private void btnDashboard_Click(object sender, EventArgs e)
    {
      ActivateButton(sender);
    }

    private void btnOrders_Click(object sender, EventArgs e)
    {
      ActivateButton(sender);
    }

    private void btnInvoices_Click(object sender, EventArgs e)
    {
      ActivateButton(sender);
    }

    private void btnClients_Click(object sender, EventArgs e)
    {
      ActivateButton(sender);
    }

    private void btnSettings_Click(object sender, EventArgs e)
    {
      ActivateButton(sender);
    }
  }
}
