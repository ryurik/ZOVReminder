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

        public static SqlConnection Connection;

        static MyConnectionString() 
        {
            Connection = new SqlConnection(ConnectionString);
            try
            {
                Connection.Open();
            }
            catch
            {
                // ignored
            }
        }

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
                if (Connection.State != ConnectionState.Open)
                    Connection.Open();

                SqlCommand comm = new SqlCommand(commandText, Connection);

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
                if (Connection.State != ConnectionState.Open)
                    Connection.Open();


                SqlCommand comm = new SqlCommand(commandText, Connection);

                SqlDataReader dataReader = comm.ExecuteReader();

//                if (!dataReader.HasRows)
                return dataReader;
            }
            catch (Exception)
            {
                return null;
            }
        }

        public static DateTime LastUpdateDateTime(int userId = 0)
        {
            {
                if ((Connection == null) || (userId == 0))
                {
                    return DateTime.MinValue;
                }

                if (Connection.State != ConnectionState.Open)
                {
                    Connection.Open();
                }
                SqlCommand comm = new SqlCommand(String.Format("SELECT [dbo].[FN_GetLastUpdateForUser]({0}) 'LastEditTime'", userId), Connection);

                SqlDataReader dataReader = comm.ExecuteReader();

                if (!dataReader.HasRows)
                {
                    return DateTime.MinValue;
                }
                dataReader.Read();

                try
                {
                    DateTime dt = dataReader.GetDateTime(0);
                    dataReader.Close();
                    return dt;
                }
                catch (Exception)
                {
                    return DateTime.MinValue;
                }
            }
        }

    }
}
