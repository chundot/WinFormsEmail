
namespace wfemail
{
    partial class OldForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OldForm));
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.treeAccount = new System.Windows.Forms.TreeView();
            this.imgList16 = new System.Windows.Forms.ImageList(this.components);
            this.statusAccount = new System.Windows.Forms.StatusStrip();
            this.tLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.listMail = new System.Windows.Forms.ListView();
            this.colSubject = new System.Windows.Forms.ColumnHeader();
            this.colDate = new System.Windows.Forms.ColumnHeader();
            this.statusMail = new System.Windows.Forms.StatusStrip();
            this.tLabel2 = new System.Windows.Forms.ToolStripStatusLabel();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.statusAccount.SuspendLayout();
            this.statusMail.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Cursor = System.Windows.Forms.Cursors.VSplit;
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Margin = new System.Windows.Forms.Padding(2);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.treeAccount);
            this.splitContainer1.Panel1.Controls.Add(this.statusAccount);
            this.splitContainer1.Panel1.Padding = new System.Windows.Forms.Padding(3, 3, 0, 3);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.listMail);
            this.splitContainer1.Panel2.Controls.Add(this.statusMail);
            this.splitContainer1.Panel2.Padding = new System.Windows.Forms.Padding(0, 3, 3, 3);
            this.splitContainer1.Size = new System.Drawing.Size(624, 441);
            this.splitContainer1.SplitterDistance = 192;
            this.splitContainer1.SplitterWidth = 3;
            this.splitContainer1.TabIndex = 0;
            // 
            // treeAccount
            // 
            this.treeAccount.Cursor = System.Windows.Forms.Cursors.Default;
            this.treeAccount.Dock = System.Windows.Forms.DockStyle.Fill;
            this.treeAccount.ImageIndex = 0;
            this.treeAccount.ImageList = this.imgList16;
            this.treeAccount.Location = new System.Drawing.Point(3, 3);
            this.treeAccount.Name = "treeAccount";
            this.treeAccount.SelectedImageIndex = 0;
            this.treeAccount.Size = new System.Drawing.Size(189, 413);
            this.treeAccount.TabIndex = 2;
            this.treeAccount.NodeMouseClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.treeAccount_NodeMouseClick);
            this.treeAccount.NodeMouseDoubleClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.treeAccount_NodeMouseDoubleClick);
            // 
            // imgList16
            // 
            this.imgList16.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imgList16.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imgList16.ImageStream")));
            this.imgList16.TransparentColor = System.Drawing.Color.Transparent;
            this.imgList16.Images.SetKeyName(0, "info");
            this.imgList16.Images.SetKeyName(1, "mail");
            this.imgList16.Images.SetKeyName(2, "mailopen.png");
            // 
            // statusAccount
            // 
            this.statusAccount.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tLabel1});
            this.statusAccount.Location = new System.Drawing.Point(3, 416);
            this.statusAccount.Name = "statusAccount";
            this.statusAccount.Padding = new System.Windows.Forms.Padding(1, 0, 10, 0);
            this.statusAccount.Size = new System.Drawing.Size(189, 22);
            this.statusAccount.TabIndex = 1;
            this.statusAccount.Text = "statusStrip1";
            // 
            // tLabel1
            // 
            this.tLabel1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.tLabel1.Name = "tLabel1";
            this.tLabel1.Size = new System.Drawing.Size(68, 17);
            this.tLabel1.Text = "邮件文件夹";
            // 
            // listMail
            // 
            this.listMail.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colSubject,
            this.colDate});
            this.listMail.Cursor = System.Windows.Forms.Cursors.Default;
            this.listMail.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listMail.HideSelection = false;
            this.listMail.Location = new System.Drawing.Point(0, 3);
            this.listMail.Name = "listMail";
            this.listMail.Size = new System.Drawing.Size(426, 413);
            this.listMail.SmallImageList = this.imgList16;
            this.listMail.TabIndex = 2;
            this.listMail.UseCompatibleStateImageBehavior = false;
            this.listMail.View = System.Windows.Forms.View.Details;
            this.listMail.SelectedIndexChanged += new System.EventHandler(this.listMail_SelectedIndexChanged);
            // 
            // colSubject
            // 
            this.colSubject.Text = "主题";
            this.colSubject.Width = 240;
            // 
            // colDate
            // 
            this.colDate.Text = "日期";
            this.colDate.Width = 120;
            // 
            // statusMail
            // 
            this.statusMail.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tLabel2});
            this.statusMail.Location = new System.Drawing.Point(0, 416);
            this.statusMail.Name = "statusMail";
            this.statusMail.Padding = new System.Windows.Forms.Padding(1, 0, 10, 0);
            this.statusMail.Size = new System.Drawing.Size(426, 22);
            this.statusMail.TabIndex = 1;
            this.statusMail.Text = "statusStrip2";
            // 
            // tLabel2
            // 
            this.tLabel2.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.tLabel2.Name = "tLabel2";
            this.tLabel2.Size = new System.Drawing.Size(56, 17);
            this.tLabel2.Text = "邮件列表";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(624, 441);
            this.Controls.Add(this.splitContainer1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "MainForm";
            this.Text = "邮件客户端";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.statusAccount.ResumeLayout(false);
            this.statusAccount.PerformLayout();
            this.statusMail.ResumeLayout(false);
            this.statusMail.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.StatusStrip statusAccount;
        private System.Windows.Forms.StatusStrip statusMail;
        private System.Windows.Forms.ToolStripStatusLabel tLabel1;
        private System.Windows.Forms.ToolStripStatusLabel tLabel2;
        private System.Windows.Forms.TreeView treeAccount;
        private System.Windows.Forms.ListView listMail;
        private System.Windows.Forms.ImageList imgList16;
        private System.Windows.Forms.ColumnHeader colSubject;
        private System.Windows.Forms.ColumnHeader colDate;
    }
}

