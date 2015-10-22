using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraReports.Native;
using ZOVReminder.Classes;

namespace ZOVReminder.Forms
{
    public partial class frmMainMDI : Form
    {
        private bool exitApplicaton = false;

        [DllImport("user32.dll")]
        static extern int GetWindowLong(IntPtr hWnd, int nIndex);

        [DllImport("user32.dll")]
        static extern int SetWindowLong(IntPtr hWnd, int nIndex, int dwNewLong);

        public frmMainMDI()
        {
            InitializeComponent();
        }
/*
        protected override void WndProc(ref Message m)
        {
            const int WM_SYSCOMMAND = 0x0112;
            const int WM_NCCALCSIZE = 131;
            const int SC_MOVE = 0xF010;
            const int GWL_STYLE = (-16);
            const UInt32 WS_VSCROLL = 0x200000;
            const UInt32 WS_HSCROLL = 0x100000;
            
            //ShowScrollBar(this.Handle, (int)ScrollBarDirection.SB_BOTH, false);
            switch (m.Msg)
            {
                case WM_SYSCOMMAND:
                    int command = m.WParam.ToInt32() & 0xfff0;
                    if (command == SC_MOVE)
                        return;
                    break;
                case WM_NCCALCSIZE:
                    int iii = GetWindowLong(Handle, GWL_STYLE);
                    if ((iii & (WS_HSCROLL | WS_VSCROLL)) != 0)
                    {
                        SetWindowLong(Handle, GWL_STYLE,
                            (int) (GetWindowLong(Handle, GWL_STYLE) & (WS_HSCROLL | WS_VSCROLL)));
                    }
                    break;
            }
            base.WndProc(ref m);
        }
--*/
        private void frmMainMDI_Load(object sender, EventArgs e)
        {
            toolStripStatusLabelUserName.Text = Program.Security.UserName;
            mToolStripMenuItemSettings.Visible = Program.Security.IsAdmin;

        }


        private void OpenChildForms(Type frmType, String caption, FormWindowState formWindowState = FormWindowState.Minimized)
        {
            foreach (Form c in MdiChildren)
            {
                if ((c.GetType() == frmType) && (c.Text.ToLower().Equals(caption.ToLower())))
                {
                    c.BringToFront();
                    return;
                }
            }


            Type[] types = new Type[1];
            types[0] = typeof(int);
            // Get the public instance constructor that takes an integer parameter.
            ConstructorInfo constructorInfoObj = frmType.GetConstructor(
                BindingFlags.Instance | BindingFlags.Public, null,
                CallingConventions.HasThis, types, null);
            if (constructorInfoObj != null)
            {
                object[] i = new object[1];
                var f = constructorInfoObj.Invoke(i);
                if (f is Form)
                {
                    (f as Form).MdiParent = this;
                    if (formWindowState != FormWindowState.Minimized)
                    {
                        (f as Form).WindowState = formWindowState;
                    }
                    (f as Form).Show();
                }
            }

        }

        private void mToolStripMenuItemExit_Click(object sender, EventArgs e)
        {
            exitApplicaton = true;
            CloseForm();
        }

        private void mToolStripMenuItemPasswords_Click(object sender, EventArgs e)
        {
            
            OpenChildForms(typeof(frmPasswords), "Пароли", FormWindowState.Normal);

            //frmPasswords frmPasswords = new frmPasswords();
            //frmPasswords.MdiParent = this;
            //frmPasswords.Show();
        }


        private void mToolStripMenuItemCalendar_Click(object sender, EventArgs e)
        {
            OpenChildForms(typeof(frmCalendar), "Напоминание");
        }

        private void frmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
#if !DEBUG
            e.Cancel = !exitApplicaton;
            if (e.Cancel)
            {
                WindowState = FormWindowState.Minimized;
                ShowInTaskbar = false;
                Visible = false;
                notifyIcon.BalloonTipText = "Напоминалка";
                notifyIcon.ShowBalloonTip(500);
            }
            else
            {
                FillLastLogon();
                notifyIcon.Dispose();
            }
#else
            FillLastLogon();
            notifyIcon.Dispose();
#endif
        }

        private void FillLastLogon()
        {
            if (Program.Security.ZOVReminderUsersID == 0)
                return;

            MyConnectionString.ExecuteScalarQuery(String.Format(
                                "UPDATE ZOVRU " +
                                "  SET LastLogOff = CONVERT(datetime, '{1}', 103)" +
                                "  FROM ZOVReminderUsers ZOVRU " +
                                "  WHERE (UserName LIKE '{0}')",
                                Program.Security.UserName, DateTime.Now));
        }

        private void notifyIcon_DoubleClick(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Normal;
            ShowInTaskbar = true;
            Visible = true;
        }


        public void ShowToolTip(string message, int timeDuration)
        {
            notifyIcon.BalloonTipText = message;
            notifyIcon.ShowBalloonTip(timeDuration);

        }

        private void mContextOpen_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Normal;
            ShowInTaskbar = true;
            Visible = true;
        }

        private void mContextClose_Click(object sender, EventArgs e)
        {
            exitApplicaton = true;
            CloseForm();
        }

        private void группыToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenChildForms(typeof(frmGroups), "Группы");
        }

        private void CloseForm()
        {
            Close();
            //            Application.Exit();
            //Environment.Exit(0);
        }

        private void пользователиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenChildForms(typeof(frmUsers), "Пользователи");
        }

    }
}
