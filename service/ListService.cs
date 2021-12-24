using MailKit;
using MailKit.Net.Imap;
using System;
using System.Windows.Forms;

namespace wfemail.service
{
    public class ListService
    {
        public ImapClient imap { get; set; }
        private ToolStripLabel label;
        private ListView list;

        public ListService(ListView list, ToolStripLabel label)
        {
            this.list = list;
            this.label = label;
        }

        public void updateLabelInfo(IMailFolder folder)
        {
            label.Text = string.Format("正在打开 {0}...", folder.Name);
            if (!folder.IsOpen)
                folder.Open(FolderAccess.ReadOnly);
            label.Text = string.Format("{0} 条邮件, {1} 条最近.", folder.Count, folder.Recent);
        }

        public void updateList(TreeNode node)
        {
            label.Text = string.Format("正在获取 {0} 的信息...", node.Text);
            var folder = (IMailFolder)node.Tag;
            if (!folder.IsOpen)
                folder.Open(FolderAccess.ReadOnly);
            list.Items.Clear();
            foreach (var summary in folder.Fetch(0, -1, MessageSummaryItems.Envelope))
            {
                ListViewItem item = new ListViewItem(summary.Envelope.Subject);
                item.ImageIndex = 2;
                var time = summary.Envelope.Date ?? DateTimeOffset.Now;
                item.SubItems.Add(time.DateTime.ToString());
                list.Items.Add(item);
            }
            label.Text = string.Format("获取 {0} 的信息完成！", node.Text);
        }
    }
}