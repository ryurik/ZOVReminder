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
    }
}
