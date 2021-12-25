using System.Windows.Forms;

namespace wfemail.form.control
{
    public partial class MailViewer : UserControl
    {
        public WebBrowser box;

        public MailViewer()
        {
            InitializeComponent();
            box = new WebBrowser();
            box.Dock = DockStyle.Fill;
            Controls.Add(box);
        }

        public void cDispose()
        {
            box.Dispose();
            Dispose();
        }
    }
}