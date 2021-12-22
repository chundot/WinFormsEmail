using MailKit.Net.Imap;
using MailKit.Security;
using System;
using System.Collections.Generic;
using System.Text;
using wfemail.db.entity;

namespace wfemail.util
{
    class Imap
    {
        public void getDir(Account account)
        {
            ImapClient client = new ImapClient();
            client.Connect(account.a_imap, account.a_imap_port, SecureSocketOptions.SslOnConnect);
            client.Authenticate(account.a_account, account.a_pass);
        }
    }
}
