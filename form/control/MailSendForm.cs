using MailKit;
using MimeKit;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using wfemail.db.entity;

namespace wfemail.form.control
{
    public partial class MailSendForm : UserControl
    {
        private WebBrowser webBrowser;
        private HtmlDocument doc;
        private HtmlElement div;
        public delegate void sendMail(MailInfo info);
        private event sendMail onSendMail;
        private List<MimeEntity> list = new List<MimeEntity>();
        public MailSendForm(sendMail fn)
        {
            InitializeComponent();
            webInit();
            onSendMail += fn;
        }

        public void replyInit(Envelope envelope)
        {
            toBox.Text = envelope.From.First().Name;
            subBox.Text = "回复：" + envelope.Subject;
        }

        private void webInit()
        {
            webBrowser = new WebBrowser();
            webBrowser.Dock = DockStyle.Fill;
            webBrowser.DocumentText = @"<div contenteditable=""true"" />";
            webBrowser.DocumentCompleted += (s, e) =>
            {
                doc = webBrowser.Document;
                div = doc.GetElementsByTagName("div")[0];
            };
            panelMain.Controls.Add(webBrowser);
        }

        public void comboInit(List<Account> aList)
        {
            foreach (var a in aList)
            {
                senderCombo.Items.Add(a.a_account);
            }
            senderCombo.SelectedIndex = 0;
        }

        public string htmlBody => div.InnerHtml;

        public void foreColor(Color color)
        {
            doc.ExecCommand("foreColor", false, ColorTranslator.ToHtml(color));
        }

        public void backColor(Color color)
        {
            doc.ExecCommand("backColor", false, ColorTranslator.ToHtml(color));
        }

        public void heading(Headings heading)
        {
            doc.ExecCommand("formatBlock", false, $"<{heading}>");
        }

        public enum Headings
        { H1, H2, H3, H4, H5, H6 }

        // 事件绑定
        private void boldBtn_Click(object sender, EventArgs e)
        {
            doc.ExecCommand("bold", false, null);
        }

        private void italicBtn_Click(object sender, EventArgs e)
        {
            doc.ExecCommand("italic", false, null);
        }

        private void udlBtn_Click(object sender, EventArgs e)
        {
            doc.ExecCommand("underline", false, null);
        }

        private void insPicBtn_Click(object sender, EventArgs e)
        {
            using (var ofd = new OpenFileDialog())
            {
                ofd.Filter = "图片文件|*.png;*.jpg;*.gif;*.jpeg;*.bmp";
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    using (var image = Image.FromFile(ofd.FileName))
                    {
                        // 插入图片转base64
                        var bytes = (byte[])new ImageConverter().ConvertTo(image, typeof(byte[]));
                        var src = $"data:image/png;base64,{Convert.ToBase64String(bytes)}";
                        doc.ExecCommand("insertImage", false, src);
                    }
                }
            }
        }

        private void listOrderBtn_Click(object sender, EventArgs e)
        {
            doc.ExecCommand("insertOrderedList", false, null);
        }

        private void listBtn_Click(object sender, EventArgs e)
        {
            doc.ExecCommand("insertUnOrderedList", false, null);
        }

        private void infoBtn_Click(object sender, EventArgs e)
        {
            if (rePanel.Visible)
                rePanel.Hide();
            else rePanel.Show();
        }

        private void sendBtn_Click(object sender, EventArgs e)
        {
            var info = new MailInfo();
            info.to = toBox.Text;
            info.from = senderCombo.SelectedItem as string;
            info.subject = subBox.Text;
            info.html = htmlBody;
            info.attachments = list;
            onSendMail(info);
        }

        private void attachBtn_Click(object sender, EventArgs e)
        {
            using (var ofd = new OpenFileDialog())
            {
                ofd.Filter = "所有文件|*.*";
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    var attachment = new MimePart()
                    {
                        Content = new MimeContent(File.OpenRead(ofd.FileName)),
                        ContentDisposition = new ContentDisposition(ContentDisposition.Attachment),
                        ContentTransferEncoding = ContentEncoding.Base64,
                        FileName = Path.GetFileName(ofd.FileName)
                    };
                    list.Add(attachment);
                    // 添加附件栏
                    var attachPanel = new AttachmentPanel(attachment);
                    panelMain.Controls.Add(attachPanel);
                    attachPanel.Dock = DockStyle.Top;
                    attachPanel.BringToFront();
                }
            }
        }
    }
    public struct MailInfo
    {
        public string from;
        public string to;
        public string subject;
        public string html;
        public List<MimeEntity> attachments;
    }
}