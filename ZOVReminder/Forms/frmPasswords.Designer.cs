namespace ZOVReminder
{
    partial class frmPasswords
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPasswords));
            this.panelLeft = new DevExpress.XtraEditors.PanelControl();
            this.panAll = new DevExpress.XtraEditors.PanelControl();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.btnCheck = new DevExpress.XtraEditors.SimpleButton();
            this.labPasswordConfigm = new DevExpress.XtraEditors.LabelControl();
            this.textEditPassConfirm = new DevExpress.XtraEditors.TextEdit();
            this.btnApply = new DevExpress.XtraEditors.SimpleButton();
            this.comboBoxUsers = new DevExpress.XtraEditors.ComboBoxEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControlUserName = new DevExpress.XtraEditors.LabelControl();
            this.textEditPwd = new DevExpress.XtraEditors.TextEdit();
            this.panBottom = new DevExpress.XtraEditors.PanelControl();
            this.btnCancel = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.panelLeft)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panAll)).BeginInit();
            this.panAll.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.textEditPassConfirm.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.comboBoxUsers.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEditPwd.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panBottom)).BeginInit();
            this.panBottom.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelLeft
            // 
            this.panelLeft.ContentImage = ((System.Drawing.Image)(resources.GetObject("panelLeft.ContentImage")));
            this.panelLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelLeft.Location = new System.Drawing.Point(0, 0);
            this.panelLeft.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panelLeft.Name = "panelLeft";
            this.panelLeft.Size = new System.Drawing.Size(135, 254);
            this.panelLeft.TabIndex = 0;
            // 
            // panAll
            // 
            this.panAll.Controls.Add(this.panelControl1);
            this.panAll.Controls.Add(this.panBottom);
            this.panAll.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panAll.Location = new System.Drawing.Point(135, 0);
            this.panAll.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panAll.Name = "panAll";
            this.panAll.Size = new System.Drawing.Size(347, 254);
            this.panAll.TabIndex = 1;
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.btnCheck);
            this.panelControl1.Controls.Add(this.labPasswordConfigm);
            this.panelControl1.Controls.Add(this.textEditPassConfirm);
            this.panelControl1.Controls.Add(this.btnApply);
            this.panelControl1.Controls.Add(this.comboBoxUsers);
            this.panelControl1.Controls.Add(this.labelControl2);
            this.panelControl1.Controls.Add(this.labelControlUserName);
            this.panelControl1.Controls.Add(this.textEditPwd);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelControl1.Location = new System.Drawing.Point(2, 2);
            this.panelControl1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(343, 193);
            this.panelControl1.TabIndex = 4;
            // 
            // btnCheck
            // 
            this.btnCheck.Location = new System.Drawing.Point(36, 138);
            this.btnCheck.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnCheck.Name = "btnCheck";
            this.btnCheck.Size = new System.Drawing.Size(112, 35);
            this.btnCheck.TabIndex = 15;
            this.btnCheck.Text = "Проверить";
            this.btnCheck.Click += new System.EventHandler(this.btnCheck_Click);
            // 
            // labPasswordConfigm
            // 
            this.labPasswordConfigm.Location = new System.Drawing.Point(20, 103);
            this.labPasswordConfigm.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.labPasswordConfigm.Name = "labPasswordConfigm";
            this.labPasswordConfigm.Size = new System.Drawing.Size(117, 19);
            this.labPasswordConfigm.TabIndex = 14;
            this.labPasswordConfigm.Text = "Подтверждение";
            // 
            // textEditPassConfirm
            // 
            this.textEditPassConfirm.EditValue = "";
            this.textEditPassConfirm.Location = new System.Drawing.Point(153, 98);
            this.textEditPassConfirm.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textEditPassConfirm.Name = "textEditPassConfirm";
            this.textEditPassConfirm.Properties.Appearance.BackColor = System.Drawing.Color.White;
            this.textEditPassConfirm.Properties.Appearance.Options.UseBackColor = true;
            this.textEditPassConfirm.Properties.PasswordChar = '*';
            this.textEditPassConfirm.Size = new System.Drawing.Size(176, 26);
            this.textEditPassConfirm.TabIndex = 13;
            this.textEditPassConfirm.EditValueChanged += new System.EventHandler(this.textEditPassConfirm_EditValueChanged);
            this.textEditPassConfirm.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textEditPassConfirm_KeyDown);
            // 
            // btnApply
            // 
            this.btnApply.Enabled = false;
            this.btnApply.Location = new System.Drawing.Point(213, 138);
            this.btnApply.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnApply.Name = "btnApply";
            this.btnApply.Size = new System.Drawing.Size(112, 35);
            this.btnApply.TabIndex = 12;
            this.btnApply.Text = "Применить";
            this.btnApply.Click += new System.EventHandler(this.btnApply_Click);
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
            // 
            // panBottom
            // 
            this.panBottom.Controls.Add(this.btnCancel);
            this.panBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panBottom.Location = new System.Drawing.Point(2, 195);
            this.panBottom.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panBottom.Name = "panBottom";
            this.panBottom.Size = new System.Drawing.Size(343, 57);
            this.panBottom.TabIndex = 0;
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(213, 9);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(112, 35);
            this.btnCancel.TabIndex = 1;
            this.btnCancel.Text = "Отмена";
            // 
            // frmPasswords
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(482, 254);
            this.Controls.Add(this.panAll);
            this.Controls.Add(this.panelLeft);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmPasswords";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Пароли";
            this.Load += new System.EventHandler(this.frmPasswords_Load);
            ((System.ComponentModel.ISupportInitialize)(this.panelLeft)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panAll)).EndInit();
            this.panAll.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panelControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.textEditPassConfirm.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.comboBoxUsers.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEditPwd.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panBottom)).EndInit();
            this.panBottom.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.PanelControl panelLeft;
        private DevExpress.XtraEditors.PanelControl panAll;
        private DevExpress.XtraEditors.PanelControl panBottom;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.ComboBoxEdit comboBoxUsers;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControlUserName;
        private DevExpress.XtraEditors.TextEdit textEditPwd;
        private DevExpress.XtraEditors.SimpleButton btnCancel;
        private DevExpress.XtraEditors.LabelControl labPasswordConfigm;
        private DevExpress.XtraEditors.TextEdit textEditPassConfirm;
        private DevExpress.XtraEditors.SimpleButton btnApply;
        private DevExpress.XtraEditors.SimpleButton btnCheck;
    }
}