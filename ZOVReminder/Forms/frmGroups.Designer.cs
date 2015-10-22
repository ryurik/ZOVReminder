namespace ZOVReminder.Forms
{
    partial class frmGroups
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
            this.gridControl = new DevExpress.XtraGrid.GridControl();
            this.zOVReminderGroupsBindingSource = new System.Windows.Forms.BindingSource();
            this.globalbaseDataSet = new ZOVReminder.GlobalbaseDataSet();
            this.gridView = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colZOVReminderGroupsID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNote = new DevExpress.XtraGrid.Columns.GridColumn();
            this.panelControlBottom = new DevExpress.XtraEditors.PanelControl();
            this.simpleButtonApply = new DevExpress.XtraEditors.SimpleButton();
            this.btnClose = new DevExpress.XtraEditors.SimpleButton();
            this.zOVReminderGroupsTableAdapter = new ZOVReminder.GlobalbaseDataSetTableAdapters.ZOVReminderGroupsTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.zOVReminderGroupsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.globalbaseDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControlBottom)).BeginInit();
            this.panelControlBottom.SuspendLayout();
            this.SuspendLayout();
            // 
            // gridControl
            // 
            this.gridControl.DataSource = this.zOVReminderGroupsBindingSource;
            this.gridControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl.Location = new System.Drawing.Point(0, 0);
            this.gridControl.MainView = this.gridView;
            this.gridControl.Name = "gridControl";
            this.gridControl.Size = new System.Drawing.Size(785, 303);
            this.gridControl.TabIndex = 0;
            this.gridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView});
            // 
            // zOVReminderGroupsBindingSource
            // 
            this.zOVReminderGroupsBindingSource.DataMember = "ZOVReminderGroups";
            this.zOVReminderGroupsBindingSource.DataSource = this.globalbaseDataSet;
            // 
            // globalbaseDataSet
            // 
            this.globalbaseDataSet.DataSetName = "GlobalbaseDataSet";
            this.globalbaseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gridView
            // 
            this.gridView.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colZOVReminderGroupsID,
            this.colName,
            this.colNote});
            this.gridView.GridControl = this.gridControl;
            this.gridView.Name = "gridView";
            this.gridView.OptionsBehavior.AllowAddRows = DevExpress.Utils.DefaultBoolean.True;
            this.gridView.OptionsBehavior.AllowDeleteRows = DevExpress.Utils.DefaultBoolean.True;
            // 
            // colZOVReminderGroupsID
            // 
            this.colZOVReminderGroupsID.FieldName = "ZOVReminderGroupsID";
            this.colZOVReminderGroupsID.Name = "colZOVReminderGroupsID";
            // 
            // colName
            // 
            this.colName.FieldName = "Name";
            this.colName.Name = "colName";
            this.colName.Visible = true;
            this.colName.VisibleIndex = 0;
            // 
            // colNote
            // 
            this.colNote.FieldName = "Note";
            this.colNote.Name = "colNote";
            this.colNote.Visible = true;
            this.colNote.VisibleIndex = 1;
            // 
            // panelControlBottom
            // 
            this.panelControlBottom.Controls.Add(this.simpleButtonApply);
            this.panelControlBottom.Controls.Add(this.btnClose);
            this.panelControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelControlBottom.Location = new System.Drawing.Point(0, 270);
            this.panelControlBottom.Name = "panelControlBottom";
            this.panelControlBottom.Size = new System.Drawing.Size(785, 33);
            this.panelControlBottom.TabIndex = 1;
            // 
            // simpleButtonApply
            // 
            this.simpleButtonApply.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.simpleButtonApply.Location = new System.Drawing.Point(509, 5);
            this.simpleButtonApply.Name = "simpleButtonApply";
            this.simpleButtonApply.Size = new System.Drawing.Size(129, 23);
            this.simpleButtonApply.TabIndex = 0;
            this.simpleButtonApply.Text = "Применить";
            this.simpleButtonApply.Click += new System.EventHandler(this.simpleButtonApply_Click);
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.Location = new System.Drawing.Point(644, 5);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(129, 23);
            this.btnClose.TabIndex = 0;
            this.btnClose.Text = "Закрыть";
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // zOVReminderGroupsTableAdapter
            // 
            this.zOVReminderGroupsTableAdapter.ClearBeforeFill = true;
            // 
            // frmGroups
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(785, 303);
            this.Controls.Add(this.panelControlBottom);
            this.Controls.Add(this.gridControl);
            this.Name = "frmGroups";
            this.Text = "Группы";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmGroups_FormClosing);
            this.Load += new System.EventHandler(this.frmGroups_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.zOVReminderGroupsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.globalbaseDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControlBottom)).EndInit();
            this.panelControlBottom.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView;
        private DevExpress.XtraEditors.PanelControl panelControlBottom;
        private DevExpress.XtraGrid.Columns.GridColumn colZOVReminderGroupsID;
        private DevExpress.XtraGrid.Columns.GridColumn colName;
        private DevExpress.XtraGrid.Columns.GridColumn colNote;
        private GlobalbaseDataSet globalbaseDataSet;
        private System.Windows.Forms.BindingSource zOVReminderGroupsBindingSource;
        private GlobalbaseDataSetTableAdapters.ZOVReminderGroupsTableAdapter zOVReminderGroupsTableAdapter;
        private DevExpress.XtraEditors.SimpleButton btnClose;
        private DevExpress.XtraEditors.SimpleButton simpleButtonApply;
    }
}