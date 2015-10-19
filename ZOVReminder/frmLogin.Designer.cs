namespace ZOVReminder
{
    partial class FrmLogin
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
            this.panelControlLeft = new DevExpress.XtraEditors.PanelControl();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.panelControl2 = new DevExpress.XtraEditors.PanelControl();
            this.btnCancel = new DevExpress.XtraEditors.SimpleButton();
            this.btnLogin = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControlUserName = new DevExpress.XtraEditors.LabelControl();
            this.textEditPwd = new DevExpress.XtraEditors.TextEdit();
            this.textEditUser = new DevExpress.XtraEditors.TextEdit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControlLeft)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).BeginInit();
            this.panelControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.textEditPwd.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEditUser.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // panelControlLeft
            // 
            this.panelControlLeft.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.panelControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelControlLeft.Location = new System.Drawing.Point(0, 0);
            this.panelControlLeft.Name = "panelControlLeft";
            this.panelControlLeft.Size = new System.Drawing.Size(97, 106);
            this.panelControlLeft.TabIndex = 2;
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.panelControl2);
            this.panelControl1.Controls.Add(this.labelControl2);
            this.panelControl1.Controls.Add(this.labelControlUserName);
            this.panelControl1.Controls.Add(this.textEditPwd);
            this.panelControl1.Controls.Add(this.textEditUser);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelControl1.Location = new System.Drawing.Point(97, 0);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(231, 106);
            this.panelControl1.TabIndex = 3;
            // 
            // panelControl2
            // 
            this.panelControl2.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.panelControl2.Controls.Add(this.btnCancel);
            this.panelControl2.Controls.Add(this.btnLogin);
            this.panelControl2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelControl2.Location = new System.Drawing.Point(2, 67);
            this.panelControl2.Name = "panelControl2";
            this.panelControl2.Size = new System.Drawing.Size(227, 37);
            this.panelControl2.TabIndex = 10;
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(142, 9);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 0;
            this.btnCancel.Text = "Отмена";
            // 
            // btnLogin
            // 
            this.btnLogin.Location = new System.Drawing.Point(19, 9);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(75, 23);
            this.btnLogin.TabIndex = 0;
            this.btnLogin.Text = "Вход";
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(59, 41);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(37, 13);
            this.labelControl2.TabIndex = 8;
            this.labelControl2.Text = "Пароль";
            // 
            // labelControlUserName
            // 
            this.labelControlUserName.Location = new System.Drawing.Point(24, 15);
            this.labelControlUserName.Name = "labelControlUserName";
            this.labelControlUserName.Size = new System.Drawing.Size(72, 13);
            this.labelControlUserName.TabIndex = 9;
            this.labelControlUserName.Text = "Пользователь";
            // 
            // textEditPwd
            // 
            this.textEditPwd.EditValue = "";
            this.textEditPwd.Location = new System.Drawing.Point(102, 38);
            this.textEditPwd.Name = "textEditPwd";
            this.textEditPwd.Properties.PasswordChar = '*';
            this.textEditPwd.Size = new System.Drawing.Size(117, 20);
            this.textEditPwd.TabIndex = 6;
            // 
            // textEditUser
            // 
            this.textEditUser.Location = new System.Drawing.Point(102, 12);
            this.textEditUser.Name = "textEditUser";
            this.textEditUser.Size = new System.Drawing.Size(117, 20);
            this.textEditUser.TabIndex = 7;
            // 
            // FrmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(328, 106);
            this.Controls.Add(this.panelControl1);
            this.Controls.Add(this.panelControlLeft);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "FrmLogin";
            this.Text = "Авторизация";
            ((System.ComponentModel.ISupportInitialize)(this.panelControlLeft)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panelControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).EndInit();
            this.panelControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.textEditPwd.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEditUser.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.PanelControl panelControlLeft;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControlUserName;
        private DevExpress.XtraEditors.TextEdit textEditPwd;
        private DevExpress.XtraEditors.TextEdit textEditUser;
        private DevExpress.XtraEditors.PanelControl panelControl2;
        private DevExpress.XtraEditors.SimpleButton btnCancel;
        private DevExpress.XtraEditors.SimpleButton btnLogin;

    }
}