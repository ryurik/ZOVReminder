﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ZOVReminder.Forms
{
    public partial class FrmBase : Form
    {
        public FrmBase()
        {
            InitializeComponent();
        }

        private void frmBase_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.R:
                    MaxFormSize();
                  break;
            }
        }

        private void frmBase_Load(object sender, EventArgs e)
        {
            MaxFormSize();
            OnResize(e);
        }

        public void MaxFormSize()
        {
            if (MdiParent == null)
                return;
            Top = 0;
            Left = 0;

            Width = MdiParent.ClientSize.Width;
            Height = MdiParent.ClientSize.Height;
        }

        private void simpleButtonApply_Click(object sender, EventArgs e)
        {
            UpdateData();
        }

        private void frmBase_FormClosing(object sender, FormClosingEventArgs e)
        {
            CheckForChanges();
        }


        private void btnClose_Click(object sender, EventArgs e)
        {
            CloseForm();
        }

        public virtual void CheckForChanges()
        {
        }

        public virtual void UpdateData()
        {
        }

        public virtual void CloseForm()
        {
            CheckForChanges();
            Close();
        }

        private void FrmBase_Resize(object sender, EventArgs e)
        {
            btnClose.Left = panelControlBottom.Size.Width - btnClose.Width - 15;
            btnApply.Left = btnClose.Left - btnApply.Width - 20;
        }

    }
}
