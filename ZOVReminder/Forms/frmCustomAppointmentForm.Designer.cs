namespace ZOVReminder.Forms
{
    partial class frmCustomAppointmentForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel2 = new System.Windows.Forms.Panel();
            this.labelUser = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.chkAllDay.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.edtStartDate.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.edtStartDate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.edtEndDate.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.edtEndDate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.edtStartTime.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.edtEndTime.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.edtLabel.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.edtShowTimeAs.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbSubject.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.edtResource.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.edtResources.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.edtResources.ResourcesCheckedListBoxControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkReminder.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbDescription.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbReminder.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbLocation.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panel1)).BeginInit();
            this.panel1.SuspendLayout();
            this.progressPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbProgress)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbProgress.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // lblSubject
            // 
            this.lblSubject.Location = new System.Drawing.Point(24, 51);
            this.lblSubject.Size = new System.Drawing.Size(42, 19);
            this.lblSubject.Text = "&Тема:";
            // 
            // lblLocation
            // 
            this.lblLocation.Location = new System.Drawing.Point(24, 89);
            this.lblLocation.Size = new System.Drawing.Size(50, 19);
            this.lblLocation.Text = "&Место:";
            // 
            // lblLabel
            // 
            this.lblLabel.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.lblLabel.Size = new System.Drawing.Size(50, 19);
            this.lblLabel.Text = "Метка:";
            // 
            // lblStartTime
            // 
            this.lblStartTime.Location = new System.Drawing.Point(24, 143);
            this.lblStartTime.Size = new System.Drawing.Size(60, 19);
            this.lblStartTime.Text = "Начало:";
            // 
            // lblEndTime
            // 
            this.lblEndTime.Location = new System.Drawing.Point(24, 180);
            this.lblEndTime.Size = new System.Drawing.Size(51, 19);
            this.lblEndTime.Text = "Конец:";
            // 
            // lblShowTimeAs
            // 
            this.lblShowTimeAs.Location = new System.Drawing.Point(24, 234);
            this.lblShowTimeAs.Size = new System.Drawing.Size(98, 19);
            this.lblShowTimeAs.Text = "В это время :";
            // 
            // chkAllDay
            // 
            this.chkAllDay.Properties.Caption = "&Целый день";
            this.chkAllDay.Size = new System.Drawing.Size(109, 23);
            // 
            // btnOk
            // 
            this.btnOk.Location = new System.Drawing.Point(24, 528);
            this.btnOk.Text = "Принять";
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(156, 528);
            this.btnCancel.Text = "Отмена";
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(288, 528);
            this.btnDelete.Text = "&Удалить";
            // 
            // btnRecurrence
            // 
            this.btnRecurrence.Location = new System.Drawing.Point(420, 528);
            this.btnRecurrence.Text = "&Повторение";
            // 
            // edtStartDate
            // 
            this.edtStartDate.EditValue = new System.DateTime(2005, 3, 31, 0, 0, 0, 0);
            this.edtStartDate.Location = new System.Drawing.Point(144, 139);
            this.edtStartDate.Size = new System.Drawing.Size(164, 26);
            // 
            // edtEndDate
            // 
            this.edtEndDate.EditValue = new System.DateTime(2005, 3, 31, 0, 0, 0, 0);
            this.edtEndDate.Location = new System.Drawing.Point(144, 176);
            this.edtEndDate.Size = new System.Drawing.Size(164, 26);
            // 
            // edtStartTime
            // 
            this.edtStartTime.EditValue = new System.DateTime(2005, 3, 31, 0, 0, 0, 0);
            this.edtStartTime.Location = new System.Drawing.Point(365, 140);
            // 
            // edtEndTime
            // 
            this.edtEndTime.EditValue = new System.DateTime(2005, 3, 31, 0, 0, 0, 0);
            this.edtEndTime.Location = new System.Drawing.Point(365, 176);
            // 
            // edtLabel
            // 
            this.edtLabel.Size = new System.Drawing.Size(168, 26);
            // 
            // edtShowTimeAs
            // 
            this.edtShowTimeAs.Location = new System.Drawing.Point(144, 230);
            this.edtShowTimeAs.Size = new System.Drawing.Size(354, 26);
            // 
            // tbSubject
            // 
            this.tbSubject.Location = new System.Drawing.Point(144, 48);
            this.tbSubject.Size = new System.Drawing.Size(653, 26);
            // 
            // edtResource
            // 
            this.edtResource.Size = new System.Drawing.Size(168, 26);
            // 
            // lblResource
            // 
            this.lblResource.Size = new System.Drawing.Size(73, 19);
            this.lblResource.Text = "Средства:";
            // 
            // edtResources
            // 
            // 
            // 
            // 
            this.edtResources.ResourcesCheckedListBoxControl.CheckOnClick = true;
            this.edtResources.ResourcesCheckedListBoxControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.edtResources.ResourcesCheckedListBoxControl.Location = new System.Drawing.Point(0, 0);
            this.edtResources.ResourcesCheckedListBoxControl.Name = "";
            this.edtResources.ResourcesCheckedListBoxControl.Size = new System.Drawing.Size(200, 100);
            this.edtResources.ResourcesCheckedListBoxControl.TabIndex = 0;
            // 
            // chkReminder
            // 
            this.chkReminder.Properties.Caption = "&Оповещение";
            this.chkReminder.Size = new System.Drawing.Size(115, 23);
            // 
            // tbDescription
            // 
            this.tbDescription.Location = new System.Drawing.Point(24, 327);
            this.tbDescription.Size = new System.Drawing.Size(774, 187);
            // 
            // cbReminder
            // 
            // 
            // tbLocation
            // 
            this.tbLocation.Location = new System.Drawing.Point(144, 85);
            this.tbLocation.Size = new System.Drawing.Size(353, 26);
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(509, 85);
            // 
            // progressPanel
            // 
            this.progressPanel.Location = new System.Drawing.Point(24, 268);
            this.progressPanel.Size = new System.Drawing.Size(774, 50);
            // 
            // tbProgress
            // 
            this.tbProgress.Properties.LabelAppearance.Options.UseTextOptions = true;
            this.tbProgress.Properties.LabelAppearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.tbProgress.Size = new System.Drawing.Size(354, 45);
            // 
            // lblPercentComplete
            // 
            this.lblPercentComplete.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.lblPercentComplete.Size = new System.Drawing.Size(109, 19);
            this.lblPercentComplete.Text = "% &Выполнено:";
            // 
            // lblPercentCompleteValue
            // 
            this.lblPercentCompleteValue.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.lblPercentCompleteValue.Location = new System.Drawing.Point(747, 15);
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.Location = new System.Drawing.Point(813, 51);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(277, 463);
            this.panel2.TabIndex = 29;
            // 
            // labelUser
            // 
            this.labelUser.Location = new System.Drawing.Point(24, 12);
            this.labelUser.Name = "labelUser";
            this.labelUser.Size = new System.Drawing.Size(102, 19);
            this.labelUser.TabIndex = 30;
            this.labelUser.Text = "Пользователь";
            // 
            // frmCustomAppointmentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.ClientSize = new System.Drawing.Size(1099, 577);
            this.Controls.Add(this.labelUser);
            this.Controls.Add(this.panel2);
            this.Name = "frmCustomAppointmentForm";
            this.Controls.SetChildIndex(this.edtShowTimeAs, 0);
            this.Controls.SetChildIndex(this.edtEndTime, 0);
            this.Controls.SetChildIndex(this.edtEndDate, 0);
            this.Controls.SetChildIndex(this.btnRecurrence, 0);
            this.Controls.SetChildIndex(this.btnDelete, 0);
            this.Controls.SetChildIndex(this.btnCancel, 0);
            this.Controls.SetChildIndex(this.lblShowTimeAs, 0);
            this.Controls.SetChildIndex(this.lblEndTime, 0);
            this.Controls.SetChildIndex(this.tbLocation, 0);
            this.Controls.SetChildIndex(this.lblSubject, 0);
            this.Controls.SetChildIndex(this.lblLocation, 0);
            this.Controls.SetChildIndex(this.tbSubject, 0);
            this.Controls.SetChildIndex(this.lblStartTime, 0);
            this.Controls.SetChildIndex(this.btnOk, 0);
            this.Controls.SetChildIndex(this.edtStartDate, 0);
            this.Controls.SetChildIndex(this.edtStartTime, 0);
            this.Controls.SetChildIndex(this.panel1, 0);
            this.Controls.SetChildIndex(this.progressPanel, 0);
            this.Controls.SetChildIndex(this.tbDescription, 0);
            this.Controls.SetChildIndex(this.panel2, 0);
            this.Controls.SetChildIndex(this.labelUser, 0);
            ((System.ComponentModel.ISupportInitialize)(this.chkAllDay.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.edtStartDate.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.edtStartDate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.edtEndDate.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.edtEndDate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.edtStartTime.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.edtEndTime.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.edtLabel.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.edtShowTimeAs.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbSubject.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.edtResource.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.edtResources.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.edtResources.ResourcesCheckedListBoxControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkReminder.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbDescription.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbReminder.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbLocation.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panel1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.progressPanel.ResumeLayout(false);
            this.progressPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbProgress.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbProgress)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private DevExpress.XtraEditors.LabelControl labelUser;
    }
}
