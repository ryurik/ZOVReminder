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
    public partial class frmGroups : frmBase
    {
        public frmGroups()
        {
            InitializeComponent();
        }

        private void frmGroups_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'globalbaseDataSet.ZOVReminderGroups' table. You can move, or remove it, as needed.
            this.zOVReminderGroupsTableAdapter.Fill(this.globalbaseDataSet.ZOVReminderGroups);
            zOVReminderGroupsBindingSource.Filter = "ZOVReminderGroupsID > 5";
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
            var dt = globalbaseDataSet.ZOVReminderGroups.GetChanges();
            if ((dt != null) && (dt.Rows.Count > 0))
            {
                if (MessageBox.Show("Данные были изменены. Сохранить?", "Вопрос", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    UpdateData();
                }
            }
        }

        private void UpdateData()
        {
            zOVReminderGroupsTableAdapter.Update(globalbaseDataSet);
        }

        private void frmGroups_FormClosing(object sender, FormClosingEventArgs e)
        {
            CheckForChanges();
        }

        private void panelControlMain_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
