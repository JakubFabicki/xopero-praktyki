using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Krystyna
{
    class DinnerParty
    {
        public int NumberOfPeople;
        private float CostOfDecorations;
        private bool rabat = false;

        public float CalculateCost(bool healtDinner, bool decorationDinner, int NumberOfPeople2)
        {
            NumberOfPeople = NumberOfPeople2;
            CostOfDecorations = 25 * NumberOfPeople;
            if (healtDinner)
            {
                rabat = true;
                CostOfDecorations += 5 * NumberOfPeople;
            }
            else
            {
                rabat = false;
                CostOfDecorations += 20 * NumberOfPeople;
            }

            if (decorationDinner)
                CostOfDecorations += 15 * NumberOfPeople + 50; 
            else
                CostOfDecorations += 7.5f * NumberOfPeople + 30;

            if (rabat)
                CostOfDecorations *= 0.95f;

            return CostOfDecorations;
        }
    }
}
