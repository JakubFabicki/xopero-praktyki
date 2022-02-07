using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ul
{
    public interface IStingPatrol
    {
        int AlertLevel { get; }
        int StingerLenght { get; set; }
        bool LookForEnemies();
        int SharpenStinger(int Lenght);
    }

    class StingPatrol 
    {
        public int AlertLevel { get; private set; }
        public int StingerLenght { get; set; }
     
        public StingPatrol()
        {

        }

        public bool SharpensStinger(int Lenght)
        {
            return false;
        }

        public bool LookForEnemies()
        {
            return false;
        }

        public void Sting(string Enemy)
        {

        }
    }
}
