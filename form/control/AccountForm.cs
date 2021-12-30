using MailKit.Net.Imap;
using MailKit.Net.Smtp;
using MailKit.Security;
using System;
using System.Linq;
using System.Net.Sockets;
using System.Windows.Forms;
using wfemail.db.entity;
using wfemail.util;

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
                if (text.Contains("163"))
                    numSPort.Value = 465;
                else numSPort.Value = 587;
            }
        }

        private async void btnTest_Click(object sender, EventArgs e)
        {
            textIntoAccount();
            try
            {
                await SmtpUtil.getClient(a);
                await ImapUtil.getImap(a);
            }
            catch (InvalidOperationException)
            {
                MessageBox.Show("请不要频繁测试！", "繁忙", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            catch (SocketException)
            {
                MessageBox.Show("无法找到IMAP或SMTP主机，请检查网络连接和配置信息！", "登录失败", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            catch (SmtpProtocolException)
            {
                MessageBox.Show("该账户的SMTP服务器端口或主机名配置错误！", "SMTP错误", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            catch (ImapProtocolException)
            {
                MessageBox.Show("该账户的IMAP服务器端口或主机名配置错误！", "IMAP错误", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            catch (AuthenticationException)
            {
                MessageBox.Show("账号或密码错误，无法登录！", "登录失败", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
    }
}