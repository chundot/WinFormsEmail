using MailKit;
using MailKit.Net.Imap;
using System.Windows.Forms;
using wfemail.db.entity;
using wfemail.service;
using wfemail.util;

namespace wfemail
{
    public partial class OldForm : Form
    {
        private ImapClient imap;
        private TreeService treeService;
        private ListService listService;

        public OldForm()
        {
            InitializeComponent();
            treeService = new TreeService(treeAccount, tLabel1);
            listService = new ListService(listMail, tLabel2);
            treeService.treeInit();
        }

        private void treeAccount_NodeMouseClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            var node = e.Node;
            var tag = node.Tag;
            var type = tag.GetType();
            // 点击邮箱账号时
            if (type == typeof(Account))
            {
                if (node.Nodes.Count == 0)
                {
                    var a = (Account)tag;
                    tLabel1.Text = "正在获取邮件文件夹...";
                    imap = ImapUtil.newImap(a);
                    listService.imap = imap;
                    treeService.imap = imap;
                    treeService.refreshDir(node);
                }
            }
            // 点击文件夹时
            else if (node.Nodes.Count == 0)
            {
                listService.updateLabelInfo((IMailFolder)node.Tag);
            }
        }

        private void treeAccount_NodeMouseDoubleClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            var node = e.Node;
            var tag = node.Tag;
            var type = tag.GetType();
            if (type == typeof(Account))
            {
            }
            else if (node.Nodes.Count == 0)
            {
                listService.updateList(node);
            }
        }

        private void listMail_SelectedIndexChanged(object sender, System.EventArgs e)
        {

        }
    }
}