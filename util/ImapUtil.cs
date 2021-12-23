using MailKit;
using MailKit.Net.Imap;
using MailKit.Security;
using System.Collections.Generic;
using wfemail.db.entity;

namespace wfemail.util
{
    public class ImapUtil
    {
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

        public static IList<IMailFolder> getDir(ImapClient client)
        {
            return client.GetFolders(client.PersonalNamespaces[0]);
        }

        public static void getMail(ImapClient client, string folder)
        {
        }
    }
}