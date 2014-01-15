using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace DinamicTreeview
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void BtnEdit_Click(object sender, EventArgs e)
        {
            PnlEdit.Visible = true;
        }

        private void BtnDone_Click(object sender, EventArgs e)
        {
            PnlEdit.Visible = false;
        }
    }
}
