using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClassProject
{
    class Talker
    {
        public static int BlahBlahBlah(string thingToSay, int numberOfTimes)
        {
            string finalString = "";
            int i;
            for (i = 0; i < numberOfTimes; i++)
                finalString = finalString + thingToSay + "\n";
            MessageBox.Show(finalString);
            return finalString.Length - i;
        }
    }
}
