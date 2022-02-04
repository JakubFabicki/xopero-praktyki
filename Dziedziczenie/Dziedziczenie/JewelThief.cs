using System;
using System.Collections.Generic;
using System.Text;

namespace Dziedziczenie
{
    class JewelThief : Locksmith
    {
        private Jewels stolenJewels = null;
        override public void ReturnContents(Jewels safeContents, Owner owner)
        {
            stolenJewels = safeContents;
            Console.WriteLine("Kradnę zawartośc sejfu" + stolenJewels.Sparkle());
        }
    }
}
