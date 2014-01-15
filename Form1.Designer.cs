namespace DinamicTreeview
{
    partial class FrmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMain));
            this.PnlTree = new System.Windows.Forms.Panel();
            this.Tview = new System.Windows.Forms.TreeView();
            this.BtnEdit = new System.Windows.Forms.Button();
            this.PnlEdit = new System.Windows.Forms.Panel();
            this.BtnNodeEdit = new System.Windows.Forms.Button();
            this.BtnDone = new System.Windows.Forms.Button();
            this.BtnDelete = new System.Windows.Forms.Button();
            this.BtnAdChiled = new System.Windows.Forms.Button();
            this.BtnAdRoot = new System.Windows.Forms.Button();
            this.PnlTree.SuspendLayout();
            this.PnlEdit.SuspendLayout();
            this.SuspendLayout();
            // 
            // PnlTree
            // 
            this.PnlTree.Controls.Add(this.Tview);
            this.PnlTree.Dock = System.Windows.Forms.DockStyle.Top;
            this.PnlTree.Location = new System.Drawing.Point(0, 0);
            this.PnlTree.Name = "PnlTree";
            this.PnlTree.Size = new System.Drawing.Size(566, 398);
            this.PnlTree.TabIndex = 0;
            // 
            // Tview
            // 
            this.Tview.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Tview.LabelEdit = true;
            this.Tview.Location = new System.Drawing.Point(0, 0);
            this.Tview.Name = "Tview";
            this.Tview.Size = new System.Drawing.Size(566, 398);
            this.Tview.TabIndex = 0;
            // 
            // BtnEdit
            // 
            this.BtnEdit.Location = new System.Drawing.Point(13, 402);
            this.BtnEdit.Name = "BtnEdit";
            this.BtnEdit.Size = new System.Drawing.Size(75, 23);
            this.BtnEdit.TabIndex = 1;
            this.BtnEdit.Text = "Edit Tree";
            this.BtnEdit.UseVisualStyleBackColor = true;
            this.BtnEdit.Click += new System.EventHandler(this.BtnEdit_Click);
            // 
            // PnlEdit
            // 
            this.PnlEdit.Controls.Add(this.BtnNodeEdit);
            this.PnlEdit.Controls.Add(this.BtnDone);
            this.PnlEdit.Controls.Add(this.BtnDelete);
            this.PnlEdit.Controls.Add(this.BtnAdChiled);
            this.PnlEdit.Controls.Add(this.BtnAdRoot);
            this.PnlEdit.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.PnlEdit.Location = new System.Drawing.Point(0, 401);
            this.PnlEdit.Name = "PnlEdit";
            this.PnlEdit.Size = new System.Drawing.Size(566, 29);
            this.PnlEdit.TabIndex = 2;
            this.PnlEdit.Visible = false;
            // 
            // BtnNodeEdit
            // 
            this.BtnNodeEdit.Location = new System.Drawing.Point(165, 1);
            this.BtnNodeEdit.Name = "BtnNodeEdit";
            this.BtnNodeEdit.Size = new System.Drawing.Size(75, 23);
            this.BtnNodeEdit.TabIndex = 4;
            this.BtnNodeEdit.Text = "Edit";
            this.BtnNodeEdit.UseVisualStyleBackColor = true;
            this.BtnNodeEdit.Click += new System.EventHandler(this.BtnNodeEdit_Click);
            // 
            // BtnDone
            // 
            this.BtnDone.Location = new System.Drawing.Point(488, 1);
            this.BtnDone.Name = "BtnDone";
            this.BtnDone.Size = new System.Drawing.Size(75, 23);
            this.BtnDone.TabIndex = 3;
            this.BtnDone.Text = "Done";
            this.BtnDone.UseVisualStyleBackColor = true;
            this.BtnDone.Click += new System.EventHandler(this.BtnDone_Click);
            // 
            // BtnDelete
            // 
            this.BtnDelete.Location = new System.Drawing.Point(246, 1);
            this.BtnDelete.Name = "BtnDelete";
            this.BtnDelete.Size = new System.Drawing.Size(75, 23);
            this.BtnDelete.TabIndex = 2;
            this.BtnDelete.Text = "Delete";
            this.BtnDelete.UseVisualStyleBackColor = true;
            this.BtnDelete.Click += new System.EventHandler(this.BtnDelete_Click);
            // 
            // BtnAdChiled
            // 
            this.BtnAdChiled.Location = new System.Drawing.Point(84, 1);
            this.BtnAdChiled.Name = "BtnAdChiled";
            this.BtnAdChiled.Size = new System.Drawing.Size(75, 23);
            this.BtnAdChiled.TabIndex = 1;
            this.BtnAdChiled.Text = "Add Chiled";
            this.BtnAdChiled.UseVisualStyleBackColor = true;
            this.BtnAdChiled.Click += new System.EventHandler(this.BtnAdChiled_Click);
            // 
            // BtnAdRoot
            // 
            this.BtnAdRoot.Location = new System.Drawing.Point(3, 1);
            this.BtnAdRoot.Name = "BtnAdRoot";
            this.BtnAdRoot.Size = new System.Drawing.Size(75, 23);
            this.BtnAdRoot.TabIndex = 0;
            this.BtnAdRoot.Text = "Add root";
            this.BtnAdRoot.UseVisualStyleBackColor = true;
            this.BtnAdRoot.Click += new System.EventHandler(this.BtnAdRoot_Click);
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(566, 430);
            this.Controls.Add(this.PnlEdit);
            this.Controls.Add(this.BtnEdit);
            this.Controls.Add(this.PnlTree);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FrmMain";
            this.Text = "Dinamic Tree";
            this.PnlTree.ResumeLayout(false);
            this.PnlEdit.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel PnlTree;
        private System.Windows.Forms.TreeView Tview;
        private System.Windows.Forms.Button BtnEdit;
        private System.Windows.Forms.Panel PnlEdit;
        private System.Windows.Forms.Button BtnDone;
        private System.Windows.Forms.Button BtnDelete;
        private System.Windows.Forms.Button BtnAdChiled;
        private System.Windows.Forms.Button BtnAdRoot;
        private System.Windows.Forms.Button BtnNodeEdit;
    }
}

