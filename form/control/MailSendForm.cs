using System.Windows.Forms;

namespace wfemail.form.control
{
    public partial class MailSendForm : UserControl
    {
        WebBrowser webBrowser;
        HtmlDocument doc;
        HtmlElement div;
        public MailSendForm()
        {
            InitializeComponent();
            webBrowser = new WebBrowser();
            webBrowser.DocumentText = @"<div contenteditable=""true""></div>";
            webBrowser.Dock = DockStyle.Fill;
            webBrowser.DocumentCompleted += (s, e) =>
            {
                doc = (HtmlDocument) webBrowser.Document.DomDocument;
                div = doc.GetElementsByTagName("div")[0];
            };
            Controls.Add(webBrowser);
        }

        void bold() { doc.ExecCommand("bold", false, null); }
    }
}