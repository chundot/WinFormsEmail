using MailKit;
using MailKit.Net.Imap;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Windows.Forms;

namespace wfemail.form.control
{
    public partial class MailList : UserControl
    {
        public ListView list;

        public delegate void viewMail(ListViewItem item);

        public delegate void setMailFlag(ListViewItem item, MessageFlags flag);

        public delegate void refresh();

        public delegate void getMailListByPage(IImapFolder f, int curPage, int numPerPage);

        public event viewMail eventOpenMail;

        public event setMailFlag eventSetMailFlag;

        public event refresh eventRefresh;

        public event getMailListByPage eventGetMailList;

        private IImapFolder curFolder;

        private int maxPage = 1;
        private int curPage = 1;
        public int numPerPage = 10;

        public MailList()
        {
            InitializeComponent();
            CheckForIllegalCrossThreadCalls = false;
            list = listMail;
        }

        public void updateList(IList<IMessageSummary> eList)
        {
            updatePageLabel();
            list.Items.Clear();
            for (int index = eList.Count - 1; index >= 0; index--)
            {
                var i = eList[index];
                var item = new ListViewItem(i.Envelope.Subject ?? "(无主题)");
                if (i.Flags.Equals(MessageFlags.Seen))
                    item.ImageIndex = 1;
                else item.ImageIndex = 0;
                string date = "日期未获取";
                if (i.InternalDate != null)
                    date = i.InternalDate?.DateTime.ToString();
                item.Tag = i;
                item.SubItems.Add(date);
                list.Items.Add(item);
            }
        }

        public void updateItem(MessageFlags flag)
        {
            var index = list.SelectedItems[0].Index;
            if (flag.Equals(MessageFlags.Seen))
                list.Items[index].ImageIndex = 1;
            else if (flag.Equals(MessageFlags.None))
                list.Items[index].ImageIndex = 0;
            else
                list.Items[index].Remove();
        }

        public void updatePageLabel()
        {
            int count = curFolder.Count;
            int start = (curPage - 1) * numPerPage + 1;
            int end = curPage * numPerPage;
            end = (end > count) ? count : end;
            toolPageLabel.Text = $"{curPage}/{maxPage}页 {start}-{end}/{count}条";
        }

        public void loadNewFolder(IImapFolder f)
        {
            curFolder = f;
            maxPage = f.Count / numPerPage;
            maxPage += ((f.Count % numPerPage) != 0) ? 1 : 0;
            curPage = 1;
            pageChanged();
        }

        public void pageChanged()
        {
            if (curPage < 1) curPage = 1;
            else if (curPage > maxPage) curPage = maxPage;
            eventGetMailList(curFolder, curPage, numPerPage);
        }

        // 事件绑定
        private void listMail_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                eventOpenMail(listMail.SelectedItems[0]);
            }
        }

        private void viewItem_Click(object sender, EventArgs e)
        {
            if (listMail.SelectedItems != null)
                eventOpenMail(listMail.SelectedItems[0]);
        }

        private void listMail_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                var res = listMail.SelectedItems.Count != 0;
                for (int i = 0; i < 5; i++)
                    ctxMailList.Items[i].Enabled = res;
                ctxMailList.Show(MousePosition);
            }
        }

        private void refreshItem_Click(object sender, EventArgs e)
        {
            eventRefresh();
        }

        private void readItem_Click(object sender, EventArgs e)
        {
            eventSetMailFlag(listMail.SelectedItems[0], MessageFlags.Seen);
        }

        private void unreadItem_Click(object sender, EventArgs e)
        {
            eventSetMailFlag(listMail.SelectedItems[0], MessageFlags.None);
        }

        private void junkItem_Click(object sender, EventArgs e)
        {
            eventSetMailFlag(listMail.SelectedItems[0], MessageFlags.UserDefined);
        }

        private void delItem_Click(object sender, EventArgs e)
        {
            eventSetMailFlag(listMail.SelectedItems[0], MessageFlags.Deleted);
        }

        private void firstBtn_Click(object sender, EventArgs e)
        {
            curPage = 1;
            pageChanged();
        }

        private void lastBtn_Click(object sender, EventArgs e)
        {
            curPage = maxPage;
            pageChanged();
        }

        private void prevBtn_Click(object sender, EventArgs e)
        {
            curPage--;
            pageChanged();
        }

        private void nextBtn_Click(object sender, EventArgs e)
        {
            curPage++;
            pageChanged();
        }
    }
}