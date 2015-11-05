namespace ZOVReminder.Forms
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
            this.zOVReminderUsersTableAdapter = new ZOVReminder.GlobalbaseDataSetTableAdapters.ZOVReminderUsersTableAdapter();
            this.colEnabled = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colReadOnly = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSendToAll = new DevExpress.XtraGrid.Columns.GridColumn();
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
            this.panelControlBottom.Location = new System.Drawing.Point(0, 248);
            this.panelControlBottom.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panelControlBottom.Size = new System.Drawing.Size(931, 33);
            // 
            // btnApply
            // 
            this.btnApply.Location = new System.Drawing.Point(638, 5);
            this.btnApply.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(787, 5);
            this.btnClose.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            // 
            // panelControlMain
            // 
            this.panelControlMain.Controls.Add(this.gridControl);
            this.panelControlMain.Margin = new System.Windows.Forms.Padding(3);
            this.panelControlMain.Size = new System.Drawing.Size(931, 248);
            // 
            // gridControl
            // 
            this.gridControl.DataSource = this.zOVReminderUsersBindingSource;
            this.gridControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl.EmbeddedNavigator.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.zOVReminderUsersBindingSource, "ZOVReminderUsersID", true));
            this.gridControl.Location = new System.Drawing.Point(2, 2);
            this.gridControl.MainView = this.gridView;
            this.gridControl.Name = "gridControl";
            this.gridControl.Size = new System.Drawing.Size(927, 244);
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
            this.colEnabled});
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
            // zOVReminderUsersTableAdapter
            // 
            this.zOVReminderUsersTableAdapter.ClearBeforeFill = true;
            // 
            // colEnabled
            // 
            this.colEnabled.Caption = "Включен";
            this.colEnabled.FieldName = "Enabled";
            this.colEnabled.Name = "colEnabled";
            this.colEnabled.Visible = true;
            this.colEnabled.VisibleIndex = 8;
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
            // FrmUsers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(931, 281);
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
    }
}