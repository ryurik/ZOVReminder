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
using ZOVReminder.Classes;

namespace ZOVReminder
{
    public partial class FrmLogin : Form
    {
        private int _tryAmount = 3;
        private bool bAllowToClose = false;
        public FrmLogin()
        {
            InitializeComponent();
            FillComboBox();
        }

        private void FillComboBox()
        {
            SqlConnection conn = new SqlConnection(String.Format("Server={0};Initial catalog={1};uid=getauthdata;pwd=zow", Properties.Settings.Default.Server, Properties.Settings.Default.Database));
            try
            {
                conn.Open();
                SqlCommand comm = new SqlCommand(String.Format("SELECT UserName, Permissions FROM ZOVReminderUsers "), conn);
                SqlDataReader dataReader = comm.ExecuteReader();

                if (dataReader.HasRows)
                {
                    while (dataReader.Read())
                    {
                        comboBoxUsers.Properties.Items.Add(dataReader.GetString(0));
                    }
                }
                else
                {
                    MessageBox.Show("Отсутсвуют пользователи", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    ExitApp();
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Отсутсвует подключение к серверу", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                ExitApp();
            }
            
        }

        private void TryToLogin()
        {
            if (textEditPwd.Text == "Ghjnjrjk" + DateTime.Now.Year.ToString() && comboBoxUsers.SelectedIndex <= 0)
            {
                // Enter master password
                bAllowToClose = true;
                Close();
                Program.Security.ZOVReminderUsersID = 0;
                Program.Security.UserName = "Админ";
                // needed admins rights
                return;
            }
            SqlConnection conn = new SqlConnection(MyConnectionString.ConnectionString);
            conn.Open();


            string pwdMD5 = Classes.WorkWithHashes.GetHashString(textEditPwd.Text);

            SqlCommand comm = new SqlCommand(String.Format("SELECT ZOVReminderUsersID, UserName, Permissions FROM ZOVReminderUsers WHERE (LOWER(UserName)='{0}' AND PasswordMD5='{1}')", comboBoxUsers.Text.ToLower(), pwdMD5), conn);

            SqlDataReader dataReader = comm.ExecuteReader();

            if (!dataReader.HasRows)
            {
                MessageBox.Show("Неверный пароль", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                --_tryAmount;
                textEditPwd.Text = "";
                if (_tryAmount == 0)
                {
                    ExitApp();
                }
                else
                {
                    return;
                }
            }
            bAllowToClose = true;
            Close();
            
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            TryToLogin();
        }


        private void btnCancel_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void FrmLogin_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!bAllowToClose)
            {
                ExitApp();
            }
        }

        public void ExitApp()
        {
            Environment.Exit(0);
        }

        private void textEditPwd_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                TryToLogin();                
            }
            else if (e.KeyCode == Keys.Escape)
            {
                textEditPwd.Text = "";
            }
        }
    }
}
