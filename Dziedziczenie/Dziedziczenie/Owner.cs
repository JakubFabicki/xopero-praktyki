using System;
using System.Collections.Generic;
using System.Text;

namespace Dziedziczenie
{
    class Owner
    {
        private Jewels returnedContents;
        public void ReciveContents(Jewels safeContents)
        {
            returnedContents = safeContents;
            Console.WriteLine("Dziękuję za zwrócenie klejnotów" + safeContents.Sparkle());
        }
    }
}
