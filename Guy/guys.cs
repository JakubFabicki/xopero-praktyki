using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Guy
{
    class guys
    {
        public int Cash;
        public string Name;

        public int GiveCash(int amount)
        {
            if (amount <= Cash && amount > 0)
            {
                Cash -= amount;
                return amount;
            }
            else
            {
                MessageBox.Show("Nie mam tyle pieniędzy żeby je oddać" + amount, Name + "powiedział");
                return 0;
            }
        }
        public int ReciveCash(int amount)
        {
            if (amount > 0)
            {
                Cash += amount;
                return amount;
            }
            else
            {
                MessageBox.Show("Za mało" + amount, Name + "powiedział");
                return 0;
            }
        }
    }
}
