using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Farmerzy
{
    class Farmer
    {
        private int feedMultipler;
        private int numberOfCows;

        public int BagsOfFeed { get; private set; }
        
        public int NumberOfCows
        {
            get
            {
                return numberOfCows;
            }
            set
            {
                numberOfCows = value;
                BagsOfFeed = numberOfCows * feedMultipler;
            }
        }
        
        ///konstruktor
        public Farmer(int numberOfCows, int feedMultipler)
        {
            this.feedMultipler = feedMultipler;
            NumberOfCows = numberOfCows;
        }
    }
}
