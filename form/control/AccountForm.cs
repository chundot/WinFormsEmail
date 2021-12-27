using System;
using System.Diagnostics;
using System.Linq;
using System.Windows.Forms;
using wfemail.db.entity;

namespace wfemail.form.control
{
    public partial class AccountForm : UserControl
    {
        public delegate void submit(Account a);

        public event submit eventSubmit;

        private Account a = new Account();

        public AccountForm()
        {
            InitializeComponent();
        }

        public void init(Account a)
        {
            this.a = a;
            textAccount.Text = a.a_account;
            textPass.Text = a.a_pass;
            textSmtp.Text = a.a_smtp;
            textImap.Text = a.a_imap;
            numIPort.Value = a.a_imap_port;
            numSPort.Value = a.a_smtp_port;
        }

        public void textIntoAccount()
        {
            a.a_account = textAccount.Text;
            a.a_pass = textPass.Text;
            a.a_smtp = textSmtp.Text;
            a.a_imap = textImap.Text;
            a.a_imap_port = (int)numIPort.Value;
            a.a_smtp_port = (int)numSPort.Value;
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            textIntoAccount();
            eventSubmit(a);
        }

        private void checkBoxAuto_CheckedChanged(object sender, EventArgs e)
        {
            var res = !checkBoxAuto.Checked;
            numSPort.Enabled = numIPort.Enabled = textImap.Enabled = textSmtp.Enabled = res;
        }

        private void textAccount_Leave(object sender, EventArgs e)
        {
            var text = textAccount.Text;
            if (checkBoxAuto.Checked)
            {
                if (text.Contains("@"))
                {
                    textSmtp.Text = "smtp." + text.Split("@").Last();
                    textImap.Text = "imap." + text.Split("@").Last();
                }
                numIPort.Value = 993;
                numSPort.Value = 587;
            }
        }
    }
}