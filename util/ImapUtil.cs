using MailKit.Net.Imap;
using MailKit.Security;
using System.Collections.Generic;
using System.Threading.Tasks;
using wfemail.db.entity;

namespace wfemail.util
{
    public class ImapUtil
    {
        private enum ImapState
        {
            Ready,
            Waiting
        }

        private struct Imap
        {
            public ImapState state;
            public int a_id;
            public ImapClient client;
        }

        private static List<Imap> imaps = new List<Imap>();

        public static async Task<ImapClient> getImap(Account a)
        {
            // 对象池寻找
            var imap = imaps.Find((Imap i) =>
            {
                return i.a_id == a.a_id;
            });
            if (imap.client != null)
            {
                if (imap.client.IsConnected)
                    return imap.client;
                else
                {
                    await imap.client.ConnectAsync(a.a_imap, a.a_imap_port, SecureSocketOptions.SslOnConnect);
                    await imap.client.AuthenticateAsync(a.a_account, a.a_pass);
                    return imap.client;
                }
            }
            // 产生新imap实例
            imap = new Imap();
            imap.state = ImapState.Waiting;
            imap.a_id = a.a_id ?? 0;
            imap.client = new ImapClient();
            await imap.client.ConnectAsync(a.a_imap, a.a_imap_port, SecureSocketOptions.SslOnConnect);
            await imap.client.AuthenticateAsync(a.a_account, a.a_pass);
            imap.state = ImapState.Ready;
            imaps.Add(imap);
            return imap.client;
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

                default:
                    return "inbox";
            }
        }
    }
}