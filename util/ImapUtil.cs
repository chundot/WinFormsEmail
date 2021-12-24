using MailKit;
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
            imap.a_id = a.a_id;
            imap.client = new ImapClient();
            await imap.client.ConnectAsync(a.a_imap, a.a_imap_port, SecureSocketOptions.SslOnConnect);
            await imap.client.AuthenticateAsync(a.a_account, a.a_pass);
            imap.state = ImapState.Ready;
            imaps.Add(imap);
            return imap.client;
        }

        public static ImapClient newImap(Account account)
        {
            ImapClient client = new ImapClient();
            client.Connect(account.a_imap, account.a_imap_port, SecureSocketOptions.SslOnConnect);
            client.Authenticate(account.a_account, account.a_pass);
            return client;
        }

        public static string getDisName(string str)
        {
            switch (str)
            {
                case "INBOX":
                    return "收件箱";

                case "Sent Messages":
                    return "已发送";

                case "Junk":
                    return "垃圾箱";

                case "Drafts":
                    return "草稿";

                case "Deleted Messages":
                    return "已删除";

                default:
                    return str;
            }
        }

        public static Task<IList<IMailFolder>> getDir(ImapClient client)
        {
            return client.GetFoldersAsync(client.PersonalNamespaces[0]);
        }

        public static void getMail(ImapClient client, string folder)
        {
        }
    }
}