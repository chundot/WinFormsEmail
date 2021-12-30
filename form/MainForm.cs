using MailKit;
using MailKit.Net.Imap;
using System;
using System.Collections.Generic;
using System.Windows.Forms;
using wfemail.db.entity;
using wfemail.form.control;
using wfemail.util;

namespace wfemail.form
{
    public partial class MainForm : Form
    {
        private DB db = new DB();
        private delegate void useAccounts(List<Account> aList);
        private event useAccounts onAccountsLoad;
        public MainForm()
        {
            InitializeComponent();
            treeAccount.onDel += onDel;
            treeAccount.onMod += newAccountTab;
            treeAccount.eventGetMail += mailListInit;

            listMail.eventOpenMail += newMailViewerTab;
            listMail.eventSetMailFlag += setMailFlag;
            listMail.eventRefresh += refreshMailList;
            listMail.eventGetMailList += getMailList;

            onAccountsLoad += treeAccount.init;

            reloadAcc();
        }

        private void closeActiveTab()
        {
            if (tabControl.SelectedIndex != 0)
            {
                var index = tabControl.SelectedIndex;
                tabControl.SelectedIndex--;
                tabControl.TabPages.RemoveAt(index);
            }
        }

        private void newAccountTab(bool add)
        {
            var page = new TabPage();
            var form = new AccountForm();
            form.eventSubmit += onSubmit;
            page.Controls.Add(form);
            tabControl.TabPages.Add(page);
            tabControl.SelectedIndex++;
            if (add)
                page.Text = "新用户";
            else
            {
                Account a = treeAccount.getCurAcc();
                if (a == null && !add)
                {
                    treeAccount.L("请先选择要编辑的用户！");
                    return;
                }
                page.Text = "编辑用户";
                form.init(a);
            }
        }

        private void newMailTab()
        {
            // 跳转到已有界面
            if (tabControl.TabPages.ContainsKey("newMail"))
            {
                tabControl.SelectedIndex = tabControl.TabPages.IndexOfKey("newMail");
                return;
            }
            // 产生新页面
            var page = new TabPage("新邮件");
            page.Name = "newMail";
            var editor = new MailSendForm(onSendMail);
            onAccountsLoad += editor.comboInit;
            editor.Dock = DockStyle.Fill;
            page.Controls.Add(editor);
            tabControl.TabPages.Add(page);
            tabControl.SelectedIndex = tabControl.TabCount - 1;
            reloadAcc();
        }

        private void onSubmit(Account a)
        {
            treeAccount.L("正在保存...");
            if (a.a_id == null)
                db.acnt.Insert(a);
            else db.acnt.Update(a);
            treeAccount.L("保存成功！");
            closeActiveTab();
            reloadAcc();
        }

        private void onDel()
        {
            int a_id = treeAccount.getCurAcc().a_id ?? -1;
            if (a_id == -1)
            {
                treeAccount.L("先选择要删除的用户！");
                return;
            }
            treeAccount.L("正在删除...");
            db.acnt.DeleteById(a_id);
            treeAccount.L("删除成功！");
            reloadAcc();
        }

        private void onSendMail(MailInfo info)
        {
            var a = db.acnt.GetSingle(it => it.a_account == info.from);
            SmtpUtil.sendMail(a, info);
            closeActiveTab();
        }

        private async void newMailViewerTab(ListViewItem item)
        {
            var viewer = new MailViewer();
            var page = new TabPage("邮件详情");
            page.Controls.Add(viewer);
            viewer.Dock = DockStyle.Fill;
            tabControl.TabPages.Add(page);
            tabControl.SelectedIndex = tabControl.TabCount - 1;

            var tag = item.Tag as MessageSummary;
            // 确保文件夹已打开
            await ImapUtil.openFolder(tag.Folder);
            // 获取summary
            var summary = await tag.Folder.GetMessageAsync(tag.UniqueId);
            await tag.Folder.SetFlagsAsync(tag.UniqueId, MessageFlags.Seen, false);
            // 添加附件
            viewer.newAttachments(summary.Attachments);
            if (summary.HtmlBody != null)
            {
                viewer.box.DocumentText = summary.HtmlBody;
            }
            else if (summary.TextBody != null)
            {
                viewer.box.DocumentText = summary.TextBody;
            }
        }

        private async void setMailFlag(ListViewItem item, MessageFlags flag)
        {
            var tag = item.Tag as MessageSummary;
            await ImapUtil.openFolder(tag.Folder);
            await tag.Folder.SetFlagsAsync(tag.UniqueId, flag, false);
            if (flag.Equals(MessageFlags.Deleted))
                await tag.Folder.MoveToAsync(tag.UniqueId, treeAccount.trash);
            if (flag.Equals(MessageFlags.UserDefined))
                await tag.Folder.MoveToAsync(tag.UniqueId, treeAccount.junk);
        }

        private async void reloadAcc()
        {
            var aList = await db.acnt.GetListAsync();
            onAccountsLoad(aList);
            newMailBtn.Enabled = treeAccount.treeView.Nodes.Count != 0;
        }

        private void refreshMailList()
        {
            var node = treeAccount.treeView.SelectedNode;
            if (node.Tag.GetType() == typeof(ImapFolder))
            {
                var tag = node.Tag as IImapFolder;
                mailListInit(tag, node);
            }
        }

        private void onMessageFlagsChanged(object sender, MessageFlagsChangedEventArgs e)
        {
            var f = sender as ImapFolder;
            listMail.updateItem(e.Flags, f.Count - e.Index - 1);
        }

        private async void mailListInit(IImapFolder f, TreeNode node)
        {
            ImapUtil.check(node);
            treeAccount.L("正在打开文件夹...");
            await ImapUtil.openFolder(f);
            // 信息改变事件
            f.MessageFlagsChanged += onMessageFlagsChanged;

            listMail.loadNewFolder(f);

            tabControl.SelectedIndex = 0;
        }

        private async void getMailList(IImapFolder f, int curPage, int numPerPage)
        {
            try
            {
                treeAccount.L("正在读取文件夹里的信息...");
                var list = await ImapUtil.getMailList(f, curPage, numPerPage);
                listMail.updateList(list);
                treeAccount.L("读取完成！");
            }
            catch (InvalidOperationException)
            {
                treeAccount.L("程序繁忙，请稍等！");
            }
        }

        // 事件绑定
        // 菜单事件
        private void tabControl_DoubleClick(object sender, EventArgs e)
        {
            closeActiveTab();
        }

        private void newAccMenuItem_Click(object sender, EventArgs e)
        {
            newAccountTab(true);
        }

        private void editAccMenuItem_Click(object sender, EventArgs e)
        {
            newAccountTab(false);
        }

        private void delAccMenuItem_Click(object sender, EventArgs e)
        {
            onDel();
        }

        // 工具栏事件
        private void newMailBtn_Click(object sender, EventArgs e)
        {
            newMailTab();
        }

        private void exitBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void HelpMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void AboutMenuItem_Click(object sender, EventArgs e)
        {
            var form = new AboutForm();
            form.Show();
        }
    }
}