using MailKit;
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
            treeAccount.list = listMail.list;
            treeAccount.onDel += onDel;
            treeAccount.onMod += newAccountTab;

            listMail.eventOpenMail += newMailViewerTab;

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
            tabControl.SelectedIndex++;
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

        private void newMailViewerTab(ListViewItem item)
        {
            var viewer = new MailViewer();
            var page = new TabPage("邮件详情");
            page.Controls.Add(viewer);
            viewer.Dock = DockStyle.Fill;
            tabControl.TabPages.Add(page);
            tabControl.SelectedIndex++;

            var tag = (MessageSummary)item.Tag;
            var summary = tag.Folder.GetMessage(tag.UniqueId);
            tag.Folder.SetFlags(tag.UniqueId, MessageFlags.Seen, true);
            if (summary.HtmlBody != null)
            {
                viewer.box.DocumentText = summary.HtmlBody;
            }
            else if (summary.TextBody != null)
            {
                viewer.box.DocumentText = summary.TextBody;
            }
        }

        private async void reloadAcc()
        {
            var aList = await db.acnt.GetListAsync();
            onAccountsLoad(aList);
        }

        private void updateList()
        {
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
    }
}