namespace ZOVReminder.Forms
{
    partial class FrmChat
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
            this.splitContainerControl1 = new DevExpress.XtraEditors.SplitContainerControl();
            this.gridChats = new DevExpress.XtraGrid.GridControl();
            this.vwChats = new DevExpress.XtraGrid.Views.Grid.GridView();
            ((System.ComponentModel.ISupportInitialize)(this.panelControlBottom)).BeginInit();
            this.panelControlBottom.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControlMain)).BeginInit();
            this.panelControlMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tabMain)).BeginInit();
            this.tabMain.SuspendLayout();
            this.pageMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).BeginInit();
            this.splitContainerControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridChats)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vwChats)).BeginInit();
            this.SuspendLayout();
            // 
            // panelControlBottom
            // 
            this.panelControlBottom.Location = new System.Drawing.Point(0, 652);
            this.panelControlBottom.Size = new System.Drawing.Size(1304, 51);
            // 
            // btnApply
            // 
            this.btnApply.Location = new System.Drawing.Point(881, 8);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(1095, 8);
            // 
            // panelControlMain
            // 
            this.panelControlMain.Controls.Add(this.splitContainerControl1);
            this.panelControlMain.Size = new System.Drawing.Size(1296, 644);
            // 
            // tabMain
            // 
            this.tabMain.Size = new System.Drawing.Size(1304, 652);
            // 
            // pageMain
            // 
            this.pageMain.Size = new System.Drawing.Size(1296, 644);
            // 
            // splitContainerControl1
            // 
            this.splitContainerControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerControl1.Location = new System.Drawing.Point(2, 2);
            this.splitContainerControl1.Name = "splitContainerControl1";
            this.splitContainerControl1.Panel1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.splitContainerControl1.Panel1.CaptionLocation = DevExpress.Utils.Locations.Top;
            this.splitContainerControl1.Panel1.Controls.Add(this.gridChats);
            this.splitContainerControl1.Panel1.ShowCaption = true;
            this.splitContainerControl1.Panel1.Text = "Чаты";
            this.splitContainerControl1.Panel2.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.splitContainerControl1.Panel2.CaptionLocation = DevExpress.Utils.Locations.Top;
            this.splitContainerControl1.Panel2.ShowCaption = true;
            this.splitContainerControl1.Panel2.Text = "Сообщения";
            this.splitContainerControl1.Size = new System.Drawing.Size(1292, 640);
            this.splitContainerControl1.SplitterPosition = 594;
            this.splitContainerControl1.TabIndex = 0;
            this.splitContainerControl1.Text = "splitContainerControl1";
            // 
            // gridChats
            // 
            this.gridChats.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridChats.Location = new System.Drawing.Point(0, 0);
            this.gridChats.MainView = this.vwChats;
            this.gridChats.Name = "gridChats";
            this.gridChats.Size = new System.Drawing.Size(590, 609);
            this.gridChats.TabIndex = 0;
            this.gridChats.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.vwChats});
            // 
            // vwChats
            // 
            this.vwChats.GridControl = this.gridChats;
            this.vwChats.Name = "vwChats";
            // 
            // FrmChat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1304, 703);
            this.Name = "FrmChat";
            this.Text = "Информационное поле";
            ((System.ComponentModel.ISupportInitialize)(this.panelControlBottom)).EndInit();
            this.panelControlBottom.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.panelControlMain)).EndInit();
            this.panelControlMain.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.tabMain)).EndInit();
            this.tabMain.ResumeLayout(false);
            this.pageMain.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).EndInit();
            this.splitContainerControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridChats)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vwChats)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.SplitContainerControl splitContainerControl1;
        private DevExpress.XtraGrid.GridControl gridChats;
        private DevExpress.XtraGrid.Views.Grid.GridView vwChats;
    }
}