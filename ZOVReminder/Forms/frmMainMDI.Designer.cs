namespace ZOVReminder.Forms
{
    partial class FrmMainMDI
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMainMDI));
            this.menuStripMain = new System.Windows.Forms.MenuStrip();
            this.mToolStripMenuItemFile = new System.Windows.Forms.ToolStripMenuItem();
            this.mToolStripMenuItemCalendar = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.mToolStripMenuItemExit = new System.Windows.Forms.ToolStripMenuItem();
            this.mToolStripMenuItemSettings = new System.Windows.Forms.ToolStripMenuItem();
            this.mToolStripMenuItemPasswords = new System.Windows.Forms.ToolStripMenuItem();
            this.группыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.пользователиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripSeparator();
            this.группыИПользователиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.applicationMenu = new DevExpress.XtraBars.Ribbon.ApplicationMenu(this.components);
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabelUserName = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabelConnectionString = new System.Windows.Forms.ToolStripStatusLabel();
            this.notifyIcon = new System.Windows.Forms.NotifyIcon(this.components);
            this.mainContextMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.mContextOpen = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.mContextClose = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStripMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.applicationMenu)).BeginInit();
            this.statusStrip.SuspendLayout();
            this.mainContextMenuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStripMain
            // 
            this.menuStripMain.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(236)))), ((int)(((byte)(239)))));
            this.menuStripMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mToolStripMenuItemFile,
            this.mToolStripMenuItemSettings});
            this.menuStripMain.Location = new System.Drawing.Point(0, 0);
            this.menuStripMain.Name = "menuStripMain";
            this.menuStripMain.Padding = new System.Windows.Forms.Padding(4, 1, 0, 1);
            this.menuStripMain.Size = new System.Drawing.Size(965, 24);
            this.menuStripMain.TabIndex = 1;
            // 
            // mToolStripMenuItemFile
            // 
            this.mToolStripMenuItemFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mToolStripMenuItemCalendar,
            this.toolStripMenuItem1,
            this.mToolStripMenuItemExit});
            this.mToolStripMenuItemFile.Name = "mToolStripMenuItemFile";
            this.mToolStripMenuItemFile.Size = new System.Drawing.Size(45, 22);
            this.mToolStripMenuItemFile.Text = "Файл";
            // 
            // mToolStripMenuItemCalendar
            // 
            this.mToolStripMenuItemCalendar.Name = "mToolStripMenuItemCalendar";
            this.mToolStripMenuItemCalendar.Size = new System.Drawing.Size(130, 22);
            this.mToolStripMenuItemCalendar.Text = "Календарь";
            this.mToolStripMenuItemCalendar.Click += new System.EventHandler(this.mToolStripMenuItemCalendar_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(127, 6);
            // 
            // mToolStripMenuItemExit
            // 
            this.mToolStripMenuItemExit.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.mToolStripMenuItemExit.Name = "mToolStripMenuItemExit";
            this.mToolStripMenuItemExit.Size = new System.Drawing.Size(130, 22);
            this.mToolStripMenuItemExit.Text = "Выход";
            this.mToolStripMenuItemExit.Click += new System.EventHandler(this.mToolStripMenuItemExit_Click);
            // 
            // mToolStripMenuItemSettings
            // 
            this.mToolStripMenuItemSettings.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mToolStripMenuItemPasswords,
            this.группыToolStripMenuItem,
            this.пользователиToolStripMenuItem,
            this.toolStripMenuItem2,
            this.группыИПользователиToolStripMenuItem});
            this.mToolStripMenuItemSettings.Name = "mToolStripMenuItemSettings";
            this.mToolStripMenuItemSettings.Size = new System.Drawing.Size(73, 22);
            this.mToolStripMenuItemSettings.Text = "Настройка";
            // 
            // mToolStripMenuItemPasswords
            // 
            this.mToolStripMenuItemPasswords.Name = "mToolStripMenuItemPasswords";
            this.mToolStripMenuItemPasswords.Size = new System.Drawing.Size(195, 22);
            this.mToolStripMenuItemPasswords.Text = "Пароли";
            this.mToolStripMenuItemPasswords.Click += new System.EventHandler(this.mToolStripMenuItemPasswords_Click);
            // 
            // группыToolStripMenuItem
            // 
            this.группыToolStripMenuItem.Name = "группыToolStripMenuItem";
            this.группыToolStripMenuItem.Size = new System.Drawing.Size(195, 22);
            this.группыToolStripMenuItem.Text = "Группы";
            this.группыToolStripMenuItem.Click += new System.EventHandler(this.группыToolStripMenuItem_Click);
            // 
            // пользователиToolStripMenuItem
            // 
            this.пользователиToolStripMenuItem.Name = "пользователиToolStripMenuItem";
            this.пользователиToolStripMenuItem.Size = new System.Drawing.Size(195, 22);
            this.пользователиToolStripMenuItem.Text = "Пользователи";
            this.пользователиToolStripMenuItem.Click += new System.EventHandler(this.пользователиToolStripMenuItem_Click);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(192, 6);
            // 
            // группыИПользователиToolStripMenuItem
            // 
            this.группыИПользователиToolStripMenuItem.Name = "группыИПользователиToolStripMenuItem";
            this.группыИПользователиToolStripMenuItem.Size = new System.Drawing.Size(195, 22);
            this.группыИПользователиToolStripMenuItem.Text = "Группы и пользователи";
            this.группыИПользователиToolStripMenuItem.Click += new System.EventHandler(this.группыИПользователиToolStripMenuItem_Click);
            // 
            // applicationMenu
            // 
            this.applicationMenu.Name = "applicationMenu";
            // 
            // statusStrip
            // 
            this.statusStrip.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(236)))), ((int)(((byte)(239)))));
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabelUserName,
            this.toolStripStatusLabelConnectionString});
            this.statusStrip.Location = new System.Drawing.Point(0, 498);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Padding = new System.Windows.Forms.Padding(1, 0, 9, 0);
            this.statusStrip.Size = new System.Drawing.Size(965, 22);
            this.statusStrip.TabIndex = 6;
            // 
            // toolStripStatusLabelUserName
            // 
            this.toolStripStatusLabelUserName.Name = "toolStripStatusLabelUserName";
            this.toolStripStatusLabelUserName.Size = new System.Drawing.Size(56, 17);
            this.toolStripStatusLabelUserName.Text = "UserName";
            // 
            // toolStripStatusLabelConnectionString
            // 
            this.toolStripStatusLabelConnectionString.Name = "toolStripStatusLabelConnectionString";
            this.toolStripStatusLabelConnectionString.Size = new System.Drawing.Size(89, 17);
            this.toolStripStatusLabelConnectionString.Text = "ConnectionString";
            // 
            // notifyIcon
            // 
            this.notifyIcon.ContextMenuStrip = this.mainContextMenuStrip;
            this.notifyIcon.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon.Icon")));
            this.notifyIcon.Text = "Напоминалка";
            this.notifyIcon.Visible = true;
            this.notifyIcon.DoubleClick += new System.EventHandler(this.notifyIcon_DoubleClick);
            // 
            // mainContextMenuStrip
            // 
            this.mainContextMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mContextOpen,
            this.toolStripSeparator1,
            this.mContextClose});
            this.mainContextMenuStrip.Name = "mainContextMenuStrip";
            this.mainContextMenuStrip.Size = new System.Drawing.Size(177, 54);
            // 
            // mContextOpen
            // 
            this.mContextOpen.Name = "mContextOpen";
            this.mContextOpen.Size = new System.Drawing.Size(176, 22);
            this.mContextOpen.Text = "Открыть программу";
            this.mContextOpen.Click += new System.EventHandler(this.mContextOpen_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(173, 6);
            // 
            // mContextClose
            // 
            this.mContextClose.Name = "mContextClose";
            this.mContextClose.Size = new System.Drawing.Size(176, 22);
            this.mContextClose.Text = "Выход";
            this.mContextClose.Click += new System.EventHandler(this.mContextClose_Click);
            // 
            // FrmMainMDI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(236)))), ((int)(((byte)(239)))));
            this.ClientSize = new System.Drawing.Size(965, 520);
            this.Controls.Add(this.statusStrip);
            this.Controls.Add(this.menuStripMain);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.KeyPreview = true;
            this.MainMenuStrip = this.menuStripMain;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "FrmMainMDI";
            this.Text = "Напоминалка";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmMain_FormClosing);
            this.Load += new System.EventHandler(this.frmMainMDI_Load);
            this.Resize += new System.EventHandler(this.FrmMainMDI_Resize);
            this.menuStripMain.ResumeLayout(false);
            this.menuStripMain.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.applicationMenu)).EndInit();
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            this.mainContextMenuStrip.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStripMain;
        private System.Windows.Forms.ToolStripMenuItem mToolStripMenuItemFile;
        private System.Windows.Forms.ToolStripMenuItem mToolStripMenuItemExit;
        private System.Windows.Forms.ToolStripMenuItem mToolStripMenuItemSettings;
        private System.Windows.Forms.ToolStripMenuItem mToolStripMenuItemPasswords;
        private System.Windows.Forms.ToolStripMenuItem mToolStripMenuItemCalendar;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private DevExpress.XtraBars.Ribbon.ApplicationMenu applicationMenu;
        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabelUserName;
        private System.Windows.Forms.NotifyIcon notifyIcon;
        private System.Windows.Forms.ContextMenuStrip mainContextMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem mContextOpen;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem mContextClose;
        private System.Windows.Forms.ToolStripMenuItem группыToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem пользователиToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem группыИПользователиToolStripMenuItem;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabelConnectionString;
    }
}