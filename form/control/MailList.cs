using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace wfemail.form.control
{
    public partial class MailList : UserControl
    {
        public ListView list;
        public MailList()
        {
            InitializeComponent();
            list = listMail;
        }
        public void L(string status)
        {
            label1.Text = status;
        }
    }
}
