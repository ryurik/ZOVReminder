using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ZOVReminder.Forms
{
    public partial class frmBase : Form
    {
        public frmBase()
        {
            InitializeComponent();
        }

        public frmBase(int i)
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
        }

        public void MaxFormSize()
        {
            if (MdiParent == null)
                return;
            this.Top = 0;
            this.Left = 0;
            this.Width = MdiParent.Width;
            this.Height = MdiParent.Height;
        }
    }
}
