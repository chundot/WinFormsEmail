
namespace wfemail.form.control
{
    partial class AccountTree
    {
        /// <summary> 
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region 组件设计器生成的代码

        /// <summary> 
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AccountTree));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.label = new System.Windows.Forms.ToolStripLabel();
            this.tree = new System.Windows.Forms.TreeView();
            this.imgList = new System.Windows.Forms.ImageList(this.components);
            this.userCtx = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.addUser = new System.Windows.Forms.ToolStripMenuItem();
            this.editUser = new System.Windows.Forms.ToolStripMenuItem();
            this.delUser = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.openBoxItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip1.SuspendLayout();
            this.userCtx.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.label});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(197, 25);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // label
            // 
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(80, 22);
            this.label.Text = "邮箱账户列表";
            // 
            // tree
            // 
            this.tree.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tree.ImageIndex = 0;
            this.tree.ImageList = this.imgList;
            this.tree.Location = new System.Drawing.Point(0, 25);
            this.tree.Name = "tree";
            this.tree.SelectedImageIndex = 0;
            this.tree.Size = new System.Drawing.Size(197, 296);
            this.tree.TabIndex = 3;
            this.tree.NodeMouseClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.tree_NodeMouseClick);
            this.tree.NodeMouseDoubleClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.tree_NodeMouseDoubleClick);
            this.tree.MouseDown += new System.Windows.Forms.MouseEventHandler(this.tree_MouseDown);
            this.tree.MouseUp += new System.Windows.Forms.MouseEventHandler(this.tree_MouseUp);
            // 
            // imgList
            // 
            this.imgList.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imgList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imgList.ImageStream")));
            this.imgList.TransparentColor = System.Drawing.Color.Transparent;
            this.imgList.Images.SetKeyName(0, "info");
            this.imgList.Images.SetKeyName(1, "mail");
            this.imgList.Images.SetKeyName(2, "mailplus");
            this.imgList.Images.SetKeyName(3, "inboxdoc");
            this.imgList.Images.SetKeyName(4, "deleted");
            this.imgList.Images.SetKeyName(5, "junk");
            this.imgList.Images.SetKeyName(6, "question");
            this.imgList.Images.SetKeyName(7, "draft");
            this.imgList.Images.SetKeyName(8, "sent");
            this.imgList.Images.SetKeyName(9, "inbox");
            this.imgList.Images.SetKeyName(10, "disk");
            this.imgList.Images.SetKeyName(11, "diskarr");
            // 
            // userCtx
            // 
            this.userCtx.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addUser,
            this.editUser,
            this.delUser,
            this.toolStripSeparator1,
            this.openBoxItem});
            this.userCtx.Name = "userCtx";
            this.userCtx.Size = new System.Drawing.Size(137, 98);
            // 
            // addUser
            // 
            this.addUser.Image = global::wfemail.Properties.Resources.userplus;
            this.addUser.Name = "addUser";
            this.addUser.Size = new System.Drawing.Size(136, 22);
            this.addUser.Text = "添加用户";
            this.addUser.Click += new System.EventHandler(this.addUser_Click);
            // 
            // editUser
            // 
            this.editUser.Image = global::wfemail.Properties.Resources.userpencil;
            this.editUser.Name = "editUser";
            this.editUser.Size = new System.Drawing.Size(136, 22);
            this.editUser.Text = "编辑用户";
            this.editUser.Click += new System.EventHandler(this.editUser_Click);
            // 
            // delUser
            // 
            this.delUser.Image = global::wfemail.Properties.Resources.userminus;
            this.delUser.Name = "delUser";
            this.delUser.Size = new System.Drawing.Size(136, 22);
            this.delUser.Text = "删除用户";
            this.delUser.Click += new System.EventHandler(this.delUser_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(133, 6);
            // 
            // openBoxItem
            // 
            this.openBoxItem.Image = global::wfemail.Properties.Resources.folder;
            this.openBoxItem.Name = "openBoxItem";
            this.openBoxItem.Size = new System.Drawing.Size(136, 22);
            this.openBoxItem.Text = "打开文件夹";
            this.openBoxItem.Click += new System.EventHandler(this.openBoxItem_Click);
            // 
            // AccountTree
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tree);
            this.Controls.Add(this.toolStrip1);
            this.Name = "AccountTree";
            this.Size = new System.Drawing.Size(197, 321);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.userCtx.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripLabel label;
        private System.Windows.Forms.TreeView tree;
        private System.Windows.Forms.ImageList imgList;
        private System.Windows.Forms.ContextMenuStrip userCtx;
        private System.Windows.Forms.ToolStripMenuItem addUser;
        private System.Windows.Forms.ToolStripMenuItem editUser;
        private System.Windows.Forms.ToolStripMenuItem delUser;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem openBoxItem;
    }
}
