using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Data;
using System.Data.OleDb;

//This code comes from https://msdn.microsoft.com/en-us/library/jj943772.aspx#BKMK_createtheformsandaddcontrols
namespace TheatreManagerApp
{
    internal class Utility
    {

        internal static string GetConnectionString()
        {
            string returnValue = null;
            ConnectionStringSettings settings = ConfigurationManager.ConnectionStrings["TheatreManagerApp.Properties.Settings.connString"];
            if (settings != null)
                returnValue = settings.ConnectionString;

            return returnValue;
        }
        internal static OleDbConnection GetOleDBConnection()
        {
            string ConnectionPath = "Provider=sqloledb; Data Source = CS1; Initial Catalog = TheaterDB; Integrated Security = SSPI;";
            OleDbConnection MyConnection = new OleDbConnection(ConnectionPath);
            return MyConnection;
        }
    }
}