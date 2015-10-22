using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraPrinting.Native;
using ZOVReminder.Classes;

namespace ZOVReminder
{
    public partial class frmPasswords : Form
    {

        public frmPasswords()
        {
            InitializeComponent();
        }

        public frmPasswords(int i)
        {
            InitializeComponent();
        }

        private void frmPasswords_Load(object sender, EventArgs e)
        {
            FillComboBox();
        }

        private void FillComboBox()
        {
            SqlConnection conn = new SqlConnection(MyConnectionString.ConnectionString);
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
            SqlConnection conn = new SqlConnection(MyConnectionString.ConnectionString);
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

        private void textEditPassConfirm_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Enter:
                    ApplyPassword();
                    break;
                case Keys.Escape:
                    textEditPassConfirm.Text = "";
                    break;
            }
        }

        private void textEditPassConfirm_EditValueChanged(object sender, EventArgs e)
        {
            if (textEditPassConfirm.Text == "")
            {
                textEditPassConfirm.BackColor = Color.White;
                return;
            }
            textEditPassConfirm.BackColor = textEditPassConfirm.Text.Equals(textEditPwd.Text) ? Color.White : Color.Tomato;
            btnApply.Enabled = textEditPassConfirm.Text.Equals(textEditPwd.Text) && !textEditPassConfirm.Text.IsEmpty();
        }

        private void btnApply_Click(object sender, EventArgs e)
        {
            ApplyPassword();
        }

        private void ApplyPassword()
        {
            if (!textEditPwd.Text.Equals(textEditPassConfirm.Text))
            {
                return;
            }

            SqlConnection conn = new SqlConnection(MyConnectionString.ConnectionString);
            try
            {
                conn.Open();
                SqlCommand comm =
                    new SqlCommand(
                        String.Format(
                            "UPDATE ZOVRU " +
                            "  SET PasswordMD5 = '{1}'" +
                            "  FROM ZOVReminderUsers ZOVRU " +
                            "  WHERE (UserName LIKE '{0}')",
                            comboBoxUsers.Text, Classes.WorkWithHashes.GetHashString(textEditPwd.Text)), conn);
                
                comm.ExecuteScalar();

                textEditPwd.Text = "";
                textEditPassConfirm.Text = "";

                MessageBox.Show(String.Format("Пароль для'{0}' был успешно обнволен", comboBoxUsers.Text), "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            catch (Exception E)
            {
                MessageBox.Show(String.Format("Ошибка: {0}", E.Message), "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
        }
    }
}
