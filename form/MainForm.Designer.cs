
namespace wfemail.form
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.newMailBtn = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.settingBtn = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.exitBtn = new System.Windows.Forms.ToolStripButton();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.账户ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newAccMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editAccMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.delAccMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.关于ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.HelpMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.AboutMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.treeAccount = new wfemail.form.control.AccountTree();
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tabPage = new System.Windows.Forms.TabPage();
            this.listMail = new wfemail.form.control.MailList();
            this.toolStrip1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.tabControl.SuspendLayout();
            this.tabPage.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newMailBtn,
            this.toolStripSeparator1,
            this.settingBtn,
            this.toolStripSeparator2,
            this.exitBtn});
            this.toolStrip1.Location = new System.Drawing.Point(0, 25);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(944, 31);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // newMailBtn
            // 
            this.newMailBtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.newMailBtn.Image = global::wfemail.Properties.Resources.newmail;
            this.newMailBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.newMailBtn.Name = "newMailBtn";
            this.newMailBtn.Size = new System.Drawing.Size(28, 28);
            this.newMailBtn.Text = "新邮件";
            this.newMailBtn.Click += new System.EventHandler(this.newMailBtn_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 31);
            // 
            // settingBtn
            // 
            this.settingBtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.settingBtn.Image = global::wfemail.Properties.Resources.preferences_other;
            this.settingBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.settingBtn.Name = "settingBtn";
            this.settingBtn.Size = new System.Drawing.Size(28, 28);
            this.settingBtn.Text = "设置";
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 31);
            // 
            // exitBtn
            // 
            this.exitBtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.exitBtn.Image = global::wfemail.Properties.Resources.shutdown;
            this.exitBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.exitBtn.Name = "exitBtn";
            this.exitBtn.Size = new System.Drawing.Size(28, 28);
            this.exitBtn.Text = "退出";
            this.exitBtn.Click += new System.EventHandler(this.exitBtn_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.账户ToolStripMenuItem,
            this.关于ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(944, 25);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // 账户ToolStripMenuItem
            // 
            this.账户ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newAccMenuItem,
            this.editAccMenuItem,
            this.delAccMenuItem});
            this.账户ToolStripMenuItem.Name = "账户ToolStripMenuItem";
            this.账户ToolStripMenuItem.Size = new System.Drawing.Size(44, 21);
            this.账户ToolStripMenuItem.Text = "账户";
            // 
            // newAccMenuItem
            // 
            this.newAccMenuItem.Image = global::wfemail.Properties.Resources.userplus;
            this.newAccMenuItem.Name = "newAccMenuItem";
            this.newAccMenuItem.Size = new System.Drawing.Size(124, 22);
            this.newAccMenuItem.Text = "新账户";
            this.newAccMenuItem.Click += new System.EventHandler(this.newAccMenuItem_Click);
            // 
            // editAccMenuItem
            // 
            this.editAccMenuItem.Image = global::wfemail.Properties.Resources.userpencil;
            this.editAccMenuItem.Name = "editAccMenuItem";
            this.editAccMenuItem.Size = new System.Drawing.Size(124, 22);
            this.editAccMenuItem.Text = "编辑账户";
            this.editAccMenuItem.Click += new System.EventHandler(this.editAccMenuItem_Click);
            // 
            // delAccMenuItem
            // 
            this.delAccMenuItem.Image = global::wfemail.Properties.Resources.userminus;
            this.delAccMenuItem.Name = "delAccMenuItem";
            this.delAccMenuItem.Size = new System.Drawing.Size(124, 22);
            this.delAccMenuItem.Text = "删除账户";
            this.delAccMenuItem.Click += new System.EventHandler(this.delAccMenuItem_Click);
            // 
            // 关于ToolStripMenuItem
            // 
            this.关于ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.HelpMenuItem,
            this.AboutMenuItem});
            this.关于ToolStripMenuItem.Name = "关于ToolStripMenuItem";
            this.关于ToolStripMenuItem.Size = new System.Drawing.Size(44, 21);
            this.关于ToolStripMenuItem.Text = "关于";
            // 
            // HelpMenuItem
            // 
            this.HelpMenuItem.Image = global::wfemail.Properties.Resources.help;
            this.HelpMenuItem.Name = "HelpMenuItem";
            this.HelpMenuItem.Size = new System.Drawing.Size(109, 22);
            this.HelpMenuItem.Text = "帮助";
            this.HelpMenuItem.Click += new System.EventHandler(this.HelpMenuItem_Click);
            // 
            // AboutMenuItem
            // 
            this.AboutMenuItem.Image = global::wfemail.Properties.Resources.about;
            this.AboutMenuItem.Name = "AboutMenuItem";
            this.AboutMenuItem.Size = new System.Drawing.Size(109, 22);
            this.AboutMenuItem.Text = "关于...";
            this.AboutMenuItem.Click += new System.EventHandler(this.AboutMenuItem_Click);
            // 
            // splitContainer1
            // 
            this.splitContainer1.Cursor = System.Windows.Forms.Cursors.VSplit;
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 56);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.treeAccount);
            this.splitContainer1.Panel1.Cursor = System.Windows.Forms.Cursors.Default;
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.tabControl);
            this.splitContainer1.Panel2.Cursor = System.Windows.Forms.Cursors.Default;
            this.splitContainer1.Size = new System.Drawing.Size(944, 433);
            this.splitContainer1.SplitterDistance = 314;
            this.splitContainer1.SplitterWidth = 2;
            this.splitContainer1.TabIndex = 2;
            // 
            // treeAccount
            // 
            this.treeAccount.Dock = System.Windows.Forms.DockStyle.Fill;
            this.treeAccount.Location = new System.Drawing.Point(0, 0);
            this.treeAccount.Name = "treeAccount";
            this.treeAccount.Size = new System.Drawing.Size(314, 433);
            this.treeAccount.TabIndex = 0;
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.tabPage);
            this.tabControl.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.tabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl.Location = new System.Drawing.Point(0, 0);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(628, 433);
            this.tabControl.TabIndex = 0;
            this.tabControl.DoubleClick += new System.EventHandler(this.tabControl_DoubleClick);
            // 
            // tabPage
            // 
            this.tabPage.Controls.Add(this.listMail);
            this.tabPage.Location = new System.Drawing.Point(4, 26);
            this.tabPage.Margin = new System.Windows.Forms.Padding(0);
            this.tabPage.Name = "tabPage";
            this.tabPage.Size = new System.Drawing.Size(620, 403);
            this.tabPage.TabIndex = 0;
            this.tabPage.Text = "邮件列表";
            this.tabPage.UseVisualStyleBackColor = true;
            // 
            // listMail
            // 
            this.listMail.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.listMail.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listMail.Location = new System.Drawing.Point(0, 0);
            this.listMail.Margin = new System.Windows.Forms.Padding(0);
            this.listMail.Name = "listMail";
            this.listMail.Size = new System.Drawing.Size(620, 403);
            this.listMail.TabIndex = 0;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(944, 489);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.Text = "手搓邮件客户端 - 中文典藏无敌版";
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.tabControl.ResumeLayout(false);
            this.tabPage.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tabPage;
        private control.MailList listMail;
        private System.Windows.Forms.ToolStripButton newMailBtn;
        private System.Windows.Forms.ToolStripMenuItem 账户ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newAccMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editAccMenuItem;
        private System.Windows.Forms.ToolStripMenuItem delAccMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 关于ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem HelpMenuItem;
        private System.Windows.Forms.ToolStripMenuItem AboutMenuItem;
        private control.AccountTree treeAccount;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton settingBtn;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton exitBtn;
    }
}