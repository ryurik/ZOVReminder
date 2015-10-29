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
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraScheduler;

namespace ZOVReminder.Forms
{
    public partial class frmCustomAppointmentForm : DevExpress.XtraScheduler.UI.AppointmentForm
    {
        private int _zovReminderUsersID;
        public frmCustomAppointmentForm()
        {
            InitializeComponent();
        }
        public frmCustomAppointmentForm(DevExpress.XtraScheduler.SchedulerControl control, DevExpress.XtraScheduler.Appointment apt)
            : base(control, apt)
        {
            InitializeComponent();
        }
        public frmCustomAppointmentForm(DevExpress.XtraScheduler.SchedulerControl control, DevExpress.XtraScheduler.Appointment apt, bool openRecurrenceForm)
            : base(control, apt, openRecurrenceForm)
        {
            InitializeComponent();
        }
        /// <summary>
        /// Add your code to obtain a custom field value and fill the editor with data.
        /// </summary>
        public override void LoadFormData(DevExpress.XtraScheduler.Appointment appointment)
        {
            if (appointment.CustomFields["ZOVReminderUsersID"] == null)
            {
                labelUser.Text = "";
                _zovReminderUsersID = Program.Security.ZOVReminderUsersID;
                appointment.CustomFields["ZOVReminderUsersID"] = _zovReminderUsersID;
            }
                //labelUser = appointment.CustomFields["ZOVReminderUsersID"].ToString();
            labelUser.Text = Program.Security.UserName;
            _zovReminderUsersID = Program.Security.ZOVReminderUsersID;
            base.LoadFormData(appointment);
        }
        /// <summary>
        /// Add your code to retrieve a value from the editor and set the custom appointment field.
        /// </summary>
        public override bool SaveFormData(DevExpress.XtraScheduler.Appointment appointment)
        {
            appointment.CustomFields["ZOVReminderUsersID"] = _zovReminderUsersID; //Program.Security.ZOVReminderUsersID;
            return base.SaveFormData(appointment);
        }
        /// <summary>
        /// Add your code to notify that any custom field is changed. Return true if a custom field is changed, otherwise false.
        /// </summary>
        public override bool IsAppointmentChanged(DevExpress.XtraScheduler.Appointment appointment)
        {
            if (_zovReminderUsersID.ToString() == appointment.CustomFields["ZOVReminderUsersID"].ToString())
                return false;
            else
                return true;
        }
    }
}
