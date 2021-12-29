using MimeKit;
using System;
using System.Diagnostics;
using System.IO;
using System.Windows.Forms;

namespace wfemail.form.control
{
    public partial class AttachmentPanel : UserControl
    {
        private MimeEntity attachment;

        public AttachmentPanel(MimeEntity attachment)
        {
            InitializeComponent();
            this.attachment = attachment;
            Debug.WriteLine(attachment.ContentType);
            linkLabel1.Text = attachment.ContentDisposition.FileName;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Hide();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            using (var sfd = new SaveFileDialog())
            {
                sfd.FileName += attachment.ContentDisposition.FileName;
                sfd.Filter = "所有文件|*.*";
                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    using (var stream = File.Create(sfd.FileName))
                    {
                        if (attachment is MessagePart)
                        {
                            var part = attachment as MessagePart;
                            part.Message.WriteTo(stream);
                        }
                        else
                        {
                            var part = attachment as MimePart;
                            part.Content.DecodeTo(stream);
                        }
                        Hide();
                    }
                }
            }
        }
    }
}