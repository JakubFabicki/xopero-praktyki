using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Farmerzy
{
    public partial class Form1 : Form
    {
        Farmer farmer;

        public Form1()
        {
            InitializeComponent();
            farmer = new Farmer(15, 30);
        }

        private void OblBtn_Click(object sender, EventArgs e)
        {
            Console.WriteLine("Potrzebuje {0} worków paszy do wykarmienia {1} krów", farmer.BagsOfFeed, farmer.NumberOfCows);
        }

        private void cowNum_ValueChanged(object sender, EventArgs e)
        {
            farmer.NumberOfCows = (int) cowNum.Value;
        }
    }
}
