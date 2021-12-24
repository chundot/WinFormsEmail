using MailKit;
using MailKit.Net.Imap;
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

        public AccountTree()
        {
            InitializeComponent();
            _ = initAsync();
        }

        public async Task initAsync()
        {
            label.Text = "读取用户中...";
            var aList = await db.acnt.GetListAsync();
            foreach (Account a in aList)
            {
                TreeNode a_node = new TreeNode(a.a_account, 1, 1);
                a_node.ImageIndex = 1;
                a_node.Name = a.a_id.ToString();
                a_node.Tag = a;
                tree.Nodes.Add(a_node);
            }
            label.Text = "用户邮箱列表";
        }

        public async Task getDirAsync(Account a, TreeNode node)
        {
            // 产生新的imap实例
            label.Text = "登录中...";
            var imap = await ImapUtil.getImap(a);
            label.Text = "文件夹加载中...";
            var dList = await imap.GetFoldersAsync(imap.PersonalNamespaces[0]);
            foreach (var d in dList)
            {
                var d_node = new TreeNode();
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
            label.Text = "文件夹加载完成！";
        }

        public async Task getDirInfoAsync(IImapFolder f, TreeNode node)
        {
            // 检测连接
            var p = node.Parent;
            while (p.Parent != null) p = p.Parent;
            await ImapUtil.getImap((Account)p.Tag);
            // 打开文件夹
            label.Text = "正在打开文件夹...";
            if (!f.IsOpen) await f.OpenAsync(MailKit.FolderAccess.ReadOnly);
            label.Text = string.Format("{0} 条邮件, {1} 条最近", f.Count, f.Recent);
        }

        public async Task getMailList(IImapFolder f, TreeNode node)
        {
            // 检测连接
            var p = node.Parent;
            while (p.Parent != null) p = p.Parent;
            await ImapUtil.getImap((Account)p.Tag);
            // 添加邮件主题等简略信息到列表
            label.Text = "正在打开文件夹...";
            if (!f.IsOpen) await f.OpenAsync(MailKit.FolderAccess.ReadOnly);
            label.Text = "正在读取文件夹里的信息...";
            var eList = await f.FetchAsync(0, -1, MessageSummaryItems.Envelope);
            list.Items.Clear();
            foreach (var i in eList)
            {
                var item = new ListViewItem(i.Envelope.Subject);
                item.SubItems.Add(i.Envelope.Date.ToString());
                list.Items.Add(item);
            }
            label.Text = "读取完成！";
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
                if (node.Nodes.Count == 0)
                {
                    node.ImageIndex = 2;
                    var a = (Account)tag;
                    _ = getDirAsync(a, node);
                }
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
            }
            // 双击可选择的目录
            else if (node.Nodes.Count == 0)
            {
                var f = (IImapFolder)tag;
                _ = getMailList(f, node);
            }
        }
    }
}