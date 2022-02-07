using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ul
{
    class Queen : Bee
    {
        private Worker[] workers;
        private int shiftNumber;

        private double honeyConsumed;
    
        public Queen(Worker[] workers, double weightMg) : base(weightMg)
        {
            this.workers = workers;
        }

        public bool AssignWork(string jobName, int shiftLeft)
        {
            for (int i = 0; i < workers.Length; i++)
                if (workers[i].DoThisJob(jobName, shiftLeft))
                    return true;
            return false;
        }

        //uplyniecie zmiany
        public void WorkTheNextShift()
        {
            shiftNumber++;
            for (int i = 0; i < workers.Length; i++)
                if (workers[i].ShiftLeft > 0)
                {
                    workers[i].WorkOneShift();
                    honeyConsumed += workers[i].HoneyConsumptionRate();
                }
            honeyConsumed += HoneyConsumptionRate();
        }

        //logowanie pracy
        public string Raport()
        {
            string raport = null;
            raport += "Raport z dnia: " + shiftNumber + "\r\n";
            for (int i = 0; i < workers.Length; i++)
            {
                raport += "Pracownica numer: " + (i + 1) + " ";
                if (workers[i].ShiftLeft > 1)
                    raport += "wykonuje\" " + workers[i].CurrentJob + "\" jeszcze przez " + workers[i].ShiftLeft + " zmiany \r\n";
                else if (workers[i].ShiftLeft == 1)
                    raport += "wykonuje\" " + workers[i].CurrentJob + "\" jeszcze przez jedną zmianę \r\n";
                else
                    raport += "nie wykonuje żadnej pracy \r\n";
            }
            raport += "Całkowite zużycie miodu: " + honeyConsumed + " jednostek \r\n";

            return raport;
        }
    }
}
