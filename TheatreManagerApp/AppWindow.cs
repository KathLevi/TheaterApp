using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TheatreManagerApp;
using System.Data.OleDb;

namespace TheatreManagerApp
{
    public partial class AppWindow : Form
    {
        private BindingSource bindingSource1 = new BindingSource();
        List<string> MenuList = new List<string>();
        List<string> StockList = new List<string>();
        public AppWindow()
        {
            InitializeComponent();
           
            dtpStart.Value = DateTime.Now;
            dtpEnd.Value = DateTime.Now.AddDays(1);
            
            LoadCenterPanel();
            LoadPrices();
            LoadMenuList();
            LoadStockList();
            GetSchedule();
        }
        
        private void LoadCenterPanel()
        {
            dataGridView1.DataSource = bindingSource1;
            GetSchedule();
        }
        private void LoadPrices()
        {
            try
            {
                OleDbConnection connection = Utility.GetOleDBConnection();
                connection.Open();
                string Query = "SELECT  * FROM Box_Office BO;";
                OleDbCommand cmd = new OleDbCommand(Query, connection);
                DataTable BO = new DataTable();
                BO.Load(cmd.ExecuteReader());
                connection.Close();
                kidPrice.Text = "$" + BO.Rows[0][1].ToString();
                adultPrice.Text = "$" + BO.Rows[0][2].ToString();
                seniorPrice.Text = "$" + BO.Rows[0][3].ToString();
                matPrice.Text = "$" + BO.Rows[0][4].ToString();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Oops, error: " + ex.Message + ex.StackTrace);
            }
        }   
        private void GetSchedule()
        {
            try
            {
               
                OleDbConnection connection = Utility.GetOleDBConnection();
                String Start = dtpStart.Value.ToShortDateString();
                String End = dtpEnd.Value.ToShortDateString();
                string query = 
                    "SELECT C.Date, S.Time, M.Title, M.Rating " +
                    "FROM Calendar C " +
                    "JOIN Schedule S " +
                        "ON C.Cal_Id = S.Calendar_Id "  +
                    "JOIN Movie M " +
                        "ON M.Movie_Id = S.Movie_Id " +
                    "WHERE '"+ Start + "' < C.Date AND C.Date < '" + End + "' ; ";
                
                
                DataTable table = new DataTable();
                using (connection)
                {
                    OleDbCommand cmd = new OleDbCommand(query, connection);
                    connection.Open();
                    OleDbDataAdapter adapter = new OleDbDataAdapter(cmd);
                    adapter.Fill(table);
                }

                // Populate a new data table and bind it to the BindingSource.
                bindingSource1.DataSource = table;
                
             
                foreach(DataGridViewColumn col in dataGridView1.Columns)
                {
                    col.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                }
            }
            catch (OleDbException ex)
            {
                MessageBox.Show("Oops, error: " + ex.Message + ex.StackTrace);
            }   
        }

       /* private void GetScheduleListView()
        {
            try
            {

                OleDbConnection connection = Utility.GetOleDBConnection();
                String Start = dtpStart.Value.ToShortDateString();
                String End = dtpEnd.Value.ToShortDateString();
                string query =
                    "SELECT C.Date, S.Time, M.Title, M.Rating, T.Capacity " +
                    "FROM Calendar C " +
                    "JOIN Schedule S " +
                        "ON C.Cal_Id = S.Calendar_Id " +
                    "JOIN Movie M " +
                        "ON M.Movie_Id = S.Movie_Id " +
                    "JOIN Theater T " +
                        "ON T.Theater_Id = S.Theater_Id " +
                    "WHERE '" + Start + "' < C.Date AND C.Date < '" + End + "' ; ";


                DataTable table = new DataTable();
                using (connection)
                {
                    OleDbCommand cmd = new OleDbCommand(query, connection);
                    connection.Open();
                    OleDbDataAdapter adapter = new OleDbDataAdapter(cmd);
                    adapter.Fill(table);
                }

                for (int i = 0; i < table.Rows.Count; i++)
                {
                    DataRow dr = table.Rows[i];
                    ListViewItem listitem = new ListViewItem(dr["Date"].ToString());
                    listitem.SubItems.Add(dr["Time"].ToString());
                    listitem.SubItems.Add(dr["Title"].ToString());
                    listitem.SubItems.Add(dr["Rating"].ToString());
                    listitem.SubItems.Add(dr["Capacity"].ToString());
                    listView1.Items.Add(listitem);
                }

            }
            catch (OleDbException ex)
            {
                MessageBox.Show("Oops, error: " + ex.Message + ex.StackTrace);
            };
        }
        */
        private void LoadMenuList()
        {
            try
            {
                //connect to the database 
                OleDbConnection connection = Utility.GetOleDBConnection();
                connection.Open();
                //query the database
                string Query = "SELECT M.Prod_Name FROM Menu M WHERE M.Quantity > 0";
                OleDbCommand cmd = new OleDbCommand(Query, connection);
                OleDbDataReader rdr = cmd.ExecuteReader();
                MenuList.Clear();

                while (rdr.Read())
                {
                    MenuList.Add(rdr.GetValue(0).ToString());
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Oops, error: " + ex.Message + ex.StackTrace);
            }

            Menu_List.DataSource = null;
            Menu_List.DataSource = MenuList;    //reload menu list
        }

        private void LoadStockList()    //similar to LoadMenuList()
        {
            try
            {
                OleDbConnection connection = Utility.GetOleDBConnection();
                connection.Open();
                string Query = "SELECT M.Prod_Name FROM Menu M WHERE M.Quantity < 50";
                OleDbCommand cmd = new OleDbCommand(Query, connection);
                OleDbDataReader rdr = cmd.ExecuteReader();
                StockList.Clear();

                while (rdr.Read())
                {
                    StockList.Add(rdr.GetValue(0).ToString());
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Oops, error: " + ex.Message + ex.StackTrace);
            }

            Stock_List.DataSource = null;
            Stock_List.DataSource = StockList;
        }

        private void AddBtn_Click(object sender, EventArgs e)
        {
            //The add button was clicked
            AddPopUp addPopUp = new AddPopUp();
            addPopUp.ShowDialog();

            //Reload database after adding new products
            LoadMenuList();
            LoadStockList();

            //If we just added an item, ensure the remove and edit buttons are enabled
            RemoveBtn.Enabled = true;
            EditBtn.Enabled = true;
        }

        private void RemoveBtn_Click(object sender, EventArgs e)
        {
            //The remove button was clicked
            int selectedIndex = Menu_List.SelectedIndex;
            string productName = Menu_List.SelectedItem.ToString();

            try
            {
                //Remove selected item in the list
                MenuList.RemoveAt(selectedIndex);

                OleDbConnection connection = Utility.GetOleDBConnection();
                connection.Open();
                string Query = "DELETE FROM Menu WHERE '" + productName + "' LIKE Prod_Name; ";
                OleDbCommand cmd = new OleDbCommand(Query, connection);
                cmd.ExecuteNonQuery();

                LoadMenuList();
                LoadStockList();
            }
            catch
            {
            }

            Menu_List.DataSource = null;
            Menu_List.DataSource = MenuList;

            //If the list is empty disable the remove and edit buttons
            if (Menu_List.Items.Count == 0)
            {
                RemoveBtn.Enabled = false;
                EditBtn.Enabled = false;
            }
        }


        private void EditBtn_Click(object sender, EventArgs e)
        {
            string productName = Menu_List.SelectedItem.ToString();

            //The edit button was clicked
            EditPopUp editPopUp = new EditPopUp(productName);
            editPopUp.ShowDialog();

            //Reload database after editing products
            LoadMenuList();
            LoadStockList();

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void dtpEnd_ValueChanged(object sender, EventArgs e)
        {
            GetSchedule();
            
        }

        private void dtpStart_ValueChanged(object sender, EventArgs e)
        {
            GetSchedule();
            
        }

        private void EditPriceBtn_Click(object sender, EventArgs e)
        {
            //The edit price button was clicked
            PriceEditPopUp editPrice = new PriceEditPopUp();
            editPrice.ShowDialog();

            //Reload database after editing products
            LoadPrices();
        }

        private void DeleteLowStockBtn_Click(object sender, EventArgs e)
        {
            //The remove button was clicked
            int selectedIndex = Stock_List.SelectedIndex;
            string productName = Stock_List.SelectedItem.ToString();

            try
            {
                //Remove selected item in the list
                StockList.RemoveAt(selectedIndex);

                OleDbConnection connection = Utility.GetOleDBConnection();
                connection.Open();
                string Query = "DELETE FROM Menu WHERE '" + productName + "' LIKE Prod_Name; ";
                OleDbCommand cmd = new OleDbCommand(Query, connection);
                cmd.ExecuteNonQuery();

                LoadMenuList();
                LoadStockList();
            }
            catch
            {
            }

            Stock_List.DataSource = null;
            Stock_List.DataSource = StockList;

            //If the list is empty disable the remove and edit buttons
            if (Stock_List.Items.Count == 0)
            {
                DeleteLowStockBtn.Enabled = false;
                RestockBtn.Enabled = false;
            }
        }

        private void RestockBtn_Click(object sender, EventArgs e)
        {
            string productName = Stock_List.SelectedItem.ToString();

            //The edit button was clicked
            EditPopUp editPopUp = new EditPopUp(productName);
            editPopUp.ShowDialog();

            //Reload database after editing products
            LoadMenuList();
            LoadStockList();
        }
    }
}
