using System.Windows.Forms;

namespace wfemail.form.control
{
    public partial class MailViewer : UserControl
    {
        public WebBrowser box;

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
    }
}