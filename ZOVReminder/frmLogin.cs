using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Security.Cryptography;  

namespace ZOVReminder
{
    public partial class FrmLogin : Form
    {
        private int tryAmount = 3;
        public FrmLogin()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(String.Format("Server={0};Initial catalog={1};uid=getauthdata;pwd=zow", Properties.Settings.Default.Server, Properties.Settings.Default.Database));
            conn.Open();


            string pwdMD5 = GetHashString(textEditPwd.Text);

            SqlCommand comm = new SqlCommand(String.Format("SELECT UserName, Permissions FROM ZOVReminderUsers WHERE (LCase(UserName)={0} AND PasswordMD5={1})", textEditUser.Text.ToLower(), pwdMD5), conn);

            SqlDataReader dataReader = comm.ExecuteReader();
        }

        string GetHashString(string s)
        {
            //переводим строку в байт-массим  
            byte[] bytes = Encoding.Unicode.GetBytes(s);

            //создаем объект для получения средст шифрования  
            MD5CryptoServiceProvider csp = new MD5CryptoServiceProvider();

            //вычисляем хеш-представление в байтах  
            byte[] byteHash = csp.ComputeHash(bytes);

            string hash = string.Empty;

            //формируем одну цельную строку из массива  
            foreach (byte b in byteHash)
                hash += string.Format("{0:x2}", b);

            return hash;
        }  
    }
}
