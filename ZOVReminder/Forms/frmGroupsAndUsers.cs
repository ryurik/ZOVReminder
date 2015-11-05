using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using ZOVReminder.Classes;
using ZOVReminder.GlobalbaseDataSetTableAdapters;

namespace ZOVReminder.Forms
{
    public partial class FrmGroupsAndUsers : FrmBase
    {
        private int _groupId;

        public FrmGroupsAndUsers()
        {
            InitializeComponent();
            frmGroupsAndUsers_Resize(this, null);
        }

        public int GroupId
        {
            get { return _groupId; }
            set
            {
                _groupId = value;
                RefreshDsForGroup();
            }
        }

        private void frmGroupsAndUsers_Resize(object sender, EventArgs e)
        {
            panelControlRight.Width = (ClientSize.Width - panelMiddle.Width)/2;
            simpleButtonFromLeftToRight.Top = panelMiddle.Size.Height / 2 - simpleButtonFromLeftToRight.Height - 5;
            simpleButtonFromRightToLeft.Top = panelMiddle.Size.Height / 2 + 5;
        }

        private void frmGroupsAndUsers_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'globalbaseDataSet.ZOVReminderGroups' table. You can move, or remove it, as needed.
            this.taReminderGroups.FillBy(this.globalbaseDataSet.ZOVReminderGroups);
            // TODO: This line of code loads data into the 'globalbaseDataSet.ZOVReminderUsers' table. You can move, or remove it, as needed.
            this.taUsers.Fill(this.globalbaseDataSet.ZOVReminderUsers);
            // TODO: This line of code loads data into the 'globalbaseDataSet.ZOVReminderUsersAndGroups' table. You can move, or remove it, as needed.
            this.taUsersAndGroups.Fill(this.globalbaseDataSet.ZOVReminderUsersAndGroups);
            if (comboBoxGroups.SelectedValue != null)
            {
                GroupId = (int)comboBoxGroups.SelectedValue;
            }
        }

        private void comboBoxGroups_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxGroups.SelectedValue != null)
            {
                GroupId = (int)comboBoxGroups.SelectedValue;
            }
            else
            {
                return;
            }
        }

        private void RefreshDsForGroup()
        {
            bsUserAndGroups.Filter = String.Format("ZOVReminderGroupsID = {0}", _groupId);

            taUsersForGroup.Fill(globalbaseDataSet.ZOVReminderUsersForGroups, _groupId);
        }

        private void FrmGroupsAndUsers_Activated(object sender, EventArgs e)
        {
            frmGroupsAndUsers_Resize(sender, e);
        }

        private void simpleButtonFromLeftToRight_Click(object sender, EventArgs e)
        {
            AddSelectedUsersToGroup();
        }

        private void AddSelectedUsersToGroup()
        {
            for (int i = 0; i < gridViewAllUsers.SelectedRowsCount; i++)
            {
                if (gridViewAllUsers.GetSelectedRows()[i] >= 0)
                {
                    AddUserToGroup((int)(gridViewAllUsers.GetDataRow(gridViewAllUsers.GetSelectedRows()[i]))["ZOVReminderUsersID"], false);
                }
            }
            RefreshDsForGroup();
        }

        private void AddUserToGroup(int userID, bool readOnly)
        {

            if ((GroupId != 0) && (userID != 0))
            {
                globalbaseDataSet.ZOVReminderUsersAndGroups.AddZOVReminderUsersAndGroupsRow(GroupId, userID, readOnly);
                taUsersAndGroups.Update(globalbaseDataSet.ZOVReminderUsersAndGroups);
            }
        }

        private void gridControlAllUsers_DoubleClick(object sender, EventArgs e)
        {
            AddSelectedUsersToGroup();
        }

        private void simpleButtonFromRightToLeft_Click(object sender, EventArgs e)
        {
            RemoveSelectedUsersFromGroup();
        }

        private void RemoveSelectedUsersFromGroup()
        {
            for (int i = 0; i < gridViewUsersAndGroup.SelectedRowsCount; i++)
            {
                if (gridViewUsersAndGroup.GetSelectedRows()[i] >= 0)
                {
                    DeleteUserFromGroupById((int)(gridViewUsersAndGroup.GetDataRow(gridViewUsersAndGroup.GetSelectedRows()[i]))["ZOVReminderUsersAndGroupsID"]);
                }
            }
            taUsersAndGroups.Fill(globalbaseDataSet.ZOVReminderUsersAndGroups);
            RefreshDsForGroup();
        }

        private void DeleteUserFromGroupById(int zovReminderUsersAndGroupsID)
        {
            taUsersAndGroups.DeleteByID(zovReminderUsersAndGroupsID);
        }

        private void zOVReminderUsersAndGroupsGridControl_DoubleClick(object sender, EventArgs e)
        {
            RemoveSelectedUsersFromGroup();
        }

        public override void CheckForChanges()
        {
            var dt = globalbaseDataSet.ZOVReminderUsersAndGroups.GetChanges();
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
            taUsersAndGroups.Update(globalbaseDataSet);
        }

    }
}
