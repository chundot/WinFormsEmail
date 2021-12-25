﻿using MailKit;
using MailKit.Net.Imap;
using System;
using System.Threading.Tasks;
using System.Windows.Forms;
using wfemail.db.entity;
using wfemail.util;

namespace wfemail.form.control
{
    public partial class AccountTree : UserControl
    {
        public ListView list;
        private DB db = new DB();

        public delegate void newAccountTab(bool add, Account account);

        public event newAccountTab newAccountTabEvent;

        public delegate void delAccount(int a_id);

        public event delAccount eventDel;

        public AccountTree()
        {
            InitializeComponent();
            _ = initAsync();
        }

        public void L(string str)
        {
            label.Text = str;
        }

        // 用户相关
        // 载入sqlite中的用户
        public async Task initAsync()
        {
            L("读取用户中...");
            var aList = await db.acnt.GetListAsync();
            tree.Nodes.Clear();
            foreach (Account a in aList)
            {
                TreeNode a_node = new TreeNode(a.a_account, 10, 10);
                a_node.Name = a.a_id.ToString();
                a_node.Tag = a;
                tree.Nodes.Add(a_node);
            }
            L("用户邮箱列表");
        }

        // 邮件相关
        public async Task getDirAsync(Account a, TreeNode node)
        {
            // 产生新的imap实例
            L("登录中...");
            var imap = await ImapUtil.getImap(a);
            L("文件夹加载中...");
            var dList = await imap.GetFoldersAsync(imap.PersonalNamespaces[0]);
            foreach (var d in dList)
            {
                var d_node = new TreeNode();
                d_node.ImageKey = d_node.SelectedImageKey = ImapUtil.getIconName(d.Name);
                d_node.Text = ImapUtil.getDisName(d.Name);
                d_node.Name = d.FullName;
                d_node.Tag = d;
                if (d.FullName.Contains('/'))
                {
                    var pStr = d.FullName.Split('/')[0];
                    foreach (TreeNode n in node.Nodes)
                        if (n.Text.Equals(pStr))
                        {
                            n.Nodes.Add(d_node);
                            break;
                        }
                }
                else
                    node.Nodes.Add(d_node);
            }
            node.ImageIndex = 11;
            node.SelectedImageIndex = 11;
            L("文件夹加载完成！");
        }

        public async Task getDirInfoAsync(IImapFolder f, TreeNode node)
        {
            // 检测连接
            var p = node.Parent;
            while (p.Parent != null) p = p.Parent;
            await ImapUtil.getImap((Account)p.Tag);
            // 打开文件夹
            L("正在打开文件夹...");
            if (!f.IsOpen) await f.OpenAsync(FolderAccess.ReadOnly);
            L(string.Format("{0} 条邮件, {1} 条最近", f.Count, f.Recent));
        }

        public async Task getMailListAsync(IImapFolder f, TreeNode node)
        {
            // 检测连接
            var p = node.Parent;
            while (p.Parent != null) p = p.Parent;
            await ImapUtil.getImap((Account)p.Tag);
            // 添加邮件主题等简略信息到列表
            L("正在打开文件夹...");
            if (!f.IsOpen) await f.OpenAsync(FolderAccess.ReadOnly);
            L("正在读取文件夹里的信息...");
            var eList = await f.FetchAsync(0, -1, MessageSummaryItems.UniqueId | MessageSummaryItems.Envelope);
            // 载入到listView
            list.Items.Clear();
            for (int index = eList.Count - 1; index >= 0; index--)
            {
                var i = eList[index];
                var item = new ListViewItem(i.Envelope.Subject);
                var date = i.Envelope.Date ?? DateTimeOffset.Now;
                item.Tag = i;
                item.SubItems.Add(date.DateTime.ToString());
                list.Items.Add(item);
            }
            L("读取完成！");
        }

        // 绑定的事件
        // 单击树形图列表物品
        private void tree_NodeMouseClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            var node = e.Node;
            var tag = node.Tag;
            var type = tag.GetType();
            // 没有获取过文件夹的邮箱账户
            if (type == typeof(Account))
            {
            }
            // 可选择的目录
            else if (node.Nodes.Count == 0)
            {
                var f = (IImapFolder)tag;
                _ = getDirInfoAsync(f, node);
            }
        }

        // 双击树形图列表物品
        private void tree_NodeMouseDoubleClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            var node = e.Node;
            var tag = node.Tag;
            var type = tag.GetType();
            // 双击账户名时
            if (type == typeof(Account))
            {
                if (node.Nodes.Count == 0)
                {
                    var a = (Account)tag;
                    _ = getDirAsync(a, node);
                }
            }
            // 双击可选择的目录
            else if (node.Nodes.Count == 0)
            {
                var f = (IImapFolder)tag;
                _ = getMailListAsync(f, node);
            }
        }

        private void addBtn_Click(object sender, EventArgs e)
        {
            newAccountTabEvent(true, null);
        }

        private void editBtn_Click(object sender, EventArgs e)
        {
            var a = (Account)tree.SelectedNode.Tag;
            newAccountTabEvent(false, a);
        }

        private void delBtn_Click(object sender, EventArgs e)
        {
            var a = (Account)tree.SelectedNode.Tag;
            eventDel(a.a_id ?? 0);
        }
    }
}