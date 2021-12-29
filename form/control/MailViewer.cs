using MimeKit;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace wfemail.form.control
{
    public partial class MailViewer : UserControl
    {
        public WebBrowser box;
        private List<AttachmentPanel> list = new List<AttachmentPanel>();
        public MailViewer()
        {
            InitializeComponent();
            webInit();
        }

        public void webInit()
        {
            box = new WebBrowser();
            box.Dock = DockStyle.Fill;
            panel1.Controls.Add(box);
        }

        public void newAttachment(MimeEntity attachment)
        {
            var attachBar = new AttachmentPanel(attachment);
            list.Add(attachBar);
            panel1.Controls.Add(attachBar);
            attachBar.Dock = DockStyle.Top;
        }

        public void newAttachments(IEnumerable<MimeEntity> attachments)
        {
            if (attachments.Count() != 0)
                toolStrip1.Visible = true;
            foreach (var attachment in attachments)
                newAttachment(attachment);
        }

        public void showAllAttach(bool show)
        {
            foreach (var panel in list)
                panel.Visible = show;
        }

        private void toolStripButton1_Click(object sender, System.EventArgs e)
        {
            showAllAttach(!list[0].Visible);
        }
    }
}