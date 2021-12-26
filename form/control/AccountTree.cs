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
        public ListView list;
        public delegate void del();
        public delegate void mod(bool add);
        public event del onDel;
        public event mod onMod;
        public AccountTree()
        {
            InitializeComponent();
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
            // 产生新的imap实例
            L("文件夹加载中...");
            var dList = await ImapUtil.getFolders(a);
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
            await ImapUtil.openFolder(f);
            L(string.Format("{0} 条邮件, {1} 条最近", f.Count, f.Recent));
        }

        public async void getMailListAsync(IImapFolder f, TreeNode node)
        {
            // 检测连接
            var p = node.Parent;
            while (p.Parent != null) p = p.Parent;
            // 添加邮件主题等简略信息到列表
            L("正在打开文件夹...");
            await ImapUtil.openFolder(f);
            L("正在读取文件夹里的信息...");
            var eList = await f.FetchAsync(0, -1, MessageSummaryItems.UniqueId | MessageSummaryItems.Envelope | MessageSummaryItems.Flags);
            // 载入到listView
            list.Items.Clear();
            for (int index = eList.Count - 1; index >= 0; index--)
            {
                var i = eList[index];
                var item = new ListViewItem(i.Envelope.Subject);
                if (i.Flags.Equals(MessageFlags.Seen))
                    item.ImageIndex = 1;
                else item.ImageIndex = 0;
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
                        var a = (Account)tag;
                        getDirAsync(a, node);
                    }
                }
                // 双击可选择的目录
                else if (node.Nodes.Count == 0)
                {
                    var f = (IImapFolder)tag;
                    getMailListAsync(f, node);
                }
            }
        }

        private void tree_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                if (tree.SelectedNode == null)
                {
                    userCtx.Items[1].Enabled = false;
                    userCtx.Items[2].Enabled = false;
                    userCtx.Show(MousePosition);
                }
                else
                {
                    userCtx.Items[1].Enabled = true;
                    userCtx.Items[2].Enabled = true;
                    userCtx.Show(MousePosition);
                }
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
    }
}