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
            this.components = new System.ComponentModel.Container();
            this.panelTree = new System.Windows.Forms.Panel();
            this.treeList = new DevExpress.XtraTreeList.TreeList();
            this.colId = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.colName = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.bsSP_GetTreeList = new System.Windows.Forms.BindingSource(this.components);
            this.globalbaseDataSet = new ZOVReminder.GlobalbaseDataSet();
            this.labelUser = new DevExpress.XtraEditors.LabelControl();
            this.taGetTreeList = new ZOVReminder.GlobalbaseDataSetTableAdapters.SP_GetTreeListTableAdapter();
            this.panel2 = new System.Windows.Forms.Panel();
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
            this.panelTree.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.treeList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsSP_GetTreeList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.globalbaseDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // lblSubject
            // 
            this.lblSubject.Location = new System.Drawing.Point(24, 51);
            this.lblSubject.Margin = new System.Windows.Forms.Padding(3);
            this.lblSubject.Size = new System.Drawing.Size(42, 19);
            this.lblSubject.Text = "&Тема:";
            // 
            // lblLocation
            // 
            this.lblLocation.Location = new System.Drawing.Point(24, 89);
            this.lblLocation.Margin = new System.Windows.Forms.Padding(3);
            this.lblLocation.Size = new System.Drawing.Size(50, 19);
            this.lblLocation.Text = "&Место:";
            // 
            // lblLabel
            // 
            this.lblLabel.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.lblLabel.Margin = new System.Windows.Forms.Padding(3);
            this.lblLabel.Size = new System.Drawing.Size(50, 19);
            this.lblLabel.Text = "Метка:";
            // 
            // lblStartTime
            // 
            this.lblStartTime.Location = new System.Drawing.Point(24, 143);
            this.lblStartTime.Margin = new System.Windows.Forms.Padding(3);
            this.lblStartTime.Size = new System.Drawing.Size(60, 19);
            this.lblStartTime.Text = "Начало:";
            // 
            // lblEndTime
            // 
            this.lblEndTime.Location = new System.Drawing.Point(24, 180);
            this.lblEndTime.Margin = new System.Windows.Forms.Padding(3);
            this.lblEndTime.Size = new System.Drawing.Size(51, 19);
            this.lblEndTime.Text = "Конец:";
            // 
            // lblShowTimeAs
            // 
            this.lblShowTimeAs.Location = new System.Drawing.Point(24, 234);
            this.lblShowTimeAs.Margin = new System.Windows.Forms.Padding(3);
            this.lblShowTimeAs.Size = new System.Drawing.Size(98, 19);
            this.lblShowTimeAs.Text = "В это время :";
            // 
            // chkAllDay
            // 
            this.chkAllDay.Margin = new System.Windows.Forms.Padding(3);
            this.chkAllDay.Properties.Caption = "&Целый день";
            this.chkAllDay.Size = new System.Drawing.Size(109, 23);
            // 
            // btnOk
            // 
            this.btnOk.Location = new System.Drawing.Point(24, 528);
            this.btnOk.Margin = new System.Windows.Forms.Padding(3);
            this.btnOk.Text = "Принять";
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(156, 528);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(3);
            this.btnCancel.Text = "Отмена";
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(288, 528);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(3);
            this.btnDelete.Text = "&Удалить";
            // 
            // btnRecurrence
            // 
            this.btnRecurrence.Location = new System.Drawing.Point(420, 528);
            this.btnRecurrence.Margin = new System.Windows.Forms.Padding(3);
            this.btnRecurrence.Text = "&Повторение";
            // 
            // edtStartDate
            // 
            this.edtStartDate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)));
            this.edtStartDate.EditValue = new System.DateTime(2005, 3, 31, 0, 0, 0, 0);
            this.edtStartDate.Location = new System.Drawing.Point(144, 139);
            this.edtStartDate.Margin = new System.Windows.Forms.Padding(3);
            this.edtStartDate.Size = new System.Drawing.Size(134, 26);
            // 
            // edtEndDate
            // 
            this.edtEndDate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)));
            this.edtEndDate.EditValue = new System.DateTime(2005, 3, 31, 0, 0, 0, 0);
            this.edtEndDate.Location = new System.Drawing.Point(144, 175);
            this.edtEndDate.Margin = new System.Windows.Forms.Padding(3);
            this.edtEndDate.Size = new System.Drawing.Size(134, 26);
            // 
            // edtStartTime
            // 
            this.edtStartTime.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)));
            this.edtStartTime.EditValue = new System.DateTime(2005, 3, 31, 0, 0, 0, 0);
            this.edtStartTime.Location = new System.Drawing.Point(333, 140);
            this.edtStartTime.Margin = new System.Windows.Forms.Padding(3);
            // 
            // edtEndTime
            // 
            this.edtEndTime.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)));
            this.edtEndTime.EditValue = new System.DateTime(2005, 3, 31, 0, 0, 0, 0);
            this.edtEndTime.Location = new System.Drawing.Point(333, 175);
            this.edtEndTime.Margin = new System.Windows.Forms.Padding(3);
            // 
            // edtLabel
            // 
            this.edtLabel.Margin = new System.Windows.Forms.Padding(3);
            this.edtLabel.Size = new System.Drawing.Size(168, 26);
            // 
            // edtShowTimeAs
            // 
            this.edtShowTimeAs.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)));
            this.edtShowTimeAs.Location = new System.Drawing.Point(144, 229);
            this.edtShowTimeAs.Margin = new System.Windows.Forms.Padding(3);
            this.edtShowTimeAs.Size = new System.Drawing.Size(325, 26);
            // 
            // tbSubject
            // 
            this.tbSubject.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)));
            this.tbSubject.Location = new System.Drawing.Point(144, 48);
            this.tbSubject.Margin = new System.Windows.Forms.Padding(3);
            this.tbSubject.Size = new System.Drawing.Size(623, 26);
            // 
            // edtResource
            // 
            this.edtResource.Margin = new System.Windows.Forms.Padding(3);
            this.edtResource.Size = new System.Drawing.Size(168, 26);
            // 
            // lblResource
            // 
            this.lblResource.Margin = new System.Windows.Forms.Padding(3);
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
            this.chkReminder.Margin = new System.Windows.Forms.Padding(3);
            this.chkReminder.Properties.Caption = "&Оповещение";
            this.chkReminder.Size = new System.Drawing.Size(115, 23);
            // 
            // tbDescription
            // 
            this.tbDescription.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.tbDescription.Location = new System.Drawing.Point(24, 327);
            this.tbDescription.Margin = new System.Windows.Forms.Padding(3);
            this.tbDescription.Size = new System.Drawing.Size(742, 187);
            // 
            // cbReminder
            // 
            // 
            // tbLocation
            // 
            this.tbLocation.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)));
            this.tbLocation.Location = new System.Drawing.Point(144, 85);
            this.tbLocation.Margin = new System.Windows.Forms.Padding(3);
            this.tbLocation.Size = new System.Drawing.Size(320, 26);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)));
            this.panel1.Location = new System.Drawing.Point(479, 85);
            this.panel1.Margin = new System.Windows.Forms.Padding(3);
            // 
            // progressPanel
            // 
            this.progressPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)));
            this.progressPanel.Location = new System.Drawing.Point(24, 267);
            this.progressPanel.Margin = new System.Windows.Forms.Padding(3);
            this.progressPanel.Size = new System.Drawing.Size(742, 50);
            // 
            // tbProgress
            // 
            this.tbProgress.Properties.LabelAppearance.Options.UseTextOptions = true;
            this.tbProgress.Properties.LabelAppearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.tbProgress.Size = new System.Drawing.Size(322, 45);
            // 
            // lblPercentComplete
            // 
            this.lblPercentComplete.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.lblPercentComplete.Margin = new System.Windows.Forms.Padding(3);
            this.lblPercentComplete.Size = new System.Drawing.Size(109, 19);
            this.lblPercentComplete.Text = "% &Выполнено:";
            // 
            // lblPercentCompleteValue
            // 
            this.lblPercentCompleteValue.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.lblPercentCompleteValue.Location = new System.Drawing.Point(714, 15);
            this.lblPercentCompleteValue.Margin = new System.Windows.Forms.Padding(3);
            // 
            // panelTree
            // 
            this.panelTree.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelTree.Controls.Add(this.treeList);
            this.panelTree.Location = new System.Drawing.Point(782, 51);
            this.panelTree.Name = "panelTree";
            this.panelTree.Size = new System.Drawing.Size(310, 511);
            this.panelTree.TabIndex = 29;
            // 
            // treeList
            // 
            this.treeList.Columns.AddRange(new DevExpress.XtraTreeList.Columns.TreeListColumn[] {
            this.colId,
            this.colName});
            this.treeList.DataSource = this.bsSP_GetTreeList;
            this.treeList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.treeList.Location = new System.Drawing.Point(0, 0);
            this.treeList.Name = "treeList";
            this.treeList.OptionsBehavior.AllowIncrementalSearch = true;
            this.treeList.OptionsBehavior.AllowRecursiveNodeChecking = true;
            this.treeList.OptionsBehavior.AutoChangeParent = false;
            this.treeList.ParentFieldName = "ParentId";
            this.treeList.PreviewFieldName = "Name";
            this.treeList.ShowButtonMode = DevExpress.XtraTreeList.ShowButtonModeEnum.ShowAlways;
            this.treeList.Size = new System.Drawing.Size(310, 511);
            this.treeList.TabIndex = 0;
            // 
            // colId
            // 
            this.colId.FieldName = "Id";
            this.colId.Name = "colId";
            this.colId.Visible = true;
            this.colId.VisibleIndex = 0;
            this.colId.Width = 98;
            // 
            // colName
            // 
            this.colName.FieldName = "Name";
            this.colName.Name = "colName";
            this.colName.Visible = true;
            this.colName.VisibleIndex = 1;
            this.colName.Width = 145;
            // 
            // bsSP_GetTreeList
            // 
            this.bsSP_GetTreeList.DataMember = "SP_GetTreeList";
            this.bsSP_GetTreeList.DataSource = this.globalbaseDataSet;
            // 
            // globalbaseDataSet
            // 
            this.globalbaseDataSet.DataSetName = "GlobalbaseDataSet";
            this.globalbaseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // labelUser
            // 
            this.labelUser.Location = new System.Drawing.Point(24, 12);
            this.labelUser.Name = "labelUser";
            this.labelUser.Size = new System.Drawing.Size(102, 19);
            this.labelUser.TabIndex = 30;
            this.labelUser.Text = "Пользователь";
            // 
            // taGetTreeList
            // 
            this.taGetTreeList.ClearBeforeFill = true;
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.Location = new System.Drawing.Point(780, 51);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(312, 463);
            this.panel2.TabIndex = 29;
            // 
            // FrmCustomAppointmentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.ClientSize = new System.Drawing.Size(1104, 577);
            this.Controls.Add(this.labelUser);
            this.Controls.Add(this.panelTree);
            this.Margin = new System.Windows.Forms.Padding(3);
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
            this.Controls.SetChildIndex(this.panelTree, 0);
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
            this.panelTree.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.treeList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsSP_GetTreeList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.globalbaseDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelTree;
        private DevExpress.XtraEditors.LabelControl labelUser;
        private System.Windows.Forms.BindingSource bsSP_GetTreeList;
        private GlobalbaseDataSet globalbaseDataSet;
        private GlobalbaseDataSetTableAdapters.SP_GetTreeListTableAdapter taGetTreeList;
        private System.Windows.Forms.Panel panel2;
        private DevExpress.XtraTreeList.TreeList treeList;
        private DevExpress.XtraTreeList.Columns.TreeListColumn colId;
        private DevExpress.XtraTreeList.Columns.TreeListColumn colName;
    }
}
