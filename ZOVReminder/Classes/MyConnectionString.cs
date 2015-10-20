using System;
using System.Collections.Generic;
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
    }
}
