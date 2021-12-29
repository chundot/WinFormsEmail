using MailKit;
using MailKit.Net.Imap;
using MailKit.Security;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Windows.Forms;
using wfemail.db.entity;

namespace wfemail.util
{
    public class ImapUtil
    {
        public enum ImapState
        {
            Ready,
            Waiting
        }

        public struct Imap
        {
            public ImapState state;
            public int a_id;
            public ImapClient client;
            // 获得锁
            public void L() {
                while (state == ImapState.Waiting) ;
                state = ImapState.Waiting;
            }
            // 释放锁
            public void F()
            {
                state = ImapState.Ready;
            }
        }

        private static List<Imap> imaps = new List<Imap>();
        private static List<IImapFolder> folders = new List<IImapFolder>();
        private static List<IMailFolder> m_folders = new List<IMailFolder>();

        public static async Task<Imap> getImap(Account a)
        {
            // 对象池寻找
            var imap = imaps.Find((Imap i) =>
            {
                return i.a_id == a.a_id;
            });
            if (imap.client != null)
            {
                imap.L();
                if (!imap.client.IsConnected)
                {
                    await imap.client.ConnectAsync(a.a_imap, a.a_imap_port, SecureSocketOptions.SslOnConnect);
                    await imap.client.AuthenticateAsync(a.a_account, a.a_pass);
                }
                imap.F();
                return imap;
            }
            // 产生新imap实例
            imap.a_id = a.a_id ?? 0;
            imap.client = new ImapClient();
            await imap.client.ConnectAsync(a.a_imap, a.a_imap_port, SecureSocketOptions.SslOnConnect);
            await imap.client.AuthenticateAsync(a.a_account, a.a_pass);
            imaps.Add(imap);
            imap.F();
            return imap;
        }

        public static async void check(TreeNode node)
        {
            // 检测连接
            var p = node;
            while (p.Parent != null) p = p.Parent;
            await getImap((Account)p.Tag);
        }

        public static async Task<IList<IMailFolder>> getFolders(Account a)
        {
            var imap = await getImap(a);
            imap.L();
            var list = await imap.client.GetFoldersAsync(imap.client.PersonalNamespaces[0]);
            imap.F();
            return list;
        }

        public static async Task openFolder(IImapFolder f)
        {
            // 给正在打开的文件夹加锁
            while (folders.Contains(f)) 
                if (f.IsOpen) return;
            if (f.IsOpen) return;
            folders.Add(f);
            await f.OpenAsync(FolderAccess.ReadWrite);
            folders.Remove(f);
        }

        public static async Task openFolder(IMailFolder f)
        {
            // 给正在打开的文件夹加锁
            while (m_folders.Contains(f))
                if (f.IsOpen) return;
            if (f.IsOpen) return;
            m_folders.Add(f);
            await f.OpenAsync(FolderAccess.ReadWrite);
            m_folders.Remove(f);
        }

        public static string getDisName(string str)
        {
            switch (str)
            {
                case "INBOX":
                    return "收件箱";

                case "Sent Messages":
                    return "已发送";

                case "Sent Mail":
                    return "已发送";

                case "Junk":
                    return "垃圾箱";

                case "Drafts":
                    return "草稿";

                case "Deleted Messages":
                    return "已删除";

                case "Trash":
                    return "已删除";

                default:
                    return str;
            }
        }

        public static string getIconName(string str)
        {
            switch (str)
            {
                case "INBOX":
                    return "inboxdoc";

                case "Sent Messages":
                    return "sent";

                case "Drafts":
                    return "draft";

                case "Junk":
                    return "junk";

                case "Deleted Messages":
                    return "deleted";

                case "Trash":
                    return "deleted";

                default:
                    return "inbox";
            }
        }
    }
}