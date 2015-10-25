namespace ZOVReminder.Forms
{
    partial class frmGroupsAndUsers
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
            this.panelTop = new DevExpress.XtraEditors.PanelControl();
            this.comboBoxGroups = new DevExpress.XtraEditors.ComboBoxEdit();
            this.labelControlGroupName = new DevExpress.XtraEditors.LabelControl();
            this.gridControlLeftUsers = new DevExpress.XtraGrid.GridControl();
            this.gridViewLeftUsers = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.panelMiddle = new System.Windows.Forms.Panel();
            this.simpleButtonFromRightToLeft = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButtonFromLeftToRight = new DevExpress.XtraEditors.SimpleButton();
            this.panelControlRight = new DevExpress.XtraEditors.PanelControl();
            this.gridControlRightUsers = new DevExpress.XtraGrid.GridControl();
            this.gridViewRightUsers = new DevExpress.XtraGrid.Views.Grid.GridView();
            ((System.ComponentModel.ISupportInitialize)(this.panelControlBottom)).BeginInit();
            this.panelControlBottom.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControlMain)).BeginInit();
            this.panelControlMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelTop)).BeginInit();
            this.panelTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.comboBoxGroups.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlLeftUsers)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewLeftUsers)).BeginInit();
            this.panelMiddle.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControlRight)).BeginInit();
            this.panelControlRight.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlRightUsers)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewRightUsers)).BeginInit();
            this.SuspendLayout();
            // 
            // panelControlBottom
            // 
            this.panelControlBottom.Location = new System.Drawing.Point(0, 461);
            this.panelControlBottom.Size = new System.Drawing.Size(1183, 51);
            // 
            // simpleButtonApply
            // 
            this.simpleButtonApply.Location = new System.Drawing.Point(712, 8);
            this.simpleButtonApply.Size = new System.Drawing.Size(196, 35);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(925, 8);
            this.btnClose.Size = new System.Drawing.Size(196, 35);
            // 
            // panelControlMain
            // 
            this.panelControlMain.Controls.Add(this.panelControlRight);
            this.panelControlMain.Controls.Add(this.panelMiddle);
            this.panelControlMain.Controls.Add(this.gridControlLeftUsers);
            this.panelControlMain.Controls.Add(this.panelTop);
            this.panelControlMain.Size = new System.Drawing.Size(1183, 461);
            // 
            // panelTop
            // 
            this.panelTop.Controls.Add(this.comboBoxGroups);
            this.panelTop.Controls.Add(this.labelControlGroupName);
            this.panelTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTop.Location = new System.Drawing.Point(2, 2);
            this.panelTop.Name = "panelTop";
            this.panelTop.Size = new System.Drawing.Size(1179, 50);
            this.panelTop.TabIndex = 0;
            // 
            // comboBoxGroups
            // 
            this.comboBoxGroups.Location = new System.Drawing.Point(77, 12);
            this.comboBoxGroups.Name = "comboBoxGroups";
            this.comboBoxGroups.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.comboBoxGroups.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.comboBoxGroups.Size = new System.Drawing.Size(338, 26);
            this.comboBoxGroups.TabIndex = 15;
            this.comboBoxGroups.SelectedIndexChanged += new System.EventHandler(this.comboBoxGroups_SelectedIndexChanged);
            // 
            // labelControlGroupName
            // 
            this.labelControlGroupName.Location = new System.Drawing.Point(19, 15);
            this.labelControlGroupName.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.labelControlGroupName.Name = "labelControlGroupName";
            this.labelControlGroupName.Size = new System.Drawing.Size(51, 19);
            this.labelControlGroupName.TabIndex = 14;
            this.labelControlGroupName.Text = "Группа";
            // 
            // gridControlLeftUsers
            // 
            this.gridControlLeftUsers.Dock = System.Windows.Forms.DockStyle.Left;
            this.gridControlLeftUsers.Location = new System.Drawing.Point(2, 52);
            this.gridControlLeftUsers.MainView = this.gridViewLeftUsers;
            this.gridControlLeftUsers.Name = "gridControlLeftUsers";
            this.gridControlLeftUsers.Size = new System.Drawing.Size(584, 407);
            this.gridControlLeftUsers.TabIndex = 1;
            this.gridControlLeftUsers.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewLeftUsers});
            // 
            // gridViewLeftUsers
            // 
            this.gridViewLeftUsers.GridControl = this.gridControlLeftUsers;
            this.gridViewLeftUsers.Name = "gridViewLeftUsers";
            this.gridViewLeftUsers.OptionsView.ShowGroupPanel = false;
            // 
            // panelMiddle
            // 
            this.panelMiddle.Controls.Add(this.simpleButtonFromRightToLeft);
            this.panelMiddle.Controls.Add(this.simpleButtonFromLeftToRight);
            this.panelMiddle.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMiddle.Location = new System.Drawing.Point(586, 52);
            this.panelMiddle.Name = "panelMiddle";
            this.panelMiddle.Size = new System.Drawing.Size(97, 407);
            this.panelMiddle.TabIndex = 4;
            // 
            // simpleButtonFromRightToLeft
            // 
            this.simpleButtonFromRightToLeft.Location = new System.Drawing.Point(22, 209);
            this.simpleButtonFromRightToLeft.Name = "simpleButtonFromRightToLeft";
            this.simpleButtonFromRightToLeft.Size = new System.Drawing.Size(60, 23);
            this.simpleButtonFromRightToLeft.TabIndex = 0;
            this.simpleButtonFromRightToLeft.Text = "<<";
            // 
            // simpleButtonFromLeftToRight
            // 
            this.simpleButtonFromLeftToRight.Location = new System.Drawing.Point(22, 167);
            this.simpleButtonFromLeftToRight.Name = "simpleButtonFromLeftToRight";
            this.simpleButtonFromLeftToRight.Size = new System.Drawing.Size(60, 23);
            this.simpleButtonFromLeftToRight.TabIndex = 0;
            this.simpleButtonFromLeftToRight.Text = ">>";
            // 
            // panelControlRight
            // 
            this.panelControlRight.Controls.Add(this.gridControlRightUsers);
            this.panelControlRight.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelControlRight.Location = new System.Drawing.Point(683, 52);
            this.panelControlRight.Name = "panelControlRight";
            this.panelControlRight.Size = new System.Drawing.Size(498, 407);
            this.panelControlRight.TabIndex = 5;
            // 
            // gridControlRightUsers
            // 
            this.gridControlRightUsers.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControlRightUsers.Location = new System.Drawing.Point(2, 2);
            this.gridControlRightUsers.MainView = this.gridViewRightUsers;
            this.gridControlRightUsers.Name = "gridControlRightUsers";
            this.gridControlRightUsers.Size = new System.Drawing.Size(494, 403);
            this.gridControlRightUsers.TabIndex = 0;
            this.gridControlRightUsers.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewRightUsers});
            // 
            // gridViewRightUsers
            // 
            this.gridViewRightUsers.GridControl = this.gridControlRightUsers;
            this.gridViewRightUsers.Name = "gridViewRightUsers";
            this.gridViewRightUsers.OptionsView.ShowGroupPanel = false;
            // 
            // frmGroupsAndUsers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1183, 512);
            this.Margin = new System.Windows.Forms.Padding(3);
            this.Name = "frmGroupsAndUsers";
            this.Text = "Группы и пользователи";
            this.Load += new System.EventHandler(this.frmGroupsAndUsers_Load);
            this.Resize += new System.EventHandler(this.frmGroupsAndUsers_Resize);
            ((System.ComponentModel.ISupportInitialize)(this.panelControlBottom)).EndInit();
            this.panelControlBottom.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.panelControlMain)).EndInit();
            this.panelControlMain.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.panelTop)).EndInit();
            this.panelTop.ResumeLayout(false);
            this.panelTop.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.comboBoxGroups.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlLeftUsers)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewLeftUsers)).EndInit();
            this.panelMiddle.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.panelControlRight)).EndInit();
            this.panelControlRight.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControlRightUsers)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewRightUsers)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.PanelControl panelTop;
        private DevExpress.XtraEditors.ComboBoxEdit comboBoxGroups;
        private DevExpress.XtraEditors.LabelControl labelControlGroupName;
        private DevExpress.XtraGrid.GridControl gridControlLeftUsers;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewLeftUsers;
        private System.Windows.Forms.Panel panelMiddle;
        private DevExpress.XtraEditors.PanelControl panelControlRight;
        private DevExpress.XtraGrid.GridControl gridControlRightUsers;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewRightUsers;
        private DevExpress.XtraEditors.SimpleButton simpleButtonFromRightToLeft;
        private DevExpress.XtraEditors.SimpleButton simpleButtonFromLeftToRight;


    }
}