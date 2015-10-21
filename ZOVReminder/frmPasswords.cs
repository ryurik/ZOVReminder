using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ZOVReminder
{
    public partial class frmPasswords : Form
    {
        public frmPasswords()
        {
            InitializeComponent();
        }

        private void frmPasswords_Load(object sender, EventArgs e)
        {
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
                    Environment.Exit(0);
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Отсутсвует подключение к серверу", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Environment.Exit(0);
            }

        }

        private void btnCheck_Click(object sender, EventArgs e)
        {
            CheckCurrentUserPassword();
        }

        private void CheckCurrentUserPassword()
        {
            if (comboBoxUsers.Text == "")
            {
                MessageBox.Show("Выберите пользователя", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            SqlConnection conn = new SqlConnection(String.Format("Server={0};Initial catalog={1};uid=getauthdata;pwd=zow", Properties.Settings.Default.Server, Properties.Settings.Default.Database));
            try
            {
                conn.Open();
                SqlCommand comm =
                    new SqlCommand(
                        String.Format(
                            "SELECT ZOVReminderUsersID, UserName, PasswordMD5 FROM ZOVReminderUsers WHERE (UserName LIKE '{0}') --AND (PasswordMD5 LIKE '{1}')",
                            comboBoxUsers.Text, Classes.WorkWithHashes.GetHashString(textEditPwd.Text)), conn);
                SqlDataReader dataReader = comm.ExecuteReader();

                if (dataReader.HasRows)
                {
                    while (dataReader.Read())
                    {
                        if (dataReader.GetString(0) == Classes.WorkWithHashes.GetHashString(textEditPwd.Text))
                        {
                            MessageBox.Show("Ок", "Инфо", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("Пароль неправильный", "Инфо", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                }
                else
                {
                    MessageBox.Show(String.Format("Нет такого пользователя\n{0}", comboBoxUsers.Text), "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                }
            }
            catch (Exception E)
            {
                MessageBox.Show(String.Format("Ошибка: {0}", E.Message), "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
        }

    }
}
