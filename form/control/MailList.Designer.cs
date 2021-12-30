
namespace wfemail.form.control
{
    partial class MailList
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MailList));
            this.listMail = new System.Windows.Forms.ListView();
            this.colSub = new System.Windows.Forms.ColumnHeader();
            this.colDate = new System.Windows.Forms.ColumnHeader();
            this.imgList = new System.Windows.Forms.ImageList(this.components);
            this.ctxMailList = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.viewItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.delItem = new System.Windows.Forms.ToolStripMenuItem();
            this.markAsItem = new System.Windows.Forms.ToolStripMenuItem();
            this.readItem = new System.Windows.Forms.ToolStripMenuItem();
            this.unreadItem = new System.Windows.Forms.ToolStripMenuItem();
            this.junkItem = new System.Windows.Forms.ToolStripMenuItem();
            this.movItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.refreshItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolPage = new System.Windows.Forms.ToolStrip();
            this.toolPageLabel = new System.Windows.Forms.ToolStripLabel();
            this.lastBtn = new System.Windows.Forms.ToolStripButton();
            this.nextBtn = new System.Windows.Forms.ToolStripButton();
            this.prevBtn = new System.Windows.Forms.ToolStripButton();
            this.firstBtn = new System.Windows.Forms.ToolStripButton();
            this.ctxMailList.SuspendLayout();
            this.toolPage.SuspendLayout();
            this.SuspendLayout();
            // 
            // listMail
            // 
            this.listMail.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colSub,
            this.colDate});
            this.listMail.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listMail.HideSelection = false;
            this.listMail.Location = new System.Drawing.Point(0, 0);
            this.listMail.Margin = new System.Windows.Forms.Padding(0);
            this.listMail.Name = "listMail";
            this.listMail.Size = new System.Drawing.Size(471, 319);
            this.listMail.SmallImageList = this.imgList;
            this.listMail.TabIndex = 2;
            this.listMail.UseCompatibleStateImageBehavior = false;
            this.listMail.View = System.Windows.Forms.View.Details;
            this.listMail.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.listMail_MouseDoubleClick);
            this.listMail.MouseUp += new System.Windows.Forms.MouseEventHandler(this.listMail_MouseUp);
            // 
            // colSub
            // 
            this.colSub.Text = "主题";
            this.colSub.Width = 240;
            // 
            // colDate
            // 
            this.colDate.Text = "日期";
            this.colDate.Width = 144;
            // 
            // imgList
            // 
            this.imgList.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imgList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imgList.ImageStream")));
            this.imgList.TransparentColor = System.Drawing.Color.Transparent;
            this.imgList.Images.SetKeyName(0, "mailunread");
            this.imgList.Images.SetKeyName(1, "mailread");
            // 
            // ctxMailList
            // 
            this.ctxMailList.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.viewItem,
            this.toolStripSeparator1,
            this.delItem,
            this.markAsItem,
            this.movItem,
            this.toolStripSeparator2,
            this.refreshItem});
            this.ctxMailList.Name = "ctxMailList";
            this.ctxMailList.Size = new System.Drawing.Size(125, 126);
            // 
            // viewItem
            // 
            this.viewItem.Name = "viewItem";
            this.viewItem.Size = new System.Drawing.Size(124, 22);
            this.viewItem.Text = "查看内容";
            this.viewItem.Click += new System.EventHandler(this.viewItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(121, 6);
            // 
            // delItem
            // 
            this.delItem.Name = "delItem";
            this.delItem.Size = new System.Drawing.Size(124, 22);
            this.delItem.Text = "删除";
            this.delItem.Click += new System.EventHandler(this.delItem_Click);
            // 
            // markAsItem
            // 
            this.markAsItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.readItem,
            this.unreadItem,
            this.junkItem});
            this.markAsItem.Name = "markAsItem";
            this.markAsItem.Size = new System.Drawing.Size(124, 22);
            this.markAsItem.Text = "标记为...";
            // 
            // readItem
            // 
            this.readItem.Image = global::wfemail.Properties.Resources.mailread;
            this.readItem.Name = "readItem";
            this.readItem.Size = new System.Drawing.Size(124, 22);
            this.readItem.Text = "已读";
            this.readItem.Click += new System.EventHandler(this.readItem_Click);
            // 
            // unreadItem
            // 
            this.unreadItem.Image = global::wfemail.Properties.Resources.mailunread;
            this.unreadItem.Name = "unreadItem";
            this.unreadItem.Size = new System.Drawing.Size(124, 22);
            this.unreadItem.Text = "未读";
            this.unreadItem.Click += new System.EventHandler(this.unreadItem_Click);
            // 
            // junkItem
            // 
            this.junkItem.Image = global::wfemail.Properties.Resources.mailjunk;
            this.junkItem.Name = "junkItem";
            this.junkItem.Size = new System.Drawing.Size(124, 22);
            this.junkItem.Text = "垃圾邮件";
            this.junkItem.Click += new System.EventHandler(this.junkItem_Click);
            // 
            // movItem
            // 
            this.movItem.Name = "movItem";
            this.movItem.Size = new System.Drawing.Size(124, 22);
            this.movItem.Text = "移动至...";
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(121, 6);
            // 
            // refreshItem
            // 
            this.refreshItem.Image = global::wfemail.Properties.Resources.view_refresh;
            this.refreshItem.Name = "refreshItem";
            this.refreshItem.Size = new System.Drawing.Size(124, 22);
            this.refreshItem.Text = "刷新";
            this.refreshItem.Click += new System.EventHandler(this.refreshItem_Click);
            // 
            // toolPage
            // 
            this.toolPage.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.toolPage.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolPageLabel,
            this.lastBtn,
            this.nextBtn,
            this.prevBtn,
            this.firstBtn});
            this.toolPage.Location = new System.Drawing.Point(0, 319);
            this.toolPage.Name = "toolPage";
            this.toolPage.Size = new System.Drawing.Size(471, 25);
            this.toolPage.TabIndex = 3;
            this.toolPage.Text = "toolStrip1";
            // 
            // toolPageLabel
            // 
            this.toolPageLabel.Name = "toolPageLabel";
            this.toolPageLabel.Size = new System.Drawing.Size(100, 22);
            this.toolPageLabel.Text = "第1页 1-10/15条";
            // 
            // lastBtn
            // 
            this.lastBtn.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.lastBtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.lastBtn.Image = global::wfemail.Properties.Resources.last;
            this.lastBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.lastBtn.Name = "lastBtn";
            this.lastBtn.Size = new System.Drawing.Size(23, 22);
            this.lastBtn.Text = "最后一页";
            this.lastBtn.Click += new System.EventHandler(this.lastBtn_Click);
            // 
            // nextBtn
            // 
            this.nextBtn.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.nextBtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.nextBtn.Image = global::wfemail.Properties.Resources.next;
            this.nextBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.nextBtn.Name = "nextBtn";
            this.nextBtn.Size = new System.Drawing.Size(23, 22);
            this.nextBtn.Text = "下一页";
            this.nextBtn.Click += new System.EventHandler(this.nextBtn_Click);
            // 
            // prevBtn
            // 
            this.prevBtn.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.prevBtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.prevBtn.Image = global::wfemail.Properties.Resources.prev;
            this.prevBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.prevBtn.Name = "prevBtn";
            this.prevBtn.Size = new System.Drawing.Size(23, 22);
            this.prevBtn.Text = "上一页";
            this.prevBtn.Click += new System.EventHandler(this.prevBtn_Click);
            // 
            // firstBtn
            // 
            this.firstBtn.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.firstBtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.firstBtn.Image = global::wfemail.Properties.Resources.first;
            this.firstBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.firstBtn.Name = "firstBtn";
            this.firstBtn.Size = new System.Drawing.Size(23, 22);
            this.firstBtn.Text = "第一页";
            this.firstBtn.Click += new System.EventHandler(this.firstBtn_Click);
            // 
            // MailList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.listMail);
            this.Controls.Add(this.toolPage);
            this.Name = "MailList";
            this.Size = new System.Drawing.Size(471, 344);
            this.ctxMailList.ResumeLayout(false);
            this.toolPage.ResumeLayout(false);
            this.toolPage.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ListView listMail;
        private System.Windows.Forms.ColumnHeader colSub;
        private System.Windows.Forms.ColumnHeader colDate;
        private System.Windows.Forms.ImageList imgList;
        private System.Windows.Forms.ContextMenuStrip ctxMailList;
        private System.Windows.Forms.ToolStripMenuItem viewItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem delItem;
        private System.Windows.Forms.ToolStripMenuItem markAsItem;
        private System.Windows.Forms.ToolStripMenuItem movItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem refreshItem;
        private System.Windows.Forms.ToolStripMenuItem readItem;
        private System.Windows.Forms.ToolStripMenuItem unreadItem;
        private System.Windows.Forms.ToolStripMenuItem junkItem;
        private System.Windows.Forms.ToolStrip toolPage;
        private System.Windows.Forms.ToolStripLabel toolPageLabel;
        private System.Windows.Forms.ToolStripButton lastBtn;
        private System.Windows.Forms.ToolStripButton nextBtn;
        private System.Windows.Forms.ToolStripButton prevBtn;
        private System.Windows.Forms.ToolStripButton firstBtn;
    }
}
