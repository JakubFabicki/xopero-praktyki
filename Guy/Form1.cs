using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Guy
{
    public partial class Form1 : Form
    {
        guys joshV;
        guys boshV;
        int bankV = 100;

        public Form1()
        {
            InitializeComponent();
            joshV = new guys() {Name = "Josh", Cash = 50};
            boshV = new guys() {Name = "Bosh", Cash = 100};
        }

        public void UpdateForm()
        {
            josh.Text = joshV.Name + " ma " + joshV.Cash + " zł";
            bosh.Text = boshV.Name + " ma " + boshV.Cash + " zł";
            bank.Text = "Bank ma " + bankV + " zł";
        }

        private void reciveBtn_Click(object sender, EventArgs e)
        {
            if (bankV >= 10)
            {
                bankV -= joshV.ReciveCash(10);
                UpdateForm();
            }
            else
                MessageBox.Show("Bank nie posiada tyle pieniędzy");
        }

        private void giveBtn_Click(object sender, EventArgs e)
        {
            bankV += boshV.GiveCash(5);
            UpdateForm();
        }
    }
}
