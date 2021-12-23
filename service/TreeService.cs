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
            var dList = ImapUtil.getDir(imap);
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
    }
}