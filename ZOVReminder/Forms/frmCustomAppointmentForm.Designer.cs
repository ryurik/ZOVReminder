namespace ZOVReminder.Forms
{
    partial class FrmCustomAppointmentForm
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
            this.lblSubject.Location = new System.Drawing.Point(16, 35);
            this.lblSubject.Margin = new System.Windows.Forms.Padding(2);
            this.lblSubject.Size = new System.Drawing.Size(28, 13);
            this.lblSubject.Text = "&Тема:";
            // 
            // lblLocation
            // 
            this.lblLocation.Location = new System.Drawing.Point(16, 61);
            this.lblLocation.Margin = new System.Windows.Forms.Padding(2);
            this.lblLocation.Size = new System.Drawing.Size(35, 13);
            this.lblLocation.Text = "&Место:";
            // 
            // lblLabel
            // 
            this.lblLabel.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.lblLabel.Margin = new System.Windows.Forms.Padding(2);
            this.lblLabel.Size = new System.Drawing.Size(36, 13);
            this.lblLabel.Text = "Метка:";
            // 
            // lblStartTime
            // 
            this.lblStartTime.Location = new System.Drawing.Point(16, 98);
            this.lblStartTime.Margin = new System.Windows.Forms.Padding(2);
            this.lblStartTime.Size = new System.Drawing.Size(41, 13);
            this.lblStartTime.Text = "Начало:";
            // 
            // lblEndTime
            // 
            this.lblEndTime.Location = new System.Drawing.Point(16, 123);
            this.lblEndTime.Margin = new System.Windows.Forms.Padding(2);
            this.lblEndTime.Size = new System.Drawing.Size(35, 13);
            this.lblEndTime.Text = "Конец:";
            // 
            // lblShowTimeAs
            // 
            this.lblShowTimeAs.Location = new System.Drawing.Point(16, 160);
            this.lblShowTimeAs.Margin = new System.Windows.Forms.Padding(2);
            this.lblShowTimeAs.Size = new System.Drawing.Size(66, 13);
            this.lblShowTimeAs.Text = "В это время :";
            // 
            // chkAllDay
            // 
            this.chkAllDay.Margin = new System.Windows.Forms.Padding(2);
            this.chkAllDay.Properties.Caption = "&Целый день";
            this.chkAllDay.Size = new System.Drawing.Size(84, 19);
            // 
            // btnOk
            // 
            this.btnOk.Location = new System.Drawing.Point(16, 361);
            this.btnOk.Margin = new System.Windows.Forms.Padding(2);
            this.btnOk.Text = "Принять";
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(104, 361);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(2);
            this.btnCancel.Text = "Отмена";
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(192, 361);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(2);
            this.btnDelete.Text = "&Удалить";
            // 
            // btnRecurrence
            // 
            this.btnRecurrence.Location = new System.Drawing.Point(280, 361);
            this.btnRecurrence.Margin = new System.Windows.Forms.Padding(2);
            this.btnRecurrence.Text = "&Повторение";
            // 
            // edtStartDate
            // 
            this.edtStartDate.EditValue = new System.DateTime(2005, 3, 31, 0, 0, 0, 0);
            this.edtStartDate.Location = new System.Drawing.Point(96, 95);
            this.edtStartDate.Margin = new System.Windows.Forms.Padding(2);
            this.edtStartDate.Size = new System.Drawing.Size(86, 20);
            // 
            // edtEndDate
            // 
            this.edtEndDate.EditValue = new System.DateTime(2005, 3, 31, 0, 0, 0, 0);
            this.edtEndDate.Location = new System.Drawing.Point(96, 120);
            this.edtEndDate.Margin = new System.Windows.Forms.Padding(2);
            this.edtEndDate.Size = new System.Drawing.Size(86, 20);
            // 
            // edtStartTime
            // 
            this.edtStartTime.EditValue = new System.DateTime(2005, 3, 31, 0, 0, 0, 0);
            this.edtStartTime.Location = new System.Drawing.Point(220, 96);
            this.edtStartTime.Margin = new System.Windows.Forms.Padding(2);
            // 
            // edtEndTime
            // 
            this.edtEndTime.EditValue = new System.DateTime(2005, 3, 31, 0, 0, 0, 0);
            this.edtEndTime.Location = new System.Drawing.Point(220, 120);
            this.edtEndTime.Margin = new System.Windows.Forms.Padding(2);
            // 
            // edtLabel
            // 
            this.edtLabel.Margin = new System.Windows.Forms.Padding(2);
            // 
            // edtShowTimeAs
            // 
            this.edtShowTimeAs.Location = new System.Drawing.Point(96, 157);
            this.edtShowTimeAs.Margin = new System.Windows.Forms.Padding(2);
            this.edtShowTimeAs.Size = new System.Drawing.Size(213, 20);
            // 
            // tbSubject
            // 
            this.tbSubject.Location = new System.Drawing.Point(96, 33);
            this.tbSubject.Margin = new System.Windows.Forms.Padding(2);
            this.tbSubject.Size = new System.Drawing.Size(412, 20);
            // 
            // edtResource
            // 
            this.edtResource.Margin = new System.Windows.Forms.Padding(2);
            // 
            // lblResource
            // 
            this.lblResource.Margin = new System.Windows.Forms.Padding(2);
            this.lblResource.Size = new System.Drawing.Size(53, 13);
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
            this.chkReminder.Margin = new System.Windows.Forms.Padding(2);
            this.chkReminder.Properties.Caption = "&Оповещение";
            this.chkReminder.Size = new System.Drawing.Size(87, 19);
            // 
            // tbDescription
            // 
            this.tbDescription.Location = new System.Drawing.Point(16, 224);
            this.tbDescription.Margin = new System.Windows.Forms.Padding(2);
            this.tbDescription.Size = new System.Drawing.Size(493, 128);
            // 
            // cbReminder
            // 
            // 
            // tbLocation
            // 
            this.tbLocation.Location = new System.Drawing.Point(96, 58);
            this.tbLocation.Margin = new System.Windows.Forms.Padding(2);
            this.tbLocation.Size = new System.Drawing.Size(212, 20);
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(316, 58);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            // 
            // progressPanel
            // 
            this.progressPanel.Location = new System.Drawing.Point(16, 183);
            this.progressPanel.Margin = new System.Windows.Forms.Padding(2);
            this.progressPanel.Size = new System.Drawing.Size(493, 34);
            // 
            // tbProgress
            // 
            this.tbProgress.Properties.LabelAppearance.Options.UseTextOptions = true;
            this.tbProgress.Properties.LabelAppearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.tbProgress.Size = new System.Drawing.Size(213, 31);
            // 
            // lblPercentComplete
            // 
            this.lblPercentComplete.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.lblPercentComplete.Margin = new System.Windows.Forms.Padding(2);
            this.lblPercentComplete.Size = new System.Drawing.Size(74, 13);
            this.lblPercentComplete.Text = "% &Выполнено:";
            // 
            // lblPercentCompleteValue
            // 
            this.lblPercentCompleteValue.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.lblPercentCompleteValue.Location = new System.Drawing.Point(475, 10);
            this.lblPercentCompleteValue.Margin = new System.Windows.Forms.Padding(2);
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.Location = new System.Drawing.Point(519, 35);
            this.panel2.Margin = new System.Windows.Forms.Padding(2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(185, 317);
            this.panel2.TabIndex = 29;
            // 
            // labelUser
            // 
            this.labelUser.Location = new System.Drawing.Point(16, 8);
            this.labelUser.Margin = new System.Windows.Forms.Padding(2);
            this.labelUser.Name = "labelUser";
            this.labelUser.Size = new System.Drawing.Size(72, 13);
            this.labelUser.TabIndex = 30;
            this.labelUser.Text = "Пользователь";
            // 
            // FrmCustomAppointmentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(710, 395);
            this.Controls.Add(this.labelUser);
            this.Controls.Add(this.panel2);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MinimumSize = new System.Drawing.Size(718, 300);
            this.Name = "FrmCustomAppointmentForm";
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
