using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ZOVReminder.Forms
{
    public partial class FrmUsers : FrmBase
    {
        public FrmUsers()
        {
            InitializeComponent();
        }

        private void frmUsers_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'globalbaseDataSet.ZOVReminderUsers' table. You can move, or remove it, as needed.
            this.zOVReminderUsersTableAdapter.Fill(this.globalbaseDataSet.ZOVReminderUsers);
        }

        private void simpleButtonApply_Click(object sender, EventArgs e)
        {
            UpdateData();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            CheckForChanges();
            Close();
        }

        public override void CheckForChanges()
        {
            var dt = globalbaseDataSet.ZOVReminderGroups.GetChanges();
            if ((dt != null) && (dt.Rows.Count > 0))
            {
                if (MessageBox.Show("Данные были изменены. Сохранить?", "Вопрос", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    UpdateData();
                }
            }
        }

        public override void UpdateData()
        {
            zOVReminderUsersTableAdapter.Update(globalbaseDataSet);
        }

    }
}
