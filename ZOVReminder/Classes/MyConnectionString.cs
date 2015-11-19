using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;

namespace ZOVReminder.Classes
{
    public static class MyConnectionString
    {
        private static string _Server = Properties.Settings.Default.Server;
        private static string _InitialCatalog = Properties.Settings.Default.Database;
        private static string _uid = "getauthdata";
        private static string _pwd = "zow";
        
        public static string ConnectionString
        {
            get
            {
                return String.Format("Server={0};Initial catalog={1};uid={2};pwd={3}", _Server, _InitialCatalog, _uid, _pwd);
            }
        }


        public static string ExecuteScalarQuery(string commandText)
        {
            try
            {
                SqlConnection conn = new SqlConnection(ConnectionString);
                conn.Open();


                SqlCommand comm = new SqlCommand(commandText, conn);

                comm.ExecuteScalar();
                return "";
            }
            catch (Exception E)
            {
                return E.Message;
            }
        }

        public static SqlDataReader ExecuteQuery(string commandText)
        {
            try
            {
                SqlConnection conn = new SqlConnection(ConnectionString);
                conn.Open();


                SqlCommand comm = new SqlCommand(commandText, conn);

                SqlDataReader dataReader = comm.ExecuteReader();

//                if (!dataReader.HasRows)
                return dataReader;
            }
            catch (Exception)
            {
                return null;
            }
        }
    }
}
