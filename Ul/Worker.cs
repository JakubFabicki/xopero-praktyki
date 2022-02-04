using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ul
{
    class Worker
    {
        public string CurrentJob;
        public int ShiftLeft;

        private string[] jobsICanDo;
        Bank bank;

        public Worker(Bank bank, string[] task)
        {
            jobsICanDo = task;
            this.bank = bank;
        }

        public bool DoThisJob(string nextJob, int shiftLeft)
        {
            if(String.IsNullOrEmpty(CurrentJob))
            {
                for (int i = 0; i < jobsICanDo.Length; i++)
                    if (jobsICanDo[i] == nextJob)
                    {
                        CurrentJob = nextJob;
                        ShiftLeft = shiftLeft;
                        return true;
                    }
                return false;
            }
            else
                return false;
        }
        public void WorkOneShift()
        {
            ShiftLeft--;
            bank.AddMoney();
            if (ShiftLeft == 0)
                CurrentJob = null;
        }
    }
}
