﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace ZMS
{
  using System.Runtime.InteropServices;

  public partial class FormMainMenu : Form
  {
    //Fields
    private Button currentButton;
    private Random random;
    private int tempIndex;
    private Form activeForm;


    public FormMainMenu()
    {
      InitializeComponent();
      random = new Random();
      btnCloseChildForm.Visible = false;
      this.Text = string.Empty;
      this.ControlBox = false;
      this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;
    }

    [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
    private extern static void ReleaseCapture(); 
    
    [DllImport("user32.DLL", EntryPoint = "SendMessage")]
    private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

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
          ThemeColor.PrimaryColor = color;
          ThemeColor.SecondaryColor = ThemeColor.ChangeColorBrightness(color, -0.3);
          btnCloseChildForm.Visible = true;
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

    private void openChildForm(Form childForm, object btnSender)
    {
      if (activeForm != null)
      {
        activeForm.Close();
      }

      ActivateButton(btnSender);
      activeForm = childForm;
      childForm.TopLevel = false;
      childForm.FormBorderStyle = FormBorderStyle.None;
      childForm.Dock = DockStyle.Fill;
      this.panelDesktopPanel.Controls.Add(childForm);
      this.panelDesktopPanel.Tag = childForm;
      childForm.BringToFront();
      childForm.Show();
      lblTitle.Text = childForm.Text;
    }

    private void btnDashboard_Click(object sender, EventArgs e)
    {
      openChildForm(new Forms.Dashboard(), sender);
    }

    private void btnOrders_Click(object sender, EventArgs e)
    {
      openChildForm(new Forms.Orders(), sender);
    }

    private void btnInvoices_Click(object sender, EventArgs e)
    {
      openChildForm(new Forms.Invoices(), sender);
    }

    private void btnClients_Click(object sender, EventArgs e)
    {
      openChildForm(new Forms.Clients(), sender);
    }

    private void btnSettings_Click(object sender, EventArgs e)
    {
      openChildForm(new Forms.Settings(), sender);
    }

    private void btnCloseChildForm_Click(object sender, EventArgs e)
    {
      if (activeForm != null)
      {
        activeForm.Close();
        Reset();
      }
    }

    private void Reset()
    {
      DisableButtons();
      lblTitle.Text = "Home";
      panelTitlebar.BackColor = Color.FromArgb(0, 120, 120);
      panelLogo.BackColor = Color.FromArgb(39, 39, 58);
      currentButton = null;
      btnCloseChildForm.Visible = false;
    }

    private void panelTitlebar_MouseDown(object sender, MouseEventArgs e)
    {
      ReleaseCapture();
      SendMessage(this.Handle, 0x112, 0xf012, 0);
    }

    private void btnClose_Click(object sender, EventArgs e)
    {
      Application.Exit();
    }

    private void btnFullScreen_Click(object sender, EventArgs e)
    {
      if (WindowState == FormWindowState.Normal)
      {
        this.WindowState = FormWindowState.Maximized;
      }
      else
      {
        this.WindowState = FormWindowState.Normal;
      }
    }

    private void btnMinimize_Click(object sender, EventArgs e)
    {
      this.WindowState = FormWindowState.Minimized;
    }

    private void FormMainMenu_Load(object sender, EventArgs e)
    {

    }
  }
}
