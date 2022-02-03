using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Krystyna
{
    public partial class Form1 : Form
    {
        DinnerParty dinnerParty;
        public Form1()
        {
            InitializeComponent();
            dinnerParty = new DinnerParty() { NumberOfPeople = 5 };
            label2.Text = dinnerParty.CalculateCost(false, true, dinnerParty.NumberOfPeople).ToString();
        }

        public void DisplayDinnerPartyCost()
        {
            label2.Text = dinnerParty.CalculateCost(healtCbx.Checked, decCbx.Checked, (int) NumUp.Value).ToString();
        }

        private void NumUp_ValueChanged(object sender, EventArgs e)
        {
            DisplayDinnerPartyCost();
        }

        private void decCbx_CheckedChanged(object sender, EventArgs e)
        {
            DisplayDinnerPartyCost();
        }

        private void healtCbx_CheckedChanged(object sender, EventArgs e)
        {
            DisplayDinnerPartyCost();
        }
    }
}
