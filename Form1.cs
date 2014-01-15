using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace DinamicTreeview
{
    public partial class FrmMain : Form
    {
        public FrmMain()
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

        private void BtnAdRoot_Click(object sender, EventArgs e)
        {
            Tview.Nodes.Add(string.Empty).BeginEdit();
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            if (Tview.SelectedNode == null)
                MessageBox.Show("Please select a node to delete.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
                if (MessageBox.Show("Do you want to delete this node (and its childes)?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                    Tview.SelectedNode.Remove();
        }

        private void BtnAdChiled_Click(object sender, EventArgs e)
        {
            if (Tview.SelectedNode != null)
            {
                Tview.SelectedNode.Nodes.Add("").BeginEdit();
                Tview.SelectedNode.Expand();
            }
            else
                MessageBox.Show("Please select a node to add child.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void BtnNodeEdit_Click(object sender, EventArgs e)
        {
            if (Tview.SelectedNode != null)
                Tview.SelectedNode.BeginEdit();
            else
                MessageBox.Show("Please select a node to edit.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}
