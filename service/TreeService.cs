using MailKit.Net.Imap;
using System.Windows.Forms;
using wfemail.db.entity;
using wfemail.util;

namespace wfemail.service
{
    internal class TreeService
    {
        public ImapClient imap { get; set; }
        private TreeView tree;
        private ToolStripLabel label;

        public TreeService(TreeView tree, ToolStripLabel label)
        {
            this.tree = tree;
            this.label = label;
        }

        public void treeInit()
        {
            var aList = new DB().acnt.GetList();
            foreach (Account a in aList)
            {
                TreeNode a_node = new TreeNode(a.a_account, 1, 1);
                a_node.ImageIndex = 1;
                a_node.Name = a.a_id.ToString();
                a_node.Tag = a;
                tree.Nodes.Add(a_node);
            }
        }

        public void refreshDir(TreeNode node)
        {
            label.Text = "文件夹加载完成！";
        }
    }
}