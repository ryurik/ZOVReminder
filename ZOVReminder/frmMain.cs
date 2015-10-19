using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraScheduler;
using DevExpress.XtraScheduler.Commands;

namespace ZOVReminder
{
    public partial class frmMain : Form
    {
        private object locker = new object();
        private GlobalbaseDataSet newDs = new GlobalbaseDataSet();
        private DateTime lastEditDate = DateTime.MinValue;
        private bool exitApplicaton = false;

        private DateTime lastApdateDateTime
        {
            get
            {
                if ((globalbaseDataSet != null) && (globalbaseDataSet.ZOVAppointments != null) &&
                    (globalbaseDataSet.ZOVAppointments.Select(x => x.LastEditTime).Count() > 0))
                {
                    return globalbaseDataSet.ZOVAppointments.Select(x => x.LastEditTime).Max();
                }
                return DateTime.MinValue;
            }
        }

        public frmMain()
        {
            InitializeComponent();
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

            zOVAppointmentsTableAdapter.Fill(globalbaseDataSet.ZOVAppointments);
            zOVResourcesTableAdapter.Fill(globalbaseDataSet.ZOVResources);
            lastEditDate = lastApdateDateTime;
            timerMain.Start();

        }

        private void OnAppointmentChangedInsertedDeleted(object sender, PersistentObjectsEventArgs e)
        {

            zOVAppointmentsTableAdapter.Update(this.globalbaseDataSet.ZOVAppointments);
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
            if (globalbaseDataSet.ZOVAppointments.GetChanges() != null)
            {
                zOVAppointmentsTableAdapter.Update(globalbaseDataSet.ZOVAppointments.GetChanges() as GlobalbaseDataSet.ZOVAppointmentsDataTable);
            }
            zOVAppointmentsTableAdapter.Fill(newDs.ZOVAppointments);
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
                    notifyIcon.BalloonTipText = s;
                    notifyIcon.ShowBalloonTip(1000);
                }
                //lastEditDate = globalbaseDataSet.ZOVAppointments.Select(x => x.LastEditTime).Max();
                lastEditDate = lastApdateDateTime;
            }
            timerMain.Enabled = true;
        }

        private void mainSchedulerControl_EditAppointmentFormShowing(object sender, AppointmentFormEventArgs e)
        {
            timerMain.Stop();
        }

        private void frmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = !exitApplicaton;
            if (e.Cancel)
            {
                WindowState = FormWindowState.Minimized;
                ShowInTaskbar = false;
                Visible = false;
                notifyIcon.BalloonTipText = "Напоминалка";
                notifyIcon.ShowBalloonTip(500);
            }
        }

        private void notifyIcon_DoubleClick(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Normal;
            ShowInTaskbar = true;
            Visible = true;
//            notifyIcon.BalloonTipText = "Напоминалка";
//            notifyIcon.ShowBalloonTip(500);
        }

        private void mainContextMenuStrip_Opening(object sender, CancelEventArgs e)
        {

        }

        private void mContextClose_Click(object sender, EventArgs e)
        {
            exitApplicaton = true;
            Application.Exit();
        }

        private void mContextOpen_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Normal;
            ShowInTaskbar = true;
            Visible = true;
        }

       }
}
