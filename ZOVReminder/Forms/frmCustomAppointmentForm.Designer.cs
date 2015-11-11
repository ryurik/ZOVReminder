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
            this.colName = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.bsSP_GetTreeList = new System.Windows.Forms.BindingSource(this.components);
            this.globalbaseDataSet = new ZOVReminder.GlobalbaseDataSet();
            this.labelUser = new DevExpress.XtraEditors.LabelControl();
            this.panel2 = new System.Windows.Forms.Panel();
            this.taSP_GetTreeList = new ZOVReminder.GlobalbaseDataSetTableAdapters.SP_GetTreeListTableAdapter();
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
            this.lblSubject.Location = new System.Drawing.Point(16, 35);
            this.lblSubject.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.lblSubject.Size = new System.Drawing.Size(28, 13);
            this.lblSubject.Text = "&Тема:";
            // 
            // lblLocation
            // 
            this.lblLocation.Location = new System.Drawing.Point(16, 61);
            this.lblLocation.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.lblLocation.Size = new System.Drawing.Size(35, 13);
            this.lblLocation.Text = "&Место:";
            // 
            // lblLabel
            // 
            this.lblLabel.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.lblLabel.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.lblLabel.Size = new System.Drawing.Size(36, 13);
            this.lblLabel.Text = "Метка:";
            // 
            // lblStartTime
            // 
            this.lblStartTime.Location = new System.Drawing.Point(16, 98);
            this.lblStartTime.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.lblStartTime.Size = new System.Drawing.Size(41, 13);
            this.lblStartTime.Text = "Начало:";
            // 
            // lblEndTime
            // 
            this.lblEndTime.Location = new System.Drawing.Point(16, 123);
            this.lblEndTime.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.lblEndTime.Size = new System.Drawing.Size(35, 13);
            this.lblEndTime.Text = "Конец:";
            // 
            // lblShowTimeAs
            // 
            this.lblShowTimeAs.Location = new System.Drawing.Point(16, 160);
            this.lblShowTimeAs.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.lblShowTimeAs.Size = new System.Drawing.Size(66, 13);
            this.lblShowTimeAs.Text = "В это время :";
            // 
            // chkAllDay
            // 
            this.chkAllDay.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.chkAllDay.Properties.Caption = "&Целый день";
            this.chkAllDay.Size = new System.Drawing.Size(84, 19);
            // 
            // btnOk
            // 
            this.btnOk.Location = new System.Drawing.Point(16, 361);
            this.btnOk.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnOk.Text = "Принять";
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(104, 361);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnCancel.Text = "Отмена";
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(192, 361);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnDelete.Text = "&Удалить";
            // 
            // btnRecurrence
            // 
            this.btnRecurrence.Location = new System.Drawing.Point(280, 361);
            this.btnRecurrence.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnRecurrence.Text = "&Повторение";
            // 
            // edtStartDate
            // 
            this.edtStartDate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)));
            this.edtStartDate.EditValue = new System.DateTime(2005, 3, 31, 0, 0, 0, 0);
            this.edtStartDate.Location = new System.Drawing.Point(96, 95);
            this.edtStartDate.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.edtStartDate.Size = new System.Drawing.Size(89, 20);
            // 
            // edtEndDate
            // 
            this.edtEndDate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)));
            this.edtEndDate.EditValue = new System.DateTime(2005, 3, 31, 0, 0, 0, 0);
            this.edtEndDate.Location = new System.Drawing.Point(96, 120);
            this.edtEndDate.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.edtEndDate.Size = new System.Drawing.Size(89, 20);
            // 
            // edtStartTime
            // 
            this.edtStartTime.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)));
            this.edtStartTime.EditValue = new System.DateTime(2005, 3, 31, 0, 0, 0, 0);
            this.edtStartTime.Location = new System.Drawing.Point(222, 96);
            this.edtStartTime.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            // 
            // edtEndTime
            // 
            this.edtEndTime.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)));
            this.edtEndTime.EditValue = new System.DateTime(2005, 3, 31, 0, 0, 0, 0);
            this.edtEndTime.Location = new System.Drawing.Point(222, 120);
            this.edtEndTime.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            // 
            // edtLabel
            // 
            this.edtLabel.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            // 
            // edtShowTimeAs
            // 
            this.edtShowTimeAs.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)));
            this.edtShowTimeAs.Location = new System.Drawing.Point(96, 157);
            this.edtShowTimeAs.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.edtShowTimeAs.Size = new System.Drawing.Size(217, 20);
            // 
            // tbSubject
            // 
            this.tbSubject.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)));
            this.tbSubject.Location = new System.Drawing.Point(96, 33);
            this.tbSubject.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tbSubject.Size = new System.Drawing.Size(415, 20);
            // 
            // edtResource
            // 
            this.edtResource.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            // 
            // lblResource
            // 
            this.lblResource.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
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
            this.chkReminder.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.chkReminder.Properties.Caption = "&Оповещение";
            this.chkReminder.Size = new System.Drawing.Size(87, 19);
            // 
            // tbDescription
            // 
            this.tbDescription.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.tbDescription.Location = new System.Drawing.Point(16, 224);
            this.tbDescription.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tbDescription.Size = new System.Drawing.Size(495, 128);
            // 
            // cbReminder
            // 
            // 
            // tbLocation
            // 
            this.tbLocation.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)));
            this.tbLocation.Location = new System.Drawing.Point(96, 58);
            this.tbLocation.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tbLocation.Size = new System.Drawing.Size(213, 20);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)));
            this.panel1.Location = new System.Drawing.Point(319, 58);
            this.panel1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            // 
            // progressPanel
            // 
            this.progressPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)));
            this.progressPanel.Location = new System.Drawing.Point(16, 183);
            this.progressPanel.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.progressPanel.Size = new System.Drawing.Size(495, 34);
            // 
            // tbProgress
            // 
            this.tbProgress.Properties.LabelAppearance.Options.UseTextOptions = true;
            this.tbProgress.Properties.LabelAppearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.tbProgress.Size = new System.Drawing.Size(215, 31);
            // 
            // lblPercentComplete
            // 
            this.lblPercentComplete.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.lblPercentComplete.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.lblPercentComplete.Size = new System.Drawing.Size(74, 13);
            this.lblPercentComplete.Text = "% &Выполнено:";
            // 
            // lblPercentCompleteValue
            // 
            this.lblPercentCompleteValue.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.lblPercentCompleteValue.Location = new System.Drawing.Point(476, 10);
            this.lblPercentCompleteValue.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            // 
            // panelTree
            // 
            this.panelTree.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelTree.Controls.Add(this.treeList);
            this.panelTree.Location = new System.Drawing.Point(521, 35);
            this.panelTree.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panelTree.Name = "panelTree";
            this.panelTree.Size = new System.Drawing.Size(207, 350);
            this.panelTree.TabIndex = 29;
            // 
            // treeList
            // 
            this.treeList.Columns.AddRange(new DevExpress.XtraTreeList.Columns.TreeListColumn[] {
            this.colName});
            this.treeList.DataSource = this.bsSP_GetTreeList;
            this.treeList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.treeList.KeyFieldName = "Id";
            this.treeList.Location = new System.Drawing.Point(0, 0);
            this.treeList.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.treeList.Name = "treeList";
            this.treeList.OptionsBehavior.AllowIncrementalSearch = true;
            this.treeList.OptionsBehavior.AllowRecursiveNodeChecking = true;
            this.treeList.OptionsBehavior.AutoChangeParent = false;
            this.treeList.OptionsBehavior.PopulateServiceColumns = true;
            this.treeList.OptionsBehavior.ReadOnly = true;
            this.treeList.OptionsSelection.MultiSelect = true;
            this.treeList.OptionsSelection.UseIndicatorForSelection = true;
            this.treeList.OptionsView.ShowCheckBoxes = true;
            this.treeList.ParentFieldName = "ParentId";
            this.treeList.PreviewFieldName = "Name";
            this.treeList.ShowButtonMode = DevExpress.XtraTreeList.ShowButtonModeEnum.ShowAlways;
            this.treeList.Size = new System.Drawing.Size(207, 350);
            this.treeList.TabIndex = 0;
            this.treeList.BeforeCheckNode += new DevExpress.XtraTreeList.CheckNodeEventHandler(this.treeList_BeforeCheckNode);
            this.treeList.AfterCheckNode += new DevExpress.XtraTreeList.NodeEventHandler(this.treeList_AfterCheckNode);
            this.treeList.CustomDrawNodeCheckBox += new DevExpress.XtraTreeList.CustomDrawNodeCheckBoxEventHandler(this.treeList_CustomDrawNodeCheckBox);
            // 
            // colName
            // 
            this.colName.Caption = "Пользователь";
            this.colName.FieldName = "Name";
            this.colName.MinWidth = 32;
            this.colName.Name = "colName";
            this.colName.Visible = true;
            this.colName.VisibleIndex = 0;
            this.colName.Width = 288;
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
            this.labelUser.Location = new System.Drawing.Point(16, 8);
            this.labelUser.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.labelUser.Name = "labelUser";
            this.labelUser.Size = new System.Drawing.Size(72, 13);
            this.labelUser.TabIndex = 30;
            this.labelUser.Text = "Пользователь";
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
            // taSP_GetTreeList
            // 
            this.taSP_GetTreeList.ClearBeforeFill = true;
            // 
            // FrmCustomAppointmentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(736, 395);
            this.Controls.Add(this.labelUser);
            this.Controls.Add(this.panelTree);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MinimumSize = new System.Drawing.Size(718, 300);
            this.Name = "FrmCustomAppointmentForm";
            this.Load += new System.EventHandler(this.FrmCustomAppointmentForm_Load);
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
        private System.Windows.Forms.Panel panel2;
        private DevExpress.XtraTreeList.TreeList treeList;
        private System.Windows.Forms.BindingSource bsSP_GetTreeList;
        private GlobalbaseDataSet globalbaseDataSet;
        private GlobalbaseDataSetTableAdapters.SP_GetTreeListTableAdapter taSP_GetTreeList;
        private DevExpress.XtraTreeList.Columns.TreeListColumn colName;
    }
}
