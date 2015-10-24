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
    public partial class frmGroupsAndUsers : frmBase
    {
        public frmGroupsAndUsers()
        {
            InitializeComponent();
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

        private void CheckForChanges()
        {
            //var dt = globalbaseDataSet.ZOVReminderGroups.GetChanges();
            //if ((dt != null) && (dt.Rows.Count > 0))
            //{
            //    if (MessageBox.Show("Данные были изменены. Сохранить?", "Вопрос", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            //    {
            //        UpdateData();
            //    }
            //}
        }

        private void UpdateData()
        {
            //zOVReminderGroupsTableAdapter.Update(globalbaseDataSet);
        }

        private void frmGroups_FormClosing(object sender, FormClosingEventArgs e)
        {
            CheckForChanges();
        }
    }
}
