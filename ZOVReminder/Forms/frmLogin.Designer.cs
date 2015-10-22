﻿namespace ZOVReminder
{
    partial class frmLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLogin));
            this.panelControlLeft = new DevExpress.XtraEditors.PanelControl();
            this.pictureEdit = new DevExpress.XtraEditors.PictureEdit();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.comboBoxUsers = new DevExpress.XtraEditors.ComboBoxEdit();
            this.panelControl2 = new DevExpress.XtraEditors.PanelControl();
            this.btnCancel = new DevExpress.XtraEditors.SimpleButton();
            this.btnLogin = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControlUserName = new DevExpress.XtraEditors.LabelControl();
            this.textEditPwd = new DevExpress.XtraEditors.TextEdit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControlLeft)).BeginInit();
            this.panelControlLeft.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.comboBoxUsers.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).BeginInit();
            this.panelControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.textEditPwd.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // panelControlLeft
            // 
            this.panelControlLeft.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.panelControlLeft.Controls.Add(this.pictureEdit);
            this.panelControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelControlLeft.Location = new System.Drawing.Point(0, 0);
            this.panelControlLeft.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panelControlLeft.Name = "panelControlLeft";
            this.panelControlLeft.Size = new System.Drawing.Size(146, 189);
            this.panelControlLeft.TabIndex = 2;
            // 
            // pictureEdit
            // 
            this.pictureEdit.AllowHtmlTextInToolTip = DevExpress.Utils.DefaultBoolean.False;
            this.pictureEdit.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureEdit.EditValue = ((object)(resources.GetObject("pictureEdit.EditValue")));
            this.pictureEdit.Location = new System.Drawing.Point(0, 0);
            this.pictureEdit.Name = "pictureEdit";
            this.pictureEdit.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.pictureEdit.Properties.ReadOnly = true;
            this.pictureEdit.Properties.ShowMenu = false;
            this.pictureEdit.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Stretch;
            this.pictureEdit.Size = new System.Drawing.Size(146, 189);
            this.pictureEdit.TabIndex = 0;
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.comboBoxUsers);
            this.panelControl1.Controls.Add(this.panelControl2);
            this.panelControl1.Controls.Add(this.labelControl2);
            this.panelControl1.Controls.Add(this.labelControlUserName);
            this.panelControl1.Controls.Add(this.textEditPwd);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelControl1.Location = new System.Drawing.Point(146, 0);
            this.panelControl1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(348, 189);
            this.panelControl1.TabIndex = 3;
            // 
            // comboBoxUsers
            // 
            this.comboBoxUsers.Location = new System.Drawing.Point(153, 18);
            this.comboBoxUsers.Name = "comboBoxUsers";
            this.comboBoxUsers.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.comboBoxUsers.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.comboBoxUsers.Size = new System.Drawing.Size(174, 26);
            this.comboBoxUsers.TabIndex = 11;
            // 
            // panelControl2
            // 
            this.panelControl2.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.panelControl2.Controls.Add(this.btnCancel);
            this.panelControl2.Controls.Add(this.btnLogin);
            this.panelControl2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelControl2.Location = new System.Drawing.Point(2, 130);
            this.panelControl2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panelControl2.Name = "panelControl2";
            this.panelControl2.Size = new System.Drawing.Size(344, 57);
            this.panelControl2.TabIndex = 10;
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(28, 9);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(112, 35);
            this.btnCancel.TabIndex = 0;
            this.btnCancel.Text = "Отмена";
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnLogin
            // 
            this.btnLogin.Location = new System.Drawing.Point(212, 9);
            this.btnLogin.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(112, 35);
            this.btnLogin.TabIndex = 0;
            this.btnLogin.Text = "Вход";
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(88, 63);
            this.labelControl2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(54, 19);
            this.labelControl2.TabIndex = 8;
            this.labelControl2.Text = "Пароль";
            // 
            // labelControlUserName
            // 
            this.labelControlUserName.Location = new System.Drawing.Point(36, 23);
            this.labelControlUserName.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.labelControlUserName.Name = "labelControlUserName";
            this.labelControlUserName.Size = new System.Drawing.Size(102, 19);
            this.labelControlUserName.TabIndex = 9;
            this.labelControlUserName.Text = "Пользователь";
            // 
            // textEditPwd
            // 
            this.textEditPwd.EditValue = "";
            this.textEditPwd.Location = new System.Drawing.Point(153, 58);
            this.textEditPwd.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textEditPwd.Name = "textEditPwd";
            this.textEditPwd.Properties.PasswordChar = '*';
            this.textEditPwd.Size = new System.Drawing.Size(176, 26);
            this.textEditPwd.TabIndex = 6;
            this.textEditPwd.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textEditPwd_KeyDown);
            // 
            // FrmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(494, 189);
            this.ControlBox = false;
            this.Controls.Add(this.panelControl1);
            this.Controls.Add(this.panelControlLeft);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Авторизация";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmLogin_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.panelControlLeft)).EndInit();
            this.panelControlLeft.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panelControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.comboBoxUsers.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).EndInit();
            this.panelControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.textEditPwd.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.PanelControl panelControlLeft;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControlUserName;
        private DevExpress.XtraEditors.TextEdit textEditPwd;
        private DevExpress.XtraEditors.PanelControl panelControl2;
        private DevExpress.XtraEditors.SimpleButton btnCancel;
        private DevExpress.XtraEditors.SimpleButton btnLogin;
        private DevExpress.XtraEditors.PictureEdit pictureEdit;
        private DevExpress.XtraEditors.ComboBoxEdit comboBoxUsers;

    }
}