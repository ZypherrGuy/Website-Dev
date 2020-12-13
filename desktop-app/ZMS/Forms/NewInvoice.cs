using MySql.Data.MySqlClient;
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
    public partial class NewInvoice : Form
    {
        DbConnections connect = new DbConnections();
        FormOperations action = new FormOperations();

        public NewInvoice()
        {
            InitializeComponent();
        }

        private void NewInvoice_Load(object sender, EventArgs e)
        {
            LoadTheme();
            this.Text = string.Empty;
            this.ControlBox = false;

            connect.FillComboBox(comboBoxNewInvoiceCurrency);

        }

        private void LoadTheme()
        {
            panelNewInvoiceTop.BackColor = ThemeColor.PrimaryColor;
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

    private void btnCancelNewInvoice_Click(object sender, EventArgs e)
    {
      Application.OpenForms
        .OfType<Form>()
        .Where(form => string.Equals(form.Name, "NewInvoice"))
        .ToList()
        .ForEach(form => form.Close());
    }

    private void lblRandSymbol_Click(object sender, EventArgs e)
    {

    }

    private void comboBoxNewInvoiceCurrency_SelectedIndexChanged(object sender, EventArgs e)
    {
      //lblCurrencySymbol.Text
      using (MySqlConnection sqlConnection = new MySqlConnection(connect.GetDBConnectionString()))
      {
        MySqlCommand sqlCmd = new MySqlCommand("SELECT currency_symbol FROM tb_currency WHERE currency_code = '" + comboBoxNewInvoiceCurrency.SelectedItem + "'", sqlConnection);
        sqlConnection.Open();
        MySqlDataReader sqlReader = sqlCmd.ExecuteReader();

        string x = lblCurrencyTotal.Text;
        decimal y = Convert.ToInt32(x);

        while (sqlReader.Read())
        {
          lblCurrencySymbol.Text = sqlReader["currency_symbol"].ToString();
          lblRandConversion.Text = action.GetLiveConversionToRand(Convert.ToInt32(lblCurrencyTotal.Text), comboBoxNewInvoiceCurrency.SelectedItem.ToString(), "ZAR");

        }



        sqlReader.Close();
      }

    } 
  }
}
