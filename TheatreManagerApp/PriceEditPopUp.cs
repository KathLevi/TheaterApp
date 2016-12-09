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
    public partial class PriceEditPopUp : Form
    {
        public PriceEditPopUp(string kidPrice, string adultPrice, string seniorPrice, string matPrice)
        {
            InitializeComponent();
            NewAdultTxt.Text = adultPrice;
            NewKidTxt.Text = kidPrice;
            NewMatTxt.Text = matPrice;
            NewSeniorTxt.Text = seniorPrice;

        }

        private void SavePopUpBtn_Click(object sender, EventArgs e)
        {
            //Edit information in the database
            try
            {
                OleDbConnection connection = Utility.GetOleDBConnection();
                connection.Open();
                string Query = "UPDATE Box_Office SET price_adult = " + NewSeniorTxt.Text + ", price_kid = " + NewKidTxt.Text + ", price_matinee = " + NewAdultTxt.Text + ", price_student_senior = " + NewMatTxt.Text + "";
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
