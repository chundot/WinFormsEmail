using MailKit;
using MailKit.Net.Imap;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Windows.Forms;
using wfemail.db.entity;
using wfemail.util;

namespace wfemail.form.control
{
    public partial class AccountTree : UserControl
    {
        public TreeView treeView;

        public delegate void del();

        public delegate void mod(bool add);

        public delegate void getMail(IImapFolder f, TreeNode node);

        public event del onDel;

        public event mod onMod;

        public event getMail eventGetMail;

        public AccountTree()
        {
            InitializeComponent();
            treeView = tree;
        }

        // 控件本身相关
        public void L(string str)
        {
            label.Text = str;
        }

        public Account getCurAcc()
        {
            var accItem = tree.SelectedNode;
            if (accItem == null) return null;
            while (accItem.Parent != null) accItem = accItem.Parent;
            return (Account)accItem.Tag;
        }

        // 用户相关
        // 载入sqlite中的用户
        public void init(List<Account> aList)
        {
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
        public async void getDirAsync(Account a, TreeNode node)
        {
            // 检测连接
            ImapUtil.check(node);
            // 加载网页
            L("文件夹加载中...");
            var dList = await ImapUtil.getFolders(a);
            node.Nodes.Clear();
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
            ImapUtil.check(node);
            // 打开文件夹
            L("正在打开文件夹...");
            await ImapUtil.openFolder(f);
            L(string.Format("{0} 条邮件, {1} 条最近", f.Count, f.Recent));
        }

        // 绑定的事件
        // 单击树形图列表物品
        private void tree_NodeMouseClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
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
        }

        // 双击树形图列表物品
        private void tree_NodeMouseDoubleClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                var node = e.Node;
                var tag = node.Tag;
                var type = tag.GetType();
                // 双击账户名时
                if (type == typeof(Account))
                {
                    if (node.Nodes.Count == 0)
                    {
                        var a = tag as Account;
                        getDirAsync(a, node);
                    }
                }
                // 双击可选择的目录
                else if (node.Nodes.Count == 0)
                {
                    var f = tag as IImapFolder;
                    eventGetMail(f, node);
                }
            }
        }

        private void tree_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                var type = tree.SelectedNode.Tag.GetType();
                var selAcc = type == typeof(Account);
                userCtx.Items[1].Visible = selAcc;
                userCtx.Items[2].Visible = selAcc;
                userCtx.Items[3].Visible = !selAcc;
                userCtx.Items[4].Visible = !selAcc;
                userCtx.Show(MousePosition);
            }
        }

        private void addUser_Click(object sender, EventArgs e)
        {
            onMod(true);
        }

        private void editUser_Click(object sender, EventArgs e)
        {
            onMod(false);
        }

        private void delUser_Click(object sender, EventArgs e)
        {
            onDel();
        }

        private void openBoxItem_Click(object sender, EventArgs e)
        {
            var node = tree.SelectedNode;
            var f = node.Tag as IImapFolder;
            eventGetMail(f, node);
        }

        private void tree_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                var node = tree.GetNodeAt(e.Location);
                if (node != null)
                    tree.SelectedNode = node;
            }
        }
    }
}