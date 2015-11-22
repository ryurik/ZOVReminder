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
using System.Windows.Forms.VisualStyles;
using DevExpress.XtraReports.Native;
using ZOVReminder.Classes;

namespace ZOVReminder.Forms
{
    public partial class FrmMainMDI : Form
    {
        private bool exitApplicaton = false;

        [DllImport("user32.dll")]
        static extern int GetWindowLong(IntPtr hWnd, int nIndex);

        [DllImport("user32.dll")]
        static extern int SetWindowLong(IntPtr hWnd, int nIndex, int dwNewLong);

        public FrmMainMDI()
        {
            InitializeComponent();
        }
/*
        protected override void WndProc(ref Message m)
        {
              const int WM_SYSCOMMAND = 0x0112;
              const int SC_MOVE = 0xF010;
              //ShowScrollBar(this.Handle, (int)ScrollBarDirection.SB_BOTH, false);
              switch (m.Msg)
              {
                case WM_SYSCOMMAND:
                  int command = m.WParam.ToInt32() & 0xfff0;
                  if (command == SC_MOVE)
                    return;
                  break;
              }
              base.WndProc(ref m);

        }
//*/
        private void frmMainMDI_Load(object sender, EventArgs e)
        {
            toolStripStatusLabelUserName.Text = Program.Security.UserName + (Program.Security.ReadOnly ? "(Только для чтения)" : "");
            mToolStripMenuItemSettings.Visible = Program.Security.IsAdmin;
            if (Program.Security.ZOVReminderUsersID > 0)
            {
                mToolStripMenuItemCalendar_Click(sender, e);
                toolStripStatusLabelConnectionString.Text = "";
            }
            else
            {
                пользователиToolStripMenuItem_Click(sender, e);
                toolStripStatusLabelConnectionString.Text = MyConnectionString.ConnectionString;
            }
            FrmMainMDI_Resize(sender, e);
            timerMain.Enabled = true;
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


            Type[] types = new Type[0];
            //types[0] = typeof(int);
            //types[0] = null;
            // Get the public instance constructor that takes NO Paramters - default constructor (an integer parameter).
            ConstructorInfo constructorInfoObj = frmType.GetConstructor(
                BindingFlags.Instance | BindingFlags.Public, null,
                CallingConventions.HasThis, types, null);
            if (constructorInfoObj != null)
            {
                object[] i = new object[0];
                var f = constructorInfoObj.Invoke(i);
                if (f is Form)
                {
                    (f as Form).MdiParent = this;
                    if (formWindowState != FormWindowState.Minimized)
                    {
                        (f as Form).WindowState = formWindowState;
                    }
                    (f as Form).Text = caption;
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
            OpenChildForms(typeof(FrmGroups), "Группы");
        }

        private void CloseForm()
        {
            Close();
            //            Application.Exit();
            //Environment.Exit(0);
        }

        private void пользователиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenChildForms(typeof(FrmUsers), "Пользователи");
        }

        private void группыИПользователиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenChildForms(typeof(FrmGroupsAndUsers), "Группы и пользователи");
        }

        private void FrmMainMDI_Resize(object sender, EventArgs e)
        {
            foreach (Form c in MdiChildren)
            {
                if (c.MinimizeBox)
                {
                    c.Top = 0;
                    c.Left = 0;
                    c.Size = new Size(this.ClientSize.Width, this.ClientSize.Height);
                    c.Height = this.ClientSize.Height - menuStripMain.Height - statusStrip.Height - 5;
                    c.Width = this.ClientSize.Width - 5;
                }
            }
        }

        private void miChats_Click(object sender, EventArgs e)
        {
            OpenChildForms(typeof(FrmChat), "Информационное поле");
        }

    }
}
