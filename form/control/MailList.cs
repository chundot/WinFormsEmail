using System.Diagnostics;
using System.Windows.Forms;

namespace wfemail.form.control
{
    public partial class MailList : UserControl
    {
        public ListView list;

        public delegate void viewMail(ListViewItem item);

        public event viewMail eventOpenMail;

        public MailList()
        {
            InitializeComponent();
            list = listMail;
        }

        public void L(string status)
        {
            label1.Text = status;
        }

        private void listMail_DoubleClick(object sender, System.EventArgs e)
        {
            if (listMail.SelectedItems != null)
            {
                eventOpenMail(listMail.SelectedItems[0]);
            }
        }
    }
}