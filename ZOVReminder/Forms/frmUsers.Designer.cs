﻿namespace ZOVReminder.Forms
{
    partial class FrmUsers
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
            this.gridControl = new DevExpress.XtraGrid.GridControl();
            this.bsZOVReminderUsers = new System.Windows.Forms.BindingSource(this.components);
            this.globalbaseDataSet = new ZOVReminder.GlobalbaseDataSet();
            this.gridView = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colZOVReminderUsersID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colUserName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPasswordMD5 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPermissions = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colLastLogon = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colLastLogOff = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colUserNameChange = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPasswordChange = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPermissionsChange = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colUserCreated = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colLastEditTime = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colReadOnly = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSendToAll = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colEnabled = new DevExpress.XtraGrid.Columns.GridColumn();
            this.taZOVReminderUsers = new ZOVReminder.GlobalbaseDataSetTableAdapters.ZOVReminderUsersTableAdapter();
            this.pageTree = new DevExpress.XtraTab.XtraTabPage();
            this.splitTree = new DevExpress.XtraEditors.SplitContainerControl();
            this.gridTreeUsers = new DevExpress.XtraGrid.GridControl();
            this.vwUsersForTree = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colZOVReminderUsersID1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn14 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colReadOnly1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSendToAll1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.treeListUsers = new DevExpress.XtraTreeList.TreeList();
            this.colId = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.colParentId = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.colName = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.bsSP_GetTreeList = new System.Windows.Forms.BindingSource(this.components);
            this.taSP_GetTreeList = new ZOVReminder.GlobalbaseDataSetTableAdapters.SP_GetTreeListTableAdapter();
            this.colAdvancePaynemt = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCompleted = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colFinalPayment = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colInvoiced = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPaid = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colShiped = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.panelControlBottom)).BeginInit();
            this.panelControlBottom.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControlMain)).BeginInit();
            this.panelControlMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tabMain)).BeginInit();
            this.tabMain.SuspendLayout();
            this.pageMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsZOVReminderUsers)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.globalbaseDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView)).BeginInit();
            this.pageTree.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitTree)).BeginInit();
            this.splitTree.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridTreeUsers)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vwUsersForTree)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.treeListUsers)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsSP_GetTreeList)).BeginInit();
            this.SuspendLayout();
            // 
            // panelControlBottom
            // 
            this.panelControlBottom.Location = new System.Drawing.Point(0, 399);
            this.panelControlBottom.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panelControlBottom.Size = new System.Drawing.Size(1020, 33);
            // 
            // btnApply
            // 
            this.btnApply.Location = new System.Drawing.Point(814, 5);
            this.btnApply.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.btnApply.Click += new System.EventHandler(this.btnApply_Click);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(925, 5);
            this.btnClose.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            // 
            // panelControlMain
            // 
            this.panelControlMain.Controls.Add(this.gridControl);
            this.panelControlMain.Margin = new System.Windows.Forms.Padding(3);
            this.panelControlMain.Size = new System.Drawing.Size(1014, 371);
            // 
            // tabMain
            // 
            this.tabMain.Margin = new System.Windows.Forms.Padding(1);
            this.tabMain.ShowTabHeader = DevExpress.Utils.DefaultBoolean.True;
            this.tabMain.Size = new System.Drawing.Size(1020, 399);
            this.tabMain.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] {
            this.pageTree});
            this.tabMain.Controls.SetChildIndex(this.pageTree, 0);
            this.tabMain.Controls.SetChildIndex(this.pageMain, 0);
            // 
            // pageMain
            // 
            this.pageMain.Margin = new System.Windows.Forms.Padding(1);
            this.pageMain.Size = new System.Drawing.Size(1014, 371);
            this.pageMain.Text = "Пользователи";
            // 
            // gridControl
            // 
            this.gridControl.DataSource = this.bsZOVReminderUsers;
            this.gridControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl.EmbeddedNavigator.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsZOVReminderUsers, "ZOVReminderUsersID", true));
            this.gridControl.Location = new System.Drawing.Point(2, 2);
            this.gridControl.MainView = this.gridView;
            this.gridControl.Name = "gridControl";
            this.gridControl.Size = new System.Drawing.Size(1010, 367);
            this.gridControl.TabIndex = 2;
            this.gridControl.UseEmbeddedNavigator = true;
            this.gridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView});
            // 
            // bsZOVReminderUsers
            // 
            this.bsZOVReminderUsers.DataMember = "ZOVReminderUsers";
            this.bsZOVReminderUsers.DataSource = this.globalbaseDataSet;
            // 
            // globalbaseDataSet
            // 
            this.globalbaseDataSet.DataSetName = "GlobalbaseDataSet";
            this.globalbaseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gridView
            // 
            this.gridView.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.gridView.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colZOVReminderUsersID,
            this.colUserName,
            this.colPasswordMD5,
            this.colPermissions,
            this.colLastLogon,
            this.colLastLogOff,
            this.colUserNameChange,
            this.colPasswordChange,
            this.colPermissionsChange,
            this.colUserCreated,
            this.colLastEditTime,
            this.colReadOnly,
            this.colSendToAll,
            this.colEnabled,
            this.colAdvancePaynemt,
            this.colCompleted,
            this.colFinalPayment,
            this.colInvoiced,
            this.colPaid,
            this.colShiped});
            this.gridView.GridControl = this.gridControl;
            this.gridView.Name = "gridView";
            this.gridView.OptionsBehavior.AllowAddRows = DevExpress.Utils.DefaultBoolean.True;
            this.gridView.OptionsBehavior.AllowDeleteRows = DevExpress.Utils.DefaultBoolean.True;
            this.gridView.OptionsBehavior.FocusLeaveOnTab = true;
            this.gridView.OptionsCustomization.AllowColumnMoving = false;
            this.gridView.OptionsEditForm.ShowUpdateCancelPanel = DevExpress.Utils.DefaultBoolean.True;
            this.gridView.OptionsNavigation.EnterMoveNextColumn = true;
            this.gridView.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Bottom;
            // 
            // colZOVReminderUsersID
            // 
            this.colZOVReminderUsersID.FieldName = "ZOVReminderUsersID";
            this.colZOVReminderUsersID.Name = "colZOVReminderUsersID";
            // 
            // colUserName
            // 
            this.colUserName.Caption = "Пользователь";
            this.colUserName.FieldName = "UserName";
            this.colUserName.Name = "colUserName";
            this.colUserName.Visible = true;
            this.colUserName.VisibleIndex = 0;
            // 
            // colPasswordMD5
            // 
            this.colPasswordMD5.Caption = "Пароль";
            this.colPasswordMD5.FieldName = "PasswordMD5";
            this.colPasswordMD5.Name = "colPasswordMD5";
            this.colPasswordMD5.Visible = true;
            this.colPasswordMD5.VisibleIndex = 1;
            // 
            // colPermissions
            // 
            this.colPermissions.FieldName = "Permissions";
            this.colPermissions.Name = "colPermissions";
            // 
            // colLastLogon
            // 
            this.colLastLogon.Caption = "Последний вход";
            this.colLastLogon.DisplayFormat.FormatString = "dd-MM-yyyy HH:mm";
            this.colLastLogon.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.colLastLogon.FieldName = "LastLogon";
            this.colLastLogon.Name = "colLastLogon";
            this.colLastLogon.Visible = true;
            this.colLastLogon.VisibleIndex = 2;
            // 
            // colLastLogOff
            // 
            this.colLastLogOff.Caption = "Завершение сеанса";
            this.colLastLogOff.DisplayFormat.FormatString = "dd-MM-yyyy HH:mm";
            this.colLastLogOff.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.colLastLogOff.FieldName = "LastLogOff";
            this.colLastLogOff.Name = "colLastLogOff";
            this.colLastLogOff.Visible = true;
            this.colLastLogOff.VisibleIndex = 3;
            // 
            // colUserNameChange
            // 
            this.colUserNameChange.FieldName = "UserNameChange";
            this.colUserNameChange.Name = "colUserNameChange";
            // 
            // colPasswordChange
            // 
            this.colPasswordChange.FieldName = "PasswordChange";
            this.colPasswordChange.Name = "colPasswordChange";
            // 
            // colPermissionsChange
            // 
            this.colPermissionsChange.FieldName = "PermissionsChange";
            this.colPermissionsChange.Name = "colPermissionsChange";
            // 
            // colUserCreated
            // 
            this.colUserCreated.Caption = "Создан";
            this.colUserCreated.DisplayFormat.FormatString = "dd-MM-yyyy HH:mm";
            this.colUserCreated.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.colUserCreated.FieldName = "UserCreated";
            this.colUserCreated.Name = "colUserCreated";
            this.colUserCreated.Visible = true;
            this.colUserCreated.VisibleIndex = 4;
            // 
            // colLastEditTime
            // 
            this.colLastEditTime.Caption = "Изменен";
            this.colLastEditTime.DisplayFormat.FormatString = "dd-MM-yyyy HH:mm";
            this.colLastEditTime.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.colLastEditTime.FieldName = "LastEditTime";
            this.colLastEditTime.Name = "colLastEditTime";
            this.colLastEditTime.Visible = true;
            this.colLastEditTime.VisibleIndex = 5;
            // 
            // colReadOnly
            // 
            this.colReadOnly.Caption = "Только для чтения";
            this.colReadOnly.FieldName = "ReadOnly";
            this.colReadOnly.Name = "colReadOnly";
            this.colReadOnly.Visible = true;
            this.colReadOnly.VisibleIndex = 6;
            // 
            // colSendToAll
            // 
            this.colSendToAll.Caption = "Всем";
            this.colSendToAll.FieldName = "SendToAll";
            this.colSendToAll.Name = "colSendToAll";
            this.colSendToAll.Visible = true;
            this.colSendToAll.VisibleIndex = 7;
            // 
            // colEnabled
            // 
            this.colEnabled.Caption = "Включен";
            this.colEnabled.FieldName = "Enabled";
            this.colEnabled.Name = "colEnabled";
            this.colEnabled.Visible = true;
            this.colEnabled.VisibleIndex = 8;
            // 
            // taZOVReminderUsers
            // 
            this.taZOVReminderUsers.ClearBeforeFill = true;
            // 
            // pageTree
            // 
            this.pageTree.Controls.Add(this.splitTree);
            this.pageTree.Margin = new System.Windows.Forms.Padding(2);
            this.pageTree.Name = "pageTree";
            this.pageTree.Size = new System.Drawing.Size(613, 228);
            this.pageTree.Text = "Дерево";
            // 
            // splitTree
            // 
            this.splitTree.CollapsePanel = DevExpress.XtraEditors.SplitCollapsePanel.Panel1;
            this.splitTree.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitTree.Location = new System.Drawing.Point(0, 0);
            this.splitTree.Margin = new System.Windows.Forms.Padding(2);
            this.splitTree.Name = "splitTree";
            this.splitTree.Panel1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Flat;
            this.splitTree.Panel1.Controls.Add(this.gridTreeUsers);
            this.splitTree.Panel1.Text = "Panel1";
            this.splitTree.Panel2.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Flat;
            this.splitTree.Panel2.Controls.Add(this.treeListUsers);
            this.splitTree.Panel2.Text = "Panel2";
            this.splitTree.Size = new System.Drawing.Size(613, 228);
            this.splitTree.SplitterPosition = 456;
            this.splitTree.TabIndex = 1;
            // 
            // gridTreeUsers
            // 
            this.gridTreeUsers.DataSource = this.bsZOVReminderUsers;
            this.gridTreeUsers.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridTreeUsers.EmbeddedNavigator.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsZOVReminderUsers, "ZOVReminderUsersID", true));
            this.gridTreeUsers.Location = new System.Drawing.Point(0, 0);
            this.gridTreeUsers.MainView = this.vwUsersForTree;
            this.gridTreeUsers.Name = "gridTreeUsers";
            this.gridTreeUsers.Size = new System.Drawing.Size(452, 224);
            this.gridTreeUsers.TabIndex = 3;
            this.gridTreeUsers.UseEmbeddedNavigator = true;
            this.gridTreeUsers.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.vwUsersForTree});
            // 
            // vwUsersForTree
            // 
            this.vwUsersForTree.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.vwUsersForTree.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colZOVReminderUsersID1,
            this.gridColumn1,
            this.gridColumn2,
            this.gridColumn14,
            this.colReadOnly1,
            this.colSendToAll1});
            this.vwUsersForTree.GridControl = this.gridTreeUsers;
            this.vwUsersForTree.Name = "vwUsersForTree";
            this.vwUsersForTree.OptionsBehavior.AllowAddRows = DevExpress.Utils.DefaultBoolean.False;
            this.vwUsersForTree.OptionsBehavior.AllowDeleteRows = DevExpress.Utils.DefaultBoolean.False;
            this.vwUsersForTree.OptionsBehavior.FocusLeaveOnTab = true;
            this.vwUsersForTree.OptionsBehavior.ReadOnly = true;
            this.vwUsersForTree.OptionsCustomization.AllowColumnMoving = false;
            this.vwUsersForTree.OptionsEditForm.ShowUpdateCancelPanel = DevExpress.Utils.DefaultBoolean.True;
            this.vwUsersForTree.OptionsNavigation.EnterMoveNextColumn = true;
            this.vwUsersForTree.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(this.vwUsersForTree_FocusedRowChanged);
            // 
            // colZOVReminderUsersID1
            // 
            this.colZOVReminderUsersID1.FieldName = "ZOVReminderUsersID";
            this.colZOVReminderUsersID1.Name = "colZOVReminderUsersID1";
            // 
            // gridColumn1
            // 
            this.gridColumn1.FieldName = "ZOVReminderUsersID";
            this.gridColumn1.Name = "gridColumn1";
            // 
            // gridColumn2
            // 
            this.gridColumn2.Caption = "Пользователь";
            this.gridColumn2.FieldName = "UserName";
            this.gridColumn2.Name = "gridColumn2";
            this.gridColumn2.Visible = true;
            this.gridColumn2.VisibleIndex = 0;
            // 
            // gridColumn14
            // 
            this.gridColumn14.Caption = "Включен";
            this.gridColumn14.FieldName = "Enabled";
            this.gridColumn14.Name = "gridColumn14";
            this.gridColumn14.Visible = true;
            this.gridColumn14.VisibleIndex = 1;
            // 
            // colReadOnly1
            // 
            this.colReadOnly1.Caption = "Только для чтения";
            this.colReadOnly1.FieldName = "ReadOnly";
            this.colReadOnly1.Name = "colReadOnly1";
            this.colReadOnly1.Visible = true;
            this.colReadOnly1.VisibleIndex = 2;
            // 
            // colSendToAll1
            // 
            this.colSendToAll1.Caption = "Отправить всем";
            this.colSendToAll1.FieldName = "SendToAll";
            this.colSendToAll1.Name = "colSendToAll1";
            this.colSendToAll1.Visible = true;
            this.colSendToAll1.VisibleIndex = 3;
            // 
            // treeListUsers
            // 
            this.treeListUsers.Columns.AddRange(new DevExpress.XtraTreeList.Columns.TreeListColumn[] {
            this.colId,
            this.colParentId,
            this.colName});
            this.treeListUsers.DataSource = this.bsSP_GetTreeList;
            this.treeListUsers.Dock = System.Windows.Forms.DockStyle.Fill;
            this.treeListUsers.KeyFieldName = "Id";
            this.treeListUsers.Location = new System.Drawing.Point(0, 0);
            this.treeListUsers.Margin = new System.Windows.Forms.Padding(2);
            this.treeListUsers.Name = "treeListUsers";
            this.treeListUsers.OptionsBehavior.PopulateServiceColumns = true;
            this.treeListUsers.OptionsLayout.AddNewColumns = false;
            this.treeListUsers.OptionsSelection.MultiSelect = true;
            this.treeListUsers.OptionsSelection.UseIndicatorForSelection = true;
            this.treeListUsers.OptionsView.ShowCheckBoxes = true;
            this.treeListUsers.ParentFieldName = "ParentId";
            this.treeListUsers.Size = new System.Drawing.Size(148, 224);
            this.treeListUsers.TabIndex = 0;
            this.treeListUsers.AfterCheckNode += new DevExpress.XtraTreeList.NodeEventHandler(this.treeListUsers_AfterCheckNode);
            // 
            // colId
            // 
            this.colId.FieldName = "Id";
            this.colId.Name = "colId";
            this.colId.OptionsColumn.AllowEdit = false;
            this.colId.OptionsColumn.ReadOnly = true;
            this.colId.Width = 55;
            // 
            // colParentId
            // 
            this.colParentId.FieldName = "ParentId";
            this.colParentId.Name = "colParentId";
            this.colParentId.OptionsColumn.AllowEdit = false;
            this.colParentId.OptionsColumn.ReadOnly = true;
            this.colParentId.Width = 157;
            // 
            // colName
            // 
            this.colName.FieldName = "Name";
            this.colName.MinWidth = 32;
            this.colName.Name = "colName";
            this.colName.OptionsColumn.AllowEdit = false;
            this.colName.OptionsColumn.ReadOnly = true;
            this.colName.Visible = true;
            this.colName.VisibleIndex = 0;
            this.colName.Width = 257;
            // 
            // bsSP_GetTreeList
            // 
            this.bsSP_GetTreeList.DataMember = "SP_GetTreeList";
            this.bsSP_GetTreeList.DataSource = this.globalbaseDataSet;
            // 
            // taSP_GetTreeList
            // 
            this.taSP_GetTreeList.ClearBeforeFill = true;
            // 
            // colAdvancePaynemt
            // 
            this.colAdvancePaynemt.Caption = "Предв. расчет";
            this.colAdvancePaynemt.FieldName = "AdvancePaynemt";
            this.colAdvancePaynemt.Name = "colAdvancePaynemt";
            this.colAdvancePaynemt.Visible = true;
            this.colAdvancePaynemt.VisibleIndex = 9;
            // 
            // colCompleted
            // 
            this.colCompleted.Caption = "Комплектация";
            this.colCompleted.FieldName = "Completed";
            this.colCompleted.Name = "colCompleted";
            this.colCompleted.Visible = true;
            this.colCompleted.VisibleIndex = 10;
            // 
            // colFinalPayment
            // 
            this.colFinalPayment.Caption = "Оконч. расчет";
            this.colFinalPayment.FieldName = "FinalPayment";
            this.colFinalPayment.Name = "colFinalPayment";
            this.colFinalPayment.Visible = true;
            this.colFinalPayment.VisibleIndex = 11;
            // 
            // colInvoiced
            // 
            this.colInvoiced.Caption = "Счет фактура";
            this.colInvoiced.FieldName = "Invoiced";
            this.colInvoiced.Name = "colInvoiced";
            this.colInvoiced.Visible = true;
            this.colInvoiced.VisibleIndex = 12;
            // 
            // colPaid
            // 
            this.colPaid.Caption = "Оплачено";
            this.colPaid.FieldName = "Paid";
            this.colPaid.Name = "colPaid";
            this.colPaid.Visible = true;
            this.colPaid.VisibleIndex = 13;
            // 
            // colShiped
            // 
            this.colShiped.Caption = "Отгружено";
            this.colShiped.FieldName = "Shiped";
            this.colShiped.Name = "colShiped";
            this.colShiped.Visible = true;
            this.colShiped.VisibleIndex = 14;
            // 
            // FrmUsers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1020, 432);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FrmUsers";
            this.Text = " ";
            this.Load += new System.EventHandler(this.frmUsers_Load);
            ((System.ComponentModel.ISupportInitialize)(this.panelControlBottom)).EndInit();
            this.panelControlBottom.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.panelControlMain)).EndInit();
            this.panelControlMain.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.tabMain)).EndInit();
            this.tabMain.ResumeLayout(false);
            this.pageMain.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsZOVReminderUsers)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.globalbaseDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView)).EndInit();
            this.pageTree.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitTree)).EndInit();
            this.splitTree.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridTreeUsers)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vwUsersForTree)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.treeListUsers)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsSP_GetTreeList)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView;
        private GlobalbaseDataSet globalbaseDataSet;
        private System.Windows.Forms.BindingSource bsZOVReminderUsers;
        private GlobalbaseDataSetTableAdapters.ZOVReminderUsersTableAdapter taZOVReminderUsers;
        private DevExpress.XtraGrid.Columns.GridColumn colZOVReminderUsersID;
        private DevExpress.XtraGrid.Columns.GridColumn colUserName;
        private DevExpress.XtraGrid.Columns.GridColumn colPasswordMD5;
        private DevExpress.XtraGrid.Columns.GridColumn colPermissions;
        private DevExpress.XtraGrid.Columns.GridColumn colLastLogon;
        private DevExpress.XtraGrid.Columns.GridColumn colLastLogOff;
        private DevExpress.XtraGrid.Columns.GridColumn colUserNameChange;
        private DevExpress.XtraGrid.Columns.GridColumn colPasswordChange;
        private DevExpress.XtraGrid.Columns.GridColumn colPermissionsChange;
        private DevExpress.XtraGrid.Columns.GridColumn colUserCreated;
        private DevExpress.XtraGrid.Columns.GridColumn colLastEditTime;
        private DevExpress.XtraGrid.Columns.GridColumn colReadOnly;
        private DevExpress.XtraGrid.Columns.GridColumn colSendToAll;
        private DevExpress.XtraGrid.Columns.GridColumn colEnabled;
        private DevExpress.XtraTab.XtraTabPage pageTree;
        private DevExpress.XtraEditors.SplitContainerControl splitTree;
        private DevExpress.XtraGrid.GridControl gridTreeUsers;
        private DevExpress.XtraGrid.Views.Grid.GridView vwUsersForTree;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn14;
        private DevExpress.XtraGrid.Columns.GridColumn colReadOnly1;
        private DevExpress.XtraGrid.Columns.GridColumn colSendToAll1;
        private DevExpress.XtraTreeList.TreeList treeListUsers;
        private DevExpress.XtraGrid.Columns.GridColumn colZOVReminderUsersID1;
        private DevExpress.XtraTreeList.Columns.TreeListColumn colId;
        private DevExpress.XtraTreeList.Columns.TreeListColumn colParentId;
        private DevExpress.XtraTreeList.Columns.TreeListColumn colName;
        private System.Windows.Forms.BindingSource bsSP_GetTreeList;
        private GlobalbaseDataSetTableAdapters.SP_GetTreeListTableAdapter taSP_GetTreeList;
        private DevExpress.XtraGrid.Columns.GridColumn colAdvancePaynemt;
        private DevExpress.XtraGrid.Columns.GridColumn colCompleted;
        private DevExpress.XtraGrid.Columns.GridColumn colFinalPayment;
        private DevExpress.XtraGrid.Columns.GridColumn colInvoiced;
        private DevExpress.XtraGrid.Columns.GridColumn colPaid;
        private DevExpress.XtraGrid.Columns.GridColumn colShiped;
    }
}