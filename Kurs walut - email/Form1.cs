using System;
using System.Windows.Forms;

namespace Kurs_walut___email
{
    public partial class Form1 : Form
    {
        private static Form1 form = null;

        mail mailObj;

        public Form1()
        {
            form = this;
            mailObj = new mail(form);
            InitializeComponent();
            mailObj.getCurrency();
        }
        
        private void mailStartBtn_Click(object sender, EventArgs e)
        {
            mailObj.sendMailStart();
        }

    }
}