﻿using System;
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
            this.taZOVReminderUsers.Fill(this.globalbaseDataSet.ZOVReminderUsers);
        }

        public override void CheckForChanges()
        {
            var dt = globalbaseDataSet.ZOVReminderUsers.GetChanges();
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
            taZOVReminderUsers.Update(globalbaseDataSet);
        }

        private void vwUsersForTree_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            int rowHandle = e.FocusedRowHandle;
            int ZOVReminderUsersID = (int)vwUsersForTree.GetDataRow(rowHandle)["ZOVReminderUsersID"];
            taSP_GetTreeList.Fill(globalbaseDataSet.SP_GetTreeList, ZOVReminderUsersID);
        }

        private void treeListUsers_AfterCheckNode(object sender, DevExpress.XtraTreeList.NodeEventArgs e)
        {
            if (e.Node.Checked)
            {
                if (e.Node.HasChildren)
                {
                    e.Node.ExpandAll();
                }
                e.Node.CheckAll();
            }
            else
            {
                e.Node.UncheckAll();
            }
        }

        private void btnApply_Click(object sender, EventArgs e)
        {
            var allCheckedNodes = treeListUsers.GetAllCheckedNodes();
            Dictionary<int, string> userInfo = new Dictionary<int, string>();
            foreach (var cn in allCheckedNodes)
            {
                if (!cn.HasChildren)
                {
                    string sid = cn.GetValue("Id").ToString();
                    string spid = cn.GetValue("ParentId").ToString();
                    string sname  = cn.GetValue("Name").ToString();

                    int id = 0;
                    int pid = 0;
                    if (sid != null)
                    {
                        id = int.Parse(sid);
                    }

                    if (spid != null)
                    {
                        pid = int.Parse(spid);
                    }

                    if (pid * id != 0)
                    {
                        int userId = (id - pid*1000) - 10000;
                        if (!userInfo.ContainsKey(userId))
                        {
                            userInfo.Add(userId, sname);
                        }
                    }
                }
            }
            // Create Appointments for this ID
            
            StringBuilder builder = new StringBuilder();
            foreach (KeyValuePair<int, string> pair in userInfo)
            {
                builder.Append(pair.Key).Append(":").Append(pair.Value).Append(Environment.NewLine);
            }
            string result = builder.ToString();
            // Remove the final delimiter
            result = result.TrimEnd(Environment.NewLine.ToCharArray());
            if (tabMain.SelectedTabPageIndex == 1)
                MessageBox.Show((result != "" ? result : "Никого не выбрал чтоли"));

        }
    }
}
