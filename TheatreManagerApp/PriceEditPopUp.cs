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
        public PriceEditPopUp()//int adultPrice, int kidPrice, int seniorPrice, int matPrice
        {
            InitializeComponent();
            //NewAdultTxt.Text = adultPrice.ToString();
            //NewKidTxt.Text = kidPrice.ToString();
            //NewMatTxt.Text = matPrice.ToString();
            //NewSeniorTxt.Text = seniorPrice.ToString();

        }

        private void SavePopUpBtn_Click(object sender, EventArgs e)
        {
            //Edit information in the database
            try
            {
                OleDbConnection connection = Utility.GetOleDBConnection();
                connection.Open();
                string Query = "UPDATE Box_Office SET price_adult = " + NewAdultTxt.Text + ", price_kid = " + NewKidTxt.Text + ", price_matinee = " + NewMatTxt.Text + ", price_student_senior = " + NewSeniorTxt.Text + "";
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
