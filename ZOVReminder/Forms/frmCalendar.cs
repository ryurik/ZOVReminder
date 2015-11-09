using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.Office.Utils;
using DevExpress.XtraScheduler;
using DevExpress.XtraScheduler.Commands;
using ZOVReminder.Forms;

namespace ZOVReminder
{
    public partial class frmCalendar : FrmBase
    {
        private object locker = new object();
        private GlobalbaseDataSet newDs = new GlobalbaseDataSet();
        private DateTime lastEditDate = DateTime.MinValue;


        private DateTime lastApdateDateTime
        {
            get
            {
                if ((globalbaseDataSet != null) && (globalbaseDataSet.ZOVAppointments != null) &&
                    (globalbaseDataSet.ZOVAppointments.Select(x => x.LastEditTime).Any()))
                {
                    return globalbaseDataSet.ZOVAppointments.Select(x => x.LastEditTime).Max();
                }
                return DateTime.MinValue;
            }
        }

        public frmCalendar()
        {
            InitializeComponent();
            //searchAppointments.Client = mainSchedulerControl;
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            mainSchedulerControl.Start = DateTime.Now;
            mainSchedulerControl.ActiveViewType = DevExpress.XtraScheduler.SchedulerViewType.FullWeek;
            var a = new SwitchShowWorkTimeOnlyCommand(mainSchedulerControl);
            a.Execute();
             
            mainSchedulerStorage.AppointmentsChanged += OnAppointmentChangedInsertedDeleted;
            mainSchedulerStorage.AppointmentsInserted += OnAppointmentChangedInsertedDeleted;
            mainSchedulerStorage.AppointmentsDeleted += OnAppointmentChangedInsertedDeleted;

            Debug.WriteLine(taZOVAppointments.Connection);
            
            taZOVAppointments.Fill(globalbaseDataSet.ZOVAppointments);
            taZOVResources.Fill(globalbaseDataSet.ZOVResources);
            lastEditDate = lastApdateDateTime;
            timerMain.Start();



            SetSchedulerControlSecurity();
        }

        private void SetSchedulerControlSecurity()
        {
            ribbonPageSettings.Visible = Program.Security.IsAdmin;
            appointmentRibbonPage.Visible = !Program.Security.ReadOnly;
            actionsRibbonPageGroup.Visible = !Program.Security.ReadOnly;
            appointmentRibbonPageGroupHome.Visible = !Program.Security.ReadOnly;
            mainSchedulerControl.OptionsCustomization.AllowAppointmentCopy = (Program.Security.ReadOnly ? UsedAppointmentType.None : UsedAppointmentType.All);
            mainSchedulerControl.OptionsCustomization.AllowAppointmentDelete = (Program.Security.ReadOnly ? UsedAppointmentType.None : UsedAppointmentType.All);
            mainSchedulerControl.OptionsCustomization.AllowAppointmentEdit = (Program.Security.ReadOnly ? UsedAppointmentType.None : UsedAppointmentType.All);
            mainSchedulerControl.OptionsCustomization.AllowAppointmentResize = (Program.Security.ReadOnly ? UsedAppointmentType.None : UsedAppointmentType.All);
            mainSchedulerControl.OptionsCustomization.AllowAppointmentConflicts = (Program.Security.ReadOnly ? AppointmentConflictsMode.Forbidden : AppointmentConflictsMode.Allowed);
            mainSchedulerControl.OptionsCustomization.AllowAppointmentCreate = (Program.Security.ReadOnly ? UsedAppointmentType.None : UsedAppointmentType.All);
            mainSchedulerControl.OptionsCustomization.AllowAppointmentCreate = (Program.Security.ReadOnly ? UsedAppointmentType.None : UsedAppointmentType.All);
            mainSchedulerControl.OptionsCustomization.AllowAppointmentCreate = (Program.Security.ReadOnly ? UsedAppointmentType.None : UsedAppointmentType.All);
        }

        private void OnAppointmentChangedInsertedDeleted(object sender, PersistentObjectsEventArgs e)
        {

            taZOVAppointments.Update(this.globalbaseDataSet.ZOVAppointments);
            globalbaseDataSet.AcceptChanges();
            if (!timerMain.Enabled)
            {
                timerMain.Start();
            }
        }

        private void timerMain_Tick(object sender, EventArgs e)
        {
            timerMain.Enabled = false;
            newDs.ZOVAppointments.Clear();
            newDs.ZOVAppointments.AcceptChanges();
            //OnAppointmentChangedInsertedDeleted(null, null);
            var dt = globalbaseDataSet.ZOVAppointments.GetChanges();
            if ((dt != null) && (dt.Rows.Count > 0))
            {
                foreach (DataRow changesRow in dt.Rows)
                {
                    changesRow["ZOVReminderUsersID"] = Program.Security.ZOVReminderUsersID;
                }
                dt.AcceptChanges();
                //zOVAppointmentsTableAdapter.Update(globalbaseDataSet.ZOVAppointments.GetChanges() as GlobalbaseDataSet.ZOVAppointmentsDataTable);
                taZOVAppointments.Update(dt as GlobalbaseDataSet.ZOVAppointmentsDataTable);
            }
            taZOVAppointments.Fill(newDs.ZOVAppointments);
            lock (locker)
            {
                globalbaseDataSet.ZOVAppointments.Merge(newDs.ZOVAppointments, false);
                globalbaseDataSet.AcceptChanges();
            }
            if (lastEditDate < lastApdateDateTime /*globalbaseDataSet.ZOVAppointments.Select(x => x.LastEditTime).Max()*/)
            {
                var q = from a in globalbaseDataSet.ZOVAppointments
                    where a.LastEditTime > lastEditDate
                    orderby a.LastEditTime descending
                    select a;

                var qq = globalbaseDataSet.ZOVAppointments.Where(x => x.LastEditTime > lastEditDate).ToArray();

                foreach (var c in q)
                {
                    string s = c.Subject + Environment.NewLine + c.Subject + Environment.NewLine + c.Description +
                        Environment.NewLine + c.StartDate.ToShortTimeString();
                    if ((MdiParent != null) && (MdiParent is FrmMainMDI))
                    {
                        var frmMainMdi = MdiParent as FrmMainMDI;
                        if (frmMainMdi != null) frmMainMdi.ShowToolTip(s, 1000);
                    }
                }
                //lastEditDate = globalbaseDataSet.ZOVAppointments.Select(x => x.LastEditTime).Max();
                lastEditDate = lastApdateDateTime;
            }
            timerMain.Enabled = true;
        }

        private void mainSchedulerControl_EditAppointmentFormShowing(object sender, AppointmentFormEventArgs e)
        {
            if (Program.Security.ReadOnly)
            {
                e.Handled = true;
                return;
            }

            timerMain.Stop();
            SchedulerControl scheduler = ((SchedulerControl)(sender));
            FrmCustomAppointmentForm form = new FrmCustomAppointmentForm(scheduler, e.Appointment, e.OpenRecurrenceForm);
            try
            {
                e.DialogResult = form.ShowDialog();
                e.Handled = true;
            }
            finally
            {
                timerMain.Start();
                form.Dispose();
            }
        }

        private void barButtonItemPasswords_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            var frmPass = new frmPasswords();
            frmPass.ShowDialog();
        }

        private void frmCalendar_Resize(object sender, EventArgs e)
        {
            btnClose.Left = this.Width - btnClose.Width - 20;
            btnApply.Left = btnClose.Left - btnApply.Width - 20;
        }
    }
}
