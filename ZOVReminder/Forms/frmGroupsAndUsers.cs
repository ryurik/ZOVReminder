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
    public partial class FrmGroupsAndUsers : FrmBase
    {
        public FrmGroupsAndUsers()
        {
            InitializeComponent();
            frmGroupsAndUsers_Resize(this, null);
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
            panelControlRight.Width = (ClientSize.Width - panelMiddle.Width)/2;
            simpleButtonFromLeftToRight.Top = panelMiddle.Height/2 - simpleButtonFromLeftToRight.Height - 5;
            simpleButtonFromRightToLeft.Top = panelMiddle.Height / 2 + 5;
        }

        private void frmGroupsAndUsers_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'globalbaseDataSet.ZOVReminderGroups' table. You can move, or remove it, as needed.
            this.zOVReminderGroupsTableAdapter.FillBy(this.globalbaseDataSet.ZOVReminderGroups);
            // TODO: This line of code loads data into the 'globalbaseDataSet.ZOVReminderUsers' table. You can move, or remove it, as needed.
            this.taUsers.Fill(this.globalbaseDataSet.ZOVReminderUsers);
            // TODO: This line of code loads data into the 'globalbaseDataSet.ZOVReminderUsersAndGroups' table. You can move, or remove it, as needed.
            this.taUsersAndGroups.Fill(this.globalbaseDataSet.ZOVReminderUsersAndGroups);

        }

        private void comboBoxGroups_SelectedIndexChanged(object sender, EventArgs e)
        {
            // bindingSourceUsersAndGroups.Filter = 
            int groupId = 0;
            if (zOVReminderGroupsBindingSource.Current != null)
            {
                 groupId = (int)((DataRowView)zOVReminderGroupsBindingSource.Current)["ZOVReminderGroupsID"];
            }
            else
            {
                return;
            }

            bsUserAndGroupsNotInGroup.Filter = "ZOVReminderGroupsID <> " + groupId.ToString();
            bsUserAndGroups.Filter = "ZOVReminderGroupsID = " + groupId.ToString();

            taUsersForGroup.Fill(globalbaseDataSet.ZOVReminderUsersForGroups, groupId);
        }

        private void FrmGroupsAndUsers_Activated(object sender, EventArgs e)
        {
            frmGroupsAndUsers_Resize(sender, e);
        }

        private void zOVReminderUsersAndGroupsBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.bsUserAndGroups.EndEdit();
            this.tableAdapterManager.UpdateAll(this.globalbaseDataSet);

        }

        private void zOVReminderUsersAndGroupsGridControl_Click(object sender, EventArgs e)
        {

        }

    }
}
