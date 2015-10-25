using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using ZOVReminder.GlobalbaseDataSetTableAdapters;

namespace ZOVReminder.Forms
{
    public partial class frmGroupsAndUsers : frmBase
    {
        public frmGroupsAndUsers()
        {
            InitializeComponent();
        }

        public override void CheckForChanges()
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

        public override void UpdateData()
        {
            //zOVReminderGroupsTableAdapter.Update(globalbaseDataSet);
        }

        private void frmGroupsAndUsers_Resize(object sender, EventArgs e)
        {
            gridControlLeftUsers.Width = (ClientSize.Width - panelMiddle.Width)/2;
        }

        private void frmGroupsAndUsers_Load(object sender, EventArgs e)
        {
            GlobalbaseDataSetTableAdapters.ZOVReminderGroupsTableAdapter zovReminderGroupsTableAdapter = new ZOVReminderGroupsTableAdapter();
            GlobalbaseDataSet globalbaseDataSet = new GlobalbaseDataSet();

            zovReminderGroupsTableAdapter.Fill(globalbaseDataSet.ZOVReminderGroups);
            
            foreach (var groupName in globalbaseDataSet.ZOVReminderGroups)
            {
                comboBoxGroups.Properties.Items.Add(groupName.Name);
            }
        }

        private void comboBoxGroups_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

    }
}
