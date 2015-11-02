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
            this.zOVReminderUsersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.globalbaseDataSet = new ZOVReminder.GlobalbaseDataSet();
            this.gridView = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colZOVReminderUsersID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Пользователь = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Пароль = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPermissions = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colLastLogon = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colLastLogOff = new DevExpress.XtraGrid.Columns.GridColumn();
            this.zOVReminderUsersTableAdapter = new ZOVReminder.GlobalbaseDataSetTableAdapters.ZOVReminderUsersTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.panelControlBottom)).BeginInit();
            this.panelControlBottom.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControlMain)).BeginInit();
            this.panelControlMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.zOVReminderUsersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.globalbaseDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView)).BeginInit();
            this.SuspendLayout();
            // 
            // panelControlBottom
            // 
            this.panelControlBottom.Location = new System.Drawing.Point(0, 243);
            this.panelControlBottom.Size = new System.Drawing.Size(628, 33);
            // 
            // simpleButtonApply
            // 
            this.simpleButtonApply.Location = new System.Drawing.Point(162, 5);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(301, 5);
            // 
            // panelControlMain
            // 
            this.panelControlMain.Controls.Add(this.gridControl);
            this.panelControlMain.Size = new System.Drawing.Size(628, 243);
            // 
            // gridControl
            // 
            this.gridControl.DataSource = this.zOVReminderUsersBindingSource;
            this.gridControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl.EmbeddedNavigator.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.zOVReminderUsersBindingSource, "ZOVReminderUsersID", true));
            this.gridControl.Location = new System.Drawing.Point(2, 2);
            this.gridControl.MainView = this.gridView;
            this.gridControl.Name = "gridControl";
            this.gridControl.Size = new System.Drawing.Size(624, 239);
            this.gridControl.TabIndex = 2;
            this.gridControl.UseEmbeddedNavigator = true;
            this.gridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView});
            // 
            // zOVReminderUsersBindingSource
            // 
            this.zOVReminderUsersBindingSource.DataMember = "ZOVReminderUsers";
            this.zOVReminderUsersBindingSource.DataSource = this.globalbaseDataSet;
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
            this.Пользователь,
            this.Пароль,
            this.colPermissions,
            this.colLastLogon,
            this.colLastLogOff});
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
            this.colZOVReminderUsersID.Caption = "ID";
            this.colZOVReminderUsersID.FieldName = "ZOVReminderUsersID";
            this.colZOVReminderUsersID.Name = "colZOVReminderUsersID";
            // 
            // Пользователь
            // 
            this.Пользователь.Caption = "Пользователь";
            this.Пользователь.FieldName = "UserName";
            this.Пользователь.Name = "Пользователь";
            this.Пользователь.Visible = true;
            this.Пользователь.VisibleIndex = 0;
            // 
            // Пароль
            // 
            this.Пароль.Caption = "Пароль";
            this.Пароль.FieldName = "PasswordMD5";
            this.Пароль.Name = "Пароль";
            this.Пароль.OptionsColumn.AllowEdit = false;
            this.Пароль.OptionsColumn.AllowMove = false;
            this.Пароль.OptionsColumn.ReadOnly = true;
            this.Пароль.Visible = true;
            this.Пароль.VisibleIndex = 1;
            // 
            // colPermissions
            // 
            this.colPermissions.FieldName = "Permissions";
            this.colPermissions.Name = "colPermissions";
            // 
            // colLastLogon
            // 
            this.colLastLogon.Caption = "Дата входа";
            this.colLastLogon.DisplayFormat.FormatString = "d";
            this.colLastLogon.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.colLastLogon.FieldName = "LastLogon";
            this.colLastLogon.Name = "colLastLogon";
            this.colLastLogon.OptionsColumn.AllowEdit = false;
            this.colLastLogon.OptionsColumn.ReadOnly = true;
            this.colLastLogon.Visible = true;
            this.colLastLogon.VisibleIndex = 2;
            // 
            // colLastLogOff
            // 
            this.colLastLogOff.Caption = "Дата выхода";
            this.colLastLogOff.DisplayFormat.FormatString = "d";
            this.colLastLogOff.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.colLastLogOff.FieldName = "LastLogOff";
            this.colLastLogOff.Name = "colLastLogOff";
            this.colLastLogOff.OptionsColumn.AllowEdit = false;
            this.colLastLogOff.OptionsColumn.ReadOnly = true;
            this.colLastLogOff.Visible = true;
            this.colLastLogOff.VisibleIndex = 3;
            // 
            // zOVReminderUsersTableAdapter
            // 
            this.zOVReminderUsersTableAdapter.ClearBeforeFill = true;
            // 
            // FrmUsers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(628, 276);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FrmUsers";
            this.Text = "Пользователи";
            this.Load += new System.EventHandler(this.frmUsers_Load);
            ((System.ComponentModel.ISupportInitialize)(this.panelControlBottom)).EndInit();
            this.panelControlBottom.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.panelControlMain)).EndInit();
            this.panelControlMain.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.zOVReminderUsersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.globalbaseDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView;
        private GlobalbaseDataSet globalbaseDataSet;
        private System.Windows.Forms.BindingSource zOVReminderUsersBindingSource;
        private GlobalbaseDataSetTableAdapters.ZOVReminderUsersTableAdapter zOVReminderUsersTableAdapter;
        private DevExpress.XtraGrid.Columns.GridColumn colZOVReminderUsersID;
        private DevExpress.XtraGrid.Columns.GridColumn Пользователь;
        private DevExpress.XtraGrid.Columns.GridColumn Пароль;
        private DevExpress.XtraGrid.Columns.GridColumn colPermissions;
        private DevExpress.XtraGrid.Columns.GridColumn colLastLogon;
        private DevExpress.XtraGrid.Columns.GridColumn colLastLogOff;
    }
}