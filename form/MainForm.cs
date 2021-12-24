using System.Windows.Forms;

namespace wfemail.form
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            treeAccount.list = listMail.list;
        }
    }
}