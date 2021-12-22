
namespace wfemail
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.treeAccount = new System.Windows.Forms.TreeView();
            this.listMail = new System.Windows.Forms.ListView();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Cursor = System.Windows.Forms.Cursors.VSplit;
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.treeAccount);
            this.splitContainer1.Panel1.Padding = new System.Windows.Forms.Padding(4, 4, 0, 4);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.listMail);
            this.splitContainer1.Panel2.Padding = new System.Windows.Forms.Padding(0, 4, 4, 4);
            this.splitContainer1.Size = new System.Drawing.Size(800, 450);
            this.splitContainer1.SplitterDistance = 266;
            this.splitContainer1.TabIndex = 0;
            // 
            // treeAccount
            // 
            this.treeAccount.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.treeAccount.Dock = System.Windows.Forms.DockStyle.Fill;
            this.treeAccount.Indent = 16;
            this.treeAccount.Location = new System.Drawing.Point(4, 4);
            this.treeAccount.Margin = new System.Windows.Forms.Padding(0);
            this.treeAccount.Name = "treeAccount";
            this.treeAccount.Size = new System.Drawing.Size(262, 442);
            this.treeAccount.TabIndex = 0;
            this.treeAccount.Tag = "";
            // 
            // listMail
            // 
            this.listMail.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.listMail.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listMail.HideSelection = false;
            this.listMail.Location = new System.Drawing.Point(0, 4);
            this.listMail.Margin = new System.Windows.Forms.Padding(0);
            this.listMail.Name = "listMail";
            this.listMail.Size = new System.Drawing.Size(526, 442);
            this.listMail.TabIndex = 0;
            this.listMail.UseCompatibleStateImageBehavior = false;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.splitContainer1);
            this.Name = "MainForm";
            this.Text = "Form1";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.TreeView treeAccount;
        private System.Windows.Forms.ListView listMail;
    }
}

