#region Note
/*
{**************************************************************************************************************}
{  This file is automatically created when you open the Scheduler Control smart tag                            }
{  *and click Create Customizable Appointment Dialog.                                                          }
{  It contains a a descendant of the default appointment editing form created by visual inheritance.           }
{  In Visual Studio Designer add an editor that is required to edit your appointment custom field.             }
{  Modify the LoadFormData method to get data from a custom field and fill your editor with data.              }
{  Modify the SaveFormData method to retrieve data from the editor and set the appointment custom field value. }
{  The code that displays this form is automatically inserted                                                  }
{  *in the EditAppointmentFormShowing event handler of the SchedulerControl.                                   }
{                                                                                                              }
{**************************************************************************************************************}
*/
#endregion Note

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraScheduler;
using DevExpress.XtraTreeList.Nodes;
using ZOVReminder.Classes;
using ZOVReminder.GlobalbaseDataSetTableAdapters;

namespace ZOVReminder.Forms
{
    public partial class FrmCustomAppointmentForm : DevExpress.XtraScheduler.UI.AppointmentForm
    {
        private int _zovReminderUsersID;
        private string _zovReminderUsers;

        private bool canCheck;

        private BindingSource bs = new BindingSource();

        public FrmCustomAppointmentForm()
        {
            InitializeComponent();
        }
        public FrmCustomAppointmentForm(DevExpress.XtraScheduler.SchedulerControl control, DevExpress.XtraScheduler.Appointment apt): base(control, apt)
        {
            InitializeComponent();
        }
        public FrmCustomAppointmentForm(DevExpress.XtraScheduler.SchedulerControl control, DevExpress.XtraScheduler.Appointment apt, bool openRecurrenceForm): base(control, apt, openRecurrenceForm)
        {
            InitializeComponent();
        }

        private int GetUserIdByIdAndParentID(int id, int parentId)
        {
            return (id - parentId * 1000) - 10000;
        }
        /// <summary>
        /// Add your code to obtain a custom field value and fill the editor with data.
        /// </summary>
        public override void LoadFormData(DevExpress.XtraScheduler.Appointment appointment)
        {
            base.LoadFormData(appointment);
            canCheck = true;

            //labelUser = appointment.CustomFields["ZOVReminderUsersID"].ToString();
            labelUser.Text = Program.Security.UserName;

            if (appointment.CustomFields["ZOVReminderUsersID"] == null)
            {
                labelUser.Text = "";
                _zovReminderUsersID = Program.Security.ZOVReminderUsersID;
                appointment.CustomFields["ZOVReminderUsersID"] = _zovReminderUsersID;
                appointment.CustomFields["ZOVReminderUsers"] = _zovReminderUsers;
            }
            else if ((appointment.CustomFields["ZOVReminderUsersID"].ToString() != Program.Security.ZOVReminderUsersID.ToString()) && 
                     (Program.Security.ZOVReminderUsersID != 0))
            {
                canCheck = false;
                using (GlobalbaseDataSet.ZOVReminderUsersDataTable zovReminderUsers =
                        new GlobalbaseDataSet.ZOVReminderUsersDataTable())
                {
                    GlobalbaseDataSetTableAdapters.ZOVReminderUsersTableAdapter tableAdapter = new ZOVReminderUsersTableAdapter();
                    tableAdapter.Fill(zovReminderUsers);
                    labelUser.Text = zovReminderUsers.FindByZOVReminderUsersID((int)appointment.CustomFields["ZOVReminderUsersID"])["UserName"].ToString();
                }

            }


            _zovReminderUsersID = Program.Security.ZOVReminderUsersID;
            _zovReminderUsers = (appointment.CustomFields["ZOVReminderUsers"] == null? "" : appointment.CustomFields["ZOVReminderUsers"].ToString());

            taSP_GetTreeList.Fill(globalbaseDataSet.SP_GetTreeList, _zovReminderUsersID);

            // Don't paint TreeList by visual BindingSource
            bs.DataSource = globalbaseDataSet;
            bs.DataMember = "SP_GetTreeList";
            treeList.DataSource = bs;

            if (_zovReminderUsers == "")
                return;
            var pairs = _zovReminderUsers.Split(' ');
            foreach (var p in pairs)
            {
                var sid = p.Split(':');
                int pid = Int32.Parse(sid[1]);
                if (pid != 0)
                {
                    int id = Int32.Parse(sid[0]);
                    if (id != 0)
                    {
//                        id = pid * 1000 + 10000 + id;
                        CheckNodeByIdAndPid(treeList.Nodes, id, pid);
                    }
                }
            }
        }

        private bool CheckNodeByIdAndPid(TreeListNodes treeListNodes, int id, int pid)
        {
            foreach (TreeListNode cn in treeListNodes)
            {
                if (cn.HasChildren)
                {
                    if (CheckNodeByIdAndPid(cn.Nodes, id, pid))
                    {
                        cn.ExpandAll();
                    }
                }
                else
                //if ((cn.Id == id) && (cn.ParentNode.Id == pid))
                {
                    if (cn.GetValue("Id").ToString() == id.ToString())
                    {
                        cn.Checked = true;
                        return true;
                    }
                }
            }
            return false;
        }


        /// <summary>
        /// Add your code to retrieve a value from the editor and set the custom appointment field.
        /// </summary>
        public override bool SaveFormData(DevExpress.XtraScheduler.Appointment appointment)
        {
            // Clear all appointments for UnCheked, must clear Trigger
            // MyConnectionString.ExecuteScalarQuery(String.Format("EXEC SP_ClearAppointmentsForUsers @UniqueID = {0};", appointment.Id));
            // if we try to change foreign appointment

            if ((tbSubject.Text == "") && (MessageBox.Show("Поле Тема не заполнено, продолжить?", "Вопрос", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No))
            {
                return false;
            }

            if ((Program.Security.ZOVReminderUsersID != 0) && (appointment.CustomFields["ZOVReminderUsersID"] != null) && (appointment.CustomFields["ZOVReminderUsersID"].ToString() != Program.Security.ZOVReminderUsersID.ToString()))
            {
                return false;
            }

            var allCheckedNodes = treeList.GetAllCheckedNodes();
            
            Dictionary<int, int> userInfo = new Dictionary<int, int>();
            foreach (var cn in allCheckedNodes)
            {
                if (!cn.HasChildren)
                {
                    string sid = cn.GetValue("Id").ToString();
                    string spid = cn.GetValue("ParentId").ToString();
                    string sname = cn.GetValue("Name").ToString();

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
                        // int userId = GetUserIdByIdAndParentID(id, pid); 
                        userInfo.Add(id, pid);
                    }
                }
            }

            StringBuilder builder = new StringBuilder();
            foreach (KeyValuePair<int, int> pair in userInfo)
            {
                builder.Append(pair.Key).Append(":").Append(pair.Value).Append(" ");
            }
            string result = builder.ToString().Trim(' ');

            appointment.CustomFields["ZOVReminderUsersID"] = _zovReminderUsersID; //Program.Security.ZOVReminderUsersID;
            appointment.CustomFields["ZOVReminderUsers"] = result;
            if (result == "")
            {
                if (MessageBox.Show("Список получателей пуст, продолжить?", "Вопрос", MessageBoxButtons.YesNo, MessageBoxIcon.Question) ==
                    DialogResult.Yes)
                {
                    return base.SaveFormData(appointment);
                }
                else
                {
                    return false;
                }

            }
            return base.SaveFormData(appointment);
        }
        /// <summary>
        /// Add your code to notify that any custom field is changed. Return true if a custom field is changed, otherwise false.
        /// </summary>
        public override bool IsAppointmentChanged(DevExpress.XtraScheduler.Appointment appointment)
        {
            if ((_zovReminderUsersID.ToString() == appointment.CustomFields["ZOVReminderUsersID"].ToString()) &&
                 (_zovReminderUsers == appointment.CustomFields["ZOVReminderUsers"].ToString()))
                return false;
            if ((_zovReminderUsersID.ToString() != appointment.CustomFields["ZOVReminderUsersID"].ToString()) &&
                (appointment.CustomFields["ZOVReminderUsersID"].ToString() != "") &&
                (Program.Security.ZOVReminderUsersID != 0))  // Super Admin
                return false;
            return true;
        }

        /// <summary>
        /// Add your code to notify that any custom field is changed. Return true if a custom field is changed, otherwise false.
        /// </summary>
        private void treeList_AfterCheckNode(object sender, DevExpress.XtraTreeList.NodeEventArgs e)
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

        private void FrmCustomAppointmentForm_Load(object sender, EventArgs e)
        {
        }

        private void treeList_CustomDrawNodeCheckBox(object sender, DevExpress.XtraTreeList.CustomDrawNodeCheckBoxEventArgs e)
        {
            if (!canCheck)
                e.ObjectArgs.State = DevExpress.Utils.Drawing.ObjectState.Disabled;
        }

        private void treeList_BeforeCheckNode(object sender, DevExpress.XtraTreeList.CheckNodeEventArgs e)
        {
            if (!canCheck)
            {
                e.State = e.PrevState;
            }
        }

        private void btnOk_Click(object sender, EventArgs e)
        {

        }
    }
}
