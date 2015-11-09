namespace ZOVReminder.Forms
{
    partial class FrmGroupsAndUsers
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
            this.panelTop = new DevExpress.XtraEditors.PanelControl();
            this.comboBoxGroups = new System.Windows.Forms.ComboBox();
            this.bsReminderGroups = new System.Windows.Forms.BindingSource(this.components);
            this.globalbaseDataSet = new ZOVReminder.GlobalbaseDataSet();
            this.labelControlGroupName = new DevExpress.XtraEditors.LabelControl();
            this.panelControlRight = new DevExpress.XtraEditors.PanelControl();
            this.zOVReminderUsersAndGroupsGridControl = new DevExpress.XtraGrid.GridControl();
            this.bsUserAndGroups = new System.Windows.Forms.BindingSource(this.components);
            this.gridViewUsersAndGroup = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colZOVReminderUsersAndGroupsID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colZOVReminderGroupsID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colZOVReminderUsersID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemLookUpEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.bsUsers = new System.Windows.Forms.BindingSource(this.components);
            this.readOnly = new DevExpress.XtraGrid.Columns.GridColumn();
            this.panelMiddle = new DevExpress.XtraEditors.PanelControl();
            this.simpleButtonFromRightToLeft = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButtonFromLeftToRight = new DevExpress.XtraEditors.SimpleButton();
            this.panelControl2 = new DevExpress.XtraEditors.PanelControl();
            this.gridControlAllUsers = new DevExpress.XtraGrid.GridControl();
            this.bsUsersForGroup = new System.Windows.Forms.BindingSource(this.components);
            this.gridViewAllUsers = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gcZOVReminderUsersID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemLookUpEdit2 = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.taUsersAndGroups = new ZOVReminder.GlobalbaseDataSetTableAdapters.ZOVReminderUsersAndGroupsTableAdapter();
            this.tableAdapterManager = new ZOVReminder.GlobalbaseDataSetTableAdapters.TableAdapterManager();
            this.taUsers = new ZOVReminder.GlobalbaseDataSetTableAdapters.ZOVReminderUsersTableAdapter();
            this.taReminderGroups = new ZOVReminder.GlobalbaseDataSetTableAdapters.ZOVReminderGroupsTableAdapter();
            this.taUsersForGroup = new ZOVReminder.GlobalbaseDataSetTableAdapters.ZOVReminderUsersForGroupsTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.panelControlBottom)).BeginInit();
            this.panelControlBottom.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControlMain)).BeginInit();
            this.panelControlMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tabMain)).BeginInit();
            this.tabMain.SuspendLayout();
            this.pageMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelTop)).BeginInit();
            this.panelTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bsReminderGroups)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.globalbaseDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControlRight)).BeginInit();
            this.panelControlRight.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.zOVReminderUsersAndGroupsGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsUserAndGroups)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewUsersAndGroup)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemLookUpEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsUsers)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelMiddle)).BeginInit();
            this.panelMiddle.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).BeginInit();
            this.panelControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlAllUsers)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsUsersForGroup)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewAllUsers)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemLookUpEdit2)).BeginInit();
            this.SuspendLayout();
            // 
            // panelControlBottom
            // 
            this.panelControlBottom.Location = new System.Drawing.Point(0, 359);
            this.panelControlBottom.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panelControlBottom.Size = new System.Drawing.Size(860, 33);
            // 
            // btnApply
            // 
            this.btnApply.Location = new System.Drawing.Point(575, 5);
            this.btnApply.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnApply.Size = new System.Drawing.Size(131, 23);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(719, 5);
            this.btnClose.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnClose.Size = new System.Drawing.Size(131, 23);
            // 
            // panelControlMain
            // 
            this.panelControlMain.Controls.Add(this.panelControl2);
            this.panelControlMain.Controls.Add(this.panelMiddle);
            this.panelControlMain.Controls.Add(this.panelControlRight);
            this.panelControlMain.Controls.Add(this.panelTop);
            this.panelControlMain.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.panelControlMain.Size = new System.Drawing.Size(854, 353);
            // 
            // tabMain
            // 
            this.tabMain.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.tabMain.Size = new System.Drawing.Size(860, 359);
            // 
            // pageMain
            // 
            this.pageMain.Margin = new System.Windows.Forms.Padding(3, 3, 3, 3);
            this.pageMain.Size = new System.Drawing.Size(854, 353);
            // 
            // panelTop
            // 
            this.panelTop.Controls.Add(this.comboBoxGroups);
            this.panelTop.Controls.Add(this.labelControlGroupName);
            this.panelTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTop.Location = new System.Drawing.Point(2, 2);
            this.panelTop.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panelTop.Name = "panelTop";
            this.panelTop.Size = new System.Drawing.Size(850, 32);
            this.panelTop.TabIndex = 0;
            // 
            // comboBoxGroups
            // 
            this.comboBoxGroups.DataSource = this.bsReminderGroups;
            this.comboBoxGroups.DisplayMember = "Name";
            this.comboBoxGroups.FormattingEnabled = true;
            this.comboBoxGroups.Location = new System.Drawing.Point(56, 10);
            this.comboBoxGroups.Name = "comboBoxGroups";
            this.comboBoxGroups.Size = new System.Drawing.Size(210, 21);
            this.comboBoxGroups.TabIndex = 15;
            this.comboBoxGroups.ValueMember = "ZOVReminderGroupsID";
            this.comboBoxGroups.SelectedIndexChanged += new System.EventHandler(this.comboBoxGroups_SelectedIndexChanged);
            // 
            // bsReminderGroups
            // 
            this.bsReminderGroups.DataMember = "ZOVReminderGroups";
            this.bsReminderGroups.DataSource = this.globalbaseDataSet;
            // 
            // globalbaseDataSet
            // 
            this.globalbaseDataSet.DataSetName = "GlobalbaseDataSet";
            this.globalbaseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // labelControlGroupName
            // 
            this.labelControlGroupName.Location = new System.Drawing.Point(13, 10);
            this.labelControlGroupName.Name = "labelControlGroupName";
            this.labelControlGroupName.Size = new System.Drawing.Size(36, 13);
            this.labelControlGroupName.TabIndex = 14;
            this.labelControlGroupName.Text = "Группа";
            // 
            // panelControlRight
            // 
            this.panelControlRight.Controls.Add(this.zOVReminderUsersAndGroupsGridControl);
            this.panelControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.panelControlRight.Location = new System.Drawing.Point(438, 34);
            this.panelControlRight.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panelControlRight.Name = "panelControlRight";
            this.panelControlRight.Size = new System.Drawing.Size(414, 317);
            this.panelControlRight.TabIndex = 7;
            // 
            // zOVReminderUsersAndGroupsGridControl
            // 
            this.zOVReminderUsersAndGroupsGridControl.DataSource = this.bsUserAndGroups;
            this.zOVReminderUsersAndGroupsGridControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.zOVReminderUsersAndGroupsGridControl.Location = new System.Drawing.Point(2, 2);
            this.zOVReminderUsersAndGroupsGridControl.MainView = this.gridViewUsersAndGroup;
            this.zOVReminderUsersAndGroupsGridControl.Name = "zOVReminderUsersAndGroupsGridControl";
            this.zOVReminderUsersAndGroupsGridControl.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemLookUpEdit1});
            this.zOVReminderUsersAndGroupsGridControl.Size = new System.Drawing.Size(410, 313);
            this.zOVReminderUsersAndGroupsGridControl.TabIndex = 0;
            this.zOVReminderUsersAndGroupsGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewUsersAndGroup});
            this.zOVReminderUsersAndGroupsGridControl.DoubleClick += new System.EventHandler(this.zOVReminderUsersAndGroupsGridControl_DoubleClick);
            // 
            // bsUserAndGroups
            // 
            this.bsUserAndGroups.DataMember = "ZOVReminderUsersAndGroups";
            this.bsUserAndGroups.DataSource = this.globalbaseDataSet;
            // 
            // gridViewUsersAndGroup
            // 
            this.gridViewUsersAndGroup.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colZOVReminderUsersAndGroupsID,
            this.colZOVReminderGroupsID,
            this.colZOVReminderUsersID,
            this.readOnly});
            this.gridViewUsersAndGroup.GridControl = this.zOVReminderUsersAndGroupsGridControl;
            this.gridViewUsersAndGroup.Name = "gridViewUsersAndGroup";
            this.gridViewUsersAndGroup.OptionsSelection.CheckBoxSelectorColumnWidth = 30;
            this.gridViewUsersAndGroup.OptionsSelection.EnableAppearanceHideSelection = false;
            this.gridViewUsersAndGroup.OptionsSelection.MultiSelect = true;
            this.gridViewUsersAndGroup.OptionsView.ShowGroupPanel = false;
            this.gridViewUsersAndGroup.OptionsView.ShowIndicator = false;
            // 
            // colZOVReminderUsersAndGroupsID
            // 
            this.colZOVReminderUsersAndGroupsID.FieldName = "ZOVReminderUsersAndGroupsID";
            this.colZOVReminderUsersAndGroupsID.Name = "colZOVReminderUsersAndGroupsID";
            // 
            // colZOVReminderGroupsID
            // 
            this.colZOVReminderGroupsID.FieldName = "ZOVReminderGroupsID";
            this.colZOVReminderGroupsID.Name = "colZOVReminderGroupsID";
            // 
            // colZOVReminderUsersID
            // 
            this.colZOVReminderUsersID.Caption = "Пользователи";
            this.colZOVReminderUsersID.ColumnEdit = this.repositoryItemLookUpEdit1;
            this.colZOVReminderUsersID.FieldName = "ZOVReminderUsersID";
            this.colZOVReminderUsersID.Name = "colZOVReminderUsersID";
            this.colZOVReminderUsersID.OptionsColumn.ReadOnly = true;
            this.colZOVReminderUsersID.Visible = true;
            this.colZOVReminderUsersID.VisibleIndex = 0;
            // 
            // repositoryItemLookUpEdit1
            // 
            this.repositoryItemLookUpEdit1.AllowDropDownWhenReadOnly = DevExpress.Utils.DefaultBoolean.False;
            this.repositoryItemLookUpEdit1.AllowMouseWheel = false;
            this.repositoryItemLookUpEdit1.AutoHeight = false;
            this.repositoryItemLookUpEdit1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemLookUpEdit1.DataSource = this.bsUsers;
            this.repositoryItemLookUpEdit1.DisplayMember = "UserName";
            this.repositoryItemLookUpEdit1.Name = "repositoryItemLookUpEdit1";
            this.repositoryItemLookUpEdit1.ReadOnly = true;
            this.repositoryItemLookUpEdit1.ValueMember = "ZOVReminderUsersID";
            // 
            // bsUsers
            // 
            this.bsUsers.DataMember = "ZOVReminderUsers";
            this.bsUsers.DataSource = this.globalbaseDataSet;
            // 
            // readOnly
            // 
            this.readOnly.Caption = "Только для чтения";
            this.readOnly.FieldName = "ReadOnly";
            this.readOnly.Name = "readOnly";
            this.readOnly.Visible = true;
            this.readOnly.VisibleIndex = 1;
            // 
            // panelMiddle
            // 
            this.panelMiddle.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Flat;
            this.panelMiddle.Controls.Add(this.simpleButtonFromRightToLeft);
            this.panelMiddle.Controls.Add(this.simpleButtonFromLeftToRight);
            this.panelMiddle.Dock = System.Windows.Forms.DockStyle.Right;
            this.panelMiddle.Location = new System.Drawing.Point(371, 34);
            this.panelMiddle.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panelMiddle.Name = "panelMiddle";
            this.panelMiddle.Size = new System.Drawing.Size(67, 317);
            this.panelMiddle.TabIndex = 6;
            // 
            // simpleButtonFromRightToLeft
            // 
            this.simpleButtonFromRightToLeft.Location = new System.Drawing.Point(13, 178);
            this.simpleButtonFromRightToLeft.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.simpleButtonFromRightToLeft.Name = "simpleButtonFromRightToLeft";
            this.simpleButtonFromRightToLeft.Size = new System.Drawing.Size(40, 15);
            this.simpleButtonFromRightToLeft.TabIndex = 3;
            this.simpleButtonFromRightToLeft.Text = "<<";
            this.simpleButtonFromRightToLeft.Click += new System.EventHandler(this.simpleButtonFromRightToLeft_Click);
            // 
            // simpleButtonFromLeftToRight
            // 
            this.simpleButtonFromLeftToRight.Location = new System.Drawing.Point(13, 157);
            this.simpleButtonFromLeftToRight.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.simpleButtonFromLeftToRight.Name = "simpleButtonFromLeftToRight";
            this.simpleButtonFromLeftToRight.Size = new System.Drawing.Size(40, 15);
            this.simpleButtonFromLeftToRight.TabIndex = 4;
            this.simpleButtonFromLeftToRight.Text = ">>";
            this.simpleButtonFromLeftToRight.Click += new System.EventHandler(this.simpleButtonFromLeftToRight_Click);
            // 
            // panelControl2
            // 
            this.panelControl2.Controls.Add(this.gridControlAllUsers);
            this.panelControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelControl2.Location = new System.Drawing.Point(2, 34);
            this.panelControl2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panelControl2.Name = "panelControl2";
            this.panelControl2.Size = new System.Drawing.Size(369, 317);
            this.panelControl2.TabIndex = 5;
            // 
            // gridControlAllUsers
            // 
            this.gridControlAllUsers.DataSource = this.bsUsersForGroup;
            this.gridControlAllUsers.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControlAllUsers.Location = new System.Drawing.Point(2, 2);
            this.gridControlAllUsers.MainView = this.gridViewAllUsers;
            this.gridControlAllUsers.Name = "gridControlAllUsers";
            this.gridControlAllUsers.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemLookUpEdit2});
            this.gridControlAllUsers.Size = new System.Drawing.Size(365, 313);
            this.gridControlAllUsers.TabIndex = 1;
            this.gridControlAllUsers.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewAllUsers});
            this.gridControlAllUsers.DoubleClick += new System.EventHandler(this.gridControlAllUsers_DoubleClick);
            // 
            // bsUsersForGroup
            // 
            this.bsUsersForGroup.DataMember = "ZOVReminderUsersForGroups";
            this.bsUsersForGroup.DataSource = this.globalbaseDataSet;
            // 
            // gridViewAllUsers
            // 
            this.gridViewAllUsers.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn1,
            this.gridColumn2,
            this.gcZOVReminderUsersID});
            this.gridViewAllUsers.GridControl = this.gridControlAllUsers;
            this.gridViewAllUsers.Name = "gridViewAllUsers";
            this.gridViewAllUsers.OptionsBehavior.AllowAddRows = DevExpress.Utils.DefaultBoolean.False;
            this.gridViewAllUsers.OptionsBehavior.AllowDeleteRows = DevExpress.Utils.DefaultBoolean.False;
            this.gridViewAllUsers.OptionsBehavior.ReadOnly = true;
            this.gridViewAllUsers.OptionsCustomization.AllowGroup = false;
            this.gridViewAllUsers.OptionsSelection.CheckBoxSelectorColumnWidth = 30;
            this.gridViewAllUsers.OptionsSelection.EnableAppearanceHideSelection = false;
            this.gridViewAllUsers.OptionsSelection.MultiSelect = true;
            this.gridViewAllUsers.OptionsView.ShowGroupPanel = false;
            this.gridViewAllUsers.OptionsView.ShowIndicator = false;
            // 
            // gridColumn1
            // 
            this.gridColumn1.FieldName = "ZOVReminderUsersAndGroupsID";
            this.gridColumn1.Name = "gridColumn1";
            // 
            // gridColumn2
            // 
            this.gridColumn2.FieldName = "ZOVReminderGroupsID";
            this.gridColumn2.Name = "gridColumn2";
            // 
            // gcZOVReminderUsersID
            // 
            this.gcZOVReminderUsersID.Caption = "Пользователи";
            this.gcZOVReminderUsersID.ColumnEdit = this.repositoryItemLookUpEdit2;
            this.gcZOVReminderUsersID.FieldName = "ZOVReminderUsersID";
            this.gcZOVReminderUsersID.Name = "gcZOVReminderUsersID";
            this.gcZOVReminderUsersID.OptionsColumn.AllowEdit = false;
            this.gcZOVReminderUsersID.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.False;
            this.gcZOVReminderUsersID.OptionsColumn.AllowMove = false;
            this.gcZOVReminderUsersID.OptionsColumn.ReadOnly = true;
            this.gcZOVReminderUsersID.Visible = true;
            this.gcZOVReminderUsersID.VisibleIndex = 0;
            // 
            // repositoryItemLookUpEdit2
            // 
            this.repositoryItemLookUpEdit2.AutoHeight = false;
            this.repositoryItemLookUpEdit2.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemLookUpEdit2.DataSource = this.bsUsers;
            this.repositoryItemLookUpEdit2.DisplayMember = "UserName";
            this.repositoryItemLookUpEdit2.Name = "repositoryItemLookUpEdit2";
            this.repositoryItemLookUpEdit2.ValueMember = "ZOVReminderUsersID";
            // 
            // taUsersAndGroups
            // 
            this.taUsersAndGroups.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.UpdateOrder = ZOVReminder.GlobalbaseDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.ZOVAppointmentsTableAdapter = null;
            this.tableAdapterManager.ZOVReminderGroupsTableAdapter = null;
            this.tableAdapterManager.ZOVReminderUsersAndGroupsTableAdapter = this.taUsersAndGroups;
            this.tableAdapterManager.ZOVReminderUsersTableAdapter = null;
            this.tableAdapterManager.ZOVResourcesTableAdapter = null;
            // 
            // taUsers
            // 
            this.taUsers.ClearBeforeFill = true;
            // 
            // taReminderGroups
            // 
            this.taReminderGroups.ClearBeforeFill = true;
            // 
            // taUsersForGroup
            // 
            this.taUsersForGroup.ClearBeforeFill = true;
            // 
            // FrmGroupsAndUsers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(860, 392);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "FrmGroupsAndUsers";
            this.Text = "Группы и пользователи";
            this.Activated += new System.EventHandler(this.FrmGroupsAndUsers_Activated);
            this.Load += new System.EventHandler(this.frmGroupsAndUsers_Load);
            this.Resize += new System.EventHandler(this.frmGroupsAndUsers_Resize);
            ((System.ComponentModel.ISupportInitialize)(this.panelControlBottom)).EndInit();
            this.panelControlBottom.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.panelControlMain)).EndInit();
            this.panelControlMain.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.tabMain)).EndInit();
            this.tabMain.ResumeLayout(false);
            this.pageMain.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.panelTop)).EndInit();
            this.panelTop.ResumeLayout(false);
            this.panelTop.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bsReminderGroups)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.globalbaseDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControlRight)).EndInit();
            this.panelControlRight.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.zOVReminderUsersAndGroupsGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsUserAndGroups)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewUsersAndGroup)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemLookUpEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsUsers)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelMiddle)).EndInit();
            this.panelMiddle.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).EndInit();
            this.panelControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControlAllUsers)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsUsersForGroup)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewAllUsers)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemLookUpEdit2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.PanelControl panelTop;
        private DevExpress.XtraEditors.LabelControl labelControlGroupName;
        private DevExpress.XtraEditors.PanelControl panelControlRight;
        private DevExpress.XtraEditors.PanelControl panelControl2;
        private DevExpress.XtraEditors.PanelControl panelMiddle;
        private DevExpress.XtraEditors.SimpleButton simpleButtonFromRightToLeft;
        private DevExpress.XtraEditors.SimpleButton simpleButtonFromLeftToRight;
        private GlobalbaseDataSet globalbaseDataSet;
        private System.Windows.Forms.BindingSource bsUserAndGroups;
        private GlobalbaseDataSetTableAdapters.ZOVReminderUsersAndGroupsTableAdapter taUsersAndGroups;
        private GlobalbaseDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private DevExpress.XtraGrid.GridControl zOVReminderUsersAndGroupsGridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewUsersAndGroup;
        private DevExpress.XtraGrid.Columns.GridColumn colZOVReminderUsersAndGroupsID;
        private DevExpress.XtraGrid.Columns.GridColumn colZOVReminderGroupsID;
        private DevExpress.XtraGrid.Columns.GridColumn colZOVReminderUsersID;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit repositoryItemLookUpEdit1;
        private System.Windows.Forms.BindingSource bsUsers;
        private GlobalbaseDataSetTableAdapters.ZOVReminderUsersTableAdapter taUsers;
        private System.Windows.Forms.ComboBox comboBoxGroups;
        private System.Windows.Forms.BindingSource bsReminderGroups;
        private GlobalbaseDataSetTableAdapters.ZOVReminderGroupsTableAdapter taReminderGroups;
        private DevExpress.XtraGrid.GridControl gridControlAllUsers;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewAllUsers;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
        private DevExpress.XtraGrid.Columns.GridColumn gcZOVReminderUsersID;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit repositoryItemLookUpEdit2;
        private System.Windows.Forms.BindingSource bsUsersForGroup;
        private GlobalbaseDataSetTableAdapters.ZOVReminderUsersForGroupsTableAdapter taUsersForGroup;
        private DevExpress.XtraGrid.Columns.GridColumn readOnly;


    }
}