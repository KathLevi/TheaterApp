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

        //---------------------------------?? DELETE ??------------------------------------
        //internal static string QuerySelect(int QueryNum)
        //{
        //    string Query;
        //    switch (QueryNum)
        //    {
        //        //Price kid
        //        case 0:
        //            Query = "SELECT  BO.price_kid FROM Box_Office BO; ";
        //            return Query;
        //        //Pirce Adult
        //        case 1:
        //            Query = "SELECT BO.price_adult FROM Box_Office BO; ";
        //            return Query;
        //        //Price Matinee
        //        case 2:
        //            Query = "SELECT BO.price_matinee FROM Box_Office BO; ";
        //            return Query;
        //        //Price Senior Student
        //        case 3:
        //            Query = "Select BO.price_student_senior FROM Box_Office BO; ";
        //            return Query;
        //        default:
        //            Query = "";
        //            return Query;
        //    }
        //}
        //internal static string QuerySelect(int QueryNum, DateTime date)
        //{
        //    string Query = "";
        //    switch (QueryNum)
        //    {
        //        //PULLS MOVIE INFO AND TIME(CAN INCLUDE THEATER IN LATER QUERY) FOR AFTER A SPCIFIC DATE--
        //        case 0:
        //            Query = String.Format("SELECT * FROM Schedule S LEFT OUTER JOIN Calendar C ON S.ScheduleID = C.Calendar ID LEFT OUT JOIN Movie M ON S.movie_id = M.movie_id WHERE C.Date > {0} ; ", date.Date);
        //            return Query;
        //        //PULLS MOVIE INFO AND TIME(CAN INCLUDE THEATER IN LATER QUERY) FOR BEFORE A SPCIFIC DATE--
        //        case 1:
        //            Query = String.Format("SELECT * FROM Schedule S LEFT OUTER JOIN Calendar C ON S.ScheduleID = C.Calendar ID LEFT OUT JOIN Movie M ON S.movie_id = M.movie_id WHERE C.Date < { 0} ;", date.Date);
        //            return Query;
        //        //PULLS MOVIE INFO AND TIME(CAN INCLUDE THEATER IN LATER QUERY) FOR ON A SPCIFIC DATE--
        //        case 2:
        //            Query = String.Format("SELECT * FROM Schedule S LEFT OUTER JOIN Calendar C ON S.ScheduleID = C.Calendar ID LEFT OUT JOIN Movie M ON S.movie_id = M.movie_id WHERE C.Date = { 0}; ", date.Date);
        //            return Query;
        //        default:
        //            return Query;
        //    }
        //}
        //internal static string QuerySelect(DateTime start, DateTime end)
        //{
        //    //--PULLS MOVIE INFO AND TIME(CAN INCLUDE THEATER IN LATER QUERY) FOR FROM {0} to {1}--
        //    String Query = String.Format("SELECT *FROM Schedule S LEFT OUTER JOIN Calendar C ON S.ScheduleID = C.Calendar ID LEFT OUTER JOIN Movie M ON S.movie_id = M.movie_id WHERE C.Date >= {0} AND C.DATE <= {1} ;", start.Date, end.Date);
        //    return Query;
           
        //}
        //internal static string QuerySelect(int QueryNum, DateTime date, DateTime time ) {
        //    String Query = "";

        //    switch (QueryNum)
        //    {
        //        //--PULLS MOVIE INFO AND TIME(CAN INCLUDE THEATER IN LATER QUERY) FOR AFTER A SPCIFIC DATE{0} AFTER A SPECIFIC TIME{1}--
        //        case 0:
        //            Query = String.Format("SELECT * FROM Schedule S LEFT OUTER JOIN Calendar C ON S.ScheduleID = C.Calendar ID LEFT OUT JOIN Movie M ON S.movie_id = M.movie_id WHERE C.Date > {0} AND S.TIME > {1} ;", date.Date, time.ToUniversalTime());
        //            return Query;
        //        //--PULLS MOVIE INFO AND TIME(CAN INCLUDE THEATER IN LATER QUERY) FOR BEFORE A SPCIFIC DATE{0} AFTER A SPECIFIC TIME{1}--
        //        case 1:
        //            Query = String.Format("SELECT * FROM Schedule S LEFT OUTER JOIN Calendar C ON S.ScheduleID = C.Calendar ID LEFT OUT JOIN Movie M ON S.movie_id = M.movie_id WHERE C.Date < {0} AND S.Time > {1}; ", date.Date, time.ToUniversalTime());
        //            return Query;
        //        //--PULLS MOVIE INFO AND TIME(CAN INCLUDE THEATER IN LATER QUERY) FOR ON A SPCIFIC DATE{0} AFTER A SPECIFIC TIME{1}--
        //        case 2:
        //            Query = String.Format("SELECT * FROM Schedule S LEFT OUTER JOIN Calendar C ON S.ScheduleID = C.Calendar ID LEFT OUT JOIN Movie M ON S.movie_id = M.movie_id WHERE C.Date = {0} AND S.Time > {1}; ", date.Date, time.ToUniversalTime());
        //            return Query;
        //        //--PULLS MOVIE INFO AND TIME(CAN INCLUDE THEATER IN LATER QUERY) FOR AFTER A SPCIFIC DATE{0} BEFORE A SPECIFIC TIME{1}--
        //        case 3:
        //            Query = String.Format("SELECT * FROM Schedule S LEFT OUTER JOIN Calendar C ON S.ScheduleID = C.Calendar ID LEFT OUT JOIN Movie M ON S.movie_id = M.movie_id WHERE C.Date > {0} AND S.TIME < {1}; ", date.Date, time.ToUniversalTime());
        //            return Query;
        //        //--PULLS MOVIE INFO AND TIME(CAN INCLUDE THEATER IN LATER QUERY) FOR BEFORE A SPCIFIC DATE{0} BEFORE A SPECIFIC TIME{1}--
        //        case 4:
        //            Query = String.Format("SELECT * FROM Schedule S LEFT OUTER JOIN Calendar C ON S.ScheduleID = C.Calendar ID LEFT OUT JOIN Movie M ON S.movie_id = M.movie_id WHERE C.Date < {0} AND S.Time < {1}; ", date.Date, time.ToUniversalTime());
        //            return Query;
        //        //--PULLS MOVIE INFO AND TIME(CAN INCLUDE THEATER IN LATER QUERY) FOR ON A SPCIFIC DATE{0} BEFORE A SPECIFIC TIME{1}--
        //        case 5:
        //            Query = String.Format("SELECT * FROM Schedule S LEFT OUTER JOIN Calendar C ON S.ScheduleID = C.Calendar ID LEFT OUT JOIN Movie M ON S.movie_id = M.movie_id WHERE C.Date = {0} AND S.Time < {1}; ", date.Date, time.ToUniversalTime());
        //            return Query;
        //        //--PULLS MOVIE INFO AND TIME(CAN INCLUDE THEATER IN LATER QUERY) FOR AFTER A SPCIFIC DATE{0} AT A SPECIFIC TIME{1}--
        //        case 6:
        //            Query = String.Format("SELECT * FROM Schedule S LEFT OUTER JOIN Calendar C ON S.ScheduleID = C.Calendar ID LEFT OUT JOIN Movie M ON S.movie_id = M.movie_id WHERE C.Date > {0} AND S.TIME = {1}; ", date.Date, time.ToUniversalTime());
        //            return Query;
        //        //--PULLS MOVIE INFO AND TIME(CAN INCLUDE THEATER IN LATER QUERY) FOR BEFORE A SPCIFIC DATE{0} AT A SPECIFIC TIME{1}--
        //        case 7:
        //            Query = String.Format("SELECT * FROM Schedule S LEFT OUTER JOIN Calendar C ON S.ScheduleID = C.Calendar ID LEFT OUT JOIN Movie M ON S.movie_id = M.movie_id WHERE C.Date < {0} AND S.Time = {1}; ", date.Date, time.ToUniversalTime());
        //            return Query;
        //        //--PULLS MOVIE INFO AND TIME(CAN INCLUDE THEATER IN LATER QUERY) FOR ON A SPCIFIC DATE{0} AT A SPECIFIC TIME{1}--
        //        case 8:
        //            Query = String.Format("SELECT * FROM Schedule S LEFT OUTER JOIN Calendar C ON S.ScheduleID = C.Calendar ID LEFT OUT JOIN Movie M ON S.movie_id = M.movie_id WHERE C.Date = {0} AND S.Time = {1}; ", date.Date, time.ToUniversalTime());
        //            return Query;
        //        default:
        //            return Query;
        //    }

        //}
    }
}