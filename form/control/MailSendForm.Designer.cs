
namespace wfemail.form.control
{
    partial class MailSendForm
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
            this.toolText = new System.Windows.Forms.ToolStrip();
            this.boldBtn = new System.Windows.Forms.ToolStripButton();
            this.italicBtn = new System.Windows.Forms.ToolStripButton();
            this.udlBtn = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.insPicBtn = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.listOrderBtn = new System.Windows.Forms.ToolStripButton();
            this.listBtn = new System.Windows.Forms.ToolStripButton();
            this.infoBtn = new System.Windows.Forms.ToolStripButton();
            this.panelMain = new System.Windows.Forms.Panel();
            this.rePanel = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.subBox = new System.Windows.Forms.TextBox();
            this.toBox = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.senderCombo = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.sendBtn = new System.Windows.Forms.Button();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.attachBtn = new System.Windows.Forms.ToolStripButton();
            this.toolText.SuspendLayout();
            this.rePanel.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolText
            // 
            this.toolText.GripMargin = new System.Windows.Forms.Padding(0);
            this.toolText.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.boldBtn,
            this.italicBtn,
            this.udlBtn,
            this.toolStripSeparator1,
            this.insPicBtn,
            this.toolStripSeparator2,
            this.listOrderBtn,
            this.listBtn,
            this.infoBtn,
            this.toolStripSeparator3,
            this.attachBtn});
            this.toolText.Location = new System.Drawing.Point(0, 63);
            this.toolText.Name = "toolText";
            this.toolText.Size = new System.Drawing.Size(562, 25);
            this.toolText.TabIndex = 0;
            this.toolText.Text = "toolStrip1";
            // 
            // boldBtn
            // 
            this.boldBtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.boldBtn.Image = global::wfemail.Properties.Resources.bold;
            this.boldBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.boldBtn.Name = "boldBtn";
            this.boldBtn.Size = new System.Drawing.Size(23, 22);
            this.boldBtn.Text = "粗体";
            this.boldBtn.Click += new System.EventHandler(this.boldBtn_Click);
            // 
            // italicBtn
            // 
            this.italicBtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.italicBtn.Image = global::wfemail.Properties.Resources.italic;
            this.italicBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.italicBtn.Name = "italicBtn";
            this.italicBtn.Size = new System.Drawing.Size(23, 22);
            this.italicBtn.Text = "斜体";
            this.italicBtn.Click += new System.EventHandler(this.italicBtn_Click);
            // 
            // udlBtn
            // 
            this.udlBtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.udlBtn.Image = global::wfemail.Properties.Resources.underline;
            this.udlBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.udlBtn.Name = "udlBtn";
            this.udlBtn.Size = new System.Drawing.Size(23, 22);
            this.udlBtn.Text = "下划线";
            this.udlBtn.Click += new System.EventHandler(this.udlBtn_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // insPicBtn
            // 
            this.insPicBtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.insPicBtn.Image = global::wfemail.Properties.Resources.insert_image;
            this.insPicBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.insPicBtn.Name = "insPicBtn";
            this.insPicBtn.Size = new System.Drawing.Size(23, 22);
            this.insPicBtn.Text = "插入图片";
            this.insPicBtn.Click += new System.EventHandler(this.insPicBtn_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // listOrderBtn
            // 
            this.listOrderBtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.listOrderBtn.Image = global::wfemail.Properties.Resources.listorder;
            this.listOrderBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.listOrderBtn.Name = "listOrderBtn";
            this.listOrderBtn.Size = new System.Drawing.Size(23, 22);
            this.listOrderBtn.Text = "插入有序列表";
            this.listOrderBtn.Click += new System.EventHandler(this.listOrderBtn_Click);
            // 
            // listBtn
            // 
            this.listBtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.listBtn.Image = global::wfemail.Properties.Resources.list;
            this.listBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.listBtn.Name = "listBtn";
            this.listBtn.Size = new System.Drawing.Size(23, 22);
            this.listBtn.Text = "插入列表";
            this.listBtn.Click += new System.EventHandler(this.listBtn_Click);
            // 
            // infoBtn
            // 
            this.infoBtn.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.infoBtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.infoBtn.Image = global::wfemail.Properties.Resources.userinfo;
            this.infoBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.infoBtn.Name = "infoBtn";
            this.infoBtn.Size = new System.Drawing.Size(23, 22);
            this.infoBtn.Text = "toolStripButton1";
            this.infoBtn.ToolTipText = "显示/隐藏菜单";
            this.infoBtn.Click += new System.EventHandler(this.infoBtn_Click);
            // 
            // panelMain
            // 
            this.panelMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelMain.Location = new System.Drawing.Point(0, 88);
            this.panelMain.Margin = new System.Windows.Forms.Padding(0);
            this.panelMain.Name = "panelMain";
            this.panelMain.Size = new System.Drawing.Size(562, 288);
            this.panelMain.TabIndex = 1;
            // 
            // rePanel
            // 
            this.rePanel.Controls.Add(this.label2);
            this.rePanel.Controls.Add(this.label1);
            this.rePanel.Controls.Add(this.subBox);
            this.rePanel.Controls.Add(this.toBox);
            this.rePanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.rePanel.Location = new System.Drawing.Point(0, 0);
            this.rePanel.Margin = new System.Windows.Forms.Padding(0);
            this.rePanel.Name = "rePanel";
            this.rePanel.Size = new System.Drawing.Size(562, 63);
            this.rePanel.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(47, 37);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "主题";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(36, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "收件人";
            // 
            // subBox
            // 
            this.subBox.Location = new System.Drawing.Point(85, 34);
            this.subBox.Name = "subBox";
            this.subBox.Size = new System.Drawing.Size(185, 23);
            this.subBox.TabIndex = 1;
            // 
            // toBox
            // 
            this.toBox.Location = new System.Drawing.Point(85, 5);
            this.toBox.Name = "toBox";
            this.toBox.Size = new System.Drawing.Size(185, 23);
            this.toBox.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.senderCombo);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.sendBtn);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 376);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(562, 29);
            this.panel1.TabIndex = 3;
            // 
            // senderCombo
            // 
            this.senderCombo.FormattingEnabled = true;
            this.senderCombo.Location = new System.Drawing.Point(53, 3);
            this.senderCombo.Name = "senderCombo";
            this.senderCombo.Size = new System.Drawing.Size(217, 25);
            this.senderCombo.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 6);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 17);
            this.label3.TabIndex = 1;
            this.label3.Text = "发件人";
            // 
            // sendBtn
            // 
            this.sendBtn.Dock = System.Windows.Forms.DockStyle.Right;
            this.sendBtn.Image = global::wfemail.Properties.Resources.sending;
            this.sendBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.sendBtn.Location = new System.Drawing.Point(502, 0);
            this.sendBtn.Name = "sendBtn";
            this.sendBtn.Size = new System.Drawing.Size(60, 29);
            this.sendBtn.TabIndex = 0;
            this.sendBtn.Text = "发送";
            this.sendBtn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.sendBtn.UseVisualStyleBackColor = true;
            this.sendBtn.Click += new System.EventHandler(this.sendBtn_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 25);
            // 
            // attachBtn
            // 
            this.attachBtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.attachBtn.Image = global::wfemail.Properties.Resources.attachment;
            this.attachBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.attachBtn.Name = "attachBtn";
            this.attachBtn.Size = new System.Drawing.Size(23, 22);
            this.attachBtn.Text = "添加附件";
            this.attachBtn.Click += new System.EventHandler(this.attachBtn_Click);
            // 
            // MailSendForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panelMain);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.toolText);
            this.Controls.Add(this.rePanel);
            this.Margin = new System.Windows.Forms.Padding(0);
            this.Name = "MailSendForm";
            this.Size = new System.Drawing.Size(562, 405);
            this.toolText.ResumeLayout(false);
            this.toolText.PerformLayout();
            this.rePanel.ResumeLayout(false);
            this.rePanel.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolText;
        private System.Windows.Forms.ToolStripButton boldBtn;
        private System.Windows.Forms.ToolStripButton italicBtn;
        private System.Windows.Forms.ToolStripButton udlBtn;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton insPicBtn;
        private System.Windows.Forms.Panel panelMain;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton listOrderBtn;
        private System.Windows.Forms.ToolStripButton listBtn;
        private System.Windows.Forms.Panel rePanel;
        private System.Windows.Forms.ToolStripButton infoBtn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox subBox;
        private System.Windows.Forms.TextBox toBox;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button sendBtn;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox senderCombo;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripButton attachBtn;
    }
}
