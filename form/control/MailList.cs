﻿using MailKit;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace wfemail.form.control
{
    public partial class MailList : UserControl
    {
        public ListView list;

        public delegate void viewMail(ListViewItem item);

        public delegate void setMailFlag(ListViewItem item, MessageFlags flag);

        public delegate void refresh();

        public event viewMail eventOpenMail;

        public event setMailFlag eventSetMailFlag;

        public event refresh eventRefresh;

        public MailList()
        {
            InitializeComponent();
            CheckForIllegalCrossThreadCalls = false;
            list = listMail;
        }

        public void updateList(IList<IMessageSummary> eList)
        {
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
        }

        public void updateItem(MessageFlags flag, int index)
        {
            if (flag.Equals(MessageFlags.Seen))
                list.Items[index].ImageIndex = 1;
            else if (flag.Equals(MessageFlags.None))
                list.Items[index].ImageIndex = 0;
            else
                list.Items[index].Remove();
        }

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
    }
}