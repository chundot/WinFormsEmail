using MailKit.Net.Smtp;
using MimeKit;
using System.Collections.Generic;
using System.Threading.Tasks;
using wfemail.db.entity;
using wfemail.form.control;

namespace wfemail.util
{
    internal class SmtpUtil
    {
        private static List<Client> clients = new List<Client>();

        public struct Client
        {
            public string account;
            public SmtpClient client;
        }

        public static async Task<Client> getClient(Account account)
        {
            var tmp = clients.Find((Client c) => { return c.account.Equals(account.a_account); });
            if (tmp.client != null) return tmp;
            tmp.account = account.a_account;
            tmp.client = new SmtpClient();
            await tmp.client.ConnectAsync(account.a_smtp, account.a_smtp_port);
            await tmp.client.AuthenticateAsync(account.a_account, account.a_pass);
            clients.Add(tmp);
            return tmp;
        }

        public static async Task sendMail(Account account, MailInfo info)
        {
            var sClient = await getClient(account);
            var client = sClient.client;
            var msg = new MimeMessage();
            msg.From.Add(new MailboxAddress(info.from, info.from));
            msg.To.Add(new MailboxAddress(info.to, info.to));
            msg.Subject = info.subject;
            var multipart = new Multipart("mixed");
            var body = new TextPart("html")
            {
                Text = info.html
            };
            // 追加附件
            foreach (var attachment in info.attachments)
                multipart.Add(attachment);
            multipart.Add(body);
            msg.Body = multipart;
            await client.SendAsync(msg);
        }
    }
}