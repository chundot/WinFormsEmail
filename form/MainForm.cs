using Sunny.UI;
using System.Collections.Generic;
using System.Windows.Forms;
using wfemail.db.entity;

namespace wfemail
{
    public partial class MainForm : UIForm
    {
        public MainForm()
        {
            InitializeComponent();

            List<Account> aList = DB.getAccounts();
            foreach (Account a in aList)
            {
                TreeNode node = new TreeNode(a.a_account);
                treeAccount.Nodes.Add(node);
            }
        }
    }
}