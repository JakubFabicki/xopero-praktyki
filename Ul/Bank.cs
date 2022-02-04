using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ul
{
    class Bank
    {
        public int Money { get; private set; }

        public Bank()
        {
        }

        public void AddMoney()
        {
            Money += 10;
        }
    }
}
