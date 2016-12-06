using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace TheatreManagerApp
{
    public partial class EditPopUp : Form
    {
        public EditPopUp(string productName)
        {
            InitializeComponent();
            ClickedProductNameLb.Text = productName;
        }

        private void SavePopUpBtn_Click(object sender, EventArgs e)
        {
            //Edit information in the database
            try
            {
                OleDbConnection connection = Utility.GetOleDBConnection();
                connection.Open();
                string Query = "UPDATE Menu SET Price = " + NewPriceTxt.Text + ", Quantity = " + NewQuantityTxt.Text + " WHERE Prod_Name LIKE '" + ClickedProductNameLb.Text + "'; ";
                OleDbCommand cmd = new OleDbCommand(Query, connection);
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Oops, error: " + ex.Message + ex.StackTrace);
            }
            Close();
        }
    }
}
