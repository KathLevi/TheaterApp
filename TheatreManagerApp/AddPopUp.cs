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
    public partial class AddPopUp : Form
    {
        public AddPopUp()
        {
            InitializeComponent();
        }

        private void SavePopUpBtn_Click(object sender, EventArgs e)
        {
            //Save new information to DB
            try
            {
                OleDbConnection connection = Utility.GetOleDBConnection();
                connection.Open();
                string Query = "INSERT INTO Menu (Prod_Name, Price, Quantity) VALUES ('" + NewProductTxt.Text + "', " + NewPriceTxt.Text + ", " + NewQuantityTxt.Text + "); ";
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
