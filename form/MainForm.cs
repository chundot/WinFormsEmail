using MailKit;
using System;
using System.Windows.Forms;
using wfemail.db.entity;
using wfemail.form.control;

namespace wfemail.form
{
    public partial class MainForm : Form
    {
        private DB db = new DB();

        public MainForm()
        {
            InitializeComponent();
            treeAccount.newAccountTabEvent += newAccountTab;
            treeAccount.eventDel += onDel;
            treeAccount.list = listMail.list;
            listMail.eventOpenMail += newMailViewerTab;
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

        private void newAccountTab(bool add, Account a)
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
                page.Text = "编辑用户";
                form.init(a);
            }
        }

        private void onSubmit(Account a)
        {
            listMail.L("正在保存...");
            if (a.a_id == null)
                db.acnt.Insert(a);
            else db.acnt.Update(a);
            listMail.L("保存成功！");
            closeActiveTab();
            _ = treeAccount.initAsync();
        }

        private void onDel(int a_id)
        {
            listMail.L("正在删除...");
            db.acnt.DeleteById(a_id);
            listMail.L("删除成功！");
            _ = treeAccount.initAsync();
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
            if (summary.HtmlBody != null)
            {
                viewer.box.DocumentText = summary.HtmlBody;
            }
            else if (summary.TextBody != null)
            {
                viewer.box.DocumentText = summary.TextBody;
            }
        }

        private void updateList()
        {
        }

        private void tabControl_DoubleClick(object sender, EventArgs e)
        {
            closeActiveTab();
        }
    }
}