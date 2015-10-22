namespace ZOVReminder.Forms
{
    partial class frmMainMDI
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMainMDI));
            this.notifyIcon = new System.Windows.Forms.NotifyIcon(this.components);
            this.menuStripMain = new System.Windows.Forms.MenuStrip();
            this.mToolStripMenuItemFile = new System.Windows.Forms.ToolStripMenuItem();
            this.mToolStripMenuItemExit = new System.Windows.Forms.ToolStripMenuItem();
            this.mToolStripMenuItemSettings = new System.Windows.Forms.ToolStripMenuItem();
            this.mToolStripMenuItemPasswords = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStripMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // notifyIcon
            // 
            this.notifyIcon.Text = "notifyIcon1";
            this.notifyIcon.Visible = true;
            // 
            // menuStripMain
            // 
            this.menuStripMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mToolStripMenuItemFile,
            this.mToolStripMenuItemSettings});
            this.menuStripMain.Location = new System.Drawing.Point(0, 0);
            this.menuStripMain.Name = "menuStripMain";
            this.menuStripMain.Size = new System.Drawing.Size(1447, 33);
            this.menuStripMain.TabIndex = 1;
            this.menuStripMain.Text = "menuStrip1";
            // 
            // mToolStripMenuItemFile
            // 
            this.mToolStripMenuItemFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mToolStripMenuItemExit});
            this.mToolStripMenuItemFile.Name = "mToolStripMenuItemFile";
            this.mToolStripMenuItemFile.Size = new System.Drawing.Size(65, 29);
            this.mToolStripMenuItemFile.Text = "Файл";
            // 
            // mToolStripMenuItemExit
            // 
            this.mToolStripMenuItemExit.Name = "mToolStripMenuItemExit";
            this.mToolStripMenuItemExit.Size = new System.Drawing.Size(152, 30);
            this.mToolStripMenuItemExit.Text = "Выход";
            this.mToolStripMenuItemExit.Click += new System.EventHandler(this.mToolStripMenuItemExit_Click);
            // 
            // mToolStripMenuItemSettings
            // 
            this.mToolStripMenuItemSettings.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mToolStripMenuItemPasswords});
            this.mToolStripMenuItemSettings.Name = "mToolStripMenuItemSettings";
            this.mToolStripMenuItemSettings.Size = new System.Drawing.Size(111, 29);
            this.mToolStripMenuItemSettings.Text = "Настройка";
            // 
            // mToolStripMenuItemPasswords
            // 
            this.mToolStripMenuItemPasswords.Name = "mToolStripMenuItemPasswords";
            this.mToolStripMenuItemPasswords.Size = new System.Drawing.Size(152, 30);
            this.mToolStripMenuItemPasswords.Text = "Пароли";
            this.mToolStripMenuItemPasswords.Click += new System.EventHandler(this.mToolStripMenuItemPasswords_Click);
            // 
            // frmMainMDI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1447, 800);
            this.Controls.Add(this.menuStripMain);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.KeyPreview = true;
            this.MainMenuStrip = this.menuStripMain;
            this.Name = "frmMainMDI";
            this.Text = "Напоминалка";
            this.menuStripMain.ResumeLayout(false);
            this.menuStripMain.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NotifyIcon notifyIcon;
        private System.Windows.Forms.MenuStrip menuStripMain;
        private System.Windows.Forms.ToolStripMenuItem mToolStripMenuItemFile;
        private System.Windows.Forms.ToolStripMenuItem mToolStripMenuItemExit;
        private System.Windows.Forms.ToolStripMenuItem mToolStripMenuItemSettings;
        private System.Windows.Forms.ToolStripMenuItem mToolStripMenuItemPasswords;
    }
}